<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PickPokemonForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstboxPokemon = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(319, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstboxPokemon
        '
        Me.lstboxPokemon.FormattingEnabled = True
        Me.lstboxPokemon.ItemHeight = 16
        Me.lstboxPokemon.Location = New System.Drawing.Point(6, 12)
        Me.lstboxPokemon.Name = "lstboxPokemon"
        Me.lstboxPokemon.Size = New System.Drawing.Size(734, 372)
        Me.lstboxPokemon.TabIndex = 2
        '
        'PickPokemonForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 445)
        Me.Controls.Add(Me.lstboxPokemon)
        Me.Controls.Add(Me.Button1)
        Me.Name = "PickPokemonForm"
        Me.Text = "PickPokemonForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents lstboxPokemon As ListBox
End Class
