using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Lab_DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var clients = new Dictionary<int, BankAccount>();

            var command = Console.ReadLine();

            while (command != "End")
            {
                var commands = command.Split();

                switch (commands[0])
                {
                    case "Create":
                        Create(commands[1], clients);
                        break;
                    case "Deposit":
                        Deposit(commands[1], commands[2], clients);
                        break;
                    case "Withdraw":
                        Withdraw(commands[1], commands[2], clients);
                        break;
                    case "Print":
                        Print(commands[1], clients);
                        break;

                }

                command = Console.ReadLine();
            }
        }

        private static void Print(string clientId, Dictionary<int, BankAccount> clients)
        {
            var id = int.Parse(clientId);


            if (ChecClientExistance(clients, id))
            {
                Console.WriteLine($"Account ID{id}, balance {clients[id].Balance:f2}");
            }
        }

        private static void Withdraw(string clientId, string amountToWithdraw, Dictionary<int, BankAccount> clients)
        {
            var id = int.Parse(clientId);
            var amount = double.Parse(amountToWithdraw);


            if (ChecClientExistance(clients, id))
            {
                if (clients[id].Balance >= amount)
                {
                    clients[id].Withdraw(amount);
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }
                

            }
        }

        private static void Deposit(string clientId, string amountToDeposit, Dictionary<int, BankAccount> clients)
        {
            var id = int.Parse(clientId);
            var amount = double.Parse(amountToDeposit);


            if (ChecClientExistance(clients, id))
            {
                clients[id].Deposit(amount);
            }

        }

        private static bool ChecClientExistance(Dictionary<int, BankAccount> clients, int id)
        {
            if (!clients.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return false;
            }
            return true;
        }

        private static void Create(string clientId, Dictionary<int, BankAccount> clients)
        {
            var id = int.Parse(clientId);

            if (!clients.ContainsKey(id))
            {
                var account = new BankAccount();
                account.ID = id;
                clients.Add(id, account);
            }
            else
            {
                Console.WriteLine("Account already exists");
            }
        }
    }
}
