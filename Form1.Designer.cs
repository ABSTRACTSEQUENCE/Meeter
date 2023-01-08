
namespace Meeter
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.bt_plan = new System.Windows.Forms.Button();
			this.bt_planned = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lb_planned = new System.Windows.Forms.ListBox();
			this.l_chose_date = new System.Windows.Forms.Label();
			this.tb_comments = new System.Windows.Forms.TextBox();
			this.l_comments = new System.Windows.Forms.Label();
			this.calendar = new System.Windows.Forms.MonthCalendar();
			this.bt_debug = new System.Windows.Forms.Button();
			this.l_name = new System.Windows.Forms.Label();
			this.tb_name = new System.Windows.Forms.TextBox();
			this.bt_del = new System.Windows.Forms.Button();
			this.bt_edit = new System.Windows.Forms.Button();
			this.bt_cancel = new System.Windows.Forms.Button();
			this.bt_export = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bt_plan
			// 
			this.bt_plan.BackColor = System.Drawing.Color.Violet;
			this.bt_plan.Font = new System.Drawing.Font("Lucida Console", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_plan.ForeColor = System.Drawing.SystemColors.Desktop;
			this.bt_plan.Location = new System.Drawing.Point(63, 233);
			this.bt_plan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.bt_plan.Name = "bt_plan";
			this.bt_plan.Size = new System.Drawing.Size(263, 36);
			this.bt_plan.TabIndex = 0;
			this.bt_plan.Text = "Запланировать встречу";
			this.bt_plan.UseVisualStyleBackColor = false;
			this.bt_plan.Click += new System.EventHandler(this.bt_plan_Click);
			// 
			// bt_planned
			// 
			this.bt_planned.BackColor = System.Drawing.Color.Violet;
			this.bt_planned.Font = new System.Drawing.Font("La Guapita", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_planned.ForeColor = System.Drawing.SystemColors.Desktop;
			this.bt_planned.Location = new System.Drawing.Point(1219, 221);
			this.bt_planned.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.bt_planned.Name = "bt_planned";
			this.bt_planned.Size = new System.Drawing.Size(358, 36);
			this.bt_planned.TabIndex = 4;
			this.bt_planned.Text = "Отобразить запланированные встречи";
			this.bt_planned.UseVisualStyleBackColor = false;
			this.bt_planned.Click += new System.EventHandler(this.bt_planned_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Grand Aventure Text", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(816, 112);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(124, 48);
			this.label1.TabIndex = 5;
			this.label1.Text = "meeter";
			// 
			// lb_planned
			// 
			this.lb_planned.FormattingEnabled = true;
			this.lb_planned.ItemHeight = 11;
			this.lb_planned.Location = new System.Drawing.Point(1163, 262);
			this.lb_planned.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.lb_planned.Name = "lb_planned";
			this.lb_planned.Size = new System.Drawing.Size(493, 312);
			this.lb_planned.TabIndex = 6;
			this.lb_planned.Visible = false;
			this.lb_planned.SelectedIndexChanged += new System.EventHandler(this.lb_planned_SelectedIndexChanged);
			// 
			// l_chose_date
			// 
			this.l_chose_date.AutoSize = true;
			this.l_chose_date.BackColor = System.Drawing.Color.Transparent;
			this.l_chose_date.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l_chose_date.ForeColor = System.Drawing.Color.Orange;
			this.l_chose_date.Location = new System.Drawing.Point(105, 299);
			this.l_chose_date.Name = "l_chose_date";
			this.l_chose_date.Size = new System.Drawing.Size(148, 24);
			this.l_chose_date.TabIndex = 7;
			this.l_chose_date.Text = "Выберите дату";
			this.l_chose_date.Visible = false;
			// 
			// tb_comments
			// 
			this.tb_comments.Location = new System.Drawing.Point(419, 367);
			this.tb_comments.Multiline = true;
			this.tb_comments.Name = "tb_comments";
			this.tb_comments.Size = new System.Drawing.Size(263, 166);
			this.tb_comments.TabIndex = 8;
			this.tb_comments.Visible = false;
			// 
			// l_comments
			// 
			this.l_comments.AutoSize = true;
			this.l_comments.BackColor = System.Drawing.Color.Transparent;
			this.l_comments.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l_comments.ForeColor = System.Drawing.Color.Orange;
			this.l_comments.Location = new System.Drawing.Point(428, 330);
			this.l_comments.Name = "l_comments";
			this.l_comments.Size = new System.Drawing.Size(237, 24);
			this.l_comments.TabIndex = 9;
			this.l_comments.Text = "Комментарий к событию";
			this.l_comments.Visible = false;
			// 
			// calendar
			// 
			this.calendar.Location = new System.Drawing.Point(100, 332);
			this.calendar.Name = "calendar";
			this.calendar.TabIndex = 10;
			this.calendar.Visible = false;
			// 
			// bt_debug
			// 
			this.bt_debug.BackColor = System.Drawing.Color.Gold;
			this.bt_debug.Location = new System.Drawing.Point(845, 163);
			this.bt_debug.Name = "bt_debug";
			this.bt_debug.Size = new System.Drawing.Size(75, 23);
			this.bt_debug.TabIndex = 11;
			this.bt_debug.UseVisualStyleBackColor = false;
			this.bt_debug.Click += new System.EventHandler(this.bt_debug_Click);
			// 
			// l_name
			// 
			this.l_name.AutoSize = true;
			this.l_name.BackColor = System.Drawing.Color.Transparent;
			this.l_name.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l_name.ForeColor = System.Drawing.Color.Orange;
			this.l_name.Location = new System.Drawing.Point(455, 259);
			this.l_name.Name = "l_name";
			this.l_name.Size = new System.Drawing.Size(179, 24);
			this.l_name.TabIndex = 12;
			this.l_name.Text = "Название встречи";
			this.l_name.Visible = false;
			// 
			// tb_name
			// 
			this.tb_name.Location = new System.Drawing.Point(459, 286);
			this.tb_name.Name = "tb_name";
			this.tb_name.Size = new System.Drawing.Size(175, 18);
			this.tb_name.TabIndex = 13;
			this.tb_name.Visible = false;
			// 
			// bt_del
			// 
			this.bt_del.BackColor = System.Drawing.Color.Violet;
			this.bt_del.Font = new System.Drawing.Font("Lucida Console", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_del.ForeColor = System.Drawing.SystemColors.Desktop;
			this.bt_del.Location = new System.Drawing.Point(1514, 579);
			this.bt_del.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.bt_del.Name = "bt_del";
			this.bt_del.Size = new System.Drawing.Size(142, 36);
			this.bt_del.TabIndex = 15;
			this.bt_del.Text = "Удалить";
			this.bt_del.UseVisualStyleBackColor = false;
			this.bt_del.Visible = false;
			this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
			// 
			// bt_edit
			// 
			this.bt_edit.BackColor = System.Drawing.Color.Violet;
			this.bt_edit.Font = new System.Drawing.Font("Lucida Console", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_edit.ForeColor = System.Drawing.SystemColors.Desktop;
			this.bt_edit.Location = new System.Drawing.Point(1163, 579);
			this.bt_edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.bt_edit.Name = "bt_edit";
			this.bt_edit.Size = new System.Drawing.Size(142, 36);
			this.bt_edit.TabIndex = 16;
			this.bt_edit.Text = "Изменить";
			this.bt_edit.UseVisualStyleBackColor = false;
			this.bt_edit.Visible = false;
			// 
			// bt_cancel
			// 
			this.bt_cancel.BackColor = System.Drawing.Color.Violet;
			this.bt_cancel.Font = new System.Drawing.Font("Lucida Console", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_cancel.ForeColor = System.Drawing.SystemColors.Desktop;
			this.bt_cancel.Location = new System.Drawing.Point(76, 506);
			this.bt_cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.bt_cancel.Name = "bt_cancel";
			this.bt_cancel.Size = new System.Drawing.Size(240, 27);
			this.bt_cancel.TabIndex = 17;
			this.bt_cancel.Text = "Отменить планирование";
			this.bt_cancel.UseVisualStyleBackColor = false;
			this.bt_cancel.Visible = false;
			this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
			// 
			// bt_export
			// 
			this.bt_export.BackColor = System.Drawing.Color.Violet;
			this.bt_export.Font = new System.Drawing.Font("Lucida Console", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_export.ForeColor = System.Drawing.SystemColors.Desktop;
			this.bt_export.Location = new System.Drawing.Point(1346, 579);
			this.bt_export.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.bt_export.Name = "bt_export";
			this.bt_export.Size = new System.Drawing.Size(142, 36);
			this.bt_export.TabIndex = 18;
			this.bt_export.Text = "Экспортировать";
			this.bt_export.UseVisualStyleBackColor = false;
			this.bt_export.Visible = false;
			this.bt_export.Click += new System.EventHandler(this.bt_export_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 11F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Meeter.Properties.Resources.bg;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1764, 844);
			this.Controls.Add(this.bt_export);
			this.Controls.Add(this.bt_cancel);
			this.Controls.Add(this.bt_edit);
			this.Controls.Add(this.bt_del);
			this.Controls.Add(this.tb_name);
			this.Controls.Add(this.l_name);
			this.Controls.Add(this.bt_debug);
			this.Controls.Add(this.calendar);
			this.Controls.Add(this.l_comments);
			this.Controls.Add(this.tb_comments);
			this.Controls.Add(this.l_chose_date);
			this.Controls.Add(this.lb_planned);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bt_planned);
			this.Controls.Add(this.bt_plan);
			this.Font = new System.Drawing.Font("Lucida Console", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bt_plan;
		private System.Windows.Forms.Button bt_planned;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lb_planned;
		private System.Windows.Forms.Label l_chose_date;
		private System.Windows.Forms.TextBox tb_comments;
		private System.Windows.Forms.Label l_comments;
		private System.Windows.Forms.Button bt_debug;
		public System.Windows.Forms.MonthCalendar calendar;
		private System.Windows.Forms.Label l_name;
		private System.Windows.Forms.TextBox tb_name;
		private System.Windows.Forms.Button bt_del;
		private System.Windows.Forms.Button bt_edit;
		private System.Windows.Forms.Button bt_cancel;
		private System.Windows.Forms.Button bt_export;
	}
}

