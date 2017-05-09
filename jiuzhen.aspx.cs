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
using System.Data.SqlClient;

namespace 医院管理系统
{
	/// <summary>
	/// jiuzhen 的摘要说明。
	/// </summary>
	public partial class jiuzhen : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlConnection cnn;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlDataAdapter sda;
		protected System.Data.SqlClient.SqlCommand cmd;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected System.Data.SqlClient.SqlDataAdapter sd2;
		protected 医院管理系统.ds3 ds31;
		protected System.Data.SqlClient.SqlCommand cmd1;
		protected 医院管理系统.dss dss1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand3;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
		protected System.Data.SqlClient.SqlDataAdapter sda1;
		protected 医院管理系统.sda1 sda11;
		
		Cpass cpa =new Cpass(); 
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
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
			this.cnn = new System.Data.SqlClient.SqlConnection();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sda = new System.Data.SqlClient.SqlDataAdapter();
			this.cmd = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sd2 = new System.Data.SqlClient.SqlDataAdapter();
			this.ds31 = new 医院管理系统.ds3();
			this.cmd1 = new System.Data.SqlClient.SqlCommand();
			this.dss1 = new 医院管理系统.dss();
			this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sda1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sda11 = new 医院管理系统.sda1();
			((System.ComponentModel.ISupportInitialize)(this.ds31)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dss1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sda11)).BeginInit();
			// 
			// cnn
			// 
            this.cnn.ConnectionString = "Data source=101.200.176.230;Initial Catalog=医院管理系统;User ID=sa;Password=cldera.comSQL";
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "[sel1]";
			this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand1.Connection = this.cnn;
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@挂号号码", System.Data.SqlDbType.NVarChar, 20));
			// 
			// sda
			// 
			this.sda.DeleteCommand = this.sqlDeleteCommand1;
			this.sda.InsertCommand = this.sqlInsertCommand1;
			this.sda.SelectCommand = this.sqlSelectCommand1;
			this.sda.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// cmd
			// 
			this.cmd.CommandText = "[jiuzhen1]";
			this.cmd.CommandType = System.Data.CommandType.StoredProcedure;
			this.cmd.Connection = this.cnn;
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@挂号号码", System.Data.SqlDbType.BigInt, 8));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@姓名", System.Data.SqlDbType.NVarChar, 40));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@年龄", System.Data.SqlDbType.NVarChar, 10));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@性别", System.Data.SqlDbType.NVarChar, 10));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@异常", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@诊断病况", System.Data.SqlDbType.NVarChar, 100));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@医师", System.Data.SqlDbType.NVarChar, 20));
            this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@职业", System.Data.SqlDbType.NVarChar, 50));
            this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@路径", System.Data.SqlDbType.NVarChar, 50));
            this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@开始时间", System.Data.SqlDbType.NVarChar, 50));
            this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@结束时间", System.Data.SqlDbType.NVarChar, 50));
            this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@医院", System.Data.SqlDbType.NVarChar, 50));
            this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@胶囊编号", System.Data.SqlDbType.NVarChar, 50));
            this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@仪器编号", System.Data.SqlDbType.NVarChar, 50));


			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "[ysheng]";
			this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand2.Connection = this.cnn;
			this.sqlSelectCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			// 
			// sd2
			// 
			this.sd2.DeleteCommand = this.sqlDeleteCommand2;
			this.sd2.InsertCommand = this.sqlInsertCommand2;
			this.sd2.SelectCommand = this.sqlSelectCommand2;
			this.sd2.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// ds31
			// 
			this.ds31.DataSetName = "ds3";
			this.ds31.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// cmd1
			// 
			this.cmd1.CommandText = "[gh]";
			this.cmd1.CommandType = System.Data.CommandType.StoredProcedure;
			this.cmd1.Connection = this.cnn;
			this.cmd1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.cmd1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4));
			// 
			// dss1
			// 
			this.dss1.DataSetName = "dss";
			this.dss1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlSelectCommand3
			// 
			this.sqlSelectCommand3.CommandText = "[z1]";
			this.sqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand3.Connection = this.cnn;
			this.sqlSelectCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			// 
			// sda1
			// 
			this.sda1.DeleteCommand = this.sqlDeleteCommand3;
			this.sda1.InsertCommand = this.sqlInsertCommand3;
			this.sda1.SelectCommand = this.sqlSelectCommand3;
			this.sda1.UpdateCommand = this.sqlUpdateCommand3;
			// 
			// sda11
			// 
			this.sda11.DataSetName = "sda1";
			this.sda11.Locale = new System.Globalization.CultureInfo("zh-CN");
			((System.ComponentModel.ISupportInitialize)(this.ds31)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dss1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sda11)).EndInit();

		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e)
		{
		}

		protected void Button3_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("jzhenzhao.aspx");
		}
        //点击确定触发
		protected void Button2_Click(object sender, System.EventArgs e)
		{
           
			try
			{
                //取出所选文件的本地路径  
                string fullFileName = this.File1.PostedFile.FileName;
                //从路径中截取出文件名  
                string fileName = fullFileName.Substring(fullFileName.LastIndexOf("\\") + 1);
                //限定上传文件的格式  
                string type = fullFileName.Substring(fullFileName.LastIndexOf(".") + 1);
                string saveFileName = Server.MapPath("/files") + "\\" + fileName;
                if (type == "DAT" || type == "dat")
                {
                    //将文件保存在服务器中根目录下的files文件夹中  
                    File1.PostedFile.SaveAs(saveFileName);
                }
				if(cnn.State==0) cnn.Open();
				cmd.Parameters["@挂号号码"].Value =tnumber.Text ;
                cmd.Parameters["@职业"].Value = tocc.Text;
				cmd.Parameters["@姓名"].Value =tname.Text ;
				cmd.Parameters["@性别"].Value =tsex.Text ;
				cmd.Parameters["@年龄"].Value =tage.Text ;
				cmd.Parameters["@异常"].Value =r1.SelectedValue ;//有无异常
				cmd.Parameters["@诊断病况"].Value =tbk.Text ;
				cmd.Parameters["@医师"].Value =tdoc.Text;
                cmd.Parameters["@开始时间"].Value = tstart.Text;
                cmd.Parameters["@结束时间"].Value = tend.Text;
                cmd.Parameters["@路径"].Value = saveFileName;
                cmd.Parameters["@医院"].Value = thosp.Text;
                cmd.Parameters["@胶囊编号"].Value = telec.Text;
                cmd.Parameters["@仪器编号"].Value = trec.Text;
				cmd.ExecuteNonQuery();
				cnn.Close();
				Response.Write("<script language=javascript>alert('添加成功！');</script>") ;
			
			}
			catch{
			Response.Write("<script language=javascript>alert('添加失败！');</script>") ;
			}
		}

		protected void d2_SelectedIndexChanged(object sender, System.EventArgs e)
		{

		
		}

		protected void DataGrid1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		}
		
		private void fills()
		{
			if(cnn.State==0) cnn.Open();
			sda1.SelectCommand.ExecuteNonQuery();
			sda11.Clear(); 
			sda1.Fill(sda11);
			cnn.Close();
		}

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
//			this.DataGrid1 .CurrentPageIndex =e.NewPageIndex ;
//			fills();
		}

		protected void Button4_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("webmenu.aspx");
		}

		
	}
}
