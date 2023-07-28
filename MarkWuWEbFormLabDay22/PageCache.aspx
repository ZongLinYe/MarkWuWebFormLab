<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageCache.aspx.cs" Inherits="MarkWuWEbFormLabDay22.PageCache" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True"></asp:GridView>
          <%--  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="StudentId" HeaderText="Student ID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Age" HeaderText="Age" />
                </Columns>
            </asp:GridView>
            <input type="button" value="Load Data" onclick="loadData()" />--%>
        </div>
    </form>

    <script type="text/javascript">
            function loadData() {
                // 模擬從伺服器獲取資料
                var data = [
                    { StudentId: 1, Name: "John", Age: 25 },
                    { StudentId: 2, Name: "Jane", Age: 22 },
                    { StudentId: 3, Name: "Michael", Age: 28 }
                ];

                // 將資料設置給 GridView
                var gridView = document.getElementById('<%= GridView1.ClientID %>');
                gridView.innerHTML = '<tr><th>Student ID</th><th>Name</th><th>Age</th></tr>';
                for (var i = 0; i < data.length; i++) {
                    gridView.innerHTML += '<tr><td>' + data[i].StudentId + '</td><td>' + data[i].Name + '</td><td>' + data[i].Age + '</td></tr>';
                }
            }
     </script>
</body>
</html>
