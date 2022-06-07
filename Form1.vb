Public Class Form1

    Dim Faktor1 As Integer, Faktor2 As Integer, Eingabe As Integer, Ergebnis As Integer
    ' Private Declare Sub Sleep Lib "kernel32" Alias "Sleep" (ByVal dwMilliseconds As Long)

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label6.Text = ""
        Label6.Focus()
        Label6.BackColor = Color.LightGray

        Randomize()
        Faktor1 = Rnd() * 9 + 1
        Faktor2 = Rnd() * 9 + 1

        TextBox1.Text = ""
        TextBox1.Focus()

        Label2.Text = Convert.ToString(Faktor1)
        Label3.Text = Convert.ToString(Faktor2)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Ergebnis = Faktor1 * Faktor2
        Eingabe = TextBox1.Text

        If Eingabe = Ergebnis Then
            Label6.Text = "RICHTIG"
            Label6.BackColor = Color.Green
        Else
            Label6.Text = "FALSCH"
            Label6.BackColor = Color.Red
            Label6.Focus()
        End If

        ' Sleep(2000)
        ' Label6.Text = ""
        ' Label6.BackColor = Color.LightGray
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1_Click(sender, e)
    End Sub
End Class
