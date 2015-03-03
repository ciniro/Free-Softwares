Imports AcessoDados.ConexaoComSQLServer


Public Class Paciente : Inherits Pessoa

#Region "Variáveis Privadas"
    Private _dataNascimento As String
    Private _sexo As String
    Private _telefone As String
    Private _mae As String
    Private _cod_microarea As Integer
#End Region
#Region "PROPRIEDADES - Set e Get"

    Public Property DataNascimento()
        Get
            Return _dataNascimento
        End Get
        Set(ByVal value)
            _dataNascimento = value
        End Set
    End Property
    Public Property Sexo()
        Get
            Return _sexo
        End Get
        Set(ByVal value)
            _sexo = value
        End Set
    End Property
    Public Property Telefone()
        Get
            Return _telefone
        End Get
        Set(ByVal value)
            _telefone = value
        End Set
    End Property
    Public Property NomeDaMae()
        Get
            Return _mae
        End Get
        Set(ByVal value)
            _mae = value
        End Set
    End Property
    Public Property CodigoMicroarea()
        Get
            Return _cod_microarea
        End Get
        Set(ByVal value)
            _cod_microarea = value
        End Set
    End Property
#End Region
#Region "METODOS"
    Public Overrides Function Alterar() As Boolean
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP()
            sp.sp_ALTERA_PACIENTE(_codigo, _nome, _endereco, _dataNascimento, _sexo, _telefone, _mae, _CPF, _RG, _cod_microarea)
            Return True
        Catch ex As Exception
            Throw New Exception("Não foi possível conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
            Return False
        End Try
    End Function
    Public Overrides Function Excluir() As String
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP()
            Dim saida As String = ""
            sp.sp_DELETA_PACIENTE(_codigo, saida)
            Return saida
        Catch ex As Exception
            Throw New Exception("Não foi possível conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
            Return "Não foi possível excluir este paciente!"
        End Try
    End Function
    Public Overrides Function Salvar() As Boolean
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP()
            sp.sp_INSERE_PACIENTE(_nome, _endereco, _dataNascimento, _sexo, _telefone, _mae, _CPF, _RG, _cod_microarea)
            Return True
        Catch ex As Exception
            Throw New Exception("Não foi possível conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
            Return False
        End Try
    End Function
    Public Function SelecionaPorNome(ByVal nome As String) As dtsBD_SICEP.tb_pacienteDataTable
        Dim SQL As String = "SELECT cod_paciente, nome_paciente FROM tb_paciente where nome_paciente like '" + nome + "%' order by nome_paciente;"
        Dim con As New conexaoSQLServer()
        Dim dts As New dtsBD_SICEP.tb_pacienteDataTable()
        dts.Columns.Remove("data_cad_paciente")
        dts.Columns.Remove("end_paciente")
        dts.Columns.Remove("data_nasc_paciente")
        dts.Columns.Remove("sexo_paciente")
        dts.Columns.Remove("tel_paciente")
        dts.Columns.Remove("nome_mae_paciente")
        dts.Columns.Remove("CPF_paciente")
        dts.Columns.Remove("RG_paciente")
        dts.Columns.Remove("FKcod_microarea")
        con._AbreConexao()
        con._PreencheDataTable(dts, SQL)
        con._FechaConexao()
        Return dts
    End Function
    Public Sub Seleciona(ByVal codigo As Integer)
        Dim SQL As String = "SELECT * FROM tb_paciente where cod_paciente=" + codigo.ToString() + " order by cod_paciente;"
        Dim con As New conexaoSQLServer()
        Dim dts As New dtsBD_SICEP.tb_pacienteDataTable()

        con._AbreConexao()
        con._PreencheDataTable(dts, SQL)

        _codigo = dts(0).cod_paciente
        _dataCadastro = dts(0).data_cad_paciente.ToString()
        _nome = dts(0).nome_paciente
        _endereco = dts(0).end_paciente
        _dataNascimento = dts(0).data_nasc_paciente
        _sexo = dts(0).sexo_paciente
        _telefone = dts(0).tel_paciente
        _mae = dts(0).nome_mae_paciente
        _CPF = dts(0).CPF_paciente
        _RG = dts(0).RG_paciente
        _cod_microarea = dts(0).FKcod_microarea

        con._FechaConexao()
    End Sub
#End Region
End Class
