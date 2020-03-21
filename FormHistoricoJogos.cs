using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class frmHistoricoJogos : Form
    {
        public frmHistoricoJogos()
        {
            InitializeComponent();
        }

        private void frmHistoricoJogos_Load(object sender, EventArgs e)
        {
            ShowHistory();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            DialogResult result;
            result = MessageBox.Show("Tens a certeza que queres apagar os dados?", "Apagar Histórico de Jogos", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) //Caso o utilizador selecione 'Sim', o ficheiro será apagado
            {
                System.IO.File.Delete(Variaveis.filePath);
                ShowHistory();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowHistory()
        {
            try
            {
                richTextBox1.Text = System.IO.File.ReadAllText(Variaveis.filePath); //O conteúdo da Caixa de Texto deverá ser igual ao Texto guardado no ficheiro HistoricoJogos.txt
            }
            catch //Caso não seja possivel carregar o ficheiro, o conteúdo da caixa de texto vai ser o seguinte:
            {
                richTextBox1.Text = "\n\n\n\n\n\n\n\n\n\n\n\n\n Não foi possivel carregar o histórico de jogos ou este está vazio!";
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //Tentar abrir o ficheiro
            try 
            {
                System.Diagnostics.Process.Start(Variaveis.filePath);
            }
            catch //Caso não seja possivel abrir o ficheiro será mostrada uma MessageBox
            {
                MessageBox.Show("Não foi possivel abrir o ficheiro!", "Erro");
            }
        }
    }
}
