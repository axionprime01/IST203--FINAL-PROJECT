<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PickPokemonForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvPickPokemon = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.typeid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Move1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Move2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Move3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Move4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PokemonBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PokemonDataSet = New final_project.PokemonDataSet()
        Me.PokemonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PokemonTableAdapter = New final_project.PokemonDataSetTableAdapters.PokemonTableAdapter()
        Me.btnAddPokemon = New System.Windows.Forms.Button()
        Me.btnNEWPKMNINSTANCE = New System.Windows.Forms.Button()
        Me.btnViewTeam = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSearchAll = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.TypingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TypingTableAdapter = New final_project.PokemonDataSetTableAdapters.typingTableAdapter()
        CType(Me.dgvPickPokemon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PokemonBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PokemonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PokemonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(303, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvPickPokemon
        '
        Me.dgvPickPokemon.AllowUserToAddRows = False
        Me.dgvPickPokemon.AllowUserToDeleteRows = False
        Me.dgvPickPokemon.AutoGenerateColumns = False
        Me.dgvPickPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPickPokemon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.typeid, Me.AbilityDataGridViewTextBoxColumn, Me.Move1DataGridViewTextBoxColumn, Me.Move2DataGridViewTextBoxColumn, Me.Move3DataGridViewTextBoxColumn, Me.Move4DataGridViewTextBoxColumn})
        Me.dgvPickPokemon.DataSource = Me.PokemonBindingSource1
        Me.dgvPickPokemon.Location = New System.Drawing.Point(1, 35)
        Me.dgvPickPokemon.Name = "dgvPickPokemon"
        Me.dgvPickPokemon.ReadOnly = True
        Me.dgvPickPokemon.RowTemplate.Height = 24
        Me.dgvPickPokemon.Size = New System.Drawing.Size(740, 397)
        Me.dgvPickPokemon.TabIndex = 3
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'typeid
        '
        Me.typeid.DataPropertyName = "typeid"
        Me.typeid.HeaderText = "typeid"
        Me.typeid.Name = "typeid"
        Me.typeid.ReadOnly = True
        '
        'AbilityDataGridViewTextBoxColumn
        '
        Me.AbilityDataGridViewTextBoxColumn.DataPropertyName = "ability"
        Me.AbilityDataGridViewTextBoxColumn.HeaderText = "ability"
        Me.AbilityDataGridViewTextBoxColumn.Name = "AbilityDataGridViewTextBoxColumn"
        Me.AbilityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Move1DataGridViewTextBoxColumn
        '
        Me.Move1DataGridViewTextBoxColumn.DataPropertyName = "move1"
        Me.Move1DataGridViewTextBoxColumn.HeaderText = "move1"
        Me.Move1DataGridViewTextBoxColumn.Name = "Move1DataGridViewTextBoxColumn"
        Me.Move1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Move2DataGridViewTextBoxColumn
        '
        Me.Move2DataGridViewTextBoxColumn.DataPropertyName = "move2"
        Me.Move2DataGridViewTextBoxColumn.HeaderText = "move2"
        Me.Move2DataGridViewTextBoxColumn.Name = "Move2DataGridViewTextBoxColumn"
        Me.Move2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Move3DataGridViewTextBoxColumn
        '
        Me.Move3DataGridViewTextBoxColumn.DataPropertyName = "move3"
        Me.Move3DataGridViewTextBoxColumn.HeaderText = "move3"
        Me.Move3DataGridViewTextBoxColumn.Name = "Move3DataGridViewTextBoxColumn"
        Me.Move3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Move4DataGridViewTextBoxColumn
        '
        Me.Move4DataGridViewTextBoxColumn.DataPropertyName = "move4"
        Me.Move4DataGridViewTextBoxColumn.HeaderText = "move4"
        Me.Move4DataGridViewTextBoxColumn.Name = "Move4DataGridViewTextBoxColumn"
        Me.Move4DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PokemonBindingSource1
        '
        Me.PokemonBindingSource1.DataMember = "Pokemon"
        Me.PokemonBindingSource1.DataSource = Me.PokemonDataSet
        '
        'PokemonDataSet
        '
        Me.PokemonDataSet.DataSetName = "PokemonDataSet"
        Me.PokemonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PokemonBindingSource
        '
        Me.PokemonBindingSource.DataMember = "Pokemon"
        Me.PokemonBindingSource.DataSource = Me.PokemonDataSet
        '
        'PokemonTableAdapter
        '
        Me.PokemonTableAdapter.ClearBeforeFill = True
        '
        'btnAddPokemon
        '
        Me.btnAddPokemon.Location = New System.Drawing.Point(100, 480)
        Me.btnAddPokemon.Name = "btnAddPokemon"
        Me.btnAddPokemon.Size = New System.Drawing.Size(225, 23)
        Me.btnAddPokemon.TabIndex = 4
        Me.btnAddPokemon.Text = "Add Pokemon to team"
        Me.btnAddPokemon.UseVisualStyleBackColor = True
        '
        'btnNEWPKMNINSTANCE
        '
        Me.btnNEWPKMNINSTANCE.Location = New System.Drawing.Point(370, 480)
        Me.btnNEWPKMNINSTANCE.Name = "btnNEWPKMNINSTANCE"
        Me.btnNEWPKMNINSTANCE.Size = New System.Drawing.Size(243, 23)
        Me.btnNEWPKMNINSTANCE.TabIndex = 5
        Me.btnNEWPKMNINSTANCE.Text = "add a new pokemon to the dex"
        Me.btnNEWPKMNINSTANCE.UseVisualStyleBackColor = True
        '
        'btnViewTeam
        '
        Me.btnViewTeam.Location = New System.Drawing.Point(418, 432)
        Me.btnViewTeam.Name = "btnViewTeam"
        Me.btnViewTeam.Size = New System.Drawing.Size(114, 23)
        Me.btnViewTeam.TabIndex = 6
        Me.btnViewTeam.Text = "view team"
        Me.btnViewTeam.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(143, 432)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(132, 23)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "update Pokemon"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSearchAll
        '
        Me.btnSearchAll.Location = New System.Drawing.Point(586, 2)
        Me.btnSearchAll.Name = "btnSearchAll"
        Me.btnSearchAll.Size = New System.Drawing.Size(85, 23)
        Me.btnSearchAll.TabIndex = 8
        Me.btnSearchAll.Text = "Search All"
        Me.btnSearchAll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(396, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "search through all pokemon"
        '
        'cboType
        '
        Me.cboType.DataSource = Me.TypingBindingSource
        Me.cboType.DisplayMember = "typing"
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(239, 5)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(121, 24)
        Me.cboType.TabIndex = 10
        Me.cboType.ValueMember = "typeId"
        '
        'TypingBindingSource
        '
        Me.TypingBindingSource.DataMember = "typing"
        Me.TypingBindingSource.DataSource = Me.PokemonDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "select a specific type to search by"
        '
        'TypingTableAdapter
        '
        Me.TypingTableAdapter.ClearBeforeFill = True
        '
        'PickPokemonForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 507)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearchAll)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnViewTeam)
        Me.Controls.Add(Me.btnNEWPKMNINSTANCE)
        Me.Controls.Add(Me.btnAddPokemon)
        Me.Controls.Add(Me.dgvPickPokemon)
        Me.Controls.Add(Me.Button1)
        Me.Name = "PickPokemonForm"
        Me.Text = "PickPokemonForm"
        CType(Me.dgvPickPokemon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PokemonBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PokemonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PokemonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvPickPokemon As DataGridView
    Friend WithEvents PokemonDataSet As PokemonDataSet
    Friend WithEvents PokemonBindingSource As BindingSource
    Friend WithEvents PokemonTableAdapter As PokemonDataSetTableAdapters.PokemonTableAdapter
    Friend WithEvents TypingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAddPokemon As Button
    Friend WithEvents btnNEWPKMNINSTANCE As Button
    Friend WithEvents btnViewTeam As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents PokemonBindingSource1 As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents typeid As DataGridViewTextBoxColumn
    Friend WithEvents AbilityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Move1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Move2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Move3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Move4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnSearchAll As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TypingBindingSource As BindingSource
    Friend WithEvents TypingTableAdapter As PokemonDataSetTableAdapters.typingTableAdapter
End Class
