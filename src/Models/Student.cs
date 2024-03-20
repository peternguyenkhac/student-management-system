using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace src.Models
{
    public class Student : Human
    {
        private string _studentCode;
        private string _schoolName;
        private int _startYear;
        private double _gPA;

        public string StudentCode { get => _studentCode; set => _studentCode = value; }
        public string SchoolName { get => _schoolName; set => _schoolName = value; }
        public int StartYear { get => _startYear; set => _startYear = value; }
        public double GPA { get => _gPA; set => _gPA = value; }

        public Student(string name, DateTime dateOfBirth, string address, int height, int weight, string studentCode, string schoolName, int startYear, double gPA) : base(name, dateOfBirth, address, height, weight)
        {
            _studentCode = studentCode;
            _schoolName = schoolName;
            _startYear = startYear;
            _gPA = gPA;
        }

        public Student(int id, string name, DateTime dateOfBirth, string address, int height, int weight, string studentCode, string schoolName, int startYear, double gPA) : base(id, name, dateOfBirth, address, height, weight)
        {
            _studentCode = studentCode;
            _schoolName = schoolName;
            _startYear = startYear;
            _gPA = gPA;
        }

        public string ToString()
        {
            return $"{base.ToString()}, Student code: {this._studentCode}, School name: {this._schoolName}, Start year: {this._startYear}, GPA: {this._gPA}";
        }

    }
}
