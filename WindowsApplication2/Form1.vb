Public Class Form1

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) _
        Handles txtCompany.TextChanged, txtAddress.TextChanged, txtWebsite.TextChanged

        Dim tb As TextBox = CType(sender, TextBox)

        If (String.IsNullOrEmpty(tb.Text)) Then
            tb.BackColor = Color.MistyRose
        Else
            tb.BackColor = Color.LightGreen
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        Dim c1 As Boolean = String.IsNullOrEmpty(txtCompany.Text)
        Dim c2 As Boolean = String.IsNullOrEmpty(txtAddress.Text)
        Dim c3 As Boolean = String.IsNullOrEmpty(txtWebsite.Text)

        If c1 Or c2 Or c3 Then
            MessageBox.Show("Incomplete.")
        Else
            MessageBox.Show("Complete.")
        End If

    End Sub
End Class
