using midTermExam1025.midtermDB;

namespace midTermExam1025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int totalPrice = 0;

        void setPrice()
        {
            using (MidtermDbContext db = new MidtermDbContext())
            {
                var list = db.Order1s.Where(p => p.OrderState == "구매확정").ToList();
                foreach (var item in list)
                {

                    totalPrice += item.Price;
                    label5.Text = totalPrice.ToString();
                }
            }
        }
        void LoadOrder()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox1.DisplayMember = "Date";
            listBox2.DisplayMember = "Date";
            listBox3.DisplayMember = "Date";
            listBox4.DisplayMember = "Date";
            listBox5.DisplayMember = "Date";

            using (MidtermDbContext db = new MidtermDbContext())
            {
                var list = db.Order1s.ToList();

                foreach (var item in list)
                {
                    if (item.OrderState == "주문확인")
                    {
                        listBox1.Items.Add(item);
                    }
                    else if (item.OrderState == "배송중")
                    {
                        listBox2.Items.Add(item);
                    }
                    else if (item.OrderState == "배송완료")
                    {
                        listBox3.Items.Add(item);
                    }
                    else if (item.OrderState == "구매확정")
                    {
                        listBox4.Items.Add(item);
                    }
                    else if (item.OrderState == "환불")
                    {
                        listBox5.Items.Add(item);
                    }
                }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadOrder();
            setPrice();
        }



        private void button_add_Click(object sender, EventArgs e)
        {


            Form2 form2 = new Form2();
            form2.button = "주문추가";

            if (form2.ShowDialog() == DialogResult.OK)
            {

                using (MidtermDbContext db = new MidtermDbContext())
                {
                    db.Order1s.Add(form2.orderData);
                    db.SaveChanges();
                }
                LoadOrder();
            }

        }

        private void button_modi_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.button = "주문수정";
            if (selectedOrder != null)
            {
                form2.setOrderData(selectedOrder);

                if (form2.ShowDialog() == DialogResult.OK)
                {
                    using (MidtermDbContext db = new MidtermDbContext())
                    {
                        var item = db.Order1s.Where(p => p.Date == selectedOrder.Date).FirstOrDefault();
                        item.Price = form2.orderData.Price;
                        item.OrderState = form2.orderData.OrderState;
                        db.SaveChanges();


                    }
                }
                LoadOrder();


            }
        }

        //선택 로직
        midtermDB.Order1 selectedOrder;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOrder = listBox1.SelectedItem as Order1;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOrder = listBox2.SelectedItem as Order1;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOrder = listBox3.SelectedItem as Order1;
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOrder = listBox4.SelectedItem as Order1;
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOrder = listBox5.SelectedItem as Order1;
        }

        private void button_del_Click(object sender, EventArgs e)
        {

            if (selectedOrder != null)
            {



                using (MidtermDbContext db = new MidtermDbContext())
                {
                    var item = db.Order1s.Where(p => p.Date == selectedOrder.Date).FirstOrDefault();
                    db.Order1s.Remove(item);
                    db.SaveChanges();


                }

                LoadOrder();
            }
        }

        private void button1_right_Click(object sender, EventArgs e)
        {
            var listSelect = listBox1.SelectedItem as Order1;

            if (listSelect != null)
            {
                using (MidtermDbContext db = new MidtermDbContext())
                {
                    var item = db.Order1s.Where(p => p.Date == listSelect.Date).FirstOrDefault();

                    item.OrderState = "배송중";
                    db.SaveChanges();


                }
                LoadOrder();


            }
        }

        private void button2_right_Click(object sender, EventArgs e)
        {
            var listSelect = listBox2.SelectedItem as Order1;

            if (listSelect != null)
            {
                using (MidtermDbContext db = new MidtermDbContext())
                {
                    var item = db.Order1s.Where(p => p.Date == listSelect.Date).FirstOrDefault();

                    item.OrderState = "배송완료";
                    db.SaveChanges();


                }
                LoadOrder();


            }
        }

        private void button1_left_Click(object sender, EventArgs e)
        {
            var listSelect = listBox2.SelectedItem as Order1;

            if (listSelect != null)
            {
                using (MidtermDbContext db = new MidtermDbContext())
                {
                    var item = db.Order1s.Where(p => p.Date == listSelect.Date).FirstOrDefault();

                    item.OrderState = "주문확인";
                    db.SaveChanges();


                }
                LoadOrder();


            }
        }

        private void button2_left_Click(object sender, EventArgs e)
        {
            var listSelect = listBox3.SelectedItem as Order1;

            if (listSelect != null)
            {
                using (MidtermDbContext db = new MidtermDbContext())
                {
                    var item = db.Order1s.Where(p => p.Date == listSelect.Date).FirstOrDefault();

                    item.OrderState = "배송중";
                    db.SaveChanges();


                }
                LoadOrder();


            }
        }

        private void button_hwak_Click(object sender, EventArgs e)
        {
            var listSelect = listBox3.SelectedItem as Order1;

            if (listSelect != null)
            {
                using (MidtermDbContext db = new MidtermDbContext())
                {
                    var item = db.Order1s.Where(p => p.Date == listSelect.Date).FirstOrDefault();

                    item.OrderState = "구매확정";
                    db.SaveChanges();


                }
                LoadOrder();

                setPrice();

            }
        }

        private void button_rechange_Click(object sender, EventArgs e)
        {
            var listSelect = listBox3.SelectedItem as Order1;

            if (listSelect != null)
            {
                using (MidtermDbContext db = new MidtermDbContext())
                {
                    var item = db.Order1s.Where(p => p.Date == listSelect.Date).FirstOrDefault();

                    item.OrderState = "환불";
                    db.SaveChanges();


                }
                LoadOrder();


            }
        }
    }
}