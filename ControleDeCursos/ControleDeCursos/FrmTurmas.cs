﻿using System;
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
            cbxProfessor.DataSource = objProfessor.ListarProfessor();
            cbxProfessor.ValueMember = "codigo";
            cbxProfessor.DisplayMember = "nome";

            cbxCurso.DataSource = objCurso.Listar();
            cbxCurso.ValueMember = "codigo";
            cbxCurso.DisplayMember = "nome";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
