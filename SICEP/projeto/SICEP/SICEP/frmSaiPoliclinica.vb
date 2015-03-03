Imports CamadaDeNegocios

Public Class frmSaiPoliclinica
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
        Dim func As New EstoquePoliclinica
        If chkMateriais.Checked = True And chkMedicamentos.Checked = True Then
            grdEstoquePoliclinica.DataSource = func.Estoque(medicamento, validade, "")
        ElseIf chkMateriais.Checked = False And chkMedicamentos.Checked = True Then
            grdEstoquePoliclinica.DataSource = func.Estoque(medicamento, validade, "0")
        ElseIf chkMateriais.Checked = True And chkMedicamentos.Checked = False Then
            grdEstoquePoliclinica.DataSource = func.Estoque(medicamento, validade, "1")
        Else
            grdEstoquePoliclinica.DataSource = func.Estoque(medicamento, validade, "")
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
        Dim sai As New SaidasPoliclinica
        If sai.BuscaUltimaRetirada(codigo, validade) Then
            lblUltimaRetirada.Text = sai.DataSaida + " - " + sai.BuscaPacientePorCodigo(sai.CodigoPaciente)
            Dim ultima, atual As Date
            ultima = Date.Parse(sai.DataSaida)
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
    Private Sub CalculaDiasPorPaciente(ByVal codMedicamento As Integer, ByVal codPaciente As Integer, ByVal validade As String)
        Dim sai As New SaidasPoliclinica
        Dim texto As String = ""
        If sai.BuscaUltimaRetirada(codMedicamento, codPaciente, validade) Then
            Dim ultima, atual As Date
            ultima = Date.Parse(sai.DataSaida)
            atual = Date.Today
            Dim dias As TimeSpan = atual - ultima
            Try
                Dim tempo As String = dias.Days.ToString()
                texto = "ÚLTIMA RETIRADA PARA ESTE PACIENTE: " + sai.DataSaida + vbCrLf + "TOTAL DE DIAS DESDE A ÚLTIMA RETIRADA: " + tempo.ToString()
            Catch
                texto = "Foi feita uma retirada a menos de 24 horas." + vbCrLf + "DATA:" + sai.DataSaida
            End Try
        Else
        texto = "Nenhuma retirada para este paciente!"
        End If
        ToolTip.SetToolTip(imgInformaçõesPaciente, texto)
    End Sub
    Private Sub PreencheFormulario()
        Try
            If grdEstoquePoliclinica.Rows.Count > 0 Then
                lblNomeMedicamento.Text = grdEstoquePoliclinica.SelectedCells(1).Value.ToString()
                lblValMedicamento.Text = grdEstoquePoliclinica.SelectedCells(2).Value.ToString()
                lblQuantMedicamento.Text = grdEstoquePoliclinica.SelectedCells(3).Value.ToString()
                Dim codMedicamento As Integer = Int32.Parse(grdEstoquePoliclinica.SelectedCells(0).Value)
                lblCodMedicamento.Text = codMedicamento.ToString()
                SetaToolTip(codMedicamento)
                BuscaDatas(codMedicamento, lblValMedicamento.Text)
                PreencheLabelDropPaciente()
            End If
        Catch ex As Exception
            If Not ex.Message.Contains("Index was out of range. Must be non-negative and") And Not ex.Message.Contains("Object reference not set to an instance of an object") Then
                Throw ex
            End If
        End Try
    End Sub
    Private Sub PreencheDropPaciente(ByVal nome As String)
        Dim pac As New Paciente
        Dim dts As New dtsBD_SICEP.tb_pacienteDataTable
        dts = pac.SelecionaPorNome(nome)
        If dts.Rows.Count > 0 Then
            dpdPaciente.DataSource = dts
            dpdPaciente.DisplayMember = "nome_paciente"
            dpdPaciente.ValueMember = "cod_paciente"
        End If
    End Sub

    Private Sub LimpaTudo()
        txtPesqNome.Text = ""
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
        ToolTip.SetToolTip(imgInformaçõesPaciente, "")
    End Sub
    Private Sub PreencheLabelDropPaciente()
        If lblCodMedicamento.Text.Trim() <> "" Then
            Dim linha As DataRowView = dpdPaciente.SelectedItem
            Dim codigo As Integer = linha.Item(0)
            CalculaDiasPorPaciente(Int32.Parse(lblCodMedicamento.Text), codigo, lblValMedicamento.Text)
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
    Private Sub frmSaiPoliclinica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Pesquisando("", "")
        lblUsuarioCadastrante.Text = UsuarioLogado.Nome
        txtDataCadastro.MaxDate = Date.Now.Date
        PreencheDropPaciente("")
        LimpaTudo()
    End Sub
    Private Sub txtPesqMedicamento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesqMedicamento.TextChanged
        Pesquisando(txtPesqMedicamento.Text, txtPesqValidade.Text)
    End Sub
    Private Sub txtPesqValidade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesqValidade.TextChanged
        Pesquisando(txtPesqMedicamento.Text, txtPesqValidade.Text)
    End Sub
    Private Sub lkVerEstoque_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkVerEstoque.LinkClicked
        frmEstPoliclinica.ShowDialog()
    End Sub
    Private Sub grdEstoqueSecretaria_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdEstoquePoliclinica.CellContentClick
        PreencheFormulario()
    End Sub
    Private Sub grdEstoqueSecretaria_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdEstoquePoliclinica.CurrentCellChanged
        PreencheFormulario()
    End Sub
    Private Sub dpdRegiao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dpdPaciente.SelectedIndexChanged
        PreencheLabelDropPaciente()
    End Sub
    Private Sub txtQuantidade_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantidade.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub cmdEfetuarSaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEfetuarSaida.Click
        If Confirmacoes() Then
            Dim sai As New SaidasPoliclinica
            sai.CodigoMedicamento = Int32.Parse(lblCodMedicamento.Text)
            sai.Validade = lblValMedicamento.Text
            sai.Quantidade = Int32.Parse(txtQuantidade.Text)
            sai.CodigoUsuario = UsuarioLogado.Codigo

            Dim linha As DataRowView = dpdPaciente.SelectedItem
            sai.CodigoPaciente = linha.Item(0)
            Dim msg As String = sai.InsereSaida()
            MsgBox(msg)
            If Not msg.Contains("Existem menos itens no estoque") Then
                Dim codigo As Integer = Int32.Parse(lblCodMedicamento.Text)
                Dim linhasA As Integer = grdEstoquePoliclinica.Rows.Count
                Dim rowIndex As Integer = grdEstoquePoliclinica.SelectedCells.Item(0).RowIndex

                LimpaTudo()
                Pesquisando("", "")

                Dim linhasD As Integer = grdEstoquePoliclinica.Rows.Count
                If linhasA = linhasD Then
                    grdEstoquePoliclinica.Select()
                    grdEstoquePoliclinica.Item(1, rowIndex).Selected = True
                End If
            End If
        End If
    End Sub
    Private Sub grdEstoqueSecretaria_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdEstoquePoliclinica.SelectionChanged
        PreencheFormulario()
    End Sub
    Private Sub cmdEditarSaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditarSaida.Click
        frmEditaSaiPoliclinica.ShowDialog()
    End Sub
    Private Sub dpdPaciente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dpdPaciente.KeyPress
        e.Handled = True
    End Sub
    Private Sub lkImprimir_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkImprimir.LinkClicked
        Dim rel As New Relatorio
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelEstoquePoliclinica(grdEstoquePoliclinica.DataSource)
        frmRelatorios.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesqNome.TextChanged
        PreencheDropPaciente(txtPesqNome.Text)
    End Sub

    Private Sub chkMateriais_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMateriais.CheckedChanged
        Pesquisando(txtPesqMedicamento.Text, txtPesqValidade.Text)
    End Sub

    Private Sub chkMedicamentos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMedicamentos.CheckedChanged
        Pesquisando(txtPesqMedicamento.Text, txtPesqValidade.Text)
    End Sub
End Class