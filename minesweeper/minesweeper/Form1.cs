using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper
{
    public partial class Form1 : Form
    {
        Button[] btngrid = new Button[100];
        Random random = new Random();
        Tile[] tileGrid = new Tile[100];
        public Form1()
        {
            InitializeComponent();
            /*btngrid[0] = button1;
            btngrid[1] = button2;
            btngrid[2] = button3;
            btngrid[3] = button4;
            btngrid[4] = button5;
            btngrid[5] = button6;
            btngrid[6] = button7;
            btngrid[7] = button8;
            btngrid[8] = button9;
            btngrid[9] = button10;*/
            for (int i = 0; i < 99; i++)
            {
                btngrid[i] = (Button)Controls["button" + (i + 1)];
              
                btngrid[i].BackColor = Color.LightPink;
                tileGrid[i] = new Tile(btngrid[i]);
            }
        }
        private Button GetButton(int r, int c)
        {
            return (Button)GetButton(r, c);
        }

        private int getindex(Button b)
        {
            string tmp = b.Name.Substring(6);
            int retVAL = 0;
            int.TryParse(tmp, out retVAL);
            return retVAL;
        }













        bool flag = false;


        private void button49_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (!flag)
                    b1.BackgroundImage = pictureBox2.Image;
                else
                    b1.BackgroundImage = null;
                flag = !flag;

            }
            if (e.Button == MouseButtons.Left)
            {
                 b1.BackgroundImage = pictureBox1.Image;
            }
                

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tile t = new Tile();
            
        }
    }
}
