<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.PokemonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LookForAPokemonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeamsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateTeamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSavedTeamsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 183)
        Me.Label1.MinimumSize = New System.Drawing.Size(150, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SortaDex"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PokemonToolStripMenuItem, Me.TeamsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PokemonToolStripMenuItem
        '
        Me.PokemonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LookForAPokemonToolStripMenuItem})
        Me.PokemonToolStripMenuItem.Name = "PokemonToolStripMenuItem"
        Me.PokemonToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.PokemonToolStripMenuItem.Text = "Pokemon"
        '
        'LookForAPokemonToolStripMenuItem
        '
        Me.LookForAPokemonToolStripMenuItem.Name = "LookForAPokemonToolStripMenuItem"
        Me.LookForAPokemonToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.LookForAPokemonToolStripMenuItem.Text = "Look For a Pokemon"
        '
        'TeamsToolStripMenuItem
        '
        Me.TeamsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateTeamToolStripMenuItem, Me.ViewSavedTeamsToolStripMenuItem})
        Me.TeamsToolStripMenuItem.Name = "TeamsToolStripMenuItem"
        Me.TeamsToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.TeamsToolStripMenuItem.Text = "teams"
        '
        'CreateTeamToolStripMenuItem
        '
        Me.CreateTeamToolStripMenuItem.Name = "CreateTeamToolStripMenuItem"
        Me.CreateTeamToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.CreateTeamToolStripMenuItem.Text = "create team"
        '
        'ViewSavedTeamsToolStripMenuItem
        '
        Me.ViewSavedTeamsToolStripMenuItem.Name = "ViewSavedTeamsToolStripMenuItem"
        Me.ViewSavedTeamsToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.ViewSavedTeamsToolStripMenuItem.Text = "view Saved teams"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 446)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "SortADex"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PokemonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LookForAPokemonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeamsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateTeamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewSavedTeamsToolStripMenuItem As ToolStripMenuItem
End Class
