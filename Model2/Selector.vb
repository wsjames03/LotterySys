Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Namespace Model2

    ''' <summary>
    ''' 选号器类
    ''' </summary>
    Public Class Selector

        ReadOnly barCode As Fath.BarcodeX = New Fath.BarcodeX() ' 创建条码生成对象

        '属性
        ''' <summary>
        ''' 选择的号码（临时存储，后面打印完毕就会保存起来，用来兑奖）
        ''' </summary>
        ''' <returns></returns>
        Public Property SelectedNums As List(Of String())

        Private ReadOnly objRandom As Random = New Random()

        ''' <summary>
        ''' 构造方法（初始化成员）
        ''' </summary>
        Public Sub New()
            Me.SelectedNums = New List(Of String())
        End Sub

        ''' <summary>
        ''' 生成指定组数的随机号码
        ''' </summary>
        ''' <returns></returns>
        Public Function CreateNum() As String()

            Dim numList As String() = New String(6) {}

            For i As Integer = 0 To numList.Length - 1
                numList(i) = objRandom.Next(10).ToString()
            Next

            CreateNum = numList

        End Function

        ''' <summary>
        ''' 生成指定组数的随机号码
        ''' </summary>
        ''' <param name="count"></param>
        Public Sub CreateGroupNums(count As Integer)

            Me.SelectedNums.Clear()

            For i As Integer = 0 To count - 1
                SelectedNums.Add(CreateNum())  '增加一组
            Next

        End Sub

        ''' <summary>
        ''' 获取打印格式的号码列表
        ''' </summary>
        ''' <returns></returns>
        Public Function GetPrintedNums() As List(Of String)
            Dim numList = New List(Of String)
            Dim printedNum = String.Empty

            For i As Integer = 0 To Me.SelectedNums.Count - 1

                printedNum = "第" & String.Format("{0:D3}", i + 1) & "组:"

                For j As Integer = 0 To Me.SelectedNums(i).Length - 1
                    printedNum &= Me.SelectedNums(i)(j) & IIf(j <> 5, " ", "   ")
                Next

                numList.Add(printedNum)

            Next

            Return numList

        End Function

        Public Sub PrintLottery(e As System.Drawing.Printing.PrintPageEventArgs, serialNum As String, numList As List(Of String))

            '生成条形码
            barCode.Text = serialNum '条码数据
            barCode.Symbology = Fath.bcType.Code128 '设置条码格式
            barCode.ShowText = True '同时显示文本           
            e.Graphics.DrawImage(barCode.Image(260, 55), New Point(10, 5)) '画条形码

            '生成彩票信息
            Dim left = 2 ' 打印区域的左边界
            Dim top = 70 ' 打印区域的上边界

            Dim titleFont = New Font("仿宋", 10) ' 标题字体
            Dim font = New Font("仿宋", 8) ' 内容字体

            e.Graphics.DrawString("我了个抓百万奖彩票中心", titleFont, Brushes.Blue, left + 10, top, New StringFormat()) '打印标题

            '画一条分界线
            Dim pen = New Pen(Color.Green, 1)
            e.Graphics.DrawLine(pen, New Point(left - 2, top + 20), New Point(left + 180, top + 20))

            '循环打印选号
            For i As Integer = 0 To numList.Count - 1
                e.Graphics.DrawString(numList(i), font, Brushes.Blue, left, top + titleFont.GetHeight(e.Graphics) + font.GetHeight(e.Graphics) * i + 12, New StringFormat())
            Next

            '画一条分界线           
            Dim topPoint = titleFont.GetHeight(e.Graphics) + font.GetHeight(e.Graphics) * (numList.Count) + 22

            e.Graphics.DrawLine(pen, New Point(left - 2, top + topPoint), New Point(left + 180, top + topPoint))

            '打印时间
            Dim time = "购买时间：" + DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss")
            e.Graphics.DrawString(time, font, Brushes.Blue, left, top + titleFont.GetHeight(e.Graphics) + font.GetHeight(e.Graphics) * (numList.Count + 1) + 12, New StringFormat())

            '二维码图片left和top坐标
            Dim qrcodetop = top + titleFont.GetHeight(e.Graphics) + font.GetHeight(e.Graphics) * (numList.Count + 3) + 12
            Dim qrcodeleft = left + 32

            '生成二维码图片
            ' Image bmp = QRcodeCreator.GetQRCodeBmp("http:'www.xiketang.com/duijiang/query?id=" + serialNum)'直接添加流水号，将来从网站直接查询
            Dim bmp = QRcodeCreator.GetQRCodeBmp("我了个抓")

            '打印
            e.Graphics.DrawImage(bmp, New Point(qrcodeleft, qrcodetop)) '不同的URL图片大小不同，可以根据需要调整left坐标
            e.Graphics.DrawString("扫描二维码可直接查询兑奖结果", font, Brushes.Blue, left, qrcodetop + bmp.Height + 10, New StringFormat())

        End Sub

        Public Sub Save(serialNum As String)

            Dim Dir = New DirectoryInfo("numList")
            If Not Dir.Exists Then
                Dir.Create()
            End If

            Dim path = $"numList\" + serialNum + ".num"
            Dim fs As FileStream = New FileStream(path, FileMode.Create)
            Dim bf As BinaryFormatter = New BinaryFormatter()

#Disable Warning SYSLIB0011 ' Type or member is obsolete
            bf.Serialize(fs, SelectedNums)
#Enable Warning SYSLIB0011 ' Type or member is obsolete

            fs.Close()

        End Sub
    End Class
End Namespace