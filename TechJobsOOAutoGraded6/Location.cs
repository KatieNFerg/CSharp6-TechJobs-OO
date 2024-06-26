﻿using System;
namespace TechJobsOOAutoGraded6
{
	public class Location : JobField
	{

        // TODO: Task 2: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field.
public Location(string value) : base(value)
{
}
        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}

