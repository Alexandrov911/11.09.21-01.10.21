
namespace _01._10._21
{
    partial class Form9
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.r1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.r2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.r3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.рисунокToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // рисунокToolStripMenuItem
            // 
            this.рисунокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.r1ToolStripMenuItem,
            this.r2ToolStripMenuItem,
            this.r3ToolStripMenuItem});
            this.рисунокToolStripMenuItem.Name = "рисунокToolStripMenuItem";
            this.рисунокToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.рисунокToolStripMenuItem.Text = "рисунок";
            // 
            // r1ToolStripMenuItem
            // 
            this.r1ToolStripMenuItem.Name = "r1ToolStripMenuItem";
            this.r1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.r1ToolStripMenuItem.Text = "r1";
            this.r1ToolStripMenuItem.Click += new System.EventHandler(this.r1ToolStripMenuItem_Click);
            // 
            // r2ToolStripMenuItem
            // 
            this.r2ToolStripMenuItem.Name = "r2ToolStripMenuItem";
            this.r2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.r2ToolStripMenuItem.Text = "r2";
            this.r2ToolStripMenuItem.Click += new System.EventHandler(this.r2ToolStripMenuItem_Click);
            // 
            // r3ToolStripMenuItem
            // 
            this.r3ToolStripMenuItem.Name = "r3ToolStripMenuItem";
            this.r3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.r3ToolStripMenuItem.Text = "r3";
            this.r3ToolStripMenuItem.Click += new System.EventHandler(this.r3ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(216, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form9";
            this.Text = "Form9";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem r1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem r2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem r3ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}