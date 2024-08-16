Imports System.ComponentModel
Imports System.Text

Public Class FrmInventoryInput

    ''' <summary>
    ''' 追加済データの登録／未登録
    ''' </summary>
    Private fpIsRegisted As Boolean = True

    ''' <summary>
    ''' 画面へ表示する内容を保持するデータテーブル
    ''' </summary>
    Private fpInventoryDataTable As New DataTable

    ''' <summary>
    ''' 在庫データ接続クラス
    ''' </summary>
    Private fpInventoryAdapter As New ClsInventoryAdapter


    ''' <summary>
    ''' フォーム開始時イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmInventoryInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 画面全体のデータをクリア
        Me.ClearInput(True)


        ' 最新の在庫履歴を取得
        Me.fpInventoryDataTable = fpInventoryAdapter.FillInventoryLog()

        ' 在庫履歴データをとデータグリッドビューへ結びつける
        Me.DgvInventory.DataSource = Me.fpInventoryDataTable


    End Sub

    ''' <summary>
    ''' フォーム終了前イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmInventoryInput_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    ''' <summary>
    ''' 追加ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        '' 入力中のデータがグリッドへ追加可能か確認
        If (Me.ValidateData() = False) Then
            Me.TxtTantou.Focus()
            Return
        End If

        '' 入力中のデータを行データとしてまとめる
        Dim wNewRow As DataRow = fpInventoryDataTable.NewRow()
        wNewRow.Item("SyoriKubun") = {"1", "2"}(Me.CmbInputType.SelectedIndex)
        wNewRow.Item("Hinmei") = Me.TxtHinmei.Text.ToString()
        wNewRow.Item("Suuryou") = CInt(Me.NumSuryou.Value)
        wNewRow.Item("Tani") = Me.TxtTani.Text
        wNewRow.Item("Kingaku") = CInt(Me.NumKingaku.Value)
        wNewRow.Item("Tantousya") = Me.TxtTantou.Text
        wNewRow.Item("Bikou") = Me.TxtBikou.Text
        wNewRow.Item("SyoriDateTime") = Me.DtpInputDate.Value
        wNewRow.Item("InputDateTime") = DateTime.MinValue
        wNewRow.Item("UpdateDateTime") = DateTime.MinValue

        '' 行データを追加する
        Me.fpInventoryDataTable.Rows.Add(wNewRow)

        '' 画面を新規入力可能な状態に設定する
        Me.ClearInput(False)
        Me.TxtHinmei.Focus()
    End Sub

    ''' <summary>
    ''' 登録ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnRegist_Click(sender As Object, e As EventArgs) Handles BtnRegist.Click
        ' DBを更新し最新データを再度取得する
        If (fpInventoryAdapter.InsertInventoryLog(fpInventoryDataTable) > 0) Then

            ' 最新の在庫履歴を取得
            Me.fpInventoryDataTable = fpInventoryAdapter.FillInventoryLog()

            ' 在庫履歴データをとデータグリッドビューへ結びつける
            Me.DgvInventory.DataSource = Me.fpInventoryDataTable
        End If

    End Sub

    ''' <summary>
    ''' 終了ボタンイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' 入力データのクリア
    ''' </summary>
    ''' <param name="aNewForm"></param>
    Private Sub ClearInput(ByVal aNewForm As Boolean)
        If (aNewForm) Then
            '' フォーム立ち上げ時のみクリアする項目
            Me.TxtTantou.Clear()

        End If

        Me.CmbInputType.SelectedIndex = 0
        Me.TxtHinmei.Clear()
        Me.NumSuryou.Value = 0
        Me.NumKingaku.Value = 0
        Me.TxtTani.Clear()
        Me.TxtBikou.Clear()

    End Sub


    ''' <summary>
    ''' フォーム内のデータが追加可能か検証する
    ''' </summary>
    ''' <returns>追加可能/追加不可(True/False)</returns>
    Private Function ValidateData() As Boolean
        Dim wSblWarningMessage As New StringBuilder
        Dim wIsWarning As Boolean = False

        '' 各入力項目の警告メッセージと警告の有無を設定する
        If (Me.TxtTantou.Text.Trim.Length = 0) Then
            wSblWarningMessage.Append("・担当者が入力されていません" & vbCrLf)
            wIsWarning = True

        End If

        If (Me.TxtHinmei.Text.Trim.Length = 0) Then
            wSblWarningMessage.Append("・品名が入力されていません" & vbCrLf)
            wIsWarning = True

        End If

        '' 警告メッセージを表示する
        If (wIsWarning = True) Then
            MessageBox.Show(Me, wSblWarningMessage.ToString(),
                            Me.Text,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1)
        End If

        Return Not wIsWarning

    End Function






End Class