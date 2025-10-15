namespace _3_3_login
{
	partial class frmMenu
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
			label1 = new Label();
			groupBox1 = new GroupBox();
			btnVerUsers = new Button();
			btnRegistrarUser = new Button();
			btnSalir = new Button();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(158, 45);
			label1.Name = "label1";
			label1.Size = new Size(324, 50);
			label1.TabIndex = 6;
			label1.Text = "Menu Principal";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.LightSteelBlue;
			groupBox1.Controls.Add(btnVerUsers);
			groupBox1.Controls.Add(btnRegistrarUser);
			groupBox1.Controls.Add(btnSalir);
			groupBox1.Location = new Point(83, 130);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(450, 235);
			groupBox1.TabIndex = 7;
			groupBox1.TabStop = false;
			// 
			// btnVerUsers
			// 
			btnVerUsers.BackColor = Color.Khaki;
			btnVerUsers.Location = new Point(247, 52);
			btnVerUsers.Name = "btnVerUsers";
			btnVerUsers.Size = new Size(173, 60);
			btnVerUsers.TabIndex = 2;
			btnVerUsers.Text = "Ver Usuarios";
			btnVerUsers.UseVisualStyleBackColor = false;
			btnVerUsers.Click += btnVerUsers_Click;
			// 
			// btnRegistrarUser
			// 
			btnRegistrarUser.BackColor = Color.Khaki;
			btnRegistrarUser.Location = new Point(26, 52);
			btnRegistrarUser.Name = "btnRegistrarUser";
			btnRegistrarUser.Size = new Size(183, 60);
			btnRegistrarUser.TabIndex = 1;
			btnRegistrarUser.Text = "Registrar Usuarios";
			btnRegistrarUser.UseVisualStyleBackColor = false;
			btnRegistrarUser.Click += btnRegistrarUser_Click;
			// 
			// btnSalir
			// 
			btnSalir.BackColor = Color.Khaki;
			btnSalir.Location = new Point(26, 161);
			btnSalir.Name = "btnSalir";
			btnSalir.Size = new Size(394, 41);
			btnSalir.TabIndex = 0;
			btnSalir.Text = "Salir";
			btnSalir.UseVisualStyleBackColor = false;
			btnSalir.Click += btnSalir_Click;
			// 
			// frmMenu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkBlue;
			ClientSize = new Size(637, 450);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Name = "frmMenu";
			Text = "frmMenu";
			FormClosed += frmMenu_FormClosed_1;
			Load += frmMenu_Load;
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private GroupBox groupBox1;
		private Button btnRegistrarUser;
		private Button btnSalir;
		private Button btnVerUsers;
	}
}