﻿using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;
using Abp.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Numerics;
using TakeyourStand.Authorization;

namespace TakeyourStand.Authorization.AutoGenratedBarcodeType
{   
    public class AutoGenratedBarcodeType : FullAuditedEntity<long>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Name { get; set; }

        public AutoGenratedBarcodeType()
        {
        }

        public AutoGenratedBarcodeType(string name)
        {
            Name = name;
        }
    }
}
