using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD
{
    class UsuarioAplicacao
    {
        private bd bd;

        public void insert( string nome, string cargo, string data)
        {
            var strQuery = "";
            strQuery += "INSERT INTO usuarios (nome, cargo, data)";
            strQuery += string.Format(" VALUES ('{0}', '{1}', '{2}')", nome, cargo, data);
            using (bd = new ConexaoBD.bd())
            {
                bd.ExecutaComando(strQuery);
            }
        }
    }
}
