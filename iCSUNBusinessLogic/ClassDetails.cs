using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCSUNBusinessLogic
{
    public class ClassDetails
    {
        public ClassDetails()
        {

        }
        private string l_classNumber = string.Empty;
        public string ClassNumber
        {
            get { return l_classNumber; }
            set { l_classNumber = value; }
        }
        private string l_location = string.Empty;
        public string Location
        {
            get { return l_location; }
            set { l_location = value; }
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

        private string l_instructor = string.Empty;
        public string Instructor
        {
            get { return l_instructor; }
            set { l_instructor = value; }
        }
        private string l_classId = string.Empty;
        public string ClassId
        {
            get { return l_classId; }
            set { l_classId = value; }
        }

        private string l_sec = string.Empty;
        public string Section
        {
            get { return l_sec; }
            set { l_sec = value; }
        }
    }
}
