Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim id As Single
        id = InputBox("請輸入您喜歡的號碼(0~9)", "輸入顯示")
        MsgBox("你的幸運號碼是:" & id & vbCrLf & "good luck to you.")
    End Sub
End Class
