using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI
{
    public partial class ConsAlunos : Form
    {
        public int codigo = 0;
        public ConsAlunos()
        {
            InitializeComponent();
        }

        private void btExecutar_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao(@"Data Source=MARANGONI-PC\MSSQLSERVERDEV;Initial Catalog=bdEstSaber;Integrated Security=True");
            DALProjeto dal = new DALProjeto(cx);
            dgDados.DataSource = dal.Localizar(txtValor.Text);
        }

        private void dgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0)
            {
                this.codigo = Convert.ToInt16(dgDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
