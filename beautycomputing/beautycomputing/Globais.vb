Imports System.Runtime.InteropServices
'Importando conteudo de byte e string do BD OLEDB
Imports System.Data
Imports System.Data.OleDb

Module Globais
    Public groupboxmenu As Object
    Public lbltipousuarios As String
    Public formularioAtual As System.Windows.Forms.Form
    'constantes usadas na DLL
    Public Const WM_CAP As Short = &H400S
    Public Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Public Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Public Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Public Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Public Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Public Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Public Const WS_CHILD As Integer = &H40000000
    Public Const WS_VISIBLE As Integer = &H10000000
    Public Const SWP_NOMOVE As Short = &H2S
    Public Const SWP_NOSIZE As Short = 1
    Public Const SWP_NOZORDER As Short = &H4S
    Public Const HWND_BOTTOM As Short = 1

    Public iDevice As Integer = 0 ' ID do dispositivo atual
    Public hHwnd As Integer ' manipulador da janela do visualizador

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Public Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    'A função DestroyWindow destroi a janela especificada.
    'Envia as mensagens WM_DESTROY e WM_NCDESTROY para a 
    'janela para destivá-la e remove o foco do teclado da mesma
    'Library - User32
    'Parametros -  hWnd - (identica a janela a ser destruida)
    'Retorna um valor diferente de zero se for executada com sucesso,
    'caso contrario retorna zero
    Public Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Public Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
        ByVal nHeight As Short, ByVal hWndParent As Integer, _
        ByVal nID As Integer) As Integer

    Public Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
        ByVal cbVer As Integer) As Boolean

    Public conexao As New OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public da As OleDbDataAdapter
    Public datatb As DataTable
    Public DS As DataSet
    Public CManager As CurrencyManager

    Public reg As Integer
    Public flag As Integer
    Public I As Integer
    Public Estado As String

    'Private salvar
    Public Sub SalvarDados()
        'Salva o registro no BD
        Call conexaogeral()
        conexao.Open()
        Try
            cmd.Connection = conexao

            reg = cmd.ExecuteNonQuery()
            MessageBox.Show("Dados Salvos com sucesso", "Inclusão de dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro durante Inclusão!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not conexao Is Nothing Then
                If conexao.State = ConnectionState.Open Then
                    conexao.Close()
                    cmd.Parameters.Clear()
                End If
            End If
        End Try
    End Sub

    'Conexao com o ACCESS estabelecida
    Public Sub conexaogeral()

        'conexao joel
        'conexao = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Joel\Desktop\beautycomputing\bdestetica.mdb")

        'conexao casa
        'conexao = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Edu\Desktop\beautycomputing\bdestetica.mdb")

        'conexão etec
        conexao = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TCC Oficial\beautycomputing\bdestetica.mdb")

    End Sub

    'Local onde as fotos são salva Casa
    'Public LocalFotosclientes As String = "C:\Users\Edu\Desktop\beautycomputing\cliente"
    'Public LocalFotosaluno As String = "C:\Users\Edu\Desktop\beautycomputing\aluno"
    'Public LocalFotosfuncionario As String = "C:\Users\Edu\Desktop\beautycomputing\funcionario"


    'Local onde as fotos são salvas joel
    'Public LocalFotosclientes As String = "C:\Users\Joel\Desktop\beautycomputing\cliente"
    'Public LocalFotosaluno As String = "C:\Users\Joel\Desktop\beautycomputing\aluno"
    'Public LocalFotosfuncionario As String = "C:\Users\Joel\Desktop\beautycomputing\funcionario"


    'Local onde as fotos são salva ETEC
    Public LocalFotosclientes As String = "D:\TCC Oficial\beautycomputing\cliente"
    Public LocalFotosaluno As String = "D:\TCC Oficial\beautycomputing\aluno"
    Public LocalFotosfuncionario As String = "D:\TCC Oficial\beautycomputing\funcionario"
End Module
