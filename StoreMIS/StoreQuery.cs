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
	/// StoreQuery 的摘要说明。
	/// </summary>
	public class StoreQuery : System.Windows.Forms.Form
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
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private OleDbConnection oleConnection1 = null;
		private OleDbCommand oleCommand1 = null;

		public StoreQuery()
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
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.btNew = new System.Windows.Forms.Button();
			this.btQuery = new System.Windows.Forms.Button();
			this.textModel = new System.Windows.Forms.TextBox();
			this.textName = new System.Windows.Forms.TextBox();
			this.textID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
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
			this.dataGrid1.Location = new System.Drawing.Point(8, 83);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid1.Size = new System.Drawing.Size(448, 157);
			this.dataGrid1.TabIndex = 17;
			// 
			// btNew
			// 
			this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btNew.Location = new System.Drawing.Point(360, 51);
			this.btNew.Name = "btNew";
			this.btNew.TabIndex = 16;
			this.btNew.Text = "重置";
			this.btNew.Click += new System.EventHandler(this.btNew_Click);
			// 
			// btQuery
			// 
			this.btQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btQuery.Location = new System.Drawing.Point(256, 51);
			this.btQuery.Name = "btQuery";
			this.btQuery.TabIndex = 15;
			this.btQuery.Text = "查询";
			this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
			// 
			// textModel
			// 
			this.textModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textModel.Location = new System.Drawing.Point(80, 51);
			this.textModel.Name = "textModel";
			this.textModel.Size = new System.Drawing.Size(136, 21);
			this.textModel.TabIndex = 14;
			this.textModel.Text = "";
			// 
			// textName
			// 
			this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textName.Location = new System.Drawing.Point(304, 19);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(136, 21);
			this.textName.TabIndex = 13;
			this.textName.Text = "";
			// 
			// textID
			// 
			this.textID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textID.Location = new System.Drawing.Point(80, 19);
			this.textID.Name = "textID";
			this.textID.Size = new System.Drawing.Size(136, 21);
			this.textID.TabIndex = 10;
			this.textID.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "物资型号";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(240, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "物资名称";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "物资编号";
			// 
			// StoreQuery
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(464, 254);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.btNew);
			this.Controls.Add(this.btQuery);
			this.Controls.Add(this.textModel);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.textID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "StoreQuery";
			this.Text = "库存查询";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btQuery_Click(object sender, System.EventArgs e)
		{
			string sql = "select materialinfo.MID as 物资编号,MName as 物资名称,MModel as 物资型号,Mtype as 类型,MUnit as 单位,"+
				"InAccount-OutAccount as 剩余数量,InPrice as 单价,InValue-OutValue as 金额,InStore as 仓库,ininfo.Remark as 备注"+
				" from materialinfo,ininfo,outinfo where materialinfo.MID = ininfo.MID and materialinfo.MID = outinfo.MID";
			if (textID.Text.Trim()==""&&textName.Text.Trim()==""&&textModel.Text.Trim()=="")
			{
				MessageBox.Show("请输入查询条件！","警告");
				return;
			}
			else if (textID.Text.Trim() != "")
				sql = sql+" and materialinfo.MID= "+"'"+textID.Text.Trim()+"'";
			else
			{
				if (textName.Text.Trim() != "")
					sql = sql+" and MName= "+"'"+textName.Text+"'";
				if (textModel.Text.Trim() != "")
					sql = sql+" and MModel= "+"'"+textModel.Text+"'";
			}
			
			oleConnection1.Open();
			OleDbDataAdapter adp = new OleDbDataAdapter(sql,oleConnection1);
			DataSet ds = new DataSet();
			ds.Clear();
			adp.Fill(ds,"store");
			dataGrid1.DataSource=ds.Tables[0].DefaultView;
			dataGrid1.CaptionText="共有"+ds.Tables[0].Rows.Count+"条查询记录";
			oleConnection1.Close();
		}

		private void btNew_Click(object sender, System.EventArgs e)
		{
			this.textID.Text="";
			this.textModel.Text="";
			this.textName.Text="";
		}
	}
}
