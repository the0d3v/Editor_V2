Public Class editor_form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t As New TabPage : Dim n As New FastColoredTextBoxNS.FastColoredTextBox

        t.Text = name.Text

        n.Dock = DockStyle.Fill : t.Controls.Add(n)
        Me.TabControl1.Controls.Add(t)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CType(Me.TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Language = FastColoredTextBoxNS.Language.CSharp
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CType(Me.TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Language = FastColoredTextBoxNS.Language.VB
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CType(Me.TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Language = FastColoredTextBoxNS.Language.HTML
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
End Class