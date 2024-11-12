namespace QuanLyNhaHang
{
    partial class QL_NV
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

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtMa = new TextBox();
            txtTen = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnThem1NV = new Button();
            tỉmeCheck = new DateTimePicker();
            btnXoa1NV = new Button();
            btnTim = new Button();
            label5 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            btnReset = new Button();
            btnOut = new Button();
            cbx_ChucVu = new ComboBox();
            txtChucVuNV = new TextBox();
            btnTimNV = new Button();
            btnThem = new Button();
            btnXoaNV = new Button();
            groupBox1 = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label9 = new Label();
            txtSDT = new TextBox();
            btnSua1NV = new Button();
            rdBtnKhac = new RadioButton();
            rdBtnNu = new RadioButton();
            rdBtnNam = new RadioButton();
            label7 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label6 = new Label();
            txtMaCV = new TextBox();
            btnSuaNV = new Button();
            trv_ChucVu = new TreeView();
            groupBox3 = new GroupBox();
            btnTim1NV = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(8, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 35);
            label1.TabIndex = 0;
            label1.Text = "Bảng Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12.75F);
            label2.Location = new Point(8, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên";
            // 
            // txtMa
            // 
            txtMa.Font = new Font("Times New Roman", 12.75F);
            txtMa.Location = new Point(114, 89);
            txtMa.Margin = new Padding(4, 3, 4, 3);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(96, 27);
            txtMa.TabIndex = 2;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Times New Roman", 12.75F);
            txtTen.Location = new Point(114, 142);
            txtTen.Margin = new Padding(4, 3, 4, 3);
            txtTen.Name = "txtTen";
            txtTen.PlaceholderText = "Nhập tên";
            txtTen.Size = new Size(349, 27);
            txtTen.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12.75F);
            label3.Location = new Point(8, 145);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 19);
            label3.TabIndex = 3;
            label3.Text = "Tên nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12.75F);
            label4.Location = new Point(224, 92);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 19);
            label4.TabIndex = 5;
            label4.Text = "Chức vụ";
            // 
            // btnThem1NV
            // 
            btnThem1NV.Font = new Font("Times New Roman", 12.75F);
            btnThem1NV.Location = new Point(10, 569);
            btnThem1NV.Margin = new Padding(4, 3, 4, 3);
            btnThem1NV.Name = "btnThem1NV";
            btnThem1NV.Size = new Size(73, 35);
            btnThem1NV.TabIndex = 8;
            btnThem1NV.Text = "Thêm";
            btnThem1NV.UseVisualStyleBackColor = true;
            btnThem1NV.Click += btnThem1NV_Click;
            // 
            // tỉmeCheck
            // 
            tỉmeCheck.Font = new Font("Times New Roman", 12.75F);
            tỉmeCheck.Location = new Point(8, 306);
            tỉmeCheck.Margin = new Padding(4, 3, 4, 3);
            tỉmeCheck.Name = "tỉmeCheck";
            tỉmeCheck.Size = new Size(165, 27);
            tỉmeCheck.TabIndex = 9;
            // 
            // btnXoa1NV
            // 
            btnXoa1NV.Font = new Font("Times New Roman", 12.75F);
            btnXoa1NV.Location = new Point(224, 568);
            btnXoa1NV.Margin = new Padding(4, 3, 4, 3);
            btnXoa1NV.Name = "btnXoa1NV";
            btnXoa1NV.Size = new Size(73, 35);
            btnXoa1NV.TabIndex = 10;
            btnXoa1NV.Text = "Xoá";
            btnXoa1NV.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            btnTim.Font = new Font("Times New Roman", 12.75F);
            btnTim.Location = new Point(340, 449);
            btnTim.Margin = new Padding(4, 3, 4, 3);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(123, 62);
            btnTim.TabIndex = 11;
            btnTim.Text = "Tìm theo ca";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12.75F);
            label5.Location = new Point(8, 284);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 19);
            label5.TabIndex = 12;
            label5.Text = "Ngày vào làm";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 12.75F);
            checkBox1.Location = new Point(45, 391);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(93, 23);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "7H - 15H";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Times New Roman", 12.75F);
            checkBox2.Location = new Point(178, 391);
            checkBox2.Margin = new Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(102, 23);
            checkBox2.TabIndex = 14;
            checkBox2.Text = "15H - 23H";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Times New Roman", 7.8F);
            btnReset.Location = new Point(32, 695);
            btnReset.Margin = new Padding(4, 3, 4, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(123, 35);
            btnReset.TabIndex = 20;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnOut
            // 
            btnOut.Font = new Font("Times New Roman", 7.8F);
            btnOut.Location = new Point(219, 695);
            btnOut.Margin = new Padding(4, 3, 4, 3);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(123, 35);
            btnOut.TabIndex = 21;
            btnOut.Text = "Quit";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // cbx_ChucVu
            // 
            cbx_ChucVu.Font = new Font("Times New Roman", 12.75F);
            cbx_ChucVu.FormattingEnabled = true;
            cbx_ChucVu.Location = new Point(296, 89);
            cbx_ChucVu.Margin = new Padding(4, 3, 4, 3);
            cbx_ChucVu.Name = "cbx_ChucVu";
            cbx_ChucVu.Size = new Size(167, 27);
            cbx_ChucVu.TabIndex = 22;
            // 
            // txtChucVuNV
            // 
            txtChucVuNV.Font = new Font("Times New Roman", 12.75F);
            txtChucVuNV.Location = new Point(113, 73);
            txtChucVuNV.Margin = new Padding(4, 3, 4, 3);
            txtChucVuNV.Name = "txtChucVuNV";
            txtChucVuNV.PlaceholderText = "Nhập chức vụ";
            txtChucVuNV.Size = new Size(412, 27);
            txtChucVuNV.TabIndex = 24;
            // 
            // btnTimNV
            // 
            btnTimNV.Font = new Font("Times New Roman", 12.75F);
            btnTimNV.Location = new Point(383, 119);
            btnTimNV.Margin = new Padding(4, 3, 4, 3);
            btnTimNV.Name = "btnTimNV";
            btnTimNV.Size = new Size(142, 35);
            btnTimNV.TabIndex = 26;
            btnTimNV.Text = "Tìm theo chức vụ";
            btnTimNV.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12.75F);
            btnThem.Location = new Point(8, 119);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 35);
            btnThem.TabIndex = 25;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaNV
            // 
            btnXoaNV.Font = new Font("Times New Roman", 12.75F);
            btnXoaNV.Location = new Point(258, 119);
            btnXoaNV.Margin = new Padding(4, 3, 4, 3);
            btnXoaNV.Name = "btnXoaNV";
            btnXoaNV.Size = new Size(86, 35);
            btnXoaNV.TabIndex = 27;
            btnXoaNV.Text = "Xoá";
            btnXoaNV.UseVisualStyleBackColor = true;
            btnXoaNV.Click += btnXoaNV_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTim1NV);
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox6);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(btnSua1NV);
            groupBox1.Controls.Add(rdBtnKhac);
            groupBox1.Controls.Add(rdBtnNu);
            groupBox1.Controls.Add(rdBtnNam);
            groupBox1.Controls.Add(cbx_ChucVu);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tỉmeCheck);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnTim);
            groupBox1.Controls.Add(btnXoa1NV);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(btnThem1NV);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 14);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(479, 654);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Times New Roman", 12.75F);
            checkBox5.Location = new Point(178, 459);
            checkBox5.Margin = new Padding(4, 3, 4, 3);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(102, 23);
            checkBox5.TabIndex = 31;
            checkBox5.Text = "14H - 18H";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Times New Roman", 12.75F);
            checkBox6.Location = new Point(178, 488);
            checkBox6.Margin = new Padding(4, 3, 4, 3);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(102, 23);
            checkBox6.TabIndex = 32;
            checkBox6.Text = "18H - 23H";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Times New Roman", 12.75F);
            checkBox3.Location = new Point(45, 459);
            checkBox3.Margin = new Padding(4, 3, 4, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(93, 23);
            checkBox3.TabIndex = 29;
            checkBox3.Text = "7H - 10H";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Times New Roman", 12.75F);
            checkBox4.Location = new Point(45, 488);
            checkBox4.Margin = new Padding(4, 3, 4, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(102, 23);
            checkBox4.TabIndex = 30;
            checkBox4.Text = "10H - 14H";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(8, 430);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(92, 23);
            radioButton2.TabIndex = 28;
            radioButton2.TabStop = true;
            radioButton2.Text = "Part-time";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(7, 362);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(91, 23);
            radioButton1.TabIndex = 27;
            radioButton1.TabStop = true;
            radioButton1.Text = "Full-time";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12.75F);
            label9.Location = new Point(8, 242);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(99, 19);
            label9.TabIndex = 25;
            label9.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Times New Roman", 12.75F);
            txtSDT.Location = new Point(114, 239);
            txtSDT.Margin = new Padding(4, 3, 4, 3);
            txtSDT.Name = "txtSDT";
            txtSDT.PlaceholderText = "Nhập số điện thoại";
            txtSDT.Size = new Size(349, 27);
            txtSDT.TabIndex = 26;
            // 
            // btnSua1NV
            // 
            btnSua1NV.Font = new Font("Times New Roman", 12.75F);
            btnSua1NV.Location = new Point(117, 569);
            btnSua1NV.Margin = new Padding(4, 3, 4, 3);
            btnSua1NV.Name = "btnSua1NV";
            btnSua1NV.Size = new Size(73, 35);
            btnSua1NV.TabIndex = 24;
            btnSua1NV.Text = "Sửa";
            btnSua1NV.UseVisualStyleBackColor = true;
            // 
            // rdBtnKhac
            // 
            rdBtnKhac.AutoSize = true;
            rdBtnKhac.Font = new Font("Times New Roman", 12.75F);
            rdBtnKhac.Location = new Point(291, 194);
            rdBtnKhac.Margin = new Padding(4, 3, 4, 3);
            rdBtnKhac.Name = "rdBtnKhac";
            rdBtnKhac.Size = new Size(62, 23);
            rdBtnKhac.TabIndex = 23;
            rdBtnKhac.TabStop = true;
            rdBtnKhac.Text = "Khác";
            rdBtnKhac.UseVisualStyleBackColor = true;
            // 
            // rdBtnNu
            // 
            rdBtnNu.AutoSize = true;
            rdBtnNu.Font = new Font("Times New Roman", 12.75F);
            rdBtnNu.Location = new Point(208, 194);
            rdBtnNu.Margin = new Padding(4, 3, 4, 3);
            rdBtnNu.Name = "rdBtnNu";
            rdBtnNu.Size = new Size(48, 23);
            rdBtnNu.TabIndex = 22;
            rdBtnNu.TabStop = true;
            rdBtnNu.Text = "Nữ";
            rdBtnNu.UseVisualStyleBackColor = true;
            // 
            // rdBtnNam
            // 
            rdBtnNam.AutoSize = true;
            rdBtnNam.Font = new Font("Times New Roman", 12.75F);
            rdBtnNam.Location = new Point(114, 194);
            rdBtnNam.Margin = new Padding(4, 3, 4, 3);
            rdBtnNam.Name = "rdBtnNam";
            rdBtnNam.Size = new Size(59, 23);
            rdBtnNam.TabIndex = 21;
            rdBtnNam.TabStop = true;
            rdBtnNam.Text = "Nam";
            rdBtnNam.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12.75F);
            label7.Location = new Point(8, 196);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 19);
            label7.TabIndex = 20;
            label7.Text = "Giới tính";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtMaCV);
            groupBox2.Controls.Add(btnSuaNV);
            groupBox2.Controls.Add(txtChucVuNV);
            groupBox2.Controls.Add(btnTimNV);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnXoaNV);
            groupBox2.Font = new Font("Times New Roman", 12.75F);
            groupBox2.Location = new Point(518, 14);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(533, 169);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức vụ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12.75F);
            label8.Location = new Point(8, 76);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(90, 19);
            label8.TabIndex = 29;
            label8.Text = "Tên chức vụ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12.75F);
            label6.Location = new Point(7, 29);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(87, 19);
            label6.TabIndex = 25;
            label6.Text = "Mã chức vụ";
            // 
            // txtMaCV
            // 
            txtMaCV.Font = new Font("Times New Roman", 12.75F);
            txtMaCV.Location = new Point(113, 26);
            txtMaCV.Margin = new Padding(4, 3, 4, 3);
            txtMaCV.Name = "txtMaCV";
            txtMaCV.Size = new Size(106, 27);
            txtMaCV.TabIndex = 26;
            // 
            // btnSuaNV
            // 
            btnSuaNV.Font = new Font("Times New Roman", 12.75F);
            btnSuaNV.Location = new Point(133, 119);
            btnSuaNV.Margin = new Padding(4, 3, 4, 3);
            btnSuaNV.Name = "btnSuaNV";
            btnSuaNV.Size = new Size(86, 35);
            btnSuaNV.TabIndex = 28;
            btnSuaNV.Text = "Sửa";
            btnSuaNV.UseVisualStyleBackColor = true;
            // 
            // trv_ChucVu
            // 
            trv_ChucVu.Font = new Font("Times New Roman", 12.75F);
            trv_ChucVu.Location = new Point(7, 25);
            trv_ChucVu.Margin = new Padding(4, 3, 4, 3);
            trv_ChucVu.Name = "trv_ChucVu";
            trv_ChucVu.Size = new Size(519, 455);
            trv_ChucVu.TabIndex = 30;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(trv_ChucVu);
            groupBox3.Location = new Point(518, 183);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(534, 486);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách nhân viên";
            // 
            // btnTim1NV
            // 
            btnTim1NV.Font = new Font("Times New Roman", 12.75F);
            btnTim1NV.Location = new Point(331, 569);
            btnTim1NV.Margin = new Padding(4, 3, 4, 3);
            btnTim1NV.Name = "btnTim1NV";
            btnTim1NV.Size = new Size(134, 35);
            btnTim1NV.TabIndex = 33;
            btnTim1NV.Text = "Tìm nhân viên";
            btnTim1NV.UseVisualStyleBackColor = true;
            // 
            // QL_NV
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnOut);
            Controls.Add(btnReset);
            Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "QL_NV";
            Text = "Quản lý nhân viên";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Label label1;
        private Label label2;
        private TextBox txtMa;
        private TextBox txtTen;
        private Label label3;
        private Label label4;
        private Button btnThem1NV;
        private DateTimePicker tỉmeCheck;
        private Button btnXoa1NV;
        private Button btnTim;
        private Label label5;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button btnReset;
        private Button btnOut;
        private ComboBox cbx_ChucVu;
        private TextBox txtChucVuNV;
        private Button btnTimNV;
        private Button btnThem;
        private Button btnXoaNV;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TreeView trv_ChucVu;
        private Label label7;
        private RadioButton rdBtnNu;
        private RadioButton rdBtnNam;
        private RadioButton rdBtnKhac;
        private GroupBox groupBox3;
        private Button btnSua1NV;
        private Button btnSuaNV;
        private Label label8;
        private Label label6;
        private TextBox txtMaCV;
        private Label label9;
        private TextBox txtSDT;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Button btnTim1NV;
    }
}