Public Class frmMain
    Dim Aklimda, Level, Defa As Integer
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Level = 1 : Aklimda = Rnd() * (4 * Level) + 1 : Defa = 0
        Label2.Text = "Write a number between 1 and " & (4 * Level) + 1
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If TextBox1.Text = "" Then Exit Sub
        If IsNumeric(TextBox1.Text) = False Then Label1.Text = "Write a number please!" : Exit Sub
        If e.KeyCode = Keys.Enter Then
            Defa += 1
            If TextBox1.Text = Aklimda Then
                Label1.Text = "Bravo!" + vbCrLf + "You have guessed " + Defa.ToString + " times!" + vbCrLf + "New game started"
                Aklimda = Rnd() * (4 * Level) + 1 : Level += 1 : TextBox1.Text = "" : Defa = 0
                Label2.Text = "Write a number between 1 and " & (4 * Level) + 1
            ElseIf Int(TextBox1.Text) > Aklimda Then
                Label1.Text = "write a smaller value" : TextBox1.SelectAll()
            ElseIf Int(TextBox1.Text) < Aklimda Then
                Label1.Text = "write a bigger value" : TextBox1.SelectAll()
            End If
        End If
    End Sub
End Class
