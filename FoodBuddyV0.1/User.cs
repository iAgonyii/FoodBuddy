using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBuddyV0._1
{
    class User
    {
        private string name;
        private Allergy allergy;
        private int gender;
        public User (string inputName, Allergy inputAllergy, int inputGender)
        {
            this.allergy = inputAllergy;
            this.name = inputName;
            this.gender = inputGender;
        }

        public string GetName()
        {
            return this.name;
        }
        public Allergy GetAllergy ()
        {
            return this.allergy;
        }
        public string GetGender()
        {
            if (this.gender == 1)
            {
                return "Man";
            }
            else if (this.gender == 2)
            {
                return "Vrouw";
            }
            else
            {
                return "Onbekend";
            }
        }
    }
}
