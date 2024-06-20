using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class Client
    {
        public string clientName;
        private int clientNum;
        private int bornyear;
        private int budget;

        public int ClientNum {  get { return clientNum; } set { clientNum = value; } }
        public int Bornyear
        {
            get
            {
                return bornyear;
            }
            set
            {
                value = bornyear;
            }
        }
        public int Budget
        {
            get
            {
                return budget;
            }
            set
            {
                budget = value;
            }
        }
    }
}
