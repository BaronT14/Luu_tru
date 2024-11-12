namespace QuanLyNhaHang
{
    public partial class QL_NV : Form
    {
        public QL_NV()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đóng form?", "Quản lý nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
        //Kiểm tra trùng chức vụ nhân viên
        public bool kiemtra(string a)
        {
            foreach (TreeNode s in trv_ChucVu.Nodes)
            {

                if (String.Compare(s.Text, a, StringComparison.OrdinalIgnoreCase) == 0)
                    return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] pb = { "Phục vụ", "Quản lí", "Đầu Bếp", "Bảo vệ" };
            foreach (string s in pb)
            {
                trv_ChucVu.Nodes.Add(s);
                cbx_ChucVu.Items.Add(s);
            }
            cbx_ChucVu.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mã chức vụ sẽ được tạo tự động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if ((txtChucVuNV.Text.Length) == 0)
            {
                MessageBox.Show("Không được để trống!");
            }
            else if (kiemtra(txtChucVuNV.Text))
            {
                trv_ChucVu.Nodes.Add(txtChucVuNV.Text);
                cbx_ChucVu.Items.Add(txtChucVuNV.Text);
            }
            else
            {
                MessageBox.Show("Chức vụ hay vị trí này đã tồn tại!");
                txtChucVuNV.Text = "";
                txtChucVuNV.Focus();
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (trv_ChucVu.SelectedNode != null)
                {
                    cbx_ChucVu.Items.Remove(trv_ChucVu.SelectedNode.Text);
                    trv_ChucVu.Nodes.Remove(trv_ChucVu.SelectedNode);
                }

            }
        }

        private void btnThem1NV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mã nhân viên sẽ được tạo tự động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int index = -1;
            foreach (TreeNode n in trv_ChucVu.Nodes)
            {
                if (n.Text == cbx_ChucVu.Text)
                {
                    index = n.Index;
                    break;

                }

            }
            trv_ChucVu.Nodes[index].Nodes.Add(txtTen.Text + "(" + txtMa.Text + ")");
            trv_ChucVu.ExpandAll();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();

        }
    }
}