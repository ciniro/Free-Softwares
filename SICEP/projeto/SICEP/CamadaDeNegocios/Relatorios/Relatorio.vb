Imports AcessoDados.ConexaoComSQLServer
Imports CrystalDecisions.CrystalReports

Public Class Relatorio
    Private Function Busca(ByVal sql As String) As DataTable
        Dim con As New conexaoSQLServer
        Dim dts As New DataTable
        con._AbreConexao()
        con._PreencheDataTable(dts, sql)
        con._FechaConexao()
        Return dts
    End Function
    Public Function CriarRelEstoqueSecretaria(ByVal dts As DataTable) As rptEstoqueSecretaria
        Dim rpt As New rptEstoqueSecretaria
        rpt.SetDataSource(dts)
        Return rpt
    End Function
    Public Function CriarRelEstoquePoliclinica(ByVal dts As DataTable) As rptEstoquePoliclinica
        Dim rpt As New rptEstoquePoliclinica
        rpt.SetDataSource(dts)
        Return rpt
    End Function
    Public Function CriarRelEntradasSecretaria(ByVal dts As DataTable) As rptEntradasSecretaria
        Dim rpt As New rptEntradasSecretaria
        rpt.SetDataSource(dts)
        Return rpt
    End Function
    Public Function CriarRelEntradasPoliclinica(ByVal dts As DataTable) As rptEntradasPoliclinica
        Dim rpt As New rptEntradasPoliclinica
        rpt.SetDataSource(dts)
        Return rpt
    End Function
    Public Function CriarRelSaidasSecretaria(ByVal dts As DataTable) As rptSaidasSecretaria
        Dim rpt As New rptSaidasSecretaria
        rpt.SetDataSource(dts)
        Return rpt
    End Function
    Public Function CriarRelSaidasPoliclinica(ByVal dts As DataTable) As rptSaidasPoliclinica
        Dim rpt As New rptSaidasPoliclinica
        rpt.SetDataSource(dts)
        Return rpt
    End Function
    Public Function CriarRelMicroArea() As rptMicroArea
        Dim rpt As New rptMicroArea
        Dim SQL As String = "SELECT * from tb_microarea;"
        rpt.SetDataSource(Busca(SQL))
        Return rpt
    End Function
    Public Function CriarRelUsuario() As rptUsuario
        Dim rpt As New rptUsuario
        Dim SQL As String = "SELECT U.nome_usuario, U.cargo_usuario, U.end_usuario," & _
        " U.tel_res_usuario, U.tel_cel_usuario, U.email_usuario, U.CPF_usuario, U.RG_usuario," & _
        " P.nome_perfil from tb_usuario U, tb_perfil P where U.cod_usuario<>6 and U.FKcod_perfil=P.cod_perfil" & _
        " order by U.nome_usuario;"
        rpt.SetDataSource(Busca(SQL))
        Return rpt
    End Function
    Public Function CriarRelPaciente() As rptPaciente
        Dim rpt As New rptPaciente
        Dim SQL As String = "SELECT * from tb_paciente order by nome_paciente"
        rpt.SetDataSource(Busca(SQL))
        Return rpt
    End Function
    Public Function CriarRelMedicamento() As rptMedicamento
        Dim rpt As New rptMedicamento
        Dim SQL As String = "SELECT * from tb_medicamento where flg_material=0 order by nome_medicamento"
        rpt.SetDataSource(Busca(SQL))
        Return rpt
    End Function
    Public Function CriarRelMaterial() As rptMaterial
        Dim rpt As New rptMaterial
        Dim SQL As String = "SELECT * from tb_medicamento where flg_material=1 order by nome_medicamento"
        rpt.SetDataSource(Busca(SQL))
        Return rpt
    End Function
    Public Function CriarRelEstoqueSecretaria() As rptEstoqueSecretaria
        Dim rpt As New rptEstoqueSecretaria
        Dim est As New EstoqueSecretaria
        Dim dts As New DataTable
        dts = est.Estoque("", "")
        rpt.SetDataSource(dts)
        Return rpt
    End Function
    Public Function CriarRelEstoquePoliclinica() As rptEstoquePoliclinica
        Dim rpt As New rptEstoquePoliclinica
        Dim est As New EstoquePoliclinica
        Dim dts As New DataTable
        dts = est.Estoque("", "")
        rpt.SetDataSource(dts)
        Return rpt
    End Function
    Public Function CriarRelEntradasSecretaria() As rptEntradasSecretaria
        Dim rpt As New rptEntradasSecretaria
        Dim est As New EstoqueSecretaria
        Dim dts As New DataTable
        dts = est.EntradasEmEstoque("", "", "", "")
        rpt.SetDataSource(dts)
        Return rpt
    End Function
    Public Function CriarRelEntradasPoliclinica() As rptEntradasPoliclinica
        Dim rpt As New rptEntradasPoliclinica
        Dim est As New EstoquePoliclinica
        Dim dts As New DataTable
        dts = est.EntradasEmEstoque("", "", "", "")
        rpt.SetDataSource(dts)
        Return rpt
    End Function
    Public Function CriarRelSaidasSecretaria() As rptSaidasSecretaria
        Dim rpt As New rptSaidasSecretaria
        Dim est As New SaidasSecretaria
        Dim dts As New DataTable
        dts = est.SaidasEmEstoque("", "", "", "")
        rpt.SetDataSource(dts)
        Return rpt
    End Function
    Public Function CriarRelSaidasPoliclinica() As rptSaidasPoliclinica
        Dim rpt As New rptSaidasPoliclinica
        Dim est As New SaidasPoliclinica
        Dim dts As New DataTable
        dts = est.SaidasEmEstoque("", "", "", "")
        rpt.SetDataSource(dts)
        Return rpt
    End Function
End Class
