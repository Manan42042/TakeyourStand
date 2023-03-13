using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TakeyourStand.Authorization.AutoGenratedBarcodeType;

namespace TakeyourStand.Authorization.AutoGenratedBarcodeType
{
    public interface IAutoGenratedBarcodeTypeManager
    {
        Task<long> Create(AutoGenratedBarcodeType client);
        Task<AutoGenratedBarcodeType> Update(AutoGenratedBarcodeType client);
        Task Delete(long id);
        Task<AutoGenratedBarcodeType> GetById(long id);
        Task<List<AutoGenratedBarcodeType>> GetAll();
    }
}
