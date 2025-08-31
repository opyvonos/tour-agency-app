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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            button1.Text = "Назад";
            this.tOUR_VUTableAdapter.Fill(this.dataSet1.TOUR_VU);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
