<%@ Page language="c#" Codebehind="jiuzhen.aspx.cs" AutoEventWireup="True" Inherits="ҽԺ����ϵͳ.jiuzhen" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>jiuzhen</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	    <style type="text/css">
            .auto-style1 {
                font-size: xx-large;
                height: 55px;
                color: #FFFFFF;
            }
            .auto-style2 {
                width: 87px;
                height: 32px;
                color: #FFFFFF;
                text-align: center;
            }
            .auto-style3 {
                height: 32px;
            }
            .auto-style4 {
                width: 475px;
                height: 43px;
                color: #FFFFFF;
            }
            .auto-style5 {
                height: 43px;
            }
            .auto-style7 {
                height: 38px;
                width: 475px;
                color: #FFFFFF;
            }
            .auto-style10 {
                color: #FFFFFF;
                width: 87px;
                height: 33px;
                text-align: center;
            }
            .auto-style11 {
                height: 33px;
            }
            .auto-style12 {
                color: #FFFFFF;
                width: 87px;
                height: 31px;
                text-align: center;
            }
            .auto-style13 {
                height: 31px;
            }
            .auto-style14 {
                color: #FFFFFF;
                width: 87px;
                height: 34px;
                text-align: center;
            }
            .auto-style15 {
                height: 34px;
            }
            .auto-style16 {
                width: 475px;
                height: 45px;
                color: #FFFFFF;
            }
            .auto-style17 {
                height: 45px;
            }
            .auto-style21 {
                width: 475px;
                color: #FFFFFF;
            }
            .auto-style23 {
                height: 37px;
            }
            .auto-style24 {
                height: 37px;
                width: 475px;
                color: #FFFFFF;
            }
        </style>
	</HEAD>
	<body MS_POSITIONING="GridLayout" style="background-color:#009999">
		<form id="Form1" method="post" runat="server">
			<FONT class="sd2" face="����">
				<TABLE id="Table4" height="0" cellSpacing="1" cellPadding="1" width="736" align="center"
					border="0" frame="void">
					<TR>
						<TD align="center" class="auto-style1"><strong>������ݼ�¼</strong></TD>
					</TR>
					<TR>
						<TD align="center">
							&nbsp;</TD>
					</TR>
					<TR>
						<TD><asp:panel id="p1" Width="768px" Runat="server" style="margin-right: 71px">
								<TABLE id="Table1" style="WIDTH: 651px; HEIGHT: 876px; background-color: #009999;" cellSpacing="1" cellPadding="1"
									width="651" align="center" bgColor="#ffffff" border="0" frame="void">
                                    <TR>
													<TD class="auto-style16">������ţ�</TD>
													<TD class="auto-style17">
														<asp:TextBox id="tnumber" runat="server" Width="256px"></asp:TextBox></TD>
												</TR>
									<TR>
										<TD class="auto-style21">�����˼���Ϣ��</TD>
										<TD>
											<TABLE id="Table2" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
												<TR>
													<TD class="auto-style10">��&nbsp;&nbsp;����</TD>
													<TD class="auto-style11">
														<asp:TextBox id="tname" runat="server" Width="256px"></asp:TextBox></TD>
												</TR>
												<TR>
													<TD class="auto-style2">��&nbsp;&nbsp;��</TD>
													<TD class="auto-style3">
														<asp:TextBox id="tsex" runat="server" Width="256px"></asp:TextBox></TD>
												</TR>
												<TR>
													<TD class="auto-style12">��&nbsp;&nbsp;�䣺</TD>
													<TD class="auto-style13">
														<asp:TextBox id="tage" runat="server" Width="256px"></asp:TextBox></TD>
												</TR>
                                                <TR>
													<TD class="auto-style14">ְ&nbsp;&nbsp;ҵ��</TD>
													<TD class="auto-style15">
														<asp:TextBox id="tocc" runat="server" Width="256px"></asp:TextBox></TD>
												</TR>
											</TABLE>
										</TD>
									</TR>
                                    <TR>
										<TD class="auto-style21">�豸�����ļ��ϴ�</TD>
										<TD><INPUT id="File1" style="WIDTH: 320px; HEIGHT: 22px" type="file" size="34" name="File1"
												runat="server"></TD>
									</TR>
                                    <TR>
										<TD class="auto-style21">���ӽ��Ҳ�Ʒ��ţ�</TD>
										<TD>
											<asp:TextBox id="telec" runat="server" Width="256px"></asp:TextBox></TD>
                                    </TR>
                                    <TR>
										<TD class="auto-style21">���ݼ�¼�ǲ�Ʒ��ţ�</TD>
										<TD>
											<asp:TextBox id="trec" runat="server" Width="256px"></asp:TextBox></TD>
                                    </TR>
                   
									<TR>
										<TD class="auto-style7">�����������쳣��</TD>
										<TD style="HEIGHT: 38px">
											<asp:radiobuttonlist id="r1" runat="server" Width="136px" Height="8px" BorderStyle="None" CellPadding="0"
												RepeatDirection="Horizontal" CellSpacing="0" style="color: #FFFFFF">
												<asp:ListItem Value="��">��</asp:ListItem>
												<asp:ListItem Value="��">��</asp:ListItem>
											</asp:radiobuttonlist></TD>
									</TR>
					
									<TR>
										<TD class="auto-style21">��������Ͻ��ۣ�</TD>
										<TD>
											<asp:textbox id="tbk" runat="server" Width="504px" Height="190px" TextMode="MultiLine" DESIGNTIMEDRAGDROP="70"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="HEIGHT: 12px" align="left" colSpan="2"></TD>
									</TR>
									<TR>
													<TD class="auto-style24">����ҽ��������</TD>
													<TD class="auto-style23">
														<asp:TextBox id="tdoc" runat="server" Width="256px"></asp:TextBox></TD>
                                    </TR>
                                    <TR>
                                                    <TD class="auto-style21">�������ҽԺ��</TD>
													<TD>
                                                        <asp:TextBox id="thosp" runat="server" Width="256px"></asp:TextBox></TD>
                                    </TR>
                                    <TR>
														
                                                    <TD class="auto-style21">��鿪ʼʱ��</TD>
													<TD>
														<asp:TextBox id="tstart" runat="server" Width="256px"></asp:TextBox></TD>
                                    </TR>
									
									<TR>
										<TD class="auto-style4">������ʱ��</TD>
									    <td class="auto-style5">
                                            <asp:TextBox ID="tend" runat="server" Width="256px"></asp:TextBox>
                                        </td>
                                        
                                           
                                        
									</TR>
                                    <TR>
                                         <td align="center" colspan="2">&nbsp;
                                                <asp:Button ID="Button2" runat="server" Height="22px" onclick="Button2_Click" Text="ȷ��" Width="56px" Font-Bold="True" Font-Size="Medium" ForeColor="#009999" />&nbsp;&nbsp;
                                                <asp:Button ID="Button4" runat="server" Height="22px" onclick="Button4_Click" Text="����" Width="60px" Font-Bold="True" Font-Size="Medium" ForeColor="#009999" />
                                            </td>
                                    </TR>
								</TABLE>
							</asp:panel></TD>
					</TR>
				</TABLE>
			</FONT>
		</form>
	</body>
</HTML>
