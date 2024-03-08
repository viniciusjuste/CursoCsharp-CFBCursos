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
        Me.btn_canal = New System.Windows.Forms.Button()
        Me.lb_canal = New System.Windows.Forms.Label()
        Me.tb_nome = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_canal
        '
        Me.btn_canal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_canal.ForeColor = System.Drawing.Color.Black
        Me.btn_canal.Location = New System.Drawing.Point(276, 547)
        Me.btn_canal.Name = "btn_canal"
        Me.btn_canal.Size = New System.Drawing.Size(325, 89)
        Me.btn_canal.TabIndex = 0
        Me.btn_canal.Text = "CFB Cursos"
        Me.btn_canal.UseVisualStyleBackColor = False
        '
        'lb_canal
        '
        Me.lb_canal.AutoSize = True
        Me.lb_canal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_canal.Location = New System.Drawing.Point(270, 378)
        Me.lb_canal.Name = "lb_canal"
        Me.lb_canal.Size = New System.Drawing.Size(320, 32)
        Me.lb_canal.TabIndex = 1
        Me.lb_canal.Text = "Youtube.co./CFBCursos"
        '
        'tb_nome
        '
        Me.tb_nome.Location = New System.Drawing.Point(276, 195)
        Me.tb_nome.Name = "tb_nome"
        Me.tb_nome.Size = New System.Drawing.Size(325, 26)
        Me.tb_nome.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 669)
        Me.Controls.Add(Me.tb_nome)
        Me.Controls.Add(Me.lb_canal)
        Me.Controls.Add(Me.btn_canal)
        Me.Name = "Form1"
        Me.Text = "Curso de C# - CFB Cursos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_canal As Button
    Friend WithEvents lb_canal As Label
    Friend WithEvents tb_nome As TextBox
End Class
