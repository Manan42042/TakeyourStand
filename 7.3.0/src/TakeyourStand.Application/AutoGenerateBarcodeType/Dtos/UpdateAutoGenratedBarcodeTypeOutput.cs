﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeyourStand.Authorization.AutoGenratedBarcodeType.Dto
{
    public class UpdateAutoGenratedBarcodeTypeOutput : FullAuditedEntityDto<long>
    {
        public string Name { get; set; }
    }
}
