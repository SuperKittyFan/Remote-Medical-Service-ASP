<%@ Page language="c#" Codebehind="bedzhao.aspx.cs" AutoEventWireup="false" Inherits="ҽԺ����ϵͳ.bedzhao" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>bedzhao</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="����">
				<TABLE id="Table1" align="center" width="70%" height="0" cellSpacing="1" cellPadding="1"
					border="1">
					<TR>
						<TD align="center" style="HEIGHT: 27px">
							<asp:Image id="Image1" runat="server" Width="637px" Height="80px" ImageUrl="img/6.jpg"></asp:Image></TD>
					</TR>
					<TR>
						<TD align="center">
							�Һź��룺
							<asp:TextBox id="tnum" runat="server" Width="100px"></asp:TextBox>����:
							<asp:TextBox id="tname" runat="server" Width="91px"></asp:TextBox>����ʵ����
							<asp:DropDownList id="d1" runat="server" Width="51px">
								<asp:ListItem Value="��Ժ">��Ժ</asp:ListItem>
								<asp:ListItem Value="��Ժ">��Ժ</asp:ListItem>
							</asp:DropDownList>
							<asp:Button id="button1" runat="server" Text="����"></asp:Button>
							<asp:Button id="Button3" runat="server" Text="ɾ��"></asp:Button>
							<asp:Button id="Button2" runat="server" Text="����"></asp:Button></TD>
					</TR>
					<TR>
						<TD>
							<asp:DataGrid id="DataGrid1" Width ="100%" runat="server" BorderColor="White" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal" DataSource="<%# allpepole1 %>" DataKeyField="����" DataMember="Table" AutoGenerateColumns="False" PageSize="20" AllowPaging="True">
								<SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
								<AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
								<ItemStyle ForeColor="Black" BackColor="AntiqueWhite"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="Teal"></HeaderStyle>
								<FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
								<Columns>
									<asp:BoundColumn DataField="�Һź���" HeaderText="�Һź���"></asp:BoundColumn>
									<asp:BoundColumn DataField="����" HeaderText="����"></asp:BoundColumn>
									<asp:BoundColumn DataField="����" HeaderText="����"></asp:BoundColumn>
									<asp:BoundColumn DataField="�Ա�" HeaderText="�Ա�"></asp:BoundColumn>
									<asp:BoundColumn DataField="����" HeaderText="����"></asp:BoundColumn>
									<asp:BoundColumn DataField="����" HeaderText="����"></asp:BoundColumn>
									<asp:BoundColumn DataField="����ʵ��" SortExpression="����ʵ��" HeaderText="����ʵ��"></asp:BoundColumn>
									<asp:ButtonColumn Text="ѡ��" HeaderText="ɾ������" CommandName="Select"></asp:ButtonColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Center" ForeColor="#4A3C8C" BackColor="MistyRose" Mode="NumericPages"></PagerStyle>
							</asp:DataGrid></TD>
					</TR>
				</TABLE>
			</FONT>
		</form>
	</body>
</HTML>
