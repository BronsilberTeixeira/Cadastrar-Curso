using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCursos
{
    class Turma
    {
        public int codigo, hora_inicio, hora_termino;
        public string data_inicio, data_termino, professor;
        string tabela = "tbl_turma";
        Conexao objConexao = new Conexao();

        public void CadastraTurma()
        {
            //Passo: comando sql - insert into 
            string inserir = $"insert into {tabela} values " +
                $"('{codigo}','{data_inicio}', '{data_termino}'," +
                $"'{professor}', '{hora_inicio}', '{hora_termino}' )";
            //Passo2: executar o comando sql 
            objConexao.ExecutarComando(inserir);
        }

        public DataTable ListarTurma()
        {
            //Passo 1- comando sql
            string listar = $"select * from {tabela} order by codigo";
            return objConexao.ExecutarConsulta(listar);
        }

        public void AlterarTurma()
        {

            string alterar = $@"update {tabela} set 
                codigo= '{codigo}',
                data_inicio='{data_inicio}',
                data_termino='{data_termino}',
                professor='{professor}',
                hora_inicio='{hora_inicio}',
                hora_termino='{hora_termino}' where codigo='{codigo}';";
            objConexao.ExecutarComando(alterar);
        }

        public void ExcluirTurma()
        {
            string excluir = $"delete from {tabela} where codigo='{codigo}';";
            objConexao.ExecutarComando(excluir);
        }
    }
}
