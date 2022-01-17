using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerson
{
    public class Manager: Person
    {

        string company;
        int sale;
        
        public Manager() { }
        public Manager(string fam, string company, int sale) : base(fam)
        {
            this.company = company;
            this.sale = sale;
        }
        public string Company
        {
            set{ if (company == null) company = value; }
            get{ return company; }
        }
        public int Sale
        {
            set { sale = value; }
            get { return sale; }
        }
        public double Bonus
        {
            get { return sale * 0.05; }
        }
        public void show()
        {
            Console.WriteLine("Perenimi: " + base.Fam);
            Console.WriteLine("Firma: " + company);
            Console.WriteLine("Summa: " + sale + ". Bonus: " + Bonus);
            Console.WriteLine();
        }
    }
}
