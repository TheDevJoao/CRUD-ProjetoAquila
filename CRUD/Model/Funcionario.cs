using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Model
{
    public class Funcionario
    {
        public int FuncionarioID { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cargo { get; set; }
        public DateTime Admissao { get; set; }
        public float Salario { get; set; }

        public string TodosDados
        {
            get
            {
                return $"{ Nome } { Sexo } { CPF } { RG } { Email } { Nascimento } { Endereco }" +
                $"{ Telefone} { Cargo } { Admissao } { Salario }";
            }
        }
    }
}
