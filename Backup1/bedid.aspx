<%@ Page language="c#" Codebehind="bedid.aspx.cs" AutoEventWireup="false" Inherits="ҽԺ����ϵͳ.bedid" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>bedid</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<FONT id="FONT1" face="����">
				<asp:validationsummary id="ValidationSummary1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 80px"
					runat="server" ShowSummary="False" ShowMessageBox="True"></asp:validationsummary>
				<TABLE id="Table2" height="0" cellSpacing="1" cellPadding="1" width="70%" align="center"
					border="1">
					<TR>
						<TD align="center" colSpan="2" height="0"><FONT face="����"><asp:panel id="p1" Width="376px" Runat="server" Height="262px" Visible="False"><FONT face="����">
										<TABLE id="Table1" style="WIDTH: 355px; HEIGHT: 619px" cellSpacing="1" cellPadding="1"
											width="355" align="center" border="1">
											<TR>
												<TD align="center" colSpan="2">
													<asp:Image id="Image1" runat="server" Height="80px" Width="372px" ImageUrl="img/11.jpg"></asp:Image></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 143px; HEIGHT: 4px">���ţ�</TD>
												<TD style="HEIGHT: 4px">
													<asp:TextBox id="tch" runat="server" Width="200px"></asp:TextBox>
													<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ControlToValidate="tch" ErrorMessage="���Ų���Ϊ��">*</asp:RequiredFieldValidator></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 143px; HEIGHT: 4px">�Һź��룺</TD>
												<TD style="HEIGHT: 4px">
													<asp:TextBox id="tnum" runat="server" Width="200px"></asp:TextBox>
													<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="tnum" ErrorMessage="�Һź��벻��Ϊ��">*</asp:RequiredFieldValidator></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 143px">������</TD>
												<TD>
													<asp:TextBox id="tname" runat="server" Width="200px"></asp:TextBox>
													<asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" ControlToValidate="tname" ErrorMessage="��������Ϊ��">*</asp:RequiredFieldValidator></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 143px; HEIGHT: 6px">���䣺</TD>
												<TD style="HEIGHT: 6px">
													<asp:TextBox id="tage" runat="server" Width="200px"></asp:TextBox>
													<asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server" ControlToValidate="tage" ErrorMessage="���䲻��Ϊ��">*</asp:RequiredFieldValidator></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 143px; HEIGHT: 16px">�Ա�</TD>
												<TD style="HEIGHT: 16px">
													<asp:RadioButtonList id="r1" runat="server" Width="104px" RepeatDirection="Horizontal">
														<asp:ListItem Value="��">��</asp:ListItem>
														<asp:ListItem Value="Ů">Ů</asp:ListItem>
													</asp:RadioButtonList>
													<asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server" ControlToValidate="r1" ErrorMessage="�Ա�����Ϊ��">*</asp:RequiredFieldValidator></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 143px; HEIGHT: 4px">����</TD>
												<TD style="HEIGHT: 4px">
													<asp:DropDownList id="d1" runat="server" Width="72px">
														<asp:ListItem Value="һ��">һ��</asp:ListItem>
														<asp:ListItem Value="�е�">�е�</asp:ListItem>
														<asp:ListItem Value="�߼�">�߼�</asp:ListItem>
													</asp:DropDownList></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 143px; HEIGHT: 1px">�����ˣ�</TD>
												<TD style="HEIGHT: 1px">
													<asp:DropDownList id=d2 runat="server" Width="88px" DataTextField="����" DataMember="Table" DataSource="<%# zhuyuan1 %>">
													</asp:DropDownList></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 143px; HEIGHT: 4px">����ʵ����</TD>
												<TD style="HEIGHT: 4px">
													<asp:DropDownList id="d3" runat="server" Width="72px">
														<asp:ListItem Value="��Ժ">��Ժ</asp:ListItem>
														<asp:ListItem Value="��Ժ">��Ժ</asp:ListItem>
													</asp:DropDownList></TD>
											</TR>
											<TR>
												<TD style="HEIGHT: 5px" align="center" bgColor="#f2eaee" colSpan="2">&nbsp;
													<asp:Button id="Button1" runat="server" Text="�ύ"></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
													<asp:Button id="Button2" runat="server" Text="��Ժ"></asp:Button></TD>
											</TR>
											<TR>
												<TD style="HEIGHT: 6px" colSpan="2">�Һź��룺
													<asp:TextBox id="TextBox1" runat="server" Width="120px"></asp:TextBox>
													<asp:Button id="Button3" runat="server" Text="����"></asp:Button></TD>
											</TR>
											<TR>
												<TD align="left" colSpan="2">
													<asp:DataGrid id=DataGrid2 runat="server" Visible="False" Height="0" Width="368px" DataMember="Table" DataSource="<%# sda31 %>" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" BackColor="White" CellPadding="4" GridLines="Horizontal" DataKeyField="�Һź���" AutoGenerateColumns="False" AllowPaging="True" ShowFooter="True" PageSize="5">
														<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#339966"></SelectedItemStyle>
														<ItemStyle ForeColor="#333333" BackColor="White"></ItemStyle>
														<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#336666"></HeaderStyle>
														<FooterStyle ForeColor="#333333" BackColor="White"></FooterStyle>
														<Columns>
															<asp:BoundColumn DataField="�Һź���" SortExpression="�Һź���" HeaderText="�Һź���"></asp:BoundColumn>
															<asp:BoundColumn DataField="����" SortExpression="����" HeaderText="����"></asp:BoundColumn>
															<asp:BoundColumn DataField="����" SortExpression="����" HeaderText="����"></asp:BoundColumn>
															<asp:BoundColumn DataField="����" SortExpression="����" HeaderText="����"></asp:BoundColumn>
															<asp:BoundColumn DataField="����ʵ��" SortExpression="����ʵ��" HeaderText="����ʵ��"></asp:BoundColumn>
															<asp:ButtonColumn Text="ѡ��" CommandName="Select"></asp:ButtonColumn>
														</Columns>
														<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#336666" Mode="NumericPages"></PagerStyle>
													</asp:DataGrid></TD>
											</TR>
										</TABLE>
									</FONT>
								</asp:panel></FONT></TD>
					</TR>
					<tr>
						<td align="center">
							<asp:Image id="Image2" runat="server" Height="80px" Width="647px" ImageUrl="img/11.jpg"></asp:Image></td>
					</tr>
					<TR>
						<TD style="HEIGHT: 6px" align="center" colSpan="2">
							<asp:button id="Button5" runat="server" Text="������ҳ"></asp:button>&nbsp;<asp:button id="Button4" runat="server" Text="סԺ"></asp:button>&nbsp; 
							&nbsp;&nbsp;
							<asp:hyperlink id="HyperLink2" runat="server" ForeColor="IndianRed" Font-Bold="True" NavigateUrl="bedhos.aspx">�½���λ</asp:hyperlink>&nbsp;&nbsp;&nbsp;
							<asp:hyperlink id="HyperLink1" runat="server" Width="48px" ForeColor="IndianRed" Font-Bold="True"
								NavigateUrl="bedzhao.aspx">����</asp:hyperlink></TD>
					</TR>
					<tr>
						<td><asp:datagrid id=DataGrid1 runat="server" DataMember="Table" DataSource="<%# zhu1 %>" BorderColor="#C0C000" BorderStyle="None" BorderWidth="3px" BackColor="#FFE0C0" CellPadding="4" GridLines="Horizontal" DataKeyField="����" AutoGenerateColumns="False" AllowPaging="True" width="100%">
								<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#339966"></SelectedItemStyle>
								<ItemStyle ForeColor="#333333" BackColor="White"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#336666"></HeaderStyle>
								<FooterStyle ForeColor="#333333" BackColor="White"></FooterStyle>
								<Columns>
									<asp:BoundColumn DataField="����" SortExpression="����" HeaderText="����"></asp:BoundColumn>
									<asp:BoundColumn DataField="����" SortExpression="����" HeaderText="����"></asp:BoundColumn>
									<asp:BoundColumn DataField="����ʵ��" SortExpression="����ʵ��" HeaderText="����ʵ��"></asp:BoundColumn>
									<asp:ButtonColumn Text="ѡ��" CommandName="Select"></asp:ButtonColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#336666" Mode="NumericPages"></PagerStyle>
							</asp:datagrid></td>
					</tr>
				</TABLE>
			</FONT>
		</form>
	</body>
</HTML>
