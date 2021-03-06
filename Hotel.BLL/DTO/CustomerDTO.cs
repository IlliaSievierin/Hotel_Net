using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.BLL.DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Passport { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is CustomerDTO)
            {
                var objCM = obj as CustomerDTO;
                return
                     this.FirstName == objCM.FirstName
                    && this.MiddleName == objCM.MiddleName
                    && this.Passport == objCM.Passport
                    && this.DateOfBirth == objCM.DateOfBirth;
            }
            else return base.Equals(obj);

        }

        public override string ToString()
        {
            return $"{Id}, {LastName}, {FirstName}, {MiddleName}, {DateOfBirth}, {Passport}";
        }
    }
}
