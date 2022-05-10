using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SkyCheats.Properties;

namespace SkyCheats.LUserControls
{
	// Token: 0x0200002F RID: 47
	public class LUserControl3 : UserControl
	{
		// Token: 0x06000316 RID: 790 RVA: 0x00021AD2 File Offset: 0x0001FED2
		public LUserControl3()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000D008 File Offset: 0x0000B408
		private void button1_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00021AEC File Offset: 0x0001FEEC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00021B24 File Offset: 0x0001FF24
		private void InitializeComponent()
		{
			this.panel14 = new Panel();
			this.label3 = new Label();
			this.pictureBox2 = new PictureBox();
			this.label20 = new Label();
			this.pictureBox16 = new PictureBox();
			this.label18 = new Label();
			this.label5 = new Label();
			this.label1 = new Label();
			this.panel11 = new Panel();
			this.label2 = new Label();
			this.pictureBox1 = new PictureBox();
			this.panel2 = new Panel();
			this.label6 = new Label();
			this.pictureBox3 = new PictureBox();
			this.panel3 = new Panel();
			this.label7 = new Label();
			this.pictureBox4 = new PictureBox();
			this.panel5 = new Panel();
			this.label9 = new Label();
			this.pictureBox6 = new PictureBox();
			this.button1 = new Button();
			this.Icon2_Top_Panel = new PictureBox();
			this.label10 = new Label();
			this.panel14.SuspendLayout();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			((ISupportInitialize)this.pictureBox16).BeginInit();
			this.panel11.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			this.panel3.SuspendLayout();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			this.panel5.SuspendLayout();
			((ISupportInitialize)this.pictureBox6).BeginInit();
			((ISupportInitialize)this.Icon2_Top_Panel).BeginInit();
			base.SuspendLayout();
			this.panel14.BackColor = Color.FromArgb(28, 29, 34);
			this.panel14.Controls.Add(this.label3);
			this.panel14.Controls.Add(this.pictureBox2);
			this.panel14.Controls.Add(this.label20);
			this.panel14.Controls.Add(this.pictureBox16);
			this.panel14.Controls.Add(this.label18);
			this.panel14.Location = new Point(0, 286);
			this.panel14.Name = "panel14";
			this.panel14.Size = new Size(186, 224);
			this.panel14.TabIndex = 59;
			this.label3.Font = new Font("Segoe UI", 12f);
			this.label3.ForeColor = Color.FromArgb(153, 153, 153);
			this.label3.Location = new Point(65, 73);
			this.label3.Name = "label3";
			this.label3.Size = new Size(74, 32);
			this.label3.TabIndex = 63;
			this.label3.Text = "FenZy";
			this.label3.TextAlign = ContentAlignment.MiddleLeft;
			this.pictureBox2.Image = Resources.Anonim;
			this.pictureBox2.Location = new Point(27, 73);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Size(32, 32);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 62;
			this.pictureBox2.TabStop = false;
			this.label20.Font = new Font("Segoe UI", 12f);
			this.label20.ForeColor = Color.FromArgb(153, 153, 153);
			this.label20.Location = new Point(65, 32);
			this.label20.Name = "label20";
			this.label20.Size = new Size(74, 32);
			this.label20.TabIndex = 61;
			this.label20.Text = "Blast";
			this.label20.TextAlign = ContentAlignment.MiddleLeft;
			this.pictureBox16.Image = Resources.Anonim;
			this.pictureBox16.Location = new Point(27, 32);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new Size(32, 32);
			this.pictureBox16.SizeMode = PictureBoxSizeMode.AutoSize;
			this.pictureBox16.TabIndex = 60;
			this.pictureBox16.TabStop = false;
			this.label18.AutoSize = true;
			this.label18.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label18.ForeColor = Color.FromArgb(0, 174, 219);
			this.label18.Location = new Point(23, 6);
			this.label18.Name = "label18";
			this.label18.Size = new Size(57, 17);
			this.label18.TabIndex = 53;
			this.label18.Text = "Support";
			this.label5.Font = new Font("Segoe UI", 10f);
			this.label5.ForeColor = Color.FromArgb(153, 153, 153);
			this.label5.Location = new Point(10, 53);
			this.label5.Name = "label5";
			this.label5.Size = new Size(165, 45);
			this.label5.TabIndex = 105;
			this.label5.Text = " You can contact us in these ways.";
			this.label5.TextAlign = ContentAlignment.MiddleCenter;
			this.label1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label1.ForeColor = Color.FromArgb(0, 174, 219);
			this.label1.Location = new Point(0, 5);
			this.label1.Name = "label1";
			this.label1.Size = new Size(186, 72);
			this.label1.TabIndex = 104;
			this.label1.Text = "Contact";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.panel11.Controls.Add(this.label2);
			this.panel11.Controls.Add(this.pictureBox1);
			this.panel11.Location = new Point(14, 101);
			this.panel11.Name = "panel11";
			this.panel11.Size = new Size(60, 60);
			this.panel11.TabIndex = 108;
			this.label2.Dock = DockStyle.Fill;
			this.label2.Font = new Font("Segoe UI Semibold", 8f, FontStyle.Bold);
			this.label2.ForeColor = Color.FromArgb(0, 174, 219);
			this.label2.Location = new Point(0, 32);
			this.label2.Name = "label2";
			this.label2.Size = new Size(60, 28);
			this.label2.TabIndex = 46;
			this.label2.Text = "Discord";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.pictureBox1.Dock = DockStyle.Top;
			this.pictureBox1.Image = Resources.Discord1;
			this.pictureBox1.Location = new Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(60, 32);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Location = new Point(14, 167);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(60, 60);
			this.panel2.TabIndex = 109;
			this.label6.Dock = DockStyle.Fill;
			this.label6.Font = new Font("Segoe UI Semibold", 8f, FontStyle.Bold);
			this.label6.ForeColor = Color.FromArgb(0, 174, 219);
			this.label6.Location = new Point(0, 32);
			this.label6.Name = "label6";
			this.label6.Size = new Size(60, 28);
			this.label6.TabIndex = 46;
			this.label6.Text = "Discord";
			this.label6.TextAlign = ContentAlignment.MiddleCenter;
			this.pictureBox3.Dock = DockStyle.Top;
			this.pictureBox3.Image = Resources.Sky;
			this.pictureBox3.Location = new Point(0, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new Size(60, 32);
			this.pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox3.TabIndex = 12;
			this.pictureBox3.TabStop = false;
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.pictureBox4);
			this.panel3.Location = new Point(115, 167);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(60, 60);
			this.panel3.TabIndex = 110;
			this.label7.Dock = DockStyle.Fill;
			this.label7.Font = new Font("Segoe UI Semibold", 8f, FontStyle.Bold);
			this.label7.ForeColor = Color.FromArgb(0, 174, 219);
			this.label7.Location = new Point(0, 32);
			this.label7.Name = "label7";
			this.label7.Size = new Size(60, 28);
			this.label7.TabIndex = 46;
			this.label7.Text = "Discord";
			this.label7.TextAlign = ContentAlignment.MiddleCenter;
			this.pictureBox4.Dock = DockStyle.Top;
			this.pictureBox4.Image = Resources.Whatsapp;
			this.pictureBox4.Location = new Point(0, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new Size(60, 32);
			this.pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox4.TabIndex = 12;
			this.pictureBox4.TabStop = false;
			this.panel5.Controls.Add(this.label9);
			this.panel5.Controls.Add(this.pictureBox6);
			this.panel5.Location = new Point(115, 101);
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size(60, 60);
			this.panel5.TabIndex = 112;
			this.label9.Dock = DockStyle.Fill;
			this.label9.Font = new Font("Segoe UI Semibold", 8f, FontStyle.Bold);
			this.label9.ForeColor = Color.FromArgb(0, 174, 219);
			this.label9.Location = new Point(0, 32);
			this.label9.Name = "label9";
			this.label9.Size = new Size(60, 28);
			this.label9.TabIndex = 46;
			this.label9.Text = "Discord";
			this.label9.TextAlign = ContentAlignment.MiddleCenter;
			this.pictureBox6.Dock = DockStyle.Top;
			this.pictureBox6.Image = Resources.Telegram;
			this.pictureBox6.Location = new Point(0, 0);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new Size(60, 32);
			this.pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox6.TabIndex = 12;
			this.pictureBox6.TabStop = false;
			this.button1.BackColor = Color.FromArgb(0, 174, 219);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			this.button1.Location = new Point(10, 244);
			this.button1.Name = "button1";
			this.button1.Size = new Size(166, 26);
			this.button1.TabIndex = 113;
			this.button1.Text = "Back";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += this.button1_Click;
			this.Icon2_Top_Panel.Image = Resources.SLOGOSS2;
			this.Icon2_Top_Panel.Location = new Point(39, 2);
			this.Icon2_Top_Panel.Name = "Icon2_Top_Panel";
			this.Icon2_Top_Panel.Size = new Size(25, 25);
			this.Icon2_Top_Panel.SizeMode = PictureBoxSizeMode.Zoom;
			this.Icon2_Top_Panel.TabIndex = 119;
			this.Icon2_Top_Panel.TabStop = false;
			this.label10.AutoSize = true;
			this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label10.ForeColor = Color.FromArgb(0, 174, 219);
			this.label10.Location = new Point(62, 7);
			this.label10.Name = "label10";
			this.label10.Size = new Size(72, 16);
			this.label10.TabIndex = 120;
			this.label10.Text = "Blast Aim";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(28, 29, 34);
			base.Controls.Add(this.Icon2_Top_Panel);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.panel5);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel11);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.panel14);
			base.Name = "LUserControl3";
			base.Size = new Size(186, 427);
			this.panel14.ResumeLayout(false);
			this.panel14.PerformLayout();
			((ISupportInitialize)this.pictureBox2).EndInit();
			((ISupportInitialize)this.pictureBox16).EndInit();
			this.panel11.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.panel2.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox3).EndInit();
			this.panel3.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox4).EndInit();
			this.panel5.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox6).EndInit();
			((ISupportInitialize)this.Icon2_Top_Panel).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400025A RID: 602
		private IContainer components = null;

		// Token: 0x0400025B RID: 603
		private Panel panel14;

		// Token: 0x0400025C RID: 604
		private Label label20;

		// Token: 0x0400025D RID: 605
		private PictureBox pictureBox16;

		// Token: 0x0400025E RID: 606
		private Label label18;

		// Token: 0x0400025F RID: 607
		private Label label5;

		// Token: 0x04000260 RID: 608
		private Label label1;

		// Token: 0x04000261 RID: 609
		private Panel panel11;

		// Token: 0x04000262 RID: 610
		private Label label2;

		// Token: 0x04000263 RID: 611
		private PictureBox pictureBox1;

		// Token: 0x04000264 RID: 612
		private Panel panel2;

		// Token: 0x04000265 RID: 613
		private Label label6;

		// Token: 0x04000266 RID: 614
		private PictureBox pictureBox3;

		// Token: 0x04000267 RID: 615
		private Panel panel3;

		// Token: 0x04000268 RID: 616
		private Label label7;

		// Token: 0x04000269 RID: 617
		private PictureBox pictureBox4;

		// Token: 0x0400026A RID: 618
		private Panel panel5;

		// Token: 0x0400026B RID: 619
		private Label label9;

		// Token: 0x0400026C RID: 620
		private PictureBox pictureBox6;

		// Token: 0x0400026D RID: 621
		private Button button1;

		// Token: 0x0400026E RID: 622
		private PictureBox Icon2_Top_Panel;

		// Token: 0x0400026F RID: 623
		private Label label10;

		// Token: 0x04000270 RID: 624
		private Label label3;

		// Token: 0x04000271 RID: 625
		private PictureBox pictureBox2;
	}
}
