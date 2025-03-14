﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
   public interface IGenericService<T> where T:class,new()
    {
        void Insert(T p);
        void Delete(T p);
        void Update(T p);
        T GetById(int id);
        List<T> GetListAll();
    }
}
