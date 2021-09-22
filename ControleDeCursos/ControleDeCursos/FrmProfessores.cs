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
            objProfessor.codigo = txtCodigo.Text;
            objProfessor.nome = txtNome.Text;
            objProfessor.valorHora = Double.Parse(txtValorHora.Text);
            objProfessor.telefone = txtTelefone.Text;
            objProfessor.CadastraProfessor();
            MessageBox.Show("Registro cadastrado com sucesso!");
            //Limpando os campos
            txtNome.Clear();
            txtCodigo.Clear();
            txtValorHora.Clear();
            txtTelefone.Clear();
            dtgProfessor.DataSource = objProfessor.ListarProfessor();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //alterar
            objProfessor.codigo = txtCodigo.Text;
            objProfessor.nome = txtNome.Text;
            objProfessor.valorHora = Double.Parse(txtValorHora.Text);
            objProfessor.telefone = txtTelefone.Text;
            objProfessor.AlterarProfessor();
            MessageBox.Show("Registro alterado com sucesso!");
            txtNome.Clear();
            txtCodigo.Clear();
            txtValorHora.Clear();
            txtTelefone.Clear();
            dtgProfessor.DataSource = objProfessor.ListarProfessor();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objProfessor.codigo = txtCodigo.Text;
            objProfessor.ExcluirProfessor();
            MessageBox.Show("Registro Excluido com sucesso!!");
            dtgProfessor.DataSource = objProfessor.ListarProfessor();
        }

        private void dtgProfessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dtgProfessor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgProfessor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtValorHora.Text = dtgProfessor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTelefone.Text = dtgProfessor.Rows[e.RowIndex].Cells[3].Value.ToString();
            //txtCargaHoraria.Text = dtgCursos.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void FrmProfessores_Load(object sender, EventArgs e)
        {
            dtgProfessor.DataSource = objProfessor.ListarProfessor();
        }
    }
}
