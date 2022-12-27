
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
			this.calendar = new System.Windows.Forms.DateTimePicker();
			this.bt_planned = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lb_planned = new System.Windows.Forms.ListBox();
			this.l_chose_date = new System.Windows.Forms.Label();
			this.tb_comments = new System.Windows.Forms.TextBox();
			this.l_comments = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bt_plan
			// 
			this.bt_plan.BackColor = System.Drawing.Color.Violet;
			this.bt_plan.Font = new System.Drawing.Font("Lucida Console", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_plan.ForeColor = System.Drawing.SystemColors.Desktop;
			this.bt_plan.Location = new System.Drawing.Point(340, 233);
			this.bt_plan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.bt_plan.Name = "bt_plan";
			this.bt_plan.Size = new System.Drawing.Size(263, 36);
			this.bt_plan.TabIndex = 0;
			this.bt_plan.Text = "Запланировать встречу";
			this.bt_plan.UseVisualStyleBackColor = false;
			this.bt_plan.Click += new System.EventHandler(this.bt_plan_Click);
			// 
			// calendar
			// 
			this.calendar.CalendarForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.calendar.CalendarMonthBackground = System.Drawing.Color.Violet;
			this.calendar.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
			this.calendar.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.calendar.Font = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.calendar.Location = new System.Drawing.Point(340, 275);
			this.calendar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.calendar.MinDate = new System.DateTime(2022, 12, 23, 0, 0, 0, 0);
			this.calendar.Name = "calendar";
			this.calendar.Size = new System.Drawing.Size(265, 22);
			this.calendar.TabIndex = 3;
			this.calendar.Visible = false;
			this.calendar.CloseUp += new System.EventHandler(this.calendar_CloseUp);
			// 
			// bt_planned
			// 
			this.bt_planned.BackColor = System.Drawing.Color.Violet;
			this.bt_planned.Font = new System.Drawing.Font("La Guapita", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_planned.ForeColor = System.Drawing.SystemColors.Desktop;
			this.bt_planned.Location = new System.Drawing.Point(306, 303);
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
			this.label1.Location = new System.Drawing.Point(406, 118);
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
			this.lb_planned.Location = new System.Drawing.Point(245, 341);
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
			this.l_chose_date.Location = new System.Drawing.Point(392, 315);
			this.l_chose_date.Name = "l_chose_date";
			this.l_chose_date.Size = new System.Drawing.Size(148, 24);
			this.l_chose_date.TabIndex = 7;
			this.l_chose_date.Text = "Выберите дату";
			this.l_chose_date.Visible = false;
			// 
			// tb_comments
			// 
			this.tb_comments.Location = new System.Drawing.Point(340, 345);
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
			this.l_comments.Location = new System.Drawing.Point(352, 513);
			this.l_comments.Name = "l_comments";
			this.l_comments.Size = new System.Drawing.Size(237, 24);
			this.l_comments.TabIndex = 9;
			this.l_comments.Text = "Комментарий к событию";
			this.l_comments.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 11F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Meeter.Properties.Resources.bg;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(945, 658);
			this.Controls.Add(this.l_comments);
			this.Controls.Add(this.tb_comments);
			this.Controls.Add(this.l_chose_date);
			this.Controls.Add(this.lb_planned);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bt_planned);
			this.Controls.Add(this.calendar);
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
		private System.Windows.Forms.DateTimePicker calendar;
		private System.Windows.Forms.Button bt_planned;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lb_planned;
		private System.Windows.Forms.Label l_chose_date;
		private System.Windows.Forms.TextBox tb_comments;
		private System.Windows.Forms.Label l_comments;
	}
}

