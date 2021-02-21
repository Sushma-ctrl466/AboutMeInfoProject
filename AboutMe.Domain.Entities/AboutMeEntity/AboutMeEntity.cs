using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboutMe.Domain.Entities.AboutMeEntity
{
    public class AboutMeEntity
    {
        #region Private Variables

        string firstName;
        string lastName;
        string occupation;
        string designation;
        string location;
        long phone;
        decimal salary;

        #endregion

        #region Constructors
        public AboutMeEntity()
        {
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.Occupation = string.Empty;
            this.Designation = string.Empty;
            this.Location = string.Empty;
            this.Phone = default(long);
            this.Salary = default(decimal);
        }
        public AboutMeEntity(string firstName, string lastName, string occupation,
            string designation, string location, long phone, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Occupation = occupation;
            this.Designation = designation;
            this.Location = location;
            this.Phone = phone;
            this.Salary = salary;
        }

        #endregion

        #region Props

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Occupation { get => occupation; set => occupation = value; }
        public string Designation { get => designation; set => designation = value; }
        public string Location { get => location; set => location = value; }
        public long Phone { get => phone; set => phone = value; }
        public decimal Salary { get => salary; set => salary = value; }

        #endregion
    }
}
