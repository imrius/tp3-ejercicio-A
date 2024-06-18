Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Dim num1 As Integer
    Dim salida1, salida2, salida3 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1 = Integer.Parse(TextBox1.Text)

        salida1 = Math.Truncate(num1 / 100)
        Label1.Text = "Centena: " & salida1.ToString()

        salida2 = Math.Truncate((num1 Mod 100) / 10)
        Label2.Text = "Decena: " & salida2.ToString()

        salida3 = num1 Mod 10
        Label3.Text = "Unidad: " & salida3.ToString()
    End Sub
End Class
