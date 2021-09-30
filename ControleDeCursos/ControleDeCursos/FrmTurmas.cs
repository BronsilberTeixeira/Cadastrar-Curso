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
            dtgTurmas.DataSource = objTurma.ListarTurma();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //CADASTRAR
            objTurma.codigo = int.Parse(txtCodigo.Text);
            objTurma.professor = cbxProfessor.Text;
            objTurma.curso = cbxCurso.Text;
            objTurma.hora_inicio = int.Parse(txtHoraInicio.Text);
            objTurma.hora_termino = int.Parse(txtHoraTermino.Text);
            objTurma.data_inicio = dtpDataInicio.Text;
            objTurma.data_termino = dtpDataTermino.Text;
            objProfessor.CadastraProfessor();
            MessageBox.Show("Registro cadastrado com sucesso!");
            //Limpando os campos
     
            dtgTurmas.DataSource = objTurma.ListarTurma();
        }
    }
}
