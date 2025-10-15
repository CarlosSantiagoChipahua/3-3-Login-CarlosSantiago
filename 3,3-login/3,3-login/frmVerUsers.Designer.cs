namespace _3_3_login
{
	partial class frmVerUsers
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
			btnVolver = new Button();
			label2 = new Label();
			dgvUsers = new DataGridView();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(243, -3);
			label1.Name = "label1";
			label1.Size = new Size(832, 79);
			label1.TabIndex = 7;
			label1.Text = "Lista de usuarios";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.LightSteelBlue;
			groupBox1.Controls.Add(btnVolver);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(dgvUsers);
			groupBox1.Location = new Point(29, 79);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1247, 470);
			groupBox1.TabIndex = 8;
			groupBox1.TabStop = false;
			// 
			// btnVolver
			// 
			btnVolver.BackColor = Color.Khaki;
			btnVolver.Location = new Point(473, 411);
			btnVolver.Name = "btnVolver";
			btnVolver.Size = new Size(324, 38);
			btnVolver.TabIndex = 10;
			btnVolver.Text = "Volver";
			btnVolver.UseVisualStyleBackColor = false;
			btnVolver.Click += btnVolver_Click;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = SystemColors.ActiveCaptionText;
			label2.Location = new Point(214, 23);
			label2.Name = "label2";
			label2.Size = new Size(823, 61);
			label2.TabIndex = 9;
			label2.Text = "Usuarios";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// dgvUsers
			// 
			dgvUsers.BackgroundColor = SystemColors.ControlLight;
			dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvUsers.Location = new Point(13, 100);
			dgvUsers.Name = "dgvUsers";
			dgvUsers.RowHeadersWidth = 51;
			dgvUsers.Size = new Size(1216, 292);
			dgvUsers.TabIndex = 0;
			// 
			// frmVerUsers
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkBlue;
			ClientSize = new Size(1308, 574);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Name = "frmVerUsers";
			Text = "frmVerUsers";
			FormClosed += frmVerUsers_FormClosed;
			Load += frmVerUsers_Load;
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private GroupBox groupBox1;
		private DataGridView dgvUsers;
		private Label label2;
		private Button btnVolver;
	}
}