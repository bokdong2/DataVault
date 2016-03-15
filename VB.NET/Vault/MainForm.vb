Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class MainForm
    Dim strFile As String
    Dim strOutput As String
    Dim strErrChk As String
    Dim fsInput As FileStream
    Dim fsOutput As FileStream
    Dim Mode As Integer = 0
    Dim iPosition As Integer = 0
    Dim i As Integer = 0

    Private Function CreateKey(ByVal strPassword As String) As Byte()
        Dim chrData() As Char = strPassword.ToCharArray
        Dim intLength As Integer = chrData.GetUpperBound(0)
        Dim bytDataToHash(intLength) As Byte
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        Dim SHA512 As New SHA512Managed
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        Dim bytKey(31) As Byte
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        Return bytKey
    End Function

    Private Function CreateIV(ByVal strPassword As String) As Byte()
        Dim chrData() As Char = strPassword.ToCharArray
        Dim intLength As Integer = chrData.GetUpperBound(0)
        Dim bytDataToHash(intLength) As Byte
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next
        Dim SHA512 As New SHA512Managed
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        Dim bytIV(15) As Byte

        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        Return bytIV
    End Function

    Private Enum CryptoAction
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Private Sub EncryptOrDecryptFile(ByVal strInputFile As String,
                                     ByVal strOutputFile As String,
                                     ByVal bytKey() As Byte,
                                     ByVal bytIV() As Byte,
                                     ByVal Direction As CryptoAction)
        Try

            fsInput = New System.IO.FileStream(strInputFile, FileMode.Open,
                                               FileAccess.Read)
            fsOutput = New System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate,
                                                FileAccess.Write)
            fsOutput.SetLength(0)
            Dim bytBuffer(4096) As Byte
            Dim lngBytesProcessed As Long = 0
            Dim lngFileLength As Long = fsInput.Length
            Dim intBytesInCurrentBlock As Integer
            Dim csCryptoStream As CryptoStream

            Dim cspRijndael As New RijndaelManaged
            pbStatus.Value = 0
            pbStatus.Maximum = 100


            Select Case Direction
                Case CryptoAction.ActionEncrypt
                    csCryptoStream = New CryptoStream(fsOutput,
                    cspRijndael.CreateEncryptor(bytKey, bytIV),
                    CryptoStreamMode.Write)

                Case CryptoAction.ActionDecrypt
                    csCryptoStream = New CryptoStream(fsOutput,
                    cspRijndael.CreateDecryptor(bytKey, bytIV),
                    CryptoStreamMode.Write)
            End Select

            While lngBytesProcessed < lngFileLength

                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)

                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)

                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)

                pbStatus.Value = CInt((lngBytesProcessed / lngFileLength) * 100)
            End While


            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()

            If Direction = CryptoAction.ActionEncrypt Then
                Dim fileOriginal As New FileInfo(strFile)
                fileOriginal.Delete()
            End If


            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileEncrypted As New FileInfo(strFile)
                fileEncrypted.Delete()
            End If


            Dim Wrap As String = Chr(13) + Chr(10)
            If Direction = CryptoAction.ActionEncrypt Then
                MsgBox("암호화 완료" + Wrap + Wrap +
                        "용량 = " +
                        lngBytesProcessed.ToString,
                        MsgBoxStyle.Information, "Done")


                pbStatus.Value = 0
                txtFile.Text = "암호화/복호화 할 파일 경로"
                txtPassword.Text = ""
                txtPasswordc.Text = ""
                txtDestination.Text = "암호화/복호화 된 파일 저장 위치"
                btnChange.Enabled = False


            Else

                MsgBox("복호화 완료" + Wrap + Wrap +
                       "복호화 용량 = " +
                        lngBytesProcessed.ToString,
                        MsgBoxStyle.Information, "Done")


                pbStatus.Value = 0
                txtFile.Text = "암호화/복호화 할 파일 경로"
                txtPassword.Text = ""
                txtPasswordc.Text = ""
                txtDestination.Text = "암호화/복호화 된 파일 저장 위치"
                btnChange.Enabled = False

            End If



        Catch When Err.Number = 53
            MsgBox("파일 위치가 올바르지 " +
                    "않습니다.",
                     MsgBoxStyle.Exclamation, "에러 53")


        Catch When txtFile.Text = strErrChk
            MsgBox("파일 위치가 올바르지 " +
                    "않습니다.",
                     MsgBoxStyle.Exclamation, "에러 53")
        Catch
            fsInput.Close()
            fsOutput.Close()

            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileDelete As New FileInfo(txtDestination.Text)
                fileDelete.Delete()
                pbStatus.Value = 0
                txtPassword.Text = ""
                txtPasswordc.Text = ""

                MsgBox("비밀번호가 올바르지 " +
                        "않습니다.", MsgBoxStyle.Exclamation, "에러 52")
            Else
                Dim fileDelete As New FileInfo(txtDestination.Text)
                fileDelete.Delete()

                pbStatus.Value = 0
                txtPassword.Text = ""
                txtPasswordc.Text = ""

                MsgBox("이 파일을 암호화 할 수 없습니다.",
                        MsgBoxStyle.Exclamation, "에러 51")

            End If

        End Try
    End Sub
    Private Sub Encrypt()

        If txtPasswordc.Text = txtPassword.Text Then

            Dim bytKey As Byte()
            Dim bytIV As Byte()

            bytKey = CreateKey(txtPassword.Text)

            bytIV = CreateIV(txtPassword.Text)

            EncryptOrDecryptFile(strFile, txtDestination.Text,
                                 bytKey, bytIV, CryptoAction.ActionEncrypt)
        Else
            MsgBox("비밀번호를 다시 입력 해 주세요.", MsgBoxStyle.Exclamation)
            txtPassword.Text = ""
            txtPasswordc.Text = ""
        End If
    End Sub

    Private Sub Decrypt()

        If txtPasswordc.Text = txtPassword.Text Then

            Dim bytKey As Byte()
            Dim bytIV As Byte()

            bytKey = CreateKey(txtPassword.Text)

            bytIV = CreateIV(txtPassword.Text)

            EncryptOrDecryptFile(strFile, txtDestination.Text,
                                 bytKey, bytIV, CryptoAction.ActionDecrypt)
        Else
            MsgBox("비밀번호를 다시 입력 해 주세요.", MsgBoxStyle.Exclamation)
            txtPassword.Text = ""
            txtPasswordc.Text = ""
        End If
    End Sub

    Private Sub OpenToEncryptFile()

        OpenFileDialog.FileName = ""
        OpenFileDialog.Title = "암호화 할 파일 선택"
        OpenFileDialog.InitialDirectory = "C:\"
        OpenFileDialog.Filter = "모든 파일 (*.*) | *.*"


        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            strFile = OpenFileDialog.FileName
            txtFile.Text = strFile

            Dim iPosition As Integer = 0
            Dim i As Integer = 0

            While strFile.IndexOf("\"c, i) <> -1
                iPosition = strFile.IndexOf("\"c, i)
                i = iPosition + 1
            End While


            strOutput = strFile.Substring(iPosition + 1)

            Dim S As String = strFile.Substring(0, iPosition + 1)

            strOutput = strOutput.Replace("."c, "_"c)

            txtDestination.Text = S + strOutput + ".encrypt"

            btnChange.Enabled = True

        End If
    End Sub
    Private Sub OpenToDecryptFile()
        OpenFileDialog.FileName = ""
        OpenFileDialog.Title = "복호화 할 파일 선택"
        OpenFileDialog.InitialDirectory = "C:\"
        OpenFileDialog.Filter = "암호화 된 파일 (*.encrypt) | *.encrypt"


        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            strFile = OpenFileDialog.FileName
            txtFile.Text = strFile
            Dim iPosition As Integer = 0
            Dim i As Integer = 0



            While strFile.IndexOf("\"c, i) <> -1
                iPosition = strFile.IndexOf("\"c, i)
                i = iPosition + 1
            End While


            strOutput = strFile.Substring(0, strFile.Length - 8)

            Dim S As String = strFile.Substring(0, iPosition + 1)

            strOutput = strOutput.Substring((iPosition + 1))

            txtDestination.Text = S + strOutput.Replace("_"c, "."c)


            btnChange.Enabled = True

        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        If Mode Mod 2 = 0 Then
            Call OpenToEncryptFile()
            btnMode.Enabled = False
            btnChange.Enabled = True
        ElseIf Mode Mod 2 = 1 Then
            Call OpenToDecryptFile()
            btnMode.Enabled = False
            btnChange.Enabled = True

        End If
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If Mode = 0 Then

            FolderBrowserDialog.Description = "암호화 된 파일을 저장할 경로를 선택 하세요."

            If FolderBrowserDialog.ShowDialog = DialogResult.OK Then
                txtDestination.Text = FolderBrowserDialog.SelectedPath +
                                             "\" + strOutput + ".encrypt"
            End If
        ElseIf Mode = 1 Then
            FolderBrowserDialog.Description = "복호화 된 파일을 저장할 경로를 선택 하세요."

            If FolderBrowserDialog.ShowDialog = DialogResult.OK Then
                txtDestination.Text = FolderBrowserDialog.SelectedPath +
                                             "\" + strOutput.Replace("_"c, "."c)
            End If
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Mode = 0 Then
            Call Encrypt()
            btnMode.Enabled = True
            btnChange.Enabled = False
        ElseIf Mode = 1 Then
            Call Decrypt()
            btnMode.Enabled = True
            btnChange.Enabled = False
        End If
    End Sub

    Private Sub btnMode_Click(sender As Object, e As EventArgs) Handles btnMode.Click
        Mode = Mode + 1
        If Mode Mod 2 = 0 Then
            Me.btnOK.Text = "파일 암호화"
            Me.btnOK.Refresh()
            Me.FlatStatusBar1.Text = "Developed By PhilipMo@TeamH4C::File Encryption Module Loaded."
        ElseIf Mode Mod 2 = 1 Then
            Me.btnOK.Text = "파일 복호화"
            Me.btnOK.Refresh()
            Me.FlatStatusBar1.Text = "Developed By PhilipMo@TeamH4C::File Decryption Module Loaded."
        End If
    End Sub

    Private Sub FlatClose1_Click(sender As Object, e As EventArgs) Handles FlatClose1.Click
        Me.Close()
        Environment.Exit(0)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strErrChk = txtFile.Text
    End Sub

    Private Sub btnSecureInput_Click(sender As Object, e As EventArgs) Handles btnSecureInput.Click
        Dim s As String = "abcdefghijklmnopqrstuvxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+~"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 1024
            Dim idx As Integer = r.Next(0, 73)
            sb.Append(s.Substring(idx, 1))
        Next
        txtPassword.UseSystemPasswordChar = False
        txtPasswordc.UseSystemPasswordChar = False
        txtPassword.ReadOnly = True
        txtPassword.ReadOnly = True
        txtPassword.Text = sb.ToString()
        txtPasswordc.Text = sb.ToString()
        txtPasswordc.Refresh()
        txtPassword.Refresh()
        MsgBox("강력한 랜덤 패스워드가 생성 되었습니다 해당 패스워드를 복사하여 저장하세요")
    End Sub
End Class