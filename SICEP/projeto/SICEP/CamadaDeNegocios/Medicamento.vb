Imports AcessoDados.ConexaoComSQLServer

Public Class Medicamento

    Sub New()
    End Sub
#Region "metodos privados"
    Private Function BuscaMedicamento(ByVal sql As String, ByVal dts As dtsBD_SICEP.tb_medicamentoDataTable) As dtsBD_SICEP.tb_medicamentoDataTable
        Dim con As New conexaoSQLServer()
        con._AbreConexao()
        con._PreencheDataTable(dts, sql)
        con._FechaConexao()
        Return dts
    End Function
#End Region
#Region "Variáveis Privadas"
    Private _codigo As Integer
    Private _dataCadastro As String
    Private _nome As String
    Private _composicao As String
    Private _info As String
    Private _flg As String
#End Region
#Region "PROPRIEDADES Set e Get"
    Public ReadOnly Property Codigo()
        Get
            Return _codigo
        End Get
    End Property
    Public Property DataCadastro()
        Get
            Return _dataCadastro
        End Get
        Set(ByVal value)
            _dataCadastro = value
        End Set
    End Property
    Public Property Nome()
        Get
            Return _nome
        End Get
        Set(ByVal value)
            _nome = value
        End Set
    End Property
    Public Property Composicao()
        Get
            Return _composicao
        End Get
        Set(ByVal value)
            _composicao = value
        End Set
    End Property
    Public Property Informacoes()
        Get
            Return _info
        End Get
        Set(ByVal value)
            _info = value
        End Set
    End Property
    Public Property Flag()
        Get
            Return _flg
        End Get
        Set(ByVal value)
            _flg = value
        End Set
    End Property
#End Region
#Region "METODOS"
    Public Function Seleciona(ByVal nome As String) As dtsBD_SICEP.tb_medicamentoDataTable
        Dim SQL As String = "SELECT cod_medicamento, nome_medicamento from tb_medicamento where nome_medicamento like '" + nome + "%' order by nome_medicamento;"
        Dim dts As New dtsBD_SICEP.tb_medicamentoDataTable()
        dts.Columns.Remove("data_cad_medicamento")
        dts.Columns.Remove("composicao_medicamento")
        dts.Columns.Remove("info_medicamento")
        dts = BuscaMedicamento(SQL, dts)
        Return dts
    End Function
    Public Sub Seleciona(ByVal codigo As Integer)
        Dim SQL As String = "SELECT * from tb_medicamento where cod_medicamento=" + codigo.ToString() + ";"
        Dim dts As New dtsBD_SICEP.tb_medicamentoDataTable()
        dts = BuscaMedicamento(SQL, dts)
        _codigo = dts(0).cod_medicamento
        _dataCadastro = dts(0).data_cad_medicamento
        _nome = dts(0).nome_medicamento
        _composicao = dts(0).composicao_medicamento
        _info = dts(0).info_medicamento
    End Sub
    Public Function Seleciona(ByVal nome As String, ByVal flg As String) As dtsBD_SICEP.tb_medicamentoDataTable
        Dim SQL As String = "SELECT cod_medicamento, nome_medicamento from tb_medicamento where nome_medicamento like '" + nome + "%'"

        If flg.Trim() <> "" Then
            SQL = SQL + " and flg_material=" + flg
        End If

        SQL = SQL + " order by nome_medicamento;"

        Dim dts As New dtsBD_SICEP.tb_medicamentoDataTable()
        dts.Columns.Remove("data_cad_medicamento")
        dts.Columns.Remove("composicao_medicamento")
        dts.Columns.Remove("info_medicamento")
        dts = BuscaMedicamento(SQL, dts)
        Return dts
    End Function
    Public Function Salvar() As Boolean
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP
            sp.sp_INSERE_MEDICAMENTO(_nome, _composicao, _info)
            Return True
        Catch ex As Exception
            Throw New Exception("Não foi possível conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
            Return False
        End Try
    End Function
    Public Function SalvarMaterial() As Boolean
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP
            sp.sp_INSERE_MATERIAL(_nome, _composicao, _info)
            Return True
        Catch ex As Exception
            Throw New Exception("Não foi possível conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
            Return False
        End Try
    End Function
    Public Function Alterar() As Boolean
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP
            sp.sp_ALTERA_MEDICAMENTO(_codigo, _nome, _composicao, _info)
            Return True
        Catch ex As Exception
            Throw New Exception("Não foi possível conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
            Return False
        End Try
    End Function
    Public Function Excluir() As String
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP
            Dim saida As String = ""
            sp.sp_DELETA_MEDICAMENTO(_codigo, saida)
            Return saida
        Catch ex As Exception
            Throw New Exception("Não foi possível conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
            Return "Não foi possível excluir este medicamento!"
        End Try
    End Function
#End Region

End Class
