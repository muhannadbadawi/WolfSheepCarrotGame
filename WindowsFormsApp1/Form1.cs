using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Hide();
            picShip.Location = new Point(367, 235);
            picGoat.Location = new Point(732, 157);
            picWolf.Location = new Point(650, 165);
            picCarrot.Location = new Point(594, 175);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(picShip.Location.ToString());
            //MessageBox.Show(picGoat.Location.ToString());
            //MessageBox.Show(picWolf.Location.ToString());
            //MessageBox.Show(picCarrot.Location.ToString());
        }
        private void picGoat_Click(object sender, EventArgs e)
        {
            { //move
                if (picGoat.Location == new Point(732, 157) && picShip.Location == new Point(367, 235))
                {
                    picGoat.Location = new Point(400, 157);
                }
                else if (picGoat.Location == new Point(400, 157) && picShip.Location == new Point(367, 235))
                {
                    picGoat.Location = new Point(732, 157);
                }
                else if (picGoat.Location == new Point(280, 157) && picShip.Location == new Point(236, 235))
                {
                    picGoat.Location = new Point(140, 157);
                }
                else if (picGoat.Location == new Point(140, 157) && picShip.Location == new Point(236, 235))
                {
                    picGoat.Location = new Point(280, 157);
                }
                if (picGoat.Location == new Point(400, 157) && picWolf.Location == new Point(400, 165))
                {
                    picWolf.Location = new Point(650, 165);
                }
                else if (picGoat.Location == new Point(400, 157) && picCarrot.Location == new Point(400, 175))
                {
                    picCarrot.Location = new Point(594, 175);
                }
                if (picShip.Location == new Point(236, 235) && picGoat.Location == new Point(280, 157) && picWolf.Location == new Point(280, 165))
                {
                    picWolf.Location = new Point(64, 165);
                }
                else if (picShip.Location == new Point(236, 235) && picGoat.Location == new Point(280, 157) && picCarrot.Location == new Point(280, 175))
                {
                    picCarrot.Location = new Point(-1, 175);
                }
               
            }
            if (picGoat.Location == new Point(140, 157) && picWolf.Location == new Point(64, 165) && picCarrot.Location == new Point(-1, 175))
            {
                panel1.Show();
                label1.ForeColor = Color.Green;
                label1.Text = "Win";
            }
        }


        private void picWolf_Click(object sender, EventArgs e)
        {
            { //move
                if (picWolf.Location == new Point(650, 165) && picShip.Location == new Point(367, 235))
                {
                    picWolf.Location = new Point(400, 165);
                }
                else if (picWolf.Location == new Point(400, 165) && picShip.Location == new Point(367, 235))
                {
                    picWolf.Location = new Point(650, 165);
                }
                else if (picWolf.Location == new Point(280, 165) && picShip.Location == new Point(236, 235))
                {
                    picWolf.Location = new Point(64, 165);
                }
                else if (picWolf.Location == new Point(64, 165) && picShip.Location == new Point(236, 235))
                {
                    picWolf.Location = new Point(280, 165);
                }
                if (picGoat.Location == new Point(400, 157) && picWolf.Location == new Point(400, 165))
                {
                    picGoat.Location = new Point(732, 157);
                }
                else if (picWolf.Location == new Point(400, 165) && picCarrot.Location == new Point(400, 175))
                {
                    picCarrot.Location = new Point(594, 175);
                }
                if (picShip.Location == new Point(236, 235) && picWolf.Location == new Point(280, 165) && picGoat.Location == new Point(280, 157))
                {
                    picGoat.Location = new Point(140, 157);
                }
                else if (picShip.Location == new Point(236, 235) && picWolf.Location == new Point(280, 165) && picCarrot.Location == new Point(280, 175))
                {
                    picCarrot.Location = new Point(-1, 175);
                }
            }
            if (picGoat.Location == new Point(367, 235) && picCarrot.Location == new Point(594, 175) && picWolf.Location == new Point(64, 165))
            {
                panel1.Show();
                label1.ForeColor = Color.Red;
                label1.Text = "Losser";
            }

        } 

        private void picCarrot_Click(object sender, EventArgs e)
        {
            {//move
                if (picCarrot.Location == new Point(594, 175) && picShip.Location == new Point(367, 235))
                {
                    picCarrot.Location = new Point(400, 175);
                }
                else if (picCarrot.Location == new Point(400, 175) && picShip.Location == new Point(367, 235))
                {
                    picCarrot.Location = new Point(594, 175);
                }
                else if (picCarrot.Location == new Point(280, 175) && picShip.Location == new Point(236, 235))
                {
                    picCarrot.Location = new Point(-1, 175);
                }
                else if (picCarrot.Location == new Point(-1, 175) && picShip.Location == new Point(236, 235))
                {
                    picCarrot.Location = new Point(280, 175);
                }
                if (picCarrot.Location == new Point(400, 175) && picGoat.Location == new Point(400, 157))
                {
                    picGoat.Location = new Point(732, 157);
                }
                else if (picCarrot.Location == new Point(400, 175) && picWolf.Location == new Point(400, 165))
                {
                    picWolf.Location = new Point(650, 165);
                }
                if (picShip.Location == new Point(236, 235) && picCarrot.Location == new Point(280, 175) && picGoat.Location == new Point(280, 157))
                {
                    picGoat.Location = new Point(140, 157);
                }
                else if (picShip.Location == new Point(236, 235) && picCarrot.Location == new Point(280, 175) && picWolf.Location == new Point(280, 165))
                {
                    picWolf.Location = new Point(64, 165);
                }
            }
               if (picWolf.Location == new Point(650, 165) && picGoat.Location == new Point(732, 157) && picCarrot.Location == new Point(-1, 175))
            {
                panel1.Show();
                label1.ForeColor = Color.Red;
                label1.Text = "Losser";
            }
        }


        private void picShip_Click(object sender, EventArgs e)
        {
            {//move
                if (picShip.Location == new Point(367, 235))
                {
                    picShip.Location = new Point(236, 235);
                }
                else if (picShip.Location == new Point(236, 235))
                {
                    picShip.Location = new Point(367, 235);
                }
                if (picGoat.Location == new Point(400, 157))
                {
                    picGoat.Location = new Point(280, 157);
                }
                else if (picGoat.Location == new Point(280, 157))
                {
                    picGoat.Location = new Point(400, 157);
                }
                else if (picWolf.Location == new Point(400, 165))
                {
                    picWolf.Location = new Point(280, 165);
                }
                else if (picWolf.Location == new Point(280, 165))
                {
                    picWolf.Location = new Point(400, 165);
                }
                else if (picCarrot.Location == new Point(400, 175))
                {
                    picCarrot.Location = new Point(280, 175);
                }
                else if (picCarrot.Location == new Point(280, 175))
                {
                    picCarrot.Location = new Point(400, 175);
                }
            }
        
         
            if (picGoat.Location == new Point(140, 157) && picCarrot.Location == new Point(-1, 175)&& picWolf.Location == new Point(650, 165))
            {
                panel1.Show();
                label1.ForeColor = Color.Red;
                label1.Text = "Losser";
            }
            else if (picWolf.Location == new Point(64, 165) && picGoat.Location == new Point(140, 157) && picCarrot.Location == new Point(594, 175))
            {
                panel1.Show();
                label1.ForeColor = Color.Red;
                label1.Text = "Losser";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void ReastButton_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            picShip.Location = new Point(367, 235);
            picGoat.Location = new Point(732, 157);
            picWolf.Location = new Point(650, 165);
            picCarrot.Location = new Point(594, 175);
        }
    }
}



// goat 140 wolf 64 carrot -1 
