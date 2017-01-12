Imports System.Data.OleDb
Imports System.Linq 'For Radio button checking in View and Modify tabs

Public Class AdminView
    Private connect As New OleDbConnection
    Private command As New OleDbCommand
    Public currentUser As Integer

    Private Sub OpenConnection()
        '"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\CSC4251.accdb"
        connect = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CSC4251.accdb")
        connect.Open()
    End Sub

    Private Sub AdminView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CSC4251DataSet.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.CSC4251DataSet.Supplier)
        'TODO: This line of code loads data into the 'CSC4251DataSet.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.CSC4251DataSet.Books)
        'TODO: This line of code loads data into the 'CSC4251DataSet.Author' table. You can move, or remove it, as needed.
        Me.AuthorTableAdapter.Fill(Me.CSC4251DataSet.Author)
        'TODO: This line of code loads data into the 'CSC4251DataSet.Order' table. You can move, or remove it, as needed.
        Me.OrderTableAdapter.Fill(Me.CSC4251DataSet.Order)
        'TODO: This line of code loads data into the 'CSC4251DataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.CSC4251DataSet.Customer)
        'Dim loginForm As New Login
        'loginForm.Show()
        'Me.Hide()
        'TODO: This line of code loads data into the 'CSC4251DataSet.Order' table. You can move, or remove it, as needed.
        Me.OrderTableAdapter.Fill(Me.CSC4251DataSet.Order)
        'TODO: This line of code loads data into the 'CSC4251DataSet.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.CSC4251DataSet.Books)
        DisplayCustomerBooks()
        DisplayCustomerShoppingCart()
        DisplayProfile()
    End Sub

    Private Sub SearchText_TextChanged(sender As Object, e As EventArgs) Handles SearchText.TextChanged
        DisplayCustomerBooks()
    End Sub

    Private Sub DisplayCustomerBooks()
        Dim browseTable As New DataTable("BrowseTable")
        OpenConnection()

        Dim dapt As New OleDbDataAdapter("Select ISBN, Title, User_Reviews, Pub_Date, Supplied_By, Price FROM Books WHERE Title Like '%" & SearchText.Text & "%' OR ISBN Like '" & SearchText.Text & "%'", connect)
        dapt.Fill(browseTable)
        DataGridViewCustomerBrowse.Columns.Clear()
        DataGridViewCustomerBrowse.AutoGenerateColumns = True
        DataGridViewCustomerBrowse.DataSource = browseTable
        DataGridViewCustomerBrowse.Columns("Price").DefaultCellStyle.Format = "c"

        Dim addbtn As New DataGridViewButtonColumn
        addbtn.HeaderText = "Add to Cart"
        addbtn.Text = "+"
        addbtn.UseColumnTextForButtonValue = True
        addbtn.Name = "BtnAdd"
        DataGridViewCustomerBrowse.Columns.Insert(6, addbtn)

        connect.Close()
    End Sub

    Private Sub DisplayCustomerShoppingCart()
        Dim shoppingCartTable As New DataTable("ShoppingCartTable")
        OpenConnection()

        Dim SQLStatement As String =
            "SELECT Order_Item.ID, Books.Title, Books.Price
            FROM (Customer 
            INNER JOIN [Order] ON Customer.ID = Order.Placed_By) 
            INNER JOIN (Books 
            INNER JOIN Order_Item ON Books.ISBN = Order_Item.Book_ISBN) ON Order.ID = Order_Item.Belongs_To
            WHERE (((Customer.ID) = " & currentUser & "));"

        Dim dapt As New OleDbDataAdapter(SQLStatement, connect)
        dapt.Fill(shoppingCartTable)
        DataGridViewCustomerShoppingCart.Columns.Clear()
        DataGridViewCustomerShoppingCart.AutoGenerateColumns = True
        DataGridViewCustomerShoppingCart.DataSource = shoppingCartTable

        DataGridViewCustomerShoppingCart.Columns("Price").DefaultCellStyle.Format = "c"
        DataGridViewCustomerShoppingCart.Columns("ID").Visible = False

        ' Add the remove item buttons
        Dim removebtn As New DataGridViewButtonColumn
        removebtn.HeaderText = "Remove from Cart"
        removebtn.Text = "-"
        removebtn.UseColumnTextForButtonValue = True
        removebtn.Name = "BtnRemove"
        DataGridViewCustomerShoppingCart.Columns.Insert(DataGridViewCustomerShoppingCart.Columns.Count, removebtn)

        connect.Close()
    End Sub

    Private Sub DataGridViewCustomerBrowse_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCustomerBrowse.CellContentClick
        Dim colName As String = DataGridViewCustomerBrowse.Columns(e.ColumnIndex).Name
        If colName = "BtnAdd" Then
            Dim ISBN As String = DataGridViewCustomerBrowse.Rows(e.RowIndex).Cells(0).Value
            AddToOrder(ISBN)
        End If
    End Sub

    Private Sub DataGridViewCustomerShoppingCart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCustomerShoppingCart.CellContentClick
        Dim colName As String = DataGridViewCustomerShoppingCart.Columns(e.ColumnIndex).Name
        If colName = "BtnRemove" Then
            DisplayCustomerShoppingCart()
            Dim OrderItemID As String = DataGridViewCustomerShoppingCart.Rows(e.RowIndex).Cells(0).Value
            RemoveFromOrder(OrderItemID)
        End If
    End Sub

    Private Function getNewID(ByVal TableName) As Integer
        Dim getMaxID As String =
            "SELECT MAX(ID) FROM [" & TableName & "]"

        Dim command As New OleDbCommand(getMaxID, connect)
        Dim reader As OleDbDataReader = command.ExecuteReader()

        If reader.Read() Then
            Return reader(0) + 1
        Else
            reader.Close()
            Return 0
        End If
    End Function

    Private Sub RemoveFromOrder(ByVal OrderItemID As String)
        OpenConnection()
        Dim removeOrderItemQuery As String =
            "DELETE FROM Order_Item WHERE Order_Item.ID = " & OrderItemID & ";"
        Dim removeOrder As New OleDbCommand(removeOrderItemQuery, connect)
        removeOrder.ExecuteNonQuery()
        connect.Close()

        DisplayCustomerShoppingCart()
    End Sub

    Private Sub AddToOrder(ByVal ISBN As String)

        Dim shoppingCartTable As New DataTable("ShoppingCartTable")
        OpenConnection()

        Dim getOrderQuery As String =
            "SELECT Order.ID 
            FROM [Order] 
            WHERE Placed_By = " & currentUser & ";"
        Dim getOrder As New OleDbCommand(getOrderQuery, connect)
        Dim reader As OleDbDataReader = getOrder.ExecuteReader()
        Dim order As Integer
        If reader.Read() Then ' if order exists, put the order item in the existing order
            order = reader(0)
        Else ' else create new order
            order = getNewID("Order")
            Dim CreateOrderQuery As String =
                "INSERT INTO [Order] (ID, Placed_By, Order_Value, Order_Date)
                 VALUES (?,?,?,?);"
            Dim CreateOrder As New OleDbCommand(CreateOrderQuery, connect)
            CreateOrder.Parameters.AddWithValue("@ID", order)
            CreateOrder.Parameters.AddWithValue("@Placed_By", currentUser)
            CreateOrder.Parameters.AddWithValue("@Order_Value", 0)
            CreateOrder.Parameters.AddWithValue("@Order_Date", String.Format("{0:dd/MM/yyyy}", DateTime.Today))
            CreateOrder.ExecuteNonQuery()
        End If
        reader.Close()

        Dim CreateOrderItemQuery As String =
            "INSERT INTO Order_Item (ID, Belongs_To, Book_ISBN)
            VALUES (?,?,?);"

        Dim createOrderItem As New OleDbCommand(CreateOrderItemQuery, connect)
        createOrderItem.Parameters.AddWithValue("@ID", getNewID("Order_Item"))
        createOrderItem.Parameters.AddWithValue("@Belongs_To", order)
        createOrderItem.Parameters.AddWithValue("@Book_ISBN", ISBN)

        createOrderItem.ExecuteNonQuery()
        connect.Close()
        MessageBox.Show(String.Format("Added " & ISBN & " to order"))
        DisplayCustomerShoppingCart()
    End Sub

    Private Sub DisplayProfile()
        Dim getProfileQuery As String =
            "SELECT Customer.FName, Customer.LName, Contact_Details.Phone, Contact_Details.Email, Contact_Details.Address 
            FROM Customer INNER JOIN Contact_Details ON Customer.Contact_Details_ID = Contact_Details.ID 
            WHERE Customer.ID = " & currentUser
        OpenConnection()
        Dim getProfile As New OleDbCommand(getProfileQuery, connect)
        Dim reader As OleDbDataReader = getProfile.ExecuteReader()
        reader.Read()
        TBFName.Text = reader.GetValue(0)
        TBLName.Text = reader.GetValue(1)
        TBPhone.Text = reader.GetValue(2)
        TBEmail.Text = Split(reader.GetValue(3), "#")(0)
        TBAddress.Text = reader.GetValue(4)
        connect.Close()
    End Sub

    Private Function CalculateOrder(ByVal OrderID As String) As Double
        Dim sumOrderQuery As String =
            "SELECT SUM(Books.Price) 
            From Books 
            INNER JOIN Order_Item On Books.ISBN = Order_Item.Book_ISBN 
            WHERE Order_Item.Belongs_To = " & OrderID
        OpenConnection()
        Dim sumOrder As New OleDbCommand(sumOrderQuery, connect)
        Dim reader As OleDbDataReader = sumOrder.ExecuteReader()
        reader.Read()
        Dim sum As Double = reader(0)
        reader.Close()
        connect.Close()
        Return sum
    End Function

    Private Sub DeleteOrder(ByVal OrderId As String)
        OpenConnection()
        Dim deleteOrderItemsQuery As String =
            "DELETE FROM Order_Item WHERE Order_Item.Belongs_To = " & OrderId

        Dim deleteOrderItems As New OleDbCommand(deleteOrderItemsQuery, connect)
        deleteOrderItems.ExecuteNonQuery()

        Dim deleteOrderQuery As String =
            "DELETE FROM [Order] WHERE ID = " & OrderId
        Dim deleteOrder As New OleDbCommand(deleteOrderQuery, connect)
        deleteOrder.ExecuteNonQuery()

        DisplayCustomerShoppingCart()
        connect.Close()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.CustomerTableAdapter.FillBy(Me.CSC4251DataSet.Customer)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnCheckOut_Click(sender As Object, e As EventArgs) Handles BtnCheckOut.Click
        OpenConnection()
        Dim getOrderQuery As String =
            "SELECT Order.ID 
            FROM [Order] 
            WHERE Placed_By = " & currentUser & ";"
        Dim getOrder As New OleDbCommand(getOrderQuery, connect)
        Dim reader As OleDbDataReader = getOrder.ExecuteReader()
        Dim order As Integer
        If reader.Read() Then ' if order exists
            order = reader(0)
            MessageBox.Show(String.Format("Thank you for your order. Your total is " & FormatCurrency(CalculateOrder(order))))
            DeleteOrder(order)
        Else
            ' do nothing
        End If
        connect.Close()
    End Sub

    Private Sub BTUpdate_Click(sender As Object, e As EventArgs) Handles BTUpdate.Click
        Dim setProfileQuery As String =
            "UPDATE Customer 
            SET FName = '" & TBFName.Text &
            "', LName = '" & TBLName.Text & "'
            WHERE Customer.ID = " & currentUser

        Dim setProfileQuery2 As String =
            "UPDATE Contact_Details INNER JOIN Customer ON Customer.Contact_Details_ID = Contact_Details.ID 
            SET Phone = '" & TBPhone.Text &
            "', Email = '" & TBEmail.Text &
            "', Address = '" & TBAddress.Text & "'
            WHERE Customer.ID = " & currentUser

        OpenConnection()
        Dim setProfile As New OleDbCommand()
        setProfile.Connection = connect
        setProfile.CommandText = setProfileQuery
        setProfile.ExecuteNonQuery()

        setProfile.CommandText = setProfileQuery2
        setProfile.ExecuteNonQuery()
        connect.Close()
        DisplayProfile()

        LBSaved.Visible = True
        ' Timer1.Start()
    End Sub

    ' Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    Threading.Thread.Sleep(3000)
    '   LBSaved.Visible = False
    'Timer1.Stop()
    ' End Sub

    Private Sub OrderQToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Order_ItemTableAdapter.OrderQ(Me.CSC4251DataSet.Order_Item)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class