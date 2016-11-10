<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_IniciarSesion
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_B_Salir = New System.Windows.Forms.Button()
        Me.BTN_B_Ingresar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_B_IngresarContraseña = New System.Windows.Forms.TextBox()
        Me.TXT_B_IngresarUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BTN_B_Salir)
        Me.Panel1.Controls.Add(Me.BTN_B_Ingresar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TXT_B_IngresarContraseña)
        Me.Panel1.Controls.Add(Me.TXT_B_IngresarUsuario)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 268)
        Me.Panel1.TabIndex = 32
        '
        'BTN_B_Salir
        '
        Me.BTN_B_Salir.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_B_Salir.Location = New System.Drawing.Point(120, 204)
        Me.BTN_B_Salir.Name = "BTN_B_Salir"
        Me.BTN_B_Salir.Size = New System.Drawing.Size(94, 43)
        Me.BTN_B_Salir.TabIndex = 5
        Me.BTN_B_Salir.Text = "Salir"
        Me.BTN_B_Salir.UseVisualStyleBackColor = True
        '
        'BTN_B_Ingresar
        '
        Me.BTN_B_Ingresar.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_B_Ingresar.Location = New System.Drawing.Point(20, 204)
        Me.BTN_B_Ingresar.Name = "BTN_B_Ingresar"
        Me.BTN_B_Ingresar.Size = New System.Drawing.Size(94, 43)
        Me.BTN_B_Ingresar.TabIndex = 2
        Me.BTN_B_Ingresar.Text = "Ingresar"
        Me.BTN_B_Ingresar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ingrese su contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ingrese su usuario"
        '
        'TXT_B_IngresarContraseña
        '
        Me.TXT_B_IngresarContraseña.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_B_IngresarContraseña.Location = New System.Drawing.Point(20, 153)
        Me.TXT_B_IngresarContraseña.Name = "TXT_B_IngresarContraseña"
        Me.TXT_B_IngresarContraseña.Size = New System.Drawing.Size(194, 25)
        Me.TXT_B_IngresarContraseña.TabIndex = 2
        '
        'TXT_B_IngresarUsuario
        '
        Me.TXT_B_IngresarUsuario.Font = New System.Drawing.Font("Segoe WP", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_B_IngresarUsuario.Location = New System.Drawing.Point(20, 90)
        Me.TXT_B_IngresarUsuario.Name = "TXT_B_IngresarUsuario"
        Me.TXT_B_IngresarUsuario.Size = New System.Drawing.Size(194, 25)
        Me.TXT_B_IngresarUsuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe WP Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido"
        '
        'F_IniciarSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(273, 292)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "F_IniciarSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_IniciarSesion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BTN_B_Salir As System.Windows.Forms.Button
    Friend WithEvents BTN_B_Ingresar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_B_IngresarContraseña As System.Windows.Forms.TextBox
    Friend WithEvents TXT_B_IngresarUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
