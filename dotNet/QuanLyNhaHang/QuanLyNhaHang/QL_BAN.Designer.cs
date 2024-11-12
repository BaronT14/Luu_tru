namespace QuanLyNhaHang
{
    partial class QL_BAN
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
            groupBox1 = new GroupBox();
            treeView1 = new TreeView();
            cb_loaiban = new ComboBox();
            checkBox1 = new CheckBox();
            groupBox2 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            button4 = new Button();
            textBox3 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            numericUpDown2 = new NumericUpDown();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 0;
            label1.Text = "Quản lý bàn ăn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(treeView1);
            groupBox1.Controls.Add(cb_loaiban);
            groupBox1.Font = new Font("Times New Roman", 12.75F);
            groupBox1.Location = new Point(12, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 601);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách bàn ăn";
            // 
            // treeView1
            // 
            treeView1.Font = new Font("Times New Roman", 12.75F);
            treeView1.Location = new Point(21, 59);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(447, 520);
            treeView1.TabIndex = 0;
            // 
            // cb_loaiban
            // 
            cb_loaiban.Font = new Font("Times New Roman", 12.75F);
            cb_loaiban.FormattingEnabled = true;
            cb_loaiban.Location = new Point(21, 26);
            cb_loaiban.Name = "cb_loaiban";
            cb_loaiban.Size = new Size(447, 27);
            cb_loaiban.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 12.75F);
            checkBox1.Location = new Point(533, 308);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(158, 23);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Thêm loại bàn/sảnh";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Times New Roman", 12.75F);
            groupBox2.Location = new Point(533, 55);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(519, 224);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin bàn ăn/sảnh";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(139, 123);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(100, 27);
            numericUpDown1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12.75F);
            label2.Location = new Point(14, 125);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 13;
            label2.Text = "Số lượng bàn:";
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 12.75F);
            button3.Location = new Point(355, 168);
            button3.Name = "button3";
            button3.Size = new Size(106, 40);
            button3.TabIndex = 12;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12.75F);
            button2.Location = new Point(223, 168);
            button2.Name = "button2";
            button2.Size = new Size(106, 40);
            button2.TabIndex = 11;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12.75F);
            button1.Location = new Point(86, 168);
            button1.Name = "button1";
            button1.Size = new Size(106, 40);
            button1.TabIndex = 10;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 12.75F);
            textBox2.Location = new Point(139, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(349, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12.75F);
            textBox1.Location = new Point(139, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 27);
            textBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12.75F);
            label3.Location = new Point(15, 84);
            label3.Name = "label3";
            label3.Size = new Size(101, 19);
            label3.TabIndex = 6;
            label3.Text = "Tên bàn/sảnh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12.75F);
            label4.Location = new Point(18, 29);
            label4.Name = "label4";
            label4.Size = new Size(98, 19);
            label4.TabIndex = 7;
            label4.Text = "Mã bàn/sảnh:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Times New Roman", 12.75F);
            groupBox3.Location = new Point(533, 337);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(519, 319);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin loại bàn";
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 12.75F);
            button4.Location = new Point(355, 145);
            button4.Name = "button4";
            button4.Size = new Size(106, 40);
            button4.TabIndex = 15;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 12.75F);
            textBox3.Location = new Point(99, 85);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(389, 27);
            textBox3.TabIndex = 13;
            // 
            // button5
            // 
            button5.Font = new Font("Times New Roman", 12.75F);
            button5.Location = new Point(223, 145);
            button5.Name = "button5";
            button5.Size = new Size(106, 40);
            button5.TabIndex = 14;
            button5.Text = "Cập nhật";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Times New Roman", 12.75F);
            button6.Location = new Point(86, 145);
            button6.Name = "button6";
            button6.Size = new Size(106, 40);
            button6.TabIndex = 13;
            button6.Text = "Thêm";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 12.75F);
            textBox4.Location = new Point(99, 30);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(389, 27);
            textBox4.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12.75F);
            label5.Location = new Point(18, 88);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 10;
            label5.Text = "Tên loại:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12.75F);
            label6.Location = new Point(21, 33);
            label6.Name = "label6";
            label6.Size = new Size(66, 19);
            label6.TabIndex = 11;
            label6.Text = "Mã loại:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(388, 123);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(100, 27);
            numericUpDown2.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12.75F);
            label7.Location = new Point(264, 125);
            label7.Name = "label7";
            label7.Size = new Size(118, 19);
            label7.TabIndex = 15;
            label7.Text = "Số lượng khách:";
            // 
            // QL_BAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(checkBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "QL_BAN";
            Text = "Quản lý bàn";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cb_loaiban;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Label label7;
    }
}