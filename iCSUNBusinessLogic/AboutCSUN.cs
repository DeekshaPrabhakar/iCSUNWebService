using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCSUNBusinessLogic
{
    public class AboutCSUN
    {
        public AboutCSUN()
        {

        }
        private string l_aboutId= string.Empty;
        public string AboutId
        {
            get { return l_aboutId; }
            set { l_aboutId = value; }
        }
        private string l_introText = string.Empty;
        public string IntroText
        {
            get { return l_introText; }
            set { l_introText = value; }
        }
        private string l_address = string.Empty;
        public string Address    
        {
            get { return l_address; }
            set { l_address = value; }
        }

    }
}
