using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresVotAdminca.Classes
{
    class ElectionCode
    {
        private UInt64 id;
        private int chose;
        private bool isValid;

        public int Chose { get => chose; set => chose = value; }
        public ulong Id { get => id; set => id = value; }
        public bool IsValid { get => isValid; set => isValid = value; }

        public ElectionCode(UInt64 id, int chose, bool isValid)
        {
            this.id = id;
            this.chose = chose;
            this.isValid = isValid;
        }

        public override string ToString()
        {
            return "Code: " + id + " " + chose + " " + isValid;
        }
    }
}
