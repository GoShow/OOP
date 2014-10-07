namespace Customer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Customer : ICloneable, IComparable<Customer>
    {
        public Customer(string firstName, string middleName, string lastName, long egn, string permanentAddress,
            string mobilePhone, string email, Type type, params Payment[] payments)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.EGN = egn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Payments = payments.ToList();
            this.Type = type;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public long EGN { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public IList<Payment> Payments { get; set; }
        public Type Type { get; set; }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;

            if (customer == null)
            {
                return false;
            }
            if (!Equals(this.FirstName, customer.FirstName))
            {
                return false;
            }
            if (!Equals(this.MiddleName, customer.MiddleName))
            {
                return false;
            }
            if (!Equals(this.LastName, customer.LastName))
            {
                return false;
            }
            if (this.EGN != customer.EGN)
            {
                return false;
            }
            if (!Equals(this.PermanentAddress, customer.PermanentAddress))
            {
                return false;
            }
            if (!Equals(this.MobilePhone, customer.MobilePhone))
            {
                return false;
            }
            if (!Equals(this.Email, customer.Email))
            {
                return false;
            }
            if (!Equals(this.Type, customer.Type))
            {
                return false;
            }
            if (this.Payments.Count != customer.Payments.Count)
            {
                return false;
            }

            for (int i = 0; i < this.Payments.Count; i++)
            {
                if (!Equals(this.Payments[i], customer.Payments[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator ==(Customer customer1, Customer customer2)
        {
            return Equals(customer1, customer2);
        }
        public static bool operator !=(Customer customer1, Customer customer2)
        {
            return !Equals(customer1, customer2);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^
                this.MiddleName.GetHashCode() ^
                this.LastName.GetHashCode() ^
                this.EGN.GetHashCode() ^
                this.PermanentAddress.GetHashCode() ^
                this.MobilePhone.GetHashCode() ^
                this.Email.GetHashCode() ^
                this.Payments.GetHashCode() ^
                this.Type.GetHashCode();
        }

        public override string ToString()
        {
            string paymentsString = "";
            if (this.Payments.Count != 0)
            {
                foreach (var payment in this.Payments)
                {
                    paymentsString += payment + " ";
                }
            }
            string customerString =
                String.Format("{0} {1} {2}\nEGN: {3}\nAddress: {4}\nMobile: {5}\nEmail: {6}\nPayments: {7}\nType: {8}",
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.EGN,
                this.PermanentAddress,
                this.MobilePhone,
                this.Email,
                paymentsString,
                this.Type);

            return customerString;
        }

        public object Clone()
        {
            Payment[] currentPayments = new Payment[this.Payments.Count];
            for (int i = 0; i < this.Payments.Count; i++)
            {
                currentPayments[i] = this.Payments[i];
            }

            return new Customer(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.EGN,
                this.PermanentAddress,
                this.MobilePhone,
                this.Email,
                this.Type,
                currentPayments);
        }

        public int CompareTo(Customer other)
        {
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            return this.EGN.CompareTo(other.EGN);
        }
    }
}
