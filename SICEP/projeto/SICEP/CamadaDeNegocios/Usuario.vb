Imports AcessoDados.ConexaoComSQLServer
Public Class Usuario : Inherits Pessoa
    Sub New()
    End Sub
#Region "Funções Privadas"
    Private Function BuscaUsuario(ByVal SQL As String) As Boolean
        Dim tbl As New dtsBD_SICEP.tb_usuarioDataTable()
        Dim con As New conexaoSQLServer()
        Dim cripto As New Criptografia()

        con._AbreConexao()
        con._PreencheDataTable(tbl, SQL)
        con._FechaConexao()
        If tbl.Rows.Count > 0 Then
            _codigo = Integer.Parse(tbl(0).cod_usuario)
            _dataCadastro = Date.Parse(tbl(0).data_cad_usuario)
            _nome = tbl(0).nome_usuario
            _cargo = tbl(0).cargo_usuario
            _endereco = tbl(0).end_usuario
            _telRes = tbl(0).tel_res_usuario
            _telCel = tbl(0).tel_cel_usuario
            _email = tbl(0).email_usuario
            _CPF = tbl(0).CPF_usuario
            _RG = tbl(0).RG_usuario
            _login = cripto.Criptografar(tbl(0).login_usuario.ToString(), False)
            _senha = cripto.Criptografar(tbl(0).senha_usuario.ToString(), False)
            _perfil = tbl(0).FKcod_perfil
            Return True
        Else
            Return False
        End If
    End Function
    Private Function BuscaPerfil(ByVal SQL As String) As String
        Dim tbl As New dtsBD_SICEP.tb_perfilDataTable()
        Dim con As New conexaoSQLServer()

        con._AbreConexao()
        con._PreencheDataTable(tbl, SQL)
        con._FechaConexao()

        Return tbl(0).nome_perfil.ToString()
    End Function
#End Region
#Region "Variaveis Privadas"
    Private _cargo As String = String.Empty
    Private _telRes As String = String.Empty
    Private _telCel As String = String.Empty
    Private _email As String = String.Empty
    Private _login As String = String.Empty
    Private _senha As String = String.Empty
    Private _perfil As Integer
#End Region
#Region "Propriedades - SET e GET"

    Public Property Cargo() As String
        Get
            Return _cargo
        End Get
        Set(ByVal value As String)
            _cargo = value
        End Set
    End Property
    Public Property TelResidencial() As String
        Get
            Return _telRes
        End Get
        Set(ByVal value As String)
            _telRes = value
        End Set
    End Property
    Public Property TelCelular() As String
        Get
            Return _telCel
        End Get
        Set(ByVal value As String)
            _telCel = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property
    Public Property Login() As String
        Get
            Return _login
        End Get
        Set(ByVal value As String)
            _login = value
        End Set
    End Property
    Public Property Senha() As String
        Get
            Return _senha
        End Get
        Set(ByVal value As String)
            _senha = value
        End Set
    End Property
    Public Property Perfil() As Integer
        Get
            Return _perfil
        End Get
        Set(ByVal value As Integer)
            _perfil = value
        End Set
    End Property
#End Region
#Region "Métodos"
    Public Function VerificaUsuario(ByVal login As String, ByVal senha As String) As Boolean
        Dim SQL As String = "SELECT * from tb_usuario where" & _
        " login_usuario='" & login & "' and senha_usuario='" & senha & "';"
        Dim resultado As Boolean = BuscaUsuario(SQL)
        Return resultado
    End Function
    Public Function VerificaUsuario() As Boolean
        If _login <> String.Empty And _senha <> String.Empty Then
            Dim SQL As String = "SELECT * from tb_usuario where" & _
            " login_usuario='" + _login + "' and senha_usuario='" + _senha + "';"

            Dim resultado As Boolean = BuscaUsuario(SQL)
            Return resultado
        Else
            Return False
        End If
    End Function
    Public Function GetNomePerfil(ByVal codigo As Integer) As String
        Dim SQL As String = "SELECT * from tb_perfil where cod_perfil=" & codigo & ";"
        Dim NomePerfil As String = BuscaPerfil(SQL)
        Return NomePerfil
    End Function
    Public Function GetNomePerfil() As String
        Dim SQL As String = "SELECT * from tb_perfil where cod_perfil=" & _perfil & ";"
        Dim NomePerfil As String = BuscaPerfil(SQL)
        Return NomePerfil
    End Function
    Public Function SelecionaPerfil() As dtsBD_SICEP.tb_perfilDataTable
        Dim SQL As String = "SELECT * from tb_perfil;"
        Dim tbl As New dtsBD_SICEP.tb_perfilDataTable()
        Dim con As New conexaoSQLServer()
        con._AbreConexao()
        con._PreencheDataTable(tbl, SQL)
        con._FechaConexao()
        Return tbl
    End Function
    Public Function SelecionaPorNome(ByVal nome As String, ByVal codUsuarioLogado As Integer) As dtsBD_SICEP.tb_usuarioDataTable
        Dim SQL As String = "SELECT cod_usuario, nome_usuario from tb_usuario where nome_usuario like '" + nome + "%' and cod_usuario<>6 and cod_usuario<>" + codUsuarioLogado.ToString() + " order by nome_usuario;"
        Dim tbl As New dtsBD_SICEP.tb_usuarioDataTable()
        tbl.Columns.Remove("cargo_usuario")
        tbl.Columns.Remove("end_usuario")
        tbl.Columns.Remove("tel_res_usuario")
        tbl.Columns.Remove("tel_cel_usuario")
        tbl.Columns.Remove("email_usuario")
        tbl.Columns.Remove("CPF_usuario")
        tbl.Columns.Remove("RG_usuario")
        tbl.Columns.Remove("login_usuario")
        tbl.Columns.Remove("senha_usuario")
        tbl.Columns.Remove("data_cad_usuario")
        tbl.Columns.Remove("FKcod_perfil")
        Dim con As New conexaoSQLServer()
        con._AbreConexao()
        con._PreencheDataTable(tbl, Sql)
        con._FechaConexao()
        Return tbl
    End Function
    Public Function SelecionaPorNome(ByVal nome As String) As dtsBD_SICEP.tb_usuarioDataTable
        Dim SQL As String = "SELECT cod_usuario, nome_usuario from tb_usuario where nome_usuario like '" + nome + "%' and cod_usuario<>6 order by nome_usuario;"
        Dim tbl As New dtsBD_SICEP.tb_usuarioDataTable()
        tbl.Columns.Remove("cargo_usuario")
        tbl.Columns.Remove("end_usuario")
        tbl.Columns.Remove("tel_res_usuario")
        tbl.Columns.Remove("tel_cel_usuario")
        tbl.Columns.Remove("email_usuario")
        tbl.Columns.Remove("CPF_usuario")
        tbl.Columns.Remove("RG_usuario")
        tbl.Columns.Remove("login_usuario")
        tbl.Columns.Remove("senha_usuario")
        tbl.Columns.Remove("data_cad_usuario")
        tbl.Columns.Remove("FKcod_perfil")
        Dim con As New conexaoSQLServer()
        con._AbreConexao()
        con._PreencheDataTable(tbl, SQL)
        con._FechaConexao()
        Return tbl
    End Function
    Public Function SelecionaPorCodigo(ByVal codigo As Integer)
        Dim SQL As String = "SELECT * from tb_usuario where cod_usuario=" + codigo.ToString() + ";"
        Dim resultado As Boolean = BuscaUsuario(SQL)
        Return resultado
    End Function
    Public Function TestaLogin(ByVal login As String) As Boolean
        Dim con As New conexaoSQLServer()
        Dim tbl As New dtsBD_SICEP.tb_usuarioDataTable()
        Dim cripto As New Criptografia()
        login = cripto.Criptografar(login, True)
        Dim SQL As String = "SELECT * from tb_usuario where login_usuario='" + login + "';"
        con._AbreConexao()
        con._PreencheDataTable(tbl, SQL)
        con._FechaConexao()
        If tbl.Rows.Count <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function TestaLoginAltera(ByVal login As String, ByVal codigo As Integer) As Boolean
        Dim con As New conexaoSQLServer()
        Dim tbl As New dtsBD_SICEP.tb_usuarioDataTable()
        Dim cripto As New Criptografia()
        login = cripto.Criptografar(login, True)
        Dim SQL As String = "SELECT * from tb_usuario where cod_usuario<>" + codigo.ToString() + " and login_usuario ='" + login + "';"
        con._AbreConexao()
        con._PreencheDataTable(tbl, SQL)
        con._FechaConexao()
        If tbl.Rows.Count <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Overrides Function Salvar() As Boolean
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP()
            Dim cripto As New Criptografia()
            Dim CLogin As String = cripto.Criptografar(_login, True)
            Dim CSenha As String = cripto.Criptografar(_senha, True)
            sp.sp_INSERE_USUARIO(_nome, _cargo, _endereco, _telRes, _telCel, _email, _CPF, _RG, CLogin, CSenha, _perfil)
            Return True
        Catch ex As Exception
            Throw New Exception("Não foi possível conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
            Return False
        End Try
    End Function
    Public Overrides Function Alterar() As Boolean
        Try
            Dim sp As New dtsBD_SICEPTableAdapters.spBD_SICEP()
            Dim cripto As New Criptografia()
            Dim CLogin As String = cripto.Criptografar(_login, True)
            Dim CSenha As String = cripto.Criptografar(_senha, True)
            sp.sp_ALTERA_USUARIO(_codigo, _nome, _cargo, _endereco, _telRes, _telCel, _email, _CPF, _RG, CLogin, CSenha, _perfil)
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
            sp.sp_DELETA_USUARIO(_codigo, saida)
            Return saida
        Catch ex As Exception
            Throw New Exception("Não foi possível conectar ao seu banco de dados pelo seguinte erro: " + ex.Message)
            Return "Não foi possível excluir este usuário!"
        End Try
    End Function
#End Region

End Class
