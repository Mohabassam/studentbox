Imports System.Net
Public Class Form1
    Dim ftpfilepath As String = Nothing
    Dim ftpserveradd As String = "ftp://ftp.ezyro.com/htdocs"
    Dim ftpserverusername As String = "ezyro_21590432"
    Dim ftpserverpass As String = "cx01ruvpoco"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newfile As New OpenFileDialog
        If newfile.ShowDialog = Windows.Forms.DialogResult.OK Then
            filepath.Text = newfile.FileName
            ftpfilepath = ftpserveradd & "/" & IO.Path.GetFileName(filepath.Text)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If isfileavailable(userid, IO.Path.GetFileName(filepath.Text)) Then
            MessageBox.Show("يوجد ملف بنفس الإسم")
        Else
            Dim request As FtpWebRequest = DirectCast(WebRequest.Create(New Uri(ftpfilepath)), FtpWebRequest)
            request.Method = WebRequestMethods.Ftp.UploadFile
            request.Credentials = New NetworkCredential(ftpserverusername, ftpserverpass)
            request.UseBinary = True
            request.UsePassive = False
            Dim filestream() As Byte = System.IO.File.ReadAllBytes(filepath.Text)
            Dim requeststream As System.IO.Stream = request.GetRequestStream

            Label6.Text = IO.Path.GetFileName(filepath.Text)
            Label8.Text = filestream.Length

            Dim chsize As Integer
            For offset As Integer = 0 To filestream.Length Step 1024
                BackgroundWorker1.ReportProgress(CType(offset * ProgressBar1.Maximum / filestream.Length, Integer))
                chsize = filestream.Length - offset
                If chsize > 1024 Then chsize = 1024
                requeststream.Write(filestream, offset, chsize)
            Next
            requeststream.Close()
            requeststream.Dispose()
        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Label2.Text = e.ProgressPercentage & "%"
        Label9.Text = "الرجاء الإنتظار . . ."
        If e.ProgressPercentage = 99 Then
            ProgressBar1.Value = 100
            Label2.Text = "100%"
        End If

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Dim da As New DataSet1TableAdapters.FilesTableAdapter
        da.Connection.Open()
        da.InsertNewFile(Convert.ToInt32(userid), IO.Path.GetFileName(filepath.Text), "", "", "")
        da.Connection.Close()
        Label9.Text = "إنتهى . . ."
    End Sub

    Function isfileavailable(uid As String, fname As String) As Boolean
        Dim da As New DataSet1TableAdapters.FilesTableAdapter
        Dim dt As DataTable
        da.Connection.Open()
        dt = da.fileavailable(Convert.ToInt16(uid), fname)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
        da.Connection.Close()
        dt.Clear()
    End Function

End Class
