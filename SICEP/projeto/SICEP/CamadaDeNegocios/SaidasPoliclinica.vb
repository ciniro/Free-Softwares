Imports AcessoDados.ConexaoComSQLServer

Public Class SaidasPoliclinica
#Region "Funções privadas"
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
    Private _validade As String
    Private _quantidade As Integer
    Private _codUsuario As Integer
    Private _nomeUsuario As String
    Private _codPaciente As Integer
    Private _nomePaciente As String
#End Region
#Region "PROPRIEDADES - Set e Get"
    Public ReadOnly Property CodigoSaida()
        Get
            Return _codigoSaida
        End Get
    End Property
    Public ReadOnly Property DataSaida()
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
    Public Property CodigoPaciente()
        Get
            Return _codPaciente
        End Get
        Set(ByVal value)
            _codPaciente = value
        End Set
    End Property
    Public Property NomePaciente()
        Get
            Return _nomePaciente
        End Get
        Set(ByVal value)
            _nomePaciente = value
        End Set
    End Property
#End Region
#Region "METODOS"
    Public Function BuscaPaciente() As dtsBD_SICEP.tb_pacienteDataTable
        Dim SQL As String = "SELECT * from tb_paciente order by nome_paciente;"
        Dim tbl As New dtsBD_SICEP.tb_pacienteDataTable
        tbl = Busca(SQL, tbl)
        Return tbl
    End Function
    Public Function BuscaPacientePorCodigo(ByVal codigo As Integer) As String
        Dim SQL As String = "SELECT * from tb_paciente where cod_paciente = " + codigo.ToString() + " order by nome_paciente;"
        Dim tbl As New dtsBD_SICEP.tb_pacienteDataTable
        tbl = Busca(SQL, tbl)
        Return tbl(0).nome_paciente.ToString()
    End Function
    Public Function BuscaUltimaRetirada(ByVal codigoMedicamento As Integer, ByVal validade As String) As Boolean
        Dim SQL As String = "SELECT * FROM tb_sai_policlinica WHERE (data_sai_poli IN (SELECT MAX(data_sai_poli)  FROM tb_sai_policlinica WHERE (FKcod_medicamento =" + codigoMedicamento.ToString() + " and validade_sai_poli='" + validade + "')))"
        Dim tbl As New dtsBD_SICEP.tb_sai_policlinicaDataTable
        tbl = Busca(SQL, tbl)
        If tbl.Rows.Count > 0 Then
            _codigoSaida = tbl(0).cod_sai_poli
            _dataSaida = tbl(0).data_sai_poli
            _codMedicamento = tbl(0).FKcod_medicamento
            _validade = tbl(0).validade_sai_poli
            _quantidade = tbl(0).quantidade_sai_poli
            _codUsuario = tbl(0).FKcod_usuario
            _codPaciente = tbl(0).FKcod_paciente
            Return True
        Else
            Return False
        End If
    End Function
    Public Function BuscaUltimaRetirada(ByVal codigoMedicamento As Integer, ByVal codPaciente As Integer, ByVal validade As String) As Boolean
        Dim SQL As String = "SELECT * FROM tb_sai_policlinica WHERE (data_sai_poli IN (SELECT MAX(data_sai_poli)  FROM tb_sai_policlinica WHERE (FKcod_medicamento =" + codigoMedicamento.ToString() + " and FKcod_paciente=" + codPaciente.ToString() + "and validade_sai_poli='" + validade + "')));"
        Dim tbl As New dtsBD_SICEP.tb_sai_policlinicaDataTable
        tbl = Busca(SQL, tbl)
        If tbl.Rows.Count > 0 Then
            _codigoSaida = tbl(0).cod_sai_poli
            _dataSaida = tbl(0).data_sai_poli
            _codMedicamento = tbl(0).FKcod_medicamento
            _validade = tbl(0).validade_sai_poli
            _quantidade = tbl(0).quantidade_sai_poli
            _codUsuario = tbl(0).FKcod_usuario
            _codPaciente = tbl(0).FKcod_paciente
            Return True
        Else
            Return False
        End If
    End Function
    Public Function InsereSaida() As String
        Dim msg As String = ""
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP
            sp.sp_INSERE_SAI_POLI(_codMedicamento, _validade, _quantidade, _codUsuario, _codPaciente, msg)
            Return msg
        Catch ex As Exception
            Throw New Exception("Não foi possível conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
            Return msg
        End Try
    End Function
    '----------------------------------------------------------------------------
    Public Function SaidasEmEstoque(ByVal medic As String, ByVal validade As String, ByVal dataInicial As String, ByVal dataFinal As String) As dtsBD_SICEP.vw_SAIDAS_POLICLINICADataTable
        Dim tbl As New dtsBD_SICEP.vw_SAIDAS_POLICLINICADataTable
        Dim SQL As String = "SELECT * from vw_SAIDAS_POLICLINICA where nome_medicamento like '" + medic + "%' and validade_sai_poli like '" + validade + "%'"
        If dataInicial <> "" And dataFinal <> "" Then
            Dim DI As Date = Convert.ToDateTime(dataInicial)
            Dim DF As Date = Convert.ToDateTime(dataFinal)
            SQL = SQL + " AND (data_sai_poli BETWEEN '" + DI.ToString("yyyyMMdd") + "' AND '" + DF.ToString("yyyyMMdd") + "')" '   '20061214' formato de data
        End If
        SQL = SQL + " ORDER BY data_sai_poli desc, nome_medicamento asc, validade_sai_poli asc;"
        tbl = Busca(SQL, tbl)
        Return tbl
    End Function
    Public Function SaidasEmEstoque(ByVal codigo As Integer) As Boolean
        Dim tbl As New dtsBD_SICEP.vw_SAIDAS_POLICLINICADataTable
        Dim SQL As String = "SELECT * from vw_SAIDAS_POLICLINICA where cod_sai_poli=" + codigo.ToString()
        tbl = Busca(SQL, tbl)
        _codigoSaida = tbl(0).cod_sai_poli
        _dataSaida = tbl(0).data_sai_poli
        _codMedicamento = tbl(0).FKcod_medicamento
        _nomeMedicamento = tbl(0).nome_medicamento
        _validade = tbl(0).validade_sai_poli
        _quantidade = tbl(0).quantidade_sai_poli
        _codUsuario = tbl(0).FKcod_usuario
        _nomeUsuario = tbl(0).nome_usuario
        _codPaciente = tbl(0).FKcod_paciente
        _nomePaciente = tbl(0).nome_paciente
        Return True
    End Function
    Public Function SaidasEmEstoque(ByVal medic As String, ByVal validade As String, ByVal dataInicial As String, ByVal dataFinal As String, ByVal flg As String) As dtsBD_SICEP.vw_SAIDAS_POLICLINICADataTable
        Dim tbl As New dtsBD_SICEP.vw_SAIDAS_POLICLINICADataTable
        Dim SQL As String = "SELECT * from vw_SAIDAS_POLICLINICA where nome_medicamento like '" + medic + "%' and validade_sai_poli like '" + validade + "%'"
        If dataInicial <> "" And dataFinal <> "" Then
            Dim DI As Date = Convert.ToDateTime(dataInicial)
            Dim DF As Date = Convert.ToDateTime(dataFinal)
            SQL = SQL + " AND (data_sai_poli BETWEEN '" + DI.ToString("yyyyMMdd") + "' AND '" + DF.ToString("yyyyMMdd") + "')" '   '20061214' formato de data
        End If
        If flg.Trim() <> "" Then
            SQL = SQL + " and flg_material=" + flg
        End If
        SQL = SQL + " ORDER BY data_sai_poli desc, nome_medicamento asc, validade_sai_poli asc;"
        tbl = Busca(SQL, tbl)
        Return tbl
    End Function
    Public Function AlteraSaida(ByVal codigo As Integer, ByVal codMedic As Integer, ByVal validade As String, ByVal quantidade As Integer) As String
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP
            Dim msg As String = ""
            sp.sp_ALTERA_SAIDA_POLICLINICA(codigo, codMedic, validade, quantidade, msg)
            Return msg
        Catch ex As Exception
            Throw New Exception("Não foi possível conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
        End Try
    End Function
    Public Function ExcluirSaida(ByVal codigo As Integer) As String
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP
            Dim msg As String = ""
            sp.sp_DELETA_SAIDA_POLICLINICA(codigo, msg)
            Return msg
        Catch ex As Exception
            Throw New Exception("Não foi possível conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
        End Try
    End Function
#End Region

End Class
