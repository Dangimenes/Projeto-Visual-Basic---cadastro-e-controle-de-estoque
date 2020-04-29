<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpesquisaservico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpesquisaservico))
        Me.btnsair = New System.Windows.Forms.Button
        Me.radiocodigo = New System.Windows.Forms.RadioButton
        Me.radioservico = New System.Windows.Forms.RadioButton
        Me.groupnome = New System.Windows.Forms.GroupBox
        Me.txtnome = New System.Windows.Forms.TextBox
        Me.txtcodservico = New System.Windows.Forms.MaskedTextBox
        Me.Dataservico = New System.Windows.Forms.DataGridView
        Me.mostrartodos = New System.Windows.Forms.Button
        Me.groupnome.SuspendLayout()
        CType(Me.Dataservico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsair
        '
        Me.btnsair.Location = New System.Drawing.Point(618, 32)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(93, 45)
        Me.btnsair.TabIndex = 5
        Me.btnsair.Text = "Sair da pesquisa"
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'radiocodigo
        '
        Me.radiocodigo.AutoSize = True
        Me.radiocodigo.Location = New System.Drawing.Point(175, 15)
        Me.radiocodigo.Name = "radiocodigo"
        Me.radiocodigo.Size = New System.Drawing.Size(158, 17)
        Me.radiocodigo.TabIndex = 3
        Me.radiocodigo.Text = "Pesquisa por codigo servico"
        Me.radiocodigo.UseVisualStyleBackColor = True
        '
        'radioservico
        '
        Me.radioservico.AutoSize = True
        Me.radioservico.Checked = True
        Me.radioservico.Location = New System.Drawing.Point(22, 15)
        Me.radioservico.Name = "radioservico"
        Me.radioservico.Size = New System.Drawing.Size(125, 17)
        Me.radioservico.TabIndex = 1
        Me.radioservico.TabStop = True
        Me.radioservico.Text = "Pesquisa por Servico"
        Me.radioservico.UseVisualStyleBackColor = True
        '
        'groupnome
        '
        Me.groupnome.Controls.Add(Me.txtnome)
        Me.groupnome.Controls.Add(Me.txtcodservico)
        Me.groupnome.Location = New System.Drawing.Point(12, 55)
        Me.groupnome.Name = "groupnome"
        Me.groupnome.Size = New System.Drawing.Size(451, 56)
        Me.groupnome.TabIndex = 0
        Me.groupnome.TabStop = False
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(16, 19)
        Me.txtnome.MaxLength = 255
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(423, 20)
        Me.txtnome.TabIndex = 2
        '
        'txtcodservico
        '
        Me.txtcodservico.Location = New System.Drawing.Point(16, 19)
        Me.txtcodservico.Name = "txtcodservico"
        Me.txtcodservico.Size = New System.Drawing.Size(423, 20)
        Me.txtcodservico.TabIndex = 7
        '
        'Dataservico
        '
        Me.Dataservico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dataservico.Location = New System.Drawing.Point(28, 414)
        Me.Dataservico.Name = "Dataservico"
        Me.Dataservico.Size = New System.Drawing.Size(802, 332)
        Me.Dataservico.TabIndex = 6
        '
        'mostrartodos
        '
        Me.mostrartodos.Location = New System.Drawing.Point(507, 32)
        Me.mostrartodos.Name = "mostrartodos"
        Me.mostrartodos.Size = New System.Drawing.Size(93, 45)
        Me.mostrartodos.TabIndex = 4
        Me.mostrartodos.Text = "Mostrar Todos"
        Me.mostrartodos.UseVisualStyleBackColor = True
        '
        'frmpesquisaservico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1392, 816)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.radiocodigo)
        Me.Controls.Add(Me.radioservico)
        Me.Controls.Add(Me.groupnome)
        Me.Controls.Add(Me.Dataservico)
        Me.Controls.Add(Me.mostrartodos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmpesquisaservico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmpesquisaservico"
        Me.groupnome.ResumeLayout(False)
        Me.groupnome.PerformLayout()
        CType(Me.Dataservico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsair As System.Windows.Forms.Button
    Friend WithEvents radiocodigo As System.Windows.Forms.RadioButton
    Friend WithEvents radioservico As System.Windows.Forms.RadioButton
    Friend WithEvents groupnome As System.Windows.Forms.GroupBox
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents Dataservico As System.Windows.Forms.DataGridView
    Friend WithEvents mostrartodos As System.Windows.Forms.Button
    Friend WithEvents txtcodservico As System.Windows.Forms.MaskedTextBox
End Class
