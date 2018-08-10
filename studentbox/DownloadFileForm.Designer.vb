<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadFileForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.FileNameBox = New System.Windows.Forms.TextBox()
        Me.SavePathBox = New System.Windows.Forms.TextBox()
        Me.browsbtn = New System.Windows.Forms.Button()
        Me.downloadbtn = New System.Windows.Forms.Button()
        Me.percentlable = New System.Windows.Forms.Label()
        Me.sizelable = New System.Windows.Forms.Label()
        Me.loadedlabel = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.StatusLaabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(422, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "اسم الملف"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(422, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "مكان الحفظ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(359, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "حجم الملف"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(171, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "حجم ما تم تحميله"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(43, 143)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(435, 23)
        Me.ProgressBar1.TabIndex = 1
        '
        'FileNameBox
        '
        Me.FileNameBox.Location = New System.Drawing.Point(84, 36)
        Me.FileNameBox.Name = "FileNameBox"
        Me.FileNameBox.ReadOnly = True
        Me.FileNameBox.Size = New System.Drawing.Size(332, 20)
        Me.FileNameBox.TabIndex = 2
        Me.FileNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SavePathBox
        '
        Me.SavePathBox.Location = New System.Drawing.Point(84, 69)
        Me.SavePathBox.Name = "SavePathBox"
        Me.SavePathBox.Size = New System.Drawing.Size(332, 20)
        Me.SavePathBox.TabIndex = 2
        '
        'browsbtn
        '
        Me.browsbtn.Location = New System.Drawing.Point(3, 67)
        Me.browsbtn.Name = "browsbtn"
        Me.browsbtn.Size = New System.Drawing.Size(75, 23)
        Me.browsbtn.TabIndex = 3
        Me.browsbtn.Text = "استعراض"
        Me.browsbtn.UseVisualStyleBackColor = True
        '
        'downloadbtn
        '
        Me.downloadbtn.Location = New System.Drawing.Point(3, 96)
        Me.downloadbtn.Name = "downloadbtn"
        Me.downloadbtn.Size = New System.Drawing.Size(75, 23)
        Me.downloadbtn.TabIndex = 3
        Me.downloadbtn.Text = "تحميل"
        Me.downloadbtn.UseVisualStyleBackColor = True
        '
        'percentlable
        '
        Me.percentlable.AutoSize = True
        Me.percentlable.BackColor = System.Drawing.Color.Transparent
        Me.percentlable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.percentlable.ForeColor = System.Drawing.Color.DarkGreen
        Me.percentlable.Location = New System.Drawing.Point(0, 148)
        Me.percentlable.Name = "percentlable"
        Me.percentlable.Size = New System.Drawing.Size(21, 14)
        Me.percentlable.TabIndex = 0
        Me.percentlable.Text = "%"
        '
        'sizelable
        '
        Me.sizelable.AutoSize = True
        Me.sizelable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sizelable.ForeColor = System.Drawing.Color.DarkGreen
        Me.sizelable.Location = New System.Drawing.Point(359, 119)
        Me.sizelable.Name = "sizelable"
        Me.sizelable.Size = New System.Drawing.Size(21, 14)
        Me.sizelable.TabIndex = 0
        Me.sizelable.Text = "%"
        '
        'loadedlabel
        '
        Me.loadedlabel.AutoSize = True
        Me.loadedlabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.loadedlabel.ForeColor = System.Drawing.Color.DarkGreen
        Me.loadedlabel.Location = New System.Drawing.Point(170, 119)
        Me.loadedlabel.Name = "loadedlabel"
        Me.loadedlabel.Size = New System.Drawing.Size(21, 14)
        Me.loadedlabel.TabIndex = 0
        Me.loadedlabel.Text = "%"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'StatusLaabel
        '
        Me.StatusLaabel.AutoSize = True
        Me.StatusLaabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.StatusLaabel.ForeColor = System.Drawing.Color.DarkGreen
        Me.StatusLaabel.Location = New System.Drawing.Point(270, 173)
        Me.StatusLaabel.Name = "StatusLaabel"
        Me.StatusLaabel.Size = New System.Drawing.Size(0, 14)
        Me.StatusLaabel.TabIndex = 0
        '
        'DownloadFileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 200)
        Me.Controls.Add(Me.downloadbtn)
        Me.Controls.Add(Me.browsbtn)
        Me.Controls.Add(Me.SavePathBox)
        Me.Controls.Add(Me.FileNameBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.loadedlabel)
        Me.Controls.Add(Me.sizelable)
        Me.Controls.Add(Me.StatusLaabel)
        Me.Controls.Add(Me.percentlable)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "DownloadFileForm"
        Me.Text = "DownloadFileForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents FileNameBox As System.Windows.Forms.TextBox
    Friend WithEvents SavePathBox As System.Windows.Forms.TextBox
    Friend WithEvents browsbtn As System.Windows.Forms.Button
    Friend WithEvents downloadbtn As System.Windows.Forms.Button
    Friend WithEvents percentlable As System.Windows.Forms.Label
    Friend WithEvents sizelable As System.Windows.Forms.Label
    Friend WithEvents loadedlabel As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusLaabel As System.Windows.Forms.Label
End Class
