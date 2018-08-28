Public Class Serie_fibonacci
    Dim maxValor As Integer
    Dim n As Integer
    Dim j As Integer
    Dim redon As Integer
    Dim ec As Single
    Dim fibonacci As Single

    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click
        j = 0
        maxValor = TextBox3.Text
        n = TextBox2.Text
        Dim serieFibo(maxValor) As Double
        Dim aureo(maxValor) As Single
        redon = n + 2
        Dim antNum, actNum As Single
        Do While j < maxValor
            If (j = 0) Then
                antNum = 0
                actNum = 1
            End If
            fibonacci = antNum + actNum
            serieFibo(j) = fibonacci
            aureo(j) = Math.Round(actNum / antNum, redon)
            antNum = actNum
            actNum = fibonacci
            salida.Rows.Add(j, serieFibo(j), aureo(j))
            j = j + 1
        Loop
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub
End Class
