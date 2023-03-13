using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeyourStand.Authorization.AutoGenratedBarcodeType.Dto;

namespace TakeyourStand.Authorization.AutoGenratedBarcodeType
{
    public interface IAutoGenratedBarcodeTypeAppService : IApplicationService
    {
        Task<CreateAutoGenratedBarcodeTypeOutput> CreateAutoGenratedBarcodeType(CreateAutoGenratedBarcodeTypeInput input);
        Task<UpdateAutoGenratedBarcodeTypeOutput> UpdateAutoGenratedBarcodeType(UpdateAutoGenratedBarcodeTypeInput input);
        Task DeleteAutoGenratedBarcodeType(long id);
        Task<GetAutoGenratedBarcodeTypeByIdOutput> GetById(long id);
        Task<GetAllAutoGenratedBarcodeTypeOutput> GetAllAutoGenratedBarcodeTypes();
    }
}
