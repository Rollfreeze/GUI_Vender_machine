using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenderMachine
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int money = 0;

		bool check1 = true;
		bool check2 = true;
		bool check3 = true;
		bool check4 = true;
		bool check5 = true;
		bool check6 = true;
		bool check7 = true;
		bool check8 = true;
		bool check9 = true;

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void panel7_Paint(object sender, PaintEventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private async void button1_Click(object sender, EventArgs e)
		{
			if (check1 == true && money >= 30)
			{
				pictureBox2.Visible = true;
				money -= 30;
				label1.Text = "₽:" + money;
				await Task.Delay(TimeSpan.FromSeconds(3));
				pictureBox2.Visible = false;
			}
			else
			{
				if (check1 == true)
				{
					label5.Visible = true;
					await Task.Delay(TimeSpan.FromSeconds(3));
					label5.Visible = false;
				}
				else
				{
					label6.Visible = true;
					await Task.Delay(TimeSpan.FromSeconds(3));
					label6.Visible = false;
				}
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			if (check1 == true)
				check1 = false;
			else
				check1 = true;

			if (check1 == true)
			{
				button10.BackColor = Color.Green;
			}

			if (check1 == false)
			{
				button10.BackColor = Color.Red;
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			if (check2 == true)
				check2 = false;
			else
				check2 = true;

			if (check2 == true)
			{
				button11.BackColor = Color.Green;
			}

			if (check2 == false)
			{
				button11.BackColor = Color.Red;
			}
		}

		private void button19_Click(object sender, EventArgs e)
		{
			money += 50;
			label1.Text = "₽:" + money;
		}

		private void button12_Click(object sender, EventArgs e)
		{
			if (check3 == true)
				check3 = false;
			else
				check3 = true;

			if (check3 == true)
			{
				button12.BackColor = Color.Green;
			}

			if (check3 == false)
			{
				button12.BackColor = Color.Red;
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			if (check4 == true)
				check4 = false;
			else
				check4 = true;

			if (check4 == true)
			{
				button13.BackColor = Color.Green;
			}

			if (check4 == false)
			{
				button13.BackColor = Color.Red;
			}
		}

		private void button14_Click(object sender, EventArgs e)
		{
			if (check5 == true)
				check5 = false;
			else
				check5 = true;

			if (check5 == true)
			{
				button14.BackColor = Color.Green;
			}

			if (check5 == false)
			{
				button14.BackColor = Color.Red;
			}
		}

		private void button15_Click(object sender, EventArgs e)
		{
			if (check6 == true)
				check6 = false;
			else
				check6 = true;

			if (check6 == true)
			{
				button15.BackColor = Color.Green;
			}

			if (check6 == false)
			{
				button15.BackColor = Color.Red;
			}
		}

		private void button16_Click(object sender, EventArgs e)
		{
			if (check7 == true)
				check7 = false;
			else
				check7 = true;

			if (check7 == true)
			{
				button16.BackColor = Color.Green;
			}

			if (check7 == false)
			{
				button16.BackColor = Color.Red;
			}
		}

		private void button17_Click(object sender, EventArgs e)
		{
			if (check8 == true)
				check8 = false;
			else
				check8 = true;

			if (check8 == true)
			{
				button17.BackColor = Color.Green;
			}

			if (check8 == false)
			{
				button17.BackColor = Color.Red;
			}
		}

		private void button18_Click(object sender, EventArgs e)
		{
			if (check9 == true)
				check9 = false;
			else
				check9 = true;

			if (check9 == true)
			{
				button18.BackColor = Color.Green;
			}

			if (check9 == false)
			{
				button18.BackColor = Color.Red;
			}
		}

		private void button21_Click(object sender, EventArgs e)
		{
			money = 0;
			label1.Text = "₽:" + money;
		}

		private void button20_Click(object sender, EventArgs e)
		{
			money += 10;
			label1.Text = "₽:" + money;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private async void button2_Click(object sender, EventArgs e)
		{
			if (check2 == true && money >= 30)
			{
				panel11.Visible = true;
				money -= 30;
				label1.Text = "₽:" + money;
				await Task.Delay(TimeSpan.FromSeconds(3));
				panel11.Visible = false;
			}
			else
			{
				if (check2 == true)
				{
					label5.Visible = true;
					await Task.Delay(TimeSpan.FromSeconds(3));
					label5.Visible = false;
				}
				else
				{
					label6.Visible = true;
					await Task.Delay(TimeSpan.FromSeconds(3));
					label6.Visible = false;
				}
			}
		}

		private async void button3_Click(object sender, EventArgs e)
		{
			if (check3 == true && money >= 30)
			{
				panel12.Visible = true;
				money -= 30;
				label1.Text = "₽:" + money;
				await Task.Delay(TimeSpan.FromSeconds(3));
				panel12.Visible = false;
			}
			else
			{
				if (check3 == true)
				{
					label5.Visible = true; //label5 = not engouh money
					await Task.Delay(TimeSpan.FromSeconds(3));
					label5.Visible = false;
				}
				else
				{
					label6.Visible = true; //label6 = there is epmty
					await Task.Delay(TimeSpan.FromSeconds(3));
					label6.Visible = false;
				}
			}
		}

		private async void button4_Click(object sender, EventArgs e)
		{
			if (check4 == true && money >= 70)
			{
				panel9.Visible = true;
				money -= 70;
				label1.Text = "₽:" + money;
				await Task.Delay(TimeSpan.FromSeconds(3));
				panel9.Visible = false;
			}
			else
			{
				if (check4 == true)
				{
					label5.Visible = true;
					await Task.Delay(TimeSpan.FromSeconds(3));
					label5.Visible = false;
				}
				else
				{
					label6.Visible = true;
					await Task.Delay(TimeSpan.FromSeconds(3));
					label6.Visible = false;
				}
			}
		}

		private async void button5_Click(object sender, EventArgs e)
		{
			if (check5 == true && money >= 70)
			{
				panel10.Visible = true;
				money -= 70;
				label1.Text = "₽:" + money;
				await Task.Delay(TimeSpan.FromSeconds(3));
				panel10.Visible = false;
			}
			else
			{
				if (check5 == true)
				{
					label5.Visible = true;
					await Task.Delay(TimeSpan.FromSeconds(3));
					label5.Visible = false;
				}
				else
				{
					label6.Visible = true;
					await Task.Delay(TimeSpan.FromSeconds(3));
					label6.Visible = false;
				}
			}
		}

		private async void button6_Click(object sender, EventArgs e)
		{
			if (check6 == true && money >= 70)
			{
				panel13.Visible = true;
				money -= 70;
				label1.Text = "₽:" + money;
				await Task.Delay(TimeSpan.FromSeconds(3));
				panel13.Visible = false;
			}
			else
			{
				if (check6 == true)
				{
					label5.Visible = true;
					await Task.Delay(TimeSpan.FromSeconds(3));
					label5.Visible = false;
				}
				else
				{
					label6.Visible = true;
					await Task.Delay(TimeSpan.FromSeconds(3));
					label6.Visible = false;
				}
			}
		}

		private async void button7_Click(object sender, EventArgs e)
		{
			if (check7 == true && money >= 70)
			{
				panel14.Visible = true;
				money -= 70;
				label1.Text = "₽:" + money;
				await Task.Delay(TimeSpan.FromSeconds(3));
				panel14.Visible = false;
			}
			else
			{
				if (check7 == true)
				{
					label5.Visible = true;
					await Task.Delay(TimeSpan.FromSeconds(3));
					label5.Visible = false;
				}
				else
				{
					label6.Visible = true;
					await Task.Delay(TimeSpan.FromSeconds(3));
					label6.Visible = false;
				}
			}
		}

		private async void button8_Click(object sender, EventArgs e)
		{
			if (check8 == true && money >= 70)
			{
				panel15.Visible = true;
				money -= 70;
				label1.Text = "₽:" + money;
				await Task.Delay(TimeSpan.FromSeconds(3));
				panel15.Visible = false;
			}
			else
			{
				if (check8 == true)
				{
					label5.Visible = true;
					await Task.Delay(TimeSpan.FromSeconds(3));
					label5.Visible = false;
				}
				else
				{
					label6.Visible = true;
					await Task.Delay(TimeSpan.FromSeconds(3));
					label6.Visible = false;
				}
			}
		}

		private async void button9_Click(object sender, EventArgs e)
		{
			if (check9 == true && money >= 70)
			{
				panel16.Visible = true;
				money -= 70;
				label1.Text = "₽:" + money;
				await Task.Delay(TimeSpan.FromSeconds(3));
				panel16.Visible = false;
			}
			else
			{
				if (check9 == true)
				{
					label5.Visible = true;
					await Task.Delay(TimeSpan.FromSeconds(3));
					label5.Visible = false;
				}
				else
				{
					label6.Visible = true;
					await Task.Delay(TimeSpan.FromSeconds(3));
					label6.Visible = false;
				}
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}