using System;

namespace CRUD.Entities
{
    public class Person : Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public DateTimeOffset BirthDate { get; set; }
    }
}

