Public Class consulproduc
    Private Sub consulproduc_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conect As OleDb.OleDbConnection
        Dim q As String
        Dim order As OleDb.OleDbDataAdapter
        Dim table As DataSet
        conect = New OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;data source=productos.accdb")
        q = "Select * from Productos order by Id"
        order = New OleDb.OleDbDataAdapter(q, conect)
        table = New DataSet()
        order.Fill(table, "Productos")
        DataGridView1.DataSource = table.Tables("Productos")
        If DataGridView1.Rows.Count = 1 Then
            MsgBox("La tabla no tiene registros", vbExclamation, "error")
        End If
    End Sub
End Class