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
	/// show ��ժҪ˵����
	/// </summary>
	public class show : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlConnection cnn;
		protected System.Data.SqlClient.SqlCommand cmd;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(cnn.State==0) cnn.Open(); 
			this.Response.ContentType="image/*";
			cmd.Parameters["@ids"].Value =Convert.ToInt32(Request.QueryString["ImageID"]);
			SqlDataReader  dr=cmd.ExecuteReader();
			while(dr.Read())
			{
				this.Response.BinaryWrite((byte[])dr["myimdata"]);
			}
			dr.Close();
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
			this.cmd = new System.Data.SqlClient.SqlCommand();
			// 
			// cnn
			// 
			this.cnn.ConnectionString = "workstation id=\"802-HUANGHAI\";packet size=4096;integrated security=SSPI;data sour" +
				"ce=\".\";persist security info=False;initial catalog=ҽԺ����ϵͳ";
			// 
			// cmd
			// 
			this.cmd.CommandText = "[myimsel1]";
			this.cmd.CommandType = System.Data.CommandType.StoredProcedure;
			this.cmd.Connection = this.cnn;
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ids", System.Data.SqlDbType.Int, 4));
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
