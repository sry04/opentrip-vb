<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        error_setuju = New Label()
        error_password = New Label()
        error_email = New Label()
        error_phone = New Label()
        error_name = New Label()
        checkbox_setuju = New CheckBox()
        Label8 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        txt_password = New TextBox()
        Label6 = New Label()
        txt_email = New TextBox()
        Label5 = New Label()
        txt_phone = New TextBox()
        Label4 = New Label()
        txt_name = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button2 = New Button()
        PictureBox2 = New PictureBox()
        btn_close = New Button()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.neom_FuusC7lfg6Q_unsplash
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(-5, -13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(969, 670)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.Controls.Add(error_setuju)
        Panel1.Controls.Add(error_password)
        Panel1.Controls.Add(error_email)
        Panel1.Controls.Add(error_phone)
        Panel1.Controls.Add(error_name)
        Panel1.Controls.Add(checkbox_setuju)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(txt_password)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txt_email)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txt_phone)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txt_name)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(655, 33)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(423, 592)
        Panel1.TabIndex = 1
        ' 
        ' error_setuju
        ' 
        error_setuju.AutoSize = True
        error_setuju.ForeColor = Color.Red
        error_setuju.Location = New Point(39, 445)
        error_setuju.Margin = New Padding(0)
        error_setuju.Name = "error_setuju"
        error_setuju.Size = New Size(84, 20)
        error_setuju.TabIndex = 18
        error_setuju.Text = "error setuju"
        ' 
        ' error_password
        ' 
        error_password.AutoSize = True
        error_password.ForeColor = Color.Red
        error_password.Location = New Point(39, 395)
        error_password.Margin = New Padding(0)
        error_password.Name = "error_password"
        error_password.Size = New Size(108, 20)
        error_password.TabIndex = 17
        error_password.Text = "error password"
        ' 
        ' error_email
        ' 
        error_email.AutoSize = True
        error_email.ForeColor = Color.Red
        error_email.Location = New Point(39, 322)
        error_email.Margin = New Padding(0)
        error_email.Name = "error_email"
        error_email.Size = New Size(82, 20)
        error_email.TabIndex = 16
        error_email.Text = "error email"
        ' 
        ' error_phone
        ' 
        error_phone.AutoSize = True
        error_phone.ForeColor = Color.Red
        error_phone.Location = New Point(39, 248)
        error_phone.Margin = New Padding(0)
        error_phone.Name = "error_phone"
        error_phone.Size = New Size(96, 20)
        error_phone.TabIndex = 15
        error_phone.Text = "error telepon"
        ' 
        ' error_name
        ' 
        error_name.AutoSize = True
        error_name.ForeColor = Color.Red
        error_name.Location = New Point(39, 176)
        error_name.Margin = New Padding(0)
        error_name.Name = "error_name"
        error_name.Size = New Size(82, 20)
        error_name.TabIndex = 14
        error_name.Text = "error nama"
        ' 
        ' checkbox_setuju
        ' 
        checkbox_setuju.AutoSize = True
        checkbox_setuju.Location = New Point(40, 419)
        checkbox_setuju.Name = "checkbox_setuju"
        checkbox_setuju.Size = New Size(243, 24)
        checkbox_setuju.TabIndex = 10
        checkbox_setuju.Text = "Saya menerima SK yang berlaku"
        checkbox_setuju.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.DimGray
        Label8.Location = New Point(34, 529)
        Label8.Name = "Label8"
        Label8.Size = New Size(288, 20)
        Label8.TabIndex = 13
        Label8.Text = "Dengan klik ""Buat Akun"" anda menyetujui SK "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(163, 485)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 20)
        Label7.TabIndex = 11
        Label7.Text = "Sudah terdaftar?"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DodgerBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(34, 474)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 42)
        Button1.TabIndex = 11
        Button1.Text = "Buat Akun"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(40, 365)
        txt_password.Name = "txt_password"
        txt_password.PasswordChar = "*"c
        txt_password.Size = New Size(276, 27)
        txt_password.TabIndex = 9
        txt_password.UseSystemPasswordChar = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(40, 342)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 20)
        Label6.TabIndex = 8
        Label6.Text = "Password"
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(40, 292)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(276, 27)
        txt_email.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(40, 269)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 20)
        Label5.TabIndex = 6
        Label5.Text = "Email"
        ' 
        ' txt_phone
        ' 
        txt_phone.Location = New Point(40, 219)
        txt_phone.Name = "txt_phone"
        txt_phone.Size = New Size(276, 27)
        txt_phone.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(40, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 20)
        Label4.TabIndex = 4
        Label4.Text = "Nomor Telepon"
        ' 
        ' txt_name
        ' 
        txt_name.BackColor = SystemColors.Window
        txt_name.Location = New Point(40, 146)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(276, 27)
        txt_name.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 20)
        Label3.TabIndex = 2
        Label3.Text = "Nama Lengkap"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lato", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(40, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(356, 16)
        Label2.TabIndex = 1
        Label2.Text = "Temukan rute perjalanan yang lebih baik dengan akun pribadi"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lato", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(34, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 33)
        Label1.TabIndex = 0
        Label1.Text = "Buat akunmu"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.RoyalBlue
        Button2.Location = New Point(279, 481)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 12
        Button2.Text = "Masuk"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.d788081a7388e8d0494cca66e42a91b7_removebg_preview
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Image = My.Resources.Resources.d788081a7388e8d0494cca66e42a91b7_removebg_preview
        PictureBox2.Location = New Point(13, -2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(157, 119)
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' btn_close
        ' 
        btn_close.BackgroundImage = My.Resources.Resources.x
        btn_close.BackgroundImageLayout = ImageLayout.Zoom
        btn_close.FlatAppearance.BorderSize = 0
        btn_close.FlatStyle = FlatStyle.Flat
        btn_close.Location = New Point(1150, -1)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(32, 32)
        btn_close.TabIndex = 2
        btn_close.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Lato", 16.1999989F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(43, 498)
        Label9.Name = "Label9"
        Label9.Size = New Size(205, 33)
        Label9.TabIndex = 4
        Label9.Text = "Temukan liburan"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Lato", 16.1999989F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(43, 529)
        Label10.Name = "Label10"
        Label10.Size = New Size(286, 33)
        Label10.TabIndex = 5
        Label10.Text = "impian anda berikutnya"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Lato", 16.1999989F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(43, 562)
        Label11.Name = "Label11"
        Label11.Size = New Size(270, 33)
        Label11.TabIndex = 6
        Label11.Text = "bersama Travel Buddy."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(1179, 637)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(btn_close)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Travel Buddy"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_close As Button
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents checkbox_setuju As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents error_password As Label
    Friend WithEvents error_email As Label
    Friend WithEvents error_phone As Label
    Friend WithEvents error_name As Label
    Friend WithEvents error_setuju As Label
End Class
