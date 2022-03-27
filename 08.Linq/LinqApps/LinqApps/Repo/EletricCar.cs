﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Repo
{
    public class EletricCar : Car
    {
        public int Autonomy { get; set; }
        public override string ToString()
        {
            return base.ToString() + $" with autonomy: {Autonomy} km";
        }
    }
}
