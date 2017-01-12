<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BrowseTab = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridViewCustomerBrowse = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SearchText = New System.Windows.Forms.TextBox()
        Me.CartTab = New System.Windows.Forms.TabPage()
        Me.BtnCheckOut = New System.Windows.Forms.Button()
        Me.DataGridViewCustomerShoppingCart = New System.Windows.Forms.DataGridView()
        Me.EditProfileTab = New System.Windows.Forms.TabPage()
        Me.LBSaved = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTUpdate = New System.Windows.Forms.Button()
        Me.TBAddress = New System.Windows.Forms.TextBox()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.TBPhone = New System.Windows.Forms.TextBox()
        Me.TBLName = New System.Windows.Forms.TextBox()
        Me.TBFName = New System.Windows.Forms.TextBox()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CSC4251DataSet = New WindowsApplication1.CSC4251DataSet()
        Me.BooksTableAdapter = New WindowsApplication1.CSC4251DataSetTableAdapters.BooksTableAdapter()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderTableAdapter = New WindowsApplication1.CSC4251DataSetTableAdapters.OrderTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.BrowseTab.SuspendLayout()
        CType(Me.DataGridViewCustomerBrowse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CartTab.SuspendLayout()
        CType(Me.DataGridViewCustomerShoppingCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EditProfileTab.SuspendLayout()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSC4251DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.BrowseTab)
        Me.TabControl1.Controls.Add(Me.CartTab)
        Me.TabControl1.Controls.Add(Me.EditProfileTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(1, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(818, 525)
        Me.TabControl1.TabIndex = 4
        '
        'BrowseTab
        '
        Me.BrowseTab.Controls.Add(Me.Label6)
        Me.BrowseTab.Controls.Add(Me.DataGridViewCustomerBrowse)
        Me.BrowseTab.Controls.Add(Me.SearchText)
        Me.BrowseTab.Location = New System.Drawing.Point(4, 22)
        Me.BrowseTab.Name = "BrowseTab"
        Me.BrowseTab.Padding = New System.Windows.Forms.Padding(3)
        Me.BrowseTab.Size = New System.Drawing.Size(810, 499)
        Me.BrowseTab.TabIndex = 0
        Me.BrowseTab.Text = "Browse"
        Me.BrowseTab.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Search by Title or ISBN"
        '
        'DataGridViewCustomerBrowse
        '
        Me.DataGridViewCustomerBrowse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCustomerBrowse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewCustomerBrowse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomerBrowse.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGridViewCustomerBrowse.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewCustomerBrowse.Location = New System.Drawing.Point(3, 64)
        Me.DataGridViewCustomerBrowse.Name = "DataGridViewCustomerBrowse"
        Me.DataGridViewCustomerBrowse.Size = New System.Drawing.Size(804, 432)
        Me.DataGridViewCustomerBrowse.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Add"
        Me.Column1.Name = "Column1"
        Me.Column1.Text = "Add"
        Me.Column1.UseColumnTextForButtonValue = True
        '
        'SearchText
        '
        Me.SearchText.Location = New System.Drawing.Point(7, 38)
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(795, 20)
        Me.SearchText.TabIndex = 0
        '
        'CartTab
        '
        Me.CartTab.Controls.Add(Me.BtnCheckOut)
        Me.CartTab.Controls.Add(Me.DataGridViewCustomerShoppingCart)
        Me.CartTab.Location = New System.Drawing.Point(4, 22)
        Me.CartTab.Name = "CartTab"
        Me.CartTab.Padding = New System.Windows.Forms.Padding(3)
        Me.CartTab.Size = New System.Drawing.Size(810, 499)
        Me.CartTab.TabIndex = 1
        Me.CartTab.Text = "Shopping Cart"
        Me.CartTab.UseVisualStyleBackColor = True
        '
        'BtnCheckOut
        '
        Me.BtnCheckOut.Location = New System.Drawing.Point(599, 444)
        Me.BtnCheckOut.Name = "BtnCheckOut"
        Me.BtnCheckOut.Size = New System.Drawing.Size(112, 40)
        Me.BtnCheckOut.TabIndex = 1
        Me.BtnCheckOut.Text = "Check Out"
        Me.BtnCheckOut.UseVisualStyleBackColor = True
        '
        'DataGridViewCustomerShoppingCart
        '
        Me.DataGridViewCustomerShoppingCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCustomerShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomerShoppingCart.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridViewCustomerShoppingCart.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewCustomerShoppingCart.Name = "DataGridViewCustomerShoppingCart"
        Me.DataGridViewCustomerShoppingCart.Size = New System.Drawing.Size(804, 435)
        Me.DataGridViewCustomerShoppingCart.TabIndex = 0
        '
        'EditProfileTab
        '
        Me.EditProfileTab.Controls.Add(Me.LBSaved)
        Me.EditProfileTab.Controls.Add(Me.Label5)
        Me.EditProfileTab.Controls.Add(Me.Label4)
        Me.EditProfileTab.Controls.Add(Me.Label3)
        Me.EditProfileTab.Controls.Add(Me.Label2)
        Me.EditProfileTab.Controls.Add(Me.Label1)
        Me.EditProfileTab.Controls.Add(Me.BTUpdate)
        Me.EditProfileTab.Controls.Add(Me.TBAddress)
        Me.EditProfileTab.Controls.Add(Me.TBEmail)
        Me.EditProfileTab.Controls.Add(Me.TBPhone)
        Me.EditProfileTab.Controls.Add(Me.TBLName)
        Me.EditProfileTab.Controls.Add(Me.TBFName)
        Me.EditProfileTab.Location = New System.Drawing.Point(4, 22)
        Me.EditProfileTab.Name = "EditProfileTab"
        Me.EditProfileTab.Size = New System.Drawing.Size(810, 499)
        Me.EditProfileTab.TabIndex = 2
        Me.EditProfileTab.Text = "Edit Profile"
        Me.EditProfileTab.UseVisualStyleBackColor = True
        '
        'LBSaved
        '
        Me.LBSaved.AutoSize = True
        Me.LBSaved.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LBSaved.Location = New System.Drawing.Point(364, 399)
        Me.LBSaved.Name = "LBSaved"
        Me.LBSaved.Size = New System.Drawing.Size(70, 13)
        Me.LBSaved.TabIndex = 11
        Me.LBSaved.Text = "Profile Saved"
        Me.LBSaved.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(236, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(376, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(236, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Phone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(376, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "First Name"
        '
        'BTUpdate
        '
        Me.BTUpdate.Location = New System.Drawing.Point(359, 347)
        Me.BTUpdate.Name = "BTUpdate"
        Me.BTUpdate.Size = New System.Drawing.Size(83, 49)
        Me.BTUpdate.TabIndex = 5
        Me.BTUpdate.Text = "Save"
        Me.BTUpdate.UseVisualStyleBackColor = True
        '
        'TBAddress
        '
        Me.TBAddress.Location = New System.Drawing.Point(236, 259)
        Me.TBAddress.Name = "TBAddress"
        Me.TBAddress.Size = New System.Drawing.Size(323, 20)
        Me.TBAddress.TabIndex = 4
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(376, 209)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(183, 20)
        Me.TBEmail.TabIndex = 3
        '
        'TBPhone
        '
        Me.TBPhone.Location = New System.Drawing.Point(236, 209)
        Me.TBPhone.Name = "TBPhone"
        Me.TBPhone.Size = New System.Drawing.Size(100, 20)
        Me.TBPhone.TabIndex = 2
        '
        'TBLName
        '
        Me.TBLName.Location = New System.Drawing.Point(376, 159)
        Me.TBLName.Name = "TBLName"
        Me.TBLName.Size = New System.Drawing.Size(183, 20)
        Me.TBLName.TabIndex = 1
        '
        'TBFName
        '
        Me.TBFName.Location = New System.Drawing.Point(236, 159)
        Me.TBFName.Name = "TBFName"
        Me.TBFName.Size = New System.Drawing.Size(100, 20)
        Me.TBFName.TabIndex = 0
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "Books"
        Me.BooksBindingSource.DataSource = Me.CSC4251DataSet
        '
        'CSC4251DataSet
        '
        Me.CSC4251DataSet.DataSetName = "CSC4251DataSet"
        Me.CSC4251DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "Order"
        Me.OrderBindingSource.DataSource = Me.CSC4251DataSet
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(810, 499)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Logout"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(433, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Log Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 528)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Books (Customer)"
        Me.TabControl1.ResumeLayout(False)
        Me.BrowseTab.ResumeLayout(False)
        Me.BrowseTab.PerformLayout()
        CType(Me.DataGridViewCustomerBrowse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CartTab.ResumeLayout(False)
        CType(Me.DataGridViewCustomerShoppingCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EditProfileTab.ResumeLayout(False)
        Me.EditProfileTab.PerformLayout()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSC4251DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents BrowseTab As TabPage
    Friend WithEvents SearchText As TextBox
    Friend WithEvents CartTab As TabPage
    Friend WithEvents EditProfileTab As TabPage
    Friend WithEvents DataGridViewCustomerBrowse As DataGridView
    Friend WithEvents CSC4251DataSet As CSC4251DataSet
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents BooksTableAdapter As CSC4251DataSetTableAdapters.BooksTableAdapter
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewCustomerShoppingCart As DataGridView
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents OrderTableAdapter As CSC4251DataSetTableAdapters.OrderTableAdapter
    Friend WithEvents BtnCheckOut As Button
    Friend WithEvents TBAddress As TextBox
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents TBPhone As TextBox
    Friend WithEvents TBLName As TextBox
    Friend WithEvents TBFName As TextBox
    Friend WithEvents BTUpdate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBSaved As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button1 As Button
End Class
