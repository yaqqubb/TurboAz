﻿using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ2.Enums;

namespace TurboAZ2.Entities
{
    public class Elan
    {
       


            public int Id { get; set; }
            public int ModelId { get; set; }
            public int March { get; set; }
            public double Price { get; set; }
            public BanNovu Banlar { get; set; }
            public YanacaqNovu Yanacaqlar { get; set; }
            public SuretQutusu SuretQutusu { get; set; }
            public Oturucu Transmission { get; set; }

            public DateTime CreatedAt { get; set; }

            public int CreatedBy { get; set; }
            public int? LastModifiedBy { get; set; }

            public DateTime? LastModifiedAt { get; set; }

            public int? DeletedBy { get; set; }

            public DateTime? DeletedAt { get; set; }





        
    }
}
