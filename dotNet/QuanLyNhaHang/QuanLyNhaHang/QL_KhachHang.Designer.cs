namespace QuanLyNhaHang
{
    partial class QL_KH
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
            label1 = new Label();
            gb_dsKH = new GroupBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            txt_timKiemKH = new TextBox();
            listBox1 = new ListBox();
            gb_ttKH = new GroupBox();
            rd_GTkhac = new RadioButton();
            btn_themKH = new Button();
            btn_xoaKH = new Button();
            btn_capnhatKH = new Button();
            label8 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            dt_lsKH = new DataGridView();
            NgayDatBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            SoHD = new DataGridViewTextBoxColumn();
            txt_emailKH = new TextBox();
            txt_sdtKH = new TextBox();
            rd_GTnu = new RadioButton();
            rd_GTnam = new RadioButton();
            txt_tenKH = new TextBox();
            label9 = new Label();
            txt_hangKH = new TextBox();
            gb_dsKH.SuspendLayout();
            gb_ttKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dt_lsKH).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(406, 9);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 0;
            label1.Text = "Quản lý khách hàng";
            // 
            // gb_dsKH
            // 
            gb_dsKH.Controls.Add(comboBox1);
            gb_dsKH.Controls.Add(label3);
            gb_dsKH.Controls.Add(txt_timKiemKH);
            gb_dsKH.Controls.Add(listBox1);
            gb_dsKH.Location = new Point(23, 59);
            gb_dsKH.Name = "gb_dsKH";
            gb_dsKH.Size = new Size(429, 610);
            gb_dsKH.TabIndex = 1;
            gb_dsKH.TabStop = false;
            gb_dsKH.Text = "Danh sách khách hàng";
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "Mặc định";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mặc định", "Tăng dần", "Giảm dần" });
            comboBox1.Location = new Point(302, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 27);
            comboBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 69);
            label3.Name = "label3";
            label3.Size = new Size(202, 19);
            label3.TabIndex = 9;
            label3.Text = "Sắp xếp theo hạng thành viên";
            // 
            // txt_timKiemKH
            // 
            txt_timKiemKH.ForeColor = SystemColors.ControlText;
            txt_timKiemKH.Location = new Point(6, 26);
            txt_timKiemKH.Name = "txt_timKiemKH";
            txt_timKiemKH.PlaceholderText = "Nhập số điện thoại";
            txt_timKiemKH.Size = new Size(417, 27);
            txt_timKiemKH.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(6, 106);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(417, 479);
            listBox1.TabIndex = 0;
            // 
            // gb_ttKH
            // 
            gb_ttKH.Controls.Add(label9);
            gb_ttKH.Controls.Add(txt_hangKH);
            gb_ttKH.Controls.Add(rd_GTkhac);
            gb_ttKH.Controls.Add(btn_themKH);
            gb_ttKH.Controls.Add(btn_xoaKH);
            gb_ttKH.Controls.Add(btn_capnhatKH);
            gb_ttKH.Controls.Add(label8);
            gb_ttKH.Controls.Add(textBox1);
            gb_ttKH.Controls.Add(label7);
            gb_ttKH.Controls.Add(dateTimePicker1);
            gb_ttKH.Controls.Add(label6);
            gb_ttKH.Controls.Add(label5);
            gb_ttKH.Controls.Add(label4);
            gb_ttKH.Controls.Add(label2);
            gb_ttKH.Controls.Add(dt_lsKH);
            gb_ttKH.Controls.Add(txt_emailKH);
            gb_ttKH.Controls.Add(txt_sdtKH);
            gb_ttKH.Controls.Add(rd_GTnu);
            gb_ttKH.Controls.Add(rd_GTnam);
            gb_ttKH.Controls.Add(txt_tenKH);
            gb_ttKH.Location = new Point(467, 59);
            gb_ttKH.Name = "gb_ttKH";
            gb_ttKH.Size = new Size(571, 610);
            gb_ttKH.TabIndex = 2;
            gb_ttKH.TabStop = false;
            gb_ttKH.Text = "Thông tin khách hàng";
            // 
            // rd_GTkhac
            // 
            rd_GTkhac.AutoSize = true;
            rd_GTkhac.Location = new Point(151, 96);
            rd_GTkhac.Name = "rd_GTkhac";
            rd_GTkhac.Size = new Size(62, 23);
            rd_GTkhac.TabIndex = 19;
            rd_GTkhac.TabStop = true;
            rd_GTkhac.Text = "Khác";
            rd_GTkhac.UseVisualStyleBackColor = true;
            // 
            // btn_themKH
            // 
            btn_themKH.Location = new Point(297, 218);
            btn_themKH.Name = "btn_themKH";
            btn_themKH.Size = new Size(75, 49);
            btn_themKH.TabIndex = 18;
            btn_themKH.Text = "Thêm";
            btn_themKH.UseVisualStyleBackColor = true;
            // 
            // btn_xoaKH
            // 
            btn_xoaKH.Location = new Point(489, 218);
            btn_xoaKH.Name = "btn_xoaKH";
            btn_xoaKH.Size = new Size(75, 49);
            btn_xoaKH.TabIndex = 17;
            btn_xoaKH.Text = "Xoá";
            btn_xoaKH.UseVisualStyleBackColor = true;
            // 
            // btn_capnhatKH
            // 
            btn_capnhatKH.Location = new Point(393, 218);
            btn_capnhatKH.Name = "btn_capnhatKH";
            btn_capnhatKH.Size = new Size(75, 49);
            btn_capnhatKH.TabIndex = 16;
            btn_capnhatKH.Text = "Cập nhật";
            btn_capnhatKH.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(297, 29);
            label8.Name = "label8";
            label8.Size = new Size(109, 19);
            label8.TabIndex = 15;
            label8.Text = "Mã khách hàng";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(297, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 27);
            textBox1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 279);
            label7.Name = "label7";
            label7.Size = new Size(112, 19);
            label7.TabIndex = 13;
            label7.Text = "Lịch sử đặt bàn";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 227);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(272, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 205);
            label6.Name = "label6";
            label6.Size = new Size(76, 19);
            label6.TabIndex = 11;
            label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 137);
            label5.Name = "label5";
            label5.Size = new Size(49, 19);
            label5.TabIndex = 10;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 137);
            label4.Name = "label4";
            label4.Size = new Size(99, 19);
            label4.TabIndex = 9;
            label4.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(112, 19);
            label2.TabIndex = 8;
            label2.Text = "Tên khách hàng";
            // 
            // dt_lsKH
            // 
            dt_lsKH.AllowUserToAddRows = false;
            dt_lsKH.AllowUserToDeleteRows = false;
            dt_lsKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt_lsKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_lsKH.Columns.AddRange(new DataGridViewColumn[] { NgayDatBan, ThanhTien, SoHD });
            dt_lsKH.Location = new Point(6, 301);
            dt_lsKH.Name = "dt_lsKH";
            dt_lsKH.ReadOnly = true;
            dt_lsKH.Size = new Size(559, 217);
            dt_lsKH.TabIndex = 6;
            // 
            // NgayDatBan
            // 
            NgayDatBan.FillWeight = 80F;
            NgayDatBan.HeaderText = "Ngày đặt bàn";
            NgayDatBan.Name = "NgayDatBan";
            NgayDatBan.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.FillWeight = 80F;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // SoHD
            // 
            SoHD.FillWeight = 50F;
            SoHD.HeaderText = "Số hoá đơn";
            SoHD.Name = "SoHD";
            SoHD.ReadOnly = true;
            // 
            // txt_emailKH
            // 
            txt_emailKH.Location = new Point(297, 159);
            txt_emailKH.Name = "txt_emailKH";
            txt_emailKH.PlaceholderText = "Nhập Email";
            txt_emailKH.Size = new Size(268, 27);
            txt_emailKH.TabIndex = 5;
            // 
            // txt_sdtKH
            // 
            txt_sdtKH.Location = new Point(6, 159);
            txt_sdtKH.Name = "txt_sdtKH";
            txt_sdtKH.PlaceholderText = "Nhập số điện thoại";
            txt_sdtKH.Size = new Size(272, 27);
            txt_sdtKH.TabIndex = 4;
            // 
            // rd_GTnu
            // 
            rd_GTnu.AutoSize = true;
            rd_GTnu.Location = new Point(84, 96);
            rd_GTnu.Name = "rd_GTnu";
            rd_GTnu.Size = new Size(48, 23);
            rd_GTnu.TabIndex = 3;
            rd_GTnu.TabStop = true;
            rd_GTnu.Text = "Nữ";
            rd_GTnu.UseVisualStyleBackColor = true;
            // 
            // rd_GTnam
            // 
            rd_GTnam.AutoSize = true;
            rd_GTnam.Location = new Point(6, 96);
            rd_GTnam.Name = "rd_GTnam";
            rd_GTnam.Size = new Size(59, 23);
            rd_GTnam.TabIndex = 2;
            rd_GTnam.TabStop = true;
            rd_GTnam.Text = "Nam";
            rd_GTnam.UseVisualStyleBackColor = true;
            // 
            // txt_tenKH
            // 
            txt_tenKH.Location = new Point(6, 51);
            txt_tenKH.Name = "txt_tenKH";
            txt_tenKH.PlaceholderText = "Nhập tên khách hàng";
            txt_tenKH.Size = new Size(272, 27);
            txt_tenKH.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(440, 29);
            label9.Name = "label9";
            label9.Size = new Size(116, 19);
            label9.TabIndex = 21;
            label9.Text = "Hạng thành viên";
            // 
            // txt_hangKH
            // 
            txt_hangKH.Enabled = false;
            txt_hangKH.Location = new Point(440, 51);
            txt_hangKH.Name = "txt_hangKH";
            txt_hangKH.Size = new Size(127, 27);
            txt_hangKH.TabIndex = 20;
            // 
            // QL_KH
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(gb_ttKH);
            Controls.Add(gb_dsKH);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "QL_KH";
            Text = "Danh sách khách hàng";
            Load += Form1_Load;
            gb_dsKH.ResumeLayout(false);
            gb_dsKH.PerformLayout();
            gb_ttKH.ResumeLayout(false);
            gb_ttKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dt_lsKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gb_dsKH;
        private GroupBox gb_ttKH;
        private TextBox txt_timKiemKH;
        private ListBox listBox1;
        private RadioButton rd_GTnu;
        private RadioButton rd_GTnam;
        private TextBox txt_tenKH;
        private TextBox txt_sdtKH;
        private TextBox txt_emailKH;
        private DataGridView dt_lsKH;
        private DataGridViewTextBoxColumn NgayDatBan;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn SoHD;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private Button btn_xoaKH;
        private Button btn_capnhatKH;
        private Button btn_themKH;
        private RadioButton rd_GTkhac;
        private Label label9;
        private TextBox txt_hangKH;
    }
}
