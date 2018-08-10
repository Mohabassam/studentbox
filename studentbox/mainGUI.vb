Public Class mainGUI

    Private Sub mainGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Files' table. You can move, or remove it, as needed.
        Me.FilesTableAdapter.Fill(Me.DataSet1.Files)
        userlabel.Text = username

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
    End Sub

    Private Sub loadfiles(uid As String)
        Dim da As New DataSet1TableAdapters.FilesTableAdapter
        Dim dt As DataTable
        dt = da.getfileslistbyuid(Convert.ToInt16(uid))
        If dt.Rows.Count > 0 Then
            dt.Columns.Remove("Field1")
            dt.Columns.Remove("Field2")
            dt.Columns.Remove("Field3")

            DataGridView1.DataSource = dt
            Dim col = DataGridView1.Columns
            col(0).Width = 100
            col(0).HeaderText = "رقم الملف"
            col(1).Width = 100
            col(1).HeaderText = "رقم الطالب"
            col(2).HeaderText = "عنوان الملف"
            DataGridView1.RowHeadersVisible = False

        Else
            MessageBox.Show("لا يوجد بيانات لعرضها")

        End If
    End Sub

    Private Sub colhandler1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 2 Then
            'MessageBox.Show(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString)
            DownloadFileName = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
            Dim dff As New DownloadFileForm
            dff.Show()

        End If

    End Sub

    Private Sub colhandler2(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.ColumnIndex = 2 Then
            MessageBox.Show(DataGridView2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectTab(1)
        loadfiles(userid)
    End Sub

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectTab(2)
        loadAllfiles()
    End Sub

    Private Sub loadAllfiles()
        Dim da As New DataSet1TableAdapters.FilesTableAdapter
        Dim dt As DataTable
        dt = da.GetAllFiles()
        If dt.Rows.Count > 0 Then
            dt.Columns.Remove("Field1")
            dt.Columns.Remove("Field2")
            dt.Columns.Remove("Field3")

            DataGridView2.DataSource = dt
            Dim col = DataGridView2.Columns
            col(0).Width = 100
            col(0).HeaderText = "رقم الملف"
            col(1).Width = 100
            col(1).HeaderText = "رقم الطالب"
            col(2).HeaderText = "عنوان الملف"
            DataGridView2.RowHeadersVisible = False

        Else
            MessageBox.Show("لا يوجد بيانات لعرضها")

        End If
    End Sub
End Class