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
	/// jiuzhen ��ժҪ˵����
	/// </summary>
	public class jiuzhen : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Web.UI.WebControls.TextBox tnum;
		protected System.Data.SqlClient.SqlConnection cnn;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlDataAdapter sda;
		protected System.Web.UI.WebControls.Button Button3;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.TextBox tfh;
		protected System.Web.UI.WebControls.TextBox ttj;
		protected System.Web.UI.WebControls.TextBox tyf;
		protected System.Web.UI.WebControls.TextBox tbk;
		protected System.Web.UI.WebControls.Panel p1;
		protected System.Web.UI.WebControls.TextBox tnumber;
		protected System.Web.UI.WebControls.TextBox tname;
		protected System.Web.UI.WebControls.TextBox tsex;
		protected System.Web.UI.WebControls.TextBox tage;
		protected System.Web.UI.WebControls.RadioButtonList r1;
		protected System.Web.UI.WebControls.RadioButtonList r2;
		protected System.Web.UI.WebControls.DropDownList d1;
		protected System.Web.UI.WebControls.DropDownList d2;
		protected System.Data.SqlClient.SqlCommand cmd;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected System.Data.SqlClient.SqlDataAdapter sd2;
		protected ҽԺ����ϵͳ.ds3 ds31;
		protected System.Data.SqlClient.SqlCommand cmd1;
		protected ҽԺ����ϵͳ.dss dss1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand3;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
		protected System.Data.SqlClient.SqlDataAdapter sda1;
		protected ҽԺ����ϵͳ.sda1 sda11;
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Web.UI.WebControls.Button Button4;
		protected System.Web.UI.WebControls.Button Button5;
		
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
			catch{  Response.Redirect("index.aspx");
		
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
			this.cmd = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sd2 = new System.Data.SqlClient.SqlDataAdapter();
			this.ds31 = new ҽԺ����ϵͳ.ds3();
			this.cmd1 = new System.Data.SqlClient.SqlCommand();
			this.dss1 = new ҽԺ����ϵͳ.dss();
			this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sda1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sda11 = new ҽԺ����ϵͳ.sda1();
			((System.ComponentModel.ISupportInitialize)(this.ds31)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dss1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sda11)).BeginInit();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			this.DataGrid1.SelectedIndexChanged += new System.EventHandler(this.DataGrid1_SelectedIndexChanged);
			this.d2.SelectedIndexChanged += new System.EventHandler(this.d2_SelectedIndexChanged);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			// 
			// cnn
			// 
			this.cnn.ConnectionString = "workstation id=\"802-HUANGHAI\";packet size=4096;integrated security=SSPI;data sour" +
				"ce=\".\";persist security info=False;initial catalog=ҽԺ����ϵͳ";
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
			// cmd
			// 
			this.cmd.CommandText = "[jiuzhen1]";
			this.cmd.CommandType = System.Data.CommandType.StoredProcedure;
			this.cmd.Connection = this.cnn;
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Һź���", System.Data.SqlDbType.BigInt, 8));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 40));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 10));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ա�", System.Data.SqlDbType.NVarChar, 10));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@סԺ", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ʵ��", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ϲ���", System.Data.SqlDbType.NVarChar, 100));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ҩ��", System.Data.SqlDbType.NVarChar, 100));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 100));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 100));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ҽʦ", System.Data.SqlDbType.NVarChar, 20));
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
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.ds31)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dss1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sda11)).EndInit();

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
			//p1.Visible =true;
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("jzhenzhao.aspx");
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
				cmd.Parameters["@סԺ"].Value =r1.SelectedValue ;
				cmd.Parameters["@����"].Value =r2.SelectedValue ;
				cmd.Parameters["@ʵ��"].Value =d1.SelectedValue ;
				cmd.Parameters["@��ϲ���"].Value =tbk.Text ;
				cmd.Parameters["@����ҩ��"].Value =tyf.Text ;
				cmd.Parameters["@����"].Value =ttj.Text ;
				cmd.Parameters["@����"].Value =tfh.Text ;
				cmd.Parameters["@ҽʦ"].Value =d2.SelectedValue ;
				cmd.ExecuteNonQuery();
				cnn.Close();
				Response.Write("<script language=javascript>alert('��ӳɹ���');</script>") ;
			
			}
			catch{
			Response.Write("<script language=javascript>alert('��Ĳ����Ѿ����ڣ���������ӣ�');</script>") ;
			}
		}

		private void d2_SelectedIndexChanged(object sender, System.EventArgs e)
		{

		
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
		
		private void fills()
		{
			if(cnn.State==0) cnn.Open();
			sda1.SelectCommand.ExecuteNonQuery();
			sda11.Clear(); 
			sda1.Fill(sda11); 
			this.DataGrid1.DataBind(); 
			cnn.Close();
		}

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
//			this.DataGrid1 .CurrentPageIndex =e.NewPageIndex ;
//			fills();
		}

		private void Button4_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("index.aspx");
		}

		private void Button5_Click(object sender, System.EventArgs e)
		{
		this.Response.Redirect("nanbing.aspx");
		}
	}
}
