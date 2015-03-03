Imports AcessoDados.ConexaoComSQLServer

Public Class SaidasSecretaria

#Region "Funções Privadas"
    Private Function Busca(ByVal SQL As String, ByVal dts As DataTable) As DataTable
        Dim con As New conexaoSQLServer()
        con._AbreConexao()
        con._PreencheDataTable(dts, SQL)
        con._FechaConexao()
        Return dts
    End Function
#End Region
#Region "Variáveis Privadas"
    Private _codigoSaida As Integer
    Private _dataSaida As String
    Private _codMedicamento As Integer
    Private _nomeMedicamento As String
    Private _validadeMedicamento As String
    Private _quantRetirada As Integer
    Private _codigoUsuario As Integer
    Private _nomeUsuario As String
    Private _codigoRegiao As Integer
    Private _nomeRegiao As String

#End Region
#Region "PROPRIEDADES - Set e Get"
    Public ReadOnly Property CodigoDaSaida()
        Get
            Return _codigoSaida
        End Get
    End Property
    Public ReadOnly Property DataDaSaida()
        Get
            Return _dataSaida
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
    Public Property ValidadeMedicamento()
        Get
            Return _validadeMedicamento
        End Get
        Set(ByVal value)
            _validadeMedicamento = value
        End Set
    End Property
    Public Property QuantidadeRetirada()
        Get
            Return _quantRetirada
        End Get
        Set(ByVal value)
            _quantRetirada = value
        End Set
    End Property
    Public Property CodigoUsuario()
        Get
            Return _codigoUsuario
        End Get
        Set(ByVal value)
            _codigoUsuario = value
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
    Public Property CodigoRegiao()
        Get
            Return _codigoRegiao
        End Get
        Set(ByVal value)
            _codigoRegiao = value
        End Set
    End Property
    Public Property NomeRegiao()
        Get
            Return _nomeRegiao
        End Get
        Set(ByVal value)
            _nomeRegiao = value
        End Set
    End Property
#End Region
#Region "MÉTODOS"
    Public Function BuscaUltimaRetirada() As Boolean
        Dim SQL As String = "SELECT * FROM tb_sai_secretaria WHERE  (data_sai_sec IN  (SELECT MAX(data_sai_sec)  FROM tb_sai_secretaria))"
        Dim tbl As New dtsBD_SICEP.tb_sai_secretariaDataTable
        tbl = Busca(SQL, tbl)
        If tbl.Rows.Count > 0 Then
            _codigoSaida = tbl(0).cod_sai_sec
            _dataSaida = tbl(0).data_sai_sec
            _codMedicamento = tbl(0).FKcod_medicamento
            _validadeMedicamento = tbl(0).validade_sai_sec
            _quantRetirada = tbl(0).quantidade_sai_sec
            _codigoUsuario = tbl(0).FKcod_usuario
            _codigoRegiao = tbl(0).FKcod_regiao
            Return True
        Else
            Return False
        End If
    End Function
    Public Function BuscaUltimaRetirada(ByVal codigoMedicamento As Integer, ByVal validade As String) As Boolean
        Dim SQL As String = "SELECT * FROM tb_sai_secretaria WHERE (data_sai_sec IN (SELECT MAX(data_sai_sec)  FROM tb_sai_secretaria WHERE (FKcod_medicamento =" + codigoMedicamento.ToString() + " and validade_sai_sec='" + validade + "')))"
        Dim tbl As New dtsBD_SICEP.tb_sai_secretariaDataTable
        tbl = Busca(SQL, tbl)
        If tbl.Rows.Count > 0 Then
            _codigoSaida = tbl(0).cod_sai_sec
            _dataSaida = tbl(0).data_sai_sec
            _codMedicamento = tbl(0).FKcod_medicamento
            _validadeMedicamento = tbl(0).validade_sai_sec
            _quantRetirada = tbl(0).quantidade_sai_sec
            _codigoUsuario = tbl(0).FKcod_usuario
            _codigoRegiao = tbl(0).FKcod_regiao
            Return True
        Else
            Return False
        End If
    End Function
    Public Function BuscaUltimaRetirada(ByVal codigoMedicamento As Integer, ByVal codRegiao As Integer, ByVal validade As String) As Boolean
        Dim SQL As String = "SELECT * FROM tb_sai_secretaria WHERE (data_sai_sec IN (SELECT MAX(data_sai_sec)  FROM tb_sai_secretaria WHERE (FKcod_medicamento =" + codigoMedicamento.ToString() + " and FKcod_regiao=" + codRegiao.ToString() + " and validade_sai_sec='" + validade + "')));"
        Dim tbl As New dtsBD_SICEP.tb_sai_secretariaDataTable
        tbl = Busca(SQL, tbl)
        If tbl.Rows.Count > 0 Then
            _codigoSaida = tbl(0).cod_sai_sec
            _dataSaida = tbl(0).data_sai_sec
            _codMedicamento = tbl(0).FKcod_medicamento
            _validadeMedicamento = tbl(0).validade_sai_sec
            _quantRetirada = tbl(0).quantidade_sai_sec
            _codigoUsuario = tbl(0).FKcod_usuario
            _codigoRegiao = tbl(0).FKcod_regiao
            Return True
        Else
            Return False
        End If
    End Function
    Public Function BuscaRegioes() As dtsBD_SICEP.tb_regiaoDataTable
        Dim SQL As String = "SELECT * from tb_regiao"
        Dim tbl As New dtsBD_SICEP.tb_regiaoDataTable
        tbl = Busca(SQL, tbl)
        Return tbl
    End Function
    Public Function BuscaRegiaoPorCodigo(ByVal codigo As Integer) As String
        Dim SQL As String = "SELECT * from tb_regiao where cod_regiao = " + codigo.ToString() + ";"
        Dim tbl As New dtsBD_SICEP.tb_regiaoDataTable
        tbl = Busca(SQL, tbl)
        Return tbl(0).nome_regiao.ToString()
    End Function
    Public Function InsereSaida() As String
        Dim msg As String = ""
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP
            sp.sp_INSERE_SAI_SEC(_codMedicamento, _validadeMedicamento, _quantRetirada, _codigoUsuario, _codigoRegiao, msg)
            Return msg
        Catch ex As Exception
            Throw New Exception("Não foi possível conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
            Return msg
        End Try
    End Function
    '----------------------------------------------------------------------------
    Public Function SaidasEmEstoque(ByVal medic As String, ByVal validade As String, ByVal dataInicial As String, ByVal dataFinal As String) As dtsBD_SICEP.vw_SAIDAS_SECRETARIADataTable
        Dim tbl As New dtsBD_SICEP.vw_SAIDAS_SECRETARIADataTable
        Dim SQL As String = "SELECT * from vw_SAIDAS_SECRETARIA where nome_medicamento like '" + medic + "%' and validade_sai_sec like '" + validade + "%'"
        If dataInicial <> "" And dataFinal <> "" Then
            Dim DI As Date = Convert.ToDateTime(dataInicial)
            Dim DF As Date = Convert.ToDateTime(dataFinal)
            SQL = SQL + " AND (data_sai_sec BETWEEN '" + DI.ToString("yyyyMMdd") + "' AND '" + DF.ToString("yyyyMMdd") + "')" '   '20061214' formato de data
        End If
        SQL = SQL + " ORDER BY data_sai_sec desc, nome_medicamento asc, validade_sai_sec asc;"
        tbl = Busca(SQL, tbl)
        Return tbl
    End Function
    Public Function SaidasEmEstoque(ByVal codigo As Integer) As Boolean
        Dim tbl As New dtsBD_SICEP.vw_SAIDAS_SECRETARIADataTable
        Dim SQL As String = "SELECT * from vw_SAIDAS_SECRETARIA where cod_sai_sec=" + codigo.ToString()
        tbl = Busca(SQL, tbl)
        _codigoSaida = tbl(0).cod_sai_sec
        _dataSaida = tbl(0).data_sai_sec
        _codMedicamento = tbl(0).FKcod_medicamento
        _nomeMedicamento = tbl(0).nome_medicamento
        _validadeMedicamento = tbl(0).validade_sai_sec
        _quantRetirada = tbl(0).quantidade_sai_sec
        _codigoUsuario = tbl(0).FKcod_usuario
        _nomeUsuario = tbl(0).nome_usuario
        _codigoRegiao = tbl(0).FKcod_regiao
        _nomeRegiao = tbl(0).nome_regiao
        Return True
    End Function
    Public Function SaidasEmEstoque(ByVal medic As String, ByVal validade As String, ByVal dataInicial As String, ByVal dataFinal As String, ByVal flg As String) As dtsBD_SICEP.vw_SAIDAS_SECRETARIADataTable
        Dim tbl As New dtsBD_SICEP.vw_SAIDAS_SECRETARIADataTable
        Dim SQL As String = "SELECT * from vw_SAIDAS_SECRETARIA where nome_medicamento like '" + medic + "%' and validade_sai_sec like '" + validade + "%'"
        If dataInicial <> "" And dataFinal <> "" Then
            Dim DI As Date = Convert.ToDateTime(dataInicial)
            Dim DF As Date = Convert.ToDateTime(dataFinal)
            SQL = SQL + " AND (data_sai_sec BETWEEN '" + DI.ToString("yyyyMMdd") + "' AND '" + DF.ToString("yyyyMMdd") + "')" '   '20061214' formato de data
        End If
        If flg.Trim() <> "" Then
            SQL = SQL + " and flg_material=" + flg
        End If
        SQL = SQL + " ORDER BY data_sai_sec desc, nome_medicamento asc, validade_sai_sec asc;"
        tbl = Busca(SQL, tbl)
        Return tbl
    End Function
    Public Function AlteraSaida(ByVal codigo As Integer, ByVal codMedic As Integer, ByVal validade As String, ByVal quantidade As Integer) As String
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP
            Dim msg As String = ""
            sp.sp_ALTERA_SAIDA_SECRETARIA(codigo, codMedic, validade, quantidade, msg)
            Return msg
        Catch ex As Exception
            Throw New Exception("Não foi possível conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
        End Try
    End Function
    Public Function ExcluirSaida(ByVal codigo As Integer) As String
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP
            Dim msg As String = ""
            sp.sp_DELETA_SAIDA_SECRETARIA(codigo, msg)
            Return msg
        Catch ex As Exception
            Throw New Exception("Não foi possível conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
        End Try
    End Function
#End Region

End Class
