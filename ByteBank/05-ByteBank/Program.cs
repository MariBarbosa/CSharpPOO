using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente maria = new Cliente();

            maria.nome = "Maria";
            maria.profissao = "Desenvolvedora C#";
            maria.cpf = "123.456.789-10";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = maria;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 536456;

            Console.WriteLine(maria.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();

        }
    }
}
