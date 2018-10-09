using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Runtime.InteropServices;

namespace StoreMIS
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Login : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private OleDbConnection sqlConnection1 =null;
		private OleDbCommand sqlCommand1 = null;
		private System.Windows.Forms.Label label1;
//		public OleDbConnection sqlConnection1 = new OleDbConnection("Data Source=storeMIS.mdb;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;");
	
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		
		

		public Login()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			this.sqlConnection1 = new OleDbConnection(StoreMIS.database.dbConnection.connection);
			this.sqlCommand1 = new OleDbCommand();
			this.sqlCommand1.Connection = this.sqlConnection1;

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
				if (components != null) 
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.Location = new System.Drawing.Point(64, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "用户名";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.Location = new System.Drawing.Point(64, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "密  码";
			// 
			// name
			// 
			this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.name.Location = new System.Drawing.Point(128, 80);
			this.name.Name = "name";
			this.name.TabIndex = 3;
			this.name.Text = "admin";
			// 
			// password
			// 
			this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.password.Location = new System.Drawing.Point(128, 120);
			this.password.Name = "password";
			this.password.PasswordChar = '*';
			this.password.TabIndex = 4;
			this.password.Text = "admin";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(48, 160);
			this.button1.Name = "button1";
			this.button1.TabIndex = 5;
			this.button1.Text = "确定";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Location = new System.Drawing.Point(168, 160);
			this.button2.Name = "button2";
			this.button2.TabIndex = 6;
			this.button2.Text = "取消";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.AliceBlue;
			this.label1.Font = new System.Drawing.Font("楷体_GB2312", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.ForeColor = System.Drawing.Color.ForestGreen;
			this.label1.Location = new System.Drawing.Point(40, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "仓库管理信息系统";
			// 
			// Login
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(292, 214);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.password);
			this.Controls.Add(this.name);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "登录";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Login());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(name.Text.Trim()==""||password.Text.Trim()=="")
				MessageBox.Show("请输入用户名和密码","提示");
			else
			{
				sqlConnection1.Open();
				OleDbCommand cmd=new OleDbCommand("",sqlConnection1);
				string sql="select RoleName from userinfo where UID='"+name.Text.Trim()+"' and PWD='"+password.Text.Trim()+"'";
				cmd.CommandText=sql;
				string rolename;

				if (null!=cmd.ExecuteScalar())
				{
					rolename=cmd.ExecuteScalar().ToString();
					//隐藏登录窗口
					this.Visible=false;  
					//创建并打开主界面
					Main main=new Main();
					main.Tag=this.FindForm();
					sql="select * from roles where RoleName='"+rolename+"'";
					OleDbDataReader dr;
					cmd.CommandText=sql;
					dr=cmd.ExecuteReader();
					dr.Read();
     
					main.menuItem1.Visible=(bool)(dr.GetValue(1));
					
					main.menuItem4.Visible=(bool)(dr.GetValue(2));
									
					main.menuItem5.Visible=(bool)(dr.GetValue(3));
					
					main.menuItem6.Visible=(bool)(dr.GetValue(4));

					main.statusBarPanel5.Text=name.Text.Trim();
			
					main.ShowDialog(); 
				}
				else
					MessageBox.Show("用户名或密码错误","警告");

				sqlConnection1.Close();
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
