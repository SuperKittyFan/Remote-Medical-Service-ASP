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
	/// money ��ժҪ˵����
	/// </summary>
	public class money : System.Web.UI.Page
	{
		Cpass cpa =new Cpass();
		private void Page_Load(object sender, System.EventArgs e)
		{
			try
			{
					string user= Session["usename"].ToString();
				string pwd=Session["pwds"].ToString() ; //��ñ���ֵ	
				if(cpa.CH(user, pwd, "���ù���")=="Norights")//�û�������������Ȩ��					
					Response.Redirect("index.aspx"); } 
			catch{  Response.Redirect("index.aspx");} 	
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			
		}
	}
}
