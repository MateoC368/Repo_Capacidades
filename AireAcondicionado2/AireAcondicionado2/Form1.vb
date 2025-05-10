Public Class Form1
    Dim aire As AIRE
    Public Sub vacio()
        If txt_frigorias.Text = "" Or txt_marca.Text = "" Or txt_pais.Text = "" Then
            btn_alta.Enabled = False
        Else
            btn_alta.Enabled = True
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vacio()
    End Sub
    Private Sub btn_alta_Click(sender As Object, e As EventArgs) Handles btn_alta.Click
        aire = New AIRE(txt_marca.Text, txt_frigorias.Text, chk_split.Checked, txt_pais.Text, rbtn_friosol.Checked)
        txt_modelo.Text = aire.Modelo
        Panel2.Visible = True
        aire.Encendido = False
        lbl_temperatura.Text = "-"

    End Sub

    Private Sub txt_marca_TextChanged(sender As Object, e As EventArgs) Handles txt_marca.TextChanged
        vacio()
    End Sub

    Private Sub txt_frigorias_TextChanged(sender As Object, e As EventArgs) Handles txt_frigorias.TextChanged
        vacio()
    End Sub

    Private Sub txt_pais_TextChanged(sender As Object, e As EventArgs) Handles txt_pais.TextChanged
        vacio()
    End Sub

    Private Sub btn_power_Click(sender As Object, e As EventArgs) Handles btn_power.Click
        aire.Encendido = Not aire.Encendido
        If aire.Encendido Then
            lbl_temperatura.Text = aire.Temperatura
        Else
            lbl_temperatura.Text = "-"
        End If

    End Sub

    Private Sub btn_mas_Click(sender As Object, e As EventArgs) Handles btn_mas.Click
        If aire.Encendido Then
            lbl_temperatura.Text = aire.SUBIR(1)
        End If
    End Sub

    Private Sub btn_menos_Click(sender As Object, e As EventArgs) Handles btn_menos.Click
        If aire.Encendido Then
            lbl_temperatura.Text = aire.BAJAR(1)
        End If
    End Sub

    Private Sub btn_min_Click(sender As Object, e As EventArgs) Handles btn_min.Click
        If aire.Encendido Then
            lbl_temperatura.Text = aire.BAJAR()
        End If
    End Sub

    Private Sub btn_max_Click(sender As Object, e As EventArgs) Handles btn_max.Click
        If aire.Encendido Then
            lbl_temperatura.Text = aire.SUBIR()
        End If
    End Sub
End Class
