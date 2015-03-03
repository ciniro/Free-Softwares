Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.File


Namespace Backup
    Public Class BackupSQLServer2000

        Private ConnString As String
        Sub New()
            ConnString = AcessoDados.My.Settings.strConexao.ToString()
        End Sub

        Public Function ObtemBasesDeDados() As String()
            Dim cn As New SqlConnection(ConnString)
            Dim dbLista As New ArrayList

            Dim cmd As New SqlCommand("SELECT [name] FROM sysdatabases", cn)
            Dim leitor As SqlDataReader

            cn.Open()
            Try
                leitor = cmd.ExecuteReader()
                While leitor.Read()
                    dbLista.Add(leitor("name"))
                End While
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return dbLista.ToArray(GetType(String))
        End Function

        Public Sub BackupDatabase(ByVal nomeDB As String, ByVal backupFile As String)

            Dim cn As New SqlConnection(ConnString)

            Try
                ' comando para fazer o backup do Banco de dados
                Dim cmdBackup As New SqlCommand("BACKUP DATABASE [" & nomeDB & "] TO DISK = '" & backupFile & "'", cn)
                cn.Open()
                cmdBackup.ExecuteNonQuery()
            Finally
                cn.Close()
            End Try
        End Sub

        Public Sub RestauraDatabase(ByVal nomeDB As String, ByVal backupFile As String)

            Dim cn As New SqlConnection(ConnString)
            Try
                'comando para restaurar o banco de dados
                Dim cmdBackup As New SqlCommand("RESTORE DATABASE [" & nomeDB & "] FROM DISK = '" & backupFile & "'", cn)
                cn.Open()
                cmdBackup.ExecuteNonQuery()
            Finally
                cn.Close()
            End Try
        End Sub

        Public Function PegaUltimaModificacao(ByVal backupFile As String) As String
            If File.Exists(backupFile) Then
                Return File.GetLastWriteTime(backupFile)
            Else
                Return "Não foi feito nenhum backup!"
            End If
        End Function
    End Class
End Namespace
