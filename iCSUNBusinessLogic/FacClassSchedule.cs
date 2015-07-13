using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCSUNBusinessLogic
{
    public class FacClassSchedule
    {
        public FacClassSchedule()
        {

        }
        private string l_fcsId = string.Empty;
        public string FcsId    
        {
            get { return l_fcsId; }
            set { l_fcsId = value; }
        }
        private string l_facId = string.Empty;
        public string FacId
        {
            get { return l_facId; }
            set { l_facId = value; }
        }
        private string l_catlgNbr = string.Empty;
        public string CatlgNbr
        {
            get { return l_catlgNbr; }
            set { l_catlgNbr = value; }
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

        private string l_room = string.Empty;
        public string Room
        {
            get { return l_room; }
            set { l_room = value; }
        }

        private string l_classNumber = string.Empty;
        public string ClassNumber
        {
            get { return l_classNumber; }
            set { l_classNumber = value; }
        }
    }
}
