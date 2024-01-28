﻿using RestaurantSignalR.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSignalR.DataAccess.Abstract
{
	public interface IBasketDal : IGenericDal<Basket>
	{
        List<Basket> GetBasketByMenuTableNumber(int id);
    }
}
