<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Logowanie
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logowanie))
        Me.ZalogujBtn = New System.Windows.Forms.Button()
        Me.LoginLbl = New System.Windows.Forms.Label()
        Me.Login = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Haslo = New System.Windows.Forms.TextBox()
        Me.ErrLbl = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ZalogujBtn
        '
        Me.ZalogujBtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.ZalogujBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ZalogujBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ZalogujBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ZalogujBtn.Location = New System.Drawing.Point(13, 114)
        Me.ZalogujBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ZalogujBtn.Name = "ZalogujBtn"
        Me.ZalogujBtn.Size = New System.Drawing.Size(485, 52)
        Me.ZalogujBtn.TabIndex = 7
        Me.ZalogujBtn.Text = "Zaloguj"
        Me.ZalogujBtn.UseVisualStyleBackColor = False
        '
        'LoginLbl
        '
        Me.LoginLbl.AutoSize = True
        Me.LoginLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.LoginLbl.Location = New System.Drawing.Point(16, 25)
        Me.LoginLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LoginLbl.Name = "LoginLbl"
        Me.LoginLbl.Size = New System.Drawing.Size(68, 24)
        Me.LoginLbl.TabIndex = 16
        Me.LoginLbl.Text = "Login:"
        '
        'Login
        '
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Login.Location = New System.Drawing.Point(92, 21)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(406, 28)
        Me.Login.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(16, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Haslo:"
        '
        'Haslo
        '
        Me.Haslo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Haslo.Location = New System.Drawing.Point(92, 66)
        Me.Haslo.Name = "Haslo"
        Me.Haslo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Haslo.Size = New System.Drawing.Size(406, 28)
        Me.Haslo.TabIndex = 17
        '
        'ErrLbl
        '
        Me.ErrLbl.AutoSize = True
        Me.ErrLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!, System.Drawing.FontStyle.Bold)
        Me.ErrLbl.ForeColor = System.Drawing.Color.DarkRed
        Me.ErrLbl.Location = New System.Drawing.Point(9, 182)
        Me.ErrLbl.Name = "ErrLbl"
        Me.ErrLbl.Size = New System.Drawing.Size(61, 20)
        Me.ErrLbl.TabIndex = 19
        Me.ErrLbl.Text = "ErrLbl"
        Me.ErrLbl.Visible = False
        '
        'Button2
        '
        Me.Button2.AccessibleDescription = "Podejrzyj hasło"
        Me.Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.Button2.BackgroundImage = Global.Narzedziownia.My.Resources.Resources.view_icon
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.8!)
        Me.Button2.Location = New System.Drawing.Point(504, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(39, 28)
        Me.Button2.TabIndex = 101
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Logowanie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(845, 328)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ErrLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Haslo)
        Me.Controls.Add(Me.LoginLbl)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.ZalogujBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(600, 300)
        Me.Name = "Logowanie"
        Me.Text = "Narzędziownia - Logowanie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ZalogujBtn As Button
    Friend WithEvents LoginLbl As Label
    Friend WithEvents Login As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Haslo As TextBox
    Friend WithEvents ErrLbl As Label
    Friend WithEvents Button2 As Button
End Class
