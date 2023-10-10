namespace _4ITAsk1HledaniMin
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
            this.herniPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // herniPanel
            // 
            this.herniPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.herniPanel.Location = new System.Drawing.Point(77, 55);
            this.herniPanel.Name = "herniPanel";
            this.herniPanel.Size = new System.Drawing.Size(360, 360);
            this.herniPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.herniPanel);
            this.Name = "Form1";
            this.Text = "Hledání Min";
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel herniPanel;
    }
}