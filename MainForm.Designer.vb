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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PlayerList = New System.Windows.Forms.DataGridView()
        Me.clnCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnPlayerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnPlayerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnBattles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnTotalGold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClanGold = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToKeep = New System.Windows.Forms.TextBox()
        Me.lblGoldPerBattle = New System.Windows.Forms.Label()
        Me.lblTotalGoldShare = New System.Windows.Forms.Label()
        CType(Me.PlayerList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlayerList
        '
        Me.PlayerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlayerList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnCount, Me.clnPlayerID, Me.clnPlayerName, Me.clnBattles, Me.clnTotalGold})
        Me.PlayerList.Location = New System.Drawing.Point(12, 40)
        Me.PlayerList.Name = "PlayerList"
        Me.PlayerList.RowTemplate.Height = 25
        Me.PlayerList.Size = New System.Drawing.Size(545, 1038)
        Me.PlayerList.TabIndex = 0
        '
        'clnCount
        '
        Me.clnCount.HeaderText = "No"
        Me.clnCount.Name = "clnCount"
        '
        'clnPlayerID
        '
        Me.clnPlayerID.HeaderText = "ID"
        Me.clnPlayerID.Name = "clnPlayerID"
        '
        'clnPlayerName
        '
        Me.clnPlayerName.HeaderText = "Name"
        Me.clnPlayerName.Name = "clnPlayerName"
        '
        'clnBattles
        '
        Me.clnBattles.HeaderText = "battles"
        Me.clnBattles.Name = "clnBattles"
        '
        'clnTotalGold
        '
        Me.clnTotalGold.HeaderText = "Gold"
        Me.clnTotalGold.Name = "clnTotalGold"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Share Gold"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Clan's Gold:"
        '
        'ClanGold
        '
        Me.ClanGold.Location = New System.Drawing.Point(193, 7)
        Me.ClanGold.Name = "ClanGold"
        Me.ClanGold.Size = New System.Drawing.Size(100, 23)
        Me.ClanGold.TabIndex = 3
        Me.ClanGold.Text = "31048"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To Keep:"
        '
        'ToKeep
        '
        Me.ToKeep.Location = New System.Drawing.Point(375, 6)
        Me.ToKeep.Name = "ToKeep"
        Me.ToKeep.Size = New System.Drawing.Size(100, 23)
        Me.ToKeep.TabIndex = 3
        Me.ToKeep.Text = "0"
        '
        'lblGoldPerBattle
        '
        Me.lblGoldPerBattle.AutoSize = True
        Me.lblGoldPerBattle.Location = New System.Drawing.Point(577, 78)
        Me.lblGoldPerBattle.Name = "lblGoldPerBattle"
        Me.lblGoldPerBattle.Size = New System.Drawing.Size(88, 15)
        Me.lblGoldPerBattle.TabIndex = 4
        Me.lblGoldPerBattle.Text = "Gold Per Battle:"
        '
        'lblTotalGoldShare
        '
        Me.lblTotalGoldShare.AutoSize = True
        Me.lblTotalGoldShare.Location = New System.Drawing.Point(587, 111)
        Me.lblTotalGoldShare.Name = "lblTotalGoldShare"
        Me.lblTotalGoldShare.Size = New System.Drawing.Size(41, 15)
        Me.lblTotalGoldShare.TabIndex = 5
        Me.lblTotalGoldShare.Text = "Label3"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 1090)
        Me.Controls.Add(Me.lblTotalGoldShare)
        Me.Controls.Add(Me.lblGoldPerBattle)
        Me.Controls.Add(Me.ToKeep)
        Me.Controls.Add(Me.ClanGold)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PlayerList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "NERVA Gold calculator"
        CType(Me.PlayerList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlayerList As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents clnCount As DataGridViewTextBoxColumn
    Friend WithEvents clnPlayerID As DataGridViewTextBoxColumn
    Friend WithEvents clnPlayerName As DataGridViewTextBoxColumn
    Friend WithEvents clnBattles As DataGridViewTextBoxColumn
    Friend WithEvents clnTotalGold As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents ClanGold As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ToKeep As TextBox
    Friend WithEvents lblGoldPerBattle As Label
    Friend WithEvents lblTotalGoldShare As Label
End Class
