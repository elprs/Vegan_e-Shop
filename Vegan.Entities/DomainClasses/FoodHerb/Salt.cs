﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegan.Entities.FoodHerb
{
    public class Salt : FoodHerb
    {
        public string SubCategory { get; set; } = "Salt";
    }
}
