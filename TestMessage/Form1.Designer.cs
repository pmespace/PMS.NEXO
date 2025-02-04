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
			button3 = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(31, 57);
			textBox1.Margin = new Padding(4, 5, 4, 5);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(1074, 31);
			textBox1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Location = new Point(460, 168);
			button1.Margin = new Padding(4, 5, 4, 5);
			button1.Name = "button1";
			button1.Size = new Size(107, 38);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(31, 267);
			textBox2.Margin = new Padding(4, 5, 4, 5);
			textBox2.Name = "textBox2";
			textBox2.ReadOnly = true;
			textBox2.Size = new Size(1074, 31);
			textBox2.TabIndex = 2;
			// 
			// button2
			// 
			button2.Location = new Point(460, 360);
			button2.Margin = new Padding(4, 5, 4, 5);
			button2.Name = "button2";
			button2.Size = new Size(107, 38);
			button2.TabIndex = 3;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(17, 448);
			textBox3.Margin = new Padding(4, 5, 4, 5);
			textBox3.Name = "textBox3";
			textBox3.ReadOnly = true;
			textBox3.Size = new Size(1074, 31);
			textBox3.TabIndex = 4;
			// 
			// button3
			// 
			button3.Location = new Point(66, 593);
			button3.Name = "button3";
			button3.Size = new Size(112, 34);
			button3.TabIndex = 5;
			button3.Text = "button3";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1143, 750);
			Controls.Add(button3);
			Controls.Add(textBox3);
			Controls.Add(button2);
			Controls.Add(textBox2);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Margin = new Padding(4, 5, 4, 5);
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
		private Button button3;
	}
}