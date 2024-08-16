<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInventoryInput
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventoryInput))
        SplitContainer1 = New SplitContainer()
        CmbInputType = New ComboBox()
        NumKingaku = New NumericUpDown()
        NumSuryou = New NumericUpDown()
        Label7 = New Label()
        DtpInputDate = New DateTimePicker()
        Label3 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TxtTantou = New TextBox()
        TxtBikou = New TextBox()
        TxtTani = New TextBox()
        TxtHinmei = New TextBox()
        BtnAdd = New Button()
        Label8 = New Label()
        SplitContainer2 = New SplitContainer()
        DgvInventory = New DataGridView()
        BtnRegist = New Button()
        BtnExit = New Button()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(NumKingaku, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumSuryou, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        CType(DgvInventory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.FixedPanel = FixedPanel.Panel1
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(CmbInputType)
        SplitContainer1.Panel1.Controls.Add(NumKingaku)
        SplitContainer1.Panel1.Controls.Add(NumSuryou)
        SplitContainer1.Panel1.Controls.Add(Label7)
        SplitContainer1.Panel1.Controls.Add(DtpInputDate)
        SplitContainer1.Panel1.Controls.Add(Label3)
        SplitContainer1.Panel1.Controls.Add(Label5)
        SplitContainer1.Panel1.Controls.Add(Label4)
        SplitContainer1.Panel1.Controls.Add(Label6)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(Label1)
        SplitContainer1.Panel1.Controls.Add(TxtTantou)
        SplitContainer1.Panel1.Controls.Add(TxtBikou)
        SplitContainer1.Panel1.Controls.Add(TxtTani)
        SplitContainer1.Panel1.Controls.Add(TxtHinmei)
        SplitContainer1.Panel1.Controls.Add(BtnAdd)
        SplitContainer1.Panel1.Controls.Add(Label8)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(SplitContainer2)
        SplitContainer1.Size = New Size(816, 612)
        SplitContainer1.SplitterDistance = 211
        SplitContainer1.TabIndex = 0
        ' 
        ' CmbInputType
        ' 
        CmbInputType.DropDownStyle = ComboBoxStyle.DropDownList
        CmbInputType.FlatStyle = FlatStyle.System
        CmbInputType.FormattingEnabled = True
        CmbInputType.Items.AddRange(New Object() {"入庫", "出庫"})
        CmbInputType.Location = New Point(73, 41)
        CmbInputType.Name = "CmbInputType"
        CmbInputType.Size = New Size(121, 23)
        CmbInputType.TabIndex = 5
        ' 
        ' NumKingaku
        ' 
        NumKingaku.Location = New Point(484, 70)
        NumKingaku.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        NumKingaku.Name = "NumKingaku"
        NumKingaku.Size = New Size(86, 23)
        NumKingaku.TabIndex = 13
        NumKingaku.ThousandsSeparator = True
        NumKingaku.Value = New Decimal(New Integer() {999999999, 0, 0, 0})
        ' 
        ' NumSuryou
        ' 
        NumSuryou.DecimalPlaces = 2
        NumSuryou.Location = New Point(220, 70)
        NumSuryou.Maximum = New Decimal(New Integer() {9999999, 0, 0, 131072})
        NumSuryou.Name = "NumSuryou"
        NumSuryou.Size = New Size(70, 23)
        NumSuryou.TabIndex = 9
        NumSuryou.ThousandsSeparator = True
        NumSuryou.Value = New Decimal(New Integer() {999999, 0, 0, 131072})
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(453, 74)
        Label7.Name = "Label7"
        Label7.Size = New Size(31, 15)
        Label7.TabIndex = 12
        Label7.Text = "金額"
        ' 
        ' DtpInputDate
        ' 
        DtpInputDate.CustomFormat = "yyyy/MM/dd hh:mm"
        DtpInputDate.Format = DateTimePickerFormat.Custom
        DtpInputDate.Location = New Point(250, 12)
        DtpInputDate.Name = "DtpInputDate"
        DtpInputDate.Size = New Size(132, 23)
        DtpInputDate.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(189, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 8
        Label3.Text = "数量"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(189, 16)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 2
        Label5.Text = "処理日時"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 45)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 4
        Label4.Text = "処理区分"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(306, 74)
        Label6.Name = "Label6"
        Label6.Size = New Size(31, 15)
        Label6.TabIndex = 10
        Label6.Text = "単位"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 15)
        Label2.TabIndex = 6
        Label2.Text = "品名"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 0
        Label1.Text = "担当者"
        ' 
        ' TxtTantou
        ' 
        TxtTantou.Location = New Point(73, 12)
        TxtTantou.Name = "TxtTantou"
        TxtTantou.Size = New Size(100, 23)
        TxtTantou.TabIndex = 1
        ' 
        ' TxtBikou
        ' 
        TxtBikou.Location = New Point(12, 118)
        TxtBikou.MaxLength = 512
        TxtBikou.Multiline = True
        TxtBikou.Name = "TxtBikou"
        TxtBikou.Size = New Size(800, 88)
        TxtBikou.TabIndex = 15
        TxtBikou.Text = resources.GetString("TxtBikou.Text")
        ' 
        ' TxtTani
        ' 
        TxtTani.Location = New Point(337, 70)
        TxtTani.Name = "TxtTani"
        TxtTani.Size = New Size(100, 23)
        TxtTani.TabIndex = 11
        ' 
        ' TxtHinmei
        ' 
        TxtHinmei.Location = New Point(73, 70)
        TxtHinmei.Name = "TxtHinmei"
        TxtHinmei.Size = New Size(100, 23)
        TxtHinmei.TabIndex = 7
        ' 
        ' BtnAdd
        ' 
        BtnAdd.Location = New Point(667, 76)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(145, 36)
        BtnAdd.TabIndex = 16
        BtnAdd.Text = "追加"
        BtnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 100)
        Label8.Name = "Label8"
        Label8.Size = New Size(31, 15)
        Label8.TabIndex = 14
        Label8.Text = "備考"
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.FixedPanel = FixedPanel.Panel2
        SplitContainer2.Location = New Point(0, 0)
        SplitContainer2.Name = "SplitContainer2"
        SplitContainer2.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(DgvInventory)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(BtnRegist)
        SplitContainer2.Panel2.Controls.Add(BtnExit)
        SplitContainer2.Panel2MinSize = 38
        SplitContainer2.Size = New Size(816, 397)
        SplitContainer2.SplitterDistance = 345
        SplitContainer2.TabIndex = 0
        ' 
        ' DgvInventory
        ' 
        DgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvInventory.Dock = DockStyle.Fill
        DgvInventory.Location = New Point(0, 0)
        DgvInventory.Name = "DgvInventory"
        DgvInventory.ReadOnly = True
        DgvInventory.RowTemplate.Height = 25
        DgvInventory.Size = New Size(816, 345)
        DgvInventory.TabIndex = 0
        ' 
        ' BtnRegist
        ' 
        BtnRegist.Dock = DockStyle.Fill
        BtnRegist.Location = New Point(0, 0)
        BtnRegist.Name = "BtnRegist"
        BtnRegist.Size = New Size(653, 48)
        BtnRegist.TabIndex = 0
        BtnRegist.Text = "登録"
        BtnRegist.UseVisualStyleBackColor = True
        ' 
        ' BtnExit
        ' 
        BtnExit.Dock = DockStyle.Right
        BtnExit.Location = New Point(653, 0)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(163, 48)
        BtnExit.TabIndex = 1
        BtnExit.Text = "終了"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' FrmInventoryInput
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(816, 612)
        Controls.Add(SplitContainer1)
        Name = "FrmInventoryInput"
        Text = "FrmInventoryInput"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(NumKingaku, ComponentModel.ISupportInitialize).EndInit()
        CType(NumSuryou, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        CType(DgvInventory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnRegist As Button
    Friend WithEvents DgvInventory As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtHinmei As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents DtpInputDate As DateTimePicker
    Friend WithEvents CmbInputType As ComboBox
    Friend WithEvents NumSuryou As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTantou As TextBox
    Friend WithEvents NumKingaku As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtBikou As TextBox
    Friend WithEvents TxtTani As TextBox
End Class
