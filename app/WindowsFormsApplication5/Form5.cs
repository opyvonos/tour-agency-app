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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.tRANSPORTTableAdapter.Fill(this.dataSet1.TRANSPORT);
            this.tOUR_TYPETableAdapter.Fill(this.dataSet1.TOUR_TYPE);
            this.tOUR_MANAGERTableAdapter.Fill(this.dataSet1.TOUR_MANAGER);
            this.tOURTableAdapter.Fill(this.dataSet1.TOUR);
            this.hOTELTableAdapter.Fill(this.dataSet1.HOTEL);
            this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
            this.cOUNTRYTableAdapter.Fill(this.dataSet1.COUNTRY);
            this.cITYTableAdapter.Fill(this.dataSet1.CITY);
            this.bOOKINGTableAdapter.Fill(this.dataSet1.BOOKING);
            this.aCCOUNTTableAdapter.Fill(this.dataSet1.ACCOUNT);
            chart1.Series[0].IsVisibleInLegend = false;

        }

        private void aCCOUNTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aCCOUNTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tRANSPORTTableAdapter.InsertQuery((string)textBox2.Text);
                this.tRANSPORTTableAdapter.Fill(this.dataSet1.TRANSPORT);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.tRANSPORTTableAdapter.UpdateQuery((string)textBox4.Text, (decimal)Convert.ToDouble(textBox3.Text));
                this.tRANSPORTTableAdapter.Fill(this.dataSet1.TRANSPORT);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.tRANSPORTTableAdapter.DeleteQuery((decimal)Convert.ToDouble(textBox5.Text));
                this.tRANSPORTTableAdapter.Fill(this.dataSet1.TRANSPORT);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                this.tOUR_TYPETableAdapter.InsertQuery((string)textBox7.Text);
                this.tOUR_TYPETableAdapter.Fill(this.dataSet1.TOUR_TYPE);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.tOUR_TYPETableAdapter.UpdateQuery((string)textBox9.Text, (decimal)Convert.ToDouble(textBox8.Text));
                this.tOUR_TYPETableAdapter.Fill(this.dataSet1.TOUR_TYPE);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                this.tOUR_TYPETableAdapter.DeleteQuery((decimal)Convert.ToDouble(textBox10.Text));
                this.tOUR_TYPETableAdapter.Fill(this.dataSet1.TOUR_TYPE);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                this.cOUNTRYTableAdapter.InsertQuery((decimal)Convert.ToDouble(textBox6.Text), (string)textBox11.Text);
                this.cOUNTRYTableAdapter.Fill(this.dataSet1.COUNTRY);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                this.cOUNTRYTableAdapter.UpdateQuery((string)textBox13.Text, (decimal)Convert.ToDouble(textBox12.Text));
                this.cOUNTRYTableAdapter.Fill(this.dataSet1.COUNTRY);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                this.cOUNTRYTableAdapter.DeleteQuery((decimal)Convert.ToDouble(textBox14.Text));
                this.cOUNTRYTableAdapter.Fill(this.dataSet1.COUNTRY);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                this.cITYTableAdapter.InsertQuery((decimal)Convert.ToDouble(textBox15.Text), (string)textBox16.Text);
                this.cITYTableAdapter.Fill(this.dataSet1.CITY);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                this.cITYTableAdapter.UpdateQuery((decimal)Convert.ToDouble(textBox18.Text), (string)textBox19.Text, (decimal)Convert.ToDouble(textBox17.Text));
                this.cITYTableAdapter.Fill(this.dataSet1.CITY);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                this.cITYTableAdapter.DeleteQuery((decimal)Convert.ToDouble(textBox20.Text));
                this.cITYTableAdapter.Fill(this.dataSet1.CITY);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                this.aCCOUNTTableAdapter.InsertQuery((decimal)Convert.ToDouble(textBox21.Text), (DateTime)dateTimePicker1.Value, (decimal)Convert.ToDouble(textBox22.Text));
                this.aCCOUNTTableAdapter.Fill(this.dataSet1.ACCOUNT);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                this.aCCOUNTTableAdapter.UpdateQuery((decimal)Convert.ToDouble(textBox24.Text), (DateTime)dateTimePicker2.Value, (decimal)Convert.ToDouble(textBox25.Text), (decimal)Convert.ToDouble(textBox23.Text));
                this.aCCOUNTTableAdapter.Fill(this.dataSet1.ACCOUNT);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                this.aCCOUNTTableAdapter.DeleteQuery((decimal)Convert.ToDouble(textBox26.Text));
                this.aCCOUNTTableAdapter.Fill(this.dataSet1.ACCOUNT);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                this.hOTELTableAdapter.InsertQuery((decimal)Convert.ToDouble(textBox1.Text), (string)textBox27.Text, (string)textBox28.Text, (decimal)Convert.ToDouble(textBox29.Text));
                this.hOTELTableAdapter.Fill(this.dataSet1.HOTEL);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                this.hOTELTableAdapter.UpdateQuery((decimal)Convert.ToDouble(textBox31.Text), (string)textBox32.Text, (string)textBox33.Text, (decimal)Convert.ToDouble(textBox34.Text), (decimal)Convert.ToDouble(textBox30.Text));
                this.hOTELTableAdapter.Fill(this.dataSet1.HOTEL);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                this.hOTELTableAdapter.DeleteQuery((decimal)Convert.ToDouble(textBox35.Text));
                this.hOTELTableAdapter.Fill(this.dataSet1.HOTEL);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                this.tOUR_MANAGERTableAdapter.InsertQuery((string)textBox37.Text, (string)textBox38.Text, (string)textBox39.Text, (DateTime)dateTimePicker3.Value, (decimal)Convert.ToDouble(textBox40.Text));
                this.tOUR_MANAGERTableAdapter.Fill(this.dataSet1.TOUR_MANAGER);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                this.tOUR_MANAGERTableAdapter.UpdateQuery((string)textBox41.Text, (string)textBox42.Text, (string)textBox43.Text, (decimal)Convert.ToDouble(textBox44.Text), (decimal)Convert.ToDouble(textBox36.Text));
                this.tOUR_MANAGERTableAdapter.Fill(this.dataSet1.TOUR_MANAGER);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                this.tOUR_MANAGERTableAdapter.DeleteQuery((decimal)Convert.ToDouble(textBox45.Text));
                this.tOUR_MANAGERTableAdapter.Fill(this.dataSet1.TOUR_MANAGER);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                this.cUSTOMERTableAdapter.InsertQuery((string)textBox46.Text, (string)textBox47.Text, (DateTime)dateTimePicker4.Value, (string)textBox48.Text, (string)textBox49.Text, (string)textBox50.Text);
                this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                this.cUSTOMERTableAdapter.UpdateQuery((string)textBox51.Text, (string)textBox52.Text, (string)textBox53.Text, (string)textBox54.Text, (string)textBox55.Text, (decimal)Convert.ToDouble(textBox56.Text));
                this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                this.cUSTOMERTableAdapter.DeleteQuery((decimal)Convert.ToDouble(textBox57.Text));
                this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                this.tOURTableAdapter.InsertQuery((decimal)Convert.ToDouble(textBox58.Text), (decimal)Convert.ToDouble(textBox59.Text), (decimal)Convert.ToDouble(textBox60.Text), (decimal)Convert.ToDouble(textBox61.Text), (decimal)Convert.ToDouble(textBox62.Text));
                this.tOURTableAdapter.Fill(this.dataSet1.TOUR);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                this.tOURTableAdapter.UpdateQuery((decimal)Convert.ToDouble(textBox63.Text), (decimal)Convert.ToDouble(textBox64.Text), (decimal)Convert.ToDouble(textBox65.Text), (decimal)Convert.ToDouble(textBox66.Text), (decimal)Convert.ToDouble(textBox67.Text), (decimal)Convert.ToDouble(textBox68.Text));
                this.tOURTableAdapter.Fill(this.dataSet1.TOUR);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            try
            {
                this.tOURTableAdapter.DeleteQuery((decimal)Convert.ToDouble(textBox69.Text));
                this.tOURTableAdapter.Fill(this.dataSet1.TOUR);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            try
            {
                this.bOOKINGTableAdapter.InsertQuery((decimal)Convert.ToDouble(textBox70.Text), (decimal)Convert.ToDouble(textBox71.Text), (decimal)Convert.ToDouble(textBox72.Text), (string)textBox73.Text, (DateTime)dateTimePicker5.Value, (string)textBox74.Text);
                this.bOOKINGTableAdapter.Fill(this.dataSet1.BOOKING);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                this.bOOKINGTableAdapter.UpdateQuery((decimal)Convert.ToDouble(textBox77.Text), (decimal)Convert.ToDouble(textBox78.Text), (string)textBox79.Text, (string)textBox76.Text, (decimal)Convert.ToDouble(textBox75.Text));
                this.bOOKINGTableAdapter.Fill(this.dataSet1.BOOKING);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            try
            {
                this.bOOKINGTableAdapter.DeleteQuery((decimal)Convert.ToDouble(textBox80.Text));
                this.bOOKINGTableAdapter.Fill(this.dataSet1.BOOKING);
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button41_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.tRANSPORTTableAdapter.GetDataByType((string)textBox81.Text);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = this.tOUR_TYPETableAdapter.GetDataByName((string)textBox82.Text);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = this.tOURTableAdapter.FindData((decimal)Convert.ToDouble(textBox84.Text), (decimal)Convert.ToDouble(textBox84.Text), (decimal)Convert.ToDouble(textBox84.Text), (decimal)Convert.ToDouble(textBox84.Text));
        }

        private void button45_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = this.hOTELTableAdapter.FindHotel((decimal)Convert.ToDouble(textBox85.Text), (decimal)Convert.ToDouble(textBox85.Text));
        }

        private void button46_Click(object sender, EventArgs e)
        {
            dataGridView6.DataSource = this.cUSTOMERTableAdapter.FindCustomer((string)textBox86.Text, (string)textBox86.Text, (string)textBox86.Text);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            dataGridView7.DataSource = this.cOUNTRYTableAdapter.FindCountry((string)textBox87.Text);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            dataGridView8.DataSource = this.cITYTableAdapter.FindCity((string)textBox88.Text);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            dataGridView9.DataSource = this.bOOKINGTableAdapter.FindBooking((decimal)Convert.ToDouble(textBox89.Text), (decimal)Convert.ToDouble(textBox89.Text));
        }

        private void button50_Click(object sender, EventArgs e)
        {
            dataGridView9.DataSource = this.bOOKINGTableAdapter.FindByStatus((string)textBox90.Text);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            dataGridView10.DataSource = this.aCCOUNTTableAdapter.FindByDate((DateTime)dateTimePicker6.Value);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            dataGridView10.DataSource = this.aCCOUNTTableAdapter.FindBySum((decimal)Convert.ToDouble(textBox91.Text));
        }

        private void button43_Click(object sender, EventArgs e)
        {
            chart1.DataSource = dataSet1.TOUR_MANAGER;
            chart1.Series[0].XValueMember = "LAST_NAME";
            chart1.Series[0].YValueMembers = "SALARY";
            chart1.Titles.Add("Заробітна плата");
            chart1.Series[0].Color = Color.SteelBlue;
            chart1.DataBind();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            this.tOUR_MANAGERTableAdapter.FillByDate(this.dataSet1.TOUR_MANAGER, (DateTime)dateTimePicker7.Value, (DateTime)dateTimePicker8.Value);
            Class.DD1 = dateTimePicker7.Value;
            Class.DD2 = dateTimePicker8.Value;
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            this.aCCOUNTTableAdapter.FillByDate(this.dataSet1.ACCOUNT, (DateTime)dateTimePicker9.Value, (DateTime)dateTimePicker10.Value);
            Class.DD3 = dateTimePicker9.Value;
            Class.DD4 = dateTimePicker10.Value;
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            this.bOOKINGTableAdapter.FillByDate(this.dataSet1.BOOKING, (DateTime)dateTimePicker11.Value, (DateTime)dateTimePicker12.Value);
            Class.DD5 = dateTimePicker11.Value;
            Class.DD6 = dateTimePicker12.Value;
            Form8 f8 = new Form8();
            f8.Show();
        }
    }

    public static class Class
    {
        public static DateTime DD1;
        public static DateTime DD2;
        public static DateTime DD3;
        public static DateTime DD4;
        public static DateTime DD5;
        public static DateTime DD6;
    }
}
