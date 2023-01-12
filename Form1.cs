using System;
using System.Windows.Forms;
using System.IO;
namespace Meeter
{
	public partial class Form1 : Form
	{
		bool IsPlanning = false;
		SaveFileDialog sf;
		public Event export { get; private set; }
		public Form1()
		{
			InitializeComponent();
			calendar.MinDate = DateTime.Now;
			sf = new SaveFileDialog();
		}
		
		public class Event
		{
			public SelectionRange range { get; }
			internal string name { get; private set; }
			internal bool IsEnded { get; private set; }
			public string comment { get; private set; }
			public Event(SelectionRange range, string comment, string name)
			{
				this.range = range; this.comment = comment; this.name = name;
				new System.Threading.Thread(() =>
				{
					while (true)
					{
						if (DateTime.Now.ToShortDateString() == range.Start.ToShortDateString())
						{
							MessageBox.Show($"Событие {name} началось!");
							break;
						}
					}
					while (true)
					{
						if(DateTime.Now.ToShortDateString() == range.End.ToShortDateString())
						{
							MessageBox.Show($"Событие{name} закончилось");
							IsEnded = true;
							break;
						}
					}
				}).Start();
			}
			public override string ToString()
			{
				return $"{name}: с {range.Start} по {range.End}";
			}

		}

		private void visibility(bool planning)
		{
			if (planning)
			{
				bt_export.Visible = false;
				bt_cancel.Visible = true;
				bt_del.Visible = false;
				bt_edit.Visible = false;
				bt_planned.Visible = false;
				calendar.Visible = true;
				l_chose_date.Visible = true;
				IsPlanning = true;
				bt_planned.Text = "Отобразить запланированные события";
				lb_planned.Visible = false;
				tb_comments.Visible = true;
				tb_comments.ReadOnly = false;
				l_comments.Visible = true;
				tb_name.Visible = true;
				l_name.Visible = true;
			}

			else
			{
				bt_plan.Text = "Запланировать встречу";
				bt_cancel.Visible = false;
				bt_planned.Visible = true;
				calendar.Visible = false;
				IsPlanning = false;
				l_chose_date.Visible = false;
				l_comments.Visible = false;
				tb_comments.Visible = false;
				tb_name.Visible = false;
				l_name.Visible = false;
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
			Event ev = new Event(calendar.SelectionRange, tb_comments.Text, tb_name.Text);
			if (ev.range == calendar.SelectionRange) //Надо сделать так, чтобы при пересечении дат выходил MS с ошибкой
			{
				MessageBox.Show("На этот день уже назначена встреча");
				return;
			}
			lb_planned.Items.Add(ev);
			MessageBox.Show($"Событие начнётся в {calendar.SelectionStart.ToShortDateString()} и закончится в {calendar.SelectionEnd.ToShortDateString()}");
			//bt_plan.Text = "Запланировать встречу";
			visibility(false);

		}

		private void bt_planned_Click(object sender, EventArgs e)
		{
			for(int i = 0; i < lb_planned.Items.Count; i++)
			{
				Event buffer = (Event)lb_planned.Items[i];
				if (buffer.IsEnded) lb_planned.Items.Remove(i);
			}
			if (lb_planned.Visible)
			{
				bt_planned.Text = "Отобразить запланированные события";
				lb_planned.Visible = false;
				bt_edit.Visible = false;
				bt_del.Visible = false;
				bt_export.Visible = false;
			}

			else
			{
				bt_planned.Text = "Скрыть запланированные события";
				bt_export.Visible = true;
				lb_planned.Visible = true;
				bt_edit.Visible = true;
				bt_del.Visible = true;
			}

		}

		private void lb_planned_SelectedIndexChanged(object sender, EventArgs e)
		{
			Event selected = (Event)lb_planned.SelectedItem;
			if (selected == null) return;
			tb_comments.ReadOnly = true;
			tb_comments.Visible = true;
			l_comments.Visible = true;
			tb_comments.Text =selected.comment;
		}

		private void bt_debug_Click(object sender, EventArgs e)
		{
			new debug(this).ShowDialog();
		}

		private void bt_del_Click(object sender, EventArgs e)
		{
			if (lb_planned.SelectedIndex == -1) return;
			else
			{
				lb_planned.Items.RemoveAt(lb_planned.SelectedIndex);
				if (sf.FileName != "") File.Delete(sf.FileName);
			}
		}

		private void bt_cancel_Click(object sender, EventArgs e)
		{
			
			visibility(false);
		}

		private void bt_export_Click(object sender, EventArgs e)
		{
			if (lb_planned.SelectedIndex == -1) return;
			Export ex = new Export(this);
			export = (Event)lb_planned.Items[lb_planned.SelectedIndex];
			ex.ShowDialog();
			ex.Dispose();
		}
	}
	/*TODO:
	1)Сделать базу данных
	2)Сделать уведомления по времени --PARTIALLY DONE
	2.1)Сделать так, чтобы событие удалялось при завершении
	3)Сделать так, чтобы события не пересекались
	4)Сделать дебаг
	*/
}
