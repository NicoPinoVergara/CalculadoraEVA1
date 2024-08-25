Public Class Form1
    Dim primerNum As Double
    Dim segundoNum As Double
    Dim operacion As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BT0_Click(sender As Object, e As EventArgs) Handles BT0.Click
        txtdigito.Text = txtdigito.Text & "0"
    End Sub

    Private Sub BTbarrer_Click(sender As Object, e As EventArgs) Handles BTbarrer.Click
        txtdigito.Text = ""
    End Sub

    Private Sub BTdividir_Click(sender As Object, e As EventArgs) Handles BTdividir.Click
        primerNum = txtdigito.Text
        txtdigito.Text = ""
        operacion = "/"
    End Sub

    Private Sub BTMultiplicar_Click(sender As Object, e As EventArgs) Handles BTMultiplicar.Click
        primerNum = txtdigito.Text
        txtdigito.Text = ""
        operacion = "x"
    End Sub

    Private Sub BT1_Click(sender As Object, e As EventArgs) Handles BT1.Click
        txtdigito.Text = txtdigito.Text & "1"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtdigito.TextChanged

    End Sub

    Private Sub BT2_Click(sender As Object, e As EventArgs) Handles BT2.Click
        txtdigito.Text = txtdigito.Text & "2"
    End Sub

    Private Sub BT3_Click(sender As Object, e As EventArgs) Handles BT3.Click
        txtdigito.Text = txtdigito.Text & "3"
    End Sub

    Private Sub BT4_Click(sender As Object, e As EventArgs) Handles BT4.Click
        txtdigito.Text = txtdigito.Text & "4"
    End Sub

    Private Sub BT5_Click(sender As Object, e As EventArgs) Handles BT5.Click
        txtdigito.Text = txtdigito.Text & "5"
    End Sub

    Private Sub BT6_Click(sender As Object, e As EventArgs) Handles BT6.Click
        txtdigito.Text = txtdigito.Text & "6"
    End Sub

    Private Sub BT7_Click(sender As Object, e As EventArgs) Handles BT7.Click
        txtdigito.Text = txtdigito.Text & "7"
    End Sub

    Private Sub BT8_Click(sender As Object, e As EventArgs) Handles BT8.Click
        txtdigito.Text = txtdigito.Text & "8"
    End Sub

    Private Sub BT9_Click(sender As Object, e As EventArgs) Handles BT9.Click
        txtdigito.Text = txtdigito.Text & "9"
    End Sub

    Private Sub BTsuma_Click(sender As Object, e As EventArgs) Handles BTsuma.Click
        primerNum = txtdigito.Text
        txtdigito.Text = ""
        operacion = "+"
    End Sub

    Private Sub BTrestar_Click(sender As Object, e As EventArgs) Handles BTrestar.Click
        primerNum = txtdigito.Text
        txtdigito.Text = ""
        operacion = "-"
    End Sub

    Private Sub BTigual_Click(sender As Object, e As EventArgs) Handles BTigual.Click
        segundoNum = txtdigito.Text
        Select Case operacion
            Case "+"
                txtdigito.Text = primerNum + segundoNum
            Case "-"
                txtdigito.Text = primerNum - segundoNum
            Case "x"
                txtdigito.Text = primerNum * segundoNum
            Case "/"
                If segundoNum = 0 Then
                    txtdigito.Text = "No se puede divir entre 0"
                Else
                    txtdigito.Text = primerNum / segundoNum
                End If
        End Select
    End Sub
End Class
