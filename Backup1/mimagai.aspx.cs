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

namespace ҽԺ����ϵͳ
{
	/// <summary>
	/// mimagai ��ժҪ˵����
	/// </summary>
	public class mimagai : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlConnection cnn;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlDataAdapter sda;
		protected System.Web.UI.WebControls.ValidationSummary ValidationSummary1;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected ҽԺ����ϵͳ.ds1 ds11;
		protected System.Data.SqlClient.SqlCommand cmd;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator3;
		protected System.Web.UI.WebControls.DropDownList d1;
		protected System.Web.UI.WebControls.CompareValidator CompareValidator1;
		protected System.Web.UI.WebControls.TextBox TextBox3;
		protected System.Web.UI.WebControls.TextBox tpwd;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Panel p1;
		 Cpass cpa =new Cpass();
	    
		private void Page_Load(object sender, System.EventArgs e)
		{
			try
			{
				string user= Session["usename"].ToString();
				string pwd=Session["pwds"].ToString() ; //��ñ���ֵ	
				if(cpa.CH(user, pwd, "���ڷ���")=="Norights")//�û�������������Ȩ��					
					Response.Redirect("index.aspx"); } 
			catch{  Response.Redirect("index.aspx");} 
			if(!IsPostBack)
			{
				fills();
			}
			this.p1.Visible =true;
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
			this.ds11 = new ҽԺ����ϵͳ.ds1();
			this.cmd = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.ds11)).BeginInit();
			// 
			// cnn
			// 
			this.cnn.ConnectionString = "workstation id=LYJ805;packet size=4096;integrated security=SSPI;data source=\".\";p" +
				"ersist security info=False;initial catalog=ҽԺ����ϵͳ";
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "[selall]";
			this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand1.Connection = this.cnn;
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "[mimagai]";
			this.sqlUpdateCommand1.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlUpdateCommand1.Connection = this.cnn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@useid", System.Data.SqlDbType.NVarChar, 20));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@pwd", System.Data.SqlDbType.NVarChar, 20));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@rights", System.Data.SqlDbType.NVarChar, 40));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "[delmima]";
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
			// ds11
			// 
			this.ds11.DataSetName = "ds1";
			this.ds11.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// cmd
			// 
			this.cmd.CommandText = "[gai11]";
			this.cmd.CommandType = System.Data.CommandType.StoredProcedure;
			this.cmd.Connection = this.cnn;
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.NVarChar, 20));
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			this.DataGrid1.SelectedIndexChanged += new System.EventHandler(this.DataGrid1_SelectedIndexChanged);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.ds11)).EndInit();

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			if(DataGrid1.SelectedIndex==-1)
			{
				Response.Write("<script language=javascript>alert('�㻹ûѡ��');</script>") ;
			}
			else
			{
			if(cnn.State==0) cnn.Open();
			sda.UpdateCommand.Parameters["@useid"].Value=this.Label1.Text;
			sda.UpdateCommand.Parameters["@pwd"].Value =tpwd.Text;
			sda.UpdateCommand.Parameters["@rights"].Value =d1.SelectedValue;
			sda.UpdateCommand.ExecuteNonQuery();
			Response.Write("<script language=javascript>alert('�޸ĳɹ���');</script>") ;
				}
		}
		private void fills()
		{
			if(cnn.State==0) cnn.Open();
			sda.SelectCommand.ExecuteNonQuery();
			ds11.Clear(); 
			sda.Fill(ds11); 
			cnn.Close();
			DataGrid1.DataBind(); 
		}

		private void DataGrid1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			

				if(cnn.State==0) cnn.Open();
				//p1.Visible =true;
				cmd.Parameters["@id"].Value=Convert.ToString (DataGrid1.SelectedItem.Cells[0].Text);
				SqlDataReader rd=cmd.ExecuteReader();
				while (rd.Read())
				{
					this.Label1.Text =rd.GetValue(0).ToString();
					
				}
				
			
		}

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			DataGrid1.CurrentPageIndex = e.NewPageIndex;
			fills();
		}

		private void Button2_Click(object sender, System.EventArgs e)
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
