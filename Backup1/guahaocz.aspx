<%@ Page language="c#" Codebehind="guahaocz.aspx.cs" AutoEventWireup="false" Inherits="ҽԺ����ϵͳ.guahaocz" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>guahaocz</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="����">
				<TABLE id="Table1" align="center" cellSpacing="1" cellPadding="1" width="698" border="1"
					style="WIDTH: 698px; HEIGHT: 66px">
					<TR>
						<TD align="center">
							<asp:Image id="Image1" runat="server" Width="719px" Height="72px" ImageUrl="img/7.jpg"></asp:Image></TD>
					</TR>
					<TR>
						<TD align="center">�Һź���
							<asp:TextBox id="tnum" runat="server" Width="120px"></asp:TextBox>����
							<asp:TextBox id="tname" runat="server" Width="112px"></asp:TextBox>
							<asp:Button id="Button1" runat="server" Text="��ѯ"></asp:Button>
							<asp:Button id="Button3" runat="server" Text="ɾ��"></asp:Button>
							<asp:Button id="Button2" runat="server" Width="39px" Text="����"></asp:Button></TD>
					</TR>
					<TR>
						<TD align="center">
							<asp:DataGrid id="DataGrid1" Width="721px" runat="server" BorderColor="#336666" BorderStyle="Double"
								BorderWidth="3px" BackColor="White" CellPadding="4" GridLines="Horizontal" DataSource="<%# guacz1 %>" DataKeyField="�Һź���" DataMember="Table" AutoGenerateColumns="False" AllowPaging="True">
								<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#339966"></SelectedItemStyle>
								<ItemStyle ForeColor="#333333" BackColor="White"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#336666"></HeaderStyle>
								<FooterStyle ForeColor="#333333" BackColor="White"></FooterStyle>
								<Columns>
									<asp:BoundColumn DataField="�Һź���" HeaderText="�Һź���"></asp:BoundColumn>
									<asp:BoundColumn DataField="����" HeaderText="����"></asp:BoundColumn>
									<asp:BoundColumn DataField="����" HeaderText="����"></asp:BoundColumn>
									<asp:BoundColumn DataField="�Ա�" HeaderText="�Ա�"></asp:BoundColumn>
									<asp:BoundColumn DataField="����" HeaderText="����"></asp:BoundColumn>
									<asp:BoundColumn DataField="�Һŷ���" HeaderText="�Һŷ���"></asp:BoundColumn>
									<asp:BoundColumn DataField="����" HeaderText="����"></asp:BoundColumn>
									<asp:BoundColumn DataField="��ַ" HeaderText="��ַ"></asp:BoundColumn>
									<asp:BoundColumn DataField="����" HeaderText="����"></asp:BoundColumn>
									<asp:ButtonColumn Text="ѡ��" HeaderText="ɾ������" CommandName="Select"></asp:ButtonColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#336666" Mode="NumericPages"></PagerStyle>
							</asp:DataGrid></TD>
					</TR>
				</TABLE>
			</FONT>
		</form>
	</body>
</HTML>
