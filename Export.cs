using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeter
{
	public partial class Export : Form
	{
		public bool db { get; private set; }
		public bool txt { get; private set; }
		Form1 f1;
		public Export(Form1 F1)
		{
			f1 = F1;
			InitializeComponent();
		}

		private void bt_db_Click(object sender, EventArgs e)
		{
			db = true;
			txt = false;
			string connection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
			SqlConnection conn = new SqlConnection(connection);
			conn.Open();
			SqlDateTime start = new SqlDateTime(f1.export.range.Start);
			SqlDateTime end = new SqlDateTime(f1.export.range.End);//53
			string convert(int val)
			{
				string str ="";
				for(int i =0; i < 9; i++)
				{
					if (i == val)
					{ str = "0" + val.ToString(); break; }
					else str = val.ToString();
				}
				return str;
			}
			SqlCommand s = new SqlCommand();//Нужно привести дату в вид YYYY.MM.DD HH.MM.SS
			s.Connection = conn;
			s.CommandText =
				$"INSERT INTO Date(Start, [End])" +
				$"VALUES" +
				$"('{start.Value.Year}" +
				$"-{convert(start.Value.Day)}" +
				$"-{convert(start.Value.Month)} " +
				$"{convert(start.Value.Hour)}" +
				$":{convert(start.Value.Minute)}" +
				$":{convert(start.Value.Second)}'," +
				$"'{end.Value.Year}-" +
				$"{convert(end.Value.Day)}-" +
				$"{convert(end.Value.Month)} " +
				$"{convert(end.Value.Hour)}:" +
				$"{convert(end.Value.Minute)}:" +
				$"{convert(end.Value.Second)}')";
			MessageBox.Show($"Добавлено {s.ExecuteNonQuery()} строк в базу данных");
			Close();
			//Самое сложное позади, осталось добавить возможность добавлять коментарии и имя к эвенту в базу и пофиксить баги из TODO листа
		}

		private void bt_txt_Click(object sender, EventArgs e)
		{
			txt = true;
			db = false;
		}
	}
}
