using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11
{
    internal class Staff
    {
        public string DateofBirth { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        private string Phone;
        public string GetPhone() => $"+39{Phone}";

        public void SetPhone(string val) =>
            Phone = val.All(ch => char.IsDigit(ch)) ? val : Phone;

        public Staff() { }

        public Staff(string dateofBirth, string name, string position)
        {
            DateofBirth = dateofBirth;
            Name = name;
            Position = position;
        }
    }
}
