﻿
namespace ControleDeCursos
{
    partial class FrmTurmas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpDataTermino = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dtgTurmas = new System.Windows.Forms.DataGridView();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.txtHoraTermino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.cbxProfessor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTurmas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(116, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código da Turma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data de Término:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data de Início:";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(116, 40);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(100, 20);
            this.dtpDataInicio.TabIndex = 15;
            // 
            // dtpDataTermino
            // 
            this.dtpDataTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataTermino.Location = new System.Drawing.Point(347, 40);
            this.dtpDataTermino.Name = "dtpDataTermino";
            this.dtpDataTermino.Size = new System.Drawing.Size(100, 20);
            this.dtpDataTermino.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hora de Início:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hora: de Término:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Location = new System.Drawing.Point(15, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 57);
            this.panel1.TabIndex = 21;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(27, 13);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(90, 30);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "CADASTRAR ";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(123, 13);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 30);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(318, 13);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 30);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(222, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 30);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dtgTurmas
            // 
            this.dtgTurmas.BackgroundColor = System.Drawing.Color.White;
            this.dtgTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTurmas.Location = new System.Drawing.Point(15, 228);
            this.dtgTurmas.Name = "dtgTurmas";
            this.dtgTurmas.Size = new System.Drawing.Size(432, 150);
            this.dtgTurmas.TabIndex = 22;
            this.dtgTurmas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTurmas_CellContentClick);
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(116, 78);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(100, 20);
            this.txtHoraInicio.TabIndex = 23;
            // 
            // txtHoraTermino
            // 
            this.txtHoraTermino.Location = new System.Drawing.Point(347, 78);
            this.txtHoraTermino.Name = "txtHoraTermino";
            this.txtHoraTermino.Size = new System.Drawing.Size(100, 20);
            this.txtHoraTermino.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Curso:";
            // 
            // cbxCurso
            // 
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Location = new System.Drawing.Point(347, 5);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(100, 21);
            this.cbxCurso.TabIndex = 26;
            // 
            // cbxProfessor
            // 
            this.cbxProfessor.FormattingEnabled = true;
            this.cbxProfessor.Location = new System.Drawing.Point(116, 114);
            this.cbxProfessor.Name = "cbxProfessor";
            this.cbxProfessor.Size = new System.Drawing.Size(100, 21);
            this.cbxProfessor.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Professor(a):";
            // 
            // FrmTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 394);
            this.Controls.Add(this.cbxProfessor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHoraTermino);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.dtgTurmas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDataTermino);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "FrmTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protótipo - TURMAS";
            this.Load += new System.EventHandler(this.FrmTurmas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTurmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.DateTimePicker dtpDataTermino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dtgTurmas;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.TextBox txtHoraTermino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.ComboBox cbxProfessor;
        private System.Windows.Forms.Label label7;
    }
}