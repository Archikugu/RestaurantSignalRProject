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
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;
        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }
        public void TAdd(Message entity)
        {
            _messageDal.Add(entity);
        }

        public void TDelete(Message entity)
        {
            _messageDal.Delete(entity);
        }

        public Message TGetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> TGetListAll()
        {
            return _messageDal.GetListAll();
        }

        public void TUpdate(Message entity)
        {
            _messageDal.Update(entity);
        }
    }
}