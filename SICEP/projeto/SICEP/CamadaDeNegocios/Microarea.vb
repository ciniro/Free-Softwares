Imports AcessoDados.ConexaoComSQLServer

Public Class Microarea
#Region "metodos privados"
    Private Function BuscaMicroarea(ByVal SQL As String, ByVal dts As dtsBD_SICEP.tb_microareaDataTable) As dtsBD_SICEP.tb_microareaDataTable
        Dim con As New conexaoSQLServer()
        con._AbreConexao()
        con._PreencheDataTable(dts, SQL)
        con._FechaConexao()
        Return dts
    End Function
#End Region
#Region "Variáveis privadas"
    Private _codigo As Integer
    Private _dataCadastro As String
    Private _agente As String
    Private _observacoes As String
#End Region
#Region "PROPRIEDADES - Set e Get"
    Public ReadOnly Property Codigo()
        Get
            Return _codigo
        End Get
    End Property
    Public Property DataCadastramento()
        Get
            Return _dataCadastro
        End Get
        Set(ByVal value)
            _dataCadastro = value
        End Set
    End Property
    Public Property Agente()
        Get
            Return _agente
        End Get
        Set(ByVal value)
            _agente = value
        End Set
    End Property
    Public Property Observacoes()
        Get
            Return _observacoes
        End Get
        Set(ByVal value)
            _observacoes = value
        End Set
    End Property
#End Region
#Region "METODOS"
    Public Function Seleciona() As dtsBD_SICEP.tb_microareaDataTable
        Dim SQL As String = "SELECT * from tb_microarea order by cod_microarea"
        Dim dts As New dtsBD_SICEP.tb_microareaDataTable()
        dts = BuscaMicroarea(SQL, dts)
        Return dts
    End Function
    Public Sub SelecionaPorValor(ByVal codigo As Integer)
        Dim SQL As String = "SELECT * from tb_microarea where cod_microarea=" + codigo.ToString() + " order by cod_microarea"
        Dim dts As New dtsBD_SICEP.tb_microareaDataTable()
        dts = BuscaMicroarea(SQL, dts)
        _codigo = dts(0).cod_microarea
        _dataCadastro = dts(0).data_cad_microarea
        _agente = dts(0).agente_microarea
        _observacoes = dts(0).obs_microarea
    End Sub
    Public Function SelecionaPorValor(ByVal valor As String) As dtsBD_SICEP.tb_microareaDataTable
        Dim SQL As String
        If IsNumeric(valor) Then
            SQL = "SELECT cod_microarea, agente_microarea from tb_microarea where cod_microarea=" + valor.ToString() + " order by cod_microarea;"
        Else
            SQL = "SELECT cod_microarea, agente_microarea from tb_microarea where agente_microarea like '" + valor.ToString() + "%' order by cod_microarea;"
        End If
        Dim dts As New dtsBD_SICEP.tb_microareaDataTable()
        dts.Columns.Remove("data_cad_microarea")
        dts.Columns.Remove("obs_microarea")
        dts = BuscaMicroarea(SQL, dts)
        Return dts
    End Function
    Public Function Salvar() As Boolean
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP
            sp.sp_INSERE_MICROAREA(_agente, _observacoes)
            Return True
        Catch ex As Exception
            Throw New Exception("Não foi possível conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
            Return False
        End Try
    End Function
    Public Function Alterar() As Boolean
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP
            sp.sp_ALTERA_MICROAREA(_codigo, _agente, _observacoes)
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
            sp.sp_DELETA_MICROAREA(_codigo, saida)
            Return saida
        Catch ex As Exception
            Throw New Exception("Não foi possível conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
            Return "Não foi possível excluir esta micro-área!"
        End Try
    End Function
#End Region
End Class
