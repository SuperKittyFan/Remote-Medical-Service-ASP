<%@ Page language="c#" Codebehind="webmenu.aspx.cs" AutoEventWireup="false" Inherits="ҽԺ����ϵͳ.webmenu" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>webmenu</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="����" color="#ff6633">
				<TABLE id="Table1" align="center" width="70%" cellSpacing="1" cellPadding="1" border="1">
					<tr>
						<td align="center">
							<asp:Image id="Image1" runat="server" Width="643px" Height="80px" ImageUrl="img/12.jpg"></asp:Image></td>
					</tr>
					<TR>
						<TD style="COLOR: #ff6633"><FONT size="4">ע�� </FONT><FONT size="2">���������û�Ȩ�޽�����Ӧ��ҳ��</FONT></TD>
					</TR>
					<TR>
						<TD align="center">
							<asp:hyperlink id="HyperLink1" runat="server" NavigateUrl="guahao.aspx" ForeColor="Purple">�Һ�</asp:hyperlink>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
							<asp:hyperlink id="HyperLink4" runat="server" NavigateUrl="jiuzhen.aspx" ForeColor="Purple">����</asp:hyperlink>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:hyperlink id="HyperLink3" runat="server" NavigateUrl="bedid.aspx" ForeColor="Purple">סԺ����</asp:hyperlink>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:hyperlink id="HyperLink2" runat="server" NavigateUrl="ysheng.aspx" ForeColor="Purple">���ڷ���</asp:hyperlink></TD>
					</TR>
					<TR>
						<TD align="center">
							<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="300" border="1" style="WIDTH: 300px; HEIGHT: 106px">
								<TR>
									<TD align="center"><FONT color="#ff0000" size="4"><STRONG>�����޸�</STRONG></FONT></TD>
								</TR>
								<TR>
									<TD align="center">
										<asp:Label id="Label2" runat="server" Height="8px" Width="70px" ForeColor="Black">�� �� ��</asp:Label>��
										<asp:Label id="Label1" runat="server" Width="126px" ForeColor="Red"></asp:Label></TD>
								</TR>
								<TR>
									<TD align="center">
										<asp:Label id="Label3" runat="server" Height="8px" Width="70px" ForeColor="Black">��    ��     ��</asp:Label>��&nbsp;&nbsp;
										<asp:TextBox id="tpwd" runat="server" Height="24" Width="102" TextMode="Password"></asp:TextBox></TD>
								</TR>
								<TR>
									<TD align="center">&nbsp; ȷ�����룺&nbsp; &nbsp;
										<asp:TextBox id="tpwd1" runat="server" Height="24px" Width="102px" TextMode="Password"></asp:TextBox>
										<asp:CompareValidator id="CompareValidator1" runat="server" ErrorMessage="���벻һ��" ControlToValidate="tpwd1"
											ControlToCompare="tpwd">*</asp:CompareValidator></TD>
								</TR>
								<TR>
									<TD align="center">
										<asp:Button id="Button1" runat="server" Text="�޸�"></asp:Button>&nbsp;
										<asp:Button id="Button2" runat="server" Text="ȡ��"></asp:Button></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
					<TR>
						<TD align="center"><FONT size="5">ϵͳ���</FONT></TD>
					</TR>
					<TR>
						<TD>
							<P>&nbsp;<FONT size="2">&nbsp;&nbsp; 
									��ҽԺӦ�õ��Ӽ��������ҪĿ���ǿ���ҽԺ��Ϣ��Դ�����ҽ�ƻ���ˮƽ��ʵ��ҽԺ��ѧ��������ҽԺ������Ϣϵͳ��ֱ�Ӳ�������Ч�棬����Ҫ������߾���ϵͳ��׼ȷ�ԣ����ҽ�������칫�Ҽ�����ҵ����ҵĹ���Ч�ʺ͹���ˮƽ����ˣ�ҽԺ������Ϣϵͳ�������ǽ���ҽ�������칫�Ҽ�����ҵ����ҵ���Ϣ������һ���Ը�������ΪĿ���ҽԺ������Ϣϵͳ��</FONT></P>
							<P><FONT size="2">һ��ϵͳ�Ĺ���</FONT></P>
							<P><FONT size="2">&nbsp;&nbsp;&nbsp; 1:��ϵͳ�������˹Һţ������Խ��в�ѯ��</FONT></P>
							<P><FONT size="2">&nbsp;&nbsp;&nbsp;&nbsp;2��ҽ����Ϣ���룬ɾ�����޸ĵ���صĲ�����</FONT></P>
							<P><FONT size="2">&nbsp;&nbsp;&nbsp;&nbsp;3������סԺ������ѯ��</FONT></P>
							<P><FONT size="2">&nbsp;&nbsp;&nbsp; 4����ֽ������Ͳ�����ѯ��</FONT></P>
							<P><FONT size="2">����ϵͳ���ص㣺</FONT></P>
							<P><FONT size="2">&nbsp;&nbsp;&nbsp; 1������û��Ȩ�޵�ʱ����Ͳ��ܽ���ҳ�档ÿ������ÿ���˵����Ρ�</FONT></P>
						</TD>
					</TR>
				</TABLE>
				<asp:ValidationSummary id="ValidationSummary1" style="Z-INDEX: 101; LEFT: 848px; POSITION: absolute; TOP: 344px"
					runat="server" ShowMessageBox="True" ShowSummary="False"></asp:ValidationSummary>
			</FONT>
		</form>
	</body>
</HTML>
