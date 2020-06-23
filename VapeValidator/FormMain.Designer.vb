<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.LabelStatus = New MetroFramework.Controls.MetroLabel()
        Me.ButtonValidate = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.TextScanTimeout = New MetroFramework.Controls.MetroTextBox()
        Me.LabelScanTimeout = New MetroFramework.Controls.MetroLabel()
        Me.ButtonSave = New MetroFramework.Controls.MetroButton()
        Me.LabelSounds = New MetroFramework.Controls.MetroLabel()
        Me.ToggleSounds = New MetroFramework.Controls.MetroToggle()
        Me.TextMinAge = New MetroFramework.Controls.MetroTextBox()
        Me.LabelMinAgeReq = New MetroFramework.Controls.MetroLabel()
        Me.TextCloseTimeout = New MetroFramework.Controls.MetroTextBox()
        Me.LabelAutoCloseTimeout = New MetroFramework.Controls.MetroLabel()
        Me.LabelAutoCloseReports = New MetroFramework.Controls.MetroLabel()
        Me.ToggleCloseReports = New MetroFramework.Controls.MetroToggle()
        Me.LabelIDAlert = New MetroFramework.Controls.MetroLabel()
        Me.LabelBehaviorOptions = New MetroFramework.Controls.MetroLabel()
        Me.LabelMaskANSI = New MetroFramework.Controls.MetroLabel()
        Me.ToggleMaskANSI = New MetroFramework.Controls.MetroToggle()
        Me.LabelAutoVerify = New MetroFramework.Controls.MetroLabel()
        Me.ToggleAutoVerify = New MetroFramework.Controls.MetroToggle()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextRaw = New VapeID.TimedTextBox()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.CustomBackground = False
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Medium
        Me.MetroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Light
        Me.MetroTabControl1.Location = New System.Drawing.Point(20, 60)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(453, 193)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTabControl1.StyleManager = Nothing
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabControl1.UseStyleColors = False
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.TextRaw)
        Me.MetroTabPage1.Controls.Add(Me.LabelStatus)
        Me.MetroTabPage1.Controls.Add(Me.ButtonValidate)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.CustomBackground = False
        Me.MetroTabPage1.HorizontalScrollbar = False
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(445, 154)
        Me.MetroTabPage1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTabPage1.StyleManager = Nothing
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "ID Scanner"
        Me.MetroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabPage1.VerticalScrollbar = False
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'LabelStatus
        '
        Me.LabelStatus.CustomBackground = False
        Me.LabelStatus.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.LabelStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.LabelStatus.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.LabelStatus.Location = New System.Drawing.Point(207, 132)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(235, 19)
        Me.LabelStatus.Style = MetroFramework.MetroColorStyle.Blue
        Me.LabelStatus.StyleManager = Nothing
        Me.LabelStatus.TabIndex = 5
        Me.LabelStatus.Text = "Status: Waiting for scan..."
        Me.LabelStatus.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LabelStatus.UseStyleColors = False
        '
        'ButtonValidate
        '
        Me.ButtonValidate.Highlight = False
        Me.ButtonValidate.Location = New System.Drawing.Point(6, 125)
        Me.ButtonValidate.Name = "ButtonValidate"
        Me.ButtonValidate.Size = New System.Drawing.Size(183, 33)
        Me.ButtonValidate.Style = MetroFramework.MetroColorStyle.Blue
        Me.ButtonValidate.StyleManager = Nothing
        Me.ButtonValidate.TabIndex = 4
        Me.ButtonValidate.Text = "Validate ID"
        Me.ButtonValidate.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.CustomBackground = False
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.MetroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.MetroLabel1.Location = New System.Drawing.Point(6, 15)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel1.StyleManager = Nothing
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "ANSI Data:"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel1.UseStyleColors = False
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.TextScanTimeout)
        Me.MetroTabPage2.Controls.Add(Me.LabelScanTimeout)
        Me.MetroTabPage2.Controls.Add(Me.ButtonSave)
        Me.MetroTabPage2.Controls.Add(Me.LabelSounds)
        Me.MetroTabPage2.Controls.Add(Me.ToggleSounds)
        Me.MetroTabPage2.Controls.Add(Me.TextMinAge)
        Me.MetroTabPage2.Controls.Add(Me.LabelMinAgeReq)
        Me.MetroTabPage2.Controls.Add(Me.TextCloseTimeout)
        Me.MetroTabPage2.Controls.Add(Me.LabelAutoCloseTimeout)
        Me.MetroTabPage2.Controls.Add(Me.LabelAutoCloseReports)
        Me.MetroTabPage2.Controls.Add(Me.ToggleCloseReports)
        Me.MetroTabPage2.Controls.Add(Me.LabelIDAlert)
        Me.MetroTabPage2.Controls.Add(Me.LabelBehaviorOptions)
        Me.MetroTabPage2.Controls.Add(Me.LabelMaskANSI)
        Me.MetroTabPage2.Controls.Add(Me.ToggleMaskANSI)
        Me.MetroTabPage2.Controls.Add(Me.LabelAutoVerify)
        Me.MetroTabPage2.Controls.Add(Me.ToggleAutoVerify)
        Me.MetroTabPage2.CustomBackground = False
        Me.MetroTabPage2.HorizontalScrollbar = False
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(445, 154)
        Me.MetroTabPage2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTabPage2.StyleManager = Nothing
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Settings"
        Me.MetroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabPage2.VerticalScrollbar = False
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'TextScanTimeout
        '
        Me.TextScanTimeout.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TextScanTimeout.FontWeight = MetroFramework.MetroTextBoxWeight.Regular
        Me.TextScanTimeout.Location = New System.Drawing.Point(122, 116)
        Me.TextScanTimeout.Multiline = False
        Me.TextScanTimeout.Name = "TextScanTimeout"
        Me.TextScanTimeout.SelectedText = ""
        Me.TextScanTimeout.Size = New System.Drawing.Size(50, 22)
        Me.TextScanTimeout.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextScanTimeout.StyleManager = Nothing
        Me.TextScanTimeout.TabIndex = 17
        Me.TextScanTimeout.Text = "500"
        Me.TextScanTimeout.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextScanTimeout.UseStyleColors = False
        '
        'LabelScanTimeout
        '
        Me.LabelScanTimeout.AutoSize = True
        Me.LabelScanTimeout.CustomBackground = False
        Me.LabelScanTimeout.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.LabelScanTimeout.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.LabelScanTimeout.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.LabelScanTimeout.Location = New System.Drawing.Point(3, 116)
        Me.LabelScanTimeout.Name = "LabelScanTimeout"
        Me.LabelScanTimeout.Size = New System.Drawing.Size(118, 19)
        Me.LabelScanTimeout.Style = MetroFramework.MetroColorStyle.Blue
        Me.LabelScanTimeout.StyleManager = Nothing
        Me.LabelScanTimeout.TabIndex = 16
        Me.LabelScanTimeout.Text = "Scan Timeout(MS):"
        Me.LabelScanTimeout.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LabelScanTimeout.UseStyleColors = False
        '
        'ButtonSave
        '
        Me.ButtonSave.Highlight = False
        Me.ButtonSave.Location = New System.Drawing.Point(208, 130)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(179, 25)
        Me.ButtonSave.Style = MetroFramework.MetroColorStyle.Blue
        Me.ButtonSave.StyleManager = Nothing
        Me.ButtonSave.TabIndex = 11
        Me.ButtonSave.Text = "Apply"
        Me.ButtonSave.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'LabelSounds
        '
        Me.LabelSounds.AutoSize = True
        Me.LabelSounds.CustomBackground = False
        Me.LabelSounds.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.LabelSounds.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.LabelSounds.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.LabelSounds.Location = New System.Drawing.Point(3, 91)
        Me.LabelSounds.Name = "LabelSounds"
        Me.LabelSounds.Size = New System.Drawing.Size(97, 19)
        Me.LabelSounds.Style = MetroFramework.MetroColorStyle.Blue
        Me.LabelSounds.StyleManager = Nothing
        Me.LabelSounds.TabIndex = 15
        Me.LabelSounds.Text = "Enable Sounds:"
        Me.LabelSounds.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LabelSounds.UseStyleColors = False
        '
        'ToggleSounds
        '
        Me.ToggleSounds.AutoSize = True
        Me.ToggleSounds.CustomBackground = False
        Me.ToggleSounds.DisplayStatus = False
        Me.ToggleSounds.FontSize = MetroFramework.MetroLinkSize.Small
        Me.ToggleSounds.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.ToggleSounds.Location = New System.Drawing.Point(122, 93)
        Me.ToggleSounds.Name = "ToggleSounds"
        Me.ToggleSounds.Size = New System.Drawing.Size(50, 17)
        Me.ToggleSounds.Style = MetroFramework.MetroColorStyle.Blue
        Me.ToggleSounds.StyleManager = Nothing
        Me.ToggleSounds.TabIndex = 14
        Me.ToggleSounds.Text = "~StatusOff"
        Me.ToggleSounds.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ToggleSounds.UseStyleColors = False
        Me.ToggleSounds.UseVisualStyleBackColor = True
        '
        'TextMinAge
        '
        Me.TextMinAge.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TextMinAge.FontWeight = MetroFramework.MetroTextBoxWeight.Regular
        Me.TextMinAge.Location = New System.Drawing.Point(335, 101)
        Me.TextMinAge.Multiline = False
        Me.TextMinAge.Name = "TextMinAge"
        Me.TextMinAge.SelectedText = ""
        Me.TextMinAge.Size = New System.Drawing.Size(50, 22)
        Me.TextMinAge.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextMinAge.StyleManager = Nothing
        Me.TextMinAge.TabIndex = 13
        Me.TextMinAge.Text = "21"
        Me.TextMinAge.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextMinAge.UseStyleColors = False
        '
        'LabelMinAgeReq
        '
        Me.LabelMinAgeReq.AutoSize = True
        Me.LabelMinAgeReq.CustomBackground = False
        Me.LabelMinAgeReq.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.LabelMinAgeReq.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.LabelMinAgeReq.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.LabelMinAgeReq.Location = New System.Drawing.Point(206, 101)
        Me.LabelMinAgeReq.Name = "LabelMinAgeReq"
        Me.LabelMinAgeReq.Size = New System.Drawing.Size(123, 19)
        Me.LabelMinAgeReq.Style = MetroFramework.MetroColorStyle.Blue
        Me.LabelMinAgeReq.StyleManager = Nothing
        Me.LabelMinAgeReq.TabIndex = 12
        Me.LabelMinAgeReq.Text = "Minimum Age Req:"
        Me.LabelMinAgeReq.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LabelMinAgeReq.UseStyleColors = False
        '
        'TextCloseTimeout
        '
        Me.TextCloseTimeout.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TextCloseTimeout.FontWeight = MetroFramework.MetroTextBoxWeight.Regular
        Me.TextCloseTimeout.Location = New System.Drawing.Point(335, 73)
        Me.TextCloseTimeout.Multiline = False
        Me.TextCloseTimeout.Name = "TextCloseTimeout"
        Me.TextCloseTimeout.SelectedText = ""
        Me.TextCloseTimeout.Size = New System.Drawing.Size(50, 22)
        Me.TextCloseTimeout.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextCloseTimeout.StyleManager = Nothing
        Me.TextCloseTimeout.TabIndex = 10
        Me.TextCloseTimeout.Text = "10"
        Me.TextCloseTimeout.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextCloseTimeout.UseStyleColors = False
        '
        'LabelAutoCloseTimeout
        '
        Me.LabelAutoCloseTimeout.AutoSize = True
        Me.LabelAutoCloseTimeout.CustomBackground = False
        Me.LabelAutoCloseTimeout.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.LabelAutoCloseTimeout.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.LabelAutoCloseTimeout.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.LabelAutoCloseTimeout.Location = New System.Drawing.Point(256, 73)
        Me.LabelAutoCloseTimeout.Name = "LabelAutoCloseTimeout"
        Me.LabelAutoCloseTimeout.Size = New System.Drawing.Size(75, 19)
        Me.LabelAutoCloseTimeout.Style = MetroFramework.MetroColorStyle.Blue
        Me.LabelAutoCloseTimeout.StyleManager = Nothing
        Me.LabelAutoCloseTimeout.TabIndex = 9
        Me.LabelAutoCloseTimeout.Text = "Timeout(S):"
        Me.LabelAutoCloseTimeout.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LabelAutoCloseTimeout.UseStyleColors = False
        '
        'LabelAutoCloseReports
        '
        Me.LabelAutoCloseReports.AutoSize = True
        Me.LabelAutoCloseReports.CustomBackground = False
        Me.LabelAutoCloseReports.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.LabelAutoCloseReports.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.LabelAutoCloseReports.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.LabelAutoCloseReports.Location = New System.Drawing.Point(206, 45)
        Me.LabelAutoCloseReports.Name = "LabelAutoCloseReports"
        Me.LabelAutoCloseReports.Size = New System.Drawing.Size(125, 19)
        Me.LabelAutoCloseReports.Style = MetroFramework.MetroColorStyle.Blue
        Me.LabelAutoCloseReports.StyleManager = Nothing
        Me.LabelAutoCloseReports.TabIndex = 8
        Me.LabelAutoCloseReports.Text = "Auto-Close Reports"
        Me.LabelAutoCloseReports.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LabelAutoCloseReports.UseStyleColors = False
        '
        'ToggleCloseReports
        '
        Me.ToggleCloseReports.AutoSize = True
        Me.ToggleCloseReports.CustomBackground = False
        Me.ToggleCloseReports.DisplayStatus = False
        Me.ToggleCloseReports.FontSize = MetroFramework.MetroLinkSize.Small
        Me.ToggleCloseReports.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.ToggleCloseReports.Location = New System.Drawing.Point(337, 47)
        Me.ToggleCloseReports.Name = "ToggleCloseReports"
        Me.ToggleCloseReports.Size = New System.Drawing.Size(50, 17)
        Me.ToggleCloseReports.Style = MetroFramework.MetroColorStyle.Blue
        Me.ToggleCloseReports.StyleManager = Nothing
        Me.ToggleCloseReports.TabIndex = 7
        Me.ToggleCloseReports.Text = "~StatusOff"
        Me.ToggleCloseReports.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ToggleCloseReports.UseStyleColors = False
        Me.ToggleCloseReports.UseVisualStyleBackColor = True
        '
        'LabelIDAlert
        '
        Me.LabelIDAlert.AutoSize = True
        Me.LabelIDAlert.CustomBackground = False
        Me.LabelIDAlert.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.LabelIDAlert.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.LabelIDAlert.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.LabelIDAlert.Location = New System.Drawing.Point(203, 17)
        Me.LabelIDAlert.Name = "LabelIDAlert"
        Me.LabelIDAlert.Size = New System.Drawing.Size(112, 19)
        Me.LabelIDAlert.Style = MetroFramework.MetroColorStyle.Blue
        Me.LabelIDAlert.StyleManager = Nothing
        Me.LabelIDAlert.TabIndex = 6
        Me.LabelIDAlert.Text = "ID Alert Settings:"
        Me.LabelIDAlert.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LabelIDAlert.UseStyleColors = False
        '
        'LabelBehaviorOptions
        '
        Me.LabelBehaviorOptions.AutoSize = True
        Me.LabelBehaviorOptions.CustomBackground = False
        Me.LabelBehaviorOptions.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.LabelBehaviorOptions.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.LabelBehaviorOptions.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.LabelBehaviorOptions.Location = New System.Drawing.Point(3, 17)
        Me.LabelBehaviorOptions.Name = "LabelBehaviorOptions"
        Me.LabelBehaviorOptions.Size = New System.Drawing.Size(128, 19)
        Me.LabelBehaviorOptions.Style = MetroFramework.MetroColorStyle.Blue
        Me.LabelBehaviorOptions.StyleManager = Nothing
        Me.LabelBehaviorOptions.TabIndex = 5
        Me.LabelBehaviorOptions.Text = "Behavioral Options:"
        Me.LabelBehaviorOptions.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LabelBehaviorOptions.UseStyleColors = False
        '
        'LabelMaskANSI
        '
        Me.LabelMaskANSI.AutoSize = True
        Me.LabelMaskANSI.CustomBackground = False
        Me.LabelMaskANSI.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.LabelMaskANSI.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.LabelMaskANSI.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.LabelMaskANSI.Location = New System.Drawing.Point(3, 68)
        Me.LabelMaskANSI.Name = "LabelMaskANSI"
        Me.LabelMaskANSI.Size = New System.Drawing.Size(107, 19)
        Me.LabelMaskANSI.Style = MetroFramework.MetroColorStyle.Blue
        Me.LabelMaskANSI.StyleManager = Nothing
        Me.LabelMaskANSI.TabIndex = 4
        Me.LabelMaskANSI.Text = "Mask ANSI Field:"
        Me.LabelMaskANSI.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LabelMaskANSI.UseStyleColors = False
        '
        'ToggleMaskANSI
        '
        Me.ToggleMaskANSI.AutoSize = True
        Me.ToggleMaskANSI.CustomBackground = False
        Me.ToggleMaskANSI.DisplayStatus = False
        Me.ToggleMaskANSI.FontSize = MetroFramework.MetroLinkSize.Small
        Me.ToggleMaskANSI.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.ToggleMaskANSI.Location = New System.Drawing.Point(122, 70)
        Me.ToggleMaskANSI.Name = "ToggleMaskANSI"
        Me.ToggleMaskANSI.Size = New System.Drawing.Size(50, 17)
        Me.ToggleMaskANSI.Style = MetroFramework.MetroColorStyle.Blue
        Me.ToggleMaskANSI.StyleManager = Nothing
        Me.ToggleMaskANSI.TabIndex = 3
        Me.ToggleMaskANSI.Text = "~StatusOff"
        Me.ToggleMaskANSI.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ToggleMaskANSI.UseStyleColors = False
        Me.ToggleMaskANSI.UseVisualStyleBackColor = True
        '
        'LabelAutoVerify
        '
        Me.LabelAutoVerify.AutoSize = True
        Me.LabelAutoVerify.CustomBackground = False
        Me.LabelAutoVerify.FontSize = MetroFramework.MetroLabelSize.Medium
        Me.LabelAutoVerify.FontWeight = MetroFramework.MetroLabelWeight.Light
        Me.LabelAutoVerify.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.LabelAutoVerify.Location = New System.Drawing.Point(3, 45)
        Me.LabelAutoVerify.Name = "LabelAutoVerify"
        Me.LabelAutoVerify.Size = New System.Drawing.Size(109, 19)
        Me.LabelAutoVerify.Style = MetroFramework.MetroColorStyle.Blue
        Me.LabelAutoVerify.StyleManager = Nothing
        Me.LabelAutoVerify.TabIndex = 2
        Me.LabelAutoVerify.Text = "Auto-Verify Data:"
        Me.LabelAutoVerify.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LabelAutoVerify.UseStyleColors = False
        '
        'ToggleAutoVerify
        '
        Me.ToggleAutoVerify.AutoSize = True
        Me.ToggleAutoVerify.CustomBackground = False
        Me.ToggleAutoVerify.DisplayStatus = False
        Me.ToggleAutoVerify.FontSize = MetroFramework.MetroLinkSize.Small
        Me.ToggleAutoVerify.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.ToggleAutoVerify.Location = New System.Drawing.Point(122, 47)
        Me.ToggleAutoVerify.Name = "ToggleAutoVerify"
        Me.ToggleAutoVerify.Size = New System.Drawing.Size(50, 17)
        Me.ToggleAutoVerify.Style = MetroFramework.MetroColorStyle.Blue
        Me.ToggleAutoVerify.StyleManager = Nothing
        Me.ToggleAutoVerify.TabIndex = 1
        Me.ToggleAutoVerify.Text = "~StatusOff"
        Me.ToggleAutoVerify.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ToggleAutoVerify.UseStyleColors = False
        Me.ToggleAutoVerify.UseVisualStyleBackColor = True
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.PictureBox2)
        Me.MetroTabPage3.Controls.Add(Me.MetroTextBox1)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage3.Controls.Add(Me.PictureBox1)
        Me.MetroTabPage3.CustomBackground = False
        Me.MetroTabPage3.HorizontalScrollbar = False
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(445, 154)
        Me.MetroTabPage3.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTabPage3.StyleManager = Nothing
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "About"
        Me.MetroTabPage3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabPage3.VerticalScrollbar = False
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(22, 69)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(223, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.Enabled = False
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Small
        Me.MetroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Regular
        Me.MetroTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.MetroTextBox1.Multiline = True
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.Size = New System.Drawing.Size(261, 60)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.StyleManager = Nothing
        Me.MetroTextBox1.TabIndex = 4
        Me.MetroTextBox1.Text = "VapeID is meant to easily scan a Drivers License and quickly verify if the custom" &
    "er is of age to be purchasing anything vape related."
        Me.MetroTextBox1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.UseStyleColors = False
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.CustomBackground = False
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.MetroLabel2.Location = New System.Drawing.Point(13, 126)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(242, 25)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel2.StyleManager = Nothing
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Created by MooreR Software"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel2.UseStyleColors = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VapeID.My.Resources.Resources._2856413
        Me.PictureBox1.Location = New System.Drawing.Point(270, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'TextRaw
        '
        Me.TextRaw.DelayedTextChangedTimeout = 500
        Me.TextRaw.Location = New System.Drawing.Point(6, 37)
        Me.TextRaw.Multiline = True
        Me.TextRaw.Name = "TextRaw"
        Me.TextRaw.Size = New System.Drawing.Size(436, 82)
        Me.TextRaw.TabIndex = 7
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 273)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(493, 273)
        Me.MinimumSize = New System.Drawing.Size(493, 273)
        Me.Name = "FormMain"
        Me.Text = "VapeID v1.10.0"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ButtonValidate As MetroFramework.Controls.MetroButton
    Friend WithEvents ToggleAutoVerify As MetroFramework.Controls.MetroToggle
    Friend WithEvents LabelAutoVerify As MetroFramework.Controls.MetroLabel
    Friend WithEvents LabelMaskANSI As MetroFramework.Controls.MetroLabel
    Friend WithEvents ToggleMaskANSI As MetroFramework.Controls.MetroToggle
    Friend WithEvents LabelBehaviorOptions As MetroFramework.Controls.MetroLabel
    Friend WithEvents LabelIDAlert As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextCloseTimeout As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LabelAutoCloseTimeout As MetroFramework.Controls.MetroLabel
    Friend WithEvents LabelAutoCloseReports As MetroFramework.Controls.MetroLabel
    Friend WithEvents ToggleCloseReports As MetroFramework.Controls.MetroToggle
    Friend WithEvents ButtonSave As MetroFramework.Controls.MetroButton
    Friend WithEvents TextMinAge As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LabelMinAgeReq As MetroFramework.Controls.MetroLabel
    Friend WithEvents LabelStatus As MetroFramework.Controls.MetroLabel
    Friend WithEvents LabelSounds As MetroFramework.Controls.MetroLabel
    Friend WithEvents ToggleSounds As MetroFramework.Controls.MetroToggle
    Friend WithEvents TextRaw As TimedTextBox
    Friend WithEvents TextScanTimeout As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LabelScanTimeout As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
