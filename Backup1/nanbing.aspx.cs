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
	/// nanbing ��ժҪ˵����
	/// </summary>
	public class nanbing : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button4;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.DropDownList d2;
		protected System.Web.UI.WebControls.TextBox tage;
		protected System.Web.UI.WebControls.TextBox tsex;
		protected System.Web.UI.WebControls.TextBox tname;
		protected System.Web.UI.WebControls.TextBox tnumber;
		protected System.Web.UI.WebControls.Panel p1;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Data.SqlClient.SqlConnection cnn;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlDataAdapter sda;
		protected System.Data.SqlClient.SqlCommand cmd1;
		protected ҽԺ����ϵͳ.dss dss1;
		protected ҽԺ����ϵͳ.ds3 ds31;
		protected System.Data.SqlClient.SqlDataAdapter sd2;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected System.Data.SqlClient.SqlCommand cmd;
		protected System.Web.UI.WebControls.TextBox tbk;
		protected System.Web.UI.WebControls.TextBox tgm;
		protected System.Web.UI.WebControls.TextBox tnum;
		Cpass cpa =new Cpass();
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			
			try
			{
				string user= Session["usename"].ToString();
				string pwd=Session["pwds"].ToString() ; //��ñ���ֵ	
				if(cpa.CH(user, pwd, "����")=="Norights")//�û�������������Ȩ��	
					
					Response.Redirect("index.aspx");
			
			} 
			catch
			{
				Response.Redirect("index.aspx");
		
			} 	
			if(cnn.State==0) cnn.Open();
			this.sd2.SelectCommand.ExecuteNonQuery();
			this.sd2.Fill(ds31);
			this.d2.DataBind();
			cnn.Close();
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
			this.cmd1 = new System.Data.SqlClient.SqlCommand();
			this.dss1 = new ҽԺ����ϵͳ.dss();
			this.ds31 = new ҽԺ����ϵͳ.ds3();
			this.sd2 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.cmd = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.dss1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds31)).BeginInit();
			this.DataGrid1.SelectedIndexChanged += new System.EventHandler(this.DataGrid1_SelectedIndexChanged);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// cnn
			// 
			this.cnn.ConnectionString = "workstation id=LYJ805;packet size=4096;integrated security=SSPI;data source=\".\";p" +
				"ersist security info=False;initial catalog=ҽԺ����ϵͳ";
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "[sel1]";
			this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand1.Connection = this.cnn;
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Һź���", System.Data.SqlDbType.NVarChar, 20));
			// 
			// sda
			// 
			this.sda.DeleteCommand = this.sqlDeleteCommand1;
			this.sda.InsertCommand = this.sqlInsertCommand1;
			this.sda.SelectCommand = this.sqlSelectCommand1;
			this.sda.UpdateCommand = this.sqlUpdateCommand1;
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
			// ds31
			// 
			this.ds31.DataSetName = "ds3";
			this.ds31.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sd2
			// 
			this.sd2.DeleteCommand = this.sqlDeleteCommand2;
			this.sd2.InsertCommand = this.sqlInsertCommand2;
			this.sd2.SelectCommand = this.sqlSelectCommand2;
			this.sd2.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "[ysheng]";
			this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand2.Connection = this.cnn;
			this.sqlSelectCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			// 
			// cmd
			// 
			this.cmd.CommandText = "[nanbing1]";
			this.cmd.CommandType = System.Data.CommandType.StoredProcedure;
			this.cmd.Connection = this.cnn;
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Һź���", System.Data.SqlDbType.NVarChar, 10));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 50));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ա�", System.Data.SqlDbType.NVarChar, 10));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 10));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���Ѳ���", System.Data.SqlDbType.NVarChar, 500));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ҩ��", System.Data.SqlDbType.NVarChar, 200));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ҽʦ", System.Data.SqlDbType.NVarChar, 50));
			this.d2.SelectedIndexChanged += new System.EventHandler(this.d2_SelectedIndexChanged);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dss1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds31)).EndInit();

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			if(cnn.State==0) cnn.Open();
			sda.SelectCommand.Parameters["@�Һź���"].Value=tnum.Text;
			sda.SelectCommand.ExecuteNonQuery ();
			this.dss1.Clear();
			this.sda.Fill(dss1);
			this.DataGrid1.DataBind();
			cnn.Close();
		}

		private void DataGrid1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(cnn.State==0) cnn.Open();
			cmd1.Parameters["@id"].Value=Convert.ToString(DataGrid1.SelectedItem.Cells[0].Text);
			SqlDataReader rd=cmd1.ExecuteReader();
			while (rd.Read())
			{
				tnumber.Text =rd.GetValue(0).ToString();
				tname.Text =rd.GetValue(1).ToString();
				tsex.Text =rd.GetValue(2).ToString();
				tage.Text =rd.GetValue(3).ToString();
			}
		}

		private void d2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}

		private void Button4_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("jiuzhen.aspx");
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(cnn.State==0) cnn.Open();
				cmd.Parameters["@�Һź���"].Value =tnumber.Text ;
				cmd.Parameters["@����"].Value =tname.Text ;
				cmd.Parameters["@�Ա�"].Value =tsex.Text ;
				cmd.Parameters["@����"].Value =tage.Text ;
				cmd.Parameters["@���Ѳ���"].Value =tbk.Text ;
				cmd.Parameters["@����ҩ��"].Value =tgm.Text ;
				cmd.Parameters["@ҽʦ"].Value =d2.SelectedValue ;
				cmd.ExecuteNonQuery();
				cnn.Close();
				Response.Write("<script language=javascript>alert('��ӳɹ���');</script>") ;
			}
			catch
			{
				Response.Write("<script language=javascript>alert('�����Ѿ����ڣ���������ӣ�');</script>") ;
			}
		
		}
	}
}
