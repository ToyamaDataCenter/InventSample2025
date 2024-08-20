<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInventoryViewer
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
        SplitContainer1 = New SplitContainer()
        CmbInputType = New ComboBox()
        DtpInputDate = New DateTimePicker()
        Label5 = New Label()
        Label4 = New Label()
        Label8 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TxtTantou = New TextBox()
        TxtBikou = New TextBox()
        TxtHinmei = New TextBox()
        BtnFind = New Button()
        SplitContainer2 = New SplitContainer()
        DgvInventory = New DataGridView()
        vSyoriKubun = New DataGridViewTextBoxColumn()
        vHinmei = New DataGridViewTextBoxColumn()
        vSuuryou = New DataGridViewTextBoxColumn()
        vTani = New DataGridViewTextBoxColumn()
        vKingaku = New DataGridViewTextBoxColumn()
        vTantousya = New DataGridViewTextBoxColumn()
        vBikou = New DataGridViewTextBoxColumn()
        vSyoriDateTime = New DataGridViewTextBoxColumn()
        BtnExit = New Button()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
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
        SplitContainer1.Panel1.Controls.Add(DtpInputDate)
        SplitContainer1.Panel1.Controls.Add(Label5)
        SplitContainer1.Panel1.Controls.Add(Label4)
        SplitContainer1.Panel1.Controls.Add(Label8)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(Label1)
        SplitContainer1.Panel1.Controls.Add(TxtTantou)
        SplitContainer1.Panel1.Controls.Add(TxtBikou)
        SplitContainer1.Panel1.Controls.Add(TxtHinmei)
        SplitContainer1.Panel1.Controls.Add(BtnFind)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(SplitContainer2)
        SplitContainer1.Size = New Size(847, 612)
        SplitContainer1.SplitterDistance = 71
        SplitContainer1.TabIndex = 0
        ' 
        ' CmbInputType
        ' 
        CmbInputType.DisplayMember = "1,2"
        CmbInputType.DropDownStyle = ComboBoxStyle.DropDownList
        CmbInputType.FlatStyle = FlatStyle.System
        CmbInputType.FormattingEnabled = True
        CmbInputType.Items.AddRange(New Object() {"入庫", "出庫"})
        CmbInputType.Location = New Point(67, 41)
        CmbInputType.Name = "CmbInputType"
        CmbInputType.Size = New Size(121, 23)
        CmbInputType.TabIndex = 5
        CmbInputType.ValueMember = "1,2"
        ' 
        ' DtpInputDate
        ' 
        DtpInputDate.Format = DateTimePickerFormat.Short
        DtpInputDate.Location = New Point(243, 12)
        DtpInputDate.Name = "DtpInputDate"
        DtpInputDate.Size = New Size(100, 23)
        DtpInputDate.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(194, 16)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 15)
        Label5.TabIndex = 2
        Label5.Text = "処理日"
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
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(458, 45)
        Label8.Name = "Label8"
        Label8.Size = New Size(31, 15)
        Label8.TabIndex = 8
        Label8.Text = "備考"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(194, 45)
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
        TxtTantou.Location = New Point(67, 12)
        TxtTantou.Name = "TxtTantou"
        TxtTantou.Size = New Size(100, 23)
        TxtTantou.TabIndex = 1
        ' 
        ' TxtBikou
        ' 
        TxtBikou.Location = New Point(489, 41)
        TxtBikou.Name = "TxtBikou"
        TxtBikou.Size = New Size(199, 23)
        TxtBikou.TabIndex = 9
        ' 
        ' TxtHinmei
        ' 
        TxtHinmei.Location = New Point(243, 41)
        TxtHinmei.Name = "TxtHinmei"
        TxtHinmei.Size = New Size(199, 23)
        TxtHinmei.TabIndex = 7
        ' 
        ' BtnFind
        ' 
        BtnFind.Location = New Point(699, 32)
        BtnFind.Name = "BtnFind"
        BtnFind.Size = New Size(145, 36)
        BtnFind.TabIndex = 10
        BtnFind.Text = "検索"
        BtnFind.UseVisualStyleBackColor = True
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
        SplitContainer2.Panel2.Controls.Add(BtnExit)
        SplitContainer2.Panel2MinSize = 38
        SplitContainer2.Size = New Size(847, 537)
        SplitContainer2.SplitterDistance = 485
        SplitContainer2.TabIndex = 0
        ' 
        ' DgvInventory
        ' 
        DgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvInventory.Columns.AddRange(New DataGridViewColumn() {vSyoriKubun, vHinmei, vSuuryou, vTani, vKingaku, vTantousya, vBikou, vSyoriDateTime})
        DgvInventory.Dock = DockStyle.Fill
        DgvInventory.Location = New Point(0, 0)
        DgvInventory.Name = "DgvInventory"
        DgvInventory.ReadOnly = True
        DgvInventory.RowTemplate.Height = 25
        DgvInventory.Size = New Size(847, 485)
        DgvInventory.TabIndex = 0
        ' 
        ' vSyoriKubun
        ' 
        vSyoriKubun.HeaderText = "処理区分"
        vSyoriKubun.Name = "vSyoriKubun"
        vSyoriKubun.ReadOnly = True
        ' 
        ' vHinmei
        ' 
        vHinmei.HeaderText = "品名"
        vHinmei.Name = "vHinmei"
        vHinmei.ReadOnly = True
        ' 
        ' vSuuryou
        ' 
        vSuuryou.HeaderText = "数量"
        vSuuryou.Name = "vSuuryou"
        vSuuryou.ReadOnly = True
        ' 
        ' vTani
        ' 
        vTani.HeaderText = "単位"
        vTani.Name = "vTani"
        vTani.ReadOnly = True
        ' 
        ' vKingaku
        ' 
        vKingaku.HeaderText = "金額"
        vKingaku.Name = "vKingaku"
        vKingaku.ReadOnly = True
        ' 
        ' vTantousya
        ' 
        vTantousya.HeaderText = "担当者"
        vTantousya.Name = "vTantousya"
        vTantousya.ReadOnly = True
        ' 
        ' vBikou
        ' 
        vBikou.HeaderText = "備考"
        vBikou.Name = "vBikou"
        vBikou.ReadOnly = True
        ' 
        ' vSyoriDateTime
        ' 
        vSyoriDateTime.HeaderText = "処理日時"
        vSyoriDateTime.Name = "vSyoriDateTime"
        vSyoriDateTime.ReadOnly = True
        ' 
        ' BtnExit
        ' 
        BtnExit.Dock = DockStyle.Fill
        BtnExit.Location = New Point(0, 0)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(847, 48)
        BtnExit.TabIndex = 1
        BtnExit.Text = "終了"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' FrmInventoryViewer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(847, 612)
        Controls.Add(SplitContainer1)
        Name = "FrmInventoryViewer"
        Text = "在庫確認画面"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
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
    Friend WithEvents DgvInventory As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtHinmei As TextBox
    Friend WithEvents BtnFind As Button
    Friend WithEvents DtpInputDate As DateTimePicker
    Friend WithEvents CmbInputType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTantou As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtBikou As TextBox
    Friend WithEvents vSyoriKubun As DataGridViewTextBoxColumn
    Friend WithEvents vHinmei As DataGridViewTextBoxColumn
    Friend WithEvents vSuuryou As DataGridViewTextBoxColumn
    Friend WithEvents vTani As DataGridViewTextBoxColumn
    Friend WithEvents vKingaku As DataGridViewTextBoxColumn
    Friend WithEvents vTantousya As DataGridViewTextBoxColumn
    Friend WithEvents vBikou As DataGridViewTextBoxColumn
    Friend WithEvents vSyoriDateTime As DataGridViewTextBoxColumn
End Class
