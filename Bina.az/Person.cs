using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az
{
    public abstract class Person
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
 
        public GenderType Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Adress { get; set; }
    }
}
