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
		protected ҽԺ����ϵͳ.ds3 ds31;
		protected System.Data.SqlClient.SqlCommand cmd1;
		protected ҽԺ����ϵͳ.dss dss1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand3;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
		protected System.Data.SqlClient.SqlDataAdapter sda1;
		protected ҽԺ����ϵͳ.sda1 sda11;
		
		Cpass cpa =new Cpass(); 
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
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
			// 
			// cnn
			// 
            this.cnn.ConnectionString = "Data source=101.200.176.230;Initial Catalog=ҽԺ����ϵͳ;User ID=sa;Password=cldera.comSQL";
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
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�쳣", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ϲ���", System.Data.SqlDbType.NVarChar, 100));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ҽʦ", System.Data.SqlDbType.NVarChar, 20));
            this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ְҵ", System.Data.SqlDbType.NVarChar, 50));
            this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@·��", System.Data.SqlDbType.NVarChar, 50));
            this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ʼʱ��", System.Data.SqlDbType.NVarChar, 50));
            this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����ʱ��", System.Data.SqlDbType.NVarChar, 50));
            this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ҽԺ", System.Data.SqlDbType.NVarChar, 50));
            this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ұ��", System.Data.SqlDbType.NVarChar, 50));
            this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�������", System.Data.SqlDbType.NVarChar, 50));


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
        //���ȷ������
		protected void Button2_Click(object sender, System.EventArgs e)
		{
           
			try
			{
                //ȡ����ѡ�ļ��ı���·��  
                string fullFileName = this.File1.PostedFile.FileName;
                //��·���н�ȡ���ļ���  
                string fileName = fullFileName.Substring(fullFileName.LastIndexOf("\\") + 1);
                //�޶��ϴ��ļ��ĸ�ʽ  
                string type = fullFileName.Substring(fullFileName.LastIndexOf(".") + 1);
                string saveFileName = Server.MapPath("/files") + "\\" + fileName;
                if (type == "DAT" || type == "dat")
                {
                    //���ļ������ڷ������и�Ŀ¼�µ�files�ļ�����  
                    File1.PostedFile.SaveAs(saveFileName);
                }
				if(cnn.State==0) cnn.Open();
				cmd.Parameters["@�Һź���"].Value =tnumber.Text ;
                cmd.Parameters["@ְҵ"].Value = tocc.Text;
				cmd.Parameters["@����"].Value =tname.Text ;
				cmd.Parameters["@�Ա�"].Value =tsex.Text ;
				cmd.Parameters["@����"].Value =tage.Text ;
				cmd.Parameters["@�쳣"].Value =r1.SelectedValue ;//�����쳣
				cmd.Parameters["@��ϲ���"].Value =tbk.Text ;
				cmd.Parameters["@ҽʦ"].Value =tdoc.Text;
                cmd.Parameters["@��ʼʱ��"].Value = tstart.Text;
                cmd.Parameters["@����ʱ��"].Value = tend.Text;
                cmd.Parameters["@·��"].Value = saveFileName;
                cmd.Parameters["@ҽԺ"].Value = thosp.Text;
                cmd.Parameters["@���ұ��"].Value = telec.Text;
                cmd.Parameters["@�������"].Value = trec.Text;
				cmd.ExecuteNonQuery();
				cnn.Close();
				Response.Write("<script language=javascript>alert('��ӳɹ���');</script>") ;
			
			}
			catch{
			Response.Write("<script language=javascript>alert('���ʧ�ܣ�');</script>") ;
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
