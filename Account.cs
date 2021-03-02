﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTask
{
    class Account
 
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;
        static int next = 2500;

        public Account(Address address)
        {
            this.address = address;
        }

        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }



        public void GenarateAccountNumber()
        {
            this.accountNumber = next;
            next++;
        }

        public int AccountNumber
        {
            get { return this.accountNumber; }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance = balance - amount;
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
            }
        }

        public void Transfer(double amount, Account receiver)
        {
            if (amount > 0 && amount <= balance)
            {
                balance = balance - amount;
                receiver.Deposit(amount);
            }
        }

        public void ShowAccountInformation()
        {
            Console.WriteLine("Account Information :");
            Console.WriteLine("Account Name : " + this.accountName);
            Console.WriteLine("Account Name : " + this.accountNumber);
            Console.WriteLine("Account Name : " + this.balance);
            Console.WriteLine("Account Name : " + this.address.GetAddress());

        }
    }
}
