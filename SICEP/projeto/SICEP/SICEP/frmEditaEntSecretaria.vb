Imports CamadaDeNegocios

Public Class frmEditaEntSecretaria
#Region "Funcoes Privadas"
    Private Sub PreencheGrid(ByVal med As String, ByVal val As String, ByVal DI As String, ByVal DF As String)
        Dim func As New EstoqueSecretaria
        If chkMateriais.Checked = True And chkMedicamentos.Checked = True Then
            grdEditarEntradas.DataSource = func.EntradasEmEstoque(med, val, DI, DF, "")
        ElseIf chkMateriais.Checked = False And chkMedicamentos.Checked = True Then
            grdEditarEntradas.DataSource = func.EntradasEmEstoque(med, val, DI, DF, "0")
        ElseIf chkMateriais.Checked = True And chkMedicamentos.Checked = False Then
            grdEditarEntradas.DataSource = func.EntradasEmEstoque(med, val, DI, DF, "1")
        Else
            grdEditarEntradas.DataSource = func.EntradasEmEstoque(med, val, DI, DF, "")
        End If
    End Sub
    Private Sub HabilitaFiltroDatas(ByVal checar As Boolean)
        If checar = True Then
            txtDataInicial.Enabled = True
            txtDataFinal.Enabled = True
        Else
            txtDataInicial.Enabled = False
            txtDataFinal.Enabled = False
        End If
        txtDataInicial.Value = "01/01/2000"
        txtDataFinal.Value = "12/12/2010"
    End Sub
    Private Sub Pesquisar()
        lblInfoData.Visible = False
        If chkPesquisaPorData.Checked = True Then
            If txtDataInicial.Value > txtDataFinal.Value Then
                lblInfoData.Visible = True
            End If
            PreencheGrid(txtPesqMedicamento.Text, txtPesqValidade.Text, txtDataInicial.Text, txtDataFinal.Text)
        Else
            PreencheGrid(txtPesqMedicamento.Text, txtPesqValidade.Text, "", "")
        End If
    End Sub
    Private Sub PreencheDropMedicamentos()
        Dim med As New Medicamento
        Dim tbl As New dtsBD_SICEP.tb_medicamentoDataTable
        tbl = med.Seleciona("", "")
        dpdMedicamentos.DataSource = tbl
        dpdMedicamentos.DisplayMember = "nome_medicamento"
        dpdMedicamentos.ValueMember = "cod_medicamento"
    End Sub
    Private Sub PreencheFormulario()
        Try
            If grdEditarEntradas.Rows.Count > 0 Then
                Dim est As New EstoqueSecretaria
                Dim codigo As Integer = Int32.Parse(grdEditarEntradas.SelectedCells.Item(0).Value)
                est.EntradasEmEstoque(codigo)
                lblCodEntrada.Text = est.Codigo
                dpdMedicamentos.SelectedValue = est.CodigoMedicamento
                txtValidade.Text = est.Validade
                txtQuantidade.Text = est.Quantidade.ToString()
                txtQuantidade.SelectAll()
            End If
        Catch ex As Exception
            If Not ex.Message.Contains("Index was out of range. Must be non-negative and") Then
                Throw ex
            End If
        End Try
    End Sub
    Private Sub AlterarEntrada()
        Dim est As New EstoqueSecretaria
        Dim linha As DataRowView = dpdMedicamentos.SelectedItem
        Dim codMedicamento As Integer = linha.Item(0)
        Dim msg As String = est.AlteraEntrada(Int32.Parse(lblCodEntrada.Text), codMedicamento, txtValidade.Text, txtQuantidade.Text)
        If msg.Trim() <> "" Then
            MsgBox(msg)
            If Not msg.Contains("Impossível!") Then
                LimpaTudo()
            End If
        End If
    End Sub
    Private Sub ExcluirEntrada()
        Dim est As New EstoqueSecretaria
        Dim linha As DataRowView = dpdMedicamentos.SelectedItem
        Dim codMedicamento As Integer = linha.Item(0)
        Dim msg As String = est.ExcluirEntrada(Int32.Parse(lblCodEntrada.Text), codMedicamento, txtValidade.Text)
        If msg.Trim() <> "" Then
            MsgBox(msg)
            If Not msg.Contains("Impossível!") Then
                LimpaTudo()
            End If
        End If
    End Sub
    Private Sub LimpaTudo()
        PreencheGrid("", "", "", "")
        dpdMedicamentos.Refresh()
        HabilitaFiltroDatas(False)
        txtPesqMedicamento.Text = ""
        txtPesqValidade.Text = ""
        txtQuantidade.Text = ""
        lblCodEntrada.Text = ""
    End Sub
#End Region
    Private Sub frmEditaEntSecretaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkMateriais.Checked = True
        chkMedicamentos.Checked = True
        chkPesquisaPorData.Checked = False
        LimpaTudo()
        PreencheDropMedicamentos()
    End Sub
    Private Sub chkPesquisaPorData_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPesquisaPorData.CheckedChanged
        HabilitaFiltroDatas(chkPesquisaPorData.Checked)
        Pesquisar()
    End Sub
    Private Sub txtPesqMedicamento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesqMedicamento.TextChanged
        Pesquisar()
    End Sub
    Private Sub txtPesqValidade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesqValidade.TextChanged
        Pesquisar()
    End Sub
    Private Sub txtDataInicial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDataInicial.ValueChanged
        Pesquisar()
    End Sub
    Private Sub txtDataFinal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDataFinal.ValueChanged
        Pesquisar()
    End Sub
    Private Sub grdEditarEntradas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdEditarEntradas.CellContentClick
        PreencheFormulario()
    End Sub
    Private Sub grdEditarEntradas_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdEditarEntradas.CurrentCellChanged
        PreencheFormulario()
    End Sub
    Private Sub txtQuantidade_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantidade.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub cmdAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlterar.Click
        If (txtQuantidade.Text.Trim()) <> "" And (lblCodEntrada.Text.Trim() <> "") Then
            If (Int32.Parse(txtQuantidade.Text.Trim()) > 0) Then
                If MsgBox("Você tem certeza que deseja alterar estes dados?", MsgBoxStyle.OkCancel, "Confirmação") = MsgBoxResult.Ok Then
                    AlterarEntrada()
                End If
            Else
                MsgBox("A quantidade deve ser maior do zero!")
            End If
        Else
            MsgBox("Por favor defina a quantidade ou" + vbCr + "selecione algo na relação de entradas!")
        End If
    End Sub
    Private Sub cmdExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        If (lblCodEntrada.Text.Trim() <> "") Then
            If MsgBox("Você tem certeza que deseja excluir esta entrada?", MsgBoxStyle.OkCancel, "Confirmação") = MsgBoxResult.Ok Then
                ExcluirEntrada()
            End If
        Else
            MsgBox("Selecione algo na relação de entradas!")
        End If
    End Sub
    Private Sub grdEditarEntradas_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdEditarEntradas.SelectionChanged
        PreencheFormulario()
    End Sub
    Private Sub lkImprimir_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkImprimir.LinkClicked
        Dim rel As New Relatorio
        frmRelatorios.crvVisualizador.ReportSource = rel.CriarRelEntradasSecretaria(grdEditarEntradas.DataSource)
        frmRelatorios.Show()
    End Sub

    Private Sub chkMedicamentos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMedicamentos.CheckedChanged
        Pesquisar()
    End Sub

    Private Sub chkMateriais_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMateriais.CheckedChanged
        Pesquisar()
    End Sub
End Class