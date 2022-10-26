using System.Data;
using System.Data.SqlClient;

namespace KørselsLog
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Server = tcp:klserver.database.windows.net, 1433; Initial Catalog = KørselsLogDB; Persist Security Info=False;User ID = AdminKL; Password=Passw0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            ShowData();
        }

        public void ShowData()
        {
            adpt = new SqlDataAdapter("SELECT * FROM [Table]", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        #region CancelBtn
        private void CancelBtn1_Click(object sender, EventArgs e)
        {
            NavnTB1.Text = "";
            DatoTB1.Text = "";
            PladeTB1.Text = "";

            NavnTB1.Focus();
        }
        private void CancelBtn2_Click(object sender, EventArgs e)
        {
            NavnTB2.Text = "";
            DatoTB2.Text = "";
            PladeTB2.Text = "";

            NavnTB2.Focus();
        }

        private void CancelBtn3_Click(object sender, EventArgs e)
        {
            NavnTB3.Text = "";

            NavnTB3.Focus();
        }

        private void CancelBtn4_Click(object sender, EventArgs e)
        {
            NavnTB4.Text = "";
            DatoTB4.Text = "";
            PladeTB4.Text = "";
            OpgaveTB4.Text = "";

            NavnTB4.Focus();
        }
        #endregion
        #region OkBtn
        private void OkBtn1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand com = new SqlCommand("INSERT INTO [Table] VALUES('"+NavnTB1.Text+"', '"+PladeTB1.Text+"')", con);
            com.ExecuteNonQuery();

            MessageBox.Show("Bruger registreret");

            con.Close();
            ShowData();
        }

        private void OkBtn2_Click(object sender, EventArgs e)
        {

        }

        private void OkBtn3_Click(object sender, EventArgs e)
        {

        }

        private void OkBtn4_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void NavnTB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PladeTB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NavnTB2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}