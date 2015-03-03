Imports CamadaDeNegocios

Public Class frmCadMaterial
#Region "funcoes privadas"
    Private Sub LimpaTudo()
        txtNome.Text = String.Empty
        txtInfo.Text = String.Empty
        lblValNome.Visible = False
        lblCodigo.Text = ""
        lblDataCadastramento.Text = ""
    End Sub
    Private Sub PreencheGridPesquisa(ByVal nome As String)
        Dim med As New Medicamento
        grdMedicamento.DataSource = med.Seleciona(nome, "1")
    End Sub
    Private Sub DefineBotoes(ByVal Novo As Boolean, ByVal Salvar As Boolean, ByVal Alterar As Boolean, ByVal Excluir As Boolean, ByVal Cancelar As Boolean)
        cmdNovo.Visible = Novo
        cmdSalvar.Visible = Salvar
        cmdAlterar.Visible = Alterar
        cmdExcluir.Visible = Excluir
        cmdCancelar.Visible = Cancelar
    End Sub
    Private Sub PreencheFormulario(ByVal codigo As Integer)
        Dim med As New Medicamento
        med.Seleciona(codigo)
        lblCodigo.Text = med.Codigo
        lblDataCadastramento.Text = med.DataCadastro
        txtNome.Text = med.Nome
        txtInfo.Text = med.Informacoes
    End Sub
    Private Function ValidaDados() As Boolean
        Dim ERRO As Boolean = False

        lblValNome.Visible = False
        If txtNome.Text.Equals("") Then
            ERRO = True
            lblValNome.Visible = True
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
    Private Sub frmCadMedicamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LimpaTudo()
        grdMedicamento.DataSource = New dtsBD_SICEP.tb_medicamentoDataTable()
        PreencheGridPesquisa("")
        DefineBotoes(True, False, False, False, False)
        pnlPesquisa.Enabled = True
    End Sub
    Private Sub txtPesquisa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisa.TextChanged
        PreencheGridPesquisa(txtPesquisa.Text)
    End Sub
    Private Sub grdMedicamento_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdMedicamento.CellContentClick
        Dim codigo As Integer = grdMedicamento.SelectedCells(0).Value
        PreencheFormulario(codigo)
        DefineBotoes(False, False, True, True, True)
    End Sub
    Private Sub cmdNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNovo.Click
        DefineBotoes(False, True, False, False, True)
        pnlPesquisa.Enabled = False
    End Sub
    Private Sub cmdSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalvar.Click
        If Not ValidaDados() Then
            Dim med As New Medicamento
            med.Nome = txtNome.Text
            med.Composicao = ""
            med.Informacoes = txtInfo.Text
            If med.SalvarMaterial() Then
                MsgBox("Material de Consumo salvo com sucesso!")
            End If
            Cancelar()
        Else
            MsgBox("Preencha os campos marcados corretamente!")
        End If
    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        If Not ValidaDados() Then
            If MsgBox("Tente certeza que fazer esta alteração?", MsgBoxStyle.OkCancel, "Confirmação") = MsgBoxResult.Ok Then
                Dim med As New Medicamento
                med.Seleciona(Int32.Parse(lblCodigo.Text))
                med.Nome = txtNome.Text
                med.Composicao = ""
                med.Informacoes = txtInfo.Text
                If med.Alterar() Then
                    MsgBox("Material de Consumo alterado com sucesso!")
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
                Dim med As New Medicamento
                med.Seleciona(Int32.Parse(lblCodigo.Text))
                Dim msg As String = med.Excluir()
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
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelMaterial()
        frmRelatorios.Show()
    End Sub
End Class