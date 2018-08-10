Imports System.Text.RegularExpressions
Public Class register


    Private Function validatingregistration() As Boolean
        If String.IsNullOrWhiteSpace(namebox.Text) Then
            errorlabel.Text += "لا يجوز ترك اسم المستخدم فارغ" + vbCr
            Return False
        ElseIf passvalidate() Then
            If mailvalidation() Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function

    Private Function mailvalidation() As Boolean
        If String.IsNullOrWhiteSpace(mailbox1.Text) Then
            errorlabel.Text += "لا يجوز ترك البريد الالكتروني فارغ" + vbCr
            Return False
        ElseIf Regex.IsMatch(mailbox1.Text,
                 "^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                 "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$") Then
            If mailbox1.Text <> mailbox2.Text Then
                errorlabel.Text += "البريد الالكتروني غير متطابق" + vbCr
                Return False
            Else
                Return True
            End If
        Else
            errorlabel.Text += "البريد الالكتروني غير صحيح" + vbCr
            Return False
        End If
    End Function

    Private Function passvalidate() As Boolean
        If String.IsNullOrWhiteSpace(passbox1.Text) Then
            errorlabel.Text += "لا يجوز ترك كلمة المرور فارغة" + vbCr
            Return False
        ElseIf passbox1.Text <> passbox2.Text Then
            errorlabel.Text += "كلمات المرور غير متطابقة" + vbCr
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        errorlabel.Text = ""
        If validatingregistration() Then
            Dim da As New DataSet1TableAdapters.usersTableAdapter
            Dim dt As New DataTable
            Try
                da.Connection.Open()
                dt = da.userExist(namebox.Text)
            Catch ex As Exception
                errorlabel.Text += ex.ToString + vbCr
            End Try
            If dt.Rows.Count > 0 Then
                errorlabel.Text += "اسم المستخدم موجود الرجاء" + vbCr + "استخدام اسم آخر"
            Else
                da.InsertNewUser(namebox.Text, passbox1.Text, mailbox1.Text)
                MessageBox.Show("تم حفظ المستخدم بنجاح, يمكنك الآن الدخول إلى التطبيق", "مستخدم جديد", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
            End If
            dt.Clear()
            da.Connection.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each txtbox In Me.Controls
            If TypeOf (txtbox) Is TextBox Then
                txtbox.Clear()
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SignIn.Show()
        Me.Close()
    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        errorlabel.Text = userid + vbCr + username
    End Sub
End Class