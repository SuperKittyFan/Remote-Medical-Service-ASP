<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chpasswd.aspx.cs" Inherits="医院管理系统.chpasswd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

            .auto-style1 {
                font-size: xx-large;
            width: 1016px;
            height: 446px;

        }
        .auto-style3 {
            font-size: medium;
            text-align: left;
        }
        .auto-style4 {
            height: 45px;
            width: 1079px;
            text-align: left;
            color: #FFFFFF;
            font-weight: bold;
        }
        .auto-style5 {
            width: 1079px;
            height: 44px;
        }
        .auto-style8 {
            font-size: medium;
            font-weight: bold;
        }
        .auto-style9 {
            color: #FFFFFF;
        }
        .auto-style10 {
            height: 48px;
            width: 1079px;
            text-align: left;
            color: #FFFFFF;
            font-weight: bold;
        }
        .auto-style11 {
            height: 46px;
            width: 1079px;
            text-align: left;
            color: #FFFFFF;
            font-weight: bold;
        }
        .auto-style12 {
            font-weight: bold;
        }
        .auto-style13 {
            font-size: medium;
            text-align: left;
            font-weight: bold;
        }
        .auto-style14 {
            color: #009999;
            font-weight: bold;
        }
    </style>
</head>
<body style="background-color:#009999">
    <form id="form1" runat="server" style="border-style: none">
				<TABLE id="Table1" align="center" width="70%" cellSpacing="1" cellPadding="1" border="1">
					<tr>
			<FONT face="宋体" color="#ff6633">
						<td align="center" class="auto-style1" style="border-style: none">
							<span class="auto-style9"><strong>密码修改</strong><br />
                            </span><FONT face="宋体" color="#ff6633"><asp:panel id="p1" Width="544px" Runat="server" style="text-align: center" BorderStyle="None" CssClass="auto-style9" Height="239px"><FONT face="宋体">
								<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="60%" align="center" border="0">
									<TR>
										<TD class="auto-style4" style="font-size: medium"><span class="auto-style8">新 </span><FONT face="宋体"><span class="auto-style13">密 码: </span></FONT><font color="#ff6633" face="宋体"><span class="auto-style3">
                                            <asp:textbox ID="tpwd" runat="server" style="text-align: left" TextMode="Password" Width="164px" CssClass="auto-style12"></asp:textbox>
                                            </span></font></TD>
									</TR>
									<TR>
										<TD class="auto-style10"><FONT face="宋体"><span class="auto-style13">确认密码:</span>
												<asp:textbox id="TextBox3" runat="server" Width="157px" TextMode="Password" Height="16px" CssClass="auto-style12"></asp:textbox>
												</FONT></TD>
									</TR>
									<TR>
										<TD class="auto-style11"><FONT face="宋体"><span class="auto-style13">用户种类:</span>&nbsp;<font color="#ff6633" face="宋体"><span class="auto-style3"><asp:DropDownList ID="d1" runat="server" style="text-align: right" Width="152px" CssClass="auto-style12">
                                            <asp:ListItem Value="医生">医生</asp:ListItem>
                                            <asp:ListItem Value="管理员">管理员</asp:ListItem>
                                            <asp:ListItem Value="研究者">研究者</asp:ListItem>
                                            </asp:DropDownList>
                                            <b><font face="宋体">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="d1" ErrorMessage="未选择权限" style="font-size: medium">*</asp:RequiredFieldValidator>
                                            </font></b></span></font><b>&nbsp;</b></FONT></TD>
									</TR>
									<TR>
										<TD align="center" class="auto-style5">
											<font face="宋体">
                                                <strong>
                                            <asp:Button ID="Button3" runat="server" CssClass="auto-style14" Font-Size="Medium" onclick="Button1_Click" Text="修改" />
                                                    &nbsp;&nbsp;&nbsp;
                                            <asp:Button ID="Button4" runat="server" CssClass="auto-style14" Font-Size="Medium" onclick="Button3_Click" Text="返回" />
                                            </strong>
                                            </font></TD>
									</TR>
								</TABLE>
							</FONT>
						</asp:panel>
			</FONT>
		                </td>
			</FONT>
					</tr>
				</TABLE>
				<br />
    </form>
</body>
</html>
