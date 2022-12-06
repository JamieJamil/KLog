using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace KørselsLog
{
    public partial class Form1 : Form
    {

        //SqlConnection con = new SqlConnection("Server=tcp:klserver.database.windows.net,1433;Initial Catalog=KørselsLogDB;Persist Security Info=False;User ID=AdminKL;Password=Passw0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //SqlConnection con2 = new SqlConnection(@"Data Source = 192.168.23.132,1433\SQLEXPRESS;User ID = sa; Password=Passw0rd;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=KørselsLogDB");

        SqlConnection con;
        public Form1(string connectionString)
        {
            con = new SqlConnection(connectionString);
            con.Close();
            InitializeComponent();
            ShowList();
            ShowLogData();
            ShowComboBox();
        }

        public bool IsConnection
        {
            get 
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                con.Close();
                return true;
            }
        }

        #region DragForm
        // Kode der gør at man kan dragge programmet rundt 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        #endregion
        #region CancelBtn
        private void CancelBtn1_Click(object sender, EventArgs e)
        {
            // Sletter det der er i textboxende efter der bliver trykket cancel.
            NavnTB1.Text = "";
            PladeTB1.Text = "";

            // Gør at navne textboxen er i focus efter der bliver trykket cancel.
            NavnTB1.Focus();
        }
        private void CancelBtn2_Click(object sender, EventArgs e)
        {
            NavnTB2.Text = "";
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
            PladeTB4.Text = "";
            OpgaveTB4.Text = "";

            NavnTB4.Focus();
        }
        #endregion
        #region OkBtn
        private void OkBtn1_Click(object sender, EventArgs e)
        {
            // Sørger for at programmet ikke acceptere intet input fra bruger.
            if(NavnTB1.Text == "" || PladeTB1.Text == "")
            {
                // Pop up fejlmeddelelse.
                MessageBox.Show("Alle felter skal udfyldes");
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(NavnTB1.Text, "^[a-zA-Z ]"))
            {
                // Pop up fejlmeddelelse.
                MessageBox.Show("Ugyldigt tegn i navnefeltet");
            }

            // Brugeren indtaster korrekt.
            else 
            {
                // Strings til textboxe.
                string navn = NavnTB1.Text, nummerPlade = PladeTB1.Text, dato = DatoBox1.Text;
                // Åbner connection.
                
                con.Open();

                // Executer SQL command som gemmer brugerens input til databasen.
                SqlCommand cmd = new SqlCommand("EXEC InsertData '" + navn + "','" + dato + "','" + nummerPlade + "'", con);
                cmd.ExecuteNonQuery();

                // Pop up for at brugeren ved at det blev indsat korrekt.
                MessageBox.Show("Bruger registreret");
                // Efter input er blevet gemt, slettes input i textboxende
                NavnTB1.Clear();
                PladeTB1.Clear();
                NavnTB1.Focus();
                con.Close();
                // Viser opdateret database.
                ShowList();
                // Viser input fra databasen i combox. 
                ShowComboBox();
            }
        }

        private void OkBtn2_Click(object sender, EventArgs e)
        {
            if (NavnTB2.Text == "" || PladeTB2.Text == "")
            {
                MessageBox.Show("Alle felter skal udfyldes");
            }
            else
            {
                string navn = NavnTB2.Text, nummerPlade = PladeTB2.Text, dato = DatoBox2.Text;
                con.Open();

                SqlCommand cmd = new SqlCommand("EXEC UpdateData '" + navn + "','" + dato + "','" + nummerPlade + "'", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data opdateret");
                con.Close();
                ShowList();
            }
        }

        private void OkBtn3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Er du sikker på at du vil slette brugeren fra databasen?", "Slet data", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                string navn = NavnTB3.Text;

                con.Open();

                SqlCommand cmd = new SqlCommand("EXEC DeleteData '" + navn + "'", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data slettet");
                con.Close();
                ShowList();
                ShowComboBox();
            }
        }

        private void OkBtn4_Click(object sender, EventArgs e)
        {
            if (NavnTB4.Text == "" || PladeTB4.Text == "" || OpgaveTB4.Text == "")
            {
                MessageBox.Show("Alle felter skal udfyldes");
            }
            else
            {
                string navn = NavnTB4.Text, nummerPlade = PladeTB4.Text, dato = DatoBox4.Text, opgave = OpgaveTB4.Text;
                con.Open();

                SqlCommand cmd = new SqlCommand("EXEC InsertKL '" + navn + "','" + dato + "','" + nummerPlade + "', '" + opgave + "'", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("KørselsLog registreret");
                PladeTB4.Clear();
                OpgaveTB4.Clear();
                NavnTB4.Focus();
                con.Close();
                ShowLogData();
            }
        }
        #endregion
        #region ShowCommands
        void ShowList()
        {
            // Executer SQL command for at vise databasen i et GridView.
            SqlCommand cmd = new SqlCommand("EXEC ListData", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void ShowLogData()
        {
            // Executer SQL command for at vise databasen i et GridView.
            SqlCommand cmd = new SqlCommand("EXEC ListKL", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        void ShowComboBox()
        {
            con.Open();
            // Command for at kunne vælge navn fra databasen i en combobox.
            SqlCommand sc = new SqlCommand("SELECT (NAVN) FROM KLData", con);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            // Ændre alle comboboxe til det samme navn.
            NavnTB2.ValueMember = "Navn";
            NavnTB2.DataSource = dt;
            NavnTB3.ValueMember = "Navn";
            NavnTB3.DataSource = dt;
            NavnTB4.ValueMember = "Navn";
            NavnTB4.DataSource = dt;
            con.Close();
        }
        #endregion
        #region NavneSelectedTB
        private void NavnTB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kode for at når brugeren vælger et navn vil nummerpladen der passer til komme automatisk ind.
            SqlCommand cmd = new SqlCommand("SELECT * FROM KLData WHERE Navn ='" + NavnTB2.Text + "'", con);
            con.Close();
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string? plade = dr["NummerPlade"].ToString();
                PladeTB2.Text = plade;
            }
            con.Close();
        }

        private void NavnTB4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KLData WHERE Navn ='" + NavnTB4.Text + "'", con);
            con.Close();
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string? plade = dr["NummerPlade"].ToString();
                PladeTB4.Text = plade;
            }
            con.Close();
        }
        #endregion
        #region Exit&Minimize
        // Kode der gør at man kan lukke programmet ved at trykke på x oppe i højre hjørne af programmet.
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            con.Close();
        }
        // Kode for at minimere programmet ved at trykke på - oppe i
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Labels
        private void label1_Click(object sender, EventArgs e)
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        #endregion
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void NavnTB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PladeTB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatoBox1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}