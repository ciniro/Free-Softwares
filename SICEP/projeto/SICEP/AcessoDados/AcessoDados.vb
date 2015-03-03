Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Collections.Generic

Namespace ConexaoComSQLServer
    Public Class conexaoSQLServer

        Sub New() 'METODO CONSTRUTOR
        End Sub
        Private conexao As New SqlConnection()

        Public Sub _AbreConexao()
            Try
                If (conexao.State = ConnectionState.Closed) Then
                    Dim strConexao As String = AcessoDados.My.Settings.strConexao.ToString()
                    conexao = New SqlConnection(strConexao)
                    conexao.Open()
                End If
            Catch ex As Exception
                Throw New Exception("Ocorreu um problema na conexão com o base de dados, devido ao seguinte erro: " + ex.Message)
            End Try
        End Sub

        Public Sub _FechaConexao()
            Try
                If (conexao.State = ConnectionState.Open) Then
                    conexao.Close()
                End If
            Catch ex As Exception
                Throw New Exception("Ocorreu um problema na conexão com o base de dados, devido ao seguinte erro: " + ex.Message)
            End Try
        End Sub

        Public Sub _PreencheDataSet(ByVal dts As DataSet, ByVal sql As String, ByVal tabela As String)
            Try
                Dim da As New SqlDataAdapter(sql, conexao)
                da.Fill(dts, tabela)
            Catch ex As Exception
                Throw New Exception("Ocorreu um problema na conexão com o base de dados, devido ao seguinte erro: " + ex.Message)
            End Try
        End Sub

        Public Sub _PreencheDataSet(ByVal dts As DataSet, ByVal sql As String)
            Try
                Dim da As New SqlDataAdapter(sql, conexao)
                da.Fill(dts)
            Catch ex As Exception
                Throw New Exception("Ocorreu um problema na conexão com o base de dados, devido ao seguinte erro: " + ex.Message)
            End Try
        End Sub

        Public Sub _PreencheDataTable(ByVal dt As DataTable, ByVal sql As String)
            Try
                Dim da As New SqlDataAdapter(sql, conexao)
                da.Fill(dt)
            Catch ex As Exception
                Throw New Exception("Ocorreu um problema na conexão com o base de dados, devido ao seguinte erro: " + ex.Message)
            End Try
        End Sub

        Public Sub _ExecutaComandoSQL(ByVal sql As String)
            Try
                Dim cmd As New SqlCommand(sql, conexao)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Ocorreu um problema na conexão com o base de dados, devido ao seguinte erro: " + ex.Message)
            End Try
        End Sub
    End Class
End Namespace

