Public Class modiprod
    Private Sub modiprod_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connect As OleDb.OleDbConnection
        Dim Query As String
        Dim order As OleDb.OleDbCommand
        connect = New OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;data source=productos.accdb")
        Query = "Update Productos Set Nombre_Producto='" & TextBox3.Text & "',Descripcion='" & TextBox2.Text & "',Precio='" & TextBox4.Text & "',Garantia='" & TextBox5.Text & "',Marca='" & TextBox6.Text & "' Where Id=" & TextBox1.Text & ";"
        order = New OleDb.OleDbCommand(Query, connect)
        order.Connection.Open()
        Try
            order.ExecuteNonQuery()
            MsgBox("Grabacion Exitosa", 16, "Productos")
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Verifique: " & vbCrLf & "1 La clave ya existe" & vbCrLf & "2 Tipos incorrectos, ejemplo:" & "Asignado textos en espacio numerico")
            TextBox1.Focus()
        End Try
        order.Connection.Close()
    End Sub

    Private Sub modiprod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As OleDb.OleDbConnection
        Dim Query As String
        Dim order As OleDb.OleDbDataAdapter
        Dim table As DataSet
        connect = New OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;data source=productos.accdb")
        Query = "Select  * from  Productos where 1"
        order = New OleDb.OleDbDataAdapter(Query, connect)
        table = New DataSet()
        order.Fill(table, "Productos")
        DataGridView1.DataSource = table.Tables("Productos")
        If DataGridView1.Rows.Count = 1 Then
            MsgBox("La tabla no tiene registros", vbExclamation, "Error")
        End If
    End Sub
End Class