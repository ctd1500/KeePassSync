﻿namespace KeePassSync.Providers.S3
{
	partial class AccountDetails
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtAccessKey = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBucketName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSecretAccessKey = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbxDailyBackups = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.regionBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Access Key:";
			// 
			// txtAccessKey
			// 
			this.txtAccessKey.Location = new System.Drawing.Point(72, 10);
			this.txtAccessKey.Name = "txtAccessKey";
			this.txtAccessKey.Size = new System.Drawing.Size(281, 20);
			this.txtAccessKey.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Bucket Name:";
			// 
			// txtBucketName
			// 
			this.txtBucketName.Location = new System.Drawing.Point(81, 62);
			this.txtBucketName.Name = "txtBucketName";
			this.txtBucketName.Size = new System.Drawing.Size(272, 20);
			this.txtBucketName.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Secret Access Key:";
			// 
			// txtSecretAccessKey
			// 
			this.txtSecretAccessKey.Location = new System.Drawing.Point(106, 36);
			this.txtSecretAccessKey.Name = "txtSecretAccessKey";
			this.txtSecretAccessKey.PasswordChar = '*';
			this.txtSecretAccessKey.Size = new System.Drawing.Size(247, 20);
			this.txtSecretAccessKey.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(21, 164);
			this.label6.MaximumSize = new System.Drawing.Size(350, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(281, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "If the bucket does not exist it will be greated automatically.";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(3, 151);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Notes:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(288, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Create Daily Backups (stores last 30 days, 1 backup a day):";
			// 
			// cbxDailyBackups
			// 
			this.cbxDailyBackups.AutoSize = true;
			this.cbxDailyBackups.Location = new System.Drawing.Point(291, 126);
			this.cbxDailyBackups.Name = "cbxDailyBackups";
			this.cbxDailyBackups.Size = new System.Drawing.Size(15, 14);
			this.cbxDailyBackups.TabIndex = 12;
			this.cbxDailyBackups.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "S3 Region:";
			// 
			// regionBox
			// 
			this.regionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.regionBox.FormattingEnabled = true;
			this.regionBox.Location = new System.Drawing.Point(81, 93);
			this.regionBox.Name = "regionBox";
			this.regionBox.Size = new System.Drawing.Size(272, 21);
			this.regionBox.TabIndex = 14;
			this.regionBox.SelectedIndexChanged += new System.EventHandler(this.regionBox_SelectedIndexChanged);
			// 
			// AccountDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.regionBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbxDailyBackups);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtSecretAccessKey);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtBucketName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAccessKey);
			this.Controls.Add(this.label1);
			this.Name = "AccountDetails";
			this.Size = new System.Drawing.Size(372, 187);
			this.Load += new System.EventHandler(this.AccountDetails_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAccessKey;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBucketName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSecretAccessKey;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox cbxDailyBackups;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox regionBox;
	}
}
