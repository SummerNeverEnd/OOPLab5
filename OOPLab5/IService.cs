﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    interface IService : IServiceChange, IServiceCreate, IServiceFind
    {
    }
}