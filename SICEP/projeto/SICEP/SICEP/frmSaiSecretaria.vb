Imports CamadaDeNegocios

Public Class frmSaiSecretaria
#Region "Funções Privadas"
    Private Sub Pesquisando(ByVal medicamento As String, ByVal validade As String)
        If medicamento.Trim().Equals("") And validade.Trim().Equals("") Then
            lblPesquisa.Text = "Você não está usando a pesquisa..."
        ElseIf medicamento.Trim() <> "" And validade.Trim().Equals("") Then
            lblPesquisa.Text = "Filtrando por item..."
        ElseIf medicamento.Trim().Equals("") And validade.Trim() <> "" Then
            lblPesquisa.Text = "Filtrando por validade..."
        Else
            lblPesquisa.Text = "Filtrando por item e validade..."
        End If
        Dim func As New EstoqueSecretaria
        If chkMateriais.Checked = True And chkMedicamentos.Checked = True Then
            grdEstoqueSecretaria.DataSource = func.Estoque(medicamento, validade, "")
        ElseIf chkMateriais.Checked = False And chkMedicamentos.Checked = True Then
            grdEstoqueSecretaria.DataSource = func.Estoque(medicamento, validade, "0")
        ElseIf chkMateriais.Checked = True And chkMedicamentos.Checked = False Then
            grdEstoqueSecretaria.DataSource = func.Estoque(medicamento, validade, "1")
        Else
            grdEstoqueSecretaria.DataSource = func.Estoque(medicamento, validade, "")
        End If
    End Sub
    Private Sub SetaToolTip(ByVal codigo As Integer)
        Dim med As New Medicamento
        med.Seleciona(codigo)
        Dim texto As String = "NOME: " + med.Nome + vbCr + "COMPOSIÇÃO: " + med.Composicao
        If med.Informacoes.ToString().Trim() <> "" Then
            texto = texto + vbCr + "OBSERVAÇÕES:" + med.Informacoes
        End If
        ToolTip.SetToolTip(imgInformacoes, texto)
    End Sub
    Private Sub BuscaDatas(ByVal codigo As Integer, ByVal validade As String)
        Dim sai As New SaidasSecretaria
        If sai.BuscaUltimaRetirada(codigo, validade) Then
            lblUltimaRetirada.Text = sai.DataDaSaida + " - " + sai.BuscaRegiaoPorCodigo(sai.CodigoRegiao)
            Dim ultima, atual As Date
            ultima = Date.Parse(sai.DataDaSaida)
            atual = Date.Today
            Dim dias As TimeSpan = atual - ultima
            Try
                lblDiferenca.Text = dias.Days.ToString()
            Catch
                lblDiferenca.Text = "0"
            End Try
        Else
        lblUltimaRetirada.Text = "Nenhuma retirada efetuada!"
        lblDiferenca.Text = "Nenhuma retirada efetuada!"
        End If
    End Sub
    Private Sub CalculaDiasPorRegiao(ByVal codMedicamento As Integer, ByVal codRegiao As Integer, ByVal validade As String)
        Dim sai As New SaidasSecretaria
        Dim texto As String = ""
        If sai.BuscaUltimaRetirada(codMedicamento, codRegiao, validade) Then
            Dim ultima, atual As Date
            ultima = Date.Parse(sai.DataDaSaida)
            atual = Date.Today
            Dim dias As TimeSpan = atual - ultima
            Try
                Dim tempo As String = dias.Days.ToString()
                texto = "ÚLTIMA RETIRADA PARA ESTA REGIÃO: " + sai.DataDaSaida + vbCrLf + "TOTAL DE DIAS DESDE A ÚLTIMA RETIRADA: " + tempo.ToString()
            Catch
                texto = "Foi feita uma retirada a menos de 24 horas." + vbCrLf + "DATA:" + sai.DataDaSaida
            End Try
        Else
        texto = "Nenhuma retirada para esta região!"
        End If
        ToolTip.SetToolTip(imgInformaçõesRegiao, texto)
    End Sub
    Private Sub PreencheFormulario()
        Try
            If grdEstoqueSecretaria.Rows.Count > 0 Then
                lblNomeMedicamento.Text = grdEstoqueSecretaria.SelectedCells(1).Value.ToString()
                lblValMedicamento.Text = grdEstoqueSecretaria.SelectedCells(2).Value.ToString()
                lblQuantMedicamento.Text = grdEstoqueSecretaria.SelectedCells(3).Value.ToString()
                Dim codMedicamento As Integer = Int32.Parse(grdEstoqueSecretaria.SelectedCells(0).Value)
                lblCodMedicamento.Text = codMedicamento.ToString()
                SetaToolTip(codMedicamento)
                BuscaDatas(codMedicamento, lblValMedicamento.Text)
                PreencheLabelDropRegiao()
            End If
        Catch ex As Exception
            If Not ex.Message.Contains("Index was out of range. Must be non-negative and") And Not ex.Message.Contains("Object reference not set to an instance of an object") Then
                Throw ex
            End If
        End Try
    End Sub
    Private Sub PreencheDropRegiao()
        Dim sai As New SaidasSecretaria
        Dim dts As New dtsBD_SICEP.tb_regiaoDataTable
        dts = sai.BuscaRegioes()
        dpdRegiao.DataSource = dts
        dpdRegiao.DisplayMember = "nome_regiao"
        dpdRegiao.ValueMember = "cod_regiao"
    End Sub
    Private Sub LimpaTudo()
        lblCodMedicamento.Text = ""
        txtPesqMedicamento.Text = ""
        txtPesqValidade.Text = ""
        lblNomeMedicamento.Text = "Não Informado!"
        lblValMedicamento.Text = "Não Informado!"
        lblQuantMedicamento.Text = "Não Informado!"
        lblUltimaRetirada.Text = "Não Informado!"
        lblDiferenca.Text = "Não Informado!"
        txtQuantidade.Text = ""
        ToolTip.SetToolTip(imgInformacoes, "")
        ToolTip.SetToolTip(imgInformaçõesRegiao, "")
    End Sub
    Private Sub PreencheLabelDropRegiao()
        If lblCodMedicamento.Text.Trim() <> "" Then
            Dim linha As DataRowView = dpdRegiao.SelectedItem
            Dim codigo As Integer = linha.Item(0)
            CalculaDiasPorRegiao(Int32.Parse(lblCodMedicamento.Text), codigo, lblValMedicamento.Text)
        End If
    End Sub
    Private Function Confirmacoes() As Boolean
        Dim erro As Boolean = False
        If lblCodMedicamento.Text.Trim() <> "" Then
            If txtQuantidade.Text.Trim() <> "0" Then
                If txtQuantidade.Text.Trim() <> "" Then
                    If MsgBox("Você tem certeza que deseja efetuar esta saída?", MsgBoxStyle.OkCancel, "Confirmação") = MsgBoxResult.Ok Then
                        erro = True
                    End If
                    Return erro
                Else
                    MsgBox("Digite uma quantidade válida!")
                    Return erro
                End If
            Else
                MsgBox("Digite um valor maior que zero!")
                Return erro
            End If
        Else
            MsgBox("Selecione algum item no estoque para efetuar a retirada!")
            Return erro
        End If
    End Function
#End Region

    Private Sub frmSaiSecretaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkMateriais.Checked = True
        chkMedicamentos.Checked = True
        Pesquisando("", "")
        lblUsuarioCadastrante.Text = UsuarioLogado.Nome
        txtDataCadastro.MaxDate = Date.Now.Date
        PreencheDropRegiao()
        LimpaTudo()
    End Sub
    Private Sub txtPesqMedicamento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesqMedicamento.TextChanged
        Pesquisando(txtPesqMedicamento.Text, txtPesqValidade.Text)
    End Sub
    Private Sub txtPesqValidade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesqValidade.TextChanged
        Pesquisando(txtPesqMedicamento.Text, txtPesqValidade.Text)
    End Sub
    Private Sub lkImprimir_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkImprimir.LinkClicked
        Dim rel As New Relatorio
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelEstoqueSecretaria(grdEstoqueSecretaria.DataSource)
        frmRelatorios.Show()
    End Sub
    Private Sub lkVerEstoque_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkVerEstoque.LinkClicked
        frmEstSecretaria.ShowDialog()
    End Sub
    Private Sub grdEstoqueSecretaria_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdEstoqueSecretaria.CellContentClick
        PreencheFormulario()
    End Sub
    Private Sub grdEstoqueSecretaria_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdEstoqueSecretaria.CurrentCellChanged
        PreencheFormulario()
    End Sub
    Private Sub dpdRegiao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dpdRegiao.SelectedIndexChanged
        PreencheLabelDropRegiao()
    End Sub
    Private Sub txtQuantidade_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantidade.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub cmdEfetuarSaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEfetuarSaida.Click
        If Confirmacoes() Then
            Dim sai As New SaidasSecretaria
            sai.CodigoMedicamento = Int32.Parse(lblCodMedicamento.Text)
            sai.ValidadeMedicamento = lblValMedicamento.Text
            sai.QuantidadeRetirada = Int32.Parse(txtQuantidade.Text)
            sai.CodigoUsuario = UsuarioLogado.Codigo

            Dim linha As DataRowView = dpdRegiao.SelectedItem
            sai.CodigoRegiao = linha.Item(0)
            Dim msg As String = sai.InsereSaida()
            MsgBox(msg)
            If Not msg.Contains("Existem menos itens no estoque") Then
                Dim codigo As Integer = Int32.Parse(lblCodMedicamento.Text)
                Dim linhasA As Integer = grdEstoqueSecretaria.Rows.Count
                Dim rowIndex As Integer = grdEstoqueSecretaria.SelectedCells.Item(0).RowIndex

                LimpaTudo()
                Pesquisando("", "")

                Dim linhasD As Integer = grdEstoqueSecretaria.Rows.Count
                If linhasA = linhasD Then
                    grdEstoqueSecretaria.Select()
                    grdEstoqueSecretaria.Item(1, rowIndex).Selected = True
                End If
            End If
        End If
    End Sub
    Private Sub grdEstoqueSecretaria_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdEstoqueSecretaria.SelectionChanged
        PreencheFormulario()
    End Sub
    Private Sub cmdEditarSaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditarSaida.Click
        frmEditaSaiSecretaria.ShowDialog()
    End Sub

    Private Sub dpdRegiao_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dpdRegiao.KeyPress
        e.Handled = True
    End Sub

    Private Sub chkMedicamentos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMedicamentos.CheckedChanged
        Pesquisando(txtPesqMedicamento.Text, txtPesqValidade.Text)
    End Sub

    Private Sub chkMateriais_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMateriais.CheckedChanged
        Pesquisando(txtPesqMedicamento.Text, txtPesqValidade.Text)
    End Sub
End Class