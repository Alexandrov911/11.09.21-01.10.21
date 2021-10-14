
namespace _01._10._21
{
    partial class Form4
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
            this.какуюКартинкуОткрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картинка1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картинка2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картинка3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.какуюКартинкуОткрытьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // какуюКартинкуОткрытьToolStripMenuItem
            // 
            this.какуюКартинкуОткрытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.картинка1ToolStripMenuItem,
            this.картинка2ToolStripMenuItem,
            this.картинка3ToolStripMenuItem});
            this.какуюКартинкуОткрытьToolStripMenuItem.Name = "какуюКартинкуОткрытьToolStripMenuItem";
            this.какуюКартинкуОткрытьToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.какуюКартинкуОткрытьToolStripMenuItem.Text = "Какую картинку открыть?";
            // 
            // картинка1ToolStripMenuItem
            // 
            this.картинка1ToolStripMenuItem.Name = "картинка1ToolStripMenuItem";
            this.картинка1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.картинка1ToolStripMenuItem.Text = "Картинка 1";
            this.картинка1ToolStripMenuItem.Click += new System.EventHandler(this.картинка1ToolStripMenuItem_Click);
            // 
            // картинка2ToolStripMenuItem
            // 
            this.картинка2ToolStripMenuItem.Name = "картинка2ToolStripMenuItem";
            this.картинка2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.картинка2ToolStripMenuItem.Text = "Картинка 2";
            this.картинка2ToolStripMenuItem.Click += new System.EventHandler(this.картинка2ToolStripMenuItem_Click);
            // 
            // картинка3ToolStripMenuItem
            // 
            this.картинка3ToolStripMenuItem.Name = "картинка3ToolStripMenuItem";
            this.картинка3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.картинка3ToolStripMenuItem.Text = "Картинка 3";
            this.картинка3ToolStripMenuItem.Click += new System.EventHandler(this.картинка3ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Форма с календарем";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem какуюКартинкуОткрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картинка1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картинка2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картинка3ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button button1;
    }
}