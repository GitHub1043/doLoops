Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intNumber As Integer = 0
        Do
            intNumber = intNumber + 1
            MessageBox.Show(intNumber)
        Loop Until intNumber = 10

        intNumber = 0
        Do
            intNumber = intNumber + 1
            MessageBox.Show(intNumber)
        Loop While intNumber < 10
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim intNumber As Integer = 0
        Do
            intNumber = intNumber + 3
            MessageBox.Show(intNumber)
        Loop Until intNumber = 15

        intNumber = 0
        Do
            intNumber = intNumber + 3
            MessageBox.Show(intNumber)
        Loop While intNumber < 15
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim intNumber As Integer = 5
        Do
            MessageBox.Show(intNumber)
            intNumber = intNumber + 3
        Loop Until intNumber > 27

        intNumber = 5
        Do
            MessageBox.Show(intNumber)
            intNumber = intNumber + 3
        Loop While intNumber < 27
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim intNumber As Integer = 0
        Do
            intNumber = intNumber - 1
            MessageBox.Show(intNumber)
        Loop While intnumber < 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim intStart As Integer
        Dim intStop As Integer
        Dim intSkip As Integer
        Dim intNumber As Integer
        intStart = InputBox("Enter A Start")
        intStop = InputBox("Enter A Stop")
        intSkip = InputBox("Enter A Skip")
        intNumber = intStart
    End Sub
End Class
