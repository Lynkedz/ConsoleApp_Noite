using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite
{
    public class Venda
    {
        private int Id;
        private string Data;
        private List<Produto> Produtos;

        public Venda(int id, string data, List<Produto> produtos)
        {
            Id = id;
            Data = data;
            Produtos = produtos;
        }

        public void setId(int id)
        {
            Id = id;
        }
        public int getId()
        {
            return Id;
        }
        public string ImprimirDados()
        {
            return $"Id da venda: {Id} Data da venda: {Data} Produtos Comprados:";
            
        } 
    }

}
