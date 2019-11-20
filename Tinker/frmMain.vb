Public Class frmMain

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        'Fecha o Tinker
        Application.Exit()
    End Sub

    Private Sub tmrTempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTempo.Tick
        'Configura a Hora e a Data Local
        sslHora.Text = DateTime.Now.ToLongTimeString
        sslData.Text = DateTime.Now.ToLongDateString
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        'Abre dentro do Form
        Dim fclForm As frmClientes = New frmClientes
        fclForm.MdiParent = Me
        fclForm.Show()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        frmInfo.ShowDialog()
    End Sub

    Private Sub EmCascataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmCascataToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub VerticalmenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerticalmenteToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub HorizoltalmenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HorizoltalmenteToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
End Class
