using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace StoreMIS
{
	/// <summary>
	/// Main 的摘要说明。
	/// </summary>
	public class Main : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		public System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		public System.Windows.Forms.MenuItem menuItem4;
		public System.Windows.Forms.MenuItem menuItem5;
		public System.Windows.Forms.MenuItem menuItem6;
		public System.Windows.Forms.MenuItem menuItem7;
		public System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.StatusBarPanel statusBarPanel3;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.StatusBarPanel statusBarPanel4;
		public System.Windows.Forms.StatusBarPanel statusBarPanel5;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Main()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Main));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem22 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.menuItem24 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel5 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel4 = new System.Windows.Forms.StatusBarPanel();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel4)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem4,
																					  this.menuItem5,
																					  this.menuItem6,
																					  this.menuItem7,
																					  this.menuItem8,
																					  this.menuItem9});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3});
			this.menuItem1.Text = "系统管理";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "添加用户";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "新建角色";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem10,
																					  this.menuItem11,
																					  this.menuItem13});
			this.menuItem4.Text = "物资信息管理";
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 0;
			this.menuItem10.Text = "添加物资信息";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 1;
			this.menuItem11.Text = "浏览物资信息";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 2;
			this.menuItem13.Text = "查询物资信息";
			this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 2;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem14,
																					  this.menuItem15,
																					  this.menuItem17});
			this.menuItem5.Text = "入库信息管理";
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 0;
			this.menuItem14.Text = "添加入库信息";
			this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 1;
			this.menuItem15.Text = "浏览入库信息";
			this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 2;
			this.menuItem17.Text = "查询入库信息";
			this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 3;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem18,
																					  this.menuItem19,
																					  this.menuItem21});
			this.menuItem6.Text = "出库信息管理";
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 0;
			this.menuItem18.Text = "添加出库信息";
			this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 1;
			this.menuItem19.Text = "浏览出库信息";
			this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 2;
			this.menuItem21.Text = "查询出库信息";
			this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 4;
			this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem22,
																					  this.menuItem12});
			this.menuItem7.Text = "库存信息管理";
			// 
			// menuItem22
			// 
			this.menuItem22.Index = 0;
			this.menuItem22.Text = "浏览库存信息";
			this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 1;
			this.menuItem12.Text = "查询库存信息";
			this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 5;
			this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem23,
																					  this.menuItem24});
			this.menuItem8.Text = "用户操作";
			// 
			// menuItem23
			// 
			this.menuItem23.Index = 0;
			this.menuItem23.Text = "修改密码";
			this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click);
			// 
			// menuItem24
			// 
			this.menuItem24.Index = 1;
			this.menuItem24.Text = "重新登录";
			this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 6;
			this.menuItem9.Text = "帮助";
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 319);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1,
																						  this.statusBarPanel5,
																						  this.statusBarPanel2,
																						  this.statusBarPanel3,
																						  this.statusBarPanel4});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(584, 22);
			this.statusBar1.TabIndex = 1;
			// 
			// statusBarPanel1
			// 
			this.statusBarPanel1.Text = "当前登录用户";
			this.statusBarPanel1.Width = 80;
			// 
			// statusBarPanel5
			// 
			this.statusBarPanel5.Width = 50;
			// 
			// statusBarPanel2
			// 
			this.statusBarPanel2.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			this.statusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanel2.Width = 218;
			// 
			// statusBarPanel4
			// 
			this.statusBarPanel4.Width = 120;
			// 
			// Main
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(584, 341);
			this.Controls.Add(this.statusBar1);
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "主界面";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel4)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Main_Load(object sender, System.EventArgs e)
		{
			this.statusBarPanel2.Text=DateTime.Now.ToString();
			this.statusBarPanel3.Text="作者：ddl";
			this.statusBarPanel4.Text="仓库管理信息系统";
		}

		AddUser adduser;
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			if (adduser==null || adduser.IsDisposed)
			{
				adduser = new AddUser();
				for(int x=0;x<this.MdiChildren.Length;x++)
				{
					Form tempChild = (Form)this.MdiChildren[x];
					tempChild.Close();
				}
				adduser.MdiParent = this;
//				adduser.WindowState = FormWindowState.Maximized;
				adduser.Show();
			}
		}

		AddRoles addRoles;
		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			if (addRoles==null || addRoles.IsDisposed)
			{
				addRoles = new AddRoles();
				for(int x=0;x<this.MdiChildren.Length;x++)
				{
					Form tempChild = (Form)this.MdiChildren[x];
					tempChild.Close();
				}
				addRoles.MdiParent = this;
//				addRoles.WindowState = FormWindowState.Maximized;
				addRoles.Show();
			}
		}

		MaterialAdd materialAdd;
		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			if (materialAdd==null || materialAdd.IsDisposed)
			{
				materialAdd = new MaterialAdd();
				for(int x=0;x<this.MdiChildren.Length;x++)
				{
					Form tempChild = (Form)this.MdiChildren[x];
					tempChild.Close();
				}
				materialAdd.MdiParent = this;
//				materialAdd.WindowState = FormWindowState.Maximized;
				materialAdd.Show();
			}
		}

		ModifyPassword modifyPassword;
		private void menuItem23_Click(object sender, System.EventArgs e)
		{
			if (modifyPassword == null || modifyPassword.IsDisposed)
			{
				modifyPassword = new ModifyPassword();
				for(int x=0;x<this.MdiChildren.Length;x++)
				{
					Form tempChild = (Form)this.MdiChildren[x];
					tempChild.Close();
				}
				modifyPassword.MdiParent = this;
				modifyPassword.Tag = this.statusBarPanel5.Text.Trim();
//				modifyPassword.WindowState = FormWindowState.Maximized;
				modifyPassword.Show();
			}
		}

		private void menuItem24_Click(object sender, System.EventArgs e)
		{
			((System.Windows.Forms.Form)this.Tag).Visible=true;
			this.Close();
		}

		Material material;
		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			if (material == null || material.IsDisposed)
			{
				material = new Material();
				for(int x=0;x<this.MdiChildren.Length;x++)
				{
					Form tempChild = (Form)this.MdiChildren[x];
					tempChild.Close();
				}
				material.MdiParent = this;
//				material.WindowState = FormWindowState.Maximized;
				material.Show();
			}
		}

		MaterialQuery materialQuery;
		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			if (materialQuery==null || materialQuery.IsDisposed)
			{
				materialQuery = new MaterialQuery();
				for(int x=0;x<this.MdiChildren.Length;x++)
				{
					Form tempChild = (Form)this.MdiChildren[x];
					tempChild.Close();
				}
				materialQuery.MdiParent = this;
//				materialQuery.WindowState = FormWindowState.Maximized;
				materialQuery.Show();
			}
		}

		InAdd inAdd;
		private void menuItem14_Click(object sender, System.EventArgs e)
		{
			if (inAdd==null || inAdd.IsDisposed)
			{
				inAdd = new InAdd();
				for(int x=0;x<this.MdiChildren.Length;x++)
				{
					Form tempChild = (Form)this.MdiChildren[x];
					tempChild.Close();
				}
				inAdd.MdiParent = this;
//				inAdd.WindowState = FormWindowState.Maximized;
				inAdd.Show();
			}
		}

		In in1;
		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			if (in1==null || in1.IsDisposed)
			{
				in1 = new In();
				for(int x=0;x<this.MdiChildren.Length;x++)
				{
					Form tempChild = (Form)this.MdiChildren[x];
					tempChild.Close();
				}
				in1.MdiParent = this;
//				in1.WindowState = FormWindowState.Maximized;
				in1.Show();
			}
		}

		InQuery inQuery;
		private void menuItem17_Click(object sender, System.EventArgs e)
		{
			if (inQuery==null || inQuery.IsDisposed)
			{
				inQuery = new InQuery();
				for(int x=0;x<this.MdiChildren.Length;x++)
				{
					Form tempChild = (Form)this.MdiChildren[x];
					tempChild.Close();
				}
				inQuery.MdiParent = this;
//				inQuery.WindowState = FormWindowState.Maximized;
				inQuery.Show();
			}
		}

		OutAdd outAdd;
		private void menuItem18_Click(object sender, System.EventArgs e)
		{
			outAdd = new OutAdd();
			for(int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			outAdd.MdiParent = this;
//			outAdd.WindowState = FormWindowState.Maximized;
			outAdd.Show();
		}

		Out out1;
		private void menuItem19_Click(object sender, System.EventArgs e)
		{
			out1 = new Out();
			for(int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			out1.MdiParent = this;
//			out1.WindowState = FormWindowState.Maximized;
			out1.Show();
		}

		OutQuery outQuery;
		private void menuItem21_Click(object sender, System.EventArgs e)
		{
			outQuery = new OutQuery();
			for(int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			outQuery.MdiParent = this;
//			outQuery.WindowState = FormWindowState.Maximized;
			outQuery.Show();
		}

		Store store;
		private void menuItem22_Click(object sender, System.EventArgs e)
		{
			store = new Store();
			for(int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			store.MdiParent = this;
//			store.WindowState = FormWindowState.Maximized;
			store.Show();
		}

		StoreQuery storeQuery;
		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			storeQuery = new StoreQuery();
			for(int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			storeQuery.MdiParent = this;
//			storeQuery.WindowState = FormWindowState.Maximized;
			storeQuery.Show();
		}
	}
}
