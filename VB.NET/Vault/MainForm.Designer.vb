<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.FormSkin1 = New Vault.FormSkin()
        Me.btnSecureInput = New Vault.FlatButton()
        Me.btnChange = New Vault.FlatButton()
        Me.txtDestination = New Vault.FlatTextBox()
        Me.pbStatus = New Vault.FlatProgressBar()
        Me.FlatStatusBar1 = New Vault.FlatStatusBar()
        Me.btnMode = New Vault.FlatButton()
        Me.txtPasswordc = New Vault.FlatTextBox()
        Me.txtPassword = New Vault.FlatTextBox()
        Me.btnOK = New Vault.FlatButton()
        Me.txtFile = New Vault.FlatTextBox()
        Me.btnBrowse = New Vault.FlatButton()
        Me.FlatClose1 = New Vault.FlatClose()
        Me.FlatMini1 = New Vault.FlatMini()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.btnSecureInput)
        Me.FormSkin1.Controls.Add(Me.btnChange)
        Me.FormSkin1.Controls.Add(Me.txtDestination)
        Me.FormSkin1.Controls.Add(Me.pbStatus)
        Me.FormSkin1.Controls.Add(Me.FlatStatusBar1)
        Me.FormSkin1.Controls.Add(Me.btnMode)
        Me.FormSkin1.Controls.Add(Me.txtPasswordc)
        Me.FormSkin1.Controls.Add(Me.txtPassword)
        Me.FormSkin1.Controls.Add(Me.btnOK)
        Me.FormSkin1.Controls.Add(Me.txtFile)
        Me.FormSkin1.Controls.Add(Me.btnBrowse)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(401, 294)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "H4C::Vault::Using Rajindael Algorithm"
        '
        'btnSecureInput
        '
        Me.btnSecureInput.BackColor = System.Drawing.Color.Transparent
        Me.btnSecureInput.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnSecureInput.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSecureInput.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSecureInput.Location = New System.Drawing.Point(297, 192)
        Me.btnSecureInput.Name = "btnSecureInput"
        Me.btnSecureInput.Rounded = False
        Me.btnSecureInput.Size = New System.Drawing.Size(99, 29)
        Me.btnSecureInput.TabIndex = 15
        Me.btnSecureInput.Text = "보안 입력"
        Me.btnSecureInput.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.Color.Transparent
        Me.btnChange.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnChange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChange.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnChange.Location = New System.Drawing.Point(345, 87)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Rounded = False
        Me.btnChange.Size = New System.Drawing.Size(51, 29)
        Me.btnChange.TabIndex = 14
        Me.btnChange.Text = "..."
        Me.btnChange.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtDestination
        '
        Me.txtDestination.BackColor = System.Drawing.Color.Transparent
        Me.txtDestination.Location = New System.Drawing.Point(3, 89)
        Me.txtDestination.MaxLength = 32767
        Me.txtDestination.Multiline = False
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.ReadOnly = True
        Me.txtDestination.Size = New System.Drawing.Size(336, 29)
        Me.txtDestination.TabIndex = 13
        Me.txtDestination.Text = "암호화/복호화 된 파일 저장 위치"
        Me.txtDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDestination.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDestination.UseSystemPasswordChar = False
        '
        'pbStatus
        '
        Me.pbStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.pbStatus.DarkerProgress = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.pbStatus.Location = New System.Drawing.Point(3, 227)
        Me.pbStatus.Maximum = 100
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.pbStatus.Size = New System.Drawing.Size(393, 42)
        Me.pbStatus.TabIndex = 12
        Me.pbStatus.Text = "pbStatus"
        Me.pbStatus.Value = 0
        '
        'FlatStatusBar1
        '
        Me.FlatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatStatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatStatusBar1.ForeColor = System.Drawing.Color.White
        Me.FlatStatusBar1.Location = New System.Drawing.Point(0, 271)
        Me.FlatStatusBar1.Name = "FlatStatusBar1"
        Me.FlatStatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatStatusBar1.ShowTimeDate = False
        Me.FlatStatusBar1.Size = New System.Drawing.Size(401, 23)
        Me.FlatStatusBar1.TabIndex = 11
        Me.FlatStatusBar1.Text = "Developed By PhilipMo@TeamH4C::File Encryption Module Loaded."
        Me.FlatStatusBar1.TextColor = System.Drawing.Color.White
        '
        'btnMode
        '
        Me.btnMode.BackColor = System.Drawing.Color.Transparent
        Me.btnMode.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnMode.Location = New System.Drawing.Point(149, 192)
        Me.btnMode.Name = "btnMode"
        Me.btnMode.Rounded = False
        Me.btnMode.Size = New System.Drawing.Size(142, 29)
        Me.btnMode.TabIndex = 10
        Me.btnMode.Text = "모드 변경"
        Me.btnMode.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtPasswordc
        '
        Me.txtPasswordc.BackColor = System.Drawing.Color.Transparent
        Me.txtPasswordc.Location = New System.Drawing.Point(3, 157)
        Me.txtPasswordc.MaxLength = 32767
        Me.txtPasswordc.Multiline = False
        Me.txtPasswordc.Name = "txtPasswordc"
        Me.txtPasswordc.ReadOnly = False
        Me.txtPasswordc.Size = New System.Drawing.Size(393, 29)
        Me.txtPasswordc.TabIndex = 8
        Me.txtPasswordc.Text = "Password"
        Me.txtPasswordc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPasswordc.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPasswordc.UseSystemPasswordChar = True
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.Location = New System.Drawing.Point(3, 122)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Multiline = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = False
        Me.txtPassword.Size = New System.Drawing.Size(393, 29)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.Text = "Password"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPassword.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnOK.Location = New System.Drawing.Point(3, 192)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Rounded = False
        Me.btnOK.Size = New System.Drawing.Size(140, 29)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "파일 암호화"
        Me.btnOK.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtFile
        '
        Me.txtFile.BackColor = System.Drawing.Color.Transparent
        Me.txtFile.Location = New System.Drawing.Point(3, 54)
        Me.txtFile.MaxLength = 32767
        Me.txtFile.Multiline = False
        Me.txtFile.Name = "txtFile"
        Me.txtFile.ReadOnly = True
        Me.txtFile.Size = New System.Drawing.Size(336, 29)
        Me.txtFile.TabIndex = 5
        Me.txtFile.Text = "암호화/복호화 할 파일 위치"
        Me.txtFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFile.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFile.UseSystemPasswordChar = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Transparent
        Me.btnBrowse.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBrowse.Location = New System.Drawing.Point(345, 54)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Rounded = False
        Me.btnBrowse.Size = New System.Drawing.Size(51, 29)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(371, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 2
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(347, 12)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 1
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 294)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlatMini1 As FlatMini
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents btnBrowse As FlatButton
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents txtFile As FlatTextBox
    Friend WithEvents txtPasswordc As FlatTextBox
    Friend WithEvents txtPassword As FlatTextBox
    Friend WithEvents btnOK As FlatButton
    Friend WithEvents pbStatus As FlatProgressBar
    Friend WithEvents FlatStatusBar1 As FlatStatusBar
    Friend WithEvents btnMode As FlatButton
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents txtDestination As FlatTextBox
    Friend WithEvents btnChange As FlatButton
    Friend WithEvents btnSecureInput As FlatButton
End Class
