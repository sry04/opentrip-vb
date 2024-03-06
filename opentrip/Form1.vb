Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PictureBox2.Parent = Me.PictureBox1

        Me.Label9.Parent = Me.PictureBox1
        Me.Label10.Parent = Me.PictureBox1
        Me.Label11.Parent = Me.PictureBox1

        resetvalidasi()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim check = validasi(True, "")

        If check Then
            MsgBox("Data berhasil dibuat")

            txt_email.Text = ""
            txt_name.Text = ""
            txt_password.Text = ""
            txt_phone.Text = ""
            checkbox_setuju.Checked = False

            resetvalidasi()
        End If
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.White
        Button1.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.White
        Button1.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.ForeColor = Color.DodgerBlue
    End Sub

    Public Function validasi(all As Boolean, tipe As String)
        Dim status = True
        If tipe = "name" Or all = True Then
            If String.IsNullOrEmpty(txt_name.Text) Then
                Me.error_name.Text = "Kolom Nama Lengkap harus diisi"
                Me.error_name.Visible = True
                txt_name.BackColor = Color.LightSalmon

                status = False
            Else
                Me.error_name.Text = ""
                Me.error_name.Visible = False
                txt_name.BackColor = Color.PaleGreen
            End If
        End If

        If tipe = "phone" Or all = True Then
            If String.IsNullOrEmpty(txt_phone.Text) Then
                Me.error_phone.Text = "Kolom Nomor Telepon harus diisi"
                Me.error_phone.Visible = True
                txt_phone.BackColor = Color.LightSalmon
                status = False
            Else
                Me.error_phone.Text = ""
                Me.error_phone.Visible = False
                txt_phone.BackColor = Color.PaleGreen
            End If
        End If

        If tipe = "email" Or all = True Then
            If String.IsNullOrEmpty(txt_email.Text) Then
                Me.error_email.Text = "Kolom Email harus diisi"
                Me.error_email.Visible = True
                txt_email.BackColor = Color.LightSalmon
                status = False
            ElseIf IsValidEmail(txt_email.Text.Trim()) = False Then
                Me.error_email.Text = "Email tidak valid"
                txt_email.BackColor = Color.LightSalmon
                Me.error_email.Visible = True
                status = False
            Else
                Me.error_email.Text = ""
                Me.error_email.Visible = False
                txt_email.BackColor = Color.PaleGreen
            End If
        End If

        If tipe = "password" Or all = True Then
            If String.IsNullOrEmpty(txt_password.Text) Then
                Me.error_password.Text = "Kolom Password harus diisi"
                txt_password.BackColor = Color.LightSalmon
                Me.error_password.Visible = True
                status = False
            ElseIf IsValidPassword(txt_password.Text.Trim()) = False Then
                Me.error_password.Text = "6 karakter, huruf besar, kecil, angka dan simbol"
                txt_password.BackColor = Color.LightSalmon
                Me.error_password.Visible = True
                status = False
            Else
                Me.error_password.Text = ""
                txt_password.BackColor = Color.PaleGreen
                Me.error_password.Visible = False
            End If
        End If

        If tipe = "setuju" Or all = True Then
            If checkbox_setuju.Checked Then
                Me.error_setuju.Text = ""
                Me.error_setuju.Visible = False
            Else
                Me.error_setuju.Text = "Kolom harus dichecklist"
                Me.error_setuju.Visible = True
                status = False
            End If
        End If

        Return status
    End Function

    Public Function resetvalidasi()
        error_name.Text = ""
        error_phone.Text = ""
        error_email.Text = ""
        error_password.Text = ""
        error_setuju.Text = ""

        error_name.Visible = False
        error_phone.Visible = False
        error_email.Visible = False
        error_password.Visible = False
        error_setuju.Visible = False

        txt_name.BackColor = Color.White
        txt_phone.BackColor = Color.White
        txt_email.BackColor = Color.White
        txt_password.BackColor = Color.White
    End Function

    Private Function IsValidEmail(email As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function

    Private Function IsValidPassword(password As String) As Boolean
        If password.Length < 6 Then
            Return False
        End If

        Dim pattern As String = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(password)
    End Function

    Private Sub txt_name_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged
        validasi(False, "name")
    End Sub

    Private Sub txt_phone_TextChanged(sender As Object, e As EventArgs) Handles txt_phone.TextChanged
        validasi(False, "phone")
    End Sub

    Private Sub txt_email_TextChanged(sender As Object, e As EventArgs) Handles txt_email.TextChanged
        validasi(False, "email")
    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged
        validasi(False, "password")
    End Sub

    Private Sub txt_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_name.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_phone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub checkbox_setuju_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_setuju.CheckedChanged
        validasi(False, "setuju")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Fitur belum tersedia!")
    End Sub
End Class
