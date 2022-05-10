using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
using SkyCheats.Properties;

namespace SkyCheats.LUserControls
{
	// Token: 0x0200002D RID: 45
	public class LUserControl1 : UserControl
	{
		// Token: 0x06000306 RID: 774 RVA: 0x0001FEAA File Offset: 0x0001E2AA
		public LUserControl1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000D008 File Offset: 0x0000B408
		private void label6_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0001FEC4 File Offset: 0x0001E2C4
		private void button1_Click(object sender, EventArgs e)
		{
			LUserControl1.KeyAuthApp.register(this.metroTextBox2.Text, this.metroTextBox1.Text, this.metroTextBox3.Text);
			bool success = LUserControl1.KeyAuthApp.response.success;
			if (success)
			{
				base.Hide();
			}
			else
			{
				this.label4.Show();
			}
			this.label7.Show();
			this.label8.Show();
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0001FF40 File Offset: 0x0001E340
		private void label9_Click(object sender, EventArgs e)
		{
			this.lUserControl31.Show();
			this.lUserControl31.BringToFront();
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0001FF5C File Offset: 0x0001E35C
		private void LUserControl1_Load(object sender, EventArgs e)
		{
			LUserControl1.KeyAuthApp.init();
			bool flag = !LUserControl1.KeyAuthApp.response.success;
			if (flag)
			{
				MessageBox.Show(LUserControl1.KeyAuthApp.response.message + " .");
				Environment.Exit(0);
			}
			this.label4.Hide();
			this.label7.Hide();
			this.label8.Hide();
			this.lUserControl31.Hide();
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000030D9 File Offset: 0x000014D9
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000030D9 File Offset: 0x000014D9
		private void metroTextBox3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0001FFE4 File Offset: 0x0001E3E4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0002001C File Offset: 0x0001E41C
		private void InitializeComponent()
		{
			this.label2 = new Label();
			this.label6 = new Label();
			this.button1 = new Button();
			this.metroTextBox1 = new MetroTextBox();
			this.label3 = new Label();
			this.metroTextBox2 = new MetroTextBox();
			this.label5 = new Label();
			this.metroTextBox3 = new MetroTextBox();
			this.label1 = new Label();
			this.label4 = new Label();
			this.label7 = new Label();
			this.label8 = new Label();
			this.label9 = new Label();
			this.lUserControl31 = new LUserControl3();
			this.Icon2_Top_Panel = new PictureBox();
			this.label10 = new Label();
			((ISupportInitialize)this.Icon2_Top_Panel).BeginInit();
			base.SuspendLayout();
			this.label2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label2.ForeColor = Color.FromArgb(153, 153, 153);
			this.label2.Location = new Point(9, 114);
			this.label2.Name = "label2";
			this.label2.Size = new Size(79, 29);
			this.label2.TabIndex = 92;
			this.label2.Text = "Username";
			this.label2.TextAlign = ContentAlignment.MiddleLeft;
			this.label6.AutoSize = true;
			this.label6.Cursor = Cursors.Hand;
			this.label6.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
			this.label6.ForeColor = Color.FromArgb(0, 174, 219);
			this.label6.Location = new Point(7, 306);
			this.label6.Name = "label6";
			this.label6.Size = new Size(142, 15);
			this.label6.TabIndex = 97;
			this.label6.Text = "Already have an account?";
			this.label6.Click += this.label6_Click;
			this.button1.BackColor = Color.FromArgb(0, 174, 219);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			this.button1.Location = new Point(10, 274);
			this.button1.Name = "button1";
			this.button1.Size = new Size(166, 26);
			this.button1.TabIndex = 96;
			this.button1.Text = "Continue";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += this.button1_Click;
			this.metroTextBox1.BackColor = Color.FromArgb(39, 41, 47);
			this.metroTextBox1.CustomButton.Image = null;
			this.metroTextBox1.CustomButton.Location = new Point(142, 2);
			this.metroTextBox1.CustomButton.Name = "";
			this.metroTextBox1.CustomButton.Size = new Size(21, 21);
			this.metroTextBox1.CustomButton.Style = 4;
			this.metroTextBox1.CustomButton.TabIndex = 1;
			this.metroTextBox1.CustomButton.Theme = 1;
			this.metroTextBox1.CustomButton.UseSelectable = true;
			this.metroTextBox1.CustomButton.Visible = false;
			this.metroTextBox1.FontSize = 1;
			this.metroTextBox1.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroTextBox1.Lines = new string[0];
			this.metroTextBox1.Location = new Point(10, 207);
			this.metroTextBox1.MaxLength = 32767;
			this.metroTextBox1.Name = "metroTextBox1";
			this.metroTextBox1.PasswordChar = '\0';
			this.metroTextBox1.RightToLeft = RightToLeft.No;
			this.metroTextBox1.ScrollBars = ScrollBars.None;
			this.metroTextBox1.SelectedText = "";
			this.metroTextBox1.SelectionLength = 0;
			this.metroTextBox1.SelectionStart = 0;
			this.metroTextBox1.ShortcutsEnabled = true;
			this.metroTextBox1.Size = new Size(166, 26);
			this.metroTextBox1.Style = 3;
			this.metroTextBox1.TabIndex = 95;
			this.metroTextBox1.Theme = 2;
			this.metroTextBox1.UseCustomBackColor = true;
			this.metroTextBox1.UseCustomForeColor = true;
			this.metroTextBox1.UseSelectable = true;
			this.metroTextBox1.UseStyleColors = true;
			this.metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
			this.metroTextBox1.WaterMarkFont = null;
			this.label3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label3.ForeColor = Color.FromArgb(153, 153, 153);
			this.label3.Location = new Point(9, 175);
			this.label3.Name = "label3";
			this.label3.Size = new Size(67, 29);
			this.label3.TabIndex = 94;
			this.label3.Text = "Password";
			this.label3.TextAlign = ContentAlignment.MiddleLeft;
			this.metroTextBox2.BackColor = Color.FromArgb(39, 41, 47);
			this.metroTextBox2.CustomButton.Image = null;
			this.metroTextBox2.CustomButton.Location = new Point(142, 2);
			this.metroTextBox2.CustomButton.Name = "";
			this.metroTextBox2.CustomButton.Size = new Size(21, 21);
			this.metroTextBox2.CustomButton.Style = 4;
			this.metroTextBox2.CustomButton.TabIndex = 1;
			this.metroTextBox2.CustomButton.Theme = 1;
			this.metroTextBox2.CustomButton.UseSelectable = true;
			this.metroTextBox2.CustomButton.Visible = false;
			this.metroTextBox2.FontSize = 1;
			this.metroTextBox2.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroTextBox2.Lines = new string[0];
			this.metroTextBox2.Location = new Point(10, 146);
			this.metroTextBox2.MaxLength = 32767;
			this.metroTextBox2.Name = "metroTextBox2";
			this.metroTextBox2.PasswordChar = '\0';
			this.metroTextBox2.RightToLeft = RightToLeft.No;
			this.metroTextBox2.ScrollBars = ScrollBars.None;
			this.metroTextBox2.SelectedText = "";
			this.metroTextBox2.SelectionLength = 0;
			this.metroTextBox2.SelectionStart = 0;
			this.metroTextBox2.ShortcutsEnabled = true;
			this.metroTextBox2.Size = new Size(166, 26);
			this.metroTextBox2.Style = 3;
			this.metroTextBox2.TabIndex = 94;
			this.metroTextBox2.Theme = 2;
			this.metroTextBox2.UseCustomBackColor = true;
			this.metroTextBox2.UseCustomForeColor = true;
			this.metroTextBox2.UseSelectable = true;
			this.metroTextBox2.UseStyleColors = true;
			this.metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
			this.metroTextBox2.WaterMarkFont = null;
			this.label5.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label5.ForeColor = Color.FromArgb(153, 153, 153);
			this.label5.Location = new Point(10, 53);
			this.label5.Name = "label5";
			this.label5.Size = new Size(100, 29);
			this.label5.TabIndex = 100;
			this.label5.Text = "Activation Key";
			this.label5.TextAlign = ContentAlignment.MiddleLeft;
			this.metroTextBox3.BackColor = Color.FromArgb(39, 41, 47);
			this.metroTextBox3.CustomButton.Image = null;
			this.metroTextBox3.CustomButton.Location = new Point(142, 2);
			this.metroTextBox3.CustomButton.Name = "";
			this.metroTextBox3.CustomButton.Size = new Size(21, 21);
			this.metroTextBox3.CustomButton.Style = 4;
			this.metroTextBox3.CustomButton.TabIndex = 1;
			this.metroTextBox3.CustomButton.Theme = 1;
			this.metroTextBox3.CustomButton.UseSelectable = true;
			this.metroTextBox3.CustomButton.Visible = false;
			this.metroTextBox3.FontSize = 1;
			this.metroTextBox3.ForeColor = Color.FromArgb(102, 102, 102);
			this.metroTextBox3.Lines = new string[0];
			this.metroTextBox3.Location = new Point(10, 85);
			this.metroTextBox3.MaxLength = 32767;
			this.metroTextBox3.Name = "metroTextBox3";
			this.metroTextBox3.PasswordChar = '\0';
			this.metroTextBox3.RightToLeft = RightToLeft.No;
			this.metroTextBox3.ScrollBars = ScrollBars.None;
			this.metroTextBox3.SelectedText = "";
			this.metroTextBox3.SelectionLength = 0;
			this.metroTextBox3.SelectionStart = 0;
			this.metroTextBox3.ShortcutsEnabled = true;
			this.metroTextBox3.Size = new Size(166, 26);
			this.metroTextBox3.Style = 3;
			this.metroTextBox3.TabIndex = 93;
			this.metroTextBox3.Theme = 2;
			this.metroTextBox3.UseCustomBackColor = true;
			this.metroTextBox3.UseCustomForeColor = true;
			this.metroTextBox3.UseSelectable = true;
			this.metroTextBox3.UseStyleColors = true;
			this.metroTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
			this.metroTextBox3.WaterMarkFont = null;
			this.metroTextBox3.Click += this.metroTextBox3_Click;
			this.label1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label1.ForeColor = Color.FromArgb(0, 174, 219);
			this.label1.Location = new Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(186, 72);
			this.label1.TabIndex = 10;
			this.label1.Text = "Create an account";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.label1.Click += this.label1_Click;
			this.label4.Cursor = Cursors.Arrow;
			this.label4.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
			this.label4.ForeColor = Color.FromArgb(0, 174, 219);
			this.label4.Location = new Point(100, 59);
			this.label4.Name = "label4";
			this.label4.Size = new Size(102, 18);
			this.label4.TabIndex = 112;
			this.label4.Text = "Invalid Key";
			this.label4.TextAlign = ContentAlignment.MiddleLeft;
			this.label7.Cursor = Cursors.Arrow;
			this.label7.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
			this.label7.ForeColor = Color.FromArgb(0, 174, 219);
			this.label7.Location = new Point(73, 120);
			this.label7.Name = "label7";
			this.label7.Size = new Size(102, 18);
			this.label7.TabIndex = 113;
			this.label7.Text = "Invalid Nickname";
			this.label7.TextAlign = ContentAlignment.MiddleLeft;
			this.label8.Cursor = Cursors.Arrow;
			this.label8.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
			this.label8.ForeColor = Color.FromArgb(0, 174, 219);
			this.label8.Location = new Point(70, 181);
			this.label8.Name = "label8";
			this.label8.Size = new Size(102, 18);
			this.label8.TabIndex = 114;
			this.label8.Text = "Invalid Password";
			this.label8.TextAlign = ContentAlignment.MiddleLeft;
			this.label9.AutoSize = true;
			this.label9.Cursor = Cursors.Hand;
			this.label9.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
			this.label9.ForeColor = Color.FromArgb(80, 250, 241);
			this.label9.Location = new Point(7, 488);
			this.label9.Name = "label9";
			this.label9.Size = new Size(50, 15);
			this.label9.TabIndex = 115;
			this.label9.Text = "Support";
			this.label9.Click += this.label9_Click;
			this.lUserControl31.BackColor = Color.FromArgb(28, 29, 34);
			this.lUserControl31.Location = new Point(0, 0);
			this.lUserControl31.Name = "lUserControl31";
			this.lUserControl31.Size = new Size(186, 510);
			this.lUserControl31.TabIndex = 116;
			this.Icon2_Top_Panel.Image = Resources.SLOGOSS2;
			this.Icon2_Top_Panel.Location = new Point(39, 2);
			this.Icon2_Top_Panel.Name = "Icon2_Top_Panel";
			this.Icon2_Top_Panel.Size = new Size(25, 25);
			this.Icon2_Top_Panel.SizeMode = PictureBoxSizeMode.Zoom;
			this.Icon2_Top_Panel.TabIndex = 121;
			this.Icon2_Top_Panel.TabStop = false;
			this.label10.AutoSize = true;
			this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label10.ForeColor = Color.FromArgb(0, 174, 219);
			this.label10.Location = new Point(62, 7);
			this.label10.Name = "label10";
			this.label10.Size = new Size(72, 16);
			this.label10.TabIndex = 122;
			this.label10.Text = "Blast Aim";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(28, 29, 34);
			base.Controls.Add(this.Icon2_Top_Panel);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.lUserControl31);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.metroTextBox3);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.metroTextBox1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.metroTextBox2);
			base.Controls.Add(this.label1);
			base.Name = "LUserControl1";
			base.Size = new Size(186, 427);
			base.Load += this.LUserControl1_Load;
			((ISupportInitialize)this.Icon2_Top_Panel).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400023D RID: 573
		public static api KeyAuthApp = new api("BlastProduction", "p0ej3FMYJt", "8940a68775345ea0a69c88f2d55c7d7c325b3005238b6948290a7720d38b92c9", "2.1");

		// Token: 0x0400023E RID: 574
		private IContainer components = null;

		// Token: 0x0400023F RID: 575
		private Label label2;

		// Token: 0x04000240 RID: 576
		private Label label6;

		// Token: 0x04000241 RID: 577
		private Button button1;

		// Token: 0x04000242 RID: 578
		private MetroTextBox metroTextBox1;

		// Token: 0x04000243 RID: 579
		private Label label3;

		// Token: 0x04000244 RID: 580
		private MetroTextBox metroTextBox2;

		// Token: 0x04000245 RID: 581
		private Label label5;

		// Token: 0x04000246 RID: 582
		private MetroTextBox metroTextBox3;

		// Token: 0x04000247 RID: 583
		private Label label1;

		// Token: 0x04000248 RID: 584
		private Label label4;

		// Token: 0x04000249 RID: 585
		private Label label7;

		// Token: 0x0400024A RID: 586
		private Label label8;

		// Token: 0x0400024B RID: 587
		private Label label9;

		// Token: 0x0400024C RID: 588
		private LUserControl3 lUserControl31;

		// Token: 0x0400024D RID: 589
		private PictureBox Icon2_Top_Panel;

		// Token: 0x0400024E RID: 590
		private Label label10;
	}
}
