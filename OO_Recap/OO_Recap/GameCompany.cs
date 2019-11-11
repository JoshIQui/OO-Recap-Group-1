using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Recap
{
    class GameCompany
    {
        //Contact group members before working on anything
        //Fields ---------------->
        protected string location;
        protected string name;
        protected int salesInYear;
        protected int yearFounded;
        protected string ceo;
        protected string latestRelease;
        protected string platform;
        protected int employees;

        //Constructor ---------------->
        public GameCompany(string location, string name, int salesInYear, int yearFounded, string ceo, string latestRelease, string platform, int employees)
        {
            this.location = location;
            this.name = name;
            this.salesInYear = salesInYear;
            this.yearFounded = yearFounded;
            this.ceo = ceo;
            this.latestRelease = latestRelease;
            this.platform = platform;
            this.employees = employees;
        }

        //Properties ---------------->
        public string Location
        {
            get { return this.location; }
        }
        public string Name
        {
            get { return this.name; }
        }
        public int SalesInYear
        {
            get { return this.salesInYear; }
            set { this.salesInYear = value; }
        }
        public int YearFounded
        {
            get { return this.yearFounded; }
        }
        public string Ceo
        {
            get { return this.ceo; }
            set { this.ceo = value; }
        }
        public string LatestRelease
        {
            get { return this.latestRelease; }
            set { this.latestRelease = value; }
        }
        public string Platform
        {
            get { return this.platform; }
        }
        public int Employees
        {
            get { return this.employees; }
            set { this.employees = value; }
        }

        //Methods ---------------->
        //Changes the latest release to the parameter
        public virtual void MakeGame(string gameName)
        {
            this.LatestRelease = gameName;
        }
        //Adds to the employee count based on the parameter
        public virtual string HireEmployee(int employeesHired)
        {
            //Only changes the amount of employees if its more than 0
            if (employeesHired >= 0)
            {
                this.Employees += employeesHired;
            }
            else
            {
                employeesHired = 0;
            }

            //Returns a string to notify the user
            return String.Format(this.Name + " has hired " + employeesHired + " employees.");
        }
        //Removes employees based on the parameter
        public virtual string FireEmployee(int employeesFired)
        {
            //Only changes the amount of employees if there are enough to fire
            if (this.Employees >= employeesFired)
            {
                this.Employees -= employeesFired;
            }
            else
            {
                employeesFired = 0;
            }

            //Returns a string to notify the user
            return String.Format(this.Name + " has fired " + employeesFired + " employees.");
        }
        //Gives the company an increase in sales
        public string IssuePressRelease()
        {
            //Increases sales in year by 20%
            this.SalesInYear += this.SalesInYear / 5;

            //Returns a string to notify the user
            return String.Format(this.Name + " has issued a successful press release.");
        }
        //Drastically gives the company an increase in sales
        public string Advertise()
        {
            //Multiplies the sales in a year by 2
            this.SalesInYear *= 2;

            //Returns a string to notify the user
            return String.Format(this.Name + " has advertised their products.");
        }
    }
}
