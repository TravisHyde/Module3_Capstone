﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Web.Models;
namespace Capstone.Web.DAL
{
    public interface IParkDAO
    {

        IList<Park> GetParks();
        Park GetPark(string parkCode);

        
    }
}
