using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

namespace ҽԺ����ϵͳ
{
	/// <summary>
	/// Cpass ��ժҪ˵����
	/// </summary>
	public class Cpass : System.ComponentModel.Component
	{
		private System.Data.SqlClient.SqlConnection cnn;
		private System.Data.SqlClient.SqlCommand cmm;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Cpass(System.ComponentModel.IContainer container)
		{
			///
			/// Windows.Forms ��׫д�����֧���������
			///
			container.Add(this);
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}
		public string CH(string usename,string pwd,string rights)
		{
				if(cnn.State==0) cnn.Open();
				cmm.Parameters["@useid"].Value = usename;
				cmm.Parameters["@pwd"].Value = pwd ;
				cmm.Parameters["@rights"].Value = rights ;
				cmm.ExecuteNonQuery();
			    string pasd=cmm.Parameters["@pass"].Value.ToString();
			    cnn.Close();		
				return(pasd); 
		}

		public Cpass()
		{
			///
			/// Windows.Forms ��׫д�����֧���������
			///
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary> 
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}


		#region �����������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.cnn = new System.Data.SqlClient.SqlConnection();
			this.cmm = new System.Data.SqlClient.SqlCommand();
			// 
			// cnn
			// 
			this.cnn.ConnectionString = "workstation id=\"802-HUANGHAI\";packet size=4096;integrated security=SSPI;data sour" +
				"ce=\".\";persist security info=False;initial catalog=ҽԺ����ϵͳ";
			// 
			// cmm
			// 
			this.cmm.CommandText = "[checkpwd]";
			this.cmm.CommandType = System.Data.CommandType.StoredProcedure;
			this.cmm.Connection = this.cnn;
			this.cmm.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.cmm.Parameters.Add(new System.Data.SqlClient.SqlParameter("@useid", System.Data.SqlDbType.NVarChar, 40));
			this.cmm.Parameters.Add(new System.Data.SqlClient.SqlParameter("@pwd", System.Data.SqlDbType.NVarChar, 50));
			this.cmm.Parameters.Add(new System.Data.SqlClient.SqlParameter("@rights", System.Data.SqlDbType.NVarChar, 40));
			this.cmm.Parameters.Add(new System.Data.SqlClient.SqlParameter("@pass", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Output, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));

		}
		#endregion
	}
}
