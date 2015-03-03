Imports AcessoDados.ConexaoComSQLServer

Public Class EstoquePoliclinica
#Region "Fun��es Privadas"
    Private Function Busca(ByVal SQL As String, ByVal dts As DataTable) As DataTable
        Dim con As New conexaoSQLServer
        con._AbreConexao()
        con._PreencheDataTable(dts, SQL)
        con._FechaConexao()
        Return dts
    End Function
#End Region
#Region "Vari�veis Privadas"
    Private _codigoEntrada As Integer
    Private _dataEntrada As String
    Private _codMedicamento As Integer
    Private _nomeMedicamento As String 'facultativa
    Private _validade As String
    Private _quantidade As Integer
    Private _codUsuario As Integer
    Private _nomeUsuario As String 'facultativa
#End Region
#Region "PROPRIEDADES - Set e Get"
    Public ReadOnly Property CodigoEntrada()
        Get
            Return _codigoEntrada
        End Get
    End Property
    Public ReadOnly Property DataDaEntrada()
        Get
            Return _dataEntrada
        End Get
    End Property
    Public Property CodigoMedicamento()
        Get
            Return _codMedicamento
        End Get
        Set(ByVal value)
            _codMedicamento = value
        End Set
    End Property
    Public Property NomeMedicamento()
        Get
            Return _nomeMedicamento
        End Get
        Set(ByVal value)
            _nomeMedicamento = value
        End Set
    End Property
    Public Property Validade()
        Get
            Return _validade
        End Get
        Set(ByVal value)
            _validade = value
        End Set
    End Property
    Public Property Quantidade()
        Get
            Return _quantidade
        End Get
        Set(ByVal value)
            _quantidade = value
        End Set
    End Property
    Public Property CodigoUsuario()
        Get
            Return _codUsuario
        End Get
        Set(ByVal value)
            _codUsuario = value
        End Set
    End Property
    Public Property NomeUsuario()
        Get
            Return _nomeUsuario
        End Get
        Set(ByVal value)
            _nomeUsuario = value
        End Set
    End Property
#End Region
#Region "M�TODOS"
    Public Function InsereEntrada() As Boolean
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP
            sp.sp_INSERE_ENT_POLI(_codMedicamento, _validade, _quantidade, _codUsuario)
            Return True
        Catch ex As Exception
            Throw New Exception("N�o foi poss�vel conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
            Return False
        End Try
    End Function
    Public Function Estoque(ByVal medic As String, ByVal validade As String) As DataTable
        Dim tbl As New DataTable
        tbl.Columns.Add("cod_medicamento")
        tbl.Columns.Add("nome_medicamento")
        tbl.Columns.Add("val_medicamento")

        Dim SQL As String = "SELECT DISTINCT " & _
        " tb_medicamento.cod_medicamento, tb_medicamento.nome_medicamento, " & _
        " tb_ent_policlinica.validade_ent_poli AS val_medicamento " & _
        " FROM tb_medicamento INNER JOIN " & _
        " tb_ent_policlinica ON tb_medicamento.cod_medicamento = tb_ent_policlinica.FKcod_medicamento " & _
        " WHERE tb_medicamento.nome_medicamento like '" + medic + "%' " & _
        " AND tb_ent_policlinica.validade_ent_poli like '" + validade + "%' " & _
        " ORDER BY tb_medicamento.nome_medicamento, tb_ent_policlinica.validade_ent_poli;"

        Busca(SQL, tbl)

        Dim tblEstoque As New DataTable
        tblEstoque.Columns.Add("cod_medicamento")
        tblEstoque.Columns.Add("nome_medicamento")
        tblEstoque.Columns.Add("val_medicamento")
        tblEstoque.Columns.Add("quant_medicamento")

        Dim linha As DataRow
        Dim NovaLinha As DataRow
        Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP
        For Each linha In tbl.Rows()
            NovaLinha = tblEstoque.NewRow()
            NovaLinha("cod_medicamento") = linha("cod_medicamento")
            NovaLinha("nome_medicamento") = linha("nome_medicamento")
            NovaLinha("val_medicamento") = linha("val_medicamento")
            Dim quantidade As Integer
            sp.sp_QUANT_EST_POLI(Int32.Parse(linha("cod_medicamento")), linha("val_medicamento").ToString(), quantidade)
            NovaLinha("quant_medicamento") = quantidade
            If quantidade > 0 Then
                tblEstoque.Rows.Add(NovaLinha)
            End If
        Next

        tbl.Dispose()
        Return tblEstoque
    End Function
    Public Function Estoque(ByVal medic As String, ByVal validade As String, ByVal flg As String) As DataTable
        Dim tbl As New DataTable
        tbl.Columns.Add("cod_medicamento")
        tbl.Columns.Add("nome_medicamento")
        tbl.Columns.Add("val_medicamento")

        Dim SQL As String = "SELECT DISTINCT " & _
        " tb_medicamento.cod_medicamento, tb_medicamento.nome_medicamento, " & _
        " tb_ent_policlinica.validade_ent_poli AS val_medicamento " & _
        " FROM tb_medicamento INNER JOIN " & _
        " tb_ent_policlinica ON tb_medicamento.cod_medicamento = tb_ent_policlinica.FKcod_medicamento " & _
        " WHERE tb_medicamento.nome_medicamento like '" + medic + "%' " & _
        " AND tb_ent_policlinica.validade_ent_poli like '" + validade + "%' "

        If flg.Trim() <> "" Then
            SQL = SQL + " and tb_medicamento.flg_material=" + flg
        End If

        SQL = SQL + " ORDER BY tb_medicamento.nome_medicamento, tb_ent_policlinica.validade_ent_poli;"
        Busca(SQL, tbl)

        Dim tblEstoque As New DataTable
        tblEstoque.Columns.Add("cod_medicamento")
        tblEstoque.Columns.Add("nome_medicamento")
        tblEstoque.Columns.Add("val_medicamento")
        tblEstoque.Columns.Add("quant_medicamento")

        Dim linha As DataRow
        Dim NovaLinha As DataRow
        Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP
        For Each linha In tbl.Rows()
            NovaLinha = tblEstoque.NewRow()
            NovaLinha("cod_medicamento") = linha("cod_medicamento")
            NovaLinha("nome_medicamento") = linha("nome_medicamento")
            NovaLinha("val_medicamento") = linha("val_medicamento")
            Dim quantidade As Integer
            sp.sp_QUANT_EST_POLI(Int32.Parse(linha("cod_medicamento")), linha("val_medicamento").ToString(), quantidade)
            NovaLinha("quant_medicamento") = quantidade
            If quantidade > 0 Then
                tblEstoque.Rows.Add(NovaLinha)
            End If
        Next

        tbl.Dispose()
        Return tblEstoque
    End Function
    Public Function EntradasEmEstoque(ByVal medic As String, ByVal validade As String, ByVal dataInicial As String, ByVal dataFinal As String) As dtsBD_SICEP.vw_ENTRADAS_POLICLINICADataTable
        Dim tbl As New dtsBD_SICEP.vw_ENTRADAS_POLICLINICADataTable
        Dim SQL As String = "SELECT * from vw_ENTRADAS_POLICLINICA where nome_medicamento like '" + medic + "%' and validade_ent_poli like '" + validade + "%'"
        If dataInicial <> "" And dataFinal <> "" Then
            Dim DI As Date = Convert.ToDateTime(dataInicial)
            Dim DF As Date = Convert.ToDateTime(dataFinal)
            SQL = SQL + " AND (data_ent_poli BETWEEN '" + DI.ToString("yyyyMMdd") + "' AND '" + DF.ToString("yyyyMMdd") + "')" '   '20061214' formato de data
        End If
        SQL = SQL + " ORDER BY data_ent_poli desc, nome_medicamento asc, validade_ent_poli asc;"
        tbl = Busca(SQL, tbl)
        Return tbl
    End Function
    Public Function EntradasEmEstoque(ByVal medic As String, ByVal validade As String, ByVal dataInicial As String, ByVal dataFinal As String, ByVal flg As String) As dtsBD_SICEP.vw_ENTRADAS_POLICLINICADataTable
        Dim tbl As New dtsBD_SICEP.vw_ENTRADAS_POLICLINICADataTable
        Dim SQL As String = "SELECT * from vw_ENTRADAS_POLICLINICA where nome_medicamento like '" + medic + "%' and validade_ent_poli like '" + validade + "%'"
        If dataInicial <> "" And dataFinal <> "" Then
            Dim DI As Date = Convert.ToDateTime(dataInicial)
            Dim DF As Date = Convert.ToDateTime(dataFinal)
            SQL = SQL + " AND (data_ent_poli BETWEEN '" + DI.ToString("yyyyMMdd") + "' AND '" + DF.ToString("yyyyMMdd") + "')" '   '20061214' formato de data
        End If
        If flg.Trim() <> "" Then
            SQL = SQL + " and flg_material=" + flg
        End If
        SQL = SQL + " ORDER BY data_ent_poli desc, nome_medicamento asc, validade_ent_poli asc;"
        tbl = Busca(SQL, tbl)
        Return tbl
    End Function
    Public Function EntradasEmEstoque(ByVal codigo As Integer) As Boolean
        Dim tbl As New dtsBD_SICEP.vw_ENTRADAS_POLICLINICADataTable
        Dim SQL As String = "SELECT * from vw_ENTRADAS_POLICLINICA where cod_ent_poli=" + codigo.ToString()
        tbl = Busca(SQL, tbl)
        _codigoEntrada = tbl(0).cod_ent_poli
        _dataEntrada = tbl(0).data_ent_poli
        _codMedicamento = tbl(0).FKcod_medicamento
        _nomeMedicamento = tbl(0).nome_medicamento
        _validade = tbl(0).validade_ent_poli
        _quantidade = tbl(0).quantidade_ent_poli
        _codUsuario = tbl(0).FKcod_usuario
        _nomeUsuario = tbl(0).nome_usuario
        Return True
    End Function
    Public Function AlteraEntrada(ByVal codigo As Integer, ByVal codMedic As Integer, ByVal validade As String, ByVal quantidade As Integer) As String
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP
            Dim msg As String = ""
            sp.sp_ALTERA_ENTRADA_POLICLINICA(codigo, codMedic, validade, quantidade, msg)
            Return msg
        Catch ex As Exception
            Throw New Exception("N�o foi poss�vel conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
        End Try
    End Function
    Public Function ExcluirEntrada(ByVal codigo As Integer, ByVal codMedic As Integer, ByVal validade As String) As String
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP
            Dim msg As String = ""
            sp.sp_DELETA_ENTRADA_POLICLINICA(codigo, codMedic, validade, msg)
            Return msg
        Catch ex As Exception
            Throw New Exception("N�o foi poss�vel conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
        End Try
    End Function
#End Region
End Class
