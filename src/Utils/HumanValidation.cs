using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Utils
{
    public static class HumanValidation
    {
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Length > Constant.MAX_NAME_LENGTH)
            {
                return false;
            } 

            return true;
        }

        public static bool IsValidAddress(string address)
        {
            if (string.IsNullOrEmpty(address) || address.Length > Constant.MAX_ADDRESS_LENGTH)
            {
                return false;
            }

            return true;
        }

        public static bool IsValidBirthYear(int birthYear)
        {
            if (birthYear < Constant.MIN_YEAR || birthYear > DateTime.Now.Year)
            {
                return false;
            }

            return true;
        }

        public static bool IsValidHeight(double height)
        {
            if (height < Constant.MIN_HEIGHT || height > Constant.MAX_HEIGHT)
            {
                return false;
            }

            return true;
        }

        public static bool IsValidWeight(double weight)
        {
            if (weight < Constant.MIN_WEIGHT || weight > Constant.MAX_WEIGHT)
            {
                return false;
            }

            return true;
        }
    }
}
