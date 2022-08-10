<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.DatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._test_usersDataSet = New SuperSistemas._test_usersDataSet()
        Me.DatosTableAdapter = New SuperSistemas._test_usersDataSetTableAdapters.DatosTableAdapter()
        Me.TableAdapterManager = New SuperSistemas._test_usersDataSetTableAdapters.TableAdapterManager()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ingreso = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        UsuarioLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.DatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._test_usersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(82, 67)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(46, 13)
        UsuarioLabel.TabIndex = 0
        UsuarioLabel.Text = "Usuario:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(73, 105)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "password:"
        '
        'DatosBindingSource
        '
        Me.DatosBindingSource.DataMember = "Datos"
        Me.DatosBindingSource.DataSource = Me._test_usersDataSet
        '
        '_test_usersDataSet
        '
        Me._test_usersDataSet.DataSetName = "_test_usersDataSet"
        Me._test_usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatosTableAdapter
        '
        Me.DatosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DatosTableAdapter = Me.DatosTableAdapter
        Me.TableAdapterManager.UpdateOrder = SuperSistemas._test_usersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DatosBindingSource, "Usuario", True))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(134, 64)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsuarioTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DatosBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(134, 102)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'ingreso
        '
        Me.ingreso.Location = New System.Drawing.Point(76, 168)
        Me.ingreso.Name = "ingreso"
        Me.ingreso.Size = New System.Drawing.Size(75, 23)
        Me.ingreso.TabIndex = 4
        Me.ingreso.Text = "Entrar"
        Me.ingreso.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(185, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Registrarse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 281)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ingreso)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.DatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._test_usersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _test_usersDataSet As _test_usersDataSet
    Friend WithEvents DatosBindingSource As BindingSource
    Friend WithEvents DatosTableAdapter As _test_usersDataSetTableAdapters.DatosTableAdapter
    Friend WithEvents TableAdapterManager As _test_usersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents ingreso As Button
    Friend WithEvents Button1 As Button
End Class
