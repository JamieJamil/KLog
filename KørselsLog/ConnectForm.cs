using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KørselsLog
{
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string azureServer = string.Format("Server = tcp:klserver.database.windows.net,1433; Initial Catalog = KørselsLogDB; Persist Security Info = False; User ID = AdminKL; Password = Passw0rd; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ");
            Form1 newForm = new Form1(azureServer);
            if (newForm.IsConnection)
            newForm.ShowDialog();

            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string sqlServer = string.Format(@"Data Source = 192.168.23.132,1433\SQLEXPRESS;User ID = sa; Password=Passw0rd;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=KørselsLogDB");
            Form1 newForm = new Form1(sqlServer);
            if (newForm.IsConnection)
            newForm.ShowDialog();

            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
