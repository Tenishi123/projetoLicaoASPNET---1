using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projetoLicaoASPNET___1.BLL
{
    public class Cliente
    {

        private int codUsuario;
        private string nome, email, endereco, cpf;

        public int CodUsuario { get => codUsuario; set => codUsuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Cpf { get => cpf; set => cpf = value; }
    }
}