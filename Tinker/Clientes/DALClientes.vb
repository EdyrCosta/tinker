Imports System.Data
Imports System.Data.SQLite

Public Class DALClientes

    Private sqcConexao As SQLiteConnection
    Private strConexao As String = "Data Source=" + Application.StartupPath + "\TinkerDB.s3db;Version=3"

    Public Sub New()
        'Faz a Conexão
        sqcConexao = New SQLiteConnection(strConexao)
    End Sub

    Public Function Listar() As DataTable
        Dim dtbDados As DataTable = New DataTable

        'Trata as Exceções
        Try
            'Prepara a Query
            Dim query As String = "SELECT * FROM clientes"
            Dim scmComando As SQLiteCommand = New SQLiteCommand(query, sqcConexao)
            Dim sdaAdaptador As SQLiteDataAdapter = New SQLiteDataAdapter(scmComando)

            'Abre a Conexão
            sqcConexao.Open()

            'Preenche o DataTable com os Dados
            sdaAdaptador.Fill(dtbDados)
            Return dtbDados
        Catch ex As Exception
            Return Nothing
        Finally
            'Fecha a Conexão
            sqcConexao.Close()
        End Try

        'Retorna os Dados
        Return dtbDados
    End Function

    Public Function ObterRegistro(ByVal id As Integer) As ModeloClientes
        Dim mdcDados As ModeloClientes = New ModeloClientes

        'Trata as Exceções
        Try
            'Prepara a Query
            Dim query As String = "SELECT * FROM clientes WHERE id=@id"
            Dim scmComando As SQLiteCommand = New SQLiteCommand(query, sqcConexao)
            scmComando.Parameters.AddWithValue("id", id)
            Dim sdaAdaptador As SQLiteDataAdapter = New SQLiteDataAdapter(scmComando)

            'Abre a Conexão
            sqcConexao.Open()

            'Preenche o DataTable
            Dim dtbDados As DataTable = New DataTable
            sdaAdaptador.Fill(dtbDados)

            'Percorre os Registros
            For Each linha As DataRow In dtbDados.Rows
                mdcDados.ID = linha.Item("id")
                mdcDados.Nome = linha.Item("nome")
                mdcDados.Endereco = linha.Item("endereco")
                mdcDados.Telefone = linha.Item("telefone")
            Next

            'Retorna os Dados
            Return mdcDados
        Catch ex As Exception
            Return Nothing
        Finally
            'Fecha a Conexão
            sqcConexao.Close()
        End Try

        'Retorna os Dados
        Return mdcDados
    End Function

    Public Function Cadastrar(ByVal mdcDados As ModeloClientes) As Boolean
        'Trata as Exceções
        Try
            'Prepara a Query
            Dim query As String = "INSERT INTO clientes (nome, endereco, telefone) VALUES (@nome, @endereco, @telefone)"
            Dim scmComando As SQLiteCommand = New SQLiteCommand(query, sqcConexao)
            scmComando.Parameters.AddWithValue("nome", mdcDados.Nome)
            scmComando.Parameters.AddWithValue("endereco", mdcDados.Endereco)
            scmComando.Parameters.AddWithValue("telefone", mdcDados.Telefone)

            'Abre a Conexão
            sqcConexao.Open()
            'Executa a Query
            scmComando.ExecuteNonQuery()
        Catch ex As Exception
            Return False
        Finally
            'Fecha a Conexão
            sqcConexao.Close()
        End Try

        'Retorna os Dados
        Return True
    End Function

    Public Function Editar(ByVal mdcDados As ModeloClientes) As Boolean
        'Trata as Exceções
        Try
            'Prepara a Query
            Dim query As String = "UPDATE clientes SET nome=@nome, endereco=@endereco, telefone=@telefone WHERE id=@id"
            Dim scmComando As SQLiteCommand = New SQLiteCommand(query, sqcConexao)
            scmComando.Parameters.AddWithValue("nome", mdcDados.Nome)
            scmComando.Parameters.AddWithValue("endereco", mdcDados.Endereco)
            scmComando.Parameters.AddWithValue("telefone", mdcDados.Telefone)
            scmComando.Parameters.AddWithValue("id", mdcDados.ID)

            'Abre a Conexão
            sqcConexao.Open()
            'Executa a Query
            scmComando.ExecuteNonQuery()
        Catch ex As Exception
            Return False
        Finally
            'Fecha a Conexão
            sqcConexao.Close()
        End Try

        'Retorna os Dados
        Return True
    End Function

    Public Function Excluir(ByVal id As Integer) As Boolean
        'Trata as Exceções
        Try
            'Prepara a Query
            Dim query As String = "DELETE FROM clientes WHERE id=@id"
            Dim scmComando As SQLiteCommand = New SQLiteCommand(query, sqcConexao)
            scmComando.Parameters.AddWithValue("id", id)

            'Abre a Conexão
            sqcConexao.Open()
            'Executa a Query
            scmComando.ExecuteNonQuery()
        Catch ex As Exception
            Return False
        Finally
            'Fecha a Conexão
            sqcConexao.Close()
        End Try

        'Retorna os Dados
        Return True
    End Function

End Class