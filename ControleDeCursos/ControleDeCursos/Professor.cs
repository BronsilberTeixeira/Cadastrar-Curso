using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCursos
{
    class Professor
    {
        public string nome, telefone, codigo;
        public double valorHora;
        string tabela = "tbl_professor";
        Conexao objConexao = new Conexao();

        public void CadastraProfessor()
        {
            //Passo: comando sql - insert into 
            string inserir = $"insert into {tabela} values " +
                $"('{nome}','{telefone}', '{valorHora}'," +
                $"'{codigo}' )";
            //Passo2: executar o comando sql 
            objConexao.ExecutarComando(inserir);
        }

        public DataTable ListarProfessor()
        {
            //Passo 1- comando sql
            string listar = $"select * from {tabela} order by codigo";
            return objConexao.ExecutarConsulta(listar);
        }

        public void AlterarProfessor()
        {
    
                string alterar = $@"update {tabela} set 
                nome= '{nome}',
                valorHora='{valorHora}',
                telefone='{telefone}' where codigo='{codigo}';";
                objConexao.ExecutarComando(alterar);
        }

        public void ExcluirProfessor()
        {
            string excluir = $"delete from {tabela} where codigo='{codigo}';";
            objConexao.ExecutarComando(excluir);
        }
    }
}
