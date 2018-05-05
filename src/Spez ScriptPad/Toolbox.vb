Public Class Toolbox

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Form1.FastColoredTextBox1.AppendText(ListView1.SelectedItems(0).SubItems(1).Text)
    End Sub
End Class