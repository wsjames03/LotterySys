<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnRandomSelect = New System.Windows.Forms.Button()
        Me.btnHandWriting = New System.Windows.Forms.Button()
        Me.txtGrpNum = New System.Windows.Forms.TextBox()
        Me.lblGrpNum = New System.Windows.Forms.Label()
        Me.btnGroupSelect = New System.Windows.Forms.Button()
        Me.txtNum7 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum3 = New System.Windows.Forms.TextBox()
        Me.txtNum4 = New System.Windows.Forms.TextBox()
        Me.txtNum5 = New System.Windows.Forms.TextBox()
        Me.txtNum6 = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.lbNumberList = New System.Windows.Forms.ListBox()
        Me.lblNum7 = New System.Windows.Forms.Label()
        Me.lblNum5 = New System.Windows.Forms.Label()
        Me.lblNum6 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblNum3 = New System.Windows.Forms.Label()
        Me.lblNum4 = New System.Windows.Forms.Label()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.RandomTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnDel)
        Me.Panel1.Controls.Add(Me.btnConfirm)
        Me.Panel1.Controls.Add(Me.btnRandomSelect)
        Me.Panel1.Controls.Add(Me.btnHandWriting)
        Me.Panel1.Controls.Add(Me.txtGrpNum)
        Me.Panel1.Controls.Add(Me.lblGrpNum)
        Me.Panel1.Controls.Add(Me.btnGroupSelect)
        Me.Panel1.Controls.Add(Me.txtNum7)
        Me.Panel1.Controls.Add(Me.txtNum2)
        Me.Panel1.Controls.Add(Me.txtNum3)
        Me.Panel1.Controls.Add(Me.txtNum4)
        Me.Panel1.Controls.Add(Me.txtNum5)
        Me.Panel1.Controls.Add(Me.txtNum6)
        Me.Panel1.Controls.Add(Me.txtNum1)
        Me.Panel1.Controls.Add(Me.lbNumberList)
        Me.Panel1.Controls.Add(Me.lblNum7)
        Me.Panel1.Controls.Add(Me.lblNum5)
        Me.Panel1.Controls.Add(Me.lblNum6)
        Me.Panel1.Controls.Add(Me.lblNum2)
        Me.Panel1.Controls.Add(Me.lblNum3)
        Me.Panel1.Controls.Add(Me.lblNum4)
        Me.Panel1.Controls.Add(Me.lblNum1)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(10, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 466)
        Me.Panel1.TabIndex = 0
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(479, 324)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 74)
        Me.btnPrint.TabIndex = 25
        Me.btnPrint.Text = "打印彩票"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(387, 369)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 29)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "清空选号"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(288, 369)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 29)
        Me.btnDel.TabIndex = 23
        Me.btnDel.Text = "删除选号"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(387, 323)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 29)
        Me.btnConfirm.TabIndex = 22
        Me.btnConfirm.Text = "确认选号"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnRandomSelect
        '
        Me.btnRandomSelect.Location = New System.Drawing.Point(288, 323)
        Me.btnRandomSelect.Name = "btnRandomSelect"
        Me.btnRandomSelect.Size = New System.Drawing.Size(75, 29)
        Me.btnRandomSelect.TabIndex = 21
        Me.btnRandomSelect.Text = "随机选号"
        Me.btnRandomSelect.UseVisualStyleBackColor = True
        '
        'btnHandWriting
        '
        Me.btnHandWriting.Location = New System.Drawing.Point(479, 277)
        Me.btnHandWriting.Name = "btnHandWriting"
        Me.btnHandWriting.Size = New System.Drawing.Size(75, 29)
        Me.btnHandWriting.TabIndex = 20
        Me.btnHandWriting.Text = "手写号码"
        Me.btnHandWriting.UseVisualStyleBackColor = True
        '
        'txtGrpNum
        '
        Me.txtGrpNum.BackColor = System.Drawing.Color.White
        Me.txtGrpNum.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtGrpNum.Location = New System.Drawing.Point(334, 277)
        Me.txtGrpNum.Multiline = True
        Me.txtGrpNum.Name = "txtGrpNum"
        Me.txtGrpNum.Size = New System.Drawing.Size(29, 29)
        Me.txtGrpNum.TabIndex = 18
        Me.txtGrpNum.Text = "０"
        Me.txtGrpNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGrpNum
        '
        Me.lblGrpNum.AutoSize = True
        Me.lblGrpNum.ForeColor = System.Drawing.Color.White
        Me.lblGrpNum.Location = New System.Drawing.Point(275, 283)
        Me.lblGrpNum.Name = "lblGrpNum"
        Me.lblGrpNum.Size = New System.Drawing.Size(47, 17)
        Me.lblGrpNum.TabIndex = 17
        Me.lblGrpNum.Text = "组个数:"
        '
        'btnGroupSelect
        '
        Me.btnGroupSelect.Location = New System.Drawing.Point(387, 277)
        Me.btnGroupSelect.Name = "btnGroupSelect"
        Me.btnGroupSelect.Size = New System.Drawing.Size(75, 29)
        Me.btnGroupSelect.TabIndex = 16
        Me.btnGroupSelect.Text = "随机组选"
        Me.btnGroupSelect.UseVisualStyleBackColor = True
        '
        'txtNum7
        '
        Me.txtNum7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNum7.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNum7.ForeColor = System.Drawing.Color.White
        Me.txtNum7.Location = New System.Drawing.Point(581, 188)
        Me.txtNum7.MaxLength = 1
        Me.txtNum7.Multiline = True
        Me.txtNum7.Name = "txtNum7"
        Me.txtNum7.Size = New System.Drawing.Size(29, 29)
        Me.txtNum7.TabIndex = 15
        Me.txtNum7.Text = "0"
        Me.txtNum7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNum2
        '
        Me.txtNum2.BackColor = System.Drawing.Color.White
        Me.txtNum2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNum2.Location = New System.Drawing.Point(334, 188)
        Me.txtNum2.MaxLength = 1
        Me.txtNum2.Multiline = True
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(29, 29)
        Me.txtNum2.TabIndex = 14
        Me.txtNum2.Text = "0"
        Me.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNum3
        '
        Me.txtNum3.BackColor = System.Drawing.Color.White
        Me.txtNum3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNum3.Location = New System.Drawing.Point(375, 188)
        Me.txtNum3.MaxLength = 1
        Me.txtNum3.Multiline = True
        Me.txtNum3.Name = "txtNum3"
        Me.txtNum3.Size = New System.Drawing.Size(29, 29)
        Me.txtNum3.TabIndex = 13
        Me.txtNum3.Text = "0"
        Me.txtNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNum4
        '
        Me.txtNum4.BackColor = System.Drawing.Color.White
        Me.txtNum4.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNum4.Location = New System.Drawing.Point(416, 188)
        Me.txtNum4.MaxLength = 1
        Me.txtNum4.Multiline = True
        Me.txtNum4.Name = "txtNum4"
        Me.txtNum4.Size = New System.Drawing.Size(29, 29)
        Me.txtNum4.TabIndex = 12
        Me.txtNum4.Text = "0"
        Me.txtNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNum5
        '
        Me.txtNum5.BackColor = System.Drawing.Color.White
        Me.txtNum5.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNum5.Location = New System.Drawing.Point(457, 188)
        Me.txtNum5.MaxLength = 1
        Me.txtNum5.Multiline = True
        Me.txtNum5.Name = "txtNum5"
        Me.txtNum5.Size = New System.Drawing.Size(29, 29)
        Me.txtNum5.TabIndex = 11
        Me.txtNum5.Text = "0"
        Me.txtNum5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNum6
        '
        Me.txtNum6.BackColor = System.Drawing.Color.White
        Me.txtNum6.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNum6.Location = New System.Drawing.Point(498, 188)
        Me.txtNum6.MaxLength = 1
        Me.txtNum6.Multiline = True
        Me.txtNum6.Name = "txtNum6"
        Me.txtNum6.Size = New System.Drawing.Size(29, 29)
        Me.txtNum6.TabIndex = 10
        Me.txtNum6.Text = "0"
        Me.txtNum6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNum1
        '
        Me.txtNum1.BackColor = System.Drawing.Color.White
        Me.txtNum1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNum1.Location = New System.Drawing.Point(293, 188)
        Me.txtNum1.MaxLength = 1
        Me.txtNum1.Multiline = True
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(29, 29)
        Me.txtNum1.TabIndex = 9
        Me.txtNum1.Text = "0"
        Me.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbNumberList
        '
        Me.lbNumberList.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lbNumberList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbNumberList.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbNumberList.ForeColor = System.Drawing.Color.White
        Me.lbNumberList.FormattingEnabled = True
        Me.lbNumberList.ItemHeight = 21
        Me.lbNumberList.Location = New System.Drawing.Point(19, 188)
        Me.lbNumberList.Name = "lbNumberList"
        Me.lbNumberList.Size = New System.Drawing.Size(232, 210)
        Me.lbNumberList.TabIndex = 8
        '
        'lblNum7
        '
        Me.lblNum7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNum7.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNum7.ForeColor = System.Drawing.Color.White
        Me.lblNum7.Location = New System.Drawing.Point(571, 116)
        Me.lblNum7.Name = "lblNum7"
        Me.lblNum7.Size = New System.Drawing.Size(48, 45)
        Me.lblNum7.TabIndex = 7
        Me.lblNum7.Text = "0"
        Me.lblNum7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum5
        '
        Me.lblNum5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNum5.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNum5.ForeColor = System.Drawing.Color.Black
        Me.lblNum5.Location = New System.Drawing.Point(387, 116)
        Me.lblNum5.Name = "lblNum5"
        Me.lblNum5.Size = New System.Drawing.Size(48, 45)
        Me.lblNum5.TabIndex = 6
        Me.lblNum5.Text = "0"
        Me.lblNum5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum6
        '
        Me.lblNum6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNum6.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNum6.ForeColor = System.Drawing.Color.Black
        Me.lblNum6.Location = New System.Drawing.Point(479, 116)
        Me.lblNum6.Name = "lblNum6"
        Me.lblNum6.Size = New System.Drawing.Size(48, 45)
        Me.lblNum6.TabIndex = 5
        Me.lblNum6.Text = "0"
        Me.lblNum6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum2
        '
        Me.lblNum2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNum2.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNum2.ForeColor = System.Drawing.Color.Black
        Me.lblNum2.Location = New System.Drawing.Point(111, 116)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(48, 45)
        Me.lblNum2.TabIndex = 4
        Me.lblNum2.Text = "0"
        Me.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum3
        '
        Me.lblNum3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNum3.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNum3.ForeColor = System.Drawing.Color.Black
        Me.lblNum3.Location = New System.Drawing.Point(203, 116)
        Me.lblNum3.Name = "lblNum3"
        Me.lblNum3.Size = New System.Drawing.Size(48, 45)
        Me.lblNum3.TabIndex = 3
        Me.lblNum3.Text = "0"
        Me.lblNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum4
        '
        Me.lblNum4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNum4.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNum4.ForeColor = System.Drawing.Color.Black
        Me.lblNum4.Location = New System.Drawing.Point(295, 116)
        Me.lblNum4.Name = "lblNum4"
        Me.lblNum4.Size = New System.Drawing.Size(48, 45)
        Me.lblNum4.TabIndex = 2
        Me.lblNum4.Text = "0"
        Me.lblNum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum1
        '
        Me.lblNum1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNum1.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNum1.ForeColor = System.Drawing.Color.Black
        Me.lblNum1.Location = New System.Drawing.Point(19, 116)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(48, 45)
        Me.lblNum1.TabIndex = 1
        Me.lblNum1.Text = "0"
        Me.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTitle.Location = New System.Drawing.Point(217, 32)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(235, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "6+1 体育彩票选号器"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnMin)
        Me.Panel2.Controls.Add(Me.btnMax)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(667, 39)
        Me.Panel2.TabIndex = 1
        '
        'btnMin
        '
        Me.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMin.Location = New System.Drawing.Point(556, 9)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(29, 23)
        Me.btnMin.TabIndex = 2
        Me.btnMin.Text = "▁"
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMax.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMax.Location = New System.Drawing.Point(591, 9)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(29, 23)
        Me.btnMax.TabIndex = 1
        Me.btnMax.Text = "□"
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClose.Location = New System.Drawing.Point(626, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(29, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "×"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'RandomTimer
        '
        Me.RandomTimer.Interval = 50
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(667, 522)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "6+1体育彩票选号器"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum7 As Label
    Friend WithEvents lblNum5 As Label
    Friend WithEvents lblNum6 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents lblNum3 As Label
    Friend WithEvents lblNum4 As Label
    Friend WithEvents lbNumberList As ListBox
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtNum3 As TextBox
    Friend WithEvents txtNum4 As TextBox
    Friend WithEvents txtNum5 As TextBox
    Friend WithEvents txtNum6 As TextBox
    Friend WithEvents txtNum7 As TextBox
    Friend WithEvents lblGrpNum As Label
    Friend WithEvents btnGroupSelect As Button
    Friend WithEvents txtGrpNum As TextBox
    Friend WithEvents btnHandWriting As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnRandomSelect As Button
    Friend WithEvents RandomTimer As Timer
End Class
