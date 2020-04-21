Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.SessionState


Public Class MedalInfo
	Public Property Gold() As Integer
	Public Property Silver() As Integer
	Public Property Bronze() As Integer
End Class
Public Class CountryInfo
	Public Property Name() As String
	Public Property Info() As MedalInfo
End Class

Public Class DSProvider
	Private ReadOnly Property Session() As HttpSessionState
		Get
			Return HttpContext.Current.Session
		End Get
	End Property
	Private Const SessionKey As String = "DSProviderData"

	Public Function GetList() As List(Of CountryInfo)
		If Session(SessionKey) Is Nothing Then
			Session(SessionKey) = CreateData()
		End If
		Return DirectCast(Session(SessionKey), List(Of CountryInfo))
	End Function
	Private Function CreateData() As List(Of CountryInfo)
		Dim list As New List(Of CountryInfo)()
		list.Add(New CountryInfo With {
			.Name = "USA", .Info = New MedalInfo With {.Gold = 46, .Silver = 37, .Bronze = 38}
		})
		list.Add(New CountryInfo With {
			.Name = "Britain", .Info = New MedalInfo With {.Gold = 27, .Silver = 23, .Bronze = 17}
		})
		list.Add(New CountryInfo With {
			.Name = "China", .Info = New MedalInfo With {.Gold = 26, .Silver = 18, .Bronze = 26}
		})
		list.Add(New CountryInfo With {
			.Name = "Russia", .Info = New MedalInfo With {.Gold = 19, .Silver = 17, .Bronze = 19}
		})
		list.Add(New CountryInfo With {
			.Name = "Germany", .Info = New MedalInfo With {.Gold = 17, .Silver = 10, .Bronze = 15}
		})
		list.Add(New CountryInfo With {
			.Name = "Japan", .Info = New MedalInfo With {.Gold = 12, .Silver = 8, .Bronze = 21}
		})
		Return list
	End Function
End Class