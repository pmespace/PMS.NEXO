namespace TestMessage
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			button1 = new Button();
			textBox2 = new TextBox();
			button2 = new Button();
			textBox3 = new TextBox();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(22, 34);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(753, 23);
			textBox1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(322, 101);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(22, 160);
			textBox2.Name = "textBox2";
			textBox2.ReadOnly = true;
			textBox2.Size = new Size(753, 23);
			textBox2.TabIndex = 2;
			// 
			// button2
			// 
			button2.Location = new Point(322, 216);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 3;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(12, 269);
			textBox3.Name = "textBox3";
			textBox3.ReadOnly = true;
			textBox3.Size = new Size(753, 23);
			textBox3.TabIndex = 4;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(textBox3);
			Controls.Add(button2);
			Controls.Add(textBox2);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Button button1;
		private TextBox textBox2;
		private Button button2;
		private TextBox textBox3;
	}
}