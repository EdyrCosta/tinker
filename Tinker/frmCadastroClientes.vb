Public Class frmCadastroClientes
    Private mdcDadosA As ModeloClientes

    Public Sub New(ByVal mdcDados As ModeloClientes)
        'Inicializa o Design
        InitializeComponent()

        'Referência
        Me.mdcDadosA = mdcDados
    End Sub

    Private Sub btnCadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrar.Click
        'Valida os campos
        If txbNome.Text.Trim = String.Empty Then
            'Avisa ao Usuário
            MessageBox.Show("Preencha o Campo 'Nome'", "Tinker", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            'Retorna
            Return
        End If

        'Prepara os Dados
        Dim mdcDados As ModeloClientes = New ModeloClientes
        mdcDados.Nome = txbNome.Text
        mdcDados.Endereco = txbEndereco.Text
        mdcDados.Telefone = mtbTelefone.Text
        If mdcDadosA Is Nothing Then
        Else
            mdcDados.ID = mdcDadosA.ID
        End If

        'Grava os Dados
        Dim bll As BLLClientes = New BLLClientes
        If mdcDadosA Is Nothing Then
            If bll.Cadastrar(mdcDados) = True Then
                MessageBox.Show("Cliente Cadastrado com Sucesso", "Tinker", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cliente Não foi Cadastrado com Sucesso", "Tinker", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If bll.Editar(mdcDados) = True Then
                MessageBox.Show("Cliente Atualizado com Sucesso", "Tinker", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cliente Não foi Atualizado com Sucesso", "Tinker", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If


    End Sub

    Private Sub frmCadastroClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mdcDadosA Is Nothing Then
        Else
            txbNome.Text = mdcDadosA.Nome
            txbEndereco.Text = mdcDadosA.Endereco
            mtbTelefone.Text = mdcDadosA.Telefone
        End If
    End Sub
End Class