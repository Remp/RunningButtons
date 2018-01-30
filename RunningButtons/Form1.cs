using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RunningButtons
{
    delegate void Motion(Button btn);

    public partial class Form1 : Form
    {
        Thread t1;
        Thread t2;
        Thread t3;
        Motion m;
        ButtonCompare[] btns;
     

        Random r = new Random();

        public Form1()
        {
            InitializeComponent();

            m = Movement;

            btns = new ButtonCompare[] { btnBMW, btnFerrari, btnLamborgini };

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnPause.Enabled = true;
            if (t1 != null)
            {

                try
                {
                    t1.Resume();
                    t2.Resume();
                    t3.Resume();
                }
                catch { }
                return;
                
            }
            t1 = new Thread(MovementBMW);
            t2 = new Thread(MovementFerrari);
            t3 = new Thread(MovementLamborgini);
            t1.IsBackground = t2.IsBackground = t3.IsBackground = true;
            t1.Start();
            t2.Start();
            t3.Start();
        }

        void Movement(Button btn)
        {
                       
            btn.Location = new Point(btn.Location.X + r.Next(3) + 1, btn.Location.Y);

            Array.Sort(btns);
            btns[0].BackColor = SystemColors.Control;
            btns[1].BackColor = SystemColors.Control;
            btns[2].BackColor = Color.Green;

            if (btn.Location.X > pictureBox1.Location.X - btn.Width)
            {
                btnPause_Click(btn, new EventArgs());
                MessageBox.Show(string.Format("{0} wins", btn.Text), "Victory");
                btnStop_Click(btn, new EventArgs());
            }
        }

        void MovementBMW()
        {
            while (true)
            {
                this.Invoke(m, btnBMW);
                Thread.Sleep(100); 
            }
            
        }

        void MovementFerrari()
        {
            while (true)
            {
                this.Invoke(m, btnLamborgini);
                Thread.Sleep(100);
            }
        }

        void MovementLamborgini()
        {
            while (true)
            {
                this.Invoke(m, btnFerrari);
                Thread.Sleep(100);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (t1 != null)
            {
                btnStart.Enabled = true;
                btnPause.Enabled = false;
                t1.Suspend();
                t2.Suspend();
                t3.Suspend();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;

            btnPause_Click(sender, e);
            btnBMW.Location = new Point(26, 19);
            btnFerrari.Location = new Point(26, 57);
            btnLamborgini.Location = new Point(26, 97);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnStop_Click(new object(), new EventArgs());
        }
    }

    class ButtonCompare : Button, IComparable<ButtonCompare>
    {
        public int CompareTo(ButtonCompare other)
        {
            if (this.Location.X > other.Location.X)
                return 1;
            if (this.Location.X < other.Location.X)
                return -1;
            return 0;
        }
    }
}





