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
	/// bedhos ��ժҪ˵����
	/// </summary>
	public class bedhos : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlConnection cnn;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.TextBox Tjcs;
		protected System.Web.UI.WebControls.TextBox Tcjs;
		protected System.Web.UI.WebControls.TextBox Tcs;
		protected System.Web.UI.WebControls.TextBox Thid;
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Data.SqlClient.SqlCommand cmm;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
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
			this.cmm = new System.Data.SqlClient.SqlCommand();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// cnn
			// 
			this.cnn.ConnectionString = "workstation id=\"802-HUANGHAI\";packet size=4096;integrated security=SSPI;data sour" +
				"ce=\".\";persist security info=False;initial catalog=ҽԺ����ϵͳ";
			// 
			// cmm
			// 
			this.cmm.CommandText = "[bedin]";
			this.cmm.CommandType = System.Data.CommandType.StoredProcedure;
			this.cmm.Connection = this.cnn;
			this.cmm.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.cmm.Parameters.Add(new System.Data.SqlClient.SqlParameter("@hID", System.Data.SqlDbType.NVarChar, 10));
			this.cmm.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Int, 4));
			this.cmm.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�����", System.Data.SqlDbType.Int, 4));
			this.cmm.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�䴲��", System.Data.SqlDbType.Int, 4));
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(cnn.State==0) cnn.Open();
				cmm.Parameters["@hid"].Value =Thid.Text;  
				cmm.Parameters["@����"].Value =Tcs.Text;  
				cmm.Parameters["@�����"].Value =Tcjs.Text;  
				cmm.Parameters["@�䴲��"].Value =Tjcs.Text;
				cmm.ExecuteNonQuery();
				cnn.Close();
			}
			catch
			{
			Response.Write("<script language=javascript>alert('û������д��򶰺�����ͬ�ģ�');</script>") ;
			}
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("bedid.aspx");
		}
	}
}
