<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.WriteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WriteToFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppendTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WriteByLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadTheFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveByFilenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(0, 31)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(800, 420)
        Me.TextBox1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WriteToolStripMenuItem, Me.ReadToolStripMenuItem, Me.SaveFileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'WriteToolStripMenuItem
        '
        Me.WriteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WriteToFileToolStripMenuItem, Me.AppendTextToolStripMenuItem, Me.WriteByLineToolStripMenuItem})
        Me.WriteToolStripMenuItem.Name = "WriteToolStripMenuItem"
        Me.WriteToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.WriteToolStripMenuItem.Text = "Write"
        '
        'WriteToFileToolStripMenuItem
        '
        Me.WriteToFileToolStripMenuItem.Name = "WriteToFileToolStripMenuItem"
        Me.WriteToFileToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.WriteToFileToolStripMenuItem.Text = "Write to file"
        '
        'AppendTextToolStripMenuItem
        '
        Me.AppendTextToolStripMenuItem.Name = "AppendTextToolStripMenuItem"
        Me.AppendTextToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.AppendTextToolStripMenuItem.Text = "Append text"
        '
        'WriteByLineToolStripMenuItem
        '
        Me.WriteByLineToolStripMenuItem.Name = "WriteByLineToolStripMenuItem"
        Me.WriteByLineToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.WriteByLineToolStripMenuItem.Text = "Write by line"
        '
        'ReadToolStripMenuItem
        '
        Me.ReadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReadTheFileToolStripMenuItem, Me.ByLineToolStripMenuItem})
        Me.ReadToolStripMenuItem.Name = "ReadToolStripMenuItem"
        Me.ReadToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.ReadToolStripMenuItem.Text = "Read"
        '
        'ReadTheFileToolStripMenuItem
        '
        Me.ReadTheFileToolStripMenuItem.Name = "ReadTheFileToolStripMenuItem"
        Me.ReadTheFileToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.ReadTheFileToolStripMenuItem.Text = "Read the file"
        '
        'ByLineToolStripMenuItem
        '
        Me.ByLineToolStripMenuItem.Name = "ByLineToolStripMenuItem"
        Me.ByLineToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.ByLineToolStripMenuItem.Text = "By line"
        '
        'SaveFileToolStripMenuItem
        '
        Me.SaveFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveByFilenameToolStripMenuItem})
        Me.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem"
        Me.SaveFileToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.SaveFileToolStripMenuItem.Text = "Save file"
        '
        'SaveByFilenameToolStripMenuItem
        '
        Me.SaveByFilenameToolStripMenuItem.Name = "SaveByFilenameToolStripMenuItem"
        Me.SaveByFilenameToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SaveByFilenameToolStripMenuItem.Text = "Save by filename"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents WriteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WriteToFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AppendTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReadTheFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WriteByLineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByLineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveByFilenameToolStripMenuItem As ToolStripMenuItem
End Class
