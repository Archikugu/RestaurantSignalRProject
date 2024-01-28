﻿using RestaurantSignalR.Business.Abstract;
using RestaurantSignalR.DataAccess.Abstract;
using RestaurantSignalR.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSignalR.Business.Concrete
{
	public class BasketManager : IBasketService
	{
		private readonly IBasketDal _basketDal;
		public BasketManager(IBasketDal basketDal)
		{
			_basketDal = basketDal;
		}
		public void TAdd(Basket entity)
		{
			_basketDal.Add(entity);
		}

		public void TDelete(Basket entity)
		{
			_basketDal.Delete(entity);
		}

		public List<Basket> TGetBasketByMenuTableNumber(int id)
		{
			return _basketDal.GetBasketByMenuTableNumber(id);
		}

		public Basket TGetById(int id)
		{
			return _basketDal.GetById(id);
		}

		public List<Basket> TGetListAll()
		{
			return _basketDal.GetListAll();
		}

		public void TUpdate(Basket entity)
		{
			_basketDal.Update(entity);
		}
	}
}