Public Class frmClientes
    Dim RegistroAtual As Integer

    Private Sub tsbCadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCadastrar.Click
        'Abre o Form de Cadastro
        Dim fccForm As frmCadastroClientes = New frmCadastroClientes(Nothing)
        fccForm.ShowDialog()

        AtualizaDados()
    End Sub

    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AtualizaDados()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripButton.Click
        'Pega os Dados do Registro
        Dim id As Integer = dgvClientes.CurrentRow.Cells(0).Value

        Dim bll As BLLClientes = New BLLClientes
        Dim mdcDados As ModeloClientes
        mdcDados = bll.ObterRegistro(id)

        'Abre o Form de Cadastro
        Dim fccForm As frmCadastroClientes = New frmCadastroClientes(mdcDados)
        fccForm.ShowDialog()

        AtualizaDados()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripButton.Click
        If (MessageBox.Show("Tem Certeza?", "Tinker", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
            'Pega os Dados do Registro
            Dim id As Integer = dgvClientes.CurrentRow.Cells(0).Value

            Dim bll As BLLClientes = New BLLClientes
            If bll.Excluir(id) = True Then
                MessageBox.Show("Registro Excluído com Sucesso", "Tinker", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Erro ao Excluir Registro", "Tinker", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        AtualizaDados()
    End Sub

    Private Sub AtualizaDados()
        'Carrega a Lista de Clientes
        Dim bll As BLLClientes = New BLLClientes
        Dim dtbDados As DataTable
        dtbDados = bll.Listar()

        ' Seta o DataGridView
        dgvClientes.DataSource = dtbDados
        dgvClientes.Refresh()

        If dtbDados.Rows.Count <> 0 Then
            EditarToolStripButton.Enabled = True
            ExcluirToolStripButton.Enabled = True
        Else
            EditarToolStripButton.Enabled = False
            ExcluirToolStripButton.Enabled = False
        End If
    End Sub
End Class