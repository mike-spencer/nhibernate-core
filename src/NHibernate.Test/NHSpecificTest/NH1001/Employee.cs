using System;
using System.Collections.Generic;
using System.Text;

namespace NHibernate.Test.NHSpecificTest.NH1001
{
    public class Employee
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private Department department;

        public Department Department
        {
            get { return department; }
            set { department = value; }
        }
    }
}
