Imports System.Security.Cryptography
Imports System.Text

Public Class Criptografia
    Dim chave As String
    Dim des As New TripleDESCryptoServiceProvider()
    Dim hashmd5 As New MD5CryptoServiceProvider()

    Public Sub New()
        'Inserir o codigo de configuração da classe
        chave = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
    End Sub

    Public Function Criptografar(ByVal texto As String, ByVal Operacao As Boolean) As String
        If Operacao Then
            Criptografar = Cifra(texto)
        Else
            Criptografar = DeCifra(texto)
        End If
    End Function

    Private Function DeCifra(ByVal texto As String) As String
        des.Key = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(chave))
        des.Mode = CipherMode.ECB
        Dim desdencrypt As ICryptoTransform = des.CreateDecryptor()
        Dim buff() As Byte = Convert.FromBase64String(texto)
        DeCifra = ASCIIEncoding.ASCII.GetString(desdencrypt.TransformFinalBlock(buff, 0, buff.Length))
    End Function

    Private Function Cifra(ByVal texto As String) As String
        des.Key = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(chave))
        des.Mode = CipherMode.ECB
        Dim desdencrypt As ICryptoTransform = des.CreateEncryptor()
        Dim MyASCIIEncoding = New ASCIIEncoding()
        Dim buff() As Byte = ASCIIEncoding.ASCII.GetBytes(texto)
        Cifra = Convert.ToBase64String(desdencrypt.TransformFinalBlock(buff, 0, buff.Length))
    End Function


End Class
