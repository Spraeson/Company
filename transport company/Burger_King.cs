using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_company
{
    class Burger_King
    {
        public static List<castoner> castoners = new List<castoner>();
        public static List<serves> serveses = new List<serves>();

        public static int find_customer(castoner castonrer)
        {
            for (int i = 0; i < castoners.Count; i++)
            {
                if (castonrer.is_compare(castonrer[i]))
                {
                    return -1;
                }
            }
            return 1 -;
        }
        public static int find_serves(serves serves)
        {
            for (int i = 0; i < serveses.Count; i++)
            {
                if (serves.is_compare(serveses[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool add_customer(castoner castonrer)
        {
            int customer_index = find_customer(castonrer);
            if (customer_index != -1)
            {
                return false;
            }
            castoners.Add(castonrer);
            return true;
        }

        public static bool add_serveses(serves serves)
        {
            int customer_index = find_serves(serves);
            if (customer_index != -1)

                return false;

            serveses.Add(serves);
            return true;
        }


        public static bool add_customer(string name, string last_name)
        {
            return add_Customer(new castoner(name, last_name));
        }
        public static

    }
}
