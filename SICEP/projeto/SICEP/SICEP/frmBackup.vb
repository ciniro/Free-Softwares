Imports CamadaDeNegocios

Public Class frmBackup

    Private Sub frmBackup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bck As New SistemaBackup
        lblData.Text = bck.DataUltimoBackup()
    End Sub

    Private Sub cmdFazerBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFazerBackup.Click
        Dim texto As String = "Você tem certeza deseja guardar estes dados?" + vbCrLf + "Esta ação substituirá o backup antigo."
        If (MsgBox(texto, MsgBoxStyle.YesNo, "Confirmação de Backup") = MsgBoxResult.Yes) Then
            Dim bck As New SistemaBackup
            If bck.FazerBackup() Then
                MsgBox("Backup feito com sucesso! Os dados foram guardados á salvo.")
                lblData.Text = bck.DataUltimoBackup()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim bck As New SistemaBackup
        Dim texto As String = "Você tem certeza deseja restaurar estes dados?" + vbCrLf + "Esta ação substituirá os dados atuais do SICEP 1.0 pelos dados que existiam na seguinte data: " + bck.DataUltimoBackup()
        If (MsgBox(texto, MsgBoxStyle.YesNo, "Confirmação de Restauração") = MsgBoxResult.Yes) Then
            If bck.RestaurarBackup() Then
                MsgBox("Restauração feita com sucesso! Os SICEP 1.0 operará agora com os dados do último backup.")
                lblData.Text = bck.DataUltimoBackup()
            End If
        End If
    End Sub
End Class