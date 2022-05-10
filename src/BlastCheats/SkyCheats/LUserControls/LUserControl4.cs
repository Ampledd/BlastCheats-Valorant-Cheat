using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
using SkyCheats.Properties;

namespace SkyCheats.LUserControls
{
	// Token: 0x02000030 RID: 48
	public class LUserControl4 : UserControl
	{
		// Token: 0x0600031A RID: 794 RVA: 0x00022BF7 File Offset: 0x00020FF7
		public LUserControl4()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00022C0F File Offset: 0x0002100F
		private void label7_Click(object sender, EventArgs e)
		{
			this.lUserControl11.Show();
			this.lUserControl11.BringToFront();
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000030D9 File Offset: 0x000014D9
		private void Button_Panel_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00022C2C File Offset: 0x0002102C
		private void LUserControl4_Load(object sender, EventArgs e)
		{
			this.label9.Hide();
			this.label8.Hide();
			LUserControl4.KeyAuthApp.init();
			bool flag = !LUserControl4.KeyAuthApp.response.success;
			if (flag)
			{
				MessageBox.Show(LUserControl4.KeyAuthApp.response.message + " ,");
				Environment.Exit(0);
			}
			this.lUserControl11.Hide();
			this.lUserControl21.Hide();
			this.lUserControl31.Hide();
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00022CBF File Offset: 0x000210BF
		private void label4_Click(object sender, EventArgs e)
		{
			this.lUserControl21.Show();
			this.lUserControl21.BringToFront();
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00022CDA File Offset: 0x000210DA
		private void label10_Click(object sender, EventArgs e)
		{
			this.lUserControl31.Show();
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000030D9 File Offset: 0x000014D9
		private void lUserControl31_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00022CEC File Offset: 0x000210EC
		private void button1_Click(object sender, EventArgs e)
		{
			LUserControl4.KeyAuthApp.login(this.metroTextBox2.Text, this.metroTextBox1.Text);
			bool success = LUserControl4.KeyAuthApp.response.success;
			if (success)
			{
				config.usernamee = this.metroTextBox2.Text;
				config.passwordd = this.metroTextBox1.Text;
				Main_Form main_Form = new Main_Form();
				((Form)base.TopLevelControl).Hide();
				main_Form.Show();
			}
			else
			{
				this.label9.Show();
			}
			this.label8.Show();
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000030D9 File Offset: 0x000014D9
		private void lUserControl11_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00022D8C File Offset: 0x0002118C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00022DC4 File Offset: 0x000211C4
		private void InitializeComponent()
		{
			this.Button_Panel = new Panel();
			this.Icon2_Top_Panel = new PictureBox();
			this.label10 = new Label();
			this.label9 = new Label();
			this.label8 = new Label();
			this.label3 = new Label();
			this.label5 = new Label();
			this.label2 = new Label();
			this.label7 = new Label();
			this.label6 = new Label();
			this.button1 = new Button();
			this.label4 = new Label();
			this.metroTextBox1 = new MetroTextBox();
			this.metroTextBox2 = new MetroTextBox();
			this.label1 = new Label();
			this.lUserControl31 = new LUserControl3();
			this.lUserControl21 = new LUserControl2();
			this.lUserControl11 = new LUserControl1();
			this.Button_Panel.SuspendLayout();
			((ISupportInitialize)this.Icon2_Top_Panel).BeginInit();
			base.SuspendLayout();
			this.Button_Panel.BackColor = Color.FromArgb(28, 29, 34);
			this.Button_Panel.Controls.Add(this.lUserControl31);
			this.Button_Panel.Controls.Add(this.lUserControl21);
			this.Button_Panel.Controls.Add(this.lUserControl11);
			this.Button_Panel.Controls.Add(this.Icon2_Top_Panel);
			this.Button_Panel.Controls.Add(this.label10);
			this.Button_Panel.Controls.Add(this.label9);
			this.Button_Panel.Controls.Add(this.label8);
			this.Button_Panel.Controls.Add(this.label3);
			this.Button_Panel.Controls.Add(this.label5);
			this.Button_Panel.Controls.Add(this.label2);
			this.Button_Panel.Controls.Add(this.label7);
			this.Button_Panel.Controls.Add(this.label6);
			this.Button_Panel.Controls.Add(this.button1);
			this.Button_Panel.Controls.Add(this.label4);
			this.Button_Panel.Controls.Add(this.metroTextBox1);
			this.Button_Panel.Controls.Add(this.metroTextBox2);
			this.Button_Panel.Controls.Add(this.label1);
			this.Button_Panel.Location = new Point(0, 0);
			this.Button_Panel.Name = "Button_Panel";
			this.Button_Panel.Size = new Size(186, 515);
			this.Button_Panel.TabIndex = 2;
			this.Button_Panel.Paint += this.Button_Panel_Paint;
			this.Icon2_Top_Panel.Image = Resources.SLOGOSS2;
			this.Icon2_Top_Panel.Location = new Point(39, 2);
			this.Icon2_Top_Panel.Name = "Icon2_Top_Panel";
			this.Icon2_Top_Panel.Size = new Size(25, 25);
			this.Icon2_Top_Panel.SizeMode = PictureBoxSizeMode.Zoom;
			this.Icon2_Top_Panel.TabIndex = 103;
			this.Icon2_Top_Panel.TabStop = false;
			this.label10.AutoSize = true;
			this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label10.ForeColor = Color.FromArgb(0, 174, 219);
			this.label10.Location = new Point(62, 7);
			this.label10.Name = "label10";
			this.label10.Size = new Size(72, 16);
			this.label10.TabIndex = 118;
			this.label10.Text = "Blast Aim";
			this.label9.Cursor = Cursors.Arrow;
			this.label9.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
			this.label9.ForeColor = Color.FromArgb(0, 174, 219);
			this.label9.Location = new Point(78, 120);
			this.label9.Name = "label9";
			this.label9.Size = new Size(44, 18);
			this.label9.TabIndex = 117;
			this.label9.Text = "Invalid";
			this.label9.TextAlign = ContentAlignment.MiddleLeft;
			this.label8.Cursor = Cursors.Arrow;
			this.label8.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
			this.label8.ForeColor = Color.FromArgb(0, 174, 219);
			this.label8.Location = new Point(72, 181);
			this.label8.Name = "label8";
			this.label8.Size = new Size(102, 18);
			this.label8.TabIndex = 116;
			this.label8.Text = "Invalid Password";
			this.label8.TextAlign = ContentAlignment.MiddleLeft;
			this.label3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label3.ForeColor = Color.FromArgb(153, 153, 153);
			this.label3.Location = new Point(10, 175);
			this.label3.Name = "label3";
			this.label3.Size = new Size(67, 29);
			this.label3.TabIndex = 115;
			this.label3.Text = "Password";
			this.label3.TextAlign = ContentAlignment.MiddleLeft;
			this.label5.Font = new Font("Segoe UI", 10f);
			this.label5.ForeColor = Color.FromArgb(153, 153, 153);
			this.label5.Location = new Point(10, 48);
			this.label5.Name = "label5";
			this.label5.Size = new Size(165, 45);
			this.label5.TabIndex = 83;
			this.label5.Text = "  We're so excited to see you again!";
			this.label5.TextAlign = ContentAlignment.MiddleCenter;
			this.label2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label2.ForeColor = Color.FromArgb(153, 153, 153);
			this.label2.Location = new Point(10, 114);
			this.label2.Name = "label2";
			this.label2.Size = new Size(151, 29);
			this.label2.TabIndex = 84;
			this.label2.Text = "Username";
			this.label2.TextAlign = ContentAlignment.MiddleLeft;
			this.label7.AutoSize = true;
			this.label7.Cursor = Cursors.Hand;
			this.label7.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
			this.label7.ForeColor = Color.FromArgb(0, 174, 219);
			this.label7.Location = new Point(117, 306);
			this.label7.Name = "label7";
			this.label7.Size = new Size(49, 15);
			this.label7.TabIndex = 91;
			this.label7.Text = "Register";
			this.label7.Click += this.label7_Click;
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
			this.label6.ForeColor = Color.FromArgb(153, 153, 153);
			this.label6.Location = new Point(7, 306);
			this.label6.Name = "label6";
			this.label6.Size = new Size(113, 15);
			this.label6.TabIndex = 90;
			this.label6.Text = "Need your account?";
			this.button1.BackColor = Color.FromArgb(0, 174, 219);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			this.button1.Location = new Point(10, 274);
			this.button1.Name = "button1";
			this.button1.Size = new Size(166, 26);
			this.button1.TabIndex = 89;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += this.button1_Click;
			this.label4.AutoSize = true;
			this.label4.Cursor = Cursors.Hand;
			this.label4.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
			this.label4.ForeColor = Color.FromArgb(0, 174, 219);
			this.label4.Location = new Point(7, 237);
			this.label4.Name = "label4";
			this.label4.Size = new Size(127, 15);
			this.label4.TabIndex = 88;
			this.label4.Text = "Forgot your password?";
			this.label4.Click += this.label4_Click;
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
			this.metroTextBox1.TabIndex = 87;
			this.metroTextBox1.Theme = 2;
			this.metroTextBox1.UseCustomBackColor = true;
			this.metroTextBox1.UseCustomForeColor = true;
			this.metroTextBox1.UseSelectable = true;
			this.metroTextBox1.UseStyleColors = true;
			this.metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
			this.metroTextBox1.WaterMarkFont = null;
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
			this.metroTextBox2.TabIndex = 85;
			this.metroTextBox2.Theme = 2;
			this.metroTextBox2.UseCustomBackColor = true;
			this.metroTextBox2.UseCustomForeColor = true;
			this.metroTextBox2.UseSelectable = true;
			this.metroTextBox2.UseStyleColors = true;
			this.metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
			this.metroTextBox2.WaterMarkFont = null;
			this.label1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label1.ForeColor = Color.FromArgb(0, 174, 219);
			this.label1.Location = new Point(0, -5);
			this.label1.Name = "label1";
			this.label1.Size = new Size(186, 72);
			this.label1.TabIndex = 9;
			this.label1.Text = "Welcome Blast Aim!";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.lUserControl31.BackColor = Color.FromArgb(28, 29, 34);
			this.lUserControl31.Location = new Point(0, -5);
			this.lUserControl31.Name = "lUserControl31";
			this.lUserControl31.Size = new Size(186, 510);
			this.lUserControl31.TabIndex = 121;
			this.lUserControl31.Load += this.lUserControl31_Load;
			this.lUserControl21.BackColor = Color.FromArgb(28, 29, 34);
			this.lUserControl21.Location = new Point(0, 2);
			this.lUserControl21.Name = "lUserControl21";
			this.lUserControl21.Size = new Size(186, 510);
			this.lUserControl21.TabIndex = 120;
			this.lUserControl11.BackColor = Color.FromArgb(28, 29, 34);
			this.lUserControl11.Location = new Point(0, 0);
			this.lUserControl11.Name = "lUserControl11";
			this.lUserControl11.Size = new Size(186, 510);
			this.lUserControl11.TabIndex = 119;
			this.lUserControl11.Load += this.lUserControl11_Load;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(28, 29, 34);
			base.Controls.Add(this.Button_Panel);
			base.Name = "LUserControl4";
			base.Size = new Size(186, 427);
			base.Load += this.LUserControl4_Load;
			this.Button_Panel.ResumeLayout(false);
			this.Button_Panel.PerformLayout();
			((ISupportInitialize)this.Icon2_Top_Panel).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000272 RID: 626
		public static api KeyAuthApp = new api("BlastProduction", "p0ej3FMYJt", "8940a68775345ea0a69c88f2d55c7d7c325b3005238b6948290a7720d38b92c9", "2.1");

		// Token: 0x04000273 RID: 627
		private IContainer components = null;

		// Token: 0x04000274 RID: 628
		private Panel Button_Panel;

		// Token: 0x04000275 RID: 629
		private Label label9;

		// Token: 0x04000276 RID: 630
		private Label label3;

		// Token: 0x04000277 RID: 631
		private Label label5;

		// Token: 0x04000278 RID: 632
		private PictureBox Icon2_Top_Panel;

		// Token: 0x04000279 RID: 633
		private Label label2;

		// Token: 0x0400027A RID: 634
		private Label label7;

		// Token: 0x0400027B RID: 635
		private Label label6;

		// Token: 0x0400027C RID: 636
		private Button button1;

		// Token: 0x0400027D RID: 637
		private Label label4;

		// Token: 0x0400027E RID: 638
		private MetroTextBox metroTextBox1;

		// Token: 0x0400027F RID: 639
		private MetroTextBox metroTextBox2;

		// Token: 0x04000280 RID: 640
		private Label label1;

		// Token: 0x04000281 RID: 641
		private Label label8;

		// Token: 0x04000282 RID: 642
		private LUserControl3 lUserControl31;

		// Token: 0x04000283 RID: 643
		private LUserControl2 lUserControl21;

		// Token: 0x04000284 RID: 644
		private LUserControl1 lUserControl11;

		// Token: 0x04000285 RID: 645
		private Label label10;
	}
}
