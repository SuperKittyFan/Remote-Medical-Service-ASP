using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 医院管理系统
{
    public partial class home : System.Web.UI.Page
    {
        Cpass cpa = new Cpass();

        protected void Page_Load(object sender, System.EventArgs e)
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

        }
        #endregion

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            if (Tname.Text == "")
            {
                Response.Write("<script language=javascript>alert('用户名不能为空！');window.location = 'home.aspx';</script>");
            }
            else if (cpa.CH(Tname.Text, Tpwd.Text, "") == "Nopasscheck")
            {
                Response.Write("<script language=javascript>alert('你的用户名或密码有误！');window.location = 'home.aspx';</script>");
                //Response.Redirect("index.aspx");
            }
            else
            {
                Session["usename"] = Tname.Text; //传递用户名和密码值
                Session["pwds"] = Tpwd.Text;
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