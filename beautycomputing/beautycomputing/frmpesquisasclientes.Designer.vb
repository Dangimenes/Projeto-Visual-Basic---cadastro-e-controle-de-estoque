﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpesquisasClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpesquisasClientes))
        Me.btnsair = New System.Windows.Forms.Button
        Me.radiorg = New System.Windows.Forms.RadioButton
        Me.radionome = New System.Windows.Forms.RadioButton
        Me.groupnome = New System.Windows.Forms.GroupBox
        Me.txtgeral = New System.Windows.Forms.TextBox
        Me.Datacliente = New System.Windows.Forms.DataGridView
        Me.mostrartodos = New System.Windows.Forms.Button
        Me.txtrg = New System.Windows.Forms.MaskedTextBox
        Me.groupnome.SuspendLayout()
        CType(Me.Datacliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsair
        '
        Me.btnsair.Location = New System.Drawing.Point(621, 29)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(93, 45)
        Me.btnsair.TabIndex = 5
        Me.btnsair.Text = "Sair da pesquisa"
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'radiorg
        '
        Me.radiorg.AutoSize = True
        Me.radiorg.Location = New System.Drawing.Point(178, 12)
        Me.radiorg.Name = "radiorg"
        Me.radiorg.Size = New System.Drawing.Size(105, 17)
        Me.radiorg.TabIndex = 3
        Me.radiorg.Text = "Pesquisa por RG"
        Me.radiorg.UseVisualStyleBackColor = True
        '
        'radionome
        '
        Me.radionome.AutoSize = True
        Me.radionome.Checked = True
        Me.radionome.Location = New System.Drawing.Point(25, 12)
        Me.radionome.Name = "radionome"
        Me.radionome.Size = New System.Drawing.Size(115, 17)
        Me.radionome.TabIndex = 1
        Me.radionome.TabStop = True
        Me.radionome.Text = "Pesquisa por nome"
        Me.radionome.UseVisualStyleBackColor = True
        '
        'groupnome
        '
        Me.groupnome.Controls.Add(Me.txtrg)
        Me.groupnome.Controls.Add(Me.txtgeral)
        Me.groupnome.Location = New System.Drawing.Point(19, 35)
        Me.groupnome.Name = "groupnome"
        Me.groupnome.Size = New System.Drawing.Size(451, 56)
        Me.groupnome.TabIndex = 0
        Me.groupnome.TabStop = False
        '
        'txtgeral
        '
        Me.txtgeral.Location = New System.Drawing.Point(12, 19)
        Me.txtgeral.MaxLength = 255
        Me.txtgeral.Name = "txtgeral"
        Me.txtgeral.Size = New System.Drawing.Size(423, 20)
        Me.txtgeral.TabIndex = 2
        '
        'Datacliente
        '
        Me.Datacliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datacliente.Location = New System.Drawing.Point(25, 299)
        Me.Datacliente.Name = "Datacliente"
        Me.Datacliente.Size = New System.Drawing.Size(802, 332)
        Me.Datacliente.TabIndex = 6
        '
        'mostrartodos
        '
        Me.mostrartodos.Location = New System.Drawing.Point(510, 29)
        Me.mostrartodos.Name = "mostrartodos"
        Me.mostrartodos.Size = New System.Drawing.Size(93, 45)
        Me.mostrartodos.TabIndex = 4
        Me.mostrartodos.Text = "Mostrar Todos"
        Me.mostrartodos.UseVisualStyleBackColor = True
        '
        'txtrg
        '
        Me.txtrg.Location = New System.Drawing.Point(12, 19)
        Me.txtrg.Mask = "00,000,000-0"
        Me.txtrg.Name = "txtrg"
        Me.txtrg.Size = New System.Drawing.Size(423, 20)
        Me.txtrg.TabIndex = 7
        '
        'frmpesquisasClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1392, 816)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.radiorg)
        Me.Controls.Add(Me.radionome)
        Me.Controls.Add(Me.groupnome)
        Me.Controls.Add(Me.Datacliente)
        Me.Controls.Add(Me.mostrartodos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmpesquisasClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmpesquisasClientes"
        Me.groupnome.ResumeLayout(False)
        Me.groupnome.PerformLayout()
        CType(Me.Datacliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsair As System.Windows.Forms.Button
    Friend WithEvents radiorg As System.Windows.Forms.RadioButton
    Friend WithEvents radionome As System.Windows.Forms.RadioButton
    Friend WithEvents groupnome As System.Windows.Forms.GroupBox
    Friend WithEvents txtgeral As System.Windows.Forms.TextBox
    Friend WithEvents Datacliente As System.Windows.Forms.DataGridView
    Friend WithEvents mostrartodos As System.Windows.Forms.Button
    Friend WithEvents txtrg As System.Windows.Forms.MaskedTextBox
End Class
