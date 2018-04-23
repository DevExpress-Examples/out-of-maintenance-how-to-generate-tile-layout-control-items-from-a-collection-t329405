Imports System.Collections.Generic
Imports System.IO

Namespace DXLayoutControlSample
    Public Class DataSource
        Public Property Items() As List(Of TileItem)
        Public Sub New()
            Items = New List(Of TileItem)()
            Items.Add(New TileItem With {.Header = "UserManagment", .Content = GetImage("UserManagment.png"), .IsSmall = True, .Category = TileItem.System})
            Items.Add(New TileItem With {.Header = "System", .Content = GetImage("System.png"), .IsSmall = True, .Category = TileItem.System})
            Items.Add(New TileItem With {.Header = "Research", .Content = GetImage("Research.png"), .IsSmall = True, .Category = TileItem.System})
            Items.Add(New TileItem With {.Header = "Statistics", .Content = GetImage("Statistics.png"), .IsNewGroup = True, .Category = TileItem.Tools})
            Items.Add(New TileItem With {.Header = "Calc", .Content = GetImage("Calc.png"), .IsSmall = True, .Category = TileItem.Tools})
            Items.Add(New TileItem With {.Header = "Rates", .Content = GetImage("Rates.png"), .IsSmall = True, .Category = TileItem.Tools})
        End Sub
        Private Function GetImage(ByVal name As String) As Byte()
            Return File.ReadAllBytes("Images\" & name)
        End Function
    End Class
    Public Class TileItem
        Public Property Header() As String
        Public Property Content() As Object
        Public Property IsNewGroup() As Boolean
        Public Property IsSmall() As Boolean
        Public Property Category() As String

        Public Const System As String = "System"
        Public Const Tools As String = "Tools"
    End Class
End Namespace