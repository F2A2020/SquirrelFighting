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
	/// Out ��ժҪ˵����
	/// </summary>
	public class Out : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btDel;
		private System.Windows.Forms.Button btModify;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private OleDbConnection oleConnection1 = null;
		private OleDbCommand oleCommand1 = null;

		public Out()
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
			this.btClose = new System.Windows.Forms.Button();
			this.btDel = new System.Windows.Forms.Button();
			this.btModify = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// btClose
			// 
			this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClose.Location = new System.Drawing.Point(416, 264);
			this.btClose.Name = "btClose";
			this.btClose.TabIndex = 14;
			this.btClose.Text = "�˳�";
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// btDel
			// 
			this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btDel.Location = new System.Drawing.Point(256, 264);
			this.btDel.Name = "btDel";
			this.btDel.TabIndex = 13;
			this.btDel.Text = "ɾ��";
			this.btDel.Click += new System.EventHandler(this.btDel_Click);
			// 
			// btModify
			// 
			this.btModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btModify.Location = new System.Drawing.Point(88, 264);
			this.btModify.Name = "btModify";
			this.btModify.TabIndex = 12;
			this.btModify.Text = "�޸�";
			this.btModify.Click += new System.EventHandler(this.btModify_Click);
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
			this.dataGrid1.Size = new System.Drawing.Size(568, 208);
			this.dataGrid1.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("����_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(200, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 24);
			this.label1.TabIndex = 10;
			this.label1.Text = "�� �� �� Ϣ �� ��";
			// 
			// Out
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(584, 294);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btDel);
			this.Controls.Add(this.btModify);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.label1);
			this.Name = "Out";
			this.Text = "������Ϣ";
			this.Load += new System.EventHandler(this.Out_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		DataSet ds;
		private void Out_Load(object sender, System.EventArgs e)
		{
			oleConnection1.Open();
			string sql ="select MName as ��������,MModel as �����ͺ�,Mtype as ����,MUnit as ��λ,OutAccount as ����,"+
				"OutPrice as ����,OutValue as ���,OutDate as ����ʱ��,OutDealer as ��ȡ��,OutSaver as ������,OutStore as �ֿ�,Remark as ��ע,"+
				"Outinfo.MID as ���ʱ��,OutID as ����� from materialinfo,Outinfo where materialinfo.MID = Outinfo.MID";
			OleDbDataAdapter adp = new OleDbDataAdapter(sql,oleConnection1);
			ds=new DataSet();
			ds.Clear();
			adp.Fill(ds,"out");
			dataGrid1.DataSource=ds.Tables[0].DefaultView;
			dataGrid1.CaptionText="����"+ds.Tables[0].Rows.Count+"����¼";
			oleConnection1.Close();
		}

		OutModify outModify;
		private void btModify_Click(object sender, System.EventArgs e)
		{
			if (dataGrid1.DataSource!=null || dataGrid1[dataGrid1.CurrentCell]!=null)
			{
				outModify = new OutModify();
				outModify.textMID.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][12].ToString().Trim();
				outModify.textName.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim();
				outModify.textModel.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][1].ToString().Trim();
				outModify.textType.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][2].ToString().Trim();
				outModify.textUnit.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][3].ToString().Trim();
				outModify.textAccount.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][4].ToString().Trim();
				outModify.textPrice.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][5].ToString().Trim();
				outModify.textValue.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][6].ToString().Trim();
				outModify.date1.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][7].ToString().Trim();
				outModify.textDealer.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][8].ToString().Trim();
				outModify.textSaver.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][9].ToString().Trim();
				outModify.textStore.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][10].ToString().Trim();
				outModify.textRemark.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][11].ToString().Trim();
				outModify.Tag = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][13].ToString().Trim();
				outModify.ShowDialog();
			}
			else
				MessageBox.Show("û��ָ��������Ϣ��","��ʾ");
		}

		private void btDel_Click(object sender, System.EventArgs e)
		{
			if (dataGrid1.CurrentRowIndex>=0 && dataGrid1.DataSource != null && dataGrid1[dataGrid1.CurrentCell] != null)
			{
				string sql="delete * from outinfo where OutID="+ds.Tables["out"].Rows[dataGrid1.CurrentCell.RowNumber][13].ToString().Trim()+"";
				oleConnection1.Open();
				oleCommand1.CommandText = sql;
				oleCommand1.ExecuteNonQuery();
				MessageBox.Show("ɾ������'"+ds.Tables["out"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim()+"'�ɹ�","��ʾ");
				oleConnection1.Close();
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
