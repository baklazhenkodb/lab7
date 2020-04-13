using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7._1
{
    public partial class Running_Button : Form
    {
        public Running_Button()
        {
            InitializeComponent();
        }

        // Button click event processing
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratz! You push the button!");
        }

        
        // Mouse move event processing
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // 
            if (e.X > button.Left - 10 && e.X < button.Left + button.Width + 10)
            {
                if (e.X >= (button.Left + (button.Width / 2)))
                {
                    button.Left -= 10;
                    button.Top -= 10;
                }
                else
                { 
                    button.Left += 10;
                    button.Top += 10;
                }
            }

            if (e.Y >= button.Top - 10 && e.Y <= button.Top + button.Height + 10)
            {
                if (e.Y >= (button.Top + (button.Height / 2)))
                    button.Top -= 10; 
                else
                    button.Top += 10;
            }

            if (button.Left <= 0) button.Left = this.ClientSize.Width-button.Width-20;
            else if (button.Left+button.Width >= this.ClientSize.Width) button.Left = 20;


            if (button.Top < 0)
                button.Top = this.ClientSize.Height;

            if ((button.Top + button.Height) > this.ClientSize.Height)
                button.Top = this.ClientSize.Height - button.Height;
        }

        private void Running_Button_Load(object sender, EventArgs e)
        {

        }
    }
}
