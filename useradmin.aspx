<%@ Page language="c#" Codebehind="useradmin.aspx.cs" AutoEventWireup="True" Inherits="医院管理系统.mimagai" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>useradmin</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	    <style type="text/css">
            .auto-style1 {
                height: 49px;
                color: #FFFFFF;
                font-weight: bold;
            }
            .auto-style2 {
                font-size: xx-large;
            }
            .auto-style3 {
                color: #FFFFFF;
            }
            .auto-style4 {
                color: #FFFFFF;
                font-weight: bold;
                text-align: left;
            }
            .auto-style5 {
                color: #FFFFFF;
                font-weight: bold;
                text-align: left;
                height: 43px;
            }
            .auto-style6 {
                color: #FFFFFF;
                font-weight: bold;
                text-align: left;
                height: 40px;
            }
            .auto-style7 {
                color: #FFFFFF;
                font-weight: bold;
                text-align: left;
                height: 53px;
            }
            .auto-style8 {
                color: #009999;
                font-weight: bold;
                text-align: left;
            }
            .auto-style9 {
                font-weight: bold;
                text-align: left;
            }
            .auto-style10 {
                color: #009999;
            }
            .auto-style11 {
                height: 293px;
            }
        </style>
	</HEAD>
	<body MS_POSITIONING="GridLayout" style="background-color:#009999">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">&nbsp;</FONT>
			<TABLE id="Table2" height="0" cellSpacing="1" cellPadding="1" width="65%" align="center"
				border="1">
				<TR>
					<TD style="border-style: none; HEIGHT: 49px; background-color: #009999; color: #FFFFFF;" align="center" bgColor="antiquewhite" class="auto-style2"><strong>用户管理</strong></TD>
				</TR>
				<TR>
					<TD><asp:datagrid id=DataGrid1 runat="server" Width="100%" BorderColor="#FF6600" BorderStyle="Solid" BorderWidth="3px" BackColor="White" CellPadding="4" GridLines="Horizontal" DataSource="<%# ds11 %>" DataKeyField="useid" DataMember="Table" AutoGenerateColumns="False" AllowPaging="True" onselectedindexchanged="DataGrid1_SelectedIndexChanged">
							<SelectedItemStyle Font-Bold="True" ForeColor="#C04000" BackColor="#E0E0E0"></SelectedItemStyle>
							<ItemStyle ForeColor="#333333" BackColor="White"></ItemStyle>
							<HeaderStyle Font-Bold="True" ForeColor="Black" BackColor="#FF6600"></HeaderStyle>
							<FooterStyle ForeColor="#333333" BackColor="White"></FooterStyle>
							<Columns>
								<asp:BoundColumn DataField="useid" HeaderText="用户名"></asp:BoundColumn>
								<asp:BoundColumn DataField="usename" HeaderText="姓名"></asp:BoundColumn>
								<asp:BoundColumn DataField="sex" HeaderText="性别"></asp:BoundColumn>
								<asp:BoundColumn DataField="addr" HeaderText="地址"></asp:BoundColumn>
								<asp:BoundColumn DataField="phone" HeaderText="电话"></asp:BoundColumn>
								<asp:ButtonColumn Text="选择" HeaderText="选择" CommandName="Select"></asp:ButtonColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" ForeColor="Purple" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></TD>
				</TR>
				<TR>
					<TD align="center" class="auto-style11"><asp:panel id="p1" Width="544px" Runat="server" BorderStyle="None" style="margin-bottom: 44px"><FONT face="宋体">
								<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="60%" align="center" border="1" frame="void" style="border-style: none">
									<TR>
										<TD align="left" class="auto-style1" style="border-style: none"><FONT face="宋体"><span class="auto-style4">用 户 名: </span>
												<asp:label id="Label1" runat="server" Width="163px" ForeColor="#C00000" Font-Bold="True" CssClass="auto-style4"></asp:label></FONT></TD>
									</TR>
									<TR>
										<TD align="center" class="auto-style5"><FONT face="宋体"><span class="auto-style4">密码:&nbsp;&nbsp;&nbsp; </span>
												<asp:textbox id="tpwd" runat="server" Width="164px" TextMode="Password" CssClass="auto-style4"></asp:textbox></FONT></TD>
									</TR>
									<TR>
										<TD align="center" class="auto-style6"><FONT face="宋体"><span class="auto-style4">确定密码:&nbsp; </span>
												<asp:textbox id="TextBox3" runat="server" Width="157px" TextMode="Password" CssClass="auto-style4"></asp:textbox>
												<b>
                                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tpwd" ControlToValidate="TextBox3" CssClass="auto-style3" ErrorMessage="密码不一致">*</asp:CompareValidator>
                                            </b></FONT></TD>
									</TR>
									<TR>
										<TD align="center" class="auto-style7"><FONT face="宋体"><span class="auto-style4">用户种类:&nbsp; </span>
                                            <asp:DropDownList ID="d1" runat="server" CssClass="auto-style4" Width="152px">
                                                <asp:ListItem Value="医生">医生</asp:ListItem>
                                                <asp:ListItem Value="管理员">管理员</asp:ListItem>
                                                <asp:ListItem Value="研究者">研究者</asp:ListItem>
                                            </asp:DropDownList>
                                            <b>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="d1" CssClass="auto-style3" ErrorMessage="未选择权限">*</asp:RequiredFieldValidator>
                                            </b></FONT></TD>
									</TR>
									<TR>
										<TD align="center" class="auto-style3">
											<font face="宋体">
                                                <asp:Button ID="Button3" runat="server" onclick="Button1_Click" Text="修改" CssClass="auto-style8" />
                                                <span class="auto-style9">&nbsp;<span class="auto-style10">&nbsp;</span></span><asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="删除" CssClass="auto-style8" Width="42px" />
                                                <span class="auto-style9">&nbsp;&nbsp;</span>
                                            <asp:Button ID="Button4" runat="server" CssClass="auto-style8" onclick="Button3_Click" Text="返回" />
                                            </font></TD>
									</TR>
								</TABLE>
							</FONT>
						</asp:panel></TD>
				</TR>
			</TABLE>
			<asp:validationsummary id="ValidationSummary1" style="Z-INDEX: 101; LEFT: 1260px; POSITION: absolute; TOP: 202px; bottom: 330px;"
				runat="server" ShowSummary="False" ShowMessageBox="True"></asp:validationsummary></form>
	</body>
</HTML>
