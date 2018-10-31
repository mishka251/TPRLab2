using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPRLab2_2
{
    /// <summary>
    /// Класс ситуации(события) ЛВМ и инфа для вывода
    /// </summary>
    class Situation
    {
        /// <summary>
        /// Вреоятность события(вводится для инициирующих на форме, для остальных считается)
        /// </summary>
        public double property;
        /// <summary>
        /// Название - для подставовки в формула алгебры логики
        /// </summary>
        public string Name;
        /// <summary>
        /// Список ситуаций находящихся ниже(для иницириующего есть, пустой)
        /// </summary>
        public List<Situation> down;
        /// <summary>
        /// Вариант операции - "И" или "ИЛИ"
        /// </summary>
        public select sel;
        /// <summary>
        /// Глубина - расстояние от корня(опасного состояния) 
        /// для вывода
        /// </summary>
        public int depth;
        /// <summary>
        /// Индекс - индекс в списке down для предка
        /// для вывода
        /// </summary>
        public int index;

        /// <summary>
        /// Конструктор 
        /// </summary>
        /// <param name="property">Вероятность</param>
        /// <param name="name">Название</param>
        /// <param name="dep">Глубина</param>
        /// <param name="ind">Индекс</param>
        /// <param name="down">Потомки</param>
        /// <param name="sel">Вариант "И" или "ИЛИ"</param>
        public Situation(double property, string name, int dep, int ind = 1, List<Situation> down = null, select sel = select.AND)
        {
            depth = dep;
            this.property = property;
            Name = name;
            this.down = down ?? new List<Situation>();
            this.sel = sel;
            index = ind;
        }

        /// <summary>
        /// Рассчет вероятности
        /// для инициирующего возвращает prop
        /// для других рассчитывает через нижестоящие
        /// </summary>
        /// <returns>вероятность наступления события</returns>
        public double CalculateProp()
        {
            if (down.Count == 0)
                return property;
            double prop = 1;
            if (sel == select.AND)
                for (int i = 0; i < down.Count; i++)
                    prop *= down[i].CalculateProp();
            else//"ИЛИ"  
            {
                // 1 - (1-х1)(1-х2)...
                for (int i = 0; i < down.Count; i++)
                    prop *= 1 - down[i].CalculateProp();
                prop = 1 - prop;
            }
            property = prop;
            return prop;
        }

        /// <summary>
        /// Формула алгебры логики в базисе конъюнкция-отрицание
        /// </summary>
        /// <returns>стркоа с формулой</returns>
        public string FALBazis()
        {
            if (down.Count == 0)
                return Name;
            string form = "";
            if (sel == select.AND)
            {
                form = "(" + down[0].FALBazis();
                for (int i = 1; i < down.Count; i++)
                    form += " AND " + down[i].FALBazis();
                form += ")";
            }

            else
            {
                form = "! (! " + down[0].FALBazis();
                for (int i = 1; i < down.Count; i++)
                    form += " AND ! " + down[i].FALBazis();
                form += ")";
            }
            return form;
        }
        /// <summary>
        /// функция алгебры логики
        /// </summary>
        /// <returns></returns>
        public string FAL()
        {
            if (down.Count == 0)
                return Name;
            string form = "";
            if (sel == select.AND)
            {
                form = "(" + down[0].FAL();
                for (int i = 1; i < down.Count; i++)
                    form += down[i].FAL();
                form += ")";
            }

            else
            {
                form = "(" + down[0].FAL();
                for (int i = 1; i < down.Count; i++)
                    form += " U " + down[i].FAL();
                form += ")";
            }
            return form;
        }
    }
}
