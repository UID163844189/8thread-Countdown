﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		int mindingtime;
		string alltime;
		public Form1()
		{
			InitializeComponent();
			mindingtime = Int32.Parse(mindtime.Text);
			alltime = fulltime.Text;
		}
		#region 
		private void re_Click(object sender, EventArgs e)
		{
			time.Text = alltime;
			time.BackColor = Color.Transparent;
			progressBar1.Maximum = int.Parse(alltime);
			progressBar2.Maximum = int.Parse(alltime);
			progressBar3.Maximum = int.Parse(alltime);
			progressBar4.Maximum = int.Parse(alltime);
			progressBar5.Maximum = int.Parse(alltime);
			progressBar6.Maximum = int.Parse(alltime);
			progressBar7.Maximum = int.Parse(alltime);
			progressBar8.Maximum = int.Parse(alltime);

		}
		private void re1_Click(object sender, EventArgs e)
		{
			time1.Text = alltime;
			time1.BackColor = Color.Transparent;
		}
		private void re2_Click(object sender, EventArgs e)
		{
			time2.Text = alltime;
			time2.BackColor = Color.Transparent;
		}
		private void re3_Click(object sender, EventArgs e)
		{
			time3.Text = alltime;
			time3.BackColor = Color.Transparent;
		}
		private void re4_Click(object sender, EventArgs e)
		{
			time4.Text = alltime;
			time4.BackColor = Color.Transparent;
		}
		private void re5_Click(object sender, EventArgs e)
		{
			time5.Text = alltime;
			time5.BackColor = Color.Transparent;
		}
		private void re6_Click(object sender, EventArgs e)
		{
			time6.Text = alltime;
			time6.BackColor = Color.Transparent;
		}
		private void re7_Click(object sender, EventArgs e)
		{
			time7.Text = alltime;
			time7.BackColor = Color.Transparent;
		}
		#endregion

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (enable.Checked == true)
			{
				int timeleft = Int32.Parse(time.Text);
				timeleft--;
				if (timeleft >= 0)
				{
					progressBar1.Value = int.Parse(alltime) - timeleft;
				}
				time.Text = timeleft.ToString();
				if (timeleft == 0)
				{
					enable.Checked = false;
					time.BackColor = Color.Red;
				}
				else if (timeleft <= mindingtime && timeleft > 0)
				{
					time.BackColor = Color.Yellow;
				}
			}
			if (enable1.Checked == true)
			{
				int timeleft = Int32.Parse(time1.Text);
				timeleft--;
				if (timeleft >= 0)
				{
					progressBar2.Value = int.Parse(alltime) - timeleft;
				}
				time1.Text = timeleft.ToString();
				if (timeleft == 0)
				{
					enable1.Checked = false;
					time1.BackColor = Color.Red;
				}
				else if (timeleft <= mindingtime && timeleft > 0)
				{
					time1.BackColor = Color.Yellow;
				}

			}
			if (enable2.Checked == true)
			{
				int timeleft = Int32.Parse(time2.Text);
				timeleft--;
				time2.Text = timeleft.ToString();
				if (timeleft >= 0)
				{
					progressBar3.Value = int.Parse(alltime) - timeleft;
				}
				if (timeleft == 0)
				{
					enable2.Checked = false;
					time2.BackColor = Color.Red;
				}
				else if (timeleft <= mindingtime && timeleft > 0)
				{
					time2.BackColor = Color.Yellow;
				}

			}
			if (enable3.Checked == true)
			{
				int timeleft = Int32.Parse(time3.Text);
				timeleft--;
				time3.Text = timeleft.ToString();
				if (timeleft >= 0)
				{
					progressBar4.Value = int.Parse(alltime) - timeleft;
				}
				if (timeleft == 0)
				{
					enable3.Checked = false;
					time3.BackColor = Color.Red;
				}
				else if (timeleft <= mindingtime && timeleft > 0)
				{
					time3.BackColor = Color.Yellow;
				}

			}
			if (enable4.Checked == true)
			{
				int timeleft = Int32.Parse(time4.Text);
				timeleft--;
				time4.Text = timeleft.ToString();
				if (timeleft >= 0)
				{
					progressBar5.Value = int.Parse(alltime) - timeleft;
				}
				if (timeleft == 0)
				{
					enable4.Checked = false;
					time4.BackColor = Color.Red;
				}
				else if (timeleft <= mindingtime && timeleft > 0)
				{
					time4.BackColor = Color.Yellow;
				}

			}
			if (enable5.Checked == true)
			{
				int timeleft = Int32.Parse(time5.Text);
				timeleft--;
				time5.Text = timeleft.ToString();
				if (timeleft >= 0)
				{
					progressBar6.Value = int.Parse(alltime) - timeleft;
				}
				if (timeleft == 0)
				{
					enable5.Checked = false;
					time5.BackColor = Color.Red;
				}
				else if (timeleft <= mindingtime && timeleft > 0)
				{
					time5.BackColor = Color.Yellow;
				}

			}
			if (enable6.Checked == true)
			{
				int timeleft = Int32.Parse(time6.Text);
				timeleft--;
				time6.Text = timeleft.ToString();
				if (timeleft >= 0)
				{
					progressBar7.Value = int.Parse(alltime) - timeleft;
				}
				if (timeleft == 0)
				{
					enable6.Checked = false;
					time6.BackColor = Color.Red;
				}
				else if (timeleft <= mindingtime && timeleft > 0)
				{
					time6.BackColor = Color.Yellow;
				}

			}
			if (enable7.Checked == true)
			{
				int timeleft = Int32.Parse(time7.Text);
				timeleft--;
				time7.Text = timeleft.ToString();
				if (timeleft >= 0)
				{
					progressBar8.Value = int.Parse(alltime) - timeleft;
				}
				if (timeleft == 0)
				{
					enable7.Checked = false;
					time7.BackColor = Color.Red;
				}
				else if (timeleft <= mindingtime && timeleft > 0)
				{
					time7.BackColor = Color.Yellow;
				}

			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			mindingtime = Int32.Parse(mindtime.Text);
			alltime = fulltime.Text;
			/*
			time.Text = alltime;
			time1.Text = alltime;
			time2.Text = alltime;
			time3.Text = alltime;
			time4.Text = alltime;
			time5.Text = alltime;
			time6.Text = alltime;
			time7.Text = alltime;
*/
		}

		private void resetall_Click(object sender, EventArgs e)
		{
			button1_Click(sender, e);
			re_Click(sender, e);
			re1_Click(sender, e);
			re2_Click(sender, e);
			re3_Click(sender, e);
			re4_Click(sender, e);
			re5_Click(sender, e);
			re6_Click(sender, e);
			re7_Click(sender, e);

		}
	}
}
