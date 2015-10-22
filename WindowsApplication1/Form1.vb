Public Class Form1

    Private winnerIcon As Bitmap
    Private answer As Integer = (New Random()).Next(1, 3)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        winnerIcon = Bitmap.FromFile(Environment.CurrentDirectory + "\ph\pic.png")

    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles cmdItem3.Click, cmdItem2.Click, cmdItem1.Click

        Dim button As Button = CType(sender, Button)

        If (button.Name.EndsWith(answer.ToString())) Then

            button.BackgroundImage = winnerIcon
            button.BackgroundImageLayout = ImageLayout.Stretch
            lblMessage.Text = "Right Answer."

        Else

            lblMessage.Text = "Wrong Answer."

        End If

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click

        Application.Exit()

    End Sub

    Private Sub cmdReplay_Click(sender As Object, e As EventArgs) Handles cmdReplay.Click

        answer = (New Random()).Next(1, 3)
        lblMessage.Text = "Play~"

        cmdItem1.BackgroundImage = Nothing
        cmdItem2.BackgroundImage = Nothing
        cmdItem3.BackgroundImage = Nothing


    End Sub

    Private Sub cmdItem1_MouseMove(sender As Object, e As MouseEventArgs) Handles cmdItem1.MouseMove

        cmdItem1.BackColor = Color.Aqua

    End Sub

    Private Sub cmdItem1_MouseLeave(sender As Object, e As EventArgs) Handles cmdItem1.MouseLeave

        cmdItem1.BackColor = DefaultBackColor

    End Sub
End Class
