<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Toolbox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("HTML Tools", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("JavaScript Tools", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Visual Basic Script Tools", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Header (Style: 1)", "<h1>Your Text Here</h1>"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Header (Style: 2)", "<h2>Your Text Here</h2>"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Paragraph", "<p>Your Text Here</p>"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Button", "<button type=""button"" onclick=""Code Here"">Your Text Here</button>"}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Input Box", "<input type=""text"" name=""ObjectNameHere"" value=""Your Value Here""><br>"}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Image", "<img src=""Image Link Here"" alt=""Altanative Text Here"" style=""width:Size Herepx;he" & _
                        "ight:SizeHerepx;"">"}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Input Box", "var person = prompt(""Your Text Here"", ""Your Value Here"");"}, -1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Message Box", "MsgBox ""Your Text Here"", Button Code , ""Your Title Here"""}, -1)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Input Box", "InputBox ""Your Text Here"" , ""Title Of Box Here"" , ""Your Value Here"" , X Position " & _
                        "Here , Y Position Here"}, -1)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ListViewGroup1.Header = "HTML Tools"
        ListViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup1.Name = "HTMLTools"
        ListViewGroup2.Header = "JavaScript Tools"
        ListViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup2.Name = "JavaScriptTools"
        ListViewGroup3.Header = "Visual Basic Script Tools"
        ListViewGroup3.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup3.Name = "VBTools"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        ListViewItem1.Group = ListViewGroup1
        ListViewItem2.Group = ListViewGroup1
        ListViewItem3.Group = ListViewGroup1
        ListViewItem4.Group = ListViewGroup1
        ListViewItem5.Group = ListViewGroup1
        ListViewItem6.Group = ListViewGroup1
        ListViewItem7.Group = ListViewGroup2
        ListViewItem8.Group = ListViewGroup3
        ListViewItem9.Group = ListViewGroup3
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9})
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(260, 337)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Tile
        '
        'Toolbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MinimumSize = New System.Drawing.Size(300, 400)
        Me.Name = "Toolbox"
        Me.Text = "Toolbox"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
