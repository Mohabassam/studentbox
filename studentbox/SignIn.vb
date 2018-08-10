Public Class SignIn

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        register.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If boxesvalidation() Then
            Dim da As New DataSet1TableAdapters.usersTableAdapter
            Dim dt As DataTable
            Try
                da.Connection.Open()
            Catch ex As Exception
                MessageBox.Show("لم يتم الاتصال مع الخادم حاول مرة أخرى", "فشل في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Button1_Click(sender, e)
                Exit Sub
            End Try
            dt = da.checkUser(namebox.Text, passbox.Text)
            If dt.Rows.Count > 0 Then
                userid = dt.Rows(0)(0)
                username = dt.Rows(0)(1)
                mainGUI.Show()
                Me.Close()
            Else
                MessageBox.Show("Wrong")
            End If
            da.Connection.Close()
            dt.Clear()

        End If
    End Sub
    Private Function boxesvalidation() As Boolean
        If String.IsNullOrWhiteSpace(namebox.Text) Or String.IsNullOrWhiteSpace(passbox.Text) Then
            MessageBox.Show("لا يجوز ترك أحد الصناديق أو كلاهما فارغ")
            Return False
        ElseIf passbox.TextLength < 8 Then
            MessageBox.Show("لا يجوز أن تكون كلمة المرور أقل من 8 أحرف")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub passbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles passbox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Button1_Click(sender, e)
        End If
    End Sub

    
    Private Sub passbox_TextChanged(sender As Object, e As EventArgs) Handles passbox.TextChanged

    End Sub
End Class