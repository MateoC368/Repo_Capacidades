<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_valor = New System.Windows.Forms.Label()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_descubierto = New System.Windows.Forms.TextBox()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.btn_extraccion = New System.Windows.Forms.Button()
        Me.btn_deposit = New System.Windows.Forms.Button()
        Me.btn_alta = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.upd_tipo = New System.Windows.Forms.DomainUpDown()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuenta Bancaria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo De Cuenta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descubierto $"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "$"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(492, 350)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Saldo $"
        '
        'lbl_valor
        '
        Me.lbl_valor.AutoSize = True
        Me.lbl_valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor.Location = New System.Drawing.Point(559, 350)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(40, 20)
        Me.lbl_valor.TabIndex = 7
        Me.lbl_valor.Text = "0.00"
        '
        'txt_numero
        '
        Me.txt_numero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_numero.ForeColor = System.Drawing.Color.Black
        Me.txt_numero.Location = New System.Drawing.Point(147, 79)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(133, 20)
        Me.txt_numero.TabIndex = 8
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(147, 128)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(199, 20)
        Me.txt_nombre.TabIndex = 9
        '
        'txt_descubierto
        '
        Me.txt_descubierto.Enabled = False
        Me.txt_descubierto.Location = New System.Drawing.Point(147, 237)
        Me.txt_descubierto.Name = "txt_descubierto"
        Me.txt_descubierto.Size = New System.Drawing.Size(64, 20)
        Me.txt_descubierto.TabIndex = 11
        Me.txt_descubierto.Text = "0"
        '
        'txt_valor
        '
        Me.txt_valor.Enabled = False
        Me.txt_valor.Location = New System.Drawing.Point(147, 347)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(100, 20)
        Me.txt_valor.TabIndex = 12
        '
        'btn_extraccion
        '
        Me.btn_extraccion.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_extraccion.Enabled = False
        Me.btn_extraccion.FlatAppearance.BorderColor = System.Drawing.Color.PapayaWhip
        Me.btn_extraccion.ForeColor = System.Drawing.Color.Black
        Me.btn_extraccion.Location = New System.Drawing.Point(284, 338)
        Me.btn_extraccion.Name = "btn_extraccion"
        Me.btn_extraccion.Size = New System.Drawing.Size(102, 22)
        Me.btn_extraccion.TabIndex = 13
        Me.btn_extraccion.Text = "Extracción"
        Me.btn_extraccion.UseVisualStyleBackColor = False
        '
        'btn_deposit
        '
        Me.btn_deposit.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_deposit.Enabled = False
        Me.btn_deposit.ForeColor = System.Drawing.Color.Black
        Me.btn_deposit.Location = New System.Drawing.Point(284, 367)
        Me.btn_deposit.Name = "btn_deposit"
        Me.btn_deposit.Size = New System.Drawing.Size(102, 22)
        Me.btn_deposit.TabIndex = 14
        Me.btn_deposit.Text = "Deposito"
        Me.btn_deposit.UseVisualStyleBackColor = False
        '
        'btn_alta
        '
        Me.btn_alta.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btn_alta.Location = New System.Drawing.Point(496, 60)
        Me.btn_alta.Name = "btn_alta"
        Me.btn_alta.Size = New System.Drawing.Size(102, 88)
        Me.btn_alta.TabIndex = 15
        Me.btn_alta.Text = "Alta Cliente"
        Me.btn_alta.UseVisualStyleBackColor = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.Maroon
        Me.btn_cerrar.Enabled = False
        Me.btn_cerrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cerrar.Location = New System.Drawing.Point(496, 197)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(102, 79)
        Me.btn_cerrar.TabIndex = 16
        Me.btn_cerrar.Text = "Cerrar Cuenta"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'upd_tipo
        '
        Me.upd_tipo.AllowDrop = True
        Me.upd_tipo.Items.Add("CC")
        Me.upd_tipo.Items.Add("CA")
        Me.upd_tipo.Location = New System.Drawing.Point(147, 177)
        Me.upd_tipo.Name = "upd_tipo"
        Me.upd_tipo.ReadOnly = True
        Me.upd_tipo.Size = New System.Drawing.Size(120, 20)
        Me.upd_tipo.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 450)
        Me.Controls.Add(Me.upd_tipo)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_alta)
        Me.Controls.Add(Me.btn_deposit)
        Me.Controls.Add(Me.btn_extraccion)
        Me.Controls.Add(Me.txt_valor)
        Me.Controls.Add(Me.txt_descubierto)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.lbl_valor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_valor As Label
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents btn_extraccion As Button
    Friend WithEvents btn_deposit As Button
    Friend WithEvents btn_alta As Button
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents upd_tipo As DomainUpDown
    Public WithEvents txt_valor As TextBox
    Public WithEvents txt_descubierto As TextBox
End Class
