Imports System.Data.OleDb
Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Login with the name selected from the name selected from the ComboBox
        Dim connec = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CSC4251.accdb")
        connec.Open()
        Dim getUserQuery As String = "Select * from Customer WHERE ID = " & TextBox1.Text
        Dim getQ As New OleDbCommand(getUserQuery, connec)
        Dim dreader As OleDbDataReader = getQ.ExecuteReader
        dreader.Read()
        Dim userint As Integer = dreader(0)
        Dim isadmin = dreader.GetValue(4)
        If isadmin = True Then
            AdminView.currentUser = userint
            AdminView.Show()
            Me.Hide()
        Else
            Form1.currentUser = userint
            Form1.Show()
            Me.Hide()
        End If
        Me.Hide()
        connec.Close()
    End Sub
End Class