using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace SkyCheats.UserControls
{
	// Token: 0x02000017 RID: 23
	public class UserControl2 : UserControl
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x0000F0E1 File Offset: 0x0000D4E1
		public UserControl2()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000030D9 File Offset: 0x000014D9
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000F0FC File Offset: 0x0000D4FC
		private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
		{
			this.label2.Text = this.metroTrackBar1.Value.ToString();
			config.smooth = Convert.ToDouble(this.metroTrackBar1.Value) / 100.0 / 2.0;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000F154 File Offset: 0x0000D554
		private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
		{
			this.label3.Text = this.metroTrackBar2.Value.ToString();
			config.shot_speed = this.metroTrackBar2.Value;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000F194 File Offset: 0x0000D594
		private void metroTrackBar3_Scroll(object sender, ScrollEventArgs e)
		{
			this.label5.Text = this.metroTrackBar3.Value.ToString();
			config.trigger_speed = this.metroTrackBar3.Value;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000F1D4 File Offset: 0x0000D5D4
		private void metroTrackBar6_Scroll(object sender, ScrollEventArgs e)
		{
			this.label11.Text = (this.metroTrackBar6.Value - 25).ToString();
			config.headx = this.metroTrackBar6.Value - 25;
			config.uwux = config.headx;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000F224 File Offset: 0x0000D624
		private void metroTrackBar7_Scroll(object sender, ScrollEventArgs e)
		{
			this.label13.Text = (this.metroTrackBar7.Value - 25).ToString();
			config.heady = this.metroTrackBar7.Value - 25;
			config.uwuy = config.heady;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000F274 File Offset: 0x0000D674
		private void metroTrackBar5_Scroll(object sender, ScrollEventArgs e)
		{
			this.label9.Text = (this.metroTrackBar5.Value - 25).ToString();
			config.bodyx = this.metroTrackBar5.Value - 25;
			config.uwux = config.bodyx;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000F2C4 File Offset: 0x0000D6C4
		private void metroTrackBar4_Scroll(object sender, ScrollEventArgs e)
		{
			this.label7.Text = (this.metroTrackBar4.Value - 25).ToString();
			config.bodyy = this.metroTrackBar4.Value - 25;
			config.uwuy = config.bodyy;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000F314 File Offset: 0x0000D714
		private void metroTrackBar9_Scroll(object sender, ScrollEventArgs e)
		{
			this.label17.Text = this.metroTrackBar9.Value.ToString();
			config.fov_x = this.metroTrackBar9.Value;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000F354 File Offset: 0x0000D754
		private void metroTrackBar8_Scroll(object sender, ScrollEventArgs e)
		{
			this.label15.Text = this.metroTrackBar8.Value.ToString();
			config.fov_y = this.metroTrackBar8.Value;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000030D9 File Offset: 0x000014D9
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000F394 File Offset: 0x0000D794
		private void metroTrackBar10_Scroll(object sender, ScrollEventArgs e)
		{
			config.sens = Convert.ToDouble(this.metroTrackBar10.Value) / 100.0 * 2.0;
			this.label20.Text = Convert.ToString(config.sens);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000030D9 File Offset: 0x000014D9
		private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000030D9 File Offset: 0x000014D9
		private void metroTrackBar12_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000030D9 File Offset: 0x000014D9
		private void metroTrackBar13_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000030D9 File Offset: 0x000014D9
		private void metroTrackBar11_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000030D9 File Offset: 0x000014D9
		private void metroTrackBar14_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000F3E4 File Offset: 0x0000D7E4
		private void metroTrackBar11_Scroll_1(object sender, ScrollEventArgs e)
		{
			this.label21.Text = this.metroTrackBar11.Value.ToString();
			config.flick_fovx = this.metroTrackBar11.Value;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000F424 File Offset: 0x0000D824
		private void metroTrackBar12_Scroll_1(object sender, ScrollEventArgs e)
		{
			this.label23.Text = this.metroTrackBar12.Value.ToString();
			config.silent_fovx = this.metroTrackBar12.Value;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000F464 File Offset: 0x0000D864
		private void metroTrackBar14_Scroll_1(object sender, ScrollEventArgs e)
		{
			this.label27.Text = this.metroTrackBar14.Value.ToString();
			config.flick_fovy = this.metroTrackBar14.Value;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000F4A4 File Offset: 0x0000D8A4
		private void metroTrackBar13_Scroll_1(object sender, ScrollEventArgs e)
		{
			this.label25.Text = this.metroTrackBar13.Value.ToString();
			config.silent_fovy = this.metroTrackBar13.Value;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000F4E4 File Offset: 0x0000D8E4
		private void metroTrackBar16_Scroll(object sender, ScrollEventArgs e)
		{
			this.label31.Text = this.metroTrackBar16.Value.ToString();
			config.flick_delay = this.metroTrackBar16.Value;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000F524 File Offset: 0x0000D924
		private void metroTrackBar15_Scroll(object sender, ScrollEventArgs e)
		{
			this.label29.Text = this.metroTrackBar15.Value.ToString();
			config.silent_delay = this.metroTrackBar15.Value;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000030D9 File Offset: 0x000014D9
		private void UserControl2_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000F564 File Offset: 0x0000D964
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000F59C File Offset: 0x0000D99C
		private void InitializeComponent()
		{
			this.label1 = new Label();
			this.metroTrackBar1 = new MetroTrackBar();
			this.label2 = new Label();
			this.panel1 = new Panel();
			this.label5 = new Label();
			this.label6 = new Label();
			this.metroTrackBar3 = new MetroTrackBar();
			this.pictureBox2 = new PictureBox();
			this.label3 = new Label();
			this.label4 = new Label();
			this.metroTrackBar2 = new MetroTrackBar();
			this.panel2 = new Panel();
			this.pictureBox4 = new PictureBox();
			this.pictureBox3 = new PictureBox();
			this.label20 = new Label();
			this.label19 = new Label();
			this.metroTrackBar10 = new MetroTrackBar();
			this.label15 = new Label();
			this.label16 = new Label();
			this.metroTrackBar8 = new MetroTrackBar();
			this.label17 = new Label();
			this.label18 = new Label();
			this.metroTrackBar9 = new MetroTrackBar();
			this.label7 = new Label();
			this.label8 = new Label();
			this.metroTrackBar4 = new MetroTrackBar();
			this.label9 = new Label();
			this.label10 = new Label();
			this.metroTrackBar5 = new MetroTrackBar();
			this.label13 = new Label();
			this.label14 = new Label();
			this.metroTrackBar7 = new MetroTrackBar();
			this.label11 = new Label();
			this.label12 = new Label();
			this.metroTrackBar6 = new MetroTrackBar();
			this.panel3 = new Panel();
			this.pictureBox5 = new PictureBox();
			this.label29 = new Label();
			this.label30 = new Label();
			this.metroTrackBar15 = new MetroTrackBar();
			this.label31 = new Label();
			this.label32 = new Label();
			this.metroTrackBar16 = new MetroTrackBar();
			this.label25 = new Label();
			this.label26 = new Label();
			this.metroTrackBar13 = new MetroTrackBar();
			this.label27 = new Label();
			this.label28 = new Label();
			this.metroTrackBar14 = new MetroTrackBar();
			this.label23 = new Label();
			this.label24 = new Label();
			this.metroTrackBar12 = new MetroTrackBar();
			this.label21 = new Label();
			this.label22 = new Label();
			this.metroTrackBar11 = new MetroTrackBar();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			this.panel3.SuspendLayout();
			((ISupportInitialize)this.pictureBox5).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label1.ForeColor = Color.FromArgb(0, 174, 219);
			this.label1.Location = new Point(18, 10);
			this.label1.Name = "label1";
			this.label1.Size = new Size(73, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Aim Speed";
			this.metroTrackBar1.BackColor = Color.Transparent;
			this.metroTrackBar1.Location = new Point(18, 32);
			this.metroTrackBar1.Name = "metroTrackBar1";
			this.metroTrackBar1.Size = new Size(233, 22);
			this.metroTrackBar1.Style = 4;
			this.metroTrackBar1.TabIndex = 1;
			this.metroTrackBar1.Text = "metroTrackBar1";
			this.metroTrackBar1.Theme = 2;
			this.metroTrackBar1.UseCustomBackColor = true;
			this.metroTrackBar1.Scroll += this.metroTrackBar1_Scroll;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Segoe UI", 10f);
			this.label2.ForeColor = Color.FromArgb(153, 153, 153);
			this.label2.Location = new Point(262, 32);
			this.label2.Name = "label2";
			this.label2.Size = new Size(25, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "50";
			this.panel1.BackColor = Color.FromArgb(32, 33, 38);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.metroTrackBar3);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.metroTrackBar1);
			this.panel1.Location = new Point(10, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(314, 142);
			this.panel1.TabIndex = 3;
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Segoe UI", 10f);
			this.label5.ForeColor = Color.FromArgb(153, 153, 153);
			this.label5.Location = new Point(262, 103);
			this.label5.Name = "label5";
			this.label5.Size = new Size(25, 19);
			this.label5.TabIndex = 10;
			this.label5.Text = "50";
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label6.ForeColor = Color.FromArgb(0, 174, 219);
			this.label6.Location = new Point(18, 81);
			this.label6.Name = "label6";
			this.label6.Size = new Size(91, 17);
			this.label6.TabIndex = 8;
			this.label6.Text = "Trigger Speed";
			this.metroTrackBar3.BackColor = Color.Transparent;
			this.metroTrackBar3.Location = new Point(18, 103);
			this.metroTrackBar3.Name = "metroTrackBar3";
			this.metroTrackBar3.Size = new Size(233, 22);
			this.metroTrackBar3.Style = 4;
			this.metroTrackBar3.TabIndex = 9;
			this.metroTrackBar3.Text = "metroTrackBar3";
			this.metroTrackBar3.Theme = 2;
			this.metroTrackBar3.UseCustomBackColor = true;
			this.metroTrackBar3.Scroll += this.metroTrackBar3_Scroll;
			this.pictureBox2.BackColor = Color.FromArgb(0, 174, 219);
			this.pictureBox2.Location = new Point(7, 67);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Size(300, 1);
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Segoe UI", 10f);
			this.label3.ForeColor = Color.FromArgb(153, 153, 153);
			this.label3.Location = new Point(306, 103);
			this.label3.Name = "label3";
			this.label3.Size = new Size(25, 19);
			this.label3.TabIndex = 7;
			this.label3.Text = "50";
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label4.ForeColor = Color.FromArgb(0, 174, 219);
			this.label4.Location = new Point(18, 81);
			this.label4.Name = "label4";
			this.label4.Size = new Size(83, 17);
			this.label4.TabIndex = 5;
			this.label4.Text = "Shots Speed";
			this.metroTrackBar2.BackColor = Color.Transparent;
			this.metroTrackBar2.Location = new Point(18, 103);
			this.metroTrackBar2.Name = "metroTrackBar2";
			this.metroTrackBar2.Size = new Size(273, 22);
			this.metroTrackBar2.Style = 4;
			this.metroTrackBar2.TabIndex = 6;
			this.metroTrackBar2.Text = "metroTrackBar2";
			this.metroTrackBar2.Theme = 2;
			this.metroTrackBar2.UseCustomBackColor = true;
			this.metroTrackBar2.Scroll += this.metroTrackBar2_Scroll;
			this.panel2.BackColor = Color.FromArgb(32, 33, 38);
			this.panel2.Controls.Add(this.pictureBox4);
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Controls.Add(this.label20);
			this.panel2.Controls.Add(this.label19);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.metroTrackBar10);
			this.panel2.Controls.Add(this.label15);
			this.panel2.Controls.Add(this.label16);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.metroTrackBar8);
			this.panel2.Controls.Add(this.metroTrackBar2);
			this.panel2.Controls.Add(this.label17);
			this.panel2.Controls.Add(this.label18);
			this.panel2.Controls.Add(this.metroTrackBar9);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.metroTrackBar4);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.metroTrackBar5);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.metroTrackBar7);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.metroTrackBar6);
			this.panel2.Location = new Point(331, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(350, 344);
			this.panel2.TabIndex = 11;
			this.panel2.Paint += this.panel2_Paint;
			this.pictureBox4.BackColor = Color.FromArgb(0, 174, 219);
			this.pictureBox4.Location = new Point(7, 146);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new Size(336, 1);
			this.pictureBox4.TabIndex = 33;
			this.pictureBox4.TabStop = false;
			this.pictureBox3.BackColor = Color.FromArgb(0, 174, 219);
			this.pictureBox3.Location = new Point(7, 67);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new Size(336, 1);
			this.pictureBox3.TabIndex = 29;
			this.pictureBox3.TabStop = false;
			this.label20.AutoSize = true;
			this.label20.Font = new Font("Segoe UI", 10f);
			this.label20.ForeColor = Color.FromArgb(153, 153, 153);
			this.label20.Location = new Point(306, 29);
			this.label20.Name = "label20";
			this.label20.Size = new Size(28, 19);
			this.label20.TabIndex = 32;
			this.label20.Text = "0.6";
			this.label19.AutoSize = true;
			this.label19.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label19.ForeColor = Color.FromArgb(0, 174, 219);
			this.label19.Location = new Point(18, 9);
			this.label19.Name = "label19";
			this.label19.Size = new Size(61, 17);
			this.label19.TabIndex = 30;
			this.label19.Text = "Sensivity";
			this.metroTrackBar10.BackColor = Color.Transparent;
			this.metroTrackBar10.Location = new Point(21, 29);
			this.metroTrackBar10.Name = "metroTrackBar10";
			this.metroTrackBar10.Size = new Size(270, 22);
			this.metroTrackBar10.Style = 4;
			this.metroTrackBar10.TabIndex = 31;
			this.metroTrackBar10.Text = "metroTrackBar10";
			this.metroTrackBar10.Theme = 2;
			this.metroTrackBar10.UseCustomBackColor = true;
			this.metroTrackBar10.Value = 30;
			this.metroTrackBar10.Scroll += this.metroTrackBar10_Scroll;
			this.label15.AutoSize = true;
			this.label15.Font = new Font("Segoe UI", 10f);
			this.label15.ForeColor = Color.FromArgb(153, 153, 153);
			this.label15.Location = new Point(307, 283);
			this.label15.Name = "label15";
			this.label15.Size = new Size(25, 19);
			this.label15.TabIndex = 25;
			this.label15.Text = "50";
			this.label16.AutoSize = true;
			this.label16.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label16.ForeColor = Color.FromArgb(0, 174, 219);
			this.label16.Location = new Point(181, 283);
			this.label16.Name = "label16";
			this.label16.Size = new Size(58, 17);
			this.label16.TabIndex = 23;
			this.label16.Text = "Fov [ Y ]";
			this.metroTrackBar8.BackColor = Color.Transparent;
			this.metroTrackBar8.Location = new Point(181, 305);
			this.metroTrackBar8.Maximum = 600;
			this.metroTrackBar8.Name = "metroTrackBar8";
			this.metroTrackBar8.Size = new Size(152, 22);
			this.metroTrackBar8.Style = 4;
			this.metroTrackBar8.TabIndex = 24;
			this.metroTrackBar8.Text = "metroTrackBar8";
			this.metroTrackBar8.Theme = 2;
			this.metroTrackBar8.UseCustomBackColor = true;
			this.metroTrackBar8.Scroll += this.metroTrackBar8_Scroll;
			this.label17.AutoSize = true;
			this.label17.Font = new Font("Segoe UI", 10f);
			this.label17.ForeColor = Color.FromArgb(153, 153, 153);
			this.label17.Location = new Point(137, 283);
			this.label17.Name = "label17";
			this.label17.Size = new Size(33, 19);
			this.label17.TabIndex = 22;
			this.label17.Text = "144";
			this.label18.AutoSize = true;
			this.label18.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label18.ForeColor = Color.FromArgb(0, 174, 219);
			this.label18.Location = new Point(11, 283);
			this.label18.Name = "label18";
			this.label18.Size = new Size(58, 17);
			this.label18.TabIndex = 20;
			this.label18.Text = "Fov [ X ]";
			this.metroTrackBar9.BackColor = Color.Transparent;
			this.metroTrackBar9.Location = new Point(11, 305);
			this.metroTrackBar9.Maximum = 900;
			this.metroTrackBar9.Name = "metroTrackBar9";
			this.metroTrackBar9.Size = new Size(152, 22);
			this.metroTrackBar9.Style = 4;
			this.metroTrackBar9.TabIndex = 21;
			this.metroTrackBar9.Text = "metroTrackBar9";
			this.metroTrackBar9.Theme = 2;
			this.metroTrackBar9.UseCustomBackColor = true;
			this.metroTrackBar9.Value = 144;
			this.metroTrackBar9.Scroll += this.metroTrackBar9_Scroll;
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Segoe UI", 10f);
			this.label7.ForeColor = Color.FromArgb(153, 153, 153);
			this.label7.Location = new Point(307, 225);
			this.label7.Name = "label7";
			this.label7.Size = new Size(31, 19);
			this.label7.TabIndex = 19;
			this.label7.Text = "-10";
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label8.ForeColor = Color.FromArgb(0, 174, 219);
			this.label8.Location = new Point(181, 225);
			this.label8.Name = "label8";
			this.label8.Size = new Size(67, 17);
			this.label8.TabIndex = 17;
			this.label8.Text = "Body [ Y ]";
			this.metroTrackBar4.BackColor = Color.Transparent;
			this.metroTrackBar4.Location = new Point(181, 247);
			this.metroTrackBar4.Maximum = 50;
			this.metroTrackBar4.Name = "metroTrackBar4";
			this.metroTrackBar4.Size = new Size(152, 22);
			this.metroTrackBar4.Style = 4;
			this.metroTrackBar4.TabIndex = 18;
			this.metroTrackBar4.Text = "metroTrackBar4";
			this.metroTrackBar4.Theme = 2;
			this.metroTrackBar4.UseCustomBackColor = true;
			this.metroTrackBar4.Value = 15;
			this.metroTrackBar4.Scroll += this.metroTrackBar4_Scroll;
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Segoe UI", 10f);
			this.label9.ForeColor = Color.FromArgb(153, 153, 153);
			this.label9.Location = new Point(137, 235);
			this.label9.Name = "label9";
			this.label9.Size = new Size(23, 19);
			this.label9.TabIndex = 16;
			this.label9.Text = "-1";
			this.label10.AutoSize = true;
			this.label10.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label10.ForeColor = Color.FromArgb(0, 174, 219);
			this.label10.Location = new Point(11, 225);
			this.label10.Name = "label10";
			this.label10.Size = new Size(67, 17);
			this.label10.TabIndex = 14;
			this.label10.Text = "Body [ X ]";
			this.metroTrackBar5.BackColor = Color.Transparent;
			this.metroTrackBar5.Location = new Point(11, 247);
			this.metroTrackBar5.Maximum = 50;
			this.metroTrackBar5.Name = "metroTrackBar5";
			this.metroTrackBar5.Size = new Size(152, 22);
			this.metroTrackBar5.Style = 4;
			this.metroTrackBar5.TabIndex = 15;
			this.metroTrackBar5.Text = "metroTrackBar5";
			this.metroTrackBar5.Theme = 2;
			this.metroTrackBar5.UseCustomBackColor = true;
			this.metroTrackBar5.Value = 24;
			this.metroTrackBar5.Scroll += this.metroTrackBar5_Scroll;
			this.label13.AutoSize = true;
			this.label13.Font = new Font("Segoe UI", 10f);
			this.label13.ForeColor = Color.FromArgb(153, 153, 153);
			this.label13.Location = new Point(307, 168);
			this.label13.Name = "label13";
			this.label13.Size = new Size(23, 19);
			this.label13.TabIndex = 13;
			this.label13.Text = "-3";
			this.label14.AutoSize = true;
			this.label14.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label14.ForeColor = Color.FromArgb(0, 174, 219);
			this.label14.Location = new Point(181, 168);
			this.label14.Name = "label14";
			this.label14.Size = new Size(68, 17);
			this.label14.TabIndex = 11;
			this.label14.Text = "Head [ Y ]";
			this.metroTrackBar7.BackColor = Color.Transparent;
			this.metroTrackBar7.Location = new Point(181, 190);
			this.metroTrackBar7.Maximum = 50;
			this.metroTrackBar7.Name = "metroTrackBar7";
			this.metroTrackBar7.Size = new Size(152, 22);
			this.metroTrackBar7.Style = 4;
			this.metroTrackBar7.TabIndex = 12;
			this.metroTrackBar7.Text = "metroTrackBar7";
			this.metroTrackBar7.Theme = 2;
			this.metroTrackBar7.UseCustomBackColor = true;
			this.metroTrackBar7.Value = 22;
			this.metroTrackBar7.Scroll += this.metroTrackBar7_Scroll;
			this.label11.AutoSize = true;
			this.label11.Font = new Font("Segoe UI", 10f);
			this.label11.ForeColor = Color.FromArgb(153, 153, 153);
			this.label11.Location = new Point(137, 168);
			this.label11.Name = "label11";
			this.label11.Size = new Size(23, 19);
			this.label11.TabIndex = 2;
			this.label11.Text = "-1";
			this.label12.AutoSize = true;
			this.label12.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label12.ForeColor = Color.FromArgb(0, 174, 219);
			this.label12.Location = new Point(11, 168);
			this.label12.Name = "label12";
			this.label12.Size = new Size(68, 17);
			this.label12.TabIndex = 0;
			this.label12.Text = "Head [ X ]";
			this.metroTrackBar6.BackColor = Color.Transparent;
			this.metroTrackBar6.Location = new Point(11, 190);
			this.metroTrackBar6.Maximum = 50;
			this.metroTrackBar6.Name = "metroTrackBar6";
			this.metroTrackBar6.Size = new Size(152, 22);
			this.metroTrackBar6.Style = 4;
			this.metroTrackBar6.TabIndex = 1;
			this.metroTrackBar6.Text = "metroTrackBar6";
			this.metroTrackBar6.Theme = 2;
			this.metroTrackBar6.UseCustomBackColor = true;
			this.metroTrackBar6.Value = 24;
			this.metroTrackBar6.Scroll += this.metroTrackBar6_Scroll;
			this.panel3.BackColor = Color.FromArgb(32, 33, 38);
			this.panel3.Controls.Add(this.pictureBox5);
			this.panel3.Controls.Add(this.label29);
			this.panel3.Controls.Add(this.label30);
			this.panel3.Controls.Add(this.metroTrackBar15);
			this.panel3.Controls.Add(this.label31);
			this.panel3.Controls.Add(this.label32);
			this.panel3.Controls.Add(this.metroTrackBar16);
			this.panel3.Controls.Add(this.label25);
			this.panel3.Controls.Add(this.label26);
			this.panel3.Controls.Add(this.metroTrackBar13);
			this.panel3.Controls.Add(this.label27);
			this.panel3.Controls.Add(this.label28);
			this.panel3.Controls.Add(this.metroTrackBar14);
			this.panel3.Controls.Add(this.label23);
			this.panel3.Controls.Add(this.label24);
			this.panel3.Controls.Add(this.metroTrackBar12);
			this.panel3.Controls.Add(this.label21);
			this.panel3.Controls.Add(this.label22);
			this.panel3.Controls.Add(this.metroTrackBar11);
			this.panel3.Location = new Point(10, 143);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(314, 213);
			this.panel3.TabIndex = 13;
			this.pictureBox5.BackColor = Color.FromArgb(0, 174, 219);
			this.pictureBox5.Location = new Point(7, 15);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new Size(300, 1);
			this.pictureBox5.TabIndex = 34;
			this.pictureBox5.TabStop = false;
			this.label29.AutoSize = true;
			this.label29.Font = new Font("Segoe UI", 10f);
			this.label29.ForeColor = Color.FromArgb(153, 153, 153);
			this.label29.Location = new Point(271, 152);
			this.label29.Name = "label29";
			this.label29.Size = new Size(25, 19);
			this.label29.TabIndex = 50;
			this.label29.Text = "25";
			this.label30.AutoSize = true;
			this.label30.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label30.ForeColor = Color.FromArgb(0, 174, 219);
			this.label30.Location = new Point(163, 152);
			this.label30.Name = "label30";
			this.label30.Size = new Size(107, 17);
			this.label30.TabIndex = 48;
			this.label30.Text = "Silent Bot Speed";
			this.metroTrackBar15.BackColor = Color.Transparent;
			this.metroTrackBar15.Location = new Point(163, 174);
			this.metroTrackBar15.Maximum = 500;
			this.metroTrackBar15.Name = "metroTrackBar15";
			this.metroTrackBar15.Size = new Size(124, 22);
			this.metroTrackBar15.Style = 4;
			this.metroTrackBar15.TabIndex = 49;
			this.metroTrackBar15.Text = "metroTrackBar15";
			this.metroTrackBar15.Theme = 2;
			this.metroTrackBar15.UseCustomBackColor = true;
			this.metroTrackBar15.Value = 25;
			this.metroTrackBar15.Scroll += this.metroTrackBar15_Scroll;
			this.label31.AutoSize = true;
			this.label31.Font = new Font("Segoe UI", 10f);
			this.label31.ForeColor = Color.FromArgb(153, 153, 153);
			this.label31.Location = new Point(123, 152);
			this.label31.Name = "label31";
			this.label31.Size = new Size(25, 19);
			this.label31.TabIndex = 47;
			this.label31.Text = "25";
			this.label32.AutoSize = true;
			this.label32.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label32.ForeColor = Color.FromArgb(0, 174, 219);
			this.label32.Location = new Point(22, 152);
			this.label32.Name = "label32";
			this.label32.Size = new Size(100, 17);
			this.label32.TabIndex = 45;
			this.label32.Text = "Flick Bot Speed";
			this.metroTrackBar16.BackColor = Color.Transparent;
			this.metroTrackBar16.Location = new Point(22, 174);
			this.metroTrackBar16.Maximum = 500;
			this.metroTrackBar16.Name = "metroTrackBar16";
			this.metroTrackBar16.Size = new Size(124, 22);
			this.metroTrackBar16.Style = 4;
			this.metroTrackBar16.TabIndex = 46;
			this.metroTrackBar16.Text = "metroTrackBar16";
			this.metroTrackBar16.Theme = 2;
			this.metroTrackBar16.UseCustomBackColor = true;
			this.metroTrackBar16.Value = 25;
			this.metroTrackBar16.Scroll += this.metroTrackBar16_Scroll;
			this.label25.AutoSize = true;
			this.label25.Font = new Font("Segoe UI", 10f);
			this.label25.ForeColor = Color.FromArgb(153, 153, 153);
			this.label25.Location = new Point(271, 94);
			this.label25.Name = "label25";
			this.label25.Size = new Size(25, 19);
			this.label25.TabIndex = 44;
			this.label25.Text = "50";
			this.label26.AutoSize = true;
			this.label26.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label26.ForeColor = Color.FromArgb(0, 174, 219);
			this.label26.Location = new Point(163, 94);
			this.label26.Name = "label26";
			this.label26.Size = new Size(94, 17);
			this.label26.TabIndex = 42;
			this.label26.Text = "Silent Bot [ Y ]";
			this.metroTrackBar13.BackColor = Color.Transparent;
			this.metroTrackBar13.Location = new Point(163, 116);
			this.metroTrackBar13.Maximum = 900;
			this.metroTrackBar13.Name = "metroTrackBar13";
			this.metroTrackBar13.Size = new Size(124, 22);
			this.metroTrackBar13.Style = 4;
			this.metroTrackBar13.TabIndex = 43;
			this.metroTrackBar13.Text = "metroTrackBar13";
			this.metroTrackBar13.Theme = 2;
			this.metroTrackBar13.UseCustomBackColor = true;
			this.metroTrackBar13.Scroll += this.metroTrackBar13_Scroll_1;
			this.label27.AutoSize = true;
			this.label27.Font = new Font("Segoe UI", 10f);
			this.label27.ForeColor = Color.FromArgb(153, 153, 153);
			this.label27.Location = new Point(123, 94);
			this.label27.Name = "label27";
			this.label27.Size = new Size(25, 19);
			this.label27.TabIndex = 41;
			this.label27.Text = "50";
			this.label28.AutoSize = true;
			this.label28.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label28.ForeColor = Color.FromArgb(0, 174, 219);
			this.label28.Location = new Point(22, 94);
			this.label28.Name = "label28";
			this.label28.Size = new Size(87, 17);
			this.label28.TabIndex = 39;
			this.label28.Text = "Flick Bot [ Y ]";
			this.metroTrackBar14.BackColor = Color.Transparent;
			this.metroTrackBar14.Location = new Point(22, 116);
			this.metroTrackBar14.Maximum = 900;
			this.metroTrackBar14.Name = "metroTrackBar14";
			this.metroTrackBar14.Size = new Size(124, 22);
			this.metroTrackBar14.Style = 4;
			this.metroTrackBar14.TabIndex = 40;
			this.metroTrackBar14.Text = "metroTrackBar14";
			this.metroTrackBar14.Theme = 2;
			this.metroTrackBar14.UseCustomBackColor = true;
			this.metroTrackBar14.Scroll += this.metroTrackBar14_Scroll_1;
			this.label23.AutoSize = true;
			this.label23.Font = new Font("Segoe UI", 10f);
			this.label23.ForeColor = Color.FromArgb(153, 153, 153);
			this.label23.Location = new Point(263, 37);
			this.label23.Name = "label23";
			this.label23.Size = new Size(33, 19);
			this.label23.TabIndex = 38;
			this.label23.Text = "350";
			this.label24.AutoSize = true;
			this.label24.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label24.ForeColor = Color.FromArgb(0, 174, 219);
			this.label24.Location = new Point(163, 37);
			this.label24.Name = "label24";
			this.label24.Size = new Size(94, 17);
			this.label24.TabIndex = 36;
			this.label24.Text = "Silent Bot [ X ]";
			this.metroTrackBar12.BackColor = Color.Transparent;
			this.metroTrackBar12.Location = new Point(163, 59);
			this.metroTrackBar12.Maximum = 900;
			this.metroTrackBar12.Name = "metroTrackBar12";
			this.metroTrackBar12.Size = new Size(124, 22);
			this.metroTrackBar12.Style = 4;
			this.metroTrackBar12.TabIndex = 37;
			this.metroTrackBar12.Text = "metroTrackBar12";
			this.metroTrackBar12.Theme = 2;
			this.metroTrackBar12.UseCustomBackColor = true;
			this.metroTrackBar12.Value = 350;
			this.metroTrackBar12.Scroll += this.metroTrackBar12_Scroll_1;
			this.label21.AutoSize = true;
			this.label21.Font = new Font("Segoe UI", 10f);
			this.label21.ForeColor = Color.FromArgb(153, 153, 153);
			this.label21.Location = new Point(115, 37);
			this.label21.Name = "label21";
			this.label21.Size = new Size(33, 19);
			this.label21.TabIndex = 35;
			this.label21.Text = "350";
			this.label22.AutoSize = true;
			this.label22.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label22.ForeColor = Color.FromArgb(0, 174, 219);
			this.label22.Location = new Point(22, 37);
			this.label22.Name = "label22";
			this.label22.Size = new Size(87, 17);
			this.label22.TabIndex = 33;
			this.label22.Text = "Flick Bot [ X ]";
			this.metroTrackBar11.BackColor = Color.Transparent;
			this.metroTrackBar11.Location = new Point(22, 59);
			this.metroTrackBar11.Maximum = 900;
			this.metroTrackBar11.Name = "metroTrackBar11";
			this.metroTrackBar11.Size = new Size(124, 22);
			this.metroTrackBar11.Style = 4;
			this.metroTrackBar11.TabIndex = 34;
			this.metroTrackBar11.Text = "metroTrackBar11";
			this.metroTrackBar11.Theme = 2;
			this.metroTrackBar11.UseCustomBackColor = true;
			this.metroTrackBar11.Value = 350;
			this.metroTrackBar11.Scroll += this.metroTrackBar11_Scroll_1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(39, 41, 47);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Name = "UserControl2";
			base.Size = new Size(691, 366);
			base.Load += this.UserControl2_Load;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.pictureBox2).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((ISupportInitialize)this.pictureBox4).EndInit();
			((ISupportInitialize)this.pictureBox3).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((ISupportInitialize)this.pictureBox5).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000118 RID: 280
		private IContainer components = null;

		// Token: 0x04000119 RID: 281
		private Label label1;

		// Token: 0x0400011A RID: 282
		private MetroTrackBar metroTrackBar1;

		// Token: 0x0400011B RID: 283
		private Label label2;

		// Token: 0x0400011C RID: 284
		private Panel panel1;

		// Token: 0x0400011D RID: 285
		private Label label5;

		// Token: 0x0400011E RID: 286
		private Label label6;

		// Token: 0x0400011F RID: 287
		private MetroTrackBar metroTrackBar3;

		// Token: 0x04000120 RID: 288
		private Label label3;

		// Token: 0x04000121 RID: 289
		private Label label4;

		// Token: 0x04000122 RID: 290
		private MetroTrackBar metroTrackBar2;

		// Token: 0x04000123 RID: 291
		private PictureBox pictureBox2;

		// Token: 0x04000124 RID: 292
		private Panel panel2;

		// Token: 0x04000125 RID: 293
		private Label label15;

		// Token: 0x04000126 RID: 294
		private Label label16;

		// Token: 0x04000127 RID: 295
		private MetroTrackBar metroTrackBar8;

		// Token: 0x04000128 RID: 296
		private Label label17;

		// Token: 0x04000129 RID: 297
		private Label label18;

		// Token: 0x0400012A RID: 298
		private MetroTrackBar metroTrackBar9;

		// Token: 0x0400012B RID: 299
		private Label label7;

		// Token: 0x0400012C RID: 300
		private Label label8;

		// Token: 0x0400012D RID: 301
		private MetroTrackBar metroTrackBar4;

		// Token: 0x0400012E RID: 302
		private Label label9;

		// Token: 0x0400012F RID: 303
		private Label label10;

		// Token: 0x04000130 RID: 304
		private MetroTrackBar metroTrackBar5;

		// Token: 0x04000131 RID: 305
		private Label label13;

		// Token: 0x04000132 RID: 306
		private Label label14;

		// Token: 0x04000133 RID: 307
		private MetroTrackBar metroTrackBar7;

		// Token: 0x04000134 RID: 308
		private Label label11;

		// Token: 0x04000135 RID: 309
		private Label label12;

		// Token: 0x04000136 RID: 310
		private MetroTrackBar metroTrackBar6;

		// Token: 0x04000137 RID: 311
		private PictureBox pictureBox3;

		// Token: 0x04000138 RID: 312
		private Label label20;

		// Token: 0x04000139 RID: 313
		private Label label19;

		// Token: 0x0400013A RID: 314
		private MetroTrackBar metroTrackBar10;

		// Token: 0x0400013B RID: 315
		private Panel panel3;

		// Token: 0x0400013C RID: 316
		private PictureBox pictureBox4;

		// Token: 0x0400013D RID: 317
		private PictureBox pictureBox5;

		// Token: 0x0400013E RID: 318
		private Label label29;

		// Token: 0x0400013F RID: 319
		private Label label30;

		// Token: 0x04000140 RID: 320
		private MetroTrackBar metroTrackBar15;

		// Token: 0x04000141 RID: 321
		private Label label31;

		// Token: 0x04000142 RID: 322
		private Label label32;

		// Token: 0x04000143 RID: 323
		private MetroTrackBar metroTrackBar16;

		// Token: 0x04000144 RID: 324
		private Label label25;

		// Token: 0x04000145 RID: 325
		private Label label26;

		// Token: 0x04000146 RID: 326
		private MetroTrackBar metroTrackBar13;

		// Token: 0x04000147 RID: 327
		private Label label27;

		// Token: 0x04000148 RID: 328
		private Label label28;

		// Token: 0x04000149 RID: 329
		private MetroTrackBar metroTrackBar14;

		// Token: 0x0400014A RID: 330
		private Label label23;

		// Token: 0x0400014B RID: 331
		private Label label24;

		// Token: 0x0400014C RID: 332
		private MetroTrackBar metroTrackBar12;

		// Token: 0x0400014D RID: 333
		private Label label21;

		// Token: 0x0400014E RID: 334
		private Label label22;

		// Token: 0x0400014F RID: 335
		private MetroTrackBar metroTrackBar11;
	}
}
