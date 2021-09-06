using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatrancTahtasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0, j = 0, yer = 0;

            for (i = 0; i < 8; i++)

            {

                for (j = 0; j < 8; j++)

                {

                    if (i % 2 == 0)

                    {

                        if (yer == 1)

                        {

                            Button btn = new Button();

                            btn.BackColor = Color.Black;

                            btn.Size = new Size(50, 50);

                            flowLayoutPanel1.Controls.Add(btn);

                            yer = 0;

                        }

                        else

                        {

                            yer++;

                            Button btn = new Button();

                            btn.BackColor = Color.White;

                            btn.Size = new Size(50, 50);

                            flowLayoutPanel1.Controls.Add(btn);

                        }

                    }

                    else

                    {

                        if (yer == 0)

                        {

                            Button btn = new Button();

                            btn.BackColor = Color.Black;

                            btn.Size = new Size(50, 50);

                            flowLayoutPanel1.Controls.Add(btn);

                            yer++;

                        }

                        else

                        {

                            yer = 0;

                            Button btn = new Button();

                            btn.BackColor = Color.White;

                            btn.Size = new Size(50, 50);

                            flowLayoutPanel1.Controls.Add(btn);

                        }

                    }



                }

            }
        }
    }
}
