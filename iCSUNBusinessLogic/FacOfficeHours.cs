using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCSUNBusinessLogic
{
    public class FacOfficeHours
    {
        public FacOfficeHours()
        {

        }
        private string l_facOffId = string.Empty;
        public string FacOffId    
        {
            get { return l_facOffId; }
            set { l_facOffId = value; }
        }
        private string l_facId = string.Empty;
        public string FacId
        {
            get { return l_facId; }
            set { l_facId = value; }
        }
        private string l_days = string.Empty;
        public string Days
        {
            get { return l_days; }
            set { l_days = value; }
        }
        private string l_time = string.Empty;
        public string Time
        {
            get { return l_time; }
            set { l_time = value; }
        }
    }
}
