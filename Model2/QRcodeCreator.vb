Imports ThoughtWorks.QRCode.Codec

Namespace Model2

    Public Class QRcodeCreator

#Region "根据链接生成二维码"


        Public Shared Function GetQRCodeBmp(url As String) As Image

            Dim QRCodeEncoder = New QRCodeEncoder()
            QRCodeEncoder.QRCodeEncodeMode = ThoughtWorks.QRCode.Codec.QRCodeEncoder.ENCODE_MODE.BYTE
            QRCodeEncoder.QRCodeScale = 4
            QRCodeEncoder.QRCodeVersion = 0
            QRCodeEncoder.QRCodeErrorCorrect = ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION.M

            Return QRCodeEncoder.Encode(url, System.Text.Encoding.UTF8)

        End Function

#End Region

    End Class

End Namespace