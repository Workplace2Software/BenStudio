Public Class Form1
    Dim r As New Random
    Dim img As Integer
    Dim tune As Integer
    Private Sub Song1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Song1.MouseHover
        My.Computer.Audio.Play(My.Resources.Tune1, AudioPlayMode.Background)
    End Sub

    Private Sub Song2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Song2.MouseHover
        My.Computer.Audio.Play(My.Resources.Tune2, AudioPlayMode.Background)
    End Sub

    Private Sub Song3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Song3.MouseHover
        My.Computer.Audio.Play(My.Resources.Tune3, AudioPlayMode.Background)
    End Sub

    Private Sub Song4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Song4.MouseHover
        My.Computer.Audio.Play(My.Resources.Tune4, AudioPlayMode.Background)
    End Sub

    Private Sub Song5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Song5.MouseHover
        My.Computer.Audio.Play(My.Resources.Tune5, AudioPlayMode.Background)
    End Sub

    Private Sub Song6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Song6.MouseHover
        My.Computer.Audio.Play(My.Resources.Tune6, AudioPlayMode.Background)
    End Sub

    Private Sub Go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Go.Click
        My.Computer.Audio.Play(My.Resources.Selection, AudioPlayMode.WaitToComplete)
        Select Case img
            Case 1
                PictureBox1.Image = My.Resources.Ben1
            Case 2
                PictureBox1.Image = My.Resources.Ben2
            Case 3
                PictureBox1.Image = My.Resources.Ben3
            Case 4
                PictureBox1.Image = My.Resources.Ben4
            Case 5
                PictureBox1.Image = My.Resources.Ben5
            Case 6
                PictureBox1.Image = My.Resources.Ben6
        End Select
        Application.DoEvents()
        Select Case tune
            Case 1
                My.Computer.Audio.Play(My.Resources.Tune1, AudioPlayMode.WaitToComplete)
            Case 2
                My.Computer.Audio.Play(My.Resources.Tune2, AudioPlayMode.WaitToComplete)
            Case 3
                My.Computer.Audio.Play(My.Resources.Tune3, AudioPlayMode.WaitToComplete)
            Case 4
                My.Computer.Audio.Play(My.Resources.Tune4, AudioPlayMode.WaitToComplete)
            Case 5
                My.Computer.Audio.Play(My.Resources.Tune5, AudioPlayMode.WaitToComplete)
            Case 6
                My.Computer.Audio.Play(My.Resources.Tune6, AudioPlayMode.WaitToComplete)
        End Select
        If img = 1 And tune = 1 And My.Settings.Pro = False Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            MessageBox.Show("Happy Ben is not available in the Free version of Ben Studio. Please go to our website to purchase the full version.")
            Me.Hide()
            My.Computer.Audio.Play(My.Resources.ExpressingAnger, AudioPlayMode.Background)
            Timer1.Start()
        End If
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Song1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Song1.Click
        My.Computer.Audio.Play(My.Resources.Selection, AudioPlayMode.Background)
        tune = 1
    End Sub

    Private Sub Song2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Song2.Click
        My.Computer.Audio.Play(My.Resources.Selection, AudioPlayMode.Background)
        tune = 2
    End Sub

    Private Sub Song3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Song3.Click
        My.Computer.Audio.Play(My.Resources.Selection, AudioPlayMode.Background)
        tune = 3
    End Sub

    Private Sub Song4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Song4.Click
        My.Computer.Audio.Play(My.Resources.Selection, AudioPlayMode.Background)
        tune = 4
    End Sub

    Private Sub Song5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Song5.Click
        My.Computer.Audio.Play(My.Resources.Selection, AudioPlayMode.Background)
        tune = 5
    End Sub

    Private Sub Song6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Song6.Click
        My.Computer.Audio.Play(My.Resources.Selection, AudioPlayMode.Background)
        tune = 6
    End Sub

    Private Sub Img1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Img1.Click
        My.Computer.Audio.Play(My.Resources.Selection, AudioPlayMode.Background)
        img = 1
    End Sub

    Private Sub Img2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Img2.Click
        My.Computer.Audio.Play(My.Resources.Selection, AudioPlayMode.Background)
        img = 2
    End Sub

    Private Sub Img3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Img3.Click
        My.Computer.Audio.Play(My.Resources.Selection, AudioPlayMode.Background)
        img = 3
    End Sub

    Private Sub Img4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Img4.Click
        My.Computer.Audio.Play(My.Resources.Selection, AudioPlayMode.Background)
        img = 4
    End Sub

    Private Sub Img5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Img5.Click
        My.Computer.Audio.Play(My.Resources.Selection, AudioPlayMode.Background)
        img = 5
    End Sub

    Private Sub Img6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Img6.Click
        My.Computer.Audio.Play(My.Resources.Selection, AudioPlayMode.Background)
        img = 6
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Application.Exit()
        End
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If r.Next(1, 3) = 1 Then
            Try
                Process.Start("C:\Program Files\Workplace2Software\BenStudio\GoPro.jpg")
            Catch ex As Exception
                MessageBox.Show("By going pro, you can:" & Environment.NewLine & Environment.NewLine & "* Unlock all Bens (including canny ben)" & Environment.NewLine & "* Unlock the ability to install Super Idol Canny pack. (uncanny not included)" & Environment.NewLine & "* Unlock technical support" & Environment.NewLine & Environment.NewLine & "All of this, AND MORE from only **7 easy payments** of $79.99!" & Environment.NewLine & "Order TODAY at theworkplace.tk/ben-studio")
            End Try
        End If
    End Sub

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If My.Settings.Pro = True Then
            Me.Text = "Ben Studio (Registered)"
        End If
    End Sub
End Class
