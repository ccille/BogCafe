using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.model
{
    public class Merchant
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Merchant()
        {
        }

        public Merchant(int id, string name, string email, string phone)
        {
            ID = id;
            Name = name;
            Email = email;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"Id = {ID}, Name = {Name}, Email = {Email}, Phone = {Phone}";
        }
    }
}
