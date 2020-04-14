Public Class AdvancedPrint

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Forms.Form1.PrintDialog1.Document = My.Forms.Form1.PrintDocument1
        My.Forms.Form1.PrintDialog1.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Forms.Form1.PrintPreviewDialog1.Document = My.Forms.Form1.PrintDocument1
        My.Forms.Form1.PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Forms.Form1.PrintDialog1.Document = My.Forms.Form1.PrintDocument1
        My.Forms.Form1.PrintDocument1.Print()
    End Sub
End Class