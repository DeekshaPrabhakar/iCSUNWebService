using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCSUNBusinessLogic
{
    public class ClassInfo
    {
        public ClassInfo()
        {

        }
        private string l_classId = string.Empty;
        public string ClassId    
        {
            get { return l_classId; }
            set { l_classId = value; }
        }
        private string l_title  = string.Empty;
        public string Title
        {
            get { return l_title; }
            set { l_title = value; }
        }

        private string l_subject = string.Empty;
        public string Subject
        {
            get { return l_subject; }
            set { l_subject = value; }
        }

        private string l_catlgNbr = string.Empty;
        public string CatlgNbr
        {
            get { return l_catlgNbr; }
            set { l_catlgNbr = value; }
        }
        
        private string l_units = string.Empty;
        public string Units
        {
            get { return l_units; }
            set { l_units = value; }
        }
    }
}
