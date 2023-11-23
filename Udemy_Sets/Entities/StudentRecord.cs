using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Sets.Entities
{
    internal class StudentRecord
    {
        public StudentRecord(int id)
        {
            Id = id;
        }

        private int Id { get; set; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is StudentRecord)|| obj is null) return false;
            StudentRecord other = (StudentRecord)obj;
            return Id.Equals(other.Id);
        }

    }
}
