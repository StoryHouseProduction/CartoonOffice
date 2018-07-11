Public Class HelpForm

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        MsgBox("หากคุณไม่เข้าใจ กรุณาอ่านข้อมูลของแอปพิเคชั้นก่อนใช่งาน", MsgBoxStyle.Information)
        My.Forms.About.ShowDialog()
    End Sub
End Class