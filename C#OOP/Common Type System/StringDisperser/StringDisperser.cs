using System;
using System.Collections;

namespace StringDisperser
{
    public class StringDisperser : IComparable<StringDisperser>, IEnumerable
    {
        public StringDisperser(string firstName, string middleName, string lastName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            StringDisperser stringDisperser = obj as StringDisperser;
            if (stringDisperser == null)
            {
                return false;
            }
            if (!Equals(this.FirstName, stringDisperser.FirstName))
            {
                return false;
            }
            if (!Equals(this.MiddleName, stringDisperser.MiddleName))
            {
                return false;
            }
            if (!Equals(this.LastName, stringDisperser.LastName))
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(StringDisperser string1, StringDisperser string2)
        {
            return Equals(string1, string2);
        }
        public static bool operator !=(StringDisperser string1, StringDisperser string2)
        {
            return !Equals(string1, string2);
        }
        public override int GetHashCode()
        {
            int hashCode = this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            string fullName = this.FirstName + " " + this.MiddleName + " " + this.LastName;
            return fullName;
        }

        public object Clone()
        {
            return new StringDisperser(this.FirstName, this.MiddleName, this.LastName);
        }

        public int CompareTo(StringDisperser other)
        {
            string firstWholeString = this.FirstName + this.MiddleName + this.LastName;
            string secondWholeString = other.FirstName + other.MiddleName + other.LastName;

            return firstWholeString.CompareTo(secondWholeString);
        }

        public IEnumerator GetEnumerator()
        {
            string wholeString = this.FirstName + this.MiddleName + this.LastName;
            for (int i = 0; i < wholeString.Length; i++)
            {
                yield return wholeString[i];
            }
        }
    }
}
