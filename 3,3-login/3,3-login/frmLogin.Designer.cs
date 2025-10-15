namespace _3_3_login
{
	partial class frmLogin
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
			txtUserName = new TextBox();
			txtPassword = new TextBox();
			btnSingIn = new Button();
			groupBox1 = new GroupBox();
			label1 = new Label();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// txtUserName
			// 
			txtUserName.Location = new Point(52, 45);
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(260, 27);
			txtUserName.TabIndex = 0;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(52, 96);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(260, 27);
			txtPassword.TabIndex = 1;
			txtPassword.TextChanged += txtPassword_TextChanged;
			// 
			// btnSingIn
			// 
			btnSingIn.BackColor = Color.Khaki;
			btnSingIn.ForeColor = Color.Black;
			btnSingIn.Location = new Point(52, 159);
			btnSingIn.Name = "btnSingIn";
			btnSingIn.Size = new Size(260, 46);
			btnSingIn.TabIndex = 2;
			btnSingIn.Text = "Sing In";
			btnSingIn.UseVisualStyleBackColor = false;
			btnSingIn.Click += btnSingIn_Click;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.LightSteelBlue;
			groupBox1.Controls.Add(txtUserName);
			groupBox1.Controls.Add(btnSingIn);
			groupBox1.Controls.Add(txtPassword);
			groupBox1.Location = new Point(192, 109);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(384, 256);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(229, 37);
			label1.Name = "label1";
			label1.Size = new Size(322, 50);
			label1.TabIndex = 4;
			label1.Text = "Login";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// frmLogin
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkBlue;
			ClientSize = new Size(786, 484);
			Controls.Add(label1);
			Controls.Add(groupBox1);
			Name = "frmLogin";
			RightToLeftLayout = true;
			Text = "frmLogin";
			FormClosed += frmLogin_FormClosed_1;
			Load += frmLogin_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TextBox txtUserName;
		private TextBox txtPassword;
		private Button btnSingIn;
		private GroupBox groupBox1;
		private Label label1;
	}
}