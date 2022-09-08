using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCTestProject
{

    internal class ListCleaner
    {
        public static ArrayList CleanList(ArrayList dataList)
        {
            ArrayList cleanList = new ArrayList();
            int addedValue = 0;
            foreach (var item in dataList)
            {
                if (int.TryParse(Convert.ToString(item), out addedValue))
                {
                    cleanList.Add(item);
                }
            }
            return cleanList;
        }

        public static int AddListElements(ArrayList datalist)
        {
            int addedValue = 0;

            foreach (var item in datalist)
            {
                addedValue += Convert.ToInt32(item);
            }

            return addedValue;
        }
    }


}
