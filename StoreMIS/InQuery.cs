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
	/// InQuery ��ժҪ˵����
	/// </summary>
	public class InQuery : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button btNew;
		private System.Windows.Forms.Button btQuery;
		private System.Windows.Forms.TextBox textModel;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox textID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker date1;
		private System.Windows.Forms.DateTimePicker date2;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private OleDbConnection oleConnection1 = null;
		private OleDbCommand oleCommand1 = null;

		public InQuery()
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
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.btNew = new System.Windows.Forms.Button();
			this.btQuery = new System.Windows.Forms.Button();
			this.textModel = new System.Windows.Forms.TextBox();
			this.textName = new System.Windows.Forms.TextBox();
			this.textID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.date1 = new System.Windows.Forms.DateTimePicker();
			this.date2 = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.AlternatingBackColor = System.Drawing.Color.LightGray;
			this.dataGrid1.BackColor = System.Drawing.Color.DarkGray;
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.White;
			this.dataGrid1.CaptionFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.Navy;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.ForeColor = System.Drawing.Color.Black;
			this.dataGrid1.GridLineColor = System.Drawing.Color.Black;
			this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dataGrid1.HeaderBackColor = System.Drawing.Color.Silver;
			this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
			this.dataGrid1.LinkColor = System.Drawing.Color.Navy;
			this.dataGrid1.Location = new System.Drawing.Point(8, 128);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid1.Size = new System.Drawing.Size(496, 152);
			this.dataGrid1.TabIndex = 17;
			// 
			// btNew
			// 
			this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btNew.Location = new System.Drawing.Point(376, 96);
			this.btNew.Name = "btNew";
			this.btNew.TabIndex = 16;
			this.btNew.Text = "����";
			this.btNew.Click += new System.EventHandler(this.btNew_Click);
			// 
			// btQuery
			// 
			this.btQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btQuery.Location = new System.Drawing.Point(272, 96);
			this.btQuery.Name = "btQuery";
			this.btQuery.TabIndex = 15;
			this.btQuery.Text = "��ѯ";
			this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
			// 
			// textModel
			// 
			this.textModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textModel.Location = new System.Drawing.Point(96, 96);
			this.textModel.Name = "textModel";
			this.textModel.Size = new System.Drawing.Size(136, 21);
			this.textModel.TabIndex = 14;
			this.textModel.Text = "";
			// 
			// textName
			// 
			this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textName.Location = new System.Drawing.Point(328, 16);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(136, 21);
			this.textName.TabIndex = 13;
			this.textName.Text = "";
			// 
			// textID
			// 
			this.textID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textID.Location = new System.Drawing.Point(104, 16);
			this.textID.Name = "textID";
			this.textID.Size = new System.Drawing.Size(136, 21);
			this.textID.TabIndex = 10;
			this.textID.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(32, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "�����ͺ�";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(264, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "��������";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(40, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "���ʱ��";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.date2);
			this.groupBox1.Controls.Add(this.date1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(16, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(480, 48);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "���ʱ��";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(64, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "��";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(256, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 16);
			this.label5.TabIndex = 1;
			this.label5.Text = "��";
			// 
			// date1
			// 
			this.date1.Location = new System.Drawing.Point(88, 16);
			this.date1.Name = "date1";
			this.date1.Size = new System.Drawing.Size(136, 21);
			this.date1.TabIndex = 2;
			this.date1.Value = new System.DateTime(2007, 8, 19, 0, 0, 0, 0);
			// 
			// date2
			// 
			this.date2.Location = new System.Drawing.Point(280, 16);
			this.date2.Name = "date2";
			this.date2.Size = new System.Drawing.Size(128, 21);
			this.date2.TabIndex = 3;
			this.date2.Value = new System.DateTime(2007, 8, 19, 0, 0, 0, 0);
			// 
			// InQuery
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(512, 286);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.btNew);
			this.Controls.Add(this.btQuery);
			this.Controls.Add(this.textModel);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.textID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "InQuery";
			this.Text = "����ѯ";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btQuery_Click(object sender, System.EventArgs e)
		{
			string sql = "select MName as ��������,MModel as �����ͺ�,Mtype as ����,MUnit as ��λ,InAccount as ����,"+
				"InPrice as ����,InValue as ���,InDate as ���ʱ��,InDealer as ������,InSaver as ������,InStore as �ֿ�,Remark as ��ע,"+
				"ininfo.MID as ���ʱ��,InID as ����� from materialinfo,ininfo where materialinfo.MID = ininfo.MID";
			if (textID.Text.Trim()==""&&textName.Text.Trim()==""&&textModel.Text.Trim()==""&&date1.Text.Trim()==""&&date2.Text.Trim()=="")
			{
				MessageBox.Show("�������ѯ������","����");
				return;
			}
			else if (textID.Text.Trim() != "")
				sql = sql+" and ininfo.MID= "+"'"+textID.Text.Trim()+"'";
			else
			{
				if (textName.Text.Trim() != "")
					sql = sql+" and MName= "+"'"+textName.Text+"'";
				if (textModel.Text.Trim() != "")
					sql = sql+" and MModel= "+"'"+textModel.Text+"'";
				if (date1.Text.Trim() != "" && date2.Text.Trim() != "")
				{
					DateTime dt1 = Convert.ToDateTime(date1.Text);
					DateTime dt2 = Convert.ToDateTime(date2.Text);
					sql = sql+" and InDate between "+"#"+dt1+"#"+" and "+"#"+dt2+"#";
				}
					
			}
			
			oleConnection1.Open();
			OleDbDataAdapter adp = new OleDbDataAdapter(sql,oleConnection1);
			DataSet ds = new DataSet();
			ds.Clear();
			adp.Fill(ds,"in");
			dataGrid1.DataSource=ds.Tables[0].DefaultView;
			dataGrid1.CaptionText="����"+ds.Tables[0].Rows.Count+"����ѯ��¼";
			oleConnection1.Close();
		}

		private void btNew_Click(object sender, System.EventArgs e)
		{
			this.textID.Text = "";
			this.textModel.Text = "";
			this.textName.Text = "";
			this.date1.Text = "";
			this.date2.Text = "";
		}
	}
}
