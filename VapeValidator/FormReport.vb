Imports VapeID.Classes

Public Class FormReport

    Private Property AutocloseCount As Integer = 0
    Sub New(id As Identity)

        ' This call is required by the designer.
        InitializeComponent()

        Me.WindowState = FormWindowState.Maximized

        Dim reasonLog As String = ""

        If id.IsUnderAge Then
            If My.Settings.UseSounds Then
                My.Computer.Audio.Play($"{Application.StartupPath}\Sounds\underage.wav")
            End If
            MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Red
            LabelReason.Text = "Under age! Sales prohibited."
            reasonLog = "Under age"
        End If

        If id.IsExpired Then
            If My.Settings.UseSounds Then
                My.Computer.Audio.Play($"{Application.StartupPath}\Sounds\expiredid.wav")
            End If
            MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Red
            LabelReason.Text = "ID Expired! Sales prohibited."
            reasonLog = "ID Expired"
        End If

        If Not id.IsUnderAge AndAlso Not id.IsExpired Then
            If My.Settings.UseSounds Then
                My.Computer.Audio.Play($"{Application.StartupPath}\sounds\passed.wav")
            End If
            MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Green
            LabelReason.Text = "No restrictions found!"
            reasonLog = "No restrictions"
        End If

        LabelName.Text = $"Name: {id.FirstName} {id.LastName}"
        LabelAge.Text = $"Age: {id.Age}"

        If My.Settings.AutoClose Then
            Timer1.Enabled = True
            MetroProgressSpinner1.Maximum = My.Settings.AutoCloseTimeout
            MetroProgressSpinner1.Enabled = True
            MetroProgressSpinner1.Visible = True
        End If

        writeLog($"{DateTime.Now.ToShortTimeString} - {id.FirstName} {id.LastName} - {id.ID} - {id.Age} - {id.State} - {reasonLog}")

    End Sub

    Private Sub writeLog(data As String)
        If Not IO.Directory.Exists($"{Application.StartupPath}\logs") Then IO.Directory.CreateDirectory($"{Application.StartupPath}\logs")
        Debug.WriteLine(data)
        My.Computer.FileSystem.WriteAllText($"{Application.StartupPath}\logs\{Date.Now.Date.ToShortDateString.Replace("/", "-")}.txt", data & vbCrLf, True)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        AutocloseCount += 1
        MetroProgressSpinner1.Value = AutocloseCount - 1
        If AutocloseCount >= My.Settings.AutoCloseTimeout Then
            Me.Close()
        End If
    End Sub


End Class