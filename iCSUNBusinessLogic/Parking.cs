using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCSUNBusinessLogic
{
    public class Parking
    {
        public Parking()
        {

        }
        private string l_pLocName = string.Empty;
        public string ParkingLocName    
        {
            get { return l_pLocName; }
            set { l_pLocName = value; }
        }
        private string l_Cood1  = string.Empty;
        public string ParkingCood1
        {
            get { return l_Cood1; }
            set { l_Cood1 = value; }
        }

        private string l_Cood2 = string.Empty;
        public string ParkingCood2
        {
            get { return l_Cood2; }
            set { l_Cood2 = value; }
        }

        private string l_Cood3 = string.Empty;
        public string ParkingCood3
        {
            get { return l_Cood3; }
            set { l_Cood3 = value; }
        }
        
        private string l_Cood4 = string.Empty;
        public string ParkingCood4
        {
            get { return l_Cood4; }
            set { l_Cood4 = value; }
        }


    }
}
