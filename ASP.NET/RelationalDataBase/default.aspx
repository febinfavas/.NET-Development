<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="RelationalDataBase._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT Fans.ID, Fans.FavoriteSong, Fans.Comments, Fans.Name, AlbumTracks.AlbumNumber, AlbumTracks.TrackNumber, AlbumTracks.[Album Name], AlbumTracks.TrackName FROM (Fans INNER JOIN AlbumTracks ON Fans.FavoriteSong = AlbumTracks.TrackName) ORDER BY AlbumTracks.AlbumNumber"></asp:SqlDataSource>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
