using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialclass.cs
{

    sealed class employee
    {
        int eid;
        string ename;
        string ecompany;
        public employee(int eid, string ename, string ecompany)
        {
            this.eid = eid;
            this.ename = ename;
            this.ecompany = ecompany;
        }
        public void edisplay()
        {
            Console.WriteLine("employee id is:" + eid);
            Console.WriteLine("employee name is:" + ename);
            Console.WriteLine("employee company is:" + ecompany);
        }
    }
    class Company : employee
    {
        int cid;
        string cname;
        public Company(int cid, string cname) : base(2, "bcd", "tcs")
        {
            this.cid = cid;
            this.cname = cname;
        }
        public void cdisplay()
        {
            Console.WriteLine("Company id is:" + cid);
            Console.WriteLine("Company name is:" + cname);
            base.edisplay();
        }
    }
}
