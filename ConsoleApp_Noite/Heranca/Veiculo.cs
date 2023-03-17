using System;
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
                return $"Assentos: {numeroAssentos} \n N° Portas: {numeroPortas}";
            }
            else 
            {
                return $"Com motor   Assentos: {numeroAssentos} N° Portas: {numeroPortas}";
            }
        }
    }
}
