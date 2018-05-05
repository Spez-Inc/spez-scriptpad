Public Class Form2

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Close()
        If Form1.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML Then
            Process.Start(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData.ToString & "\debug.html")
        End If
        If Form1.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS Then
            Process.Start(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData.ToString & "\debug.js")
        End If
        If Form1.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB Then
            Process.Start(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData.ToString & "\debug.vbs")
        End If
        Timer1.Enabled = False
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        If Form1.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML Then
            Form1.savebox.SaveFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData.ToString & "debug.html", RichTextBoxStreamType.PlainText)
        End If
        If Form1.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS Then
            Form1.savebox.SaveFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData.ToString & "debug.js", RichTextBoxStreamType.PlainText)
        End If
        If Form1.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB Then
            Form1.savebox.SaveFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData.ToString & "\debug.vbs", RichTextBoxStreamType.PlainText)
        End If
    End Sub
End Class