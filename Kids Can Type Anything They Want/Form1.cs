using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kids_Can_Type_Anything_They_Want
{
    public partial class Form1 : Form
    {

        bool rainbow = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void ColorSelect_Click(object sender, EventArgs e)
        {
            string color = ((Button)sender).Name;
            mainType.SelectionColor = Color.FromName(color);
            
            rainbow = false;
        }

        private void mainType_Leave(object sender, EventArgs e)
        {
            mainType.Focus();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            mainType.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rainbow = true;
        }

        private void mainType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(rainbow == true)
            {
                Random numGen = new Random();

                switch (numGen.Next(7))
                {
                    case 1:
                        mainType.SelectionColor = Color.Red;
                        break;
                    case 2:
                        mainType.SelectionColor = Color.Orange;
                        break;
                    case 3:
                        mainType.SelectionColor = Color.Yellow;
                        break;
                    case 4:
                        mainType.SelectionColor = Color.Green;
                        break;
                    case 5:
                        mainType.SelectionColor = Color.Blue;
                        break;
                    case 6:
                        mainType.SelectionColor = Color.Indigo;
                        break;
                    case 7:
                        mainType.SelectionColor = Color.Violet;
                        break;
                    default:
                        break;
                }
                
            }
        }

    }
}