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
	/// guahaocz ��ժҪ˵����
	/// </summary>
	public class guahaocz : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Data.SqlClient.SqlConnection cnn;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlDataAdapter sda;
		protected ҽԺ����ϵͳ.guacz guacz1;
		protected System.Web.UI.WebControls.TextBox tnum;
		protected System.Web.UI.WebControls.TextBox tname;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected System.Data.SqlClient.SqlDataAdapter sda1;
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Button Button3;
		protected System.Web.UI.WebControls.Button Button1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				fills();
			}
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
			this.cnn = new System.Data.SqlClient.SqlConnection();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sda = new System.Data.SqlClient.SqlDataAdapter();
			this.guacz1 = new ҽԺ����ϵͳ.guacz();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sda1 = new System.Data.SqlClient.SqlDataAdapter();
			((System.ComponentModel.ISupportInitialize)(this.guacz1)).BeginInit();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// cnn
			// 
			this.cnn.ConnectionString = "workstation id=\"802-HUANGHAI\";packet size=4096;integrated security=SSPI;data sour" +
				"ce=\".\";persist security info=False;initial catalog=ҽԺ����ϵͳ";
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "[guahaocz]";
			this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand1.Connection = this.cnn;
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sel", System.Data.SqlDbType.NVarChar, 20));
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.NVarChar, 50));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "[z6]";
			this.sqlDeleteCommand1.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlDeleteCommand1.Connection = this.cnn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@num", System.Data.SqlDbType.NVarChar, 20));
			// 
			// sda
			// 
			this.sda.DeleteCommand = this.sqlDeleteCommand1;
			this.sda.InsertCommand = this.sqlInsertCommand1;
			this.sda.SelectCommand = this.sqlSelectCommand1;
			this.sda.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// guacz1
			// 
			this.guacz1.DataSetName = "guacz";
			this.guacz1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "[guafill]";
			this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand2.Connection = this.cnn;
			this.sqlSelectCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			// 
			// sda1
			// 
			this.sda1.DeleteCommand = this.sqlDeleteCommand2;
			this.sda1.InsertCommand = this.sqlInsertCommand2;
			this.sda1.SelectCommand = this.sqlSelectCommand2;
			this.sda1.UpdateCommand = this.sqlUpdateCommand2;
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.guacz1)).EndInit();

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			if(cnn.State==0) cnn.Open();
			sda.SelectCommand.Parameters["@sel"].Value=tnum.Text;
			sda.SelectCommand.Parameters["@name"].Value=tname.Text;
			sda.SelectCommand.ExecuteNonQuery();
			this.guacz1.Clear();
			this.sda.Fill(guacz1);
			this.DataGrid1.DataBind();
			cnn.Close();
		}
		private void fills()
		{
		if(cnn.State==0) cnn.Open();
			sda1.SelectCommand.ExecuteNonQuery();
			this.guacz1.Clear();
			this.sda1.Fill(guacz1);
			this.DataGrid1.DataBind();
			cnn.Close();
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			this.Response .Redirect("guahao.aspx");
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			if(DataGrid1.SelectedIndex==-1)
			{
				Response.Write("<script language=javascript>alert('�㻹ûѡ��');</script>") ;
			}
			else
			{
		
				if(cnn.State==0) cnn.Open();
				sda.DeleteCommand.Parameters["@num"].Value=DataGrid1.SelectedItem.Cells[0].Text;
				sda.DeleteCommand.ExecuteNonQuery ();
				cnn.Close();
				fills();
				this.DataGrid1.SelectedIndex=-1;
			}
		}
	}
}
