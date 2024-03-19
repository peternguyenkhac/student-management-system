using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Models
{
    public class Human
    {
        private static int _id = 1;
        private DateTime _dateOfBirth;
        private string _address;
        private int _height;
        private int _weight;

        public int Id { get => _id;}
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        public string Address { get => _address; set => _address = value; }
        public int Height { get => _height; set => _height = value; }
        public int Weight { get => _weight; set => _weight = value; }

        public Human(DateTime dateOfBirth, string address, int height, int weight)
        {
            _id = _id;
            _dateOfBirth = dateOfBirth;
            _address = address;
            _height = height;
            _weight = weight;
        }

        public string ToString()
        {
            return $"Id: {_id}, Date of birth: {this._dateOfBirth.ToString("MM/dd/yyyy")}, Address: {this._address}, Height: {this._height}, Weight: {this._weight}";
        }
    }
}
