﻿using DataAccess;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CategoryMan
    {
         Repository<categories> categoryrepo = new Repository<categories>();    

        public List<categories>GetAll()
        {
            return categoryrepo.List();


        }

        public int BusAdd(categories c)
        {
            if(c.categoryname.Length <= 4)
            {


                return -1;
            }

            return categoryrepo.Insert(c);

        }


    }
}
