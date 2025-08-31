using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Text = "Назад";
            this.bOOKING_VUTableAdapter.Fill(this.dataSet1.BOOKING_VU);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
