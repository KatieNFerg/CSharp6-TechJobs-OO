using System;
using System.Data.Common;

namespace TechJobsOOAutoGraded6
{
    public class PositionType : JobField
    {

        public PositionType(string value) : base(value)
        {
        }

        // TODO: Task 2: Add custom Equals(), GetHashCode(), and ToString() methods.
    
    public override string ToString()
    {
        return Value;
    }
    public override bool Equals(object obj)
    {
        return obj is PositionType type && Id == type.Id && Value == type.Value;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Value);
    }
    }
}


