Public Class Form1

    Private Property AllText As String
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text Files(*.rtf)|*.rtf|Text Files(*.txt)|*.txt|Text Files|*.cartoonworddocement"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText( _
              SaveFileDialog1.FileName, TextDisplay.Text, False)
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Text Files(*.rtf)|*.rtf|Text Files(*.txt)|*.txt|Text Files|*.cartoonworddocement"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                AllText = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
                TextDisplay.Text = OpenFileDialog1.FileName
                TextDisplay.Text = AllText
            Catch ex As Exception
                MsgBox("An Error Occurred! Code:9721" & vbCrLf & ex.Message)
            End Try
        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub
    Private Sub NewDateAndTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewDateAndTimeToolStripMenuItem.Click
        My.Forms.DateAndTime_Settings.ShowDialog()
        NewDateAndTimeToolStripMenuItem.Visible = False
    End Sub
    
    Private Sub EnglishToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnglishToolStripMenuItem.Click
        FilesToolStripMenuItem.Text = "Files"
        OpenToolStripMenuItem.Text = "Open"
        SaveToolStripMenuItem.Text = "Save"
        InsertToolStripMenuItem.Text = "Insert"
        NewDateAndTimeToolStripMenuItem.Text = "New Date And Time"
        PrintToolStripMenuItem.Text = "Print"
        HelpToolStripMenuItem.Text = "Help"
        SettingToolStripMenuItem.Text = "Setting"
        GerenalToolStripMenuItem.Text = "Gerenal"
        LangageToolStripMenuItem.Text = "Langage"
        EnglishToolStripMenuItem.Text = "English"
        ThaiToolStripMenuItem.Text = "Thai"
        AboutThisProgramToolStripMenuItem.Text = "About This Program"
        My.Forms.DateAndTime_Settings.Label1.Text = "Please Change Date And Time"
        My.Forms.DateAndTime_Settings.Button1.Text = "Okay"
    End Sub

    Private Sub ThaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThaiToolStripMenuItem.Click
        FilesToolStripMenuItem.Text = "ไฟล์"
        OpenToolStripMenuItem.Text = "เปิด"
        SaveToolStripMenuItem.Text = "บักทึก"
        InsertToolStripMenuItem.Text = "แทรก"
        NewDateAndTimeToolStripMenuItem.Text = "เปลี่ยนการตั่งค่าวันและเวลา"
        PrintToolStripMenuItem.Text = "พิมพ์"
        HelpToolStripMenuItem.Text = "ช่วยเหลือ"
        SettingToolStripMenuItem.Text = "ตั้งค่า"
        GerenalToolStripMenuItem.Text = "ทั่วไป"
        LangageToolStripMenuItem.Text = "ภาษา"
        EnglishToolStripMenuItem.Text = "อังกฤษ"
        ThaiToolStripMenuItem.Text = "ไทย"
        AboutThisProgramToolStripMenuItem.Text = "เกี่ยวกับโปรแกรม"
        My.Forms.DateAndTime_Settings.Label1.Text = "กรุณาเปลี่ยนวันที่และเวลา"
    End Sub

    Private Sub AboutThisProgramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutThisProgramToolStripMenuItem.Click
        My.Forms.About.ShowDialog()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Forms.Startup_form.ShowDialog()
    End Sub
End Class
