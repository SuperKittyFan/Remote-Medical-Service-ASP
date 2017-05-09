<%@ Page language="c#" Codebehind="index.aspx.cs" AutoEventWireup="false" Inherits="医院管理系统.index" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>index</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table3" align="center" cellSpacing="1" cellPadding="1" width="300" border="1">
				<TR>
					<TD><FONT face="宋体">
							<asp:Image id="Image1" runat="server" Width="609px" Height="88px" ImageUrl="img/12.jpg"></asp:Image></FONT></TD>
				</TR>
				<TR>
					<TD>
						<TABLE id="Table1" cellSpacing="0" cellPadding="0" background="img/1.jpg" border="0" style="WIDTH: 608px; HEIGHT: 408px">
							<TR>
								<TD style="HEIGHT: 26px" align="center">
									<MARQUEE onmouseover="this.stop()" style="WIDTH: 607px; HEIGHT: 8px" onmouseout="this.start()"
										scrollAmount="3" scrollDelay="70" direction="left"><FONT face="宋体" color="#009900" size="2">制作人：贺鹏、黄海、许演兵、龙永斌、苟亚静。若不能正常登入，请到后勤服务部查询。</FONT></MARQUEE>
								</TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 99px" align="center"><FONT face="宋体"></FONT></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 103px" align="center"><FONT face="宋体">
										<TABLE id="Table2" style="WIDTH: 210px; HEIGHT: 90px" borderColor="#ffff00" cellSpacing="0"
											cellPadding="0" width="210" border="1">
											<TR>
												<TD style="HEIGHT: 21px"><FONT face="宋体"><FONT face="宋体">用户名:
															<asp:textbox id="Tname" runat="server" Width="137px" Font-Size="Medium"></asp:textbox></FONT></FONT></TD>
											</TR>
											<TR>
												<TD style="HEIGHT: 14px"><FONT face="宋体">密&nbsp; 码:
														<asp:textbox id="Tpwd" runat="server" Width="136px" Font-Size="Medium" TextMode="Password"></asp:textbox></FONT></TD>
											</TR>
											<TR>
												<TD align="center">
													<asp:button id="Button1" runat="server" Text="登入"></asp:button>&nbsp;
													<asp:button id="Button2" runat="server" Text="取消"></asp:button></TD>
											</TR>
										</TABLE>
										&nbsp;</FONT><FONT face="宋体, MS Song"> </FONT>
								</TD>
							</TR>
							<TR>
								<TD align="center"><FONT face="宋体"></FONT></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD></TD>
				</TR>
			</TABLE>
			&nbsp;
		</form>
	</body>
</HTML>
