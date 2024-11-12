namespace QuanLyNhaHang
{
    partial class QL_NhaHang
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
            menuStrip1 = new MenuStrip();
            đơnĐặtToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            bànSảnhToolStripMenuItem = new ToolStripMenuItem();
            thựcĐơnToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            hiểnThịToolStripMenuItem = new ToolStripMenuItem();
            danhSáchKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            danhSáchThựcĐơnToolStripMenuItem = new ToolStripMenuItem();
            danhSáchNhânViênToolStripMenuItem = new ToolStripMenuItem();
            danhSáchBànSảnhToolStripMenuItem = new ToolStripMenuItem();
            chươngTrìnhKhuyếnMãToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { đơnĐặtToolStripMenuItem, hiểnThịToolStripMenuItem, quảnLýToolStripMenuItem, thốngKêToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1029, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // đơnĐặtToolStripMenuItem
            // 
            đơnĐặtToolStripMenuItem.Checked = true;
            đơnĐặtToolStripMenuItem.CheckState = CheckState.Checked;
            đơnĐặtToolStripMenuItem.Name = "đơnĐặtToolStripMenuItem";
            đơnĐặtToolStripMenuItem.Size = new Size(64, 20);
            đơnĐặtToolStripMenuItem.Text = "Đơn đặt ";
            đơnĐặtToolStripMenuItem.Click += đơnĐặtToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chươngTrìnhKhuyếnMãToolStripMenuItem, thựcĐơnToolStripMenuItem, bànSảnhToolStripMenuItem, nhânViênToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(60, 20);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(180, 22);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // bànSảnhToolStripMenuItem
            // 
            bànSảnhToolStripMenuItem.Name = "bànSảnhToolStripMenuItem";
            bànSảnhToolStripMenuItem.Size = new Size(180, 22);
            bànSảnhToolStripMenuItem.Text = "Bàn / Sảnh";
            // 
            // thựcĐơnToolStripMenuItem
            // 
            thựcĐơnToolStripMenuItem.Name = "thựcĐơnToolStripMenuItem";
            thựcĐơnToolStripMenuItem.Size = new Size(180, 22);
            thựcĐơnToolStripMenuItem.Text = "Thực đơn";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(68, 20);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // hiểnThịToolStripMenuItem
            // 
            hiểnThịToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { danhSáchKháchHàngToolStripMenuItem, danhSáchThựcĐơnToolStripMenuItem, danhSáchNhânViênToolStripMenuItem, danhSáchBànSảnhToolStripMenuItem });
            hiểnThịToolStripMenuItem.Name = "hiểnThịToolStripMenuItem";
            hiểnThịToolStripMenuItem.Size = new Size(61, 20);
            hiểnThịToolStripMenuItem.Text = "Hiển thị";
            // 
            // danhSáchKháchHàngToolStripMenuItem
            // 
            danhSáchKháchHàngToolStripMenuItem.Name = "danhSáchKháchHàngToolStripMenuItem";
            danhSáchKháchHàngToolStripMenuItem.Size = new Size(194, 22);
            danhSáchKháchHàngToolStripMenuItem.Text = "Danh sách khách hàng";
            // 
            // danhSáchThựcĐơnToolStripMenuItem
            // 
            danhSáchThựcĐơnToolStripMenuItem.Name = "danhSáchThựcĐơnToolStripMenuItem";
            danhSáchThựcĐơnToolStripMenuItem.Size = new Size(194, 22);
            danhSáchThựcĐơnToolStripMenuItem.Text = "Danh sách thực đơn";
            // 
            // danhSáchNhânViênToolStripMenuItem
            // 
            danhSáchNhânViênToolStripMenuItem.Name = "danhSáchNhânViênToolStripMenuItem";
            danhSáchNhânViênToolStripMenuItem.Size = new Size(194, 22);
            danhSáchNhânViênToolStripMenuItem.Text = "Danh sách nhân viên";
            // 
            // danhSáchBànSảnhToolStripMenuItem
            // 
            danhSáchBànSảnhToolStripMenuItem.Name = "danhSáchBànSảnhToolStripMenuItem";
            danhSáchBànSảnhToolStripMenuItem.Size = new Size(194, 22);
            danhSáchBànSảnhToolStripMenuItem.Text = "Danh sách bàn / sảnh";
            // 
            // chươngTrìnhKhuyếnMãToolStripMenuItem
            // 
            chươngTrìnhKhuyếnMãToolStripMenuItem.Name = "chươngTrìnhKhuyếnMãToolStripMenuItem";
            chươngTrìnhKhuyếnMãToolStripMenuItem.Size = new Size(210, 22);
            chươngTrìnhKhuyếnMãToolStripMenuItem.Text = "Chương trình khuyến mãi";
            // 
            // QL_NhaHang
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 570);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "QL_NhaHang";
            Text = "QL_NhaHang";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem đơnĐặtToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem hiểnThịToolStripMenuItem;
        private ToolStripMenuItem danhSáchKháchHàngToolStripMenuItem;
        private ToolStripMenuItem danhSáchThựcĐơnToolStripMenuItem;
        private ToolStripMenuItem danhSáchNhânViênToolStripMenuItem;
        private ToolStripMenuItem danhSáchBànSảnhToolStripMenuItem;
        private ToolStripMenuItem bànSảnhToolStripMenuItem;
        private ToolStripMenuItem thựcĐơnToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem chươngTrìnhKhuyếnMãToolStripMenuItem;
    }
}