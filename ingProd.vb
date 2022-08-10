Public Class ingProd
    Private Sub ingProd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Conecct As OleDb.OleDbConnection
        Dim order As OleDb.OleDbCommand
        Dim car As String
        Conecct = New OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;data source=productos.accdb")
        car = ("INSERT INTO Productos(Id,Nombre_Producto,Descripcion,Precio,Garantia,Marca) VALUES (" & TextBox1.Text & ",'" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')")
        order = New OleDb.OleDbCommand(car, Conecct)
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

    Private Sub ingProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class