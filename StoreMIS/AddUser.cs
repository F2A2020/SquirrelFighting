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
	/// AddUser ��ժҪ˵����
	/// </summary>
	public class AddUser : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox textPWDNew;
		private System.Windows.Forms.TextBox textPassword;
		private System.Windows.Forms.ComboBox comRole;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btAdd;
		private OleDbConnection sqlConnection1 = null;
		private OleDbCommand sqlCommand1 = null;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AddUser()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
			this.sqlConnection1 = new OleDbConnection(StoreMIS.database.dbConnection.connection);
			this.sqlCommand1 = new OleDbCommand();
			this.sqlCommand1.Connection = this.sqlConnection1;

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
			this.label4 = new System.Windows.Forms.Label();
			this.textPWDNew = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textPassword = new System.Windows.Forms.TextBox();
			this.textName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comRole = new System.Windows.Forms.ComboBox();
			this.btClose = new System.Windows.Forms.Button();
			this.btAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(16, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 17);
			this.label4.TabIndex = 25;
			this.label4.Text = "��    ɫ";
			// 
			// textPWDNew
			// 
			this.textPWDNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPWDNew.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textPWDNew.ForeColor = System.Drawing.SystemColors.ControlText;
			this.textPWDNew.Location = new System.Drawing.Point(80, 96);
			this.textPWDNew.Name = "textPWDNew";
			this.textPWDNew.PasswordChar = '*';
			this.textPWDNew.Size = new System.Drawing.Size(120, 21);
			this.textPWDNew.TabIndex = 3;
			this.textPWDNew.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(16, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 17);
			this.label3.TabIndex = 22;
			this.label3.Text = "����ȷ��";
			// 
			// textPassword
			// 
			this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPassword.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textPassword.ForeColor = System.Drawing.SystemColors.ControlText;
			this.textPassword.Location = new System.Drawing.Point(80, 56);
			this.textPassword.Name = "textPassword";
			this.textPassword.PasswordChar = '*';
			this.textPassword.Size = new System.Drawing.Size(120, 21);
			this.textPassword.TabIndex = 2;
			this.textPassword.Text = "";
			// 
			// textName
			// 
			this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textName.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.textName.Location = new System.Drawing.Point(80, 16);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(120, 21);
			this.textName.TabIndex = 1;
			this.textName.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(16, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 17);
			this.label2.TabIndex = 17;
			this.label2.Text = "��    ��";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 17);
			this.label1.TabIndex = 16;
			this.label1.Text = "�û�����";
			// 
			// comRole
			// 
			this.comRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comRole.Location = new System.Drawing.Point(80, 136);
			this.comRole.Name = "comRole";
			this.comRole.Size = new System.Drawing.Size(120, 20);
			this.comRole.TabIndex = 4;
			// 
			// btClose
			// 
			this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClose.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.btClose.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btClose.Location = new System.Drawing.Point(128, 176);
			this.btClose.Name = "btClose";
			this.btClose.TabIndex = 6;
			this.btClose.Text = "�˳�";
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// btAdd
			// 
			this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btAdd.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.btAdd.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btAdd.Location = new System.Drawing.Point(24, 176);
			this.btAdd.Name = "btAdd";
			this.btAdd.TabIndex = 5;
			this.btAdd.Text = "���";
			this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
			// 
			// AddUser
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(232, 214);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textPWDNew);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textPassword);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comRole);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btAdd);
			this.Name = "AddUser";
			this.Text = "����û�";
			this.Load += new System.EventHandler(this.AddUser_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btAdd_Click(object sender, System.EventArgs e)
		{
			if (textName.Text.Trim()==""||textPassword.Text.Trim()==""||textPWDNew.Text.Trim()==""||comRole.Text.Trim()=="")
			{
				MessageBox.Show("������������Ϣ��","����");
			} 
			else
			{
				if (textPassword.Text.Trim()!=textPWDNew.Text.Trim())
				{
					MessageBox.Show("�����������벻һ�£�","����");
				} 
				else
				{
					sqlConnection1.Open();
					OleDbCommand cmd = new OleDbCommand("",sqlConnection1);
					string sql = "select * from userinfo where UID = '"+textName.Text.Trim()+"'";
					cmd.CommandText = sql;

					if (null == cmd.ExecuteScalar())
					{
						string sql1 = "insert into userinfo (UID,PWD,RoleName) "+
							"values ('"+textName.Text.Trim()+"','"+textPWDNew.Text.Trim()+"','"+comRole.Text.Trim()+"')";
						cmd.CommandText = sql1;
						cmd.ExecuteNonQuery();
						MessageBox.Show("����û��ɹ���","��ʾ");
						this.Close();
					} 
					else
						MessageBox.Show("�û���"+textName.Text.Trim()+"�Ѿ����ڣ�","��ʾ");
					sqlConnection1.Close();
				}
				
			}
		}

		private void AddUser_Load(object sender, System.EventArgs e)
		{
			DataSet ds = new DataSet();
			OleDbDataAdapter adp = new OleDbDataAdapter("",sqlConnection1);
			adp.SelectCommand.CommandText = "select RoleName from roles";
			adp.Fill(ds);
			comRole.DataSource=ds.Tables[0].DefaultView;
			comRole.DisplayMember="RoleName";
			comRole.ValueMember="RoleName";
		}
	}
}
