Public Class frmMain

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

    Private Sub FrmMain_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, Panel1.MouseDown, Panel2.MouseDown

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

End Class
