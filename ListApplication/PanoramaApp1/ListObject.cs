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
        public ListObject(string name, string quantity, string group)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Group = group;
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
