using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeCursos
{
    public partial class FrmProfessores : Form
    {
        public FrmProfessores()
        {
            InitializeComponent();
        }

        Professor objProfessor = new Professor();
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //CADASTRAR
            objProfessor.nome = txtNomeCompleto.Text;
            objProfessor.codigo = txtCodigo.Text;
            objProfessor.valorHora = Double.Parse(txtValorHora.Text);
            objProfessor.telefone = txtTelefone.Text;
            objProfessor.CadastraProfessor();
            MessageBox.Show("Registro cadastrado com sucesso!");
            //Limpando os campos
            txtNomeCompleto.Clear();
            txtCodigo.Clear();
            txtValorHora.Clear();
            txtTelefone.Clear();
            dtgProfessor.DataSource = objProfessor.ListarProfessor();
        }


    }
}
