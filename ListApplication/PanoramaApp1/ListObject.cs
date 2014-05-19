using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PanoramaApp1
{
    class ListObject
    {
        private string ListName;
        private string Quantity;
        public ListObject( string name, string quantity)
        {
            this.ListName = name;
            this.Quantity = quantity;
        }
        public string Name
        {
            get { return ListName; }
            set { ListName = value; }
        }
        public string NumberofItems
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
    }
}
