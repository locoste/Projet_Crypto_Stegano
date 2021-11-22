using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Premier
    {

        private List<int> list_premier;

        private static Premier instance;

        public Premier()
        {
            
        }

        public static Premier getInstance()
        {
            if (instance == null)
            {
                instance = new Premier();
            }
            return instance;
        }

        public List<int> get_premier()
        {
            return this.list_premier;
        }

        public void set_premier(int nb_max)
        {
            this.list_premier = new List<int>();

            int pas = 4;

            this.list_premier.Add(2);
            this.list_premier.Add(3);

            for (int nombre = 5; nombre < nb_max; nombre += pas)
            {
                if (premier(nombre))
                {
                    this.list_premier.Add(nombre);
                }
                pas = 6 - pas;
            }
        }

        private Boolean premier(int nb)
        {
            int pas = 4;
            double sqrt_nb = Math.Sqrt(nb) + 1;

            for (int i = 5; i < sqrt_nb; i += pas)
            {
                if (nb % i == 0)
                {
                    return false;
                }

                pas = 6 - pas;
            }

            return true;
        }
    }
}
