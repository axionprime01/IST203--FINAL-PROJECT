<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updatepokemon
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
        Me.txtAbility = New System.Windows.Forms.TextBox()
        Me.txtMove1 = New System.Windows.Forms.TextBox()
        Me.txtMove2 = New System.Windows.Forms.TextBox()
        Me.txtMove3 = New System.Windows.Forms.TextBox()
        Me.txtMove4 = New System.Windows.Forms.TextBox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTyping = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAbility
        '
        Me.txtAbility.Location = New System.Drawing.Point(233, 136)
        Me.txtAbility.Name = "txtAbility"
        Me.txtAbility.Size = New System.Drawing.Size(100, 22)
        Me.txtAbility.TabIndex = 0
        '
        'txtMove1
        '
        Me.txtMove1.Location = New System.Drawing.Point(58, 193)
        Me.txtMove1.Name = "txtMove1"
        Me.txtMove1.Size = New System.Drawing.Size(100, 22)
        Me.txtMove1.TabIndex = 1
        '
        'txtMove2
        '
        Me.txtMove2.Location = New System.Drawing.Point(233, 193)
        Me.txtMove2.Name = "txtMove2"
        Me.txtMove2.Size = New System.Drawing.Size(100, 22)
        Me.txtMove2.TabIndex = 2
        '
        'txtMove3
        '
        Me.txtMove3.Location = New System.Drawing.Point(58, 245)
        Me.txtMove3.Name = "txtMove3"
        Me.txtMove3.Size = New System.Drawing.Size(100, 22)
        Me.txtMove3.TabIndex = 3
        '
        'txtMove4
        '
        Me.txtMove4.Location = New System.Drawing.Point(233, 245)
        Me.txtMove4.Name = "txtMove4"
        Me.txtMove4.Size = New System.Drawing.Size(100, 22)
        Me.txtMove4.TabIndex = 4
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(55, 78)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(51, 17)
        Me.lblid.TabIndex = 5
        Me.lblid.Text = "Label1"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(230, 78)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 17)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Label2"
        '
        'lblTyping
        '
        Me.lblTyping.AutoSize = True
        Me.lblTyping.Location = New System.Drawing.Point(55, 139)
        Me.lblTyping.Name = "lblTyping"
        Me.lblTyping.Size = New System.Drawing.Size(51, 17)
        Me.lblTyping.TabIndex = 7
        Me.lblTyping.Text = "Label3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(55, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "typing"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(230, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "ability"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(55, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "move1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(230, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "move2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(230, 218)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "move4"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(55, 218)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 17)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "move3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(230, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "id"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(58, 333)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(233, 333)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'updatepokemon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 387)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTyping)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.txtMove4)
        Me.Controls.Add(Me.txtMove3)
        Me.Controls.Add(Me.txtMove2)
        Me.Controls.Add(Me.txtMove1)
        Me.Controls.Add(Me.txtAbility)
        Me.Name = "updatepokemon"
        Me.Text = "updatepokemon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAbility As TextBox
    Friend WithEvents txtMove1 As TextBox
    Friend WithEvents txtMove2 As TextBox
    Friend WithEvents txtMove3 As TextBox
    Friend WithEvents txtMove4 As TextBox
    Friend WithEvents lblid As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblTyping As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
