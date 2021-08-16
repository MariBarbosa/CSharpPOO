using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoJoao = new ContaCorrente();

            contaDoJoao.titular = "Joao";

            Console.WriteLine(contaDoJoao.saldo);
            bool resultadoSaque = contaDoJoao.Sacar(500);

            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoJoao.saldo);
          
            contaDoJoao.Depositar(500);
            Console.WriteLine(contaDoJoao.saldo);

            ContaCorrente contaDaMaria = new ContaCorrente();

            contaDaMaria.titular = "Maria";

            Console.WriteLine("Saldo do Joao: " + contaDoJoao.saldo);
            Console.WriteLine("Saldo do Maria: " + contaDaMaria.saldo);


            bool resultadoTransferencia = contaDoJoao.Transferir(200, contaDaMaria);

            Console.WriteLine("Saldo do Joao: " + contaDoJoao.saldo);
            Console.WriteLine("Saldo do Maria: " + contaDaMaria.saldo);
            Console.WriteLine("Resultado transferência " + resultadoTransferencia);

            Console.ReadLine();

        }
    }
}
