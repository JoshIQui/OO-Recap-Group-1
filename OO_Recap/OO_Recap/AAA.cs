using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Recap
{
    class AAA : GameCompany 
    {
        //Fields ---------------->
        protected double cost;
        protected string controversy;

        //Constructor ---------------->
        public AAA(string location, string name, int salesInYear, int yearFounded, string ceo, string latestRelease, string platform, int employees, double cost, string controversy)
            : base(location, name, salesInYear, yearFounded, ceo, latestRelease, platform, employees)
        {
            this.cost = cost;
            this.controversy = controversy;
        }

        //Properties ---------------->
        public double Cost
        {
            get { return this.cost; }
            set { this.cost = value; }
        }
        public string Controversy
        {
            get { return this.controversy; }
            set { this.controversy = value; }
        }

        //Methods ---------------->
        //Changes the latest release and increases the cost
        public void Acquire(string item)
        {
            //Increases the cost by 30%
            this.Cost -= this.Cost * (3 / 10);

            this.LatestRelease = item;
        }
        //Changes the ceo to the parameter
        public void Liquidate(string owner)
        {
            this.Ceo = owner;
        }
    }
}
