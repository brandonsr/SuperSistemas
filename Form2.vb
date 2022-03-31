Public Class Form2
    Private Sub DatosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DatosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DatosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._test_usersDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_test_usersDataSet.Datos' Puede moverla o quitarla según sea necesario.
        Me.DatosTableAdapter.Fill(Me._test_usersDataSet.Datos)
        'añadiendo usuarios'
        Me.DatosBindingSource.AddNew()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DatosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._test_usersDataSet)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login.Show()
        Close()
    End Sub
End Class