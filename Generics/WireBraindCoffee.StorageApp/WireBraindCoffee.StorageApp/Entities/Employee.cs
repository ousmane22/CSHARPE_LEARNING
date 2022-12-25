using System;
using System.Collections.Generic;
using System.Text;

namespace WireBraindCoffee.StorageApp.Entities
{
    public class Employee
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }

        public override string ToString() => $"Id :{ID} , FirstName: {FirstName}";


    }

}
