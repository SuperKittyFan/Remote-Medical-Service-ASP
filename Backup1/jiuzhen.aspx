<%@ Page language="c#" Codebehind="jiuzhen.aspx.cs" AutoEventWireup="false" Inherits="ҽԺ����ϵͳ.jiuzhen" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>jiuzhen</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<FONT class="sd2" face="����">
				<TABLE id="Table4" height="0" cellSpacing="1" cellPadding="1" width="736" align="center"
					border="1">
					<TR>
						<TD align="center"><asp:image id="Image1" runat="server" Height="72px" Width="768px" ImageUrl="img/4.jpg"></asp:image></TD>
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
								<TABLE id="Table1" style="WIDTH: 651px; HEIGHT: 876px" cellSpacing="1" cellPadding="1"
									width="651" align="center" bgColor="#ffffff" border="1">
									<TR>
										<TD style="WIDTH: 126px">���˼���Ϣ��</TD>
										<TD>
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
										<TD style="WIDTH: 126px; HEIGHT: 38px">�Ƿ�סԺ��</TD>
										<TD style="HEIGHT: 38px">
											<asp:radiobuttonlist id="r1" runat="server" Width="136px" Height="8px" BorderStyle="None" CellPadding="0"
												RepeatDirection="Horizontal" CellSpacing="0">
												<asp:ListItem Value="סԺ">סԺ</asp:ListItem>
												<asp:ListItem Value="��סԺ">��סԺ</asp:ListItem>
											</asp:radiobuttonlist></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 126px; HEIGHT: 18px">�Ƿ�������</TD>
										<TD style="HEIGHT: 18px">
											<asp:radiobuttonlist id="r2" runat="server" Width="208px" Height="24px" RepeatDirection="Horizontal">
												<asp:ListItem Value="��Ҫ����">��Ҫ����</asp:ListItem>
												<asp:ListItem Value="����Ҫ����">����Ҫ����</asp:ListItem>
											</asp:radiobuttonlist></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 126px">�Ƿ������飺</TD>
										<TD>
											<asp:dropdownlist id="d1" runat="server" Width="80px" Height="32px" ForeColor="Red">
												<asp:ListItem Value="����Ҫ">����Ҫ</asp:ListItem>
												<asp:ListItem Value="��ά�ڿ���ʵ��">��ά�ڿ���ʵ��</asp:ListItem>
												<asp:ListItem Value="CTͼ">CTͼ</asp:ListItem>
												<asp:ListItem Value="B��">B��</asp:ListItem>
												<asp:ListItem Value="��Ѫ">��Ѫ</asp:ListItem>
												<asp:ListItem Value="���԰�ʵ��">���԰�ʵ��</asp:ListItem>
												<asp:ListItem Value="����ʵ��">����ʵ��</asp:ListItem>
												<asp:ListItem Value="�Ե�ͼ">�Ե�ͼ</asp:ListItem>
											</asp:dropdownlist></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 126px">��ϲ�����</TD>
										<TD>
											<asp:textbox id="tbk" runat="server" Width="504px" Height="190px" TextMode="MultiLine" DESIGNTIMEDRAGDROP="70"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 126px">������ҩ����</TD>
										<TD>
											<P>
												<asp:textbox id="tyf" runat="server" Width="502px" Height="204px" TextMode="MultiLine"></asp:textbox></P>
											<P><STRONG>������</STRONG>
												<asp:textbox id="ttj" runat="server" Width="472px" TextMode="MultiLine"></asp:textbox></P>
											<P><STRONG>���ˣ�</STRONG>
												<asp:textbox id="tfh" runat="server" Width="472px" TextMode="MultiLine"></asp:textbox></P>
										</TD>
									</TR>
									<TR>
										<TD style="IGHT: 12px" align="left" colSpan="2"></TD>
									</TR>
									<TR>
										<TD align="right" colSpan="2"><STRONG><FONT color="#ff0033">���ҽʦ��</FONT></STRONG>
											<asp:dropdownlist id=d2 runat="server" Width="104px" Height="25px" DataMember="Table" DataSource="<%# ds31 %>" DataTextField="����">
											</asp:dropdownlist></TD>
									</TR>
									<TR>
										<TD align="right" colSpan="2"></TD>
									</TR>
									<TR>
										<TD align="center" colSpan="2">&nbsp;
											<asp:Button id="Button2" runat="server" Width="56px" Height="22px" Text="ȷ��"></asp:Button>
											<asp:Button id="Button5" runat="server" Width="83px" Height="22px" Text="���Ѳ����ϴ�"></asp:Button>
											<asp:Button id="Button3" runat="server" Width="56px" Height="22px" Text="����"></asp:Button>
											<asp:Button id="Button4" runat="server" Width="60px" Height="22px" Text="������ҳ"></asp:Button></TD>
									</TR>
								</TABLE>
							</asp:panel></TD>
					</TR>
				</TABLE>
			</FONT>
		</form>
	</body>
</HTML>
