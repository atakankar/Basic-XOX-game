using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void XOXtiklama(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if(label1.Text=="X")
            {
                bt.Text = "X";
                label1.ForeColor = Color.Blue;
                bt.Enabled = false;
                label1.Text = "O";
            }
            else
            {
                bt.Text = "O";
                label1.ForeColor = Color.Red;
                bt.Enabled = false;
                label1.Text = "X";
            }

            //KAZANMA DURUMLARI
            if(button1.Text==button2.Text && button2.Text== button3.Text && button1.Enabled== false && button2.Enabled==false && button3.Enabled==false)
            {
                string a = button1.Text.ToString();
                MessageBox.Show(a + " KAZANDI");
                oyunbitis();
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false)
            {
                string a = button4.Text.ToString();
                MessageBox.Show(a + " KAZANDI");
                oyunbitis();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                string a = button7.Text.ToString();
                MessageBox.Show(a + " KAZANDI");
                oyunbitis();
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Enabled == false && button4.Enabled == false && button7.Enabled == false)
            {
                string a = button1.Text.ToString();
                MessageBox.Show(a + " KAZANDI");
                oyunbitis();
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Enabled == false && button5.Enabled == false && button8.Enabled == false)
            {
                string a = button2.Text.ToString();
                MessageBox.Show(a + " KAZANDI");
                oyunbitis();
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Enabled == false && button6.Enabled == false && button9.Enabled == false)
            {
                string a = button3.Text.ToString();
                MessageBox.Show(a + " KAZANDI");
                oyunbitis();
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Enabled == false && button5.Enabled == false && button9.Enabled == false)
            {
                string a = button1.Text.ToString();
                MessageBox.Show(a + " KAZANDI");
                oyunbitis();
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Enabled == false && button5.Enabled == false && button7.Enabled == false)
            {
                string a = button3.Text.ToString();
                MessageBox.Show(a + " KAZANDI");
                oyunbitis();
            }
            //BERABERLİK
            if(button1.Enabled==false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false )
            {
                MessageBox.Show("BERABERE");
                oyunbitis();
            }
        }
        //oyun bitişi     
        private void oyunbitis()
        {
            label1.ForeColor = Color.Red;
            label1.Text = "X";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
    }
}
