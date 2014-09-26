using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFC.Views
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Client(int id, string name, string city, string state)
        {
            this.ID = id;
            this.Name = name;
            this.City = city;
            this.State = state;
        }
    }
}
