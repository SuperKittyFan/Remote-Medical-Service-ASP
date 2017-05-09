using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 医院管理系统
{
    public partial class chpasswd : System.Web.UI.Page
    {
        protected System.Data.SqlClient.SqlConnection cnn;
        protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        protected System.Data.SqlClient.SqlDataAdapter sda;
        protected 医院管理系统.ds1 ds11;
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
            this.cnn = new System.Data.SqlClient.SqlConnection();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sda = new System.Data.SqlClient.SqlDataAdapter();
            this.ds11 = new 医院管理系统.ds1();
            ((System.ComponentModel.ISupportInitialize)(this.ds11)).BeginInit();
            // 
            // cnn
            // 
            this.cnn.ConnectionString = "Data source=101.200.176.230;Initial Catalog=医院管理系统;User ID=sa;Password=cldera.comSQL";
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = "[mimagai]";
            this.sqlUpdateCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand1.Connection = this.cnn;
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@useid", System.Data.SqlDbType.NVarChar, 20));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@pwd", System.Data.SqlDbType.NVarChar, 20));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@rights", System.Data.SqlDbType.NVarChar, 40));
            //sda
            this.sda.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // ds11
            // 
            this.ds11.DataSetName = "ds1";
            this.ds11.Locale = new System.Globalization.CultureInfo("zh-CN");

        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, System.EventArgs e)
        {
            if (cnn.State == 0) cnn.Open();

            sda.UpdateCommand.Parameters["@useid"].Value = Session["usename"].ToString();
                sda.UpdateCommand.Parameters["@pwd"].Value = tpwd.Text;
                Session["pwds"] = tpwd.Text;
                sda.UpdateCommand.Parameters["@rights"].Value = d1.SelectedValue;
                sda.UpdateCommand.ExecuteNonQuery();
                Response.Write("<script language=javascript>alert('修改成功！');window.location = 'webmenu.aspx';</script>");
        }
        protected void Button3_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("webmenu.aspx");

        }
    }
}