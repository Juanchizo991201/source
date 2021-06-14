Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Bienvenido a Mi primer Programa!!!", "Mi Primer Programa")
    End Sub
    Private Sub BtnContinuar_Click(sender As Object, e As EventArgs) Handles BtnClickAquí.Click
        TbxExample.Text = "Bienvenido a Visual Studio"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAyuda.Click
        TbxExample.Text = "Contento?"
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub TbxExample_TextChanged(sender As Object, e As EventArgs) Handles TbxExample.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) 

    End Sub
End Class
