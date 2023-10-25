namespace midTermExam1025
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label_date = new Label();
            textBox_price = new TextBox();
            comboBox_state = new ComboBox();
            button_add_modi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 77);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "주문일시";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 121);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "주문금액";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 161);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "주문 상태";
            // 
            // label_date
            // 
            label_date.AutoSize = true;
            label_date.Location = new Point(81, 77);
            label_date.Name = "label_date";
            label_date.Size = new Size(75, 15);
            label_date.TabIndex = 3;
            label_date.Text = "추가시 자동 ";
            // 
            // textBox_price
            // 
            textBox_price.Location = new Point(81, 118);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(100, 23);
            textBox_price.TabIndex = 4;
            // 
            // comboBox_state
            // 
            comboBox_state.FormattingEnabled = true;
            comboBox_state.Items.AddRange(new object[] { "주문확인", "배송중", "배송완료", "구매확정", "환불" });
            comboBox_state.Location = new Point(81, 158);
            comboBox_state.Name = "comboBox_state";
            comboBox_state.Size = new Size(121, 23);
            comboBox_state.TabIndex = 5;
            // 
            // button_add_modi
            // 
            button_add_modi.Location = new Point(60, 229);
            button_add_modi.Name = "button_add_modi";
            button_add_modi.Size = new Size(75, 23);
            button_add_modi.TabIndex = 6;
            button_add_modi.Text = "1";
            button_add_modi.UseVisualStyleBackColor = true;
            button_add_modi.Click += button_add_modi_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_add_modi);
            Controls.Add(comboBox_state);
            Controls.Add(textBox_price);
            Controls.Add(label_date);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label_date;
        private TextBox textBox_price;
        private ComboBox comboBox_state;
        private Button button_add_modi;
    }
}