Imports CamadaDeNegocios


Public NotInheritable Class frmSplash
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Application.Exit()
    End Sub
    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Dim UsuarioAtual As New Usuario()
        Dim Login As String = ValidaDados(txtLogin.Text)
        Dim Senha As String = ValidaDados(txtSenha.Text)

        Dim cripto As New Criptografia()
        Login = cripto.Criptografar(Login, True)
        Senha = cripto.Criptografar(Senha, True)

        Dim resultado As Boolean = UsuarioAtual.VerificaUsuario(Login, Senha)

        If resultado Then
            UsuarioLogado = UsuarioAtual
            Me.Hide()
            frmPrincipal.Show()
        Else
            MsgBox("Login ou Senha Inválidos!", MsgBoxStyle.OkOnly, "Autenticação Inválida")
        End If
    End Sub
    Private Sub frmSplash_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txtSenha.Text = ""
    End Sub

#Region "Validações"
    Private Function ValidaDados(ByVal Texto As String) As String
        Dim lixo() As String = {"select", "drop", ";", "--", "insert", "delete", "xp_", "'"}

        For i As Integer = 0 To UBound(lixo) Step 1
            Texto = Replace(Texto, lixo(i), "")
        Next

        Return Texto
    End Function 'DESTROI INJEÇAO SQL
    Private Sub txtLogin_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtLogin.Validating
        If txtLogin.Text.Equals("") Then
            e.Cancel = True
            erro.SetError(txtLogin, "Este campo não pode ser vazio!")
        Else
            erro.SetError(txtLogin, "")
        End If
    End Sub
    Private Sub txtSenha_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSenha.Validating
        If txtSenha.Text.Equals("") Then
            e.Cancel = True
            erro.SetError(txtSenha, "Este campo não pode ser vazio!")
        Else
            erro.SetError(txtSenha, "")
        End If
    End Sub
#End Region
End Class
