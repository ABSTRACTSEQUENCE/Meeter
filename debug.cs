using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeter
{
	public partial class debug : Form
	{
		Form1 main;
		public debug(Form1 main)
		{
			InitializeComponent();
			this.main = main;
		}

		private void bt_nextDay_Click(object sender, EventArgs e)
		{
			main.calendar.TodayDate = main.calendar.TodayDate.AddDays(1);
		}

		private void bt_prevDay_Click(object sender, EventArgs e)
		{

		}
	}
}
