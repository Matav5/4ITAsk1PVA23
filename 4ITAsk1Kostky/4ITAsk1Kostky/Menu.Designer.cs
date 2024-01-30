namespace _4ITAsk1Kostky
{
    partial class Menu
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(200, 100);
            button1.TabIndex = 0;
            button1.Text = "Nová Hra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 131);
            button2.Name = "button2";
            button2.Size = new Size(200, 100);
            button2.TabIndex = 1;
            button2.Text = "Pomoc";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 255);
            button3.Name = "button3";
            button3.Size = new Size(200, 100);
            button3.TabIndex = 2;
            button3.Text = "Konec";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(278, 46);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(256, 309);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.Lime;
            button4.Location = new Point(476, 12);
            button4.Name = "button4";
            button4.Size = new Size(27, 29);
            button4.TabIndex = 4;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Location = new Point(509, 12);
            button5.Name = "button5";
            button5.Size = new Size(25, 29);
            button5.TabIndex = 5;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 369);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button4;
        private Button button5;
    }
}