using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Utils
{
    public static class StudentValidation
    {
        public static bool IsValidStudentCode(string studentCode)
        {
            if(string.IsNullOrEmpty(studentCode) || studentCode.Length != Constant.STUDENT_CODE_LENGTH)
            {
                return false;
            }
            return true;
        }

        public static bool IsValidSchoolName(string schoolName)
        {
            if(string.IsNullOrEmpty(schoolName) || schoolName.Length > Constant.MAX_SCHOOL_NAME_LENGTH) 
            { 
                return false; 
            }

            return true;
        }

        public static bool IsValidStartYear(int startYear) 
        {
            if(startYear < Constant.MIN_YEAR || startYear > DateTime.Now.Year)
            {
                return false;
            }

            return true;
        }

        public static bool IsValidGPA(int gPA)
        {
            if(gPA < Constant.MIN_GPA || gPA > Constant.MAX_GPA)
            {
                return false;
            }

            return true;
        }
    }
}
