<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EMPLOYEEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PAYROLLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMPLOYEEUPDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EMPLOYEEToolStripMenuItem, Me.PAYROLLToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(526, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EMPLOYEEToolStripMenuItem
        '
        Me.EMPLOYEEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EMPLOYEEUPDATEToolStripMenuItem})
        Me.EMPLOYEEToolStripMenuItem.Name = "EMPLOYEEToolStripMenuItem"
        Me.EMPLOYEEToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EMPLOYEEToolStripMenuItem.Text = "EMPLOYEE"
        '
        'PAYROLLToolStripMenuItem
        '
        Me.PAYROLLToolStripMenuItem.Name = "PAYROLLToolStripMenuItem"
        Me.PAYROLLToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.PAYROLLToolStripMenuItem.Text = "PAYROLL"
        '
        'EMPLOYEEUPDATEToolStripMenuItem
        '
        Me.EMPLOYEEUPDATEToolStripMenuItem.Name = "EMPLOYEEUPDATEToolStripMenuItem"
        Me.EMPLOYEEUPDATEToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.EMPLOYEEUPDATEToolStripMenuItem.Text = "EMPLOYEE UPDATE"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 328)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EMPLOYEEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PAYROLLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMPLOYEEUPDATEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
