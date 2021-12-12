''' <summary>
''' 选号器类
''' </summary>
Public Class Selector

    '属性
    ''' <summary>
    ''' 选择的号码（临时存储，后面打印完毕就会保存起来，用来兑奖）
    ''' </summary>
    ''' <returns></returns>
    Public Property SelectedNums As List(Of String())

    Private objRandom As Random = New Random()

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

End Class
