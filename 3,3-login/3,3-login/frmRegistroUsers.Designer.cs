namespace _3_3_login
{
	partial class frmRegistroUsers
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			groupBox1 = new GroupBox();
			btnCancelar = new Button();
			txtConfirmPassword = new TextBox();
			txtPassword = new TextBox();
			txtUserName = new TextBox();
			btnCrearUser = new Button();
			txtDescription = new TextBox();
			txtEmail = new TextBox();
			txtLastName = new TextBox();
			txtFirstName = new TextBox();
			label1 = new Label();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.LightSteelBlue;
			groupBox1.Controls.Add(btnCancelar);
			groupBox1.Controls.Add(txtConfirmPassword);
			groupBox1.Controls.Add(txtPassword);
			groupBox1.Controls.Add(txtUserName);
			groupBox1.Controls.Add(btnCrearUser);
			groupBox1.Controls.Add(txtDescription);
			groupBox1.Controls.Add(txtEmail);
			groupBox1.Controls.Add(txtLastName);
			groupBox1.Controls.Add(txtFirstName);
			groupBox1.Location = new Point(173, 77);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(451, 545);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			// 
			// btnCancelar
			// 
			btnCancelar.BackColor = Color.Khaki;
			btnCancelar.Location = new Point(117, 501);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(211, 26);
			btnCancelar.TabIndex = 8;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = false;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// txtConfirmPassword
			// 
			txtConfirmPassword.Location = new Point(50, 243);
			txtConfirmPassword.Name = "txtConfirmPassword";
			txtConfirmPassword.PasswordChar = '*';
			txtConfirmPassword.Size = new Size(359, 27);
			txtConfirmPassword.TabIndex = 7;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(50, 200);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.Size = new Size(359, 27);
			txtPassword.TabIndex = 6;
			// 
			// txtUserName
			// 
			txtUserName.Location = new Point(50, 156);
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(359, 27);
			txtUserName.TabIndex = 5;
			// 
			// btnCrearUser
			// 
			btnCrearUser.BackColor = Color.Khaki;
			btnCrearUser.Location = new Point(50, 435);
			btnCrearUser.Name = "btnCrearUser";
			btnCrearUser.Size = new Size(359, 43);
			btnCrearUser.TabIndex = 4;
			btnCrearUser.Text = "Crear Usuario";
			btnCrearUser.UseVisualStyleBackColor = false;
			btnCrearUser.Click += btnCrearUser_Click;
			// 
			// txtDescription
			// 
			txtDescription.Location = new Point(50, 290);
			txtDescription.Multiline = true;
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(359, 128);
			txtDescription.TabIndex = 3;
			txtDescription.TextChanged += txtDescription_TextChanged;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(50, 114);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(359, 27);
			txtEmail.TabIndex = 2;
			// 
			// txtLastName
			// 
			txtLastName.Location = new Point(50, 68);
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new Size(359, 27);
			txtLastName.TabIndex = 1;
			// 
			// txtFirstName
			// 
			txtFirstName.Location = new Point(50, 23);
			txtFirstName.Name = "txtFirstName";
			txtFirstName.Size = new Size(359, 27);
			txtFirstName.TabIndex = 0;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(246, 9);
			label1.Name = "label1";
			label1.Size = new Size(322, 65);
			label1.TabIndex = 5;
			label1.Text = "Crear Usuario";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// frmRegistroUsers
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkBlue;
			ClientSize = new Size(802, 662);
			Controls.Add(label1);
			Controls.Add(groupBox1);
			Name = "frmRegistroUsers";
			Text = "frmRegistroUsers";
			FormClosed += frmRegistroUsers_FormClosed;
			Load += frmRegistroUsers_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private Label label1;
		private TextBox txtDescription;
		private TextBox txtEmail;
		private TextBox txtLastName;
		private TextBox txtFirstName;
		private Button btnCrearUser;
		private TextBox txtUserName;
		private TextBox txtConfirmPassword;
		private TextBox txtPassword;
		private Button btnCancelar;
	}
}