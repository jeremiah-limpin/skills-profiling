Imports System.Data.OleDb

Public Class SkillsProfile_Database
    ' 
    ' Private Shared connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eleazar Villareal\source\repos\Skills Profiling\Skills Profiling\SkillsProfiling_Database.accdb;"
    Private Shared connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\Backroom_NAS\SkillsProfiling\Database\SkillsProfiling_Database.accdb"

    Private Shared connection As New OleDbConnection(connectionString)

    Public Shared Function GetConnection() As OleDbConnection
        Return connection
    End Function
End Class


