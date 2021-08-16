using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaMaria = new ContaCorrente();
            contaDaMaria.titular = "Maria";
            contaDaMaria.agencia = 863;
            contaDaMaria.numero = 863452;

            ContaCorrente contaDaMariaG = new ContaCorrente();
            contaDaMaria.titular = "Maria";
            contaDaMaria.agencia = 863;
            contaDaMaria.numero = 863452;

            Console.WriteLine(contaDaMaria == contaDaMariaG);

            contaDaMaria.saldo = 300;
            Console.WriteLine(contaDaMaria.saldo);
            Console.WriteLine(contaDaMariaG.saldo);

            if (contaDaMaria.saldo >= 100)
            {
                contaDaMaria.saldo -= 100;
            }

            Console.ReadLine();

        }
    }
}
