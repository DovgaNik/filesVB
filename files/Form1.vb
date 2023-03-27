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
End Class
