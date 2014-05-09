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
        private string Item;
        public ListObject( string name, string item)
        {
            this.ListName = name;
            this.Item = item;
        }
        public string Name
        {
            get { return ListName; }
            set { ListName = value; }
        }
        public string ItemID
        {
            get { return Item; }
            set { Item = value; }
        }
    }
}
