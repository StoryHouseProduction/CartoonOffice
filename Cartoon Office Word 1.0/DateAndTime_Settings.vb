Public Class DateAndTime_Settings

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        My.Forms.Form1.TextDisplay.Text = My.Computer.Clock.LocalTime & vbCrLf & My.Forms.Form1.TextDisplay.Text
        My.Forms.Form1.TextDisplay.Select(0, 0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Forms.Form1.NewDateAndTimeToolStripMenuItem.Visible = True
        Me.Close()
    End Sub
End Class