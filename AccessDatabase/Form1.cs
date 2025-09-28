using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AccessDatabase
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ITUTC\KÌ 5\LTTQ\AppDesktop\UTC\Database1.accdb;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Hàm tải dữ liệu từ Access và hiển thị trên DataGridView
        private void LoadData()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Student"; // Kiểm tra tên bảng
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    connection.Close();

                    // Kiểm tra số cột
                    if (dataTable.Columns.Count != 7)
                    {
                        MessageBox.Show($"Số cột không đúng: {dataTable.Columns.Count}/7");
                    }

                    // Đảm bảo hiển thị tất cả cột
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.Columns["ID"].HeaderText = "ID";
                    dataGridView1.Columns["FirstName"].HeaderText = "Tên";
                    dataGridView1.Columns["LastName"].HeaderText = "Họ";
                    dataGridView1.Columns["Address"].HeaderText = "Địa chỉ";
                    dataGridView1.Columns["Class"].HeaderText = "Lớp";
                    dataGridView1.Columns["Age"].HeaderText = "Tuổi";
                    dataGridView1.Columns["Email"].HeaderText = "Email";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
            }
        }

        // Sự kiện khi chọn một dòng trong DataGridView
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    txtId.Text = row.Cells["ID"].Value?.ToString() ?? "";
                    txtFirstName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
                    txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";
                    txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
                    txtClass.Text = row.Cells["Class"].Value?.ToString() ?? "";
                    txtAge.Text = row.Cells["Age"].Value?.ToString() ?? "";
                    txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn dòng: " + ex.Message);
                }
            }
        }

        // Hàm xóa các ô nhập liệu
        private void ClearInputs()
        {
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtClass.Text = "";
            txtAge.Text = "";
            txtEmail.Text = "";
        }

        // Nút Thêm
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtClass.Text) ||
                string.IsNullOrEmpty(txtAge.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Tuổi phải là số nguyên dương!");
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Student (FirstName, LastName, Address, Class, Age, Email) " +
                                  "VALUES (@FirstName, @LastName, @Address, @Class, @Age, @Email)";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);
                    command.Parameters.AddWithValue("@Class", txtClass.Text);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm học sinh thành công!");
                    connection.Close();
                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
            }
        }

        // Nút Sửa
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Vui lòng chọn một học sinh để sửa!");
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Tuổi phải là số nguyên dương!");
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Student SET FirstName = @FirstName, LastName = @LastName, " +
                                  "Address = @Address, Class = @Class, Age = @Age, Email = @Email WHERE ID = @ID";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);
                    command.Parameters.AddWithValue("@Class", txtClass.Text);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@ID", txtId.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật học sinh thành công!");
                    connection.Close();
                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
            }
        }

        // Nút Xóa
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Vui lòng chọn một học sinh để xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa học sinh này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Student WHERE ID = @ID";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", txtId.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa học sinh thành công!");
                    connection.Close();
                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
            }
        }

        // Sự kiện click ô trong DataGridView (chỉ chọn dòng, không xóa)
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtId.Text = row.Cells["ID"].Value?.ToString() ?? "";
                txtFirstName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
                txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
                txtClass.Text = row.Cells["Class"].Value?.ToString() ?? "";
                txtAge.Text = row.Cells["Age"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            }
        }
    }
}