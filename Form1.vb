Public Class Form1

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk1.Click
        er.Clear()
        If validadata(txtData.Text) = True Then
            er.SetError(txtData, "Data válida !")
        Else
            er.SetError(txtData, "Data invalida !")
            txtData.Focus()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmPrincipal
    End Sub

    Private Sub btnOk2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk2.Click
        txtData.Text = ""
        txtNome.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmPrincipal.Hide()

        icoAviso.Visible = True
        icoAviso.ShowBalloonTip(1000)

    End Sub

    Private Sub icoAviso_BalloonTipClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles icoAviso.BalloonTipClicked
        icoAviso.Visible = False
        frmPrincipal.Show()
    End Sub

    Private Sub icoAviso_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles icoAviso.MouseDoubleClick

    End Sub

    Private Sub txtNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNome.TextChanged

    End Sub
End Class
