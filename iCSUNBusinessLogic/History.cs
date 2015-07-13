using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCSUNBusinessLogic
{
    public class History
    {
        public History()
        {

        }
        private string l_historyId = string.Empty;
        public string HistoryId    
        {
            get { return l_historyId; }
            set { l_historyId = value; }
        }
        private string l_title = string.Empty;
        public string Title
        {
            get { return l_title; }
            set { l_title = value; }
        }
        private string l_text = string.Empty;
        public string Text
        {
            get { return l_text; }
            set { l_text = value; }
        }
    }
}
