<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReport
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
        Me.components = New System.ComponentModel.Container()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager()
        Me.LabelName = New MetroFramework.Controls.MetroLabel()
        Me.LabelAge = New MetroFramework.Controls.MetroLabel()
        Me.LabelReason = New MetroFramework.Controls.MetroLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MetroProgressSpinner1 = New MetroFramework.Controls.MetroProgressSpinner()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.OwnerForm = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'LabelName
        '
        Me.LabelName.CustomBackground = False
        Me.LabelName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelName.FontSize = MetroFramework.MetroLabelSize.Huge
        Me.LabelName.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LabelName.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.LabelName.Location = New System.Drawing.Point(3, 0)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(798, 104)
        Me.LabelName.Style = MetroFramework.MetroColorStyle.Orange
        Me.LabelName.StyleManager = Me.MetroStyleManager1
        Me.LabelName.TabIndex = 0
        Me.LabelName.Text = "MetroLabel1"
        Me.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelName.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LabelName.UseStyleColors = True
        '
        'LabelAge
        '
        Me.LabelAge.CustomBackground = False
        Me.LabelAge.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelAge.FontSize = MetroFramework.MetroLabelSize.Huge
        Me.LabelAge.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LabelAge.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.LabelAge.Location = New System.Drawing.Point(3, 104)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(798, 172)
        Me.LabelAge.Style = MetroFramework.MetroColorStyle.Orange
        Me.LabelAge.StyleManager = Me.MetroStyleManager1
        Me.LabelAge.TabIndex = 0
        Me.LabelAge.Text = "MetroLabel1"
        Me.LabelAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelAge.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LabelAge.UseStyleColors = True
        '
        'LabelReason
        '
        Me.LabelReason.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelReason.CustomBackground = False
        Me.LabelReason.FontSize = MetroFramework.MetroLabelSize.Huge
        Me.LabelReason.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LabelReason.LabelMode = MetroFramework.Controls.MetroLabelMode.[Default]
        Me.LabelReason.Location = New System.Drawing.Point(3, 276)
        Me.LabelReason.Name = "LabelReason"
        Me.LabelReason.Size = New System.Drawing.Size(798, 243)
        Me.LabelReason.Style = MetroFramework.MetroColorStyle.Orange
        Me.LabelReason.StyleManager = Me.MetroStyleManager1
        Me.LabelReason.TabIndex = 0
        Me.LabelReason.Text = "MetroLabel1"
        Me.LabelReason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelReason.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LabelReason.UseStyleColors = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'MetroProgressSpinner1
        '
        Me.MetroProgressSpinner1.CustomBackground = False
        Me.MetroProgressSpinner1.Location = New System.Drawing.Point(23, 22)
        Me.MetroProgressSpinner1.Maximum = 100
        Me.MetroProgressSpinner1.Name = "MetroProgressSpinner1"
        Me.MetroProgressSpinner1.Size = New System.Drawing.Size(49, 45)
        Me.MetroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroProgressSpinner1.StyleManager = Me.MetroStyleManager1
        Me.MetroProgressSpinner1.TabIndex = 1
        Me.MetroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroProgressSpinner1.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LabelName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelAge, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelReason, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 60)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.83435!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.66095!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.5047!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(804, 529)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'FormReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 609)
        Me.Controls.Add(Me.MetroProgressSpinner1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.MinimumSize = New System.Drawing.Size(687, 423)
        Me.Name = "FormReport"
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.StyleManager = Me.MetroStyleManager1
        Me.Text = "ID Validation Report"
        Me.TextAlign = MetroFramework.Forms.TextAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents LabelName As MetroFramework.Controls.MetroLabel
    Friend WithEvents LabelReason As MetroFramework.Controls.MetroLabel
    Friend WithEvents LabelAge As MetroFramework.Controls.MetroLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MetroProgressSpinner1 As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
