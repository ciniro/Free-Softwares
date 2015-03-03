Imports CamadaDeNegocios
Imports System.Data

Public Class frmEntPoliclinica
#Region "Funcoes Privadas"
    Public Sub PreencheListBox()
        Dim med As New Medicamento
        If chkMateriais.Checked = True And chkMedicamentos.Checked = True Then
            ltbMedicamentos.DataSource = med.Seleciona("", "")
        ElseIf chkMateriais.Checked = False And chkMedicamentos.Checked = True Then
            ltbMedicamentos.DataSource = med.Seleciona("", "0")
        ElseIf chkMateriais.Checked = True And chkMedicamentos.Checked = False Then
            ltbMedicamentos.DataSource = med.Seleciona("", "1")
        Else
            ltbMedicamentos.DataSource = med.Seleciona("", "")
        End If
        ltbMedicamentos.DisplayMember = "nome_medicamento"
        ltbMedicamentos.ValueMember = "cod_medicamento"
    End Sub
    Private Sub SetaToolTip()
        Dim med As New Medicamento
        Dim linha As DataRowView = ltbMedicamentos.SelectedItem
        Dim codigo As Integer = linha.Item(0)
        med.Seleciona(codigo)
        Dim texto As String = "NOME: " + med.Nome + vbCr + "COMPOSIÇÃO: " + med.Composicao
        If med.Informacoes.ToString().Trim() <> "" Then
            texto = texto + vbCr + "OBSERVAÇÕES:" + med.Informacoes
        End If
        ToolTip.SetToolTip(imgInformacoes, texto)
    End Sub
    Private Function ValidaDados() As Boolean
        Dim erro As Boolean = False
        lblValQuantidade.Visible = False
        lblValMedicamentos.Visible = False
        If (txtQuantidade.Text.Equals("")) Then
            lblValQuantidade.Visible = True
            erro = True
        Else
            If (Int32.Parse(txtQuantidade.Text.Trim()) <= 0) Then
                lblValQuantidade.Visible = True
                erro = True
            End If
        End If
        If (ltbMedicamentos.SelectedIndex = -1) Then
            lblValMedicamentos.Visible = True
            erro = True
        End If
        Return erro
    End Function
    Private Sub LimpaTudo()
        grdMedicamentos.Rows.Clear()
        lblValQuantidade.Visible = False
        lblValMedicamentos.Visible = False
        txtQuantidade.Text = ""
    End Sub
    Private Sub Anexar()
        Dim linha As DataRowView = ltbMedicamentos.SelectedItem
        Dim codMedicamento As Integer = linha.Item(0)
        Dim nomeMedicamento As String = linha.Item(1)
        Dim Validade As String = txtValidade.Text
        Dim Quantidade As Integer = Int32.Parse(txtQuantidade.Text)
        grdMedicamentos.Rows.Add(codMedicamento, nomeMedicamento, Quantidade, Validade)
    End Sub
    Private Sub Desanexar()
        If grdMedicamentos.Rows.Count > 0 Then
            grdMedicamentos.Rows.RemoveAt(grdMedicamentos.SelectedCells.Item(0).RowIndex)
        End If
    End Sub
    Private Sub EfetuarEntradas()
        Dim func As New EstoquePoliclinica

        func.CodigoUsuario = UsuarioLogado.Codigo
        Dim erro As Boolean = False

        Dim linha As DataGridViewRow
        For Each linha In grdMedicamentos.Rows()
            func.CodigoMedicamento = linha.Cells(0).Value
            func.Validade = linha.Cells(3).Value
            func.Quantidade = linha.Cells(2).Value
            If Not func.InsereEntrada() Then
                erro = True
            End If
        Next

        If erro = True Then
            MsgBox("Algumas de suas entradas não puderam ser efetuadas!")
        Else
            MsgBox("As entradas inseridas em sua nota foram salvas com sucesso!")
        End If

    End Sub
#End Region
    Private Sub frmEntPoliclinica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkMateriais.Checked = True
        chkMedicamentos.Checked = True
        lblUsuarioCadastrante.Text = UsuarioLogado.Nome
        txtDataCadastro.MaxDate = Date.Now.Date
        LimpaTudo()
        PreencheListBox()
    End Sub
    Private Sub cmdAnexar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnexar.Click
        If Not ValidaDados() Then
            Anexar()
            lblValQuantidade.Visible = False
            lblValMedicamentos.Visible = False
            txtQuantidade.Text = ""
            ltbMedicamentos.Focus()
            ltbMedicamentos.SelectedIndex = 0
        Else
            MsgBox("Preencha corretamente os campos marcados!")
        End If
    End Sub
    Private Sub txtQuantidade_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantidade.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub ltbMedicamentos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltbMedicamentos.SelectedIndexChanged
        SetaToolTip()
    End Sub
    Private Sub cmdDesanexar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDesanexar.Click
        Desanexar()
    End Sub
    Private Sub cmdLimparNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimparNota.Click
        If MsgBox("Você tem certeza que deseja limpar estes dados?", MsgBoxStyle.OkCancel, "Confirmação") = MsgBoxResult.Ok Then
            LimpaTudo()
        End If
    End Sub
    Private Sub cmdEfetuarEntradas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEfetuarEntradas.Click
        If grdMedicamentos.Rows.Count > 0 Then
            If MsgBox("Você tem certeza que deseja salvar estas entradas?", MsgBoxStyle.OkCancel, "Confirmação") = MsgBoxResult.Ok Then
                EfetuarEntradas()
                LimpaTudo()
            End If
        Else
            MsgBox("Não existem medicamentos anexados a nota para serem adicionados ao estoque!")
        End If
    End Sub
    Private Sub lkVerEstoque_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkVerEstoque.LinkClicked
        frmEstPoliclinica.ShowDialog()
    End Sub
    Private Sub cmdEditarEntradas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditarEntradas.Click
        frmEditaEntPoliclinica.ShowDialog()
    End Sub

    Private Sub chkMedicamentos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMedicamentos.CheckedChanged
        PreencheListBox()
    End Sub

    Private Sub chkMateriais_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMateriais.CheckedChanged
        PreencheListBox()
    End Sub
End Class