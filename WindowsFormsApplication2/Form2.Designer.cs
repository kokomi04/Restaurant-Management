
namespace WindowsFormsApplication2
{
	partial class Form2
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHienThi = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Pass = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NewPass = new System.Windows.Forms.Label();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NhapLai = new System.Windows.Forms.Label();
            this.tbAgain = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tbUser);
            this.panel3.Location = new System.Drawing.Point(5, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 36);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(116, 9);
            this.tbUser.Name = "tbUser";
            this.tbUser.ReadOnly = true;
            this.tbUser.Size = new System.Drawing.Size(174, 20);
            this.tbUser.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbHienThi);
            this.panel1.Location = new System.Drawing.Point(5, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 36);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hiển thị:";
            // 
            // tbHienThi
            // 
            this.tbHienThi.Location = new System.Drawing.Point(116, 9);
            this.tbHienThi.Name = "tbHienThi";
            this.tbHienThi.Size = new System.Drawing.Size(174, 20);
            this.tbHienThi.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Pass);
            this.panel4.Controls.Add(this.tbPass);
            this.panel4.Location = new System.Drawing.Point(5, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 36);
            this.panel4.TabIndex = 7;
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(12, 16);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(64, 13);
            this.Pass.TabIndex = 0;
            this.Pass.Text = "Mật khẩu:";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(116, 13);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(174, 20);
            this.tbPass.TabIndex = 2;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NewPass);
            this.panel2.Controls.Add(this.tbNewPass);
            this.panel2.Location = new System.Drawing.Point(5, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 36);
            this.panel2.TabIndex = 8;
            // 
            // NewPass
            // 
            this.NewPass.AutoSize = true;
            this.NewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPass.Location = new System.Drawing.Point(12, 16);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(87, 13);
            this.NewPass.TabIndex = 0;
            this.NewPass.Text = "Mật khẩu mới:";
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(116, 13);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(174, 20);
            this.tbNewPass.TabIndex = 2;
            this.tbNewPass.UseSystemPasswordChar = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.NhapLai);
            this.panel5.Controls.Add(this.tbAgain);
            this.panel5.Location = new System.Drawing.Point(5, 196);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(337, 36);
            this.panel5.TabIndex = 9;
            // 
            // NhapLai
            // 
            this.NhapLai.AutoSize = true;
            this.NhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapLai.Location = new System.Drawing.Point(12, 16);
            this.NhapLai.Name = "NhapLai";
            this.NhapLai.Size = new System.Drawing.Size(58, 13);
            this.NhapLai.TabIndex = 0;
            this.NhapLai.Text = "Nhập lại:";
            // 
            // tbAgain
            // 
            this.tbAgain.Location = new System.Drawing.Point(116, 13);
            this.tbAgain.Name = "tbAgain";
            this.tbAgain.Size = new System.Drawing.Size(174, 20);
            this.tbAgain.TabIndex = 2;
            this.tbAgain.UseSystemPasswordChar = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(121, 248);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(79, 23);
            this.Update.TabIndex = 10;
            this.Update.Text = "Cập nhật";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Exit
            // 
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Location = new System.Drawing.Point(216, 248);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(79, 23);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.Update;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(352, 283);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbHienThi;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label Pass;
		private System.Windows.Forms.TextBox tbPass;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label NewPass;
		private System.Windows.Forms.TextBox tbNewPass;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label NhapLai;
		private System.Windows.Forms.TextBox tbAgain;
		private System.Windows.Forms.Button Update;
		private System.Windows.Forms.Button Exit;
	}
}