<%@ Page language="c#" Codebehind="nanzhao.aspx.cs" AutoEventWireup="false" Inherits="ҽԺ����ϵͳ.nanzhao" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>nanzhao</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="����">
				<TABLE id="Table1" align="center" cellSpacing="1" cellPadding="1" width="80%" border="1">
					<TR>
						<TD style="HEIGHT: 60px" align="center" background="img/9.jpg" bgColor="#ffcc66"><FONT face="���Ĳ���" color="#663366" size="7"><STRONG>���Ѳ�����ʾ</STRONG></FONT>&nbsp;</TD>
					</TR>
					<TR>
						<TD>
							<asp:datagrid id=DataGrid1 runat="server" Width="100%" AllowPaging="True" DataSource="<%# nan1 %>" DataKeyField="�Һź���" DataMember="Table" AutoGenerateColumns="False" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="3">
								<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
								<ItemStyle ForeColor="#000066"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
								<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
								<Columns>
									<asp:BoundColumn DataField="�Һź���" HeaderText="�Һź���"></asp:BoundColumn>
									<asp:BoundColumn DataField="����" HeaderText="����"></asp:BoundColumn>
									<asp:BoundColumn DataField="�Ա�" HeaderText="�Ա�"></asp:BoundColumn>
									<asp:BoundColumn DataField="����" HeaderText="����"></asp:BoundColumn>
									<asp:BoundColumn DataField="���Ѳ���" HeaderText="���Ѳ���"></asp:BoundColumn>
									<asp:BoundColumn DataField="����ҩ��" SortExpression="����ҩ��" HeaderText="����ҩ��"></asp:BoundColumn>
									<asp:BoundColumn DataField="ҽʦ" HeaderText="ҽʦ"></asp:BoundColumn>
									<asp:BoundColumn DataField="�ϴ�����" HeaderText="�ϴ�����"></asp:BoundColumn>
									<asp:ButtonColumn Text="ѡ��" CommandName="Select"></asp:ButtonColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Center" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
							</asp:datagrid></TD>
					</TR>
					<TR>
						<TD align="center">&nbsp; �Һź���
							<asp:textbox id="TextBox1" runat="server" Width="120px"></asp:textbox>
							<asp:button id="Button1" runat="server" Text="����"></asp:button>
							<asp:button id="Button2" runat="server" Text="��ϸ��Ϣ"></asp:button>
							<asp:Button id="Button3" runat="server" Text="����"></asp:Button></TD>
					</TR>
					<TR>
						<TD>&nbsp;
							<asp:panel id="p1" Width="749px" Visible="False" Runat="server">
								<TABLE id="Table2" style="WIDTH: 657px; HEIGHT: 506px" height="0" cellSpacing="1" cellPadding="1"
									width="657" align="center" border="1">
									<TR>
										<TD style="HEIGHT: 1px" align="center" colSpan="2">
											<asp:Label id="Label14" runat="server" Width="236px" ForeColor="Red"></asp:Label></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 103px; HEIGHT: 7px">�Һź��룺</TD>
										<TD style="HEIGHT: 7px">
											<asp:label id="Label1" runat="server" Width="272px"></asp:label></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 103px; HEIGHT: 3px">������</TD>
										<TD style="HEIGHT: 3px">
											<asp:label id="Label2" runat="server" Width="248px"></asp:label></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 103px; HEIGHT: 10px">���䣺</TD>
										<TD style="HEIGHT: 10px">
											<asp:label id="Label3" runat="server" Width="304px"></asp:label></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 103px; HEIGHT: 4px">�Ա�</TD>
										<TD style="HEIGHT: 4px">
											<asp:label id="Label4" runat="server" Width="288px"></asp:label></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 103px; HEIGHT: 100px">���Ѳ�����</TD>
										<TD style="HEIGHT: 100px">
											<asp:label id="Label5" runat="server" Width="520px" Height="206px"></asp:label></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 103px; HEIGHT: 138px">����ҩ�</TD>
										<TD style="HEIGHT: 138px">
											<asp:label id="Label6" runat="server" Width="552px" Height="174px"></asp:label></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 103px; HEIGHT: 2px">ҽʦ��</TD>
										<TD style="HEIGHT: 2px">
											<asp:label id="Label7" runat="server" Width="184px"></asp:label></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 103px; HEIGHT: 34px">���ڣ�</TD>
										<TD style="HEIGHT: 34px">
											<asp:label id="Label8" runat="server" Width="448px"></asp:label></TD>
									</TR>
								</TABLE>
							</asp:panel></TD>
					</TR>
					<TR>
						<TD>&nbsp;
						</TD>
					</TR>
				</TABLE>
			</FONT>
		</form>
	</body>
</HTML>
