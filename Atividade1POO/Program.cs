using System;

namespace Atividade1POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Titular:");
            var titular = Convert.ToString(Console.ReadLine());

            DateTime dateTime = DateTime.Now;
            ContaPoupanca contaPoupanca = new ContaPoupanca(0.1M, dateTime, titular);

            ContaCorrente contaCorrente = new ContaCorrente(titular);

            while (true)
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Conta Poupança (CP)");
                Console.WriteLine("2 - Conta Corrente (CC)");
                Console.WriteLine("0 - Sair");

                var op1 = Convert.ToInt16(Console.ReadLine());

                if (op1 == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("1 Depositar");
                        Console.WriteLine("2 Sacar");
                        Console.WriteLine("3 Visualizar Saldo");
                        Console.WriteLine("0 Voltar");

                        var op = Convert.ToInt16(Console.ReadLine());

                        if (op == 1)
                        {
                            Console.WriteLine("Informe o valor:");
                            var valor = Convert.ToInt16(Console.ReadLine());
                            contaPoupanca.Depositar(valor);
                        }

                        else if (op == 2)
                        {
                            Console.WriteLine("Informe o valor:");
                            var valor = Convert.ToInt16(Console.ReadLine());
                            contaPoupanca.Sacar(valor);
                        }

                        else if (op == 3)
                        {
                            Console.WriteLine($"Titular: {contaPoupanca.Id} / Saldo: {contaPoupanca.Saldo}");
                        }
                        else if (op == 0)
                        {
                            break;
                        }
                    }
                }
                else if (op1 == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("1 Depositar");
                        Console.WriteLine("2 Sacar");
                        Console.WriteLine("3 Visualizar saldo");
                        Console.WriteLine("0 Sair");

                        var op = Convert.ToInt16(Console.ReadLine());

                        if (op == 1)
                        {
                            Console.WriteLine("Informe o valor:");
                            var valor = Convert.ToInt16(Console.ReadLine());
                            contaCorrente.Depositar(valor);
                        }

                        else if (op == 2)
                        {
                            Console.WriteLine("Informe o valor:");
                            var valor = Convert.ToInt16(Console.ReadLine());
                            contaCorrente.Sacar(valor);
                        }

                        else if (op == 3)
                        {
                            Console.WriteLine($"Titular: {contaCorrente.Id} / Saldo: {contaCorrente.Saldo}");
                        }
                        else if (op == 0)
                        {
                            break;
                        }
                    }
                }
                else if (op1 == 0)
                    Console.ReadKey();
                break;

            }
        }
    }
}
