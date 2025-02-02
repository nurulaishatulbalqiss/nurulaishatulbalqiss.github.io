Public Class MyProfile
    Private Sub MyProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This Variable will call InputBox to get data from user
        Dim MyName As String = InputBox("Please state your name :", "Student's Name")
        Dim RegNum As String = InputBox("Identify your registeration number :")
        Dim TelNum As String = InputBox("Input your phone number :")

        'Assign variable value to textbox objects
        txtName.Text = MyName
        txtRegNum.Text = RegNum
        txtTelNum.Text = TelNum
        txtSkills.Text = "No skills"
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        'Clear all data in the textboxes
        txtName.Text = ""
        txtRegNum.Text = ""
        txtTelNum.Text = ""
        txtSkills.Text = ""
    End Sub

    Public Class MyProfile
        'Declare module variable
        Dim FileDir As String
    End Class
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        'FileDir variable will hold the directory of the file name
        FileDir = OpenFileDialog1.FileName
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        'Open File Dialog window will displayed
        OpenFileDialog1.ShowDialog()

        'Identify whether the file exist or not
        If System.IO.File.Exists(FileDir) = True Then
            Dim objreader As New System.IO.StreamReader(FileDir)
            txtSkills.Text = objreader.ReadToEnd
            objreader.Close()
        Else
            MessageBox.Show("That file does not exist!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        'Change existing picture
        OpenFileDialog2.ShowDialog()

        If OpenFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PicBox.Image = System.Drawing.Image.FromFile(OpenFileDialog2.FileName)

        End If

    End Sub


    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs Handles PrintDocument1.PrintPage
            'Set font style to Arial, size 16,regular
            Dim font1 As New Font("Arial", 16, FontStyle.Regular)

        'Combine all text in one variable
        Dim myString As String
        myString = "Name : " & txtName.Text & vbNewLine
        & "Registration Number : " & txtRegNum.Text & vbNewLine
        & "Phone Number : " & txtTelNum.Text & vbNewLine
        & "Skills : " & txtSkilss.Text
        

        'Set the text and font to black color and start at 100,100
        e.Graphics.DrawString(myString, font1, Brushes.Black, 100, 100)

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        'Set page property to landscape
        PrintDocument1_PrintPage.DefaultPageSettings.Landscape = True
        'Call document to print from PrintDocument1.object
        PrintDialog1.Document = PrintDocument1

        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            'It will print the page
            Me.PrintDocument1_Print()


        End If


    End Sub

    Private Sub PrintDocument1_PrintPage_1(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Set font style to Arial, size 16,regular
        Dim font1 As New Font("Arial", 16, FontStyle, Regular)

        'Combine all text in one variable
        Dim myString As String
        myString = "Name : " & txtName.Text & vbNewLine
        & "Registration Number : " & txtRegNum.Text & vbNewLine
        & "Phone Number : " & txtTelNum.Text & vb
        & "Skills : " & txtSkilss.Text

        'Set the text and font to black color and start at 100,100
        e.Graphics.DrawString(myString, font1, Brushes.Black, 100, 100)


    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        'Call font dialog
        FontDialog1.ShowDialog()

        'The selected font style will affect the textboxes
        txtName.Font = FontDialog1.Font
        txtRegNum.Font = FontDialog1.Font
        txtTelNum.Font = FontDialog1.Font
        txtSkills.Font = FontDialog1.Font

    End Sub

    Private Sub ColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColourToolStripMenuItem.Click
        'Show color to textboxes
        ColorDialog1.ShowDialog()

        'Set color to textboxes
        txtName.ForeColor = ColorDialog1.Color
        txtRegNum.ForeColor = ColorDialog1.Color
        txtTelNum.ForeColor = ColorDialog1.Color
        txtSkills.ForeColor = ColorDialog1.Color


    End Sub

    Private Sub LeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeftToolStripMenuItem.Click
        txtName.TextAlign = HorizontalAlignment.Left
        txtRegNum.TextAlign = HorizontalAlignment.Left
        txtTelNum.TextAlign = HorizontalAlignment.Left
        txtSkills.TextAlign = HorizontalAlignment.Left

    End Sub

    Private Sub CenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CenterToolStripMenuItem.Click
        txtName.TextAlign = HorizontalAlignment.Center
        txtRegNum.TextAlign = HorizontalAlignment.Center
        txtTelNum.TextAlign = HorizontalAlignment.Center
        txtSkills.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub RightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RightToolStripMenuItem.Click
        txtName.TextAlign = HorizontalAlignment.Right
        txtRegNum.TextAlign = HorizontalAlignment.Right
        txtTelNum.TextAlign = HorizontalAlignment.Right
        txtSkills.TextAlign = HorizontalAlignment.Right
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

    End Sub