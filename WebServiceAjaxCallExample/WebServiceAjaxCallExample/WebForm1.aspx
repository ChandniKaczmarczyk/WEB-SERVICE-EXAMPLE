<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebServiceAjaxCallExample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <title></title>
    <script type="text/javascript" language="javascript">

        function GetStudentsById() {
            var id = document.getElementById("txtId").value;
            WebServiceAjaxCallExample.StudentService.GetStudentInformation(id, GetStudentSuccess,GetStudentError);

        }
        function GetStudentSuccess(result) {
            document.getElementById("txtname").value = result["NAME"];
            document.getElementById("txtgender").value = result["GENDER"];
        }

        function GetStudentError(error) {
            alert(error.get_message());
            
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
                <Services>
                    <asp:ServiceReference Path="~/StudentService.asmx" />
                </Services>
            </asp:ScriptManager>
            <table style="border: 1px solid brown; ">
                <tr>
                    <td>ID</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;<input id="Button1" type="button" value="Student Information" onclick="GetStudentsById()" /></td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:TextBox ID="txtgender" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <b> The time below will not change when we click on Student Information button because we are doing asynchronous call</b>
            <div><asp:Label runat="server" ID="lbltime"></asp:Label></div>
        </div>
    </form>
</body>
</html>
