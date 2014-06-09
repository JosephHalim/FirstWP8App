using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PanoramaApp1
{
    public class ListObject
    {
        
        public string Quantity; 
        public string Group;
        public string Name;
        public bool InCart;
        public ListObject(string name, string quantity, string group, bool incart)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Group = group;
            this.InCart = incart;
        }
        public bool InsideCart {
            get { return InCart; }
            set { InCart = value; }
        }
      public string NameofItem
        {
            get { return Name; }
            set { Name = value;}
        }
        public string NumberofItems
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public string GroupList
        {
            get { return Group; }
            set { Group = value; }
        }
    }
}
