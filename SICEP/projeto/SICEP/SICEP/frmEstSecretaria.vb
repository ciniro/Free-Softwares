Imports CamadaDeNegocios

Public Class frmEstSecretaria
    Private Sub Pesquisando(ByVal medicamento As String, ByVal validade As String)
        If medicamento.Trim().Equals("") And validade.Trim().Equals("") Then
            lblPesquisa.Text = "Você não está usando a pesquisa..."
        ElseIf medicamento.Trim() <> "" And validade.Trim().Equals("") Then
            lblPesquisa.Text = "Pesquisando atualmente por nome de item..."
        ElseIf medicamento.Trim().Equals("") And validade.Trim() <> "" Then
            lblPesquisa.Text = "Pesquisando atualmente por validade de item..."
        Else
            lblPesquisa.Text = "Pesquisando atualmente por nome e validade de item..."
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
    Private Sub frmEstSecretaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkMateriais.Checked = True
        chkMedicamentos.Checked = True
        Pesquisando("", "")
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

    Private Sub chkMedicamentos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMedicamentos.CheckedChanged
        Pesquisando(txtPesqMedicamento.Text, txtPesqValidade.Text)
    End Sub

    Private Sub chkMateriais_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMateriais.CheckedChanged
        Pesquisando(txtPesqMedicamento.Text, txtPesqValidade.Text)
    End Sub
End Class