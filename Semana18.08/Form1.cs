using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana18._08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void carrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._semana18_08bddDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela '_semana18_08bddDataSet.Nomes'. Você pode movê-la ou removê-la conforme necessário.
            this.nomesTableAdapter.Fill(this._semana18_08bddDataSet.Nomes);
            // TODO: esta linha de código carrega dados na tabela '_semana18_08bddDataSet.Jogos'. Você pode movê-la ou removê-la conforme necessário.
            this.jogosTableAdapter.Fill(this._semana18_08bddDataSet.Jogos);
            // TODO: esta linha de código carrega dados na tabela '_semana18_08bddDataSet.Carros'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.Fill(this._semana18_08bddDataSet.Carros);

        }
    }
}
