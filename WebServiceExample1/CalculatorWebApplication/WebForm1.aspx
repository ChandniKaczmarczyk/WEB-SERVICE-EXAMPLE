<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>First Number</td>
                <td><asp:TextBox runat="server" ID="txtFirstNumber"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Second Number</td>
                <td><asp:TextBox runat="server" ID="txtSecondNumber"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Result</td>
                <td><asp:Label runat="server" ID="lblResult"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button runat="server" ID="btnResult" Text="Add Numbers" OnClick="btnResult_Click"/></td>
                
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
