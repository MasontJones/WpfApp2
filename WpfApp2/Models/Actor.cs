using System;
using System.Collections.Generic;
using System.Text;

namespace RecordDatabase.Models
{
    public class Actor
    {
        public int ActorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName} -- ({BirthDate})";
        }
    }
}
