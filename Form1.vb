Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Dim num1 As Integer
    Dim salida1, salida2, salida3 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1 = Integer.Parse(TextBox1.Text)
    End Sub
End Class
