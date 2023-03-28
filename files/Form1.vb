Imports System.IO
Public Class Form1


    Private Sub WriteToFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WriteToFileToolStripMenuItem.Click

        If File.Exists("MyFile.txt") Then
            File.WriteAllText("MyFile.txt", TextBox1.Text)
            MessageBox.Show("File written")
        Else
            Dim answer As DialogResult
            answer = MessageBox.Show("The file already exists do you wanna orerwhite it?", "Overwrite?", MessageBoxButtons.YesNo)
            If answer = DialogResult.Yes Then
                File.WriteAllText("MyFile.txt", TextBox1.Text)
                MessageBox.Show("File written")
            End If
        End If
    End Sub

    Private Sub AppendTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppendTextToolStripMenuItem.Click
        File.AppendAllText("MyFile.txt", TextBox1.Text)
        MessageBox.Show("File written")
    End Sub

    Private Sub ReadTheFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReadTheFileToolStripMenuItem.Click
        If File.Exists("MyFile.txt") Then
            TextBox1.Text = File.ReadAllText("MyFile.txt")
        Else
            MessageBox.Show("File doesn't exist")
        End If
    End Sub

    Private Sub WriteByLineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WriteByLineToolStripMenuItem.Click
        Dim text As String
        text = TextBox1.Text
        Dim words As String()
        words = text.Split((" ,.?/\|][{}<>!@#$%^&*()" + vbNewLine).ToCharArray, StringSplitOptions.RemoveEmptyEntries)
        File.WriteAllLines("MyFile.txt", words)
    End Sub

    Private Sub ByLineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByLineToolStripMenuItem.Click
        If File.Exists("MyFile.txt") Then
            Dim words As String()
            words = File.ReadAllLines("MyFile.txt")
            TextBox1.Lines = words
        End If
    End Sub

    Private Sub SaveByFilenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveByFilenameToolStripMenuItem.Click

        'Create an instance of SaveFileDialog
        Dim svDg As New SaveFileDialog

        'Set propertites
        svDg.Filter = "text files|*.txt|documents|*.doc;*.docx;*.pdf|all files|*.*"
        svDg.FilterIndex = 1
        svDg.DefaultExt = ".txt"
        svDg.AddExtension = True
        svDg.InitialDirectory = "D:\"

        'Open the dialog, if the user chose save
        If svDg.ShowDialog() = DialogResult.OK Then

            Dim saveFile = svDg.FileName
            File.WriteAllLines(saveFile, TextBox1.Lines)

        End If

    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Dim opDg As New OpenFileDialog

        opDg.Filter = "text files|*.txt|documents|*.doc;*.docx;*.pdf|all files|*.*"
        opDg.FilterIndex = 1
        opDg.DefaultExt = ".txt"
        opDg.AddExtension = True
        opDg.InitialDirectory = "D:\"

        If opDg.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = File.ReadAllText(opDg.FileName)
        End If
    End Sub
End Class
