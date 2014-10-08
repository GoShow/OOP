using System;
using System.Collections;
using System.Linq;

namespace StringDisperser
{
    public class StringDisperser : IComparable<StringDisperser>, IEnumerable
    {
        private string[] text;
        public StringDisperser(params string[] text)
        {
            this.Text = text;
        }

        public string[] Text
        {
            get { return this.text; }

            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentNullException("text", "Text array can't be empty");
                }

                this.text = value;
            }
        }

        public override bool Equals(object obj)
        {
            StringDisperser stringDisperser = obj as StringDisperser;
            if (stringDisperser == null)
            {
                return false;
            }

            if (this.Text.Equals(stringDisperser))
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
            int hashCode = this.Text.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            string result = String.Join(", ", this.Text);         
            return result;
        }

        public object Clone()
        {
            string[] newTextArray = new string[this.Text.Length];
            for (int i = 0; i < newTextArray.Length; i++)
            {
                newTextArray[i] = this.Text[i];
            }

            return new StringDisperser(newTextArray);
        }

        public int CompareTo(StringDisperser other)
        {
            return this.ConcatenateText(this.Text).CompareTo(other.ConcatenateText(other.text));
        }

        private string ConcatenateText(string[] array)
        {
            string wholeString = String.Join("", this.Text);
            return wholeString;
        }

        public IEnumerator GetEnumerator()
        {
            string totalString = this.ConcatenateText(this.Text);
            for (int i = 0; i < totalString.Length; i++)
            {
                yield return totalString[i];
            }
        }
    }
}
