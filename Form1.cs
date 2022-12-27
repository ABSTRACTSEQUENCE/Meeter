using System;
using System.Windows.Forms;

namespace Meeter
{
	public partial class Form1 : Form
	{
		bool IsPlanning = false;
		class Event
		{
			DateTime date;
			string comment;

			public Event(DateTime date, string comment)
			{
				this.date = date; this.comment = comment;
			}
			public override string ToString()
			{
				return $"{date}: {comment}";
			}

		}

		public Form1()
		{
			InitializeComponent();
			calendar.MinDate = DateTime.Now;
		}

		private void visibility(bool planning)
		{
			if (planning)
			{
				bt_planned.Visible = false;
				calendar.Visible = true;
				l_chose_date.Visible = true;
				IsPlanning = true;
				bt_planned.Text = "Отобразить запланированные события";
				lb_planned.Visible = false;
			}

			else
			{
				bt_planned.Visible = true;
				calendar.Visible = false;
				IsPlanning = false;
				l_chose_date.Visible = false;
				l_comments.Visible = false;
				tb_comments.Visible = false;
			}
		}

		private void bt_plan_Click(object sender, EventArgs e)
		{
			if (!IsPlanning)
			{
				bt_plan.Text = "Запланировать на выбранную дату";
				visibility(true);
				return;
			}
			lb_planned.Items.Add(new Event(calendar.Value, tb_comments.Text).ToString());
			MessageBox.Show($"Событие запланировано на {calendar.Value}");
			bt_plan.Text = "Запланировать встречу";
			visibility(false);

		}

		private void bt_planned_Click(object sender, EventArgs e)
		{
			if (lb_planned.Visible)
			{
				bt_planned.Text = "Отобразить запланированные события";
				lb_planned.Visible = false;
			}

			else
			{
				bt_planned.Text = "Скрыть запланированные события";
				lb_planned.Visible = true;
			}

		}

		private void lb_planned_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void calendar_CloseUp(object sender, EventArgs e)
		{
			tb_comments.Visible = true;
			l_comments.Visible = true;
		}
	}
}
