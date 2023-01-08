
namespace Meeter
{
	partial class debug
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
			this.label1 = new System.Windows.Forms.Label();
			this.bt_nextDay = new System.Windows.Forms.Button();
			this.bt_prevDay = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(202, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(387, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Система управления временем";
			// 
			// bt_nextDay
			// 
			this.bt_nextDay.Location = new System.Drawing.Point(467, 166);
			this.bt_nextDay.Name = "bt_nextDay";
			this.bt_nextDay.Size = new System.Drawing.Size(122, 31);
			this.bt_nextDay.TabIndex = 1;
			this.bt_nextDay.Text = "Следующий день>";
			this.bt_nextDay.UseVisualStyleBackColor = true;
			this.bt_nextDay.Click += new System.EventHandler(this.bt_nextDay_Click);
			// 
			// bt_prevDay
			// 
			this.bt_prevDay.Location = new System.Drawing.Point(207, 166);
			this.bt_prevDay.Name = "bt_prevDay";
			this.bt_prevDay.Size = new System.Drawing.Size(122, 31);
			this.bt_prevDay.TabIndex = 2;
			this.bt_prevDay.Text = "<Предыдущий день";
			this.bt_prevDay.UseVisualStyleBackColor = true;
			this.bt_prevDay.Click += new System.EventHandler(this.bt_prevDay_Click);
			// 
			// debug
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.bt_prevDay);
			this.Controls.Add(this.bt_nextDay);
			this.Controls.Add(this.label1);
			this.Name = "debug";
			this.Text = "debug";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bt_nextDay;
		private System.Windows.Forms.Button bt_prevDay;
	}
}