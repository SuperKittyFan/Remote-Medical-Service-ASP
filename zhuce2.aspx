

<%@ Page language="c#" Codebehind="zhuce2.aspx.cs" AutoEventWireup="True" Inherits="医院管理系统.zhuce2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>zhuce</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	    <style type="text/css">
            .auto-style1 {
                text-align: center;
                height: 41px;
                font-size: xx-large;
                color: #FFFFFF;
            }
            .auto-style2 {
                color: #FFFFFF;
                font-weight: bold;
            }
            .auto-style3 {
                color: #FFFFFF;
                font-weight: bold;
                width: 105px;
                height: 44px;
            }
            .auto-style4 {
                height: 44px;
            }
            .auto-style5 {
                color: #FFFFFF;
                font-weight: bold;
                width: 105px;
                height: 42px;
            }
            .auto-style6 {
                height: 42px;
            }
            .auto-style7 {
                color: #FFFFFF;
                font-weight: bold;
                width: 105px;
                height: 39px;
            }
            .auto-style8 {
                height: 39px;
            }
            .auto-style9 {
                font-weight: bold;
            }
        </style>
	</HEAD>
	<body MS_POSITIONING="GridLayout" style="background-color: #009999">
		<form id="Form1" method="post" runat="server" style="background-color: #009999">
			<FONT face="宋体" style="background-color: #009999">
				<asp:validationsummary id="ValidationSummary1" style="Z-INDEX: 101; LEFT: 48px; POSITION: absolute; TOP: 248px"
					runat="server" ShowMessageBox="True" ShowSummary="False"></asp:validationsummary>
				<TABLE id="Table2" align="center" width="552" cellSpacing="1" cellPadding="1" border="0"
					style="WIDTH: 552px; HEIGHT: 320px; background-color: #009999;" frame="void">
					<TR>
						<TD class="auto-style1" style="background-color: #009999">
							<strong>用户注册<FONT face="宋体" style="background-color: #009999"><TABLE id="Table1" width="100%"  cellSpacing="1" cellPadding="1"
								align="center" bgColor="#ffffff" border="0" style="background-color: #009999; height: 388px;">
								<TR>
									<TD align="left" class="auto-style3">用 户 名：</TD>
									<TD class="auto-style4">
										<asp:textbox id="tname" runat="server" Width="200px"></asp:textbox>
										<asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" Height="14px" Width="8px" ErrorMessage="用户名不能为空"
											ControlToValidate="tname">*</asp:requiredfieldvalidator></TD>
								</TR>
								<TR>
									<TD align="left" class="auto-style5">姓名：</TD>
									<TD class="auto-style6">
										<asp:textbox id="tname1" runat="server" Width="200px"></asp:textbox>
										<asp:requiredfieldvalidator id="Requiredfieldvalidator7" runat="server" Height="14px" Width="8px" ErrorMessage="用户名不能为空"
											ControlToValidate="tname1">*</asp:requiredfieldvalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 105px" align="left" class="auto-style2">密码：</TD>
									<TD>
										<asp:textbox id="tpwd" runat="server" Width="200px" ontextchanged="Tpwd_TextChanged"></asp:textbox>
										<asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" Height="14px" Width="8px" ErrorMessage="密码不能为空"
											ControlToValidate="tpwd">*</asp:requiredfieldvalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 105px" align="left" class="auto-style2">确认密码：</TD>
									<TD>
										<asp:textbox id="pass" runat="server" Width="200px"></asp:textbox>
										<asp:comparevalidator id="CompareValidator1" runat="server" ErrorMessage="两次输入的密码不同" ControlToValidate="pass"
											ControlToCompare="tpwd">*</asp:comparevalidator></TD>
								</TR>
								<TR>
									<TD align="left" class="auto-style7">用户种类：</TD>
									<TD class="auto-style8">
										<asp:dropdownlist id="d1" runat="server" Height="24px" Width="128px">
											<asp:ListItem Value="管理员">管理员</asp:ListItem>
											<asp:ListItem Value="医生">医生</asp:ListItem>
                                            <asp:ListItem Value="研究者">研究者</asp:ListItem>
										</asp:dropdownlist>
										<asp:requiredfieldvalidator id="RequiredFieldValidator3" runat="server" Height="14px" Width="8px" ErrorMessage="科别不能为空"
											ControlToValidate="d1">*</asp:requiredfieldvalidator></TD>
								</TR>
								<TR>
									<TD align="left" class="auto-style5">性别：</TD>
									<TD class="auto-style6">
										<asp:dropdownlist id="d2" runat="server" Height="24px" Width="56px">
											<asp:ListItem Value="男">男</asp:ListItem>
											<asp:ListItem Value="女">女</asp:ListItem>
										</asp:dropdownlist>
										<asp:requiredfieldvalidator id="RequiredFieldValidator4" runat="server" Height="14px" Width="8px" ErrorMessage="性别不能为空"
											ControlToValidate="d2">*</asp:requiredfieldvalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 105px" align="left" class="auto-style2">地址：</TD>
									<TD>
										<asp:textbox id="tadd" runat="server" Width="200px"></asp:textbox>
										<asp:requiredfieldvalidator id="RequiredFieldValidator5" runat="server" Height="14px" Width="8px" ErrorMessage="地址不能为空"
											ControlToValidate="tadd">*</asp:requiredfieldvalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 105px" align="left" class="auto-style2">电话：</TD>
									<TD>
										<asp:textbox id="tphone" runat="server" Width="200px"></asp:textbox>
										<asp:requiredfieldvalidator id="RequiredFieldValidator6" runat="server" Height="14px" Width="8px" ErrorMessage="电话不能为空"
											ControlToValidate="tphone">*</asp:requiredfieldvalidator></TD>
								</TR>
								<TR>
									<TD align="center" colSpan="2">
										<asp:button id="Button1" runat="server" Width="58px" Text="注册" onclick="Button1_Click" style="color: #009999;" CssClass="auto-style9" Font-Size="Medium" Height="26px"></asp:button><b>&nbsp;&nbsp;
										</b>
										<asp:button id="Button2" runat="server" Width="46px" Text="返回" OnClick="Button2_Click" CssClass="auto-style9" Font-Size="Medium" Height="26px" style="color: #009999"></asp:button><b>&nbsp;&nbsp;</b>
										&nbsp;
										</TD>
								</TR>
							</TABLE>
			</FONT>
		                    </strong></TD>
					</TR>
					<TR>
						<TD height="0">
							&nbsp;</TD>
					</TR>
				</TABLE>
			</FONT>
		</form>
	</body>
</HTML>
