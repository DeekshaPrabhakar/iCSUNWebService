using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCSUNBusinessLogic
{
    public class FacultyInfo
    {
        public FacultyInfo()
        {

        }

       
        private string l_facId = string.Empty;
        public string FacId    
        {
            get { return l_facId; }
            set { l_facId = value; }
        }
        private string l_name = string.Empty;
        public string Name
        {
            get { return l_name; }
            set { l_name = value; }
        }
        private string l_dept = string.Empty;
        public string Dept    
        {
            get { return l_dept; }
            set { l_dept = value; }
        }
        private string l_schedule = string.Empty;
        public string Schedule    
        {
            get { return l_schedule; }
            set { l_schedule = value; }
        }
        private string l_web = string.Empty;
        public string Web    
        {
            get { return l_web; }
            set { l_web = value; }
        }
        private string l_eMail = string.Empty;
        public string Email    
        {
            get { return l_eMail; }
            set { l_eMail = value; }
        }
        private string l_ext = string.Empty;
        public string Ext    
        {
            get { return l_ext; }
            set { l_ext = value; }
        }
        private string l_officeLoc = string.Empty;
        public string OfficeLoc    
        {
            get { return l_officeLoc ; }
            set { l_officeLoc  = value; }
        }
        private string l_locCod = string.Empty;
        public string LocCod    
        {
            get { return l_locCod ; }
            set { l_locCod  = value; }
        }
        }

    }
