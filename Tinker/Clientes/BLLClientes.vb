Public Class BLLClientes

    Public Function Listar() As DataTable
        'DAL
        Dim m As DALClientes = New DALClientes

        'Retorna os Dados
        Return m.Listar()
    End Function

    Public Function ObterRegistro(ByVal id As Integer) As ModeloClientes
        'DAL
        Dim m As DALClientes = New DALClientes

        'Retorna os Dados
        Return m.ObterRegistro(id)
    End Function

    Public Function Cadastrar(ByVal mdcDados As ModeloClientes) As Integer
        Dim m As DALClientes = New DALClientes
        Return m.Cadastrar(mdcDados)
    End Function

    Public Function Editar(ByVal mdcDados As ModeloClientes) As Integer
        Dim m As DALClientes = New DALClientes
        Return m.Editar(mdcDados)
    End Function

    Public Function Excluir(ByVal id As Integer) As Integer
        Dim m As DALClientes = New DALClientes
        Return m.Excluir(id)
    End Function
End Class
