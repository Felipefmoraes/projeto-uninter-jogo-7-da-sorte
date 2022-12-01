<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SetedaSorte = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.num1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.num2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.num3 = New System.Windows.Forms.Label()
        Me.Jogar_button = New System.Windows.Forms.Button()
        Me.Fechar_button = New System.Windows.Forms.Button()
        Me.ImagemResultado = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ImagemResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SetedaSorte
        '
        Me.SetedaSorte.AutoSize = True
        Me.SetedaSorte.Font = New System.Drawing.Font("Segoe UI", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetedaSorte.ForeColor = System.Drawing.Color.OrangeRed
        Me.SetedaSorte.Location = New System.Drawing.Point(245, 9)
        Me.SetedaSorte.Name = "SetedaSorte"
        Me.SetedaSorte.Size = New System.Drawing.Size(212, 37)
        Me.SetedaSorte.TabIndex = 0
        Me.SetedaSorte.Text = "Jogo 7 da Sorte"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.num1)
        Me.Panel1.Location = New System.Drawing.Point(114, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 100)
        Me.Panel1.TabIndex = 1
        '
        'num1
        '
        Me.num1.AutoSize = True
        Me.num1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num1.Location = New System.Drawing.Point(25, 26)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(46, 54)
        Me.num1.TabIndex = 0
        Me.num1.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.num2)
        Me.Panel2.Location = New System.Drawing.Point(298, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 100)
        Me.Panel2.TabIndex = 2
        '
        'num2
        '
        Me.num2.AutoSize = True
        Me.num2.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num2.Location = New System.Drawing.Point(31, 26)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(46, 54)
        Me.num2.TabIndex = 0
        Me.num2.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.num3)
        Me.Panel3.Location = New System.Drawing.Point(484, 84)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(100, 100)
        Me.Panel3.TabIndex = 3
        '
        'num3
        '
        Me.num3.AutoSize = True
        Me.num3.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num3.Location = New System.Drawing.Point(34, 26)
        Me.num3.Name = "num3"
        Me.num3.Size = New System.Drawing.Size(46, 54)
        Me.num3.TabIndex = 0
        Me.num3.Text = "0"
        '
        'Jogar_button
        '
        Me.Jogar_button.Font = New System.Drawing.Font("Segoe Print", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jogar_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Jogar_button.Location = New System.Drawing.Point(12, 297)
        Me.Jogar_button.Name = "Jogar_button"
        Me.Jogar_button.Size = New System.Drawing.Size(91, 47)
        Me.Jogar_button.TabIndex = 4
        Me.Jogar_button.Text = "Jogar"
        Me.Jogar_button.UseVisualStyleBackColor = True
        '
        'Fechar_button
        '
        Me.Fechar_button.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fechar_button.ForeColor = System.Drawing.Color.Blue
        Me.Fechar_button.Location = New System.Drawing.Point(699, 356)
        Me.Fechar_button.Name = "Fechar_button"
        Me.Fechar_button.Size = New System.Drawing.Size(75, 33)
        Me.Fechar_button.TabIndex = 5
        Me.Fechar_button.Text = "Fechar"
        Me.Fechar_button.UseVisualStyleBackColor = True
        '
        'ImagemResultado
        '
        Me.ImagemResultado.Location = New System.Drawing.Point(149, 224)
        Me.ImagemResultado.Name = "ImagemResultado"
        Me.ImagemResultado.Size = New System.Drawing.Size(413, 120)
        Me.ImagemResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagemResultado.TabIndex = 6
        Me.ImagemResultado.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 401)
        Me.Controls.Add(Me.ImagemResultado)
        Me.Controls.Add(Me.Fechar_button)
        Me.Controls.Add(Me.Jogar_button)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SetedaSorte)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Jogo 7 da Sorte"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ImagemResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SetedaSorte As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents num1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents num2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents num3 As Label
    Friend WithEvents Jogar_button As Button
    Friend WithEvents Fechar_button As Button
    Friend WithEvents ImagemResultado As PictureBox
End Class
