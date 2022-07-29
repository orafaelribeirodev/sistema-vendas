using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema.dal
{
    internal class DataContextFactory
    {
        private static sistemaDataContext dataContext;
        sistemaDataContext DataContext
        {
            get 
            {
                if (dataContext == null)
                    dataContext = new sistemaDataContext();
                return dataContext;

            }


        }
    }
}
