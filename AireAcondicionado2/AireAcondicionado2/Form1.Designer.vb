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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chk_split = New System.Windows.Forms.CheckBox()
        Me.rbtn_friosol = New System.Windows.Forms.RadioButton()
        Me.rbtn_frioca = New System.Windows.Forms.RadioButton()
        Me.lbl_temperatura = New System.Windows.Forms.Label()
        Me.btn_alta = New System.Windows.Forms.Button()
        Me.btn_max = New System.Windows.Forms.Button()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_mas = New System.Windows.Forms.Button()
        Me.btn_menos = New System.Windows.Forms.Button()
        Me.btn_power = New System.Windows.Forms.Button()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.txt_pais = New System.Windows.Forms.TextBox()
        Me.txt_frigorias = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.btn_max)
        Me.Panel2.Controls.Add(Me.btn_min)
        Me.Panel2.Controls.Add(Me.txt_modelo)
        Me.Panel2.Controls.Add(Me.btn_mas)
        Me.Panel2.Controls.Add(Me.btn_menos)
        Me.Panel2.Controls.Add(Me.btn_power)
        Me.Panel2.Controls.Add(Me.lbl_temperatura)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(425, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(310, 381)
        Me.Panel2.TabIndex = 1
        Me.Panel2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Modelo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.txt_frigorias)
        Me.Panel1.Controls.Add(Me.txt_pais)
        Me.Panel1.Controls.Add(Me.txt_marca)
        Me.Panel1.Controls.Add(Me.btn_alta)
        Me.Panel1.Controls.Add(Me.rbtn_frioca)
        Me.Panel1.Controls.Add(Me.rbtn_friosol)
        Me.Panel1.Controls.Add(Me.chk_split)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(60, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 381)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Pais"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Frigorias"
        '
        'chk_split
        '
        Me.chk_split.AutoSize = True
        Me.chk_split.Location = New System.Drawing.Point(65, 165)
        Me.chk_split.Name = "chk_split"
        Me.chk_split.Size = New System.Drawing.Size(64, 28)
        Me.chk_split.TabIndex = 5
        Me.chk_split.Text = "Split"
        Me.chk_split.UseVisualStyleBackColor = True
        '
        'rbtn_friosol
        '
        Me.rbtn_friosol.AutoSize = True
        Me.rbtn_friosol.Checked = True
        Me.rbtn_friosol.Location = New System.Drawing.Point(35, 286)
        Me.rbtn_friosol.Name = "rbtn_friosol"
        Me.rbtn_friosol.Size = New System.Drawing.Size(104, 28)
        Me.rbtn_friosol.TabIndex = 6
        Me.rbtn_friosol.TabStop = True
        Me.rbtn_friosol.Text = "Frio Solo"
        Me.rbtn_friosol.UseVisualStyleBackColor = True
        '
        'rbtn_frioca
        '
        Me.rbtn_frioca.AutoSize = True
        Me.rbtn_frioca.Location = New System.Drawing.Point(35, 320)
        Me.rbtn_frioca.Name = "rbtn_frioca"
        Me.rbtn_frioca.Size = New System.Drawing.Size(110, 28)
        Me.rbtn_frioca.TabIndex = 7
        Me.rbtn_frioca.TabStop = True
        Me.rbtn_frioca.Text = "Frio/Calor"
        Me.rbtn_frioca.UseVisualStyleBackColor = True
        '
        'lbl_temperatura
        '
        Me.lbl_temperatura.AutoSize = True
        Me.lbl_temperatura.BackColor = System.Drawing.Color.Cyan
        Me.lbl_temperatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_temperatura.Location = New System.Drawing.Point(107, 144)
        Me.lbl_temperatura.Name = "lbl_temperatura"
        Me.lbl_temperatura.Size = New System.Drawing.Size(87, 73)
        Me.lbl_temperatura.TabIndex = 3
        Me.lbl_temperatura.Text = " - "
        '
        'btn_alta
        '
        Me.btn_alta.Enabled = False
        Me.btn_alta.Location = New System.Drawing.Point(202, 298)
        Me.btn_alta.Name = "btn_alta"
        Me.btn_alta.Size = New System.Drawing.Size(87, 37)
        Me.btn_alta.TabIndex = 8
        Me.btn_alta.Text = "Alta"
        Me.btn_alta.UseVisualStyleBackColor = True
        '
        'btn_max
        '
        Me.btn_max.Location = New System.Drawing.Point(181, 298)
        Me.btn_max.Name = "btn_max"
        Me.btn_max.Size = New System.Drawing.Size(69, 37)
        Me.btn_max.TabIndex = 9
        Me.btn_max.Text = "Max"
        Me.btn_max.UseVisualStyleBackColor = True
        '
        'btn_min
        '
        Me.btn_min.Location = New System.Drawing.Point(53, 298)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(70, 37)
        Me.btn_min.TabIndex = 10
        Me.btn_min.Text = "Min"
        Me.btn_min.UseVisualStyleBackColor = True
        '
        'btn_mas
        '
        Me.btn_mas.Location = New System.Drawing.Point(226, 236)
        Me.btn_mas.Name = "btn_mas"
        Me.btn_mas.Size = New System.Drawing.Size(44, 37)
        Me.btn_mas.TabIndex = 11
        Me.btn_mas.Text = "+"
        Me.btn_mas.UseVisualStyleBackColor = True
        '
        'btn_menos
        '
        Me.btn_menos.Location = New System.Drawing.Point(39, 236)
        Me.btn_menos.Name = "btn_menos"
        Me.btn_menos.Size = New System.Drawing.Size(39, 37)
        Me.btn_menos.TabIndex = 12
        Me.btn_menos.Text = "-"
        Me.btn_menos.UseVisualStyleBackColor = True
        '
        'btn_power
        '
        Me.btn_power.Location = New System.Drawing.Point(103, 236)
        Me.btn_power.Name = "btn_power"
        Me.btn_power.Size = New System.Drawing.Size(100, 37)
        Me.btn_power.TabIndex = 13
        Me.btn_power.Text = "POWER"
        Me.btn_power.UseVisualStyleBackColor = True
        '
        'txt_marca
        '
        Me.txt_marca.Location = New System.Drawing.Point(169, 34)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(100, 29)
        Me.txt_marca.TabIndex = 9
        '
        'txt_modelo
        '
        Me.txt_modelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_modelo.Location = New System.Drawing.Point(150, 39)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.ReadOnly = True
        Me.txt_modelo.Size = New System.Drawing.Size(141, 21)
        Me.txt_modelo.TabIndex = 10
        '
        'txt_pais
        '
        Me.txt_pais.Location = New System.Drawing.Point(169, 121)
        Me.txt_pais.Name = "txt_pais"
        Me.txt_pais.Size = New System.Drawing.Size(100, 29)
        Me.txt_pais.TabIndex = 11
        '
        'txt_frigorias
        '
        Me.txt_frigorias.Location = New System.Drawing.Point(169, 75)
        Me.txt_frigorias.Name = "txt_frigorias"
        Me.txt_frigorias.Size = New System.Drawing.Size(100, 29)
        Me.txt_frigorias.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_max As Button
    Friend WithEvents btn_min As Button
    Friend WithEvents btn_mas As Button
    Friend WithEvents btn_menos As Button
    Friend WithEvents btn_power As Button
    Friend WithEvents lbl_temperatura As Label
    Friend WithEvents btn_alta As Button
    Friend WithEvents rbtn_frioca As RadioButton
    Friend WithEvents rbtn_friosol As RadioButton
    Friend WithEvents chk_split As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_modelo As TextBox
    Friend WithEvents txt_frigorias As TextBox
    Friend WithEvents txt_pais As TextBox
    Friend WithEvents txt_marca As TextBox
End Class
