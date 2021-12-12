Public Class frmMain

    Private objSelector As New Selector()

#Region "初始化"

    ''' <summary>
    ''' 初始化
    ''' </summary>
    Public Sub New()

        InitializeComponent()

        Me.btnConfirm.Enabled = False
        Me.btnPrint.Enabled = False
        Me.btnClear.Enabled = False
        Me.btnDel.Enabled = False

    End Sub

#End Region

#Region "窗体最小化、最大化、关闭"

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region

#Region "拖动窗体的实现"

    Dim mouseOff As Point = Nothing     '鼠标移动位置变量
    Dim leftFlg As Boolean = False      '标签是否为左键

    Private Sub FrmMain_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

        If e.Button = MouseButtons.Left Then
            mouseOff = New Point(-e.X, -e.Y)        '得到变量的值
            leftFlg = True                          '点击左键按下时标注为true;
        End If

    End Sub

    Private Sub FrmMain_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, Panel1.MouseMove, Panel2.MouseMove

        If leftFlg Then

            Dim mouseSet As Point = Control.MousePosition
            mouseSet.Offset(mouseOff.X, mouseOff.Y)
            Location = mouseSet                     '设置移动后的位置

        End If

    End Sub

    Private Sub FrmMain_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp, Panel1.MouseUp, Panel2.MouseUp

        If (leftFlg) Then
            leftFlg = False  '释放鼠标后标注为false;
        End If

    End Sub
#End Region

#Region "生成彩票功能的实现"

    ''' <summary>
    ''' 启动选号
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRandomSelect_Click(sender As Object, e As EventArgs) Handles btnRandomSelect.Click

        Me.RandomTimer.Start()
        Me.btnRandomSelect.Enabled = False
        Me.btnConfirm.Enabled = True

    End Sub

    ''' <summary>
    ''' 定时生成随机号码
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RandomTimer_Tick(sender As Object, e As EventArgs) Handles RandomTimer.Tick

        Dim numList = objSelector.CreateNum()       '生成随即号

        '显示随机号码
        Me.lblNum1.Text = numList(0)
        Me.lblNum2.Text = numList(1)
        Me.lblNum3.Text = numList(2)
        Me.lblNum4.Text = numList(3)
        Me.lblNum5.Text = numList(4)
        Me.lblNum6.Text = numList(5)
        Me.lblNum7.Text = numList(6)

    End Sub

    ''' <summary>
    ''' 开始选号
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Me.RandomTimer.Stop() '定时器停止

        Dim selectedNum = New String() {lblNum1.Text, lblNum2.Text, lblNum3.Text,
                                        lblNum4.Text, lblNum5.Text, lblNum6.Text, lblNum7.Text}  '如果使用暂存号码，可以直接读取

        objSelector.SelectedNums.Add(selectedNum) ' 保存当前选中的号码

        Me.ShowSeletedNums()  '显示选中的号码

    End Sub

    ''' <summary>
    ''' 显示选中的号码
    ''' </summary>
    Private Sub ShowSeletedNums()


        Me.lbNumberList.Items.Clear()
        Me.lbNumberList.Items.AddRange(Me.objSelector.GetPrintedNums().ToArray())

        '按钮启用
        Me.btnRandomSelect.Enabled = True
        Me.btnPrint.Enabled = lbNumberList.Items.Count > 0
        Me.btnClear.Enabled = lbNumberList.Items.Count > 0
        Me.btnDel.Enabled = lbNumberList.Items.Count > 0

    End Sub

    ''' <summary>
    ''' 手写号码
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnHandWriting_Click(sender As Object, e As EventArgs) Handles btnHandWriting.Click

        Dim selectedNum = New String() {txtNum1.Text, txtNum2.Text, txtNum3.Text,
                                        txtNum4.Text, txtNum5.Text, txtNum6.Text, txtNum7.Text}

        objSelector.SelectedNums.Add(selectedNum)

        ShowSeletedNums() '//显示选中的号码

    End Sub

    ''' <summary>
    ''' 生成指定组的号码
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnGroupSelect_Click(sender As Object, e As EventArgs) Handles btnGroupSelect.Click

        '停止定时器
        Me.RandomTimer.Stop()

        '生成指定组数的随机号码
        objSelector.CreateGroupNums(Convert.ToInt32(Me.txtGrpNum.Text))

        '显示选中的号码
        ShowSeletedNums()

    End Sub

    ''' <summary>
    ''' 删除选号
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        If Me.lbNumberList.Items.Count = 0 OrElse Me.lbNumberList.SelectedItem Is Nothing Then
            Return
        End If

        Dim index = Me.lbNumberList.SelectedIndex           '获取选中的索引

        objSelector.SelectedNums.RemoveAt(index)

        '        If objSelector.SelectedNums.Count = 0 Then          '如果一个个删掉
        '
        '            Me.btnClear.Enabled = False
        '            Me.btnDel.Enabled = False
        '            Me.btnPrint.Enabled = False
        '
        '        End If

        '显示选中的号码
        ShowSeletedNums()

    End Sub

    ''' <summary>
    ''' 清空选号
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        '从界面中清除显示
        Me.lbNumberList.Items.Clear()

        ' 从选号器对象集合中清空
        Me.objSelector.SelectedNums.Clear()

        '号码复位
        Me.lblNum1.Text = "0"
        Me.lblNum2.Text = "0"
        Me.lblNum3.Text = "0"
        Me.lblNum4.Text = "0"
        Me.lblNum5.Text = "0"
        Me.lblNum6.Text = "0"
        Me.lblNum7.Text = "0"
        Me.txtNum1.Text = "0"
        Me.txtNum2.Text = "0"
        Me.txtNum3.Text = "0"
        Me.txtNum4.Text = "0"
        Me.txtNum5.Text = "0"
        Me.txtNum6.Text = "0"
        Me.txtNum7.Text = "0"
        Me.txtGrpNum.Text = "0"

        '显示选中的号码
        ShowSeletedNums()

    End Sub



#End Region

End Class
