<%@ Page language="c#" Codebehind="webmenu.aspx.cs" AutoEventWireup="True" Inherits="医院管理系统.webmenu" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>webmenu</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	    <style type="text/css">
            .auto-style1 {
                font-size: xx-large;
                width: 992px;
                text-align:center;
                color: #FFFFFF;
            }
            .auto-style2 {
                width: 992px;
                height: 50px;
            }
            .auto-style3 {
                width: 992px;
                height: 33px;
                color: #FF9933;
            }
            .auto-style4 {
                color: #FFFFFF;
            }
            .auto-style5 {
                width: 992px;
                color: #FFFFFF;
                text-align:center;
                vertical-align:central;
            }
            .auto-style6 {
                color: #009999;
            }
            .auto-style7 {
                width: 992px;
                color: #FFFFFF;
                height: 51px;
                text-align:center;
            }
            .auto-style8 {
                color: #009999;
                font-weight: bold;
            }
            .auto-style9 {
                color: #FFFFFF;
                font-weight: bold;
            }
            .auto-style10 {
                font-weight: bold;
                text-align:center;
            }
            .auto-style11 {
                width: 992px;
                color: #FFFFFF;
                height: 186px;
                text-align: center;
            }
            .auto-style12 {
                text-align: center;
            }
        </style>
	</HEAD>
	<body MS_POSITIONING="GridLayout" style=" background-color:#009999">
		<form id="Form1" method="post" runat="server" >
			<FONT face="宋体" color="#ffffff">
				<TABLE id="Table1" align="center" width="70%" border="0" frame="void">
					<tr>
						<td class="auto-style1">
							数据库管理系统</td>
					</tr>
					<TR>
						<TD class="auto-style3"><FONT size="4">注： </FONT><FONT size="2">请根据你的用户权限进入相应的页面</FONT></TD>
					</TR>
					<TR>
						<TD class="auto-style2" align="center">
							<strong>
							<asp:Button id="Button5" runat="server" Text="添加数据记录" OnClick="Button3_Click" CssClass="auto-style8" Font-Size="Medium"></asp:Button></strong><span class="auto-style6"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong></span><strong><asp:Button ID="Button6" runat="server" Text="检索数据记录"  OnClick="Button4_Click" CssClass="auto-style8" Font-Size="Medium"/>
                            </strong><span class="auto-style6"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong></span><strong><asp:button id="button4" runat="server" OnClick="HyperLink2_Click" Text="用户管理（管理员）" CssClass="auto-style8" Font-Size="Medium" Width="185px"></asp:button></strong></TD>
					</TR>
					<TR>
						<TD class="auto-style5" style="top: 141px; left: 2px;">
							<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="300" border="0" style="WIDTH: 300px; HEIGHT: 106px">
								<TR>
									<TD align="center" class="auto-style10">
										<span class="auto-style9">Aloha!
										</span><b>
										<asp:Label id="Label1" runat="server" Width="126px" ForeColor="Red" CssClass="auto-style4"></asp:Label></b><span class="auto-style9">您已登陆！</span></TD>
								</TR>
								<TR>
									<TD align="center">
										<asp:Button id="Button1" runat="server" Text="修改密码" onclick="Button1_Click" style="margin-top: 0px;" CssClass="auto-style8" Font-Size="Medium" Height="28px"></asp:Button><span class="auto-style8">&nbsp;
										</span>
										<asp:Button id="Button2" runat="server" Text="注销" OnClick="Button2_Click" CssClass="auto-style8" Font-Size="Medium"></asp:Button></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
					<TR>
						<TD class="auto-style7" style="position: relative"><FONT size="5">系统简介</FONT></TD>
					</TR>
					<TR>
						<TD class="auto-style11">
							<P class="auto-style4">本系统提供给三种不同的用户群使用</P>
							<div class="auto-style12">
							<span class="auto-style4">1 管理员：用户管理，病历添加删除，病历检索 
                            </span> 
                            <br class="auto-style4" />
                            <br class="auto-style4" />
                            <span class="auto-style4">2 医生：病历添加，病历检索 </span> <br class="auto-style4" />
                            <br class="auto-style4" />
                            <span class="auto-style4">3 研究者：病历检索 </span> 
                            </div>
                        </TD>
					</TR>
				</TABLE>
				<asp:ValidationSummary id="ValidationSummary1" style="Z-INDEX: 101; LEFT: 848px; POSITION: absolute; TOP: 344px"
					runat="server" ShowMessageBox="True" ShowSummary="False"></asp:ValidationSummary>
			</FONT>
		</form>
	    <p>
            h</p>
	</body>
</HTML>
