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
using System.IO;

namespace 医院管理系统
{
	/// <summary>
	/// jzhenzhao 的摘要说明。
	/// </summary>
	public partial class jzhenzhao : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlDataAdapter sda;
		protected System.Data.SqlClient.SqlConnection cnn;
		protected 医院管理系统.jzzhao jzzhao1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        protected System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        protected System.Data.SqlClient.SqlDataAdapter sda1;
        protected System.Data.SqlClient.SqlDataAdapter sda2;
		protected System.Data.SqlClient.SqlCommand cmd;
		Cpass cpa =new Cpass(); 
	
		protected void Page_Load(object sender, System.EventArgs e)
		{	
			if(!IsPostBack)
			{
				fill();
			}
		}
		private void fill()
		{
			if(cnn.State==0) cnn.Open();
		sda.SelectCommand.ExecuteNonQuery();
		jzzhao1.Clear(); 
		sda.Fill(jzzhao1); 
		cnn.Close();
		DataGrid1.DataBind(); 
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
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.cnn = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sda = new System.Data.SqlClient.SqlDataAdapter();
			this.jzzhao1 = new 医院管理系统.jzzhao();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sda1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sda2 = new System.Data.SqlClient.SqlDataAdapter();
			this.cmd = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.jzzhao1)).BeginInit();
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "[jzzhao]";
			this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand1.Connection = this.cnn;
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			// 
            //sqldelectcommmand1
            this.sqlDeleteCommand1.CommandText = "[deldata]";
            this.sqlDeleteCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand1.Connection = this.cnn;
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4));
			// cnn
			// 
            this.cnn.ConnectionString = "Data source=101.200.176.230;Initial Catalog=医院管理系统;User ID=sa;Password=cldera.comSQL";
			// 
			// sda
			// 
			this.sda.DeleteCommand = this.sqlDeleteCommand1;
			this.sda.InsertCommand = this.sqlInsertCommand1;
			this.sda.SelectCommand = this.sqlSelectCommand1;
			this.sda.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// jzzhao1
			// 
			this.jzzhao1.DataSetName = "jzzhao";
			this.jzzhao1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "[seljz]";
			this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand2.Connection = this.cnn;
			this.sqlSelectCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlSelectCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@挂号号码", System.Data.SqlDbType.NVarChar, 20));
			// 
			// sda1
			// 
			this.sda1.DeleteCommand = this.sqlDeleteCommand2;
			this.sda1.InsertCommand = this.sqlInsertCommand2;
			this.sda1.SelectCommand = this.sqlSelectCommand2;
			this.sda1.UpdateCommand = this.sqlUpdateCommand2;
			// 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "[seldevice]";
            this.sqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand3.Connection = this.cnn;
            this.sqlSelectCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
            this.sqlSelectCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@仪器编号", System.Data.SqlDbType.NVarChar, 20));
            // 
            // sda2
            // 
            this.sda1.DeleteCommand = this.sqlDeleteCommand2;
            this.sda1.InsertCommand = this.sqlInsertCommand2;
            this.sda2.SelectCommand = this.sqlSelectCommand3;
            this.sda1.UpdateCommand = this.sqlUpdateCommand2;
            // 
			// cmd 查找特定病历详细信息
			// 
			this.cmd.CommandText = "[jz]";
			this.cmd.CommandType = System.Data.CommandType.StoredProcedure;
			this.cmd.Connection = this.cnn;
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4));
			((System.ComponentModel.ISupportInitialize)(this.jzzhao1)).EndInit();

		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e)
		{
            p1.Visible = false;
            if (cnn.State == 0) cnn.Open();
            sda1.SelectCommand.Parameters["@挂号号码"].Value = TextBox1.Text;
            sda1.SelectCommand.ExecuteNonQuery();
            this.jzzhao1.Clear();
            this.sda1.Fill(jzzhao1);
            this.DataGrid1.DataBind();
            cnn.Close();
		}
        protected void Button4_Click(object sender, EventArgs e)
        {
            p1.Visible = false;
            if (cnn.State == 0) cnn.Open();
            sda2.SelectCommand.Parameters["@仪器编号"].Value = TextBox2.Text;
            sda2.SelectCommand.ExecuteNonQuery();
            this.jzzhao1.Clear();
            this.sda2.Fill(jzzhao1);
            this.DataGrid1.DataBind();
            cnn.Close();
        }
		protected void Button2_Click(object sender, System.EventArgs e)
		{
			if(DataGrid1.SelectedIndex==-1)
			{
				Response.Write("<script language=javascript>alert('你还没选择数据记录呢！');</script>") ;
			}
			else
			{
				if(cnn.State==0) cnn.Open();
				p1.Visible =true;
				cmd.Parameters["@id"].Value=Convert.ToInt32(DataGrid1.SelectedItem.Cells[0].Text);
				Label14.Text=DataGrid1.SelectedItem.Cells[1].Text+"——详细信息";
				SqlDataReader rd=cmd.ExecuteReader();
				while (rd.Read())
				{
					this.Label1.Text =rd.GetValue(0).ToString();
					this.Label2.Text =rd.GetValue(1).ToString();
					this.Label3.Text =rd.GetValue(2).ToString();
					this.Label4.Text =rd.GetValue(3).ToString();
					this.Label5.Text =rd.GetValue(14).ToString();
					this.Label6.Text =rd.GetValue(5).ToString();
					this.Label7.Text =rd.GetValue(7).ToString();
					this.Label8.Text =rd.GetValue(6).ToString();
					this.Label9.Text =rd.GetValue(9).ToString();
					this.Label10.Text =rd.GetValue(10).ToString();
					this.Label11.Text =rd.GetValue(8).ToString();
					this.Label12.Text =rd.GetValue(11).ToString();
					this.Label13.Text =rd.GetValue(12).ToString();
                    this.Label15.Text = rd.GetValue(4).ToString();
                    this.Label16.Text = rd.GetValue(13).ToString();
				}
			}
		}

		protected void DataGrid1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			p1.Visible =false;
		}

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			DataGrid1.CurrentPageIndex = e.NewPageIndex;
			fill();
		}

		protected void Button3_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("webmenu.aspx");
		}

        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnn.State == 0) cnn.Open();
                cmd.Parameters["@id"].Value = Convert.ToInt32(DataGrid1.SelectedItem.Cells[0].Text);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                // 获取文件在服务器的地址    
                String url = rd.GetValue(13).ToString();
                String fileName = url.Substring(url.LastIndexOf("\\") + 1);
                // 判断传输地址是否为空    
                if (fileName == "")
                {
                    // 提示“该文件暂不提供下载”    
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script defer>alert('该文件暂不提供下载！');</script>");
                    return;
                }
                // 以字符流的方式下载文件    
                FileStream fileStream = new FileStream(@url, FileMode.Open);
                byte[] bytes = new byte[(int)fileStream.Length];
                fileStream.Read(bytes, 0, bytes.Length);
                fileStream.Close();
                Response.ContentType = "application/octet-stream";

                // 通知浏览器下载   
                Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName);
                Response.BinaryWrite(bytes);
                Response.Flush();
                Response.End();
            }
            catch
            {
            }
       }  
        

        protected void Button8_Click(object sender, EventArgs e)
        {
            if (DataGrid1.SelectedIndex == -1)
            {
                Response.Write("<script language=javascript>alert('你还没选择数据记录呢！');</script>");
            }
            else
            {
                string user = Session["usename"].ToString();
                string pwd = Session["pwds"].ToString();
                if (cpa.CH(user, pwd, "管理员") == "Norights")//用户名或密码错或无权限	
                {//用户名或密码错或无权限
                    Response.Write("<script language=javascript>alert('您不是管理员，无法删除记录！');window.location = 'jzhenzhao.aspx';</script>");
                }
                if (cnn.State == 0) cnn.Open();
                sda.DeleteCommand.Parameters["@id"].Value = Convert.ToInt32(DataGrid1.SelectedItem.Cells[0].Text);
                sda.DeleteCommand.ExecuteNonQuery();
                jzzhao1.Clear();
                sda.Fill(jzzhao1);
                cnn.Close();
                DataGrid1.DataBind(); 

            }

        }

        
	}
}
