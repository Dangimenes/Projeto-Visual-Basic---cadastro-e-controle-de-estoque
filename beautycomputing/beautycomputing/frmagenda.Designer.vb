<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmagenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmagenda))
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.txtpesquisaagenda = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btntodasconsultas = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(36, 12)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowTodayCircle = False
        Me.MonthCalendar1.TabIndex = 0
        '
        'txtpesquisaagenda
        '
        Me.txtpesquisaagenda.Location = New System.Drawing.Point(36, 292)
        Me.txtpesquisaagenda.MaxLength = 6
        Me.txtpesquisaagenda.Name = "txtpesquisaagenda"
        Me.txtpesquisaagenda.ReadOnly = True
        Me.txtpesquisaagenda.Size = New System.Drawing.Size(227, 20)
        Me.txtpesquisaagenda.TabIndex = 2
        Me.txtpesquisaagenda.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(309, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(802, 435)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(794, 409)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Consultas Marcadas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(792, 408)
        Me.DataGridView1.TabIndex = 2
        '
        'btntodasconsultas
        '
        Me.btntodasconsultas.Location = New System.Drawing.Point(78, 203)
        Me.btntodasconsultas.Name = "btntodasconsultas"
        Me.btntodasconsultas.Size = New System.Drawing.Size(130, 54)
        Me.btntodasconsultas.TabIndex = 1
        Me.btntodasconsultas.Text = "Todas Consultas Marcadas"
        Me.btntodasconsultas.UseVisualStyleBackColor = True
        '
        'frmagenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1392, 816)
        Me.Controls.Add(Me.btntodasconsultas)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtpesquisaagenda)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmagenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmagenda"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents txtpesquisaagenda As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btntodasconsultas As System.Windows.Forms.Button
End Class
