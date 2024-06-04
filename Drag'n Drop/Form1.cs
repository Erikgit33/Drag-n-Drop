using Drag_n_Drop.Properties;
using System.Drawing.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Drag_n_Drop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Location = new Point(50, 50);
            button.Size = new Size(150, 50);
            button.Text = ("I am a button");
            Controls.Add(button);

            button.MouseUp += control_MouseUp;
            button.MouseMove += control_MouseDown;
            button.MouseMove += control_MouseMove;
        }

        private void textboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(50, 50);
            textBox.Size = new Size(150, 50);
            textBox.Text = ("I am a textbox");
            Controls.Add(textBox);

            textBox.MouseUp += control_MouseUp;
            textBox.MouseMove += control_MouseDown;
            textBox.MouseMove += control_MouseMove;
        }

        private void pictureboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(50, 50);
            pictureBox.Size = new Size(100, 100);
            pictureBox.Image = Resources.I_am_a_picturebox;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(pictureBox);

            pictureBox.MouseUp += control_MouseUp;
            pictureBox.MouseMove += control_MouseDown;
            pictureBox.MouseMove += control_MouseMove;
        }

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Location = new Point(50, 50);
            checkBox.Size = new Size(250, 50);
            checkBox.Text = ("I am a checkbox");
            Controls.Add(checkBox);


            checkBox.MouseUp += control_MouseUp;
            checkBox.MouseMove += control_MouseDown;
            checkBox.MouseMove += control_MouseMove;
        }

        private void control_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control c = (Control)sender;
                if (c.Bounds.IntersectsWith(pictureBox1.Bounds))
                {
                    c.Dispose();
                }
            }
        }

        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control c = (Control)sender;
                c.Location = PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));
            }
        }

        private void control_MouseMove(object sender , MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control c = (Control)sender;
                c.Location = PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));
                if (c.Bounds.IntersectsWith(pictureBox1.Bounds))
                {
                    c.BringToFront();
                    pictureBox1.BackColor = Color.Red;
                }
            }
        }
    }
}
