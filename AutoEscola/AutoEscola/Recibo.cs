using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEscola
{
    public partial class Recibo : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=E904;Initial Catalog=Escola;Integrated Security=True");
        SqlCommand con_cliente;

        public Recibo()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Recibo_Load(object sender, EventArgs e)
        {
            Data.Format = DateTimePickerFormat.Custom;
            Data.CustomFormat = "dd / MMMM / yyyy";
            Data.Value = DateTime.Today;

            sql.Open();
            cbCliente.Items.Clear();
            con_cliente = sql.CreateCommand();
            con_cliente.CommandType = CommandType.Text;
            con_cliente.CommandText = "SELECT Nome FROM tblCliente";
            con_cliente.ExecuteNonQuery();
            DataTable cliente = new DataTable();
            SqlDataAdapter sql3 = new SqlDataAdapter(con_cliente);
            sql3.Fill(cliente);
            foreach (DataRow dr in cliente.Rows)
            {
                cbCliente.Items.Add(dr["Nome"].ToString());
            }
            sql.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        Bitmap bmp;

        private void btPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
