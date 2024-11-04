using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230062
{
    internal class Book_714230062
    {
        protected string pageCount;

        public Book_714230062(string type, string title, string pagecount) : base(type, title)
        {
            this.pageCount = pagecount;
        }

        public string Pagecount
        {
            get { return this.pageCount; }
            set { this.pageCount = value; }
        }

        // implementasikan metode abstrak 
        public override void DisplayInfo()
        {
            Console.WriteLine("Product is a {0} called \"{1}\" and has {2} pages", MyType, MyTitle, PageCount);
        }
    }
}
