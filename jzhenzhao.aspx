<%@ Page language="c#" Codebehind="jzhenzhao.aspx.cs" AutoEventWireup="True" Inherits="医院管理系统.jzhenzhao" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>jzhenzhao</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	    <style type="text/css">
            .auto-style2 {
                font-size: x-large;
                color: #FFFFFF;
            }
            .auto-style8 {
                height: 34px;
                width: 766px;
                color: #FFFFFF;
            }
            .auto-style11 {
                height: 40px;
                width: 39px;
                color: #FFFFFF;
            }
            .auto-style12 {
                height: 34px;
                width: 39px;
            }
            .auto-style16 {
                height: 22px;
                width: 39px;
            }
            .auto-style17 {
                width: 766px;
                color: #FFFFFF;
            }
            .auto-style18 {
                width: 766px;
                height: 22px;
                color: #FFFFFF;
            }
            .auto-style19 {
                width: 766px;
                height: 73px;
                color: #FFFFFF;
            }
            .auto-style20 {
                height: 73px;
                width: 39px;
            }
            .auto-style22 {
                height: 40px;
                width: 766px;
                color: #FFFFFF;
            }
            .auto-style23 {
                height: 44px;
            }
            .auto-style24 {
                color: #FFFFFF;
            }
            .auto-style25 {
                height: 57px;
            }
            .auto-style26 {
                height: 58px;
            }
            .auto-style27 {
                height: 62px;
            }
        </style>
	</HEAD>
	<body style="background-color:#009999">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="80%" align="center" border="1" frame="void">
					<TR>
						<TD align="center" style="HEIGHT: 60px" bgColor="#009999"  class="auto-style2">
							<strong>数据记录检索</strong></TD>
					</TR>
					<TR>
						<TD><asp:datagrid id=DataGrid1 runat="server" AllowPaging="True" DataSource="<%# jzzhao1 %>" DataMember="Table" AutoGenerateColumns="False" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="3" Width="100%" onselectedindexchanged="DataGrid1_SelectedIndexChanged">
								<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
								<ItemStyle ForeColor="#000066"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
								<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
								<Columns>
									<asp:BoundColumn DataField="挂号号码" HeaderText="病历编号"></asp:BoundColumn>
									<asp:BoundColumn DataField="姓名" HeaderText="姓名"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="胶囊编号" HeaderText="电子胶囊编号"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="仪器编号" HeaderText="记录仪编号"></asp:BoundColumn>
									<asp:BoundColumn DataField="日期" HeaderText="日期"></asp:BoundColumn>
									<asp:ButtonColumn Text="选择" CommandName="Select" HeaderText="选择"></asp:ButtonColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Center" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
							</asp:datagrid></TD>
					</TR>
                    <TR>
                        <TD align="center" class="auto-style27">
                            <asp:Button ID="Button8" runat="server" Text="删除" onclick="Button8_Click" Font-Bold="True" Font-Size="Medium" ForeColor="#009999"/>&nbsp;&nbsp;
                        <asp:button id="Button2" runat="server" Text="详细信息" onclick="Button2_Click" Font-Bold="True" Font-Size="Medium" ForeColor="#009999" Height="27px" Width="87px"></asp:button>&nbsp;&nbsp;<asp:Button id="Button6" runat="server" Text="返回" onclick="Button3_Click" Font-Bold="True" Font-Size="Medium" ForeColor="#009999" Height="25px" Width="45px"></asp:Button></TD>
                    </TR>
					<TR>
						<TD align="center" class="auto-style25"><span class="auto-style24">&nbsp;<strong> 病历编号</strong>&nbsp;&nbsp;&nbsp;
							</span>
							<asp:textbox id="TextBox1" runat="server" Width="120px" CssClass="auto-style24">&nbsp;&nbsp;</asp:textbox>&nbsp;&nbsp;<asp:button id="Button1" runat="server" Text="按病历编号查找" onclick="Button1_Click" CssClass="auto-style24" Font-Bold="True" Font-Size="Medium" ForeColor="#009999" Height="28px" Width="169px"></asp:button>
                        
					</TR>
                    <TR>
						<TD align="center" class="auto-style26"><span class="auto-style24">&nbsp; <strong>数据记录仪编号</strong>
							</span>
							<asp:textbox id="TextBox2" runat="server" Width="120px" CssClass="auto-style24"></asp:textbox>&nbsp;&nbsp;<asp:button id="Button4" runat="server" Text="按记录仪查找" onclick="Button4_Click" CssClass="auto-style24" Font-Bold="True" Font-Size="Medium" ForeColor="#009999"></asp:button>
							
					</TR>
					<TR>
						<TD align="center">&nbsp;
							<asp:panel id="p1" Width="749px" Visible="False" Runat="server">
								<TABLE id="Table2" style="WIDTH: 657px"  cellSpacing="1" cellPadding="1"
									width="657" border="1">
									<TR>
										<TD align="center" colSpan="2" class="auto-style23">
											<asp:Label id="Label14" runat="server" Width="236px" ForeColor="Red" CssClass="auto-style24"></asp:Label></TD>
									</TR>
									<TR>
										<TD class="auto-style22">病历编号：</TD>
										<TD class="auto-style11">
											<asp:label id="Label1" runat="server" Width="272px" CssClass="auto-style24"></asp:label></TD>
									</TR>
									<TR>
										<TD class="auto-style22">姓名：</TD>
										<TD class="auto-style11">
											<asp:label id="Label2" runat="server" Width="248px" CssClass="auto-style24"></asp:label></TD>
									</TR>
									<TR>
										<TD class="auto-style22">年龄：</TD>
										<TD class="auto-style11">
											<asp:label id="Label3" runat="server" Width="304px" CssClass="auto-style24"></asp:label></TD>
									</TR>
									<TR>
										<TD class="auto-style22">性别：</TD>
										<TD class="auto-style11">
											<asp:label id="Label4" runat="server" Width="288px"></asp:label></TD>
									</TR>
                                    <TR>
										<TD class="auto-style22">职业：</TD>
										<TD class="auto-style11">
											<asp:label id="Label15" runat="server" Width="288px"></asp:label></TD>
									</TR>
									<TR>
										<TD class="auto-style18">检查所在医院：</TD>
										<TD class="auto-style16">
											<asp:label id="Label5" runat="server" Width="256px" style="color: #FFFFFF"></asp:label></TD>
									</TR>
									<TR>
										<TD class="auto-style18">检查有无异常：</TD>
										<TD class="auto-style16">
											<font face="宋体">
                                                <asp:Label ID="Label6" runat="server" Width="256px" style="color: #FFFFFF"></asp:Label>
                                            </font></TD>
									</TR>
									<TR>
										<TD class="auto-style17">电子胶囊编号</TD>
										<TD class="auto-style11">
											<asp:label id="Label7" runat="server" Width="216px"></asp:label></TD>
									</TR>
                                    <TR>
										<TD class="auto-style17">数据记录仪编号</TD>
										<TD class="auto-style11">
											<asp:label id="Label11" runat="server" Width="216px"></asp:label></TD>
									</TR>
                                    <TR>
										<TD class="auto-style19">数据存放路径</TD>
										<TD class="auto-style20">
											<asp:Label ID="Label16" runat="server" Width="216px" style="color: #FFFFFF; margin-top:10px"></asp:Label>
                                                <asp:Button ID="Button7" runat="server" Text="下载"  OnClick="Button7_Click" Height="22px" />
                                            </TD>
									</TR>
									<TR>
										<TD class="auto-style22">诊断病况：</TD>
										<TD class="auto-style11">
											<asp:label id="Label8" runat="server" Height="206px" Width="520px"></asp:label></TD>
									</TR>
                                    <TR>
										<TD class="auto-style17">开始检查时间：</TD>
										<TD class="auto-style11">
											<asp:label id="Label9" runat="server" Width="520px"></asp:label></TD>
									</TR>
                                    <TR>
										<TD class="auto-style17">结束检查时间：</TD>
										<TD class="auto-style11">
											<asp:label id="Label10" runat="server" Width="520px"></asp:label></TD>
									</TR>
									<TR>
										<TD class="auto-style22">医师：</TD>
										<TD class="auto-style11">
											<asp:label id="Label12" runat="server" Width="184px"></asp:label></TD>
									</TR>
									<TR>
										<TD class="auto-style8">日期：</TD>
										<TD class="auto-style12">
											<asp:label id="Label13" runat="server" Width="448px" style="color: #FFFFFF"></asp:label></TD>
									</TR>
								</TABLE>
							</asp:panel></TD>
					</TR>
					<TR>
						<TD>&nbsp;
						</TD>
					</TR>
				</TABLE>
			</FONT>
		</form>
	</body>
</HTML>
