using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace com_test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void t1_tick(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            try
            {
                tb2.Text += com1.ReadLine()+"  ";
            }
            catch (Exception ex) { label1.Text = ex+""; }


            timer1.Enabled = true;


         
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            

            try
            {
                com1.WriteLine(tb1.Text);
            }
            catch (Exception ex) { label1.Text = ex+""; }
          
        }

        private void btn_set_com_Click(object sender, EventArgs e)
        {

            com1.PortName = tb_set_com.Text;
            label2.Text = "当前:"+com1.PortName;
            com1.Open();
            timer1.Enabled = true;
            tb_set_com.Enabled = false;

        }

        private void btn_close_com_Click(object sender, EventArgs e)
        {
            com1.Close();
            label2.Text = "串口已关闭";
            timer1.Enabled = false;
            tb_set_com.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
