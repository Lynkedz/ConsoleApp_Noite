using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite
{
    public class Endereco
    {
        private string Rua;
        private string Numero;
        private string Cep;
        private string Bairro;
        private string Cidade;
        private string Estado;

        public Endereco(string rua, string numero, string cep, string bairro, string cidade, string estado) 
        {
            Rua = rua;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
        public void setRua(string rua)
        {
            Rua = rua;
        }   
        public void setNumero(string numero)
        {
            Numero = numero;
        }
        public void setCep(string cep)
        {
            Cep = cep;
        }
        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }
        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }
        public void setEstado(string estado)
        {
            Estado = estado;
        }
        public string getRua()
        {
            return Rua;
        }
        public string getNumero()
        {
            return Numero;
        }
        public string getCeP(string cep)
        {
            return Cep;
        }
        public string getBairro(string bairro)
        {
            return Bairro;
        }
        public string getCidade(string cidade)
        {
            return Cidade;
        }
        public string getEstado(string estado)
        {
            return Estado;
        }

        public string EnderecoCompleto()
        {
            return $"{Rua} +  + {Numero} + Bairro : + {Bairro} + Cidade: + {Cidade} + Cep:  + {Cep} + Estado + {Estado}";
        }
        public Endereco BuscaPorCep(string cep)
        {
            return new Endereco("", "", "", cep, "", "");
        }
        public string EstadoPorCidade(string estado)
        {
            if(estado == "XX")
            {

            }
            return estado;
        }
        public void InserirNoBanco(Endereco endereco)
        {
            /*db.ENDERECO.ADD(endereco)
            db.savechanges();*/
        }
    }

}
