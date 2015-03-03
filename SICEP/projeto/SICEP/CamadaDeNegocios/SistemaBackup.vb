Imports AcessoDados.Backup

Public Class SistemaBackup
    Private bck As New BackupSQLServer2000
    Public Function FazerBackup() As Boolean
        Try
            bck.BackupDatabase("bd_sicep", "C:\Arquivos de programas\SICEP\data\bckSICEP.bak")
            Return True
        Catch Ex As Exception
            Throw Ex
            Return False
        End Try
    End Function
    Public Function RestaurarBackup() As Boolean
        Try
            bck.RestauraDatabase("bd_sicep", "C:\Arquivos de programas\SICEP\data\bckSICEP.bak")
            Return True
        Catch Ex As Exception
            Throw Ex
            Return False
        End Try
    End Function

    Public Function DataUltimoBackup() As String
        Try
            Return bck.PegaUltimaModificacao("C:\Arquivos de programas\SICEP\data\bckSICEP.bak")
        Catch ex As Exception
            Throw ex
            Return ""
        End Try
    End Function
End Class
