using System;
namespace TechJobsOOAutoGraded6
{
	public class CoreCompetency : JobField
	{

        public CoreCompetency(string value) : base(value)
        {
        }

       public override string ToString()
       {
           return Value;
        }
        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id && Value == competency.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Value);
        }

    }
}

