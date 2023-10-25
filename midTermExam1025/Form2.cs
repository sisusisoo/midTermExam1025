using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midTermExam1025
{
    public partial class Form2 : Form
    {
        public midtermDB.Order1 orderData;

        public string button;

        public void setOrderData(midtermDB.Order1 orderDataSet)
        {
            label_date.Text = orderDataSet.Date.ToString();
            textBox_price.Text = orderDataSet.Price.ToString();
            comboBox_state.Text=orderDataSet.OrderState.ToString();


        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button_add_modi.Text = button;

        }

        private void button_add_modi_Click(object sender, EventArgs e)
        {
            orderData = new midtermDB.Order1()
            {
                Date = DateTime.Now,
                OrderState = comboBox_state.Text,
                Price = int.Parse(textBox_price.Text)

            };

            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }
}
