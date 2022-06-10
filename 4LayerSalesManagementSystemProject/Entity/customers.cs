using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class customers
    {
        private int custId;

        public int CustomerId
        {
            get { return custId; }
            set { custId = value; }
        }
        private string custNameSurname;

        public string CustomerNameSurname
        {
            get { return custNameSurname; }
            set { custNameSurname = value; }
        }

        private string custAdress;

        public string CustomerAdress
        {
            get { return custAdress; }
            set { custAdress = value; }
        }

        private string custMail;

        public string CustomerMail
        {
            get { return custMail; }
            set { custMail = value; }
        }
        private string custPhone;

        public string CustomerPhone
        {
            get { return custPhone; }
            set { custPhone = value; }
        }
       

    }
}
