using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Recap
{
    class _3rd_Party_Dev : GameCompany
    {
        //Fields ---------------->
        protected int fans;
        protected string publisher;

        //Constructor ---------------->
        public _3rd_Party_Dev(string location, string name, int salesInYear, int yearFounded, string ceo, string latestRelease, string platform, int employees, int fans, string publisher)
            : base(location, name, salesInYear, yearFounded, ceo, latestRelease, platform, employees)
        {
            this.fans = fans;
            this.publisher = publisher;
        }

        //Properties ---------------->
        public int Fans
        {
            get { return this.fans; }
            set { this.fans = value; }
        }
        public string Publisher
        {
            get { return this.publisher; }
            set { this.publisher = value; }
        }

        //Methods ---------------->
        //Calls the parent FireEmployee method
        public override string FireEmployee(int employeesFired)
        {
            //Removes 10 fans
            this.Fans -= 10;

            return base.FireEmployee(employeesFired) + "They lost 10 fans!";
        }
        //Changes the publisher and adds 50 fans
        public void ChangePublisher(string newPublisher)
        {
            this.Publisher = newPublisher;

            this.Fans += 50;

            Console.WriteLine("{0} has changed their publisher to {1}. They gained 50 fans.", this.Name, newPublisher);
        }
    }
}
