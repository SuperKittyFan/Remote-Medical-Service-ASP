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

namespace ҽԺ����ϵͳ
{
	/// <summary>
	/// bedid ��ժҪ˵����
	/// </summary>
	public class bedid : System.Web.UI.Page
		 
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Web.UI.WebControls.Button Button4;
		protected System.Data.SqlClient.SqlConnection cnn;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlDataAdapter sda;
		protected ҽԺ����ϵͳ.zhu zhu1;
		protected System.Data.SqlClient.SqlCommand cmd;
		protected System.Web.UI.WebControls.Panel p1;
		protected System.Web.UI.WebControls.TextBox tch;
		protected System.Web.UI.WebControls.TextBox tnum;
		protected System.Web.UI.WebControls.TextBox tname;
		protected System.Web.UI.WebControls.TextBox tage;
		protected System.Web.UI.WebControls.RadioButtonList r1;
		protected System.Web.UI.WebControls.DropDownList d1;
		protected System.Web.UI.WebControls.DropDownList d2;
		protected System.Web.UI.WebControls.DropDownList d3;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.TextBox t1;
		protected ҽԺ����ϵͳ.allpepole allpepole1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator2;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator3;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator4;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator5;
		protected System.Web.UI.WebControls.ValidationSummary ValidationSummary1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected System.Data.SqlClient.SqlDataAdapter sda1;
		protected ҽԺ����ϵͳ.zhuyuan zhuyuan1;
		protected System.Data.SqlClient.SqlCommand cmd1;
		protected System.Web.UI.WebControls.HyperLink HyperLink2;
		protected System.Web.UI.WebControls.HyperLink HyperLink1;
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Web.UI.WebControls.DataGrid DataGrid2;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand3;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
		protected System.Data.SqlClient.SqlDataAdapter sda3;
		protected System.Data.SqlClient.SqlCommand cmd2;
		protected ҽԺ����ϵͳ.sda3 sda31;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.Button Button3;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand4;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand4;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand4;
		protected System.Data.SqlClient.SqlDataAdapter sda4;
		protected System.Web.UI.WebControls.Button Button5;
		Cpass cpa =new Cpass();
		private void Page_Load(object sender, System.EventArgs e)
		{   
			
						try
						{
								string user= Session["usename"].ToString();
							string pwd=Session["pwds"].ToString() ; //��ñ���ֵ	
							if(cpa.CH(user, pwd, "��λ����")=="Norights")//�û�������������Ȩ��					
								Response.Redirect("index.aspx"); } 
						catch{  Response.Redirect("index.aspx");} 	
			
			fills();
			fill();
			if(cnn.State==0) cnn.Open();
			sda1.SelectCommand.ExecuteNonQuery();
			zhuyuan1.Clear(); 
			sda1.Fill(zhuyuan1); 
			cnn.Close();
			d2.DataBind(); 
			
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
			this.zhu1 = new ҽԺ����ϵͳ.zhu();
			this.cmd = new System.Data.SqlClient.SqlCommand();
			this.allpepole1 = new ҽԺ����ϵͳ.allpepole();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sda1 = new System.Data.SqlClient.SqlDataAdapter();
			this.zhuyuan1 = new ҽԺ����ϵͳ.zhuyuan();
			this.cmd1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sda3 = new System.Data.SqlClient.SqlDataAdapter();
			this.cmd2 = new System.Data.SqlClient.SqlCommand();
			this.sda31 = new ҽԺ����ϵͳ.sda3();
			this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand4 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand4 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand4 = new System.Data.SqlClient.SqlCommand();
			this.sda4 = new System.Data.SqlClient.SqlDataAdapter();
			((System.ComponentModel.ISupportInitialize)(this.zhu1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.allpepole1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.zhuyuan1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sda31)).BeginInit();
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			this.DataGrid1.SelectedIndexChanged += new System.EventHandler(this.DataGrid1_SelectedIndexChanged);
			// 
			// cnn
			// 
			this.cnn.ConnectionString = "workstation id=\"802-HUANGHAI\";packet size=4096;integrated security=SSPI;data sour" +
				"ce=\".\";persist security info=False;initial catalog=ҽԺ����ϵͳ";
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "[tian]";
			this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand1.Connection = this.cnn;
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "[chuyuan]";
			this.sqlUpdateCommand1.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlUpdateCommand1.Connection = this.cnn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 20));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Һź���", System.Data.SqlDbType.NVarChar, 10));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 20));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ա�", System.Data.SqlDbType.NVarChar, 10));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 10));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 10));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������", System.Data.SqlDbType.NVarChar, 50));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʵ��", System.Data.SqlDbType.NVarChar, 20));
			// 
			// sda
			// 
			this.sda.DeleteCommand = this.sqlDeleteCommand1;
			this.sda.InsertCommand = this.sqlInsertCommand1;
			this.sda.SelectCommand = this.sqlSelectCommand1;
			this.sda.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// zhu1
			// 
			this.zhu1.DataSetName = "zhu";
			this.zhu1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// cmd
			// 
			this.cmd.CommandText = "[bedup]";
			this.cmd.CommandType = System.Data.CommandType.StoredProcedure;
			this.cmd.Connection = this.cnn;
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Һź���", System.Data.SqlDbType.NVarChar, 10));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ա�", System.Data.SqlDbType.NVarChar, 10));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 10));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.NVarChar, 10));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������", System.Data.SqlDbType.NVarChar, 50));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʵ��", System.Data.SqlDbType.NVarChar, 20));
			// 
			// allpepole1
			// 
			this.allpepole1.DataSetName = "allpepole";
			this.allpepole1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "[zhuy]";
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
			// 
			// zhuyuan1
			// 
			this.zhuyuan1.DataSetName = "zhuyuan";
			this.zhuyuan1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// cmd1
			// 
			this.cmd1.CommandText = "[zy]";
			this.cmd1.CommandType = System.Data.CommandType.StoredProcedure;
			this.cmd1.Connection = this.cnn;
			this.cmd1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.cmd1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4));
			// 
			// sqlSelectCommand3
			// 
			this.sqlSelectCommand3.CommandText = "[z2]";
			this.sqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand3.Connection = this.cnn;
			this.sqlSelectCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			// 
			// sda3
			// 
			this.sda3.DeleteCommand = this.sqlDeleteCommand3;
			this.sda3.InsertCommand = this.sqlInsertCommand3;
			this.sda3.SelectCommand = this.sqlSelectCommand3;
			this.sda3.UpdateCommand = this.sqlUpdateCommand3;
			// 
			// cmd2
			// 
			this.cmd2.CommandText = "[z3]";
			this.cmd2.CommandType = System.Data.CommandType.StoredProcedure;
			this.cmd2.Connection = this.cnn;
			this.cmd2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.cmd2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4));
			// 
			// sda31
			// 
			this.sda31.DataSetName = "sda3";
			this.sda31.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlSelectCommand4
			// 
			this.sqlSelectCommand4.CommandText = "[z4]";
			this.sqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlSelectCommand4.Connection = this.cnn;
			this.sqlSelectCommand4.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlSelectCommand4.Parameters.Add(new System.Data.SqlClient.SqlParameter("@num", System.Data.SqlDbType.NVarChar, 10));
			// 
			// sda4
			// 
			this.sda4.DeleteCommand = this.sqlDeleteCommand4;
			this.sda4.InsertCommand = this.sqlInsertCommand4;
			this.sda4.SelectCommand = this.sqlSelectCommand4;
			this.sda4.UpdateCommand = this.sqlUpdateCommand4;
			this.DataGrid2.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid2_PageIndexChanged);
			this.DataGrid2.SelectedIndexChanged += new System.EventHandler(this.DataGrid2_SelectedIndexChanged_1);
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.zhu1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.allpepole1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.zhuyuan1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sda31)).EndInit();

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{    
			try
			{
			if(cnn.State==0) cnn.Open();
			cmd.Parameters["@����"].Value=tch.Text;
			cmd.Parameters["@�Һź���"].Value=tnum.Text;
			cmd.Parameters["@����"].Value =tname.Text ;
			cmd.Parameters ["@����"].Value=tage.Text ;
			cmd.Parameters ["@�Ա�"].Value=r1.SelectedValue ;
			cmd.Parameters ["@����"].Value=d1.SelectedValue ;
			cmd.Parameters ["@������"].Value=d2.SelectedValue ;
			cmd.Parameters ["@����ʵ��"].Value=d3.SelectedValue ;
			cmd.ExecuteNonQuery();
             Response.Write("<script language=javascript>alert('��Ժ�ɹ���');</script>") ;
			}
			catch
			{
				Response.Write("<script language=javascript>alert('���Ż�Һź�����ڣ�');</script>") ;
			}
			cnn.Close();
			fills();
			fill();


		}
		private void fill()
		{
		if(cnn.State==0) cnn.Open();
          sda.SelectCommand.ExecuteNonQuery();
			sda31.Clear();
			sda3.Fill(sda31);
			cnn.Close();
			this.DataGrid2.DataBind();
		}
		private void fills()
		{
		
			if(cnn.State==0) cnn.Open();
			sda.SelectCommand.ExecuteNonQuery();
			zhu1.Clear(); 
			sda.Fill(zhu1); 
			cnn.Close();
			DataGrid1.DataBind(); 
			
		}

		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			DataGrid1.CurrentPageIndex = e.NewPageIndex;
			fills();
		}

		private void Button4_Click(object sender, System.EventArgs e)
		{
			p1.Visible =true;
		   this.Image2 .Visible =false;
			this.DataGrid2.Visible=true;
			//			this.Button4.Visible=false;
			//            this.Button3.Visible=false;
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
//			p1.Visible =false;
//			Response.Redirect("bedzhao.aspx");
			if(cnn.State==0) cnn.Open();
			sda4.SelectCommand.Parameters["@num"].Value=TextBox1.Text;
			sda4.SelectCommand.ExecuteNonQuery ();
			sda31.Clear();
			sda4.Fill(sda31);
			cnn.Close();
			this.DataGrid2.DataBind();
		}
		

		private void DataGrid2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//			this.DataGrid2.CurrentPageIndex=e.NewPageIndex;
			//			fill();
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			if(cnn.State==0) cnn.Open();
			sda.UpdateCommand.Parameters["@����"].Value=tch.Text;
			sda.UpdateCommand.Parameters["@�Һź���"].Value=tnum.Text;
			sda.UpdateCommand.Parameters["@����"].Value =tname.Text ;
			sda.UpdateCommand.Parameters ["@����"].Value=tage.Text ;
			sda.UpdateCommand.Parameters ["@�Ա�"].Value=r1.SelectedValue ;
			sda.UpdateCommand.Parameters ["@����"].Value=d1.SelectedValue ;
			sda.UpdateCommand.Parameters ["@������"].Value=d2.SelectedValue ;
			sda.UpdateCommand.Parameters ["@����ʵ��"].Value=d3.SelectedValue ;
			sda.UpdateCommand.ExecuteNonQuery();
			cnn.Close();
			Response.Write("<script language=javascript>alert('���Ѿ��������ɹ���Ժ��');</script>") ;
			fills();
			fill();
		}

		private void DataGrid1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			p1.Visible =false;
			this.Image2.Visible =true;
//				if(cnn.State==0) cnn.Open();
//			cmd1.Parameters["@id"].Value=Convert.ToString(DataGrid1.SelectedItem.Cells[1].Text);
//			SqlDataReader rd=cmd1.ExecuteReader();
//			while (rd.Read())
//			{
//				tch.Text =rd.GetValue(1).ToString();
//				
//			}
			

		}

		private void DataGrid2_SelectedIndexChanged_1(object sender, System.EventArgs e)
		{
			if(cnn.State==0) cnn.Open();
			cmd2.Parameters["@id"].Value=Convert.ToString(DataGrid2.SelectedItem.Cells[0].Text);
			SqlDataReader rd=cmd2.ExecuteReader();
			while (rd.Read())
			{
				tch.Text =rd.GetValue(1).ToString();
				tnum.Text =rd.GetValue(0).ToString();
				tname.Text =rd.GetValue(2).ToString();
//				tage.Text =rd.GetValue(4).ToString();
			}
			
		}

		private void DataGrid2_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			DataGrid2.CurrentPageIndex = e.NewPageIndex;
			fill();
		}

		private void Button5_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("index.aspx");
		}

		

	}
	
		
	
}
