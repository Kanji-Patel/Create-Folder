Imports System.IO

Public Class frmCreateFolders

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Try
            pCraeteDirectory()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Function pCraeteDirectory() As Boolean
        Try
            If txtDirectoryPath.Text = "" Then
                MessageBox.Show("Please enter valid directory path", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                My.Computer.FileSystem.CreateDirectory(txtDirectoryPath.Text)
                MessageBox.Show("Directory created successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub btnCreateAndOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateAndOpen.Click
        Try
            If pCraeteDirectory() Then
                Process.Start("Explorer.exe", txtDirectoryPath.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Process.Start(LinkLabel1.Text, txtDirectoryPath.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class