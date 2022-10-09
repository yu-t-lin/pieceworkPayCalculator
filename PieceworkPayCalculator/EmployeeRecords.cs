using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieceworkPayCalculator
{
    internal class EmployeeRecords
    {

        //VARIABLES 

        private string workerName = String.Empty;
        private int messagesSent = 0;
        private float workersPay = 0;

        //CONSTRUCTOR
        public EmployeeRecords()
        {
            this.workerName = String.Empty;
            this.messagesSent = 0;
            this.workersPay = 0;
        }
         public EmployeeRecords( string inputName, int inputMessagesSent, float outputWorkersPay)
        {
            workerName = inputName;
            messagesSent = inputMessagesSent;
            workersPay = outputWorkersPay;
        }

        //PROPERTY PROCEDURES / accessors and mutators
        internal string Name
        {
            get { return workerName; }
            set { workerName = value; }

        }

        internal int MessagesSent
        {
            get { return messagesSent; }
            set { messagesSent = value; }
        }

        internal float WorkerPay { get; set; }       

    }
}
