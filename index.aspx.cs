using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace ҽԺ����ϵͳ
{
	/// <summary>
	/// index ��ժҪ˵����
	/// </summary>
	public partial class index : System.Web.UI.Page
	{
		Cpass cpa = new Cpass();
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			//Session["usename"] =Tname.Text;// �ڴ˴������û������Գ�ʼ��ҳ��
		}

		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{    

		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e)
		{
            if (Tname.Text == "" )
            {
                Response.Write("<script language=javascript>alert('�û�������Ϊ�գ�');window.location = 'index.aspx';</script>");
            }
			else if(cpa.CH(Tname.Text,Tpwd.Text,"")=="Nopasscheck")
			{
                Response.Write("<script language=javascript>alert('����û�������������');window.location = 'index.aspx';</script>");
				//Response.Redirect("index.aspx");
			}
			else
			{		
				Session["usename"] =Tname.Text; //�����û���������ֵ
				Session["pwds"] =Tpwd.Text;				
				Response.Redirect("webmenu.aspx");
			}
		}

		protected void Button2_Click(object sender, System.EventArgs e)
		{
            Response.Redirect("home.aspx");
		}

        protected void Tpwd_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("zhuce2.aspx");
        }
	}
}
