﻿using RestaurantSignalR.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSignalR.Business.Abstract
{
    public interface IMessageService : IGenericService<Message>
    {
    }
}
