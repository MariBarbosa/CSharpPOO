using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaMaria = new ContaCorrente();

            contaDaMaria.titular = "Maria";
            contaDaMaria.agencia = 863;
            contaDaMaria.numero = 863452;
            contaDaMaria.saldo = 100;

            Console.WriteLine(contaDaMaria.titular);
            Console.WriteLine("Agencia: " + contaDaMaria.agencia);
            Console.WriteLine("Numero: " + contaDaMaria.numero);
            Console.WriteLine("Saldo: " + contaDaMaria.saldo);

            contaDaMaria.saldo += 200;
            Console.WriteLine("Saldo: " + contaDaMaria.saldo);

            Console.ReadLine();
        }
    }
}
