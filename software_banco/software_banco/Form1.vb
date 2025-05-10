Public Class Form1
    Dim cuenta1 As cuenta

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cuenta()
    End Sub
    Private Sub cuenta()
        If upd_tipo.Text = "CA" Then
            txt_descubierto.Enabled = False
            txt_descubierto.Text = 0
        End If
        If upd_tipo.Text = "CC" Then
            txt_descubierto.Enabled = True
        End If
    End Sub

    Private Sub btn_alta_Click(sender As Object, e As EventArgs) Handles btn_alta.Click
        If txt_numero.Text = "" Or txt_nombre.Text = "" Or upd_tipo.Text = "" Or txt_descubierto.Text = "" Then
            MsgBox("tiene que completar los parametos de la izquierda para crear una cuenta")
        Else
            cuenta1 = New cuenta(Val(txt_numero.Text), txt_nombre.Text, upd_tipo.Text, Val(txt_descubierto.Text))
            txt_valor.Enabled = True
            btn_deposit.Enabled = True
            btn_extraccion.Enabled = True
            btn_cerrar.Enabled = True

            btn_alta.Enabled = False
            txt_numero.Enabled = False
            txt_nombre.Enabled = False
            upd_tipo.Enabled = False
            txt_descubierto.Enabled = False
        End If
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        If cuenta1.extraccion_sobrecarga() = True Then
            lbl_valor.Text = cuenta1.dinero
        End If
    End Sub

    Private Sub upd_tipo_SelectedItemChanged(sender As Object, e As EventArgs) Handles upd_tipo.SelectedItemChanged
        cuenta()
    End Sub

    Private Sub btn_extraccion_Click(sender As Object, e As EventArgs) Handles btn_extraccion.Click
        If (txt_valor.Text = "" Or txt_valor.Text = "0") Then
            MsgBox("debe ingresar un valor para extraer")
        Else
            If cuenta1.extraccion(txt_valor.Text) = True Then
                lbl_valor.Text = cuenta1.dinero
            End If

        End If
    End Sub

    Private Sub btn_deposit_Click(sender As Object, e As EventArgs) Handles btn_deposit.Click
        cuenta1.deposito(txt_valor.Text)
        lbl_valor.Text = cuenta1.dinero
    End Sub
End Class
