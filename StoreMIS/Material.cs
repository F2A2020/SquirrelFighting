using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace StoreMIS
{
	/// <summary>
	/// Material ��ժҪ˵����
	/// </summary>
	public class Material : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGrid dataGrid1;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private OleDbConnection oleConnection1 = null;
		private System.Windows.Forms.Button btModify;
		private System.Windows.Forms.Button btDel;
		private System.Windows.Forms.Button btClose;
		private OleDbCommand oleCommand1 = null;

		public Material()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
			this.oleConnection1 = new OleDbConnection(StoreMIS.database.dbConnection.connection);
			this.oleCommand1 = new OleDbCommand();
			this.oleCommand1.Connection = this.oleConnection1;

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

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.btModify = new System.Windows.Forms.Button();
			this.btDel = new System.Windows.Forms.Button();
			this.btClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("����_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(120, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "�� �� �� �� �� Ϣ �� ��";
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.AlternatingBackColor = System.Drawing.Color.LightGray;
			this.dataGrid1.BackColor = System.Drawing.Color.DarkGray;
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.Navy;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.ForeColor = System.Drawing.Color.Black;
			this.dataGrid1.GridLineColor = System.Drawing.Color.Black;
			this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dataGrid1.HeaderBackColor = System.Drawing.Color.Silver;
			this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
			this.dataGrid1.LinkColor = System.Drawing.Color.Navy;
			this.dataGrid1.Location = new System.Drawing.Point(8, 40);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid1.Size = new System.Drawing.Size(480, 184);
			this.dataGrid1.TabIndex = 1;
			// 
			// btModify
			// 
			this.btModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btModify.Location = new System.Drawing.Point(43, 232);
			this.btModify.Name = "btModify";
			this.btModify.TabIndex = 2;
			this.btModify.Text = "�޸�";
			this.btModify.Click += new System.EventHandler(this.btModify_Click);
			// 
			// btDel
			// 
			this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btDel.Location = new System.Drawing.Point(211, 232);
			this.btDel.Name = "btDel";
			this.btDel.TabIndex = 3;
			this.btDel.Text = "ɾ��";
			this.btDel.Click += new System.EventHandler(this.btDel_Click);
			// 
			// btClose
			// 
			this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClose.Location = new System.Drawing.Point(379, 232);
			this.btClose.Name = "btClose";
			this.btClose.TabIndex = 4;
			this.btClose.Text = "�˳�";
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// Material
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(496, 262);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btDel);
			this.Controls.Add(this.btModify);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.label1);
			this.Name = "Material";
			this.Text = "������Ϣ";
			this.Load += new System.EventHandler(this.Material_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		DataSet ds;
		private void Material_Load(object sender, System.EventArgs e)
		{
			oleConnection1.Open();
			string sql = "select MID as ���ʱ��,MName as ��������,MModel as �����ͺ�,Mtype as ����,MUnit as ��λ from materialinfo";
			OleDbDataAdapter adp = new OleDbDataAdapter(sql,oleConnection1);
			ds = new DataSet();
			ds.Clear();
			adp.Fill(ds,"material");
			dataGrid1.DataSource=ds.Tables[0].DefaultView;
			dataGrid1.CaptionText="����"+ds.Tables[0].Rows.Count+"����¼";
			oleConnection1.Close();
		}

		MaterialModify materailModify;
		private void btModify_Click(object sender, System.EventArgs e)
		{
			if (dataGrid1.DataSource != null || dataGrid1[dataGrid1.CurrentCell] != null)
			{
				materailModify = new MaterialModify();
				materailModify.textID.Text=ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim();
				materailModify.textName.Text=ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][1].ToString().Trim();
				materailModify.textModel.Text=ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][2].ToString().Trim();
				materailModify.textType.Text=ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][3].ToString().Trim();
				materailModify.textUnit.Text=ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][4].ToString().Trim();
				materailModify.ShowDialog();
			}
			else
				MessageBox.Show("û��ָ��������Ϣ��","��ʾ");
		}

		private void btDel_Click(object sender, System.EventArgs e)
		{
			if (dataGrid1.CurrentRowIndex>=0 && dataGrid1.DataSource!=null && dataGrid1[dataGrid1.CurrentCell]!=null)
			{
				string sql ="select * from ininfo where MID='"+ds.Tables["material"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim()+"'";
				OleDbCommand cmd = new OleDbCommand(sql,oleConnection1);
				OleDbDataReader dr;
				dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					MessageBox.Show("ɾ������'"+ds.Tables["material"].Rows[dataGrid1.CurrentCell.RowNumber][1].ToString().Trim()+"'ʧ�ܣ�����ɾ�������������Ϣ��","��ʾ");
					dr.Close();
				}
				else
				{
					dr.Close();
					string sql1="delete * from materialinfo where MID = '"+ds.Tables["material"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim()+"'";
					cmd.CommandText = sql1;
					cmd.ExecuteNonQuery();
					MessageBox.Show("ɾ������'"+ds.Tables["material"].Rows[dataGrid1.CurrentCell.RowNumber][1].ToString().Trim()+"'�ɹ���","��ʾ");
				}
			}
			else
				MessageBox.Show("û��ָ��������Ϣ��","��ʾ");
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
