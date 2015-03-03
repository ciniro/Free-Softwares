Imports CamadaDeNegocios

Public Class frmCadUsuario
#Region "Funções Privadas"
    Private Sub PreencheGridPesquisa(ByVal nome As String)
        Dim usu As New Usuario
        grdUsuario.DataSource = usu.SelecionaPorNome(nome, UsuarioLogado.Codigo)
    End Sub
    Private Sub LimpaTudo()
        lblCodigo.Text = String.Empty
        lblDataCadastramento.Text = String.Empty
        txtNome.Text = String.Empty
        txtEndereco.Text = String.Empty
        txtCargo.Text = String.Empty
        txtEmail.Text = String.Empty
        txtTelRes.Text = String.Empty
        txtTelCel.Text = String.Empty
        txtCPF.Text = String.Empty
        txtRG.Text = String.Empty
        txtLogin.Text = String.Empty
        txtSenha.Text = String.Empty
        txtConfSenha.Text = String.Empty
        lblValNome.Visible = False
        lblValEndereco.Visible = False
        lblValTelRes.Visible = False
        lblValTelCel.Visible = False
        lblValCPF.Visible = False
        lblValLogin.Visible = False
        lblValSenha.Visible = False
        lblValConfSenha.Visible = False
    End Sub
    Private Sub PreencheDropPerfil()
        Dim usu As New Usuario
        Dim tbl As New dtsBD_SICEP.tb_perfilDataTable
        tbl = usu.SelecionaPerfil()
        dpdPerfil.DataSource = tbl
        dpdPerfil.DisplayMember = "nome_perfil"
        dpdPerfil.ValueMember = "cod_perfil"
    End Sub
    Private Sub DefineBotoes(ByVal Novo As Boolean, ByVal Salvar As Boolean, ByVal Alterar As Boolean, ByVal Excluir As Boolean, ByVal Cancelar As Boolean)
        cmdNovo.Visible = Novo
        cmdSalvar.Visible = Salvar
        cmdAlterar.Visible = Alterar
        cmdExcluir.Visible = Excluir
        cmdCancelar.Visible = Cancelar
    End Sub
    Private Sub PreencheFormulario(ByVal codigo As Integer)
        Dim usu As New Usuario
        usu.SelecionaPorCodigo(codigo)
        lblCodigo.Text = usu.Codigo
        lblDataCadastramento.Text = usu.DataCadastro
        txtNome.Text = usu.Nome
        txtEndereco.Text = usu.Endereco
        txtCargo.Text = usu.Cargo
        txtEmail.Text = usu.Email
        txtTelRes.Text = usu.TelResidencial
        txtTelCel.Text = usu.TelCelular
        txtCPF.Text = usu.CPF
        txtRG.Text = usu.RG
        txtLogin.Text = usu.Login
        txtSenha.Text = usu.Senha
        txtConfSenha.Text = usu.Senha
        dpdPerfil.SelectedValue = usu.Perfil
    End Sub
    Private Function ValidaDados() As Boolean
        Dim ERRO As Boolean = False
        lblValNome.Visible = False
        lblValEndereco.Visible = False
        lblValTelRes.Visible = False
        lblValTelCel.Visible = False
        lblValCPF.Visible = False
        lblValLogin.Visible = False
        lblValSenha.Visible = False
        lblValConfSenha.Visible = False
        Dim TelCel As String = Replace(txtTelCel.Text, " ", "")
        Dim TelRes As String = Replace(txtTelRes.Text, " ", "")
        Dim CPF As String = Replace(txtCPF.Text, " ", "")
        If TelCel.Length < 13 And TelCel.Length > 3 Then 'ERRO
            ERRO = True
            lblValTelCel.Visible = True
        End If
        If TelRes.Length < 13 And TelRes.Length > 3 Then 'ERRO
            ERRO = True
            lblValTelRes.Visible = True
        End If
        If CPF.Length < 14 And CPF.Length > 3 Then 'ERRO
            ERRO = True
            lblValCPF.Visible = True
        End If
        If txtNome.Text.Trim() = "" Then
            ERRO = True
            lblValNome.Visible = True
        End If
        If txtEndereco.Text.Trim() = "" Then
            ERRO = True
            lblValEndereco.Visible = True
        End If
        If txtLogin.Text.Trim() = "" Then
            ERRO = True
            lblValLogin.Visible = True
        End If
        If txtSenha.Text.Trim() = "" Then
            ERRO = True
            lblValSenha.Visible = True
        End If
        If txtConfSenha.Text.Trim() = "" Then
            ERRO = True
            lblValConfSenha.Visible = True
        End If
        If txtSenha.Text.Trim() <> txtConfSenha.Text.Trim() Then
            ERRO = True
            lblValSenha.Visible = True
            lblValConfSenha.Visible = True
            MsgBox("A senha digitada não confere com sua confirmação!")
            txtSenha.SelectAll()
            txtSenha.Focus()
        End If

        Return ERRO
    End Function
    Private Sub Cancelar()
        DefineBotoes(True, False, False, False, False)
        pnlPesquisa.Enabled = True
        LimpaTudo()
        PreencheGridPesquisa("")
        dpdPerfil.SelectedIndex = 0
    End Sub
    Private Sub SetaToolTip()
        Dim linha As DataRowView = dpdPerfil.SelectedItem
        Dim codigo As Integer = linha.Item(0)
        Dim texto As String = ""
        Select Case codigo
            Case 1
                texto = "O usuário com este perfil tem acesso a " + vbCr + "todas as funções do sistema." + vbCr + " Pode cadastrar, operar estoques, " + vbCr + "emitir relatórios e modificar usuários."
            Case 2
                texto = "O usuário da secretaria pode cadastrar " + vbCr + "pacientes, operar os estoques " + vbCr + "da secretaria e emitir relatórios " + vbCr + "referentes ao mesmo. Não podendo cadastrar" + vbCr + " medicamentos, usuários e micro-áreas, nem funções " + vbCr + "referentes a Policlínica."
            Case 3
                texto = "O usuário da policlínica pode cadastrar " + vbCr + "pacientes, operar os estoques da " + vbCr + "policlínica e emitir relatórios " + vbCr + "referentes ao mesmo. Não podendo cadastrar " + vbCr + "medicamentos, usuários e micro-áreas, nem funções " + vbCr + "referentes a Secretaria."
            Case Else
                texto = "O usuário comum funciona como um visitante, " + vbCr + "não tem acesso a nenhuma função " + vbCr + "do sistema. Serve para que o " + vbCr + "cadastro de usuário também seja flexível para " + vbCr + "um possível cadastro de funcionários."
        End Select
        ToolTip.SetToolTip(imgInformacoes, texto)
    End Sub
#End Region
    Private Sub txtPesquisa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisa.TextChanged
        PreencheGridPesquisa(txtPesquisa.Text)
    End Sub
    Private Sub grdUsuario_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdUsuario.CellContentClick
        Dim codigo As Integer = grdUsuario.SelectedCells(e.ColumnIndex - 1).Value
        PreencheFormulario(codigo)
        DefineBotoes(False, False, True, True, True)
    End Sub
    Private Sub frmCadUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LimpaTudo()
        dpdPerfil.DataSource = New DataTable
        PreencheGridPesquisa("")
        PreencheDropPerfil()
        DefineBotoes(True, False, False, False, False)
        pnlPesquisa.Enabled = True
    End Sub
    Private Sub cmdNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNovo.Click
        DefineBotoes(False, True, False, False, True)
        pnlPesquisa.Enabled = False
    End Sub
    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
        If Not ValidaDados() Then
            Dim usu As New Usuario()
            If Not usu.TestaLogin(txtLogin.Text) Then
                Dim TelRes As String = txtTelRes.Text
                Dim TelCel As String = txtTelCel.Text
                Dim CPF As String = txtCPF.Text
                If TelRes = "(  )    -" Then
                    TelRes = ""
                End If
                If TelCel = "(  )    -" Then
                    TelCel = ""
                End If
                If CPF = "   .   .   -" Then
                    CPF = ""
                End If
                usu.Nome = txtNome.Text
                usu.Endereco = txtEndereco.Text
                usu.Cargo = txtCargo.Text
                usu.Email = txtEmail.Text
                usu.TelResidencial = TelRes
                usu.TelCelular = TelCel
                usu.CPF = CPF
                usu.RG = txtRG.Text
                usu.Login = txtLogin.Text
                usu.Senha = txtSenha.Text
                Dim linha As DataRowView = dpdPerfil.SelectedItem
                usu.Perfil = linha.Item(0)
                If usu.Salvar() Then
                    MsgBox("Usuário salvo com sucesso!")
                End If
                Cancelar()
            Else
                txtLogin.SelectAll()
                txtLogin.Focus()
                MsgBox("Já existe um usuário com este login, defina um diferente!")
            End If
        Else
            MsgBox("Por favor, preencha os campos marcados corretamente!")
        End If
    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        If Not ValidaDados() Then
            If MsgBox("Tente certeza que fazer esta alteração?", MsgBoxStyle.OkCancel, "Confirmação") = MsgBoxResult.Ok Then
                Dim usu As New Usuario()
                If Not usu.TestaLoginAltera(txtLogin.Text, Int32.Parse(lblCodigo.Text)) Then
                    Dim TelRes As String = txtTelRes.Text
                    Dim TelCel As String = txtTelCel.Text
                    Dim CPF As String = txtCPF.Text
                    If TelRes = "(  )    -" Then
                        TelRes = ""
                    End If
                    If TelCel = "(  )    -" Then
                        TelCel = ""
                    End If
                    If CPF = "   .   .   -" Then
                        CPF = ""
                    End If
                    usu.SelecionaPorCodigo(Int32.Parse(lblCodigo.Text))
                    usu.Nome = txtNome.Text
                    usu.Endereco = txtEndereco.Text
                    usu.Cargo = txtCargo.Text
                    usu.Email = txtEmail.Text
                    usu.TelResidencial = TelRes
                    usu.TelCelular = TelCel
                    usu.CPF = CPF
                    usu.RG = txtRG.Text
                    usu.Login = txtLogin.Text
                    usu.Senha = txtSenha.Text
                    Dim linha As DataRowView = dpdPerfil.SelectedItem
                    usu.Perfil = linha.Item(0)
                    If usu.Alterar() Then
                        MsgBox("Usuário alterado com sucesso!")
                    End If
                    Cancelar()
                Else
                    MsgBox("Este login já existe para um outro usuário, defina um diferente!")
                End If
            End If
        Else
            MsgBox("Por favor preencha os campos marcados corretamente!")
        End If
    End Sub
    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        If lblCodigo.Text.Trim() <> "" Then
            If MsgBox("Tente certeza que fazer esta exclusão?", MsgBoxStyle.OkCancel, "Confirmação") = MsgBoxResult.Ok Then
                Dim usu As New Usuario()
                usu.SelecionaPorCodigo(Int32.Parse(lblCodigo.Text))
                Dim msg As String = usu.Excluir()
                MsgBox(msg)
                Cancelar()
            End If
        End If
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Cancelar()
    End Sub
    Private Sub dpdPerfil_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dpdPerfil.SelectedIndexChanged
        SetaToolTip()
    End Sub

    Private Sub lkImprimir_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkImprimir.LinkClicked
        Dim rel As New Relatorio
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelUsuario()
        frmRelatorios.Show()
    End Sub

    Private Sub dpdPerfil_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dpdPerfil.KeyPress
        e.Handled = True
    End Sub
End Class