﻿using SMEcommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Services.Interfaces
{
    public interface IProductService:IService<Item>
    {
        
        bool Save();
    }
}
