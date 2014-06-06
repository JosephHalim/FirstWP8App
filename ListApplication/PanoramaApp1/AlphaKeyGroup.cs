using System.Collections.Generic;
using System.Globalization;
using Microsoft.Phone.Globalization;

namespace PanoramaApp1
{
    public class AlphaKeyGroup<T> : List<T>
    {
        /// <summary>
        /// The delegate that is used to get the key information.
        /// </summary>
        /// <param name="item">An object of type T</param>
        /// <returns>The key value to use for this object</returns>
        public delegate string GetKeyDelegate(T item);

        /// <summary>
        /// The Key of this group.
        /// </summary>
        public string Key { get; private set; }

        /// <summary>
        /// Public constructor.
        /// </summary>
        /// <param name="key">The key for this group.</param>
        public AlphaKeyGroup(string key)
        {
            Key = key;
        }

        /// <summary>
        /// Create a list of AlphaGroup<T> with keys set by a SortedLocaleGrouping.
        /// </summary>
        /// <param name="slg">The </param>
        /// <returns>Theitems source for a LongListSelector</returns>
        private static List<AlphaKeyGroup<T>> CreateGroups(List<object> values)
        {
            object hold = myGlobals.ListofItemsinList;
            List<AlphaKeyGroup<T>> list = new List<AlphaKeyGroup<T>>();
           // object hold = slg.GroupDisplayNames;
            foreach (ListObject key in values)
            {
                if (key.GroupList == null)
                {
                    list.Add(new AlphaKeyGroup<T>(""));
                }
                else {
                    list.Add(new AlphaKeyGroup<T>(key.GroupList));
                }
            }

            return list;
        }

        /// <summary>
        /// Create a list of AlphaGroup<T> with keys set by a SortedLocaleGrouping.
        /// </summary>
        /// <param name="items">The items to place in the groups.</param>
        /// <param name="ci">The CultureInfo to group and sort by.</param>
        /// <param name="getKey">A delegate to get the key from an item.</param>
        /// <param name="sort">Will sort the data if true.</param>
        /// <returns>An items source for a LongListSelector</returns>
        public static List<AlphaKeyGroup<T>> CreateGroups(IEnumerable<T> items, GetKeyDelegate getKey, bool sort)
        {
            List<AlphaKeyGroup<T>> list = CreateGroups(myGlobals.ListofItemsinList);
                foreach (T item in items)
                {
                  
                    int index = 0;
             
                     foreach (AlphaKeyGroup<T> key in list)
                    {
                    // Retrieves value from list of keys public object
                    AlphaKeyGroup<T> hold = key;
                    var temp = hold.Key;
                    //Retrieves key for each item in list
                    var property = item.GetType().GetProperty("GroupList");
                    string temp2 = property.GetValue(item) as string;
                         //Compares if keys are the same
                         if(temp2 == temp)
                         {
                             index = list.IndexOf(hold);
                             break;
                         }
                    }
                    //Adds item to list
                     if (index >= 0 && index < list.Count)
                     {
                         list[index].Add(item);
                     }
            }
          
                
            //}

           /* if (sort)
            {
                foreach (AlphaKeyGroup<T> group in list)
                {
                    group.Sort((c0, c1) => { return ci.CompareInfo.Compare(getKey(c0), getKey(c1)); });
                }
            }*/

            return list;
        }

    }
 


 

}
  