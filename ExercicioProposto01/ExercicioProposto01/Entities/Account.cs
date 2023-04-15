using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto01.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder; // Nome do usuario da conta
            Balance = balance; // Saldo inicial da conta
            WithdrawLimit = withdrawLimit; // Limite de saque da conta
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance == 0) {
                throw new ApplicationException("Não existe saldo na conta");
            }
            if (amount > WithdrawLimit) {
                throw new ApplicationException("O saque não pode ser maior que limite da conta");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return "Novo saldo da conta é: " + Balance;
        }
    }
}
