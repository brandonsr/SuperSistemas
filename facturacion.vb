Public Class facturacion
    Dim precio As Double
    Dim cantidad As Integer
    Dim total As Double
    Dim totalcant As Double


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Memoria RAM 4GB")
        ComboBox1.Items.Add("Tarjeta Madre EVGA X120")
        ComboBox1.Items.Add("Tarjeta Grafica NVIDIA GTX3080")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.Enabled = "False"
            TextBox2.Text = "C/F"
        Else
            TextBox2.Enabled = "True"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedItem
            Case "Memoria RAM 4GB"
                precio = 350
                TextBox4.Text = precio
            Case "Tarjeta Madre EVGA X120"
                precio = 823
                TextBox4.Text = precio
            Case "Tarjeta Grafica NVIDIA GTX3080"
                precio = 4999
                TextBox4.Text = precio
            Case Else
                TextBox4.Text = 0
        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label10.Text = TextBox1.Text
        Label11.Text = TextBox2.Text
        Label12.Text = TextBox3.Text
        ListBox1.Items.Add(ComboBox1.Text)
        ListBox2.Items.Add(TextBox4.Text)
        ListBox3.Items.Add(NumericUpDown1.Value)
        cantidad = NumericUpDown1.Value
        Button2.Visible = True
        total += precio
        totalcant += cantidad


    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label17.Text = (total * totalcant) / 3
    End Sub

    Private Sub facturacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub
End Class