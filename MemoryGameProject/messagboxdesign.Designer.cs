namespace MemoryGameProject
{
    partial class MessagBoxDesign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoButton = new System.Windows.Forms.Button();
            this.GifBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GifBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.NoButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 58);
            this.panel1.TabIndex = 0;
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NoButton.FlatAppearance.BorderSize = 0;
            this.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoButton.ForeColor = System.Drawing.Color.White;
            this.NoButton.Location = new System.Drawing.Point(386, 5);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(205, 46);
            this.NoButton.TabIndex = 1;
            this.NoButton.Text = "Exit";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // GifBox
            // 
            this.GifBox.Image = global::MemoryGameProject.Properties.Resources.PE1c;
            this.GifBox.Location = new System.Drawing.Point(0, 45);
            this.GifBox.Name = "GifBox";
            this.GifBox.Size = new System.Drawing.Size(603, 326);
            this.GifBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GifBox.TabIndex = 1;
            this.GifBox.TabStop = false;
            this.GifBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "You Won the game!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MessagBoxDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(603, 427);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GifBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessagBoxDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "You won the game!";
            this.Load += new System.EventHandler(this.MessagBoxDesign_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GifBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.PictureBox GifBox;
        private System.Windows.Forms.Label label1;
    }
}