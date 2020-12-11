<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NEWEMPLOYEEREGISTRATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMPLOYEELOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAY SYSTEM"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NEWEMPLOYEEREGISTRATIONToolStripMenuItem, Me.EMPLOYEELOGINToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(559, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NEWEMPLOYEEREGISTRATIONToolStripMenuItem
        '
        Me.NEWEMPLOYEEREGISTRATIONToolStripMenuItem.Name = "NEWEMPLOYEEREGISTRATIONToolStripMenuItem"
        Me.NEWEMPLOYEEREGISTRATIONToolStripMenuItem.Size = New System.Drawing.Size(189, 20)
        Me.NEWEMPLOYEEREGISTRATIONToolStripMenuItem.Text = "NEW EMPLOYEE REGISTRATION"
        '
        'EMPLOYEELOGINToolStripMenuItem
        '
        Me.EMPLOYEELOGINToolStripMenuItem.Name = "EMPLOYEELOGINToolStripMenuItem"
        Me.EMPLOYEELOGINToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.EMPLOYEELOGINToolStripMenuItem.Text = "EMPLOYEE LOGIN"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 341)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NEWEMPLOYEEREGISTRATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMPLOYEELOGINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
