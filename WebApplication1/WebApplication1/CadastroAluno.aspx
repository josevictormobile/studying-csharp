<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroAluno.aspx.cs" Inherits="WebApplication1.CadastroAluno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Nome<br />
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        Matrícula<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Nota 01<asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" style="margin-left: 10px"></asp:TextBox>
        <br />
        Nota 02<asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox3_TextChanged" style="margin-left: 10px"></asp:TextBox>
        <br />
        Nota 03<asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox3_TextChanged" style="margin-left: 10px"></asp:TextBox>
        <br />
        Nota 04<asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox3_TextChanged" style="margin-left: 10px"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cadastrar" />
        </p>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
    </form>
</body>
</html>
