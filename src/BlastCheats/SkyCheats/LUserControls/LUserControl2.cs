using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SkyCheats.Properties;

namespace SkyCheats.LUserControls
{
	// Token: 0x0200002E RID: 46
	public class LUserControl2 : UserControl
	{
		// Token: 0x06000310 RID: 784 RVA: 0x00021229 File Offset: 0x0001F629
		public LUserControl2()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000D008 File Offset: 0x0000B408
		private void button1_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00021241 File Offset: 0x0001F641
		private void LUserControl2_Load(object sender, EventArgs e)
		{
			this.lUserControl31.Hide();
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00021250 File Offset: 0x0001F650
		private void label9_Click(object sender, EventArgs e)
		{
			this.lUserControl31.Show();
			this.lUserControl31.BringToFront();
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0002126C File Offset: 0x0001F66C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000212A4 File Offset: 0x0001F6A4
		private void InitializeComponent()
		{
			this.label1 = new Label();
			this.label5 = new Label();
			this.label2 = new Label();
			this.label3 = new Label();
			this.button1 = new Button();
			this.label9 = new Label();
			this.label4 = new Label();
			this.lUserControl31 = new LUserControl3();
			this.Icon2_Top_Panel = new PictureBox();
			this.label10 = new Label();
			((ISupportInitialize)this.Icon2_Top_Panel).BeginInit();
			base.SuspendLayout();
			this.label1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label1.ForeColor = Color.FromArgb(0, 174, 219);
			this.label1.Location = new Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(186, 72);
			this.label1.TabIndex = 11;
			this.label1.Text = "Account recovery";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.label5.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label5.ForeColor = Color.FromArgb(0, 174, 219);
			this.label5.Location = new Point(10, 53);
			this.label5.Name = "label5";
			this.label5.Size = new Size(165, 60);
			this.label5.TabIndex = 108;
			this.label5.Text = "To help keep your account secure, Supports needs to confirm this account belongs to you.";
			this.label5.TextAlign = ContentAlignment.MiddleCenter;
			this.label2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.label2.ForeColor = Color.FromArgb(153, 153, 153);
			this.label2.Location = new Point(10, 119);
			this.label2.Name = "label2";
			this.label2.Size = new Size(165, 57);
			this.label2.TabIndex = 109;
			this.label2.Text = "* Use a device where you’ve signed in before";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.label3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.label3.ForeColor = Color.FromArgb(153, 153, 153);
			this.label3.Location = new Point(7, 176);
			this.label3.Name = "label3";
			this.label3.Size = new Size(165, 45);
			this.label3.TabIndex = 110;
			this.label3.Text = " * Key may have expired";
			this.label3.TextAlign = ContentAlignment.MiddleCenter;
			this.button1.BackColor = Color.FromArgb(0, 174, 219);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
			this.button1.Location = new Point(10, 274);
			this.button1.Name = "button1";
			this.button1.Size = new Size(166, 26);
			this.button1.TabIndex = 111;
			this.button1.Text = "Back";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += this.button1_Click;
			this.label9.AutoSize = true;
			this.label9.Cursor = Cursors.Hand;
			this.label9.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
			this.label9.ForeColor = Color.FromArgb(80, 250, 241);
			this.label9.Location = new Point(7, 488);
			this.label9.Name = "label9";
			this.label9.Size = new Size(50, 15);
			this.label9.TabIndex = 120;
			this.label9.Text = "Support";
			this.label9.Click += this.label9_Click;
			this.label4.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.label4.ForeColor = Color.FromArgb(153, 153, 153);
			this.label4.Location = new Point(7, 221);
			this.label4.Name = "label4";
			this.label4.Size = new Size(165, 45);
			this.label4.TabIndex = 121;
			this.label4.Text = " * Contact support team.";
			this.label4.TextAlign = ContentAlignment.MiddleCenter;
			this.lUserControl31.BackColor = Color.FromArgb(28, 29, 34);
			this.lUserControl31.Location = new Point(0, 0);
			this.lUserControl31.Name = "lUserControl31";
			this.lUserControl31.Size = new Size(186, 510);
			this.lUserControl31.TabIndex = 122;
			this.Icon2_Top_Panel.Image = Resources.SLOGOSS2;
			this.Icon2_Top_Panel.Location = new Point(39, 2);
			this.Icon2_Top_Panel.Name = "Icon2_Top_Panel";
			this.Icon2_Top_Panel.Size = new Size(25, 25);
			this.Icon2_Top_Panel.SizeMode = PictureBoxSizeMode.Zoom;
			this.Icon2_Top_Panel.TabIndex = 123;
			this.Icon2_Top_Panel.TabStop = false;
			this.label10.AutoSize = true;
			this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.label10.ForeColor = Color.FromArgb(0, 174, 219);
			this.label10.Location = new Point(62, 7);
			this.label10.Name = "label10";
			this.label10.Size = new Size(72, 16);
			this.label10.TabIndex = 124;
			this.label10.Text = "Blast Aim";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(28, 29, 34);
			base.Controls.Add(this.Icon2_Top_Panel);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.lUserControl31);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label1);
			base.Name = "LUserControl2";
			base.Size = new Size(186, 427);
			base.Load += this.LUserControl2_Load;
			((ISupportInitialize)this.Icon2_Top_Panel).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400024F RID: 591
		private IContainer components = null;

		// Token: 0x04000250 RID: 592
		private Label label1;

		// Token: 0x04000251 RID: 593
		private Label label5;

		// Token: 0x04000252 RID: 594
		private Label label2;

		// Token: 0x04000253 RID: 595
		private Label label3;

		// Token: 0x04000254 RID: 596
		private Button button1;

		// Token: 0x04000255 RID: 597
		private Label label9;

		// Token: 0x04000256 RID: 598
		private Label label4;

		// Token: 0x04000257 RID: 599
		private LUserControl3 lUserControl31;

		// Token: 0x04000258 RID: 600
		private PictureBox Icon2_Top_Panel;

		// Token: 0x04000259 RID: 601
		private Label label10;
	}
}
