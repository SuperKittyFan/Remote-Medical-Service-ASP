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

namespace 医院管理系统
{
	/// <summary>
	/// index 的摘要说明。
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
			//Session["usename"] =Tname.Text;// 在此处放置用户代码以初始化页面
		}

		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
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
				Response.Write("<script language=javascript>alert('你的用户名或密码有误！')</script>") ;
				//Response.Redirect("index.aspx");
			
			}
			else
			{		
				Session["usename"] =Tname.Text; //传递用户名和密码值
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
