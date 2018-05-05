Imports System.Text


Public Class Form1
    Dim w As IO.StreamWriter

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label2.Text = "a Free HTML, VBS, JS, etc. Editor_" Then
            Label2.Text = "a Free HTML, VBS, JS, etc. Editor"
        Else
            Label2.Text = "a Free HTML, VBS, JS, etc. Editor_"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.BackColor = Color.LightCoral
        PictureBox2.Visible = True
        Button2.BackColor = Color.Transparent
        PictureBox3.Visible = False
        Button3.BackColor = Color.Transparent
        PictureBox4.Visible = False
        NewScript.Visible = True
        OpenScript.Visible = False
        Tutorials.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button1.BackColor = Color.Transparent
        PictureBox2.Visible = False
        Button2.BackColor = Color.LightCoral
        PictureBox3.Visible = True
        Button3.BackColor = Color.Transparent
        PictureBox4.Visible = False
        NewScript.Visible = True
        OpenScript.Visible = True
        Tutorials.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button1.BackColor = Color.Transparent
        PictureBox2.Visible = False
        Button2.BackColor = Color.Transparent
        PictureBox3.Visible = False
        Button3.BackColor = Color.LightCoral
        PictureBox4.Visible = True
        NewScript.Visible = True
        OpenScript.Visible = True
        Tutorials.Visible = True
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        FastColoredTextBox1.Clear()
        Panel3.BackColor = Color.Silver
        Panel1.Visible = False
        NewScriptCodeToolStripMenuItem.Enabled = True
        ToolStripButton1.Enabled = True
        ToolStripButton3.Enabled = True
        ToolStripButton4.Enabled = True
        ToolStripButton6.Enabled = True
        ToolStripButton7.Enabled = True
        ToolStripButton8.Enabled = True
        ToolStripButton9.Enabled = True
        DebugToolStripMenuItem.Enabled = True
        SaveAsToolStripMenuItem.Enabled = True
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
        savebox.Show()
        EditToolStripMenuItem.Enabled = True
    End Sub

    Private Sub Panel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.Click
        FastColoredTextBox1.Clear()
        Panel3.BackColor = Color.Silver
        Panel1.Visible = False
        NewScriptCodeToolStripMenuItem.Enabled = True
        ToolStripButton1.Enabled = True
        ToolStripButton3.Enabled = True
        ToolStripButton4.Enabled = True
        ToolStripButton6.Enabled = True
        ToolStripButton7.Enabled = True
        ToolStripButton8.Enabled = True
        ToolStripButton9.Enabled = True
        DebugToolStripMenuItem.Enabled = True
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
        SaveAsToolStripMenuItem.Enabled = True
        savebox.Show()
        EditToolStripMenuItem.Enabled = True
    End Sub

    Private Sub PictureBox6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseHover
        Panel3.BackColor = Color.Gainsboro
    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        Panel3.BackColor = Color.White
    End Sub

    Private Sub Panel3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.MouseHover
        Panel3.BackColor = Color.Gainsboro
    End Sub

    Private Sub Panel3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.MouseLeave
        Panel3.BackColor = Color.White
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        FastColoredTextBox1.Clear()
        Panel3.BackColor = Color.Silver
        Panel1.Visible = False
        NewScriptCodeToolStripMenuItem.Enabled = True
        ToolStripButton1.Enabled = True
        ToolStripButton3.Enabled = True
        ToolStripButton4.Enabled = True
        ToolStripButton6.Enabled = True
        ToolStripButton7.Enabled = True
        ToolStripButton8.Enabled = True
        ToolStripButton9.Enabled = True
        DebugToolStripMenuItem.Enabled = True
        SaveAsToolStripMenuItem.Enabled = True
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
        savebox.Show()
        EditToolStripMenuItem.Enabled = True
    End Sub

    Private Sub Panel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.Click
        FastColoredTextBox1.Clear()
        Panel3.BackColor = Color.Silver
        Panel1.Visible = False
        NewScriptCodeToolStripMenuItem.Enabled = True
        ToolStripButton1.Enabled = True
        ToolStripButton3.Enabled = True
        ToolStripButton4.Enabled = True
        ToolStripButton6.Enabled = True
        ToolStripButton7.Enabled = True
        ToolStripButton8.Enabled = True
        ToolStripButton9.Enabled = True
        DebugToolStripMenuItem.Enabled = True
        SaveAsToolStripMenuItem.Enabled = True
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
        savebox.Show()
        EditToolStripMenuItem.Enabled = True
    End Sub

    Private Sub PictureBox8_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseHover
        Panel4.BackColor = Color.Gainsboro
    End Sub

    Private Sub PictureBox8_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseLeave
        Panel4.BackColor = Color.White
    End Sub

    Private Sub Panel4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.MouseHover
        Panel4.BackColor = Color.Gainsboro
    End Sub

    Private Sub Panel4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel4.MouseLeave
        Panel4.BackColor = Color.White
    End Sub

    Private Sub Panel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.Click
        FastColoredTextBox1.Clear()
        Panel5.BackColor = Color.Silver
        Panel1.Visible = False
        NewScriptCodeToolStripMenuItem.Enabled = True
        ToolStripButton1.Enabled = True
        ToolStripButton3.Enabled = True
        ToolStripButton4.Enabled = True
        ToolStripButton6.Enabled = True
        ToolStripButton7.Enabled = True
        ToolStripButton8.Enabled = True
        ToolStripButton9.Enabled = True
        DebugToolStripMenuItem.Enabled = True
        SaveAsToolStripMenuItem.Enabled = True
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS
        savebox.Show()
        EditToolStripMenuItem.Enabled = True
    End Sub

    Private Sub Panel5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.MouseHover
        Panel5.BackColor = Color.Gainsboro
    End Sub

    Private Sub Panel5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel5.MouseLeave
        Panel5.BackColor = Color.White
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        FastColoredTextBox1.Clear()
        Panel5.BackColor = Color.Silver
        Panel1.Visible = False
        NewScriptCodeToolStripMenuItem.Enabled = True
        ToolStripButton1.Enabled = True
        ToolStripButton3.Enabled = True
        ToolStripButton4.Enabled = True
        ToolStripButton6.Enabled = True
        ToolStripButton7.Enabled = True
        ToolStripButton8.Enabled = True
        ToolStripButton9.Enabled = True
        DebugToolStripMenuItem.Enabled = True
        SaveAsToolStripMenuItem.Enabled = True
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS
        savebox.Show()
        EditToolStripMenuItem.Enabled = True
    End Sub

    Private Sub PictureBox9_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseHover
        Panel5.BackColor = Color.Gainsboro
    End Sub

    Private Sub PictureBox9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseLeave
        Panel5.BackColor = Color.White
    End Sub

    Private Sub Panel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.Click
        FastColoredTextBox1.Clear()
        Panel6.BackColor = Color.Silver
        Panel1.Visible = False
        NewScriptCodeToolStripMenuItem.Enabled = True
        ToolStripButton1.Enabled = True
        ToolStripButton3.Enabled = True
        ToolStripButton4.Enabled = True
        ToolStripButton6.Enabled = True
        ToolStripButton7.Enabled = True
        ToolStripButton8.Enabled = True
        ToolStripButton9.Enabled = True
        DebugToolStripMenuItem.Enabled = True
        SaveAsToolStripMenuItem.Enabled = True
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB
        savebox.Show()
        EditToolStripMenuItem.Enabled = True
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        FastColoredTextBox1.Clear()
        Panel6.BackColor = Color.Silver
        Panel1.Visible = False
        NewScriptCodeToolStripMenuItem.Enabled = True
        ToolStripButton1.Enabled = True
        ToolStripButton3.Enabled = True
        ToolStripButton4.Enabled = True
        ToolStripButton6.Enabled = True
        ToolStripButton7.Enabled = True
        ToolStripButton8.Enabled = True
        ToolStripButton9.Enabled = True
        DebugToolStripMenuItem.Enabled = True
        SaveAsToolStripMenuItem.Enabled = True
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB
        savebox.Show()
        EditToolStripMenuItem.Enabled = True
    End Sub

    Private Sub PictureBox10_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.MouseHover
        Panel6.BackColor = Color.Gainsboro
    End Sub

    Private Sub PictureBox10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox10.MouseLeave
        Panel6.BackColor = Color.White
    End Sub

    Private Sub Panel6_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.MouseHover
        Panel6.BackColor = Color.Gainsboro
    End Sub

    Private Sub Panel6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel6.MouseLeave
        Panel6.BackColor = Color.White
    End Sub

    Private Sub NewScriptCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewScriptCodeToolStripMenuItem.Click
        NewScriptCodeToolStripMenuItem.Enabled = False
        Panel1.Show()
        ToolStripButton1.Enabled = False
        ToolStripButton3.Enabled = False
        ToolStripButton4.Enabled = False
        ToolStripButton6.Enabled = False
        ToolStripButton7.Enabled = False
        ToolStripButton8.Enabled = False
        ToolStripButton9.Enabled = False
        DebugToolStripMenuItem.Enabled = False
        SaveAsToolStripMenuItem.Enabled = False
        savebox.Hide()
        EditToolStripMenuItem.Enabled = False
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        NewScriptCodeToolStripMenuItem.Enabled = False
        Panel1.Show()
        ToolStripButton1.Enabled = False
        ToolStripButton3.Enabled = False
        ToolStripButton4.Enabled = False
        ToolStripButton6.Enabled = False
        ToolStripButton7.Enabled = False
        ToolStripButton8.Enabled = False
        ToolStripButton9.Enabled = False
        DebugToolStripMenuItem.Enabled = False
        SaveAsToolStripMenuItem.Enabled = False
        savebox.Hide()
        EditToolStripMenuItem.Enabled = False
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dialog1.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        If FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom Then
            MsgBox("Text Document is Not Executable File." & vbNewLine & "-------------------------------------------" & vbNewLine & "FastColoredTextbox.Language = txt" & vbNewLine & "FileControl.txtisexecutabe.ToString", vbExclamation, "''.txt'' is Not Executable File!")
        End If
        If FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML Then
            Form2.ShowDialog()
        End If
        If FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS Then
            Form2.ShowDialog()
        End If
        If FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB Then
            Form2.ShowDialog()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        savebox.Text = FastColoredTextBox1.Text
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Try
            Dim dlg As SaveFileDialog = New SaveFileDialog
            dlg.Filter = "Plain Text (.txt)|*.txt|Rich Text File (.rtf)|*.rtf|HTML Document (.html)|*.html|JavaScript Document (.js)|*.js|Visual Basic Script Document (.vbs)|*.vbs"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                savebox.SaveFile(dlg.FileName, RichTextBoxStreamType.PlainText)
            End If
        Catch ex As Exception
            MsgBox("Save Failed :(", vbCritical, "Failed")
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Start()
        savebox.Hide()
        Tutorials.Navigate("http://spezscriptpadtutorials.weebly.com/")
            Try
                Dim r As New IO.StreamReader(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData.ToString & "\LatestFiles" & ".txt")
                While (r.Peek() > -1)
                    ListBox1.Items.Add(r.ReadLine)
                    r.Close()
                End While
            Catch ex As Exception
                w = New IO.StreamWriter(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData.ToString & "\LatestFiles" & ".txt")
                w.Close()
                Dim r As New IO.StreamReader(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData.ToString & "\LatestFiles" & ".txt")
                While (r.Peek() > -1)
                    ListBox1.Items.Add(r.ReadLine)
                    r.Close()
                End While
            End Try
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        Try
            Dim dlg As SaveFileDialog = New SaveFileDialog
            dlg.Filter = "Plain Text (.txt)|*.txt|HTML Document (.html)|*.html|JavaScript Document (.js)|*.js|Visual Basic Script Document (.vbs)|*.vbs"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                savebox.SaveFile(dlg.FileName, RichTextBoxStreamType.PlainText)
            End If
        Catch ex As Exception
            MsgBox("Save Failed :(", vbCritical, "Failed")
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                NewScript.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
                FastColoredTextBox1.Text = NewScript.Text
                Panel3.BackColor = Color.Silver
                Panel1.Visible = False
                NewScriptCodeToolStripMenuItem.Enabled = True
                ToolStripButton1.Enabled = True
                ToolStripButton3.Enabled = True
                ToolStripButton4.Enabled = True
                ToolStripButton6.Enabled = True
                ToolStripButton7.Enabled = True
                ToolStripButton8.Enabled = True
                ToolStripButton9.Enabled = True
                DebugToolStripMenuItem.Enabled = True
                SaveAsToolStripMenuItem.Enabled = True
                savebox.Show()
                ListBox1.Items.Insert(0, OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox("Load Failed :(", vbCritical, "Failed")
        End Try
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        ToolStripButton2.PerformClick()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        FastColoredTextBox1.Undo()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        FastColoredTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        FastColoredTextBox1.Redo()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        FastColoredTextBox1.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        FastColoredTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        FastColoredTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        FastColoredTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        FastColoredTextBox1.SelectAll()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        If OpenFileDialog1.FilterIndex = 0 Then
            FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
        End If
        If OpenFileDialog1.FilterIndex = 1 Then
            FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
        End If
        If OpenFileDialog1.FilterIndex = 2 Then
            FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS
        End If
        If OpenFileDialog1.FilterIndex = 3 Then
            FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB
        End If
    End Sub

    Private Sub Panel7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel7.MouseLeave

    End Sub

    Private Sub Panel7_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel7.MouseHover
        Panel7.BackColor = Color.Gainsboro
    End Sub

    Private Sub Panel7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel7.Click
        If IntPtr.Size = 8 Then
            Shell("Apps/Spez-Shift-Editor (32 Bit)/sse.exe")
        ElseIf IntPtr.Size = 4 Then
            Shell("Apps/Spez Shift Editor (64 Bit)/sse.exe")
        End If
        Me.Close()
        End
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        If IntPtr.Size = 8 Then
            Shell("Apps/Spez-Shift-Editor (32 Bit)/sse.exe")
        ElseIf IntPtr.Size = 4 Then
            Shell("Apps/Spez Shift Editor (64 Bit)/sse.exe")
        End If
        Me.Close()
        End
    End Sub

    Private Sub PictureBox14_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.MouseHover
        Panel7.BackColor = Color.Gainsboro
    End Sub

    Private Sub PictureBox14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox14.MouseLeave
        Panel7.BackColor = Color.White
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        Dialog2.Show()
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaceToolStripMenuItem.Click
        Dialog2.Show()
        Dialog2.TabControl1.SelectedIndex = 1
    End Sub

    Private Sub CutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem1.Click
        FastColoredTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem1.Click
        FastColoredTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem1.Click
        FastColoredTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem1.Click
        FastColoredTextBox1.SelectAll()
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        FindToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        ReplaceToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        Toolbox.Show()
    End Sub

    Private Sub ShowToolboxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolboxToolStripMenuItem.Click
        Toolbox.Show()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim i As Integer
        Dim appPath As String = Application.StartupPath()
        w = New IO.StreamWriter(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData.ToString & "\LatestFiles" & ".txt")
        For i = 0 To ListBox1.Items.Count - 1
            w.WriteLine(ListBox1.Items.Item(i))
        Next
        w.Close()
    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Try
                NewScript.Text = My.Computer.FileSystem.ReadAllText(ListBox1.SelectedItem.ToString)
                FastColoredTextBox1.Text = NewScript.Text
                Panel3.BackColor = Color.Silver
                Panel1.Visible = False
                NewScriptCodeToolStripMenuItem.Enabled = True
                ToolStripButton1.Enabled = True
                ToolStripButton3.Enabled = True
                ToolStripButton4.Enabled = True
                ToolStripButton6.Enabled = True
                ToolStripButton7.Enabled = True
                ToolStripButton8.Enabled = True
                ToolStripButton9.Enabled = True
                DebugToolStripMenuItem.Enabled = True
                SaveAsToolStripMenuItem.Enabled = True
                savebox.Show()
        Catch ex As Exception
            MsgBox("Load Failed :(", vbCritical, "Failed")
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ToolStripButton2.PerformClick()
    End Sub

    Private Sub StartDebbugingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartDebbugingToolStripMenuItem.Click
        ToolStripButton4.PerformClick()
    End Sub

    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        Tutorials.GoBack()
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Tutorials.GoForward()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Tutorials.Refresh()
    End Sub

    Private Sub SpezScriptPadTutorialsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpezScriptPadTutorialsToolStripMenuItem.Click
        Process.Start("http://spezscriptpadtutorials.weebly.com/")
    End Sub
End Class
