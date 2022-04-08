using System;

namespace ExampleASPNETCoreMVC.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
    }
}
