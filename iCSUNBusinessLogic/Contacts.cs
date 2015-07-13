using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCSUNBusinessLogic
{
    public class Contacts
    {
        public Contacts()
        {

        }
        private string l_contactId = string.Empty;
        public string ContactId    
        {
            get { return l_contactId; }
            set { l_contactId = value; }
        }
        private string l_name = string.Empty;
        public string Name    
        {
            get { return l_name; }
            set { l_name = value; }
        }
        private string l_phone = string.Empty;
        public string Phone
        {
            get { return l_phone; }
            set { l_phone = value; }
        }
        private string l_fax = string.Empty;
        public string Fax    
        {
            get { return l_fax; }
            set { l_fax = value; }
        }

    }
}
