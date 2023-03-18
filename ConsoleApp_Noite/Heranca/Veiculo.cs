﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite.Heranca
{
    public class Veiculo
    {
        public int numeroAssentos;
        public int numeroPortas;
        public bool temMotor;

        public string ExibirDados()
        {
    
            if(temMotor == false)
            {
                return $"Veiculo sem motor, com {numeroAssentos} assento. \n";
            }
            else 
            {
                return $"Veiculo com motor, com {numeroAssentos} assentos e {numeroPortas} portas. \n";
            }
        }
    }
}
