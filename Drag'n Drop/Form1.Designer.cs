namespace Drag_n_Drop
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
            menuStrip1 = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            buttonToolStripMenuItem = new ToolStripMenuItem();
            textboxToolStripMenuItem = new ToolStripMenuItem();
            pictureboxToolStripMenuItem = new ToolStripMenuItem();
            checkboxToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(940, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buttonToolStripMenuItem, textboxToolStripMenuItem, pictureboxToolStripMenuItem, checkboxToolStripMenuItem });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(65, 29);
            addToolStripMenuItem.Text = "Stuff";
            // 
            // buttonToolStripMenuItem
            // 
            buttonToolStripMenuItem.Name = "buttonToolStripMenuItem";
            buttonToolStripMenuItem.Size = new Size(197, 34);
            buttonToolStripMenuItem.Text = "Button";
            buttonToolStripMenuItem.Click += buttonToolStripMenuItem_Click;
            // 
            // textboxToolStripMenuItem
            // 
            textboxToolStripMenuItem.Name = "textboxToolStripMenuItem";
            textboxToolStripMenuItem.Size = new Size(197, 34);
            textboxToolStripMenuItem.Text = "Textbox";
            textboxToolStripMenuItem.Click += textboxToolStripMenuItem_Click;
            // 
            // pictureboxToolStripMenuItem
            // 
            pictureboxToolStripMenuItem.Name = "pictureboxToolStripMenuItem";
            pictureboxToolStripMenuItem.Size = new Size(197, 34);
            pictureboxToolStripMenuItem.Text = "Picturebox";
            pictureboxToolStripMenuItem.Click += pictureboxToolStripMenuItem_Click;
            // 
            // checkboxToolStripMenuItem
            // 
            checkboxToolStripMenuItem.Name = "checkboxToolStripMenuItem";
            checkboxToolStripMenuItem.Size = new Size(197, 34);
            checkboxToolStripMenuItem.Text = "Checkbox";
            checkboxToolStripMenuItem.Click += checkboxToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.trashcan;
            pictureBox1.Location = new Point(722, 485);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 672);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem buttonToolStripMenuItem;
        private ToolStripMenuItem textboxToolStripMenuItem;
        private ToolStripMenuItem pictureboxToolStripMenuItem;
        private ToolStripMenuItem checkboxToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}
