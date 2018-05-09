<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Adodem.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="border: 1px solid black; font-family:Arial">
    <tr>
        <td>
            Employee FirstName
        </td>
        <td>
            <asp:TextBox ID="txtEmployeeFName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Employee LastName
        </td>
        <td>
            <asp:TextBox ID="txtEmployeeLName" runat="server"></asp:TextBox>
        </td>
    </tr> 
    <tr>
        <td>
              Address
        </td>
        <td>
            <textarea id="TextArea1" cols="20" rows="2" runat="server"></textarea>  
        </td>
    </tr>
    <tr>
        <td>
              Phone number
        </td>
        <td>
            <asp:TextBox ID="txtphn" runat="server"></asp:TextBox>  
        </td>
    </tr>       
    <tr>
        <td>
            Gender
        </td>
        <td>
            <asp:DropDownList ID="ddlGender" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr> 

    <tr>
        <td>
              Home Phone number
        </td>
        <td>
            <asp:TextBox ID="hphn" runat="server"></asp:TextBox>  
        </td>
    </tr> 
              
    <tr>
        <td colspan="2">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                onclick="SubmitButton_Click" />
        </td>
    </tr>          
    <tr>
        <td colspan="2">
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </td>
    </tr>  
</table>
    </div>
    </form>
</body>
</html>
