Imports System.Net

Public Class DownloadFileForm
    Dim ftpserveradd As String = "ftp://ftp.ezyro.com/htdocs"
    Dim ftpserverusername As String = "ezyro_21590432"
    Dim ftpserverpass As String = "cx01ruvpoco"
    Private Sub DownloadFileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        FileNameBox.Text = DownloadFileName
    End Sub

    Private Sub browsbtn_Click(sender As Object, e As EventArgs) Handles browsbtn.Click
        Dim SaveFolder As New FolderBrowserDialog
        If SaveFolder.ShowDialog = Windows.Forms.DialogResult.OK Then
            SavePathBox.Text = SaveFolder.SelectedPath
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim Buffer(1024) As Byte
        Dim BytesIn As Integer
        Dim TotalBytesIn As Integer
        Dim Output As IO.Stream
        Dim FileLength As Integer
        Try
            Dim FTPRequest As FtpWebRequest = DirectCast(WebRequest.Create(ftpserveradd + "/" + FileNameBox.Text), FtpWebRequest)
            FTPRequest.Credentials = New NetworkCredential(ftpserverusername, ftpserverpass)
            FTPRequest.Method = WebRequestMethods.Ftp.GetFileSize
            FileLength = CInt(FTPRequest.GetResponse.ContentLength)
            sizelable.Text = FileLength & " bytes."
        Catch ex As Exception
            MessageBox.Show("First Code " + ex.Message)
        End Try
        Try
            Dim FTPRequest As FtpWebRequest = DirectCast(WebRequest.Create(ftpserveradd + "/" + FileNameBox.Text), FtpWebRequest)
            FTPRequest.Credentials = New NetworkCredential(ftpserverusername, ftpserverpass)
            FTPRequest.Method = WebRequestMethods.Ftp.DownloadFile
            Dim stream As IO.Stream = FTPRequest.GetResponse.GetResponseStream
            Dim OutputFilePath As String = SavePathBox.Text & "\" & FileNameBox.Text
            Output = IO.File.Create(OutputFilePath)
            BytesIn = 1
            Do Until BytesIn < 1
                BytesIn = stream.Read(Buffer, 0, 1024)
                If BytesIn > 0 Then
                    Output.Write(Buffer, 0, BytesIn)
                    TotalBytesIn += BytesIn
                    loadedlabel.Text = TotalBytesIn.ToString & " bytes"
                    If FileLength > 0 Then
                        Dim perc As Integer = (TotalBytesIn / FileLength) * 100
                        BackgroundWorker1.ReportProgress(perc)
                    End If
                End If
            Loop
            Output.Close()
            stream.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub downloadbtn_Click(sender As Object, e As EventArgs) Handles downloadbtn.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        percentlable.Text = e.ProgressPercentage.ToString & "%"
        StatusLaabel.Text = "يتم التحميل"
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        StatusLaabel.Text = "انتهى التحميل"
    End Sub
End Class