<%@ Page language="c#" Codebehind="nanbing.aspx.cs" AutoEventWireup="false" Inherits="ҽԺ����ϵͳ.nanbing" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>nanbing</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table4" style="Z-INDEX: 101; LEFT: 128px; POSITION: absolute; TOP: 8px" height="0"
				cellSpacing="1" cellPadding="1" width="736" align="center" border="1">
				<TR>
					<TD align="center" bgColor="mintcream"><FONT face="���Ĳ���" color="#006699" size="7"><STRONG>���Ѳ���</STRONG></FONT></TD>
				</TR>
				<TR>
					<TD align="center">
						<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="744" border="0">
							<TR>
								<TD align="center"><STRONG>�Һź��룺
										<asp:textbox id="tnum" runat="server"></asp:textbox><asp:button id="Button1" runat="server" Width="63px" Text="����"></asp:button></STRONG></TD>
							</TR>
							<TR>
								<TD align="center"><asp:datagrid id=DataGrid1 runat="server" Width="739px" CellPadding="3" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#CCCCCC" DataSource="<%# dss1 %>" DataKeyField="�Һź���" DataMember="Table" AutoGenerateColumns="False" AllowPaging="True">
										<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
										<ItemStyle ForeColor="#000066"></ItemStyle>
										<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
										<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
										<Columns>
											<asp:BoundColumn DataField="�Һź���" SortExpression="�Һź���" HeaderText="�Һź���"></asp:BoundColumn>
											<asp:BoundColumn DataField="����" SortExpression="����" HeaderText="����"></asp:BoundColumn>
											<asp:BoundColumn DataField="����" SortExpression="����" HeaderText="����"></asp:BoundColumn>
											<asp:BoundColumn DataField="�Ա�" SortExpression="�Ա�" HeaderText="�Ա�"></asp:BoundColumn>
											<asp:ButtonColumn Text="ѡ��" CommandName="Select"></asp:ButtonColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Center" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
									</asp:datagrid></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD><asp:panel id="p1" Width="768px" Runat="server">
							<TABLE id="Table5" style="WIDTH: 651px; HEIGHT: 440px" cellSpacing="1" cellPadding="1"
								width="651" align="center" bgColor="#ffffff" border="1">
								<TR>
									<TD style="WIDTH: 126px; HEIGHT: 99px">���˼���Ϣ��</TD>
									<TD style="HEIGHT: 99px">
										<TABLE id="Table2" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
											<TR>
												<TD style="WIDTH: 87px">�Һź��룺</TD>
												<TD>
													<asp:TextBox id="tnumber" runat="server" Width="256px"></asp:TextBox></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 87px">��&nbsp;&nbsp;&nbsp; ����</TD>
												<TD>
													<asp:TextBox id="tname" runat="server" Width="256px"></asp:TextBox></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 87px">��&nbsp;&nbsp;&nbsp; ��</TD>
												<TD>
													<asp:TextBox id="tsex" runat="server" Width="256px"></asp:TextBox></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 87px">��&nbsp;&nbsp;&nbsp; �䣺</TD>
												<TD>
													<asp:TextBox id="tage" runat="server" Width="256px"></asp:TextBox></TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
								<TR>
									<TD style="WIDTH: 126px; HEIGHT: 184px"><FONT face="����">���Ѳ���:</FONT></TD>
									<TD style="HEIGHT: 184px">
										<P>
											<asp:textbox id="tbk" runat="server" Height="204px" Width="502px" TextMode="MultiLine"></asp:textbox><FONT face="����"></FONT></P>
									</TD>
								</TR>
								<TR>
									<TD style="WIDTH: 126px; HEIGHT: 184px"><FONT face="����">����ҩ��:</FONT></TD>
									<TD style="HEIGHT: 184px">
										<P>
											<asp:textbox id="tgm" runat="server" Height="170px" Width="502px" TextMode="MultiLine"></asp:textbox><FONT face="����"></FONT></P>
									</TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 21px" align="right" colSpan="2"><STRONG><FONT color="#ff0033">���ҽʦ��</FONT></STRONG>
										<asp:dropdownlist id=d2 runat="server" Height="25px" Width="104px" DataSource="<%# ds31 %>" DataMember="Table" DataTextField="����">
										</asp:dropdownlist></TD>
								</TR>
								<TR>
									<TD align="center" colSpan="2">&nbsp;
										<asp:Button id="Button2" runat="server" Height="22px" Width="56px" Text="ȷ��"></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										<asp:Button id="Button4" runat="server" Height="22px" Width="52px" Text="����"></asp:Button></TD>
								</TR>
							</TABLE>
						</asp:panel></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
