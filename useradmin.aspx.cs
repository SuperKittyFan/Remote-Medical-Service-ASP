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
	public partial class mimagai : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlConnection cnn;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlDataAdapter sda;
		protected ҽԺ����ϵͳ.ds1 ds11;
		protected System.Data.SqlClient.SqlCommand cmd;
		 Cpass cpa =new Cpass();
	    
		protected void Page_Load(object sender, System.EventArgs e)
		{
            
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
            this.cnn.ConnectionString = "Data source=101.200.176.230;Initial Catalog=ҽԺ����ϵͳ;User ID=sa;Password=cldera.comSQL";
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
			((System.ComponentModel.ISupportInitialize)(this.ds11)).EndInit();

		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e)
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
            Session["pwds"] = tpwd.Text;
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

		protected void DataGrid1_SelectedIndexChanged(object sender, System.EventArgs e)
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

		protected void Button2_Click(object sender, System.EventArgs e)
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
        protected void Button3_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("webmenu.aspx");
        }

		
	}
}
