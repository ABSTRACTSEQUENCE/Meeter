
namespace Meeter
{
	partial class Export
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
			this.bt_db = new System.Windows.Forms.Button();
			this.bt_txt = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bt_db
			// 
			this.bt_db.Location = new System.Drawing.Point(78, 89);
			this.bt_db.Name = "bt_db";
			this.bt_db.Size = new System.Drawing.Size(129, 36);
			this.bt_db.TabIndex = 0;
			this.bt_db.Text = "В базу данных";
			this.bt_db.UseVisualStyleBackColor = true;
			this.bt_db.Click += new System.EventHandler(this.bt_db_Click);
			// 
			// bt_txt
			// 
			this.bt_txt.Location = new System.Drawing.Point(250, 89);
			this.bt_txt.Name = "bt_txt";
			this.bt_txt.Size = new System.Drawing.Size(133, 36);
			this.bt_txt.TabIndex = 1;
			this.bt_txt.Text = "В текстовый файл";
			this.bt_txt.UseVisualStyleBackColor = true;
			this.bt_txt.Click += new System.EventHandler(this.bt_txt_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(185, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 38);
			this.label1.TabIndex = 2;
			this.label1.Text = "Куда?";
			// 
			// Export
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 153);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bt_txt);
			this.Controls.Add(this.bt_db);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Export";
			this.Text = "Export";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bt_db;
		private System.Windows.Forms.Button bt_txt;
		private System.Windows.Forms.Label label1;
	}
}