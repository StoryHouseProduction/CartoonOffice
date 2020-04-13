Public Class Form1
    Private Property AllText As String
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text Files(*.rtf)|*.rtf|Text Files(*.txt)|*.txt|Cartoon Office Word Docuement|*.cwd"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText( _
              SaveFileDialog1.FileName, TextDisplay.Text, False)
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Text Files(*.rtf)|*.rtf|Text Files(*.txt)|*.txt|Cartoon Office Word Docuement|*.cwd|Cartoon Office Word Docuement (Alpha Release)|*.cartoonworddocement"
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
    Private Sub NewDateAndTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewDateAndTimeToolStripMenuItem.Click
        TextDisplay.Text = My.Computer.Clock.LocalTime & vbCrLf & TextDisplay.Text
        TextDisplay.Select(0, 0)
    End Sub
    
    Private Sub EnglishToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnglishToolStripMenuItem.Click
        FilesToolStripMenuItem.Text = "Files"
        OpenToolStripMenuItem.Text = "Open"
        SaveToolStripMenuItem.Text = "Save"
        InsertToolStripMenuItem.Text = "Insert"
        NewDateAndTimeToolStripMenuItem.Text = "Type Date and Time"
        PrintToolStripMenuItem.Text = "Print"
        HelpToolStripMenuItem.Text = "Help"
        SettingToolStripMenuItem.Text = "Setting"
        GerenalToolStripMenuItem.Text = "Gerenal"
        LangageToolStripMenuItem.Text = "Langage"
        EnglishToolStripMenuItem.Text = "English"
        ThaiToolStripMenuItem.Text = "Thai"
        AboutThisProgramToolStripMenuItem.Text = "About This Program"
        HelpToolStripMenuItem1.Text = "Help"
    End Sub

    Private Sub ThaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThaiToolStripMenuItem.Click
        FilesToolStripMenuItem.Text = "ไฟล์"
        OpenToolStripMenuItem.Text = "เปิด"
        SaveToolStripMenuItem.Text = "บักทึก"
        InsertToolStripMenuItem.Text = "แทรก"
        NewDateAndTimeToolStripMenuItem.Text = "พิมพ์วันที่และเวลา"
        PrintToolStripMenuItem.Text = "พิมพ์"
        HelpToolStripMenuItem.Text = "ช่วยเหลือ"
        SettingToolStripMenuItem.Text = "ตั้งค่า"
        GerenalToolStripMenuItem.Text = "ทั่วไป"
        LangageToolStripMenuItem.Text = "ภาษา"
        EnglishToolStripMenuItem.Text = "อังกฤษ"
        ThaiToolStripMenuItem.Text = "ไทย"
        AboutThisProgramToolStripMenuItem.Text = "เกี่ยวกับโปรแกรม"
        HelpToolStripMenuItem1.Text = "ช่วยเหลือ"
    End Sub

    Private Sub AboutThisProgramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutThisProgramToolStripMenuItem.Click
        My.Forms.About.ShowDialog()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Forms.Startup_form.ShowDialog()
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(TextDisplay.Text, TextDisplay.Font, Brushes.Black, 100, 100)
        e.Graphics.PageUnit = GraphicsUnit.Inch
    End Sub

    Private Sub EasyMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EasyMenuToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        My.Forms.Help.ShowDialog()
    End Sub

    Private Sub AdvancedMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvancedMenuToolStripMenuItem.Click
        My.Forms.AdvancedPrint.ShowDialog()
    End Sub
End Class
