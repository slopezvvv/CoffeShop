<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CoffeShop.index" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="js/scripts.js"></script>
    <style type="text/css">
        #background-cafe {
            position:fixed;
            min-width: 320px;
            min-height: 480px;
            width:100%;
            height:100%;
            background-image: url('imagenes/cafe.jpeg');
            z-index:-99;
            background-size: cover;
        }
        .la_hora{
            color:#ffffff;
            font-size:64px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="background-cafe">
        <asp:Label ID="_laHora" runat="server" CssClass="la_hora" Text="00:00:00"></asp:Label>
        </div>
    </form>
</body>
</html>
