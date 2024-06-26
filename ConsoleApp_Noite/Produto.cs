﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite
{
    public class Produto
    {
        private int Id;
        private decimal Valor;
        private string Descricao;

        public Produto(int id, decimal valor, string descricao) 
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
        }

        public int getId()
        {
             return Id;
        }
        public decimal getValor()
        {
            return Valor;
        }
        public string getDescricao()
        {
            return Descricao;   
        }

        public void setId(int id)
        {
            Id = id;
        }
        public void setValor(decimal valor)
        {
            Valor = valor;
        }
        public void setDescricao(string descricao)
        {
            Descricao = descricao;
        }
    }
}
