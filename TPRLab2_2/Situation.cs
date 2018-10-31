using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPRLab2_2
{
    class Situation
    {
        public double property;
        public string Name;
        public List<Situation> down;
        public select sel;
        public int depth;
        public int index;

        public Situation(double property, string name, int dep, int ind = 1, List<Situation> down = null, select sel = select.AND)
        {
            depth = dep;
            this.property = property;
            Name = name;
            this.down = down ?? new List<Situation>();
            this.sel = sel;
            index = ind;
        }

        public double CalculateProp()
        {
            if (down.Count == 0)
                return property;
            double prop = 1;
            if (sel == select.AND)
                for (int i = 0; i < down.Count; i++)
                    prop *= down[i].CalculateProp();
            else
            {
                for (int i = 0; i < down.Count; i++)
                    prop *= 1 - down[i].CalculateProp();
                prop = 1 - prop;
            }
            property = prop;
            return prop;
        }

        public string Formula()
        {
            if (down.Count == 0)
                return Name;
            string form = "";
            if (sel == select.AND)
            {
                form = "(" + down[0].Formula();
                for (int i = 1; i < down.Count; i++)
                    form += " AND " + down[i].Formula();
                form += ")";
            }

            else
            {
                form = "!(!" + down[0].Formula();
                for (int i = 1; i < down.Count; i++)
                    form += " AND !" + down[i].Formula();
                form += ")";
            }
            return form;
        }
        public string Formula1()
        {
            if (down.Count == 0)
                return Name;
            string form = "";
            if (sel == select.AND)
            {
                form = "(" + down[0].Formula1();
                for (int i = 1; i < down.Count; i++)
                    form += down[i].Formula1();
                form += ")";
            }

            else
            {
                form = "(" + down[0].Formula1();
                for (int i = 1; i < down.Count; i++)
                    form += " U " + down[i].Formula1();
                form += ")";
            }
            return form;
        }
    }
}
