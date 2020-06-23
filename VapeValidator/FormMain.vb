Imports AutoUpdaterDotNET
Imports VapeID.Classes
Public Class FormMain

    Private ReadOnly _parser As New IdParser

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetSettings()

        Me.Text = $"VapeID {My.Application.Info.Version.Major}.{My.Application.Info.Version.Minor}.{My.Application.Info.Version.Build}"

        AutoUpdater.UpdateFormSize = New Size(600, 300)
        AutoUpdater.Start("http://lolskinview.com/vapeid/update.xml")

    End Sub
    Private Sub ButtonValidate_Click(sender As Object, e As EventArgs) Handles ButtonValidate.Click
        ValidateAndScan()
    End Sub
    Sub GetSettings()
        TextScanTimeout.Text = My.Settings.ScanTimeout
        ToggleSounds.Checked = My.Settings.UseSounds
        ToggleCloseReports.Checked = My.Settings.AutoClose
        ToggleAutoVerify.Checked = My.Settings.AutoVerify
        ToggleMaskANSI.Checked = My.Settings.MaskANSI
        TextCloseTimeout.Enabled = ToggleCloseReports.Checked
        TextCloseTimeout.Text = My.Settings.AutoCloseTimeout
        TextMinAge.Text = My.Settings.MinAgeOfPurchase

        TextRaw.DelayedTextChangedTimeout = My.Settings.ScanTimeout

        If My.Settings.AutoVerify Then
            ButtonValidate.Enabled = False
            ButtonValidate.Text = "Validate ID (AutoEnabled)"
        Else
            ButtonValidate.Enabled = True
            ButtonValidate.Text = "Validate ID"
        End If

        If My.Settings.MaskANSI Then
            TextRaw.PasswordChar = "*"
        Else
            TextRaw.PasswordChar = ""
        End If

    End Sub
    Sub SaveSettings()
        My.Settings.UseSounds = ToggleSounds.Checked
        My.Settings.ScanTimeout = TextScanTimeout.Text
        My.Settings.MinAgeOfPurchase = TextMinAge.Text
        My.Settings.AutoCloseTimeout = TextCloseTimeout.Text
        My.Settings.AutoClose = ToggleCloseReports.Checked
        My.Settings.MaskANSI = ToggleMaskANSI.Checked
        My.Settings.AutoVerify = ToggleAutoVerify.Checked
        My.Settings.Save()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        SaveSettings()
        GetSettings()
    End Sub

    Private Sub ToggleCloseReports_CheckedChanged(sender As Object, e As EventArgs) Handles ToggleCloseReports.CheckedChanged
        TextCloseTimeout.Enabled = ToggleCloseReports.Checked
    End Sub

    Private Sub ValidateAndScan()

        Try

            Dim ID = _parser.ParseData(TextRaw.Text)

            If ID IsNot Nothing Then
                TextRaw.Text = ""
                LabelStatus.Text = "Status: Validation finished."
                Me.TopMost = False
                Dim formReport As New FormReport(ID)
                formReport.ShowDialog()
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub FormMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TextRaw.Select()
    End Sub

    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged
        If MetroTabControl1.SelectedIndex = 0 Then
            TextRaw.Select()
        End If
    End Sub

    Private Sub FormMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        TextRaw.Select()
    End Sub

    Private Sub FormMain_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        TextRaw.Select()
    End Sub

    Private Sub TextRaw_DelayedTextChanged(sender As Object, e As EventArgs) Handles TextRaw.DelayedTextChanged
        If My.Settings.AutoVerify Then
            ValidateAndScan()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("https://www.paypal.me/lolskinview")
    End Sub

    Private Sub RunTests()
        Try
            For Each file In IO.Directory.GetFiles("INCLUDED-LICENSE-FOLDER")
                Dim ID = _parser.ParseData(IO.File.ReadAllText(file))
                Debug.WriteLine($"{ID.FirstName} {ID.LastName} - {ID.ID} - ID Expired: {ID.IsExpired} - Under Age: {ID.IsUnderAge} - {ID.State}")
            Next
        Catch ex As Exception

        End Try
    End Sub

End Class
