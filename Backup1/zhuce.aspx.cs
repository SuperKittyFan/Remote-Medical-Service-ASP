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
	/// zhuce ��ժҪ˵����
	/// </summary>
	public class zhuce : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlConnection cnn;
		protected System.Data.SqlClient.SqlCommand cmd;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.CompareValidator CompareValidator1;
		protected System.Web.UI.WebControls.ValidationSummary ValidationSummary1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator2;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator3;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator4;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator5;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator6;
		protected System.Web.UI.WebControls.RequiredFieldValidator Requiredfieldvalidator7;
		protected System.Web.UI.WebControls.TextBox tname;
		protected System.Web.UI.WebControls.TextBox tname1;
		protected System.Web.UI.WebControls.TextBox tpwd;
		protected System.Web.UI.WebControls.TextBox pass;
		protected System.Web.UI.WebControls.DropDownList d1;
		protected System.Web.UI.WebControls.DropDownList d2;
		protected System.Web.UI.WebControls.TextBox tadd;
		protected System.Web.UI.WebControls.TextBox tphone;
		protected System.Web.UI.WebControls.HyperLink HyperLink1;
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Web.UI.WebControls.HyperLink HyperLink2;
		protected System.Web.UI.WebControls.Button Button2;
	
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
			this.cmd = new System.Data.SqlClient.SqlCommand();
			this.tpwd.TextChanged += new System.EventHandler(this.Tpwd_TextChanged);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// cnn
			// 
			this.cnn.ConnectionString = "workstation id=\"802-HUANGHAI\";packet size=4096;integrated security=SSPI;data sour" +
				"ce=\".\";persist security info=False;initial catalog=ҽԺ����ϵͳ";
			// 
			// cmd
			// 
			this.cmd.CommandText = "[zhuce]";
			this.cmd.CommandType = System.Data.CommandType.StoredProcedure;
			this.cmd.Connection = this.cnn;
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@useid", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@usename", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@pwd", System.Data.SqlDbType.NVarChar, 20));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sex", System.Data.SqlDbType.NVarChar, 2));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@addr", System.Data.SqlDbType.NVarChar, 50));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@rights", System.Data.SqlDbType.NVarChar, 40));
			this.cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.NVarChar, 20));
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
	
			if(cnn.State==0) cnn.Open();
			cmd.Parameters["@useid"].Value=tname.Text;
			cmd.Parameters["@usename"].Value=tname1.Text;
			cmd.Parameters["@pwd"].Value =tpwd.Text;
			cmd.Parameters["@rights"].Value =d1.SelectedValue;
			cmd.Parameters["@sex"].Value =d2.SelectedValue;
			cmd.Parameters["@addr"].Value =tadd.Text;
			cmd.Parameters["@phone"].Value =tphone.Text;
				try
			{
				cmd.ExecuteNonQuery ();
					Response.Write("<script language=javascript>alert('��ӳɹ���');</script>");
			}
			catch
			{
				Response.Write("<script language=javascript>alert('���û����Ѿ����ڣ���ѡ�������ģ�');</script>");
			}
               cnn.Close();
           
			}

		private void Tpwd_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			this.Response .Redirect("mimagai.aspx");
		}
	}
}
