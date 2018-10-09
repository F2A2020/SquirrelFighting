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
	/// OutModify 的摘要说明。
	/// </summary>
	public class OutModify : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.DateTimePicker date1;
		public System.Windows.Forms.TextBox textStore;
		public System.Windows.Forms.TextBox textSaver;
		public System.Windows.Forms.TextBox textDealer;
		public System.Windows.Forms.TextBox textValue;
		public System.Windows.Forms.TextBox textPrice;
		public System.Windows.Forms.TextBox textAccount;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox3;
		public System.Windows.Forms.TextBox textRemark;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.TextBox textMID;
		public System.Windows.Forms.TextBox textUnit;
		public System.Windows.Forms.TextBox textType;
		public System.Windows.Forms.TextBox textModel;
		public System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private OleDbConnection oleConnection1 = null;
		private OleDbCommand oleCommand1 = null;

		public OutModify()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			this.oleConnection1 = new OleDbConnection(StoreMIS.database.dbConnection.connection);
			this.oleCommand1 = new OleDbCommand();
			this.oleCommand1.Connection = this.oleConnection1;

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
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

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btAdd = new System.Windows.Forms.Button();
			this.btClose = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.date1 = new System.Windows.Forms.DateTimePicker();
			this.textStore = new System.Windows.Forms.TextBox();
			this.textSaver = new System.Windows.Forms.TextBox();
			this.textDealer = new System.Windows.Forms.TextBox();
			this.textValue = new System.Windows.Forms.TextBox();
			this.textPrice = new System.Windows.Forms.TextBox();
			this.textAccount = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textRemark = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textMID = new System.Windows.Forms.TextBox();
			this.textUnit = new System.Windows.Forms.TextBox();
			this.textType = new System.Windows.Forms.TextBox();
			this.textModel = new System.Windows.Forms.TextBox();
			this.textName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btAdd
			// 
			this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btAdd.Location = new System.Drawing.Point(80, 296);
			this.btAdd.Name = "btAdd";
			this.btAdd.TabIndex = 26;
			this.btAdd.Text = "确定";
			this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
			// 
			// btClose
			// 
			this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClose.Location = new System.Drawing.Point(232, 296);
			this.btClose.Name = "btClose";
			this.btClose.TabIndex = 27;
			this.btClose.Text = "取消";
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.date1);
			this.groupBox2.Controls.Add(this.textStore);
			this.groupBox2.Controls.Add(this.textSaver);
			this.groupBox2.Controls.Add(this.textDealer);
			this.groupBox2.Controls.Add(this.textValue);
			this.groupBox2.Controls.Add(this.textPrice);
			this.groupBox2.Controls.Add(this.textAccount);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(208, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(192, 200);
			this.groupBox2.TabIndex = 24;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "出库信息";
			// 
			// date1
			// 
			this.date1.Location = new System.Drawing.Point(80, 96);
			this.date1.Name = "date1";
			this.date1.Size = new System.Drawing.Size(104, 21);
			this.date1.TabIndex = 9;
			this.date1.Value = new System.DateTime(2007, 8, 19, 0, 0, 0, 0);
			// 
			// textStore
			// 
			this.textStore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textStore.Location = new System.Drawing.Point(80, 168);
			this.textStore.Name = "textStore";
			this.textStore.Size = new System.Drawing.Size(104, 21);
			this.textStore.TabIndex = 12;
			this.textStore.Text = "";
			// 
			// textSaver
			// 
			this.textSaver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textSaver.Location = new System.Drawing.Point(80, 144);
			this.textSaver.Name = "textSaver";
			this.textSaver.Size = new System.Drawing.Size(104, 21);
			this.textSaver.TabIndex = 11;
			this.textSaver.Text = "";
			// 
			// textDealer
			// 
			this.textDealer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textDealer.Location = new System.Drawing.Point(80, 120);
			this.textDealer.Name = "textDealer";
			this.textDealer.Size = new System.Drawing.Size(104, 21);
			this.textDealer.TabIndex = 10;
			this.textDealer.Text = "";
			// 
			// textValue
			// 
			this.textValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textValue.Location = new System.Drawing.Point(80, 72);
			this.textValue.Name = "textValue";
			this.textValue.Size = new System.Drawing.Size(104, 21);
			this.textValue.TabIndex = 8;
			this.textValue.Text = "";
			// 
			// textPrice
			// 
			this.textPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPrice.Location = new System.Drawing.Point(80, 48);
			this.textPrice.Name = "textPrice";
			this.textPrice.Size = new System.Drawing.Size(104, 21);
			this.textPrice.TabIndex = 7;
			this.textPrice.Text = "";
			// 
			// textAccount
			// 
			this.textAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textAccount.Location = new System.Drawing.Point(80, 24);
			this.textAccount.Name = "textAccount";
			this.textAccount.Size = new System.Drawing.Size(104, 21);
			this.textAccount.TabIndex = 6;
			this.textAccount.Text = "";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(16, 168);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 18);
			this.label12.TabIndex = 6;
			this.label12.Text = "仓   库";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(16, 144);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 18);
			this.label11.TabIndex = 5;
			this.label11.Text = "保 管 人";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 120);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 18);
			this.label10.TabIndex = 4;
			this.label10.Text = "领 取 人";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(16, 96);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 18);
			this.label9.TabIndex = 3;
			this.label9.Text = "出库时间";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 18);
			this.label8.TabIndex = 2;
			this.label8.Text = "金   额";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 18);
			this.label7.TabIndex = 1;
			this.label7.Text = "单   价";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 18);
			this.label6.TabIndex = 0;
			this.label6.Text = "数   量";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textRemark);
			this.groupBox3.Location = new System.Drawing.Point(8, 216);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(392, 72);
			this.groupBox3.TabIndex = 25;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "备注";
			// 
			// textRemark
			// 
			this.textRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRemark.Location = new System.Drawing.Point(16, 16);
			this.textRemark.Multiline = true;
			this.textRemark.Name = "textRemark";
			this.textRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textRemark.Size = new System.Drawing.Size(368, 48);
			this.textRemark.TabIndex = 13;
			this.textRemark.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textMID);
			this.groupBox1.Controls.Add(this.textUnit);
			this.groupBox1.Controls.Add(this.textType);
			this.groupBox1.Controls.Add(this.textModel);
			this.groupBox1.Controls.Add(this.textName);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(192, 200);
			this.groupBox1.TabIndex = 23;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "物资信息";
			// 
			// textMID
			// 
			this.textMID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textMID.Location = new System.Drawing.Point(72, 32);
			this.textMID.Name = "textMID";
			this.textMID.ReadOnly = true;
			this.textMID.Size = new System.Drawing.Size(110, 21);
			this.textMID.TabIndex = 1;
			this.textMID.Text = "";
			// 
			// textUnit
			// 
			this.textUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textUnit.Location = new System.Drawing.Point(72, 160);
			this.textUnit.Name = "textUnit";
			this.textUnit.ReadOnly = true;
			this.textUnit.Size = new System.Drawing.Size(110, 21);
			this.textUnit.TabIndex = 5;
			this.textUnit.Text = "";
			// 
			// textType
			// 
			this.textType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textType.Location = new System.Drawing.Point(72, 128);
			this.textType.Name = "textType";
			this.textType.ReadOnly = true;
			this.textType.Size = new System.Drawing.Size(110, 21);
			this.textType.TabIndex = 4;
			this.textType.Text = "";
			// 
			// textModel
			// 
			this.textModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textModel.Location = new System.Drawing.Point(72, 96);
			this.textModel.Name = "textModel";
			this.textModel.ReadOnly = true;
			this.textModel.Size = new System.Drawing.Size(110, 21);
			this.textModel.TabIndex = 3;
			this.textModel.Text = "";
			// 
			// textName
			// 
			this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textName.Location = new System.Drawing.Point(72, 64);
			this.textName.Name = "textName";
			this.textName.ReadOnly = true;
			this.textName.Size = new System.Drawing.Size(110, 21);
			this.textName.TabIndex = 2;
			this.textName.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "单   位";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "类   别";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "物资型号";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "物资名称";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "物资编号";
			// 
			// OutModify
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(408, 326);
			this.Controls.Add(this.btAdd);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Name = "OutModify";
			this.Text = "修改出库信息";
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btAdd_Click(object sender, System.EventArgs e)
		{
			this.oleConnection1.Open();
			string sql="update outinfo set OutAccount='"+textAccount.Text.Trim()+"',OutPrice='"+textPrice.Text.Trim()+"',"+
				"OutValue='"+textValue.Text.Trim()+"',OutDate='"+date1.Text.Trim()+"',OutDealer='"+textDealer.Text.Trim()+"',"+
				"OutSaver='"+textSaver.Text.Trim()+"',OutStore='"+textStore.Text.Trim()+"',Remark='"+textRemark.Text.Trim()+"'"+
				" where OutID="+this.Tag.ToString().Trim()+"";
			oleCommand1.CommandText=sql;
			oleCommand1.ExecuteNonQuery();
			MessageBox.Show("修改出库信息成功！","提示");
			this.Close();
			this.oleConnection1.Close();
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
