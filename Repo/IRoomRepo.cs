﻿using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IRoomRepo:IGenRepo<Room>
    {
        List<Room> GetById(int id);
    }
}
