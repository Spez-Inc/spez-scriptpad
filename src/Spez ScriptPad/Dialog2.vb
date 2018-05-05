Imports System.Windows.Forms

Public Class Dialog2

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As String
        Dim b As String
        a = FindWhat1.Text
        b = InStr(Form1.FastColoredTextBox1.Text, a)
        If b Then
            Form1.FastColoredTextBox1.Focus()
            Form1.FastColoredTextBox1.SelectionStart = b - 1
            Form1.FastColoredTextBox1.SelectionLength = Len(a)
        Else
            MsgBox("No text founded.", vbExclamation, "Sorry!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Clipboard.Clear()
        Clipboard.Paste()
        Dim a As String
        Dim b As String
        a = FindWhat2.Text
        b = InStr(Form1.FastColoredTextBox1.Text, a)
        If b Then
            Form1.FastColoredTextBox1.Focus()
            Form1.FastColoredTextBox1.SelectionStart = b - 1
            Form1.FastColoredTextBox1.SelectionLength = Len(a)
            ReplaceWith.SelectAll()
            ReplaceWith.Copy()
            Form1.FastColoredTextBox1.Paste()
            Clipboard.SelectAll()
            Clipboard.Copy()
            Clipboard.SelectAll()
            Clipboard.Copy()
        Else
            MsgBox("No text founded!", vbExclamation, "Sorry!")
        End If
    End Sub
End Class
