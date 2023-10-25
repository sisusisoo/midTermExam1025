namespace midTermExam1025
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button_add = new Button();
            button_modi = new Button();
            button_del = new Button();
            button1_right = new Button();
            button2_right = new Button();
            button1_left = new Button();
            button2_left = new Button();
            button_hwak = new Button();
            button_rechange = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 89);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 244);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(191, 89);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 244);
            listBox2.TabIndex = 1;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(363, 89);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 244);
            listBox3.TabIndex = 2;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(588, 89);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(120, 244);
            listBox4.TabIndex = 3;
            listBox4.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Location = new Point(739, 89);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(120, 244);
            listBox5.TabIndex = 4;
            listBox5.SelectedIndexChanged += listBox5_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 5;
            label1.Text = "주문확인";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 59);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "배송중";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 59);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "배송완료";
            // 
            // button_add
            // 
            button_add.Location = new Point(12, 339);
            button_add.Name = "button_add";
            button_add.Size = new Size(75, 23);
            button_add.TabIndex = 8;
            button_add.Text = "주문추가";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_modi
            // 
            button_modi.Location = new Point(93, 339);
            button_modi.Name = "button_modi";
            button_modi.Size = new Size(75, 23);
            button_modi.TabIndex = 9;
            button_modi.Text = "주문수정";
            button_modi.UseVisualStyleBackColor = true;
            button_modi.Click += button_modi_Click;
            // 
            // button_del
            // 
            button_del.Location = new Point(174, 339);
            button_del.Name = "button_del";
            button_del.Size = new Size(75, 23);
            button_del.TabIndex = 10;
            button_del.Text = "주문삭제";
            button_del.UseVisualStyleBackColor = true;
            button_del.Click += button_del_Click;
            // 
            // button1_right
            // 
            button1_right.Location = new Point(138, 89);
            button1_right.Name = "button1_right";
            button1_right.Size = new Size(35, 77);
            button1_right.TabIndex = 11;
            button1_right.Text = ">";
            button1_right.UseVisualStyleBackColor = true;
            button1_right.Click += button1_right_Click;
            // 
            // button2_right
            // 
            button2_right.Location = new Point(322, 89);
            button2_right.Name = "button2_right";
            button2_right.Size = new Size(35, 77);
            button2_right.TabIndex = 12;
            button2_right.Text = ">";
            button2_right.UseVisualStyleBackColor = true;
            button2_right.Click += button2_right_Click;
            // 
            // button1_left
            // 
            button1_left.Location = new Point(138, 218);
            button1_left.Name = "button1_left";
            button1_left.Size = new Size(35, 77);
            button1_left.TabIndex = 13;
            button1_left.Text = "<";
            button1_left.UseVisualStyleBackColor = true;
            button1_left.Click += button1_left_Click;
            // 
            // button2_left
            // 
            button2_left.Location = new Point(322, 218);
            button2_left.Name = "button2_left";
            button2_left.Size = new Size(35, 77);
            button2_left.TabIndex = 14;
            button2_left.Text = "<";
            button2_left.UseVisualStyleBackColor = true;
            button2_left.Click += button2_left_Click;
            // 
            // button_hwak
            // 
            button_hwak.Location = new Point(489, 89);
            button_hwak.Name = "button_hwak";
            button_hwak.Size = new Size(75, 91);
            button_hwak.TabIndex = 15;
            button_hwak.Text = "구매확정";
            button_hwak.UseVisualStyleBackColor = true;
            button_hwak.Click += button_hwak_Click;
            // 
            // button_rechange
            // 
            button_rechange.Location = new Point(489, 245);
            button_rechange.Name = "button_rechange";
            button_rechange.Size = new Size(75, 73);
            button_rechange.TabIndex = 16;
            button_rechange.Text = "환불";
            button_rechange.UseVisualStyleBackColor = true;
            button_rechange.Click += button_rechange_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(588, 359);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 17;
            label4.Text = "총 구매확정 금액:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(696, 359);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 18;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(588, 59);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 19;
            label6.Text = "주문확정 목록";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(739, 59);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 20;
            label7.Text = "환불목록";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button_rechange);
            Controls.Add(button_hwak);
            Controls.Add(button2_left);
            Controls.Add(button1_left);
            Controls.Add(button2_right);
            Controls.Add(button1_right);
            Controls.Add(button_del);
            Controls.Add(button_modi);
            Controls.Add(button_add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox5);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_add;
        private Button button_modi;
        private Button button_del;
        private Button button1_right;
        private Button button2_right;
        private Button button1_left;
        private Button button2_left;
        private Button button_hwak;
        private Button button_rechange;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}