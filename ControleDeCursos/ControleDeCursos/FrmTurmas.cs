using System;
using System.Windows.Forms;

namespace ControleDeCursos
{
    public partial class FrmTurmas : Form
    {
        public FrmTurmas()
        {
            InitializeComponent();
        }
        Curso objCurso = new Curso();
        Professor objProfessor = new Professor();
        Turma objTurma = new Turma();
        private void FrmTurmas_Load(object sender, EventArgs e)
        {
            cbxProfessor.DataSource = objProfessor.ListarProfessor();
            cbxProfessor.ValueMember = "codigo";
            cbxProfessor.DisplayMember = "nome";

            cbxCurso.DataSource = objCurso.Listar();
            cbxCurso.ValueMember = "codigo";
            cbxCurso.DisplayMember = "nome";

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //CADASTRAR
            objTurma.codigo = int.Parse(txtCodigo.Text);
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
    }
}
