<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v19.2, Version=19.2.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
</head>
<body>
    <form id="form1" runat="server">
        <dx:BootstrapChart ID="StatesChart" runat="server" TitleSettings-Text="States Information" Rotated="true" CustomPalette="#ffd700, #c0c0c0, #cd7f32">
            <TitleSettings Text="Olympic Medals in 2016"></TitleSettings>
            <SettingsCommonSeries ArgumentField="Name">
                <Label Visible="true"></Label>
            </SettingsCommonSeries>
            <SeriesCollection>
                <dx:BootstrapChartStackedBarSeries ValueField="Gold" Name="Gold Medals" />
                <dx:BootstrapChartStackedBarSeries ValueField="Silver" Name="Silver Medals" />
                <dx:BootstrapChartStackedBarSeries ValueField="Bronze" Name="Bronze Medals" />
            </SeriesCollection>
        </dx:BootstrapChart>

        <asp:ObjectDataSource ID="CountriesDS" runat="server" SelectMethod="GetList"
            TypeName="DSProvider" DataObjectTypeName="CountryInfo"></asp:ObjectDataSource>
    </form>
</body>
</html>
