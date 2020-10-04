using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classproperty1
{
    public class Class1
    {
        private string name;//field-variable field
        private int age;
        private string city;
        private string address;
        private long mobilenumber;
        private string email_id;
        private string driving_license;
        private string PAN;
        private long aadhar;
        private long voter;

        public string Name//property
        {
            get { return name; }
            set { name = value; }
        }
        public int Age//property
        {
            get { return age; }
            set { age = value; }
        }
        public string City//property
        {
            get { return city; }
            set { city = value; }
        }
        public string Address//property
        {
            get { return address; }
            set { address = value; }
        }
        public long Mobilenumber//property
        {
            get { return mobilenumber; }
            set { mobilenumber = value; }
        }
        public string Email_id//property
        {
            get { return email_id; }
            set { email_id = value; }
        }
        public string Driving_license//property
        {
            get { return driving_license; }
            set { driving_license = value; }
        }
        public string pan//property
        {
            get { return PAN; }
            set { PAN = value; }
        }
        public long Aadhar//property
        {
            get { return aadhar; }
            set { aadhar = value; }
        }
        public long Voter//property
        {
            get { return voter; }
            set { voter = value; }
        }

    }
}
