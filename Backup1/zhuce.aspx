<%@ Page language="c#" Codebehind="zhuce.aspx.cs" AutoEventWireup="false" Inherits="ҽԺ����ϵͳ.zhuce" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>zhuce</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="����">
				<asp:validationsummary id="ValidationSummary1" style="Z-INDEX: 101; LEFT: 48px; POSITION: absolute; TOP: 248px"
					runat="server" ShowMessageBox="True" ShowSummary="False"></asp:validationsummary>
				<TABLE id="Table2" align="center" width="552" cellSpacing="1" cellPadding="1" border="1"
					style="WIDTH: 552px; HEIGHT: 320px">
					<TR>
						<TD>
							<asp:Image id="Image1" runat="server" Width="542px" Height="88px" ImageUrl="img/10.jpg"></asp:Image></TD>
					</TR>
					<TR>
						<TD height="0">
							<TABLE id="Table1" width="100%" height="0" borderColor="#330033" cellSpacing="1" cellPadding="1"
								align="center" bgColor="#ffffff" border="1">
								<TR>
									<TD style="WIDTH: 105px; HEIGHT: 29px" align="right">�� �� ����</TD>
									<TD style="HEIGHT: 29px">
										<asp:textbox id="tname" runat="server" Width="200px"></asp:textbox>
										<asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" Height="14px" Width="8px" ErrorMessage="�û�������Ϊ��"
											ControlToValidate="tname">*</asp:requiredfieldvalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 105px; HEIGHT: 29px" align="right">��&nbsp;&nbsp; &nbsp;����</TD>
									<TD style="HEIGHT: 29px">
										<asp:textbox id="tname1" runat="server" Width="200px"></asp:textbox>
										<asp:requiredfieldvalidator id="Requiredfieldvalidator7" runat="server" Height="14px" Width="8px" ErrorMessage="�û�������Ϊ��"
											ControlToValidate="tname1">*</asp:requiredfieldvalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 105px" align="right">��&nbsp; &nbsp; �룺</TD>
									<TD>
										<asp:textbox id="tpwd" runat="server" Width="200px"></asp:textbox>
										<asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" Height="14px" Width="8px" ErrorMessage="���벻��Ϊ��"
											ControlToValidate="tpwd">*</asp:requiredfieldvalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 105px" align="right">ȷ�����룺</TD>
									<TD>
										<asp:textbox id="pass" runat="server" Width="200px"></asp:textbox>
										<asp:comparevalidator id="CompareValidator1" runat="server" ErrorMessage="������������벻ͬ" ControlToValidate="pass"
											ControlToCompare="tpwd">*</asp:comparevalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 105px; HEIGHT: 16px" align="right">Ȩ&nbsp;&nbsp;&nbsp; �ޣ�</TD>
									<TD style="HEIGHT: 16px">
										<asp:dropdownlist id="d1" runat="server" Height="24px" Width="128px">
											<asp:ListItem Value="�Һ�">�Һ�</asp:ListItem>
											<asp:ListItem Value="����">����</asp:ListItem>
											<asp:ListItem Value="��λ����">��λ����</asp:ListItem>
											<asp:ListItem>���ڷ���</asp:ListItem>
										</asp:dropdownlist>
										<asp:requiredfieldvalidator id="RequiredFieldValidator3" runat="server" Height="14px" Width="8px" ErrorMessage="�Ʊ���Ϊ��"
											ControlToValidate="d1">*</asp:requiredfieldvalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 105px; HEIGHT: 15px" align="right">��&nbsp; &nbsp; ��</TD>
									<TD style="HEIGHT: 15px">
										<asp:dropdownlist id="d2" runat="server" Height="24px" Width="56px">
											<asp:ListItem Value="��">��</asp:ListItem>
											<asp:ListItem Value="Ů">Ů</asp:ListItem>
										</asp:dropdownlist>
										<asp:requiredfieldvalidator id="RequiredFieldValidator4" runat="server" Height="14px" Width="8px" ErrorMessage="�Ա���Ϊ��"
											ControlToValidate="d2">*</asp:requiredfieldvalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 105px" align="right">��&nbsp;&nbsp; &nbsp;ַ��</TD>
									<TD>
										<asp:textbox id="tadd" runat="server" Width="200px"></asp:textbox>
										<asp:requiredfieldvalidator id="RequiredFieldValidator5" runat="server" Height="14px" Width="8px" ErrorMessage="��ַ����Ϊ��"
											ControlToValidate="tadd">*</asp:requiredfieldvalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 105px" align="right">��&nbsp; &nbsp; ����</TD>
									<TD>
										<asp:textbox id="tphone" runat="server" Width="200px"></asp:textbox>
										<asp:requiredfieldvalidator id="RequiredFieldValidator6" runat="server" Height="14px" Width="8px" ErrorMessage="�绰����Ϊ��"
											ControlToValidate="tphone">*</asp:requiredfieldvalidator></TD>
								</TR>
								<TR>
									<TD align="center" colSpan="2">
										<asp:button id="Button1" runat="server" Width="42px" Text="ע��"></asp:button>&nbsp;&nbsp;
										<asp:button id="Button2" runat="server" Width="40px" Text="ȡ��"></asp:button>&nbsp;&nbsp;
										<asp:HyperLink id="HyperLink2" runat="server" ForeColor="Black" Font-Bold="True" NavigateUrl="mimagai.aspx">�����޸�</asp:HyperLink>&nbsp;
										<asp:HyperLink id="HyperLink1" runat="server" NavigateUrl="ysheng.aspx" Font-Bold="True" ForeColor="Black">ҽ������</asp:HyperLink></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
				</TABLE>
			</FONT>
		</form>
	</body>
</HTML>
