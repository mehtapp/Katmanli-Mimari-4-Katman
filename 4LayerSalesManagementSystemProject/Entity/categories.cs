using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entity
{
    public class categories
    {
        private string catId;

        public string CategoryID
        {
            get { return catId; }
            set { catId = value; }
        }

        private string catName;

        public string CategoryName
        {
            get { return catName; }
            set { catName = value; }
        }


    }
}
