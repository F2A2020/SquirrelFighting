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
	/// MaterialModify 的摘要说明。
	/// </summary>
	public class MaterialModify : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.TextBox textUnit;
		public System.Windows.Forms.TextBox textType;
		public System.Windows.Forms.TextBox textModel;
		public System.Windows.Forms.TextBox textName;
		public System.Windows.Forms.TextBox textID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btAdd;
		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private OleDbConnection oleConnection1 = null;
		private OleDbCommand oleCommand1 = null;

		public MaterialModify()
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textUnit = new System.Windows.Forms.TextBox();
			this.textType = new System.Windows.Forms.TextBox();
			this.textModel = new System.Windows.Forms.TextBox();
			this.textName = new System.Windows.Forms.TextBox();
			this.textID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btClose = new System.Windows.Forms.Button();
			this.btAdd = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textUnit);
			this.groupBox1.Controls.Add(this.textType);
			this.groupBox1.Controls.Add(this.textModel);
			this.groupBox1.Controls.Add(this.textName);
			this.groupBox1.Controls.Add(this.textID);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(16, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(216, 192);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "物资信息";
			// 
			// textUnit
			// 
			this.textUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textUnit.Location = new System.Drawing.Point(76, 152);
			this.textUnit.Name = "textUnit";
			this.textUnit.Size = new System.Drawing.Size(128, 21);
			this.textUnit.TabIndex = 19;
			this.textUnit.Text = "";
			// 
			// textType
			// 
			this.textType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textType.Location = new System.Drawing.Point(76, 120);
			this.textType.Name = "textType";
			this.textType.Size = new System.Drawing.Size(128, 21);
			this.textType.TabIndex = 18;
			this.textType.Text = "";
			// 
			// textModel
			// 
			this.textModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textModel.Location = new System.Drawing.Point(76, 88);
			this.textModel.Name = "textModel";
			this.textModel.Size = new System.Drawing.Size(128, 21);
			this.textModel.TabIndex = 17;
			this.textModel.Text = "";
			// 
			// textName
			// 
			this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textName.Location = new System.Drawing.Point(76, 56);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(128, 21);
			this.textName.TabIndex = 16;
			this.textName.Text = "";
			// 
			// textID
			// 
			this.textID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textID.Location = new System.Drawing.Point(76, 24);
			this.textID.Name = "textID";
			this.textID.ReadOnly = true;
			this.textID.Size = new System.Drawing.Size(128, 21);
			this.textID.TabIndex = 15;
			this.textID.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "单   位";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 13;
			this.label4.Text = "类   别";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "规格型号";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "物资名称";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 10;
			this.label1.Text = "物资编号";
			// 
			// btClose
			// 
			this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClose.Location = new System.Drawing.Point(144, 224);
			this.btClose.Name = "btClose";
			this.btClose.Size = new System.Drawing.Size(56, 23);
			this.btClose.TabIndex = 24;
			this.btClose.Text = "取消";
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// btAdd
			// 
			this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btAdd.Location = new System.Drawing.Point(40, 224);
			this.btAdd.Name = "btAdd";
			this.btAdd.Size = new System.Drawing.Size(56, 23);
			this.btAdd.TabIndex = 23;
			this.btAdd.Text = "确定";
			this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
			// 
			// MaterialModify
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(248, 262);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btAdd);
			this.Name = "MaterialModify";
			this.Text = "修改物资信息";
			this.Load += new System.EventHandler(this.MaterialModify_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void MaterialModify_Load(object sender, System.EventArgs e)
		{
			
		}

		private void btAdd_Click(object sender, System.EventArgs e)
		{
			oleConnection1.Open();
			string sql = "update materialinfo set MName='"+textName.Text.Trim()+"',MModel='"+textModel.Text.Trim()+"',"+
				"MType='"+textType.Text.Trim()+"',MUnit='"+textUnit.Text.Trim()+"' where MID='"+textID.Text.Trim()+"'";
			oleCommand1.CommandText = sql;
			oleCommand1.ExecuteNonQuery();
			MessageBox.Show("修改信息成功！","提示");
			this.Close();
			oleConnection1.Close();
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
