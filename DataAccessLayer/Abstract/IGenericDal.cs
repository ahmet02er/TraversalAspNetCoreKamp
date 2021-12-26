﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IGenericDal<T>
    {
        void Insert(T parametre);
        void Delete(T parametre);
        void Update(T parametre);
        List<T> GetList();
    }
}
