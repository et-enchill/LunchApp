﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunch_App.Models
{
    public class MenuModel
    {

        public Guid CompanyId { get; set; }

        public Guid MainDishId { get; set; }

         public Guid PkId { get; set; }
       

        public Guid SideDishId { get; set; }

        public Guid CondiDishId { get; set; }

        public string MainDish { get; set; }

        public string SideDish { get; set; }

        public string CondiDish { get; set; }

        public DateTime StartAt { get; set; }

        public DateTime EndAt { get; set; }

        public string Price { get; set; }

        public int IsActive { get; set; }


    }
}