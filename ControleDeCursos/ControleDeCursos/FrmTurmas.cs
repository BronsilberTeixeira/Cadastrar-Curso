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
            comboboxProfessor.DataSource = listarProfessor();
            comboboxProfessor.ValueMember = "codigo";
            comboboxProfessor.DisplayMember = "nome";
        }
    }
}
