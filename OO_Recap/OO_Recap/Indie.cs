using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Recap
{
    class Indie : GameCompany
    {
        //Fields ---------------->
        protected int backers;
        protected int awards;

        //Constructor ---------------->
        public Indie(string location, string name, int salesInYear, int yearFounded, string ceo, string latestRelease, string platform, int employees, int backers, int awards)
            : base(location, name, salesInYear, yearFounded, ceo, latestRelease, platform, employees)
        {
            this.backers = backers;
            this.awards = awards;
        }

        //Properties ---------------->
        public int Backers
        {
            get { return this.backers; }
            set { this.backers = value; }
        }
        public int Awards
        {
            get { return this.awards; }
            set { this.awards = value; }
        }

        //Methods ---------------->
        //Calls the original MakeGame method
        public override void MakeGame(string gameName)
        {
            base.MakeGame(gameName);

            //Adds 5 awards and increases backers by 20%
            this.Awards += 5;
            this.Backers += this.Backers / 5;
        }
        //Calls the original HireEmployee method
        public override string HireEmployee(int employeesHired)
        {
            //Multiplies the sales in the year by 2
            this.SalesInYear *= 2;

            return base.HireEmployee(employeesHired) + "Their yearly sales doubled!";
        }
        //Increases the amount of backers by 1000
        public void StartCampaign()
        {
            this.Backers += 1000;

            Console.WriteLine("{0} has started their campaign. They gained 1000 backers!", this.Name);
        }
    }
}
