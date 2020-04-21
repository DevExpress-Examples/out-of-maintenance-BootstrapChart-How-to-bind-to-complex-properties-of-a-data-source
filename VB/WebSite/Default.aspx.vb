Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim list As IEnumerable(Of CountryInfo) = CountriesDS.Select().Cast(Of CountryInfo)()
		StatesChart.DataSource = list.Select(Function(obj) New With {
			Key .Name = obj.Name,
			Key .Gold = obj.Info.Gold,
			Key .Silver = obj.Info.Silver,
			Key .Bronze = obj.Info.Bronze
		})
		StatesChart.DataBind()
	End Sub
End Class