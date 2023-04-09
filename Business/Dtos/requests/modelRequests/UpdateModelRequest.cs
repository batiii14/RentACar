﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.Model
{
    public class UpdateModelRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DailyPrice { get; set; }
    }
}
