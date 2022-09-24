Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_test_usersDataSet.Datos' Puede moverla o quitarla según sea necesario.
        Me.DatosTableAdapter.Fill(Me._test_usersDataSet.Datos)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ingreso.Click
        If Me.DatosTableAdapter.BuscarDATOS(Me._test_usersDataSet.Datos, UsuarioTextBox.Text, PasswordTextBox.Text) Then
            Form1.Show()
            Close()
        Else
            MsgBox("Usuario No Valido", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
    End Sub
End Class