<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.namebox = New System.Windows.Forms.TextBox()
        Me.passbox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passbox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mailbox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mailbox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.errorlabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(300, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "اسم المستخدم"
        '
        'namebox
        '
        Me.namebox.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.namebox.Location = New System.Drawing.Point(13, 50)
        Me.namebox.Name = "namebox"
        Me.namebox.Size = New System.Drawing.Size(288, 27)
        Me.namebox.TabIndex = 1
        '
        'passbox1
        '
        Me.passbox1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.passbox1.Location = New System.Drawing.Point(12, 84)
        Me.passbox1.Name = "passbox1"
        Me.passbox1.Size = New System.Drawing.Size(288, 27)
        Me.passbox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(300, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "كلمة المرور"
        '
        'passbox2
        '
        Me.passbox2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.passbox2.Location = New System.Drawing.Point(12, 118)
        Me.passbox2.Name = "passbox2"
        Me.passbox2.Size = New System.Drawing.Size(288, 27)
        Me.passbox2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(299, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "إعادة كلمة المرور"
        '
        'mailbox1
        '
        Me.mailbox1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.mailbox1.Location = New System.Drawing.Point(13, 152)
        Me.mailbox1.Name = "mailbox1"
        Me.mailbox1.Size = New System.Drawing.Size(288, 27)
        Me.mailbox1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(300, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "البريد الإلكتروني"
        '
        'mailbox2
        '
        Me.mailbox2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.mailbox2.Location = New System.Drawing.Point(13, 186)
        Me.mailbox2.Name = "mailbox2"
        Me.mailbox2.Size = New System.Drawing.Size(288, 27)
        Me.mailbox2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(300, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "إعادة البريد الإلكتروني"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(281, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "تسجيل مستخدم جديد"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(208, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 32)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "تسجيل"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'errorlabel
        '
        Me.errorlabel.AutoSize = True
        Me.errorlabel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.errorlabel.ForeColor = System.Drawing.Color.Red
        Me.errorlabel.Location = New System.Drawing.Point(49, 256)
        Me.errorlabel.Name = "errorlabel"
        Me.errorlabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.errorlabel.Size = New System.Drawing.Size(0, 19)
        Me.errorlabel.TabIndex = 12
        Me.errorlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(111, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 32)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "مسح"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 33)
        Me.Panel1.TabIndex = 13
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Button3.Location = New System.Drawing.Point(14, 219)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 32)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "عودة"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 344)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.errorlabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mailbox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mailbox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.passbox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.passbox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.namebox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "register"
        Me.Text = "Register A New User"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents namebox As System.Windows.Forms.TextBox
    Friend WithEvents passbox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents passbox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mailbox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mailbox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents errorlabel As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
