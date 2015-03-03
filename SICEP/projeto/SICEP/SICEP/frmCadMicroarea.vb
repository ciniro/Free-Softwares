Imports CamadaDeNegocios

Public Class frmCadMicroarea
#Region "Funcoes Privadas"
    Private Sub LimpaTudo()
        lblCodigo.Text = String.Empty
        lblDataCadastramento.Text = String.Empty
        txtObservacoes.Text = String.Empty
        txtAgente.Text = String.Empty
        lblValAgente.Visible = False
    End Sub
    Private Sub PreencheGridPesquisa(ByVal valor As String)
        Dim micro As New Microarea
        grdMicroarea.DataSource = micro.SelecionaPorValor(valor)
    End Sub
    Private Sub DefineBotoes(ByVal Novo As Boolean, ByVal Salvar As Boolean, ByVal Alterar As Boolean, ByVal Excluir As Boolean, ByVal Cancelar As Boolean)
        cmdNovo.Visible = Novo
        cmdSalvar.Visible = Salvar
        cmdAlterar.Visible = Alterar
        cmdExcluir.Visible = Excluir
        cmdCancelar.Visible = Cancelar
    End Sub
    Public Sub PreencheFormulario(ByVal codigo As Integer)
        Dim micro As New Microarea
        micro.SelecionaPorValor(codigo)
        lblCodigo.Text = micro.Codigo.ToString()
        lblDataCadastramento.Text = micro.DataCadastramento.ToString()
        txtAgente.Text = micro.Agente
        txtObservacoes.Text = micro.Observacoes
    End Sub
    Public Function ValidaDados() As Boolean
        Dim ERRO As Boolean = False

        lblValAgente.Visible = False
        If txtAgente.Text.Equals("") Then
            ERRO = True
            lblValAgente.Visible = True
        End If
        Return ERRO
    End Function
    Public Sub Cancelar()
        DefineBotoes(True, False, False, False, False)
        pnlPesquisa.Enabled = True
        LimpaTudo()
        PreencheGridPesquisa("")
    End Sub
#End Region

    Private Sub frmCadMicroarea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LimpaTudo()
        grdMicroarea.DataSource = New dtsBD_SICEP.tb_microareaDataTable()
        PreencheGridPesquisa("")
        DefineBotoes(True, False, False, False, False)
        pnlPesquisa.Enabled = True
    End Sub
    Private Sub txtPesquisa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisa.TextChanged
        If IsNumeric(txtPesquisa.Text) Then
            lblPesquisando.Text = "Pesquisando por código..."
        Else
            lblPesquisando.Text = "Pesquisando por agente..."
        End If
        PreencheGridPesquisa(txtPesquisa.Text)
    End Sub
    Private Sub grdMicroarea_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdMicroarea.CellContentClick
        Dim codigo As Integer = Int32.Parse(grdMicroarea.SelectedCells(0).Value)
        PreencheFormulario(codigo)
        DefineBotoes(False, False, True, True, True)
    End Sub
    Private Sub cmdNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNovo.Click
        DefineBotoes(False, True, False, False, True)
        pnlPesquisa.Enabled = False
    End Sub
    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
        If Not ValidaDados() Then
            Dim micro As New Microarea
            micro.Agente = txtAgente.Text
            micro.Observacoes = txtObservacoes.Text
            If micro.Salvar() Then
                MsgBox("Micro-Área salva com sucesso!")
            End If
            Cancelar()
        Else
            MsgBox("Preencha os campos marcados corretamente!")
        End If
    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        If Not ValidaDados() Then
            If MsgBox("Tente certeza que fazer esta alteração?", MsgBoxStyle.OkCancel, "Confirmação") = MsgBoxResult.Ok Then
                Dim micro As New Microarea
                micro.SelecionaPorValor(Int32.Parse(lblCodigo.Text))
                micro.Agente = txtAgente.Text
                micro.Observacoes = txtObservacoes.Text
                If micro.Alterar() Then
                    MsgBox("Micro-Área alterada com sucesso!")
                End If
                Cancelar()
            End If
        Else
            MsgBox("Preencha os campos marcados corretamente!")
        End If
    End Sub
    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        If (lblCodigo.Text.Trim <> "") Then
            If MsgBox("Tente certeza que fazer esta exclusão?", MsgBoxStyle.OkCancel, "Confirmação") = MsgBoxResult.Ok Then
                Dim micro As New Microarea
                micro.SelecionaPorValor(Int32.Parse(lblCodigo.Text))
                Dim msg As String = micro.Excluir()
                MsgBox(msg)
                Cancelar()
            End If
        End If
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Cancelar()
    End Sub
    Private Sub lkImprimir_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkImprimir.LinkClicked
        Dim rel As New Relatorio
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelMicroArea()
        frmRelatorios.Show()
    End Sub
End Class