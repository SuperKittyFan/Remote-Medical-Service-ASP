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
	public class index : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox Tname;
		protected System.Web.UI.WebControls.TextBox Tpwd;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Image Image1;
		Cpass cpa = new Cpass();
	
		private void Page_Load(object sender, System.EventArgs e)
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
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			if(cpa.CH(Tname.Text,Tpwd.Text,"")=="Nopasscheck")
			{
				Response.Write("<script language=javascript>alert('����û�������������')</script>") ;
				//Response.Redirect("index.aspx");
			
			}
			else
			{		
				Session["usename"] =Tname.Text; //�����û���������ֵ
				Session["pwds"] =Tpwd.Text;				
				Response.Redirect("webmenu.aspx");
			}
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
		  Tname.Text="";
			Tpwd.Text ="";
		}
	}
}
