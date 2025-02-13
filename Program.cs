using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konto
{
    internal class Customer
    {
        public Customer(string id, string name, decimal saldo)
        {
            Id = id;
            Name = name;
            Saldo = saldo;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Saldo { get; set; }

    }


}


