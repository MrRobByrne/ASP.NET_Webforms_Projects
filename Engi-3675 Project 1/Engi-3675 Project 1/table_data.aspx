<%@ page language="C#" %>
<%@ import namespace="paintmodelASP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="paintmodel.cs"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <table >
        <tr style="background-color:#004080;color:White;" >
            <td> Paint_Name </td>                        
            <td> Quantity </td>                                 
        </tr>

<% Response.Write(Paint_input.getWhileLoopData());%>

    </table>

    </div>
    </form>
</body>
</html>