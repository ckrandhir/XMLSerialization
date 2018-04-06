using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerialization
{
    public class chandan
    {
        private Details myDetails;


        [XmlRoot("Details")]
        public class Details
        {
            private List<string> y = new List<string>();
            [XmlArray("ItemsofCD")]
            public List<string> Y
            {

                get
                {

                    return y;
                }

                set
                {
                    y = value;
                }
            }
        }

        private string firstName;

        private string lastName;

        

        [XmlElement("First-Name")]
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        [XmlElement("Last-Name")]
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public Details MyDetails
        {
            get
            {
                return myDetails;
            }

            set
            {
                myDetails = value;
            }
        }
    }
}
