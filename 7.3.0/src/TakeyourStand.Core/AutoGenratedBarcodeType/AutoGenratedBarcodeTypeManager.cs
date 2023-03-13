using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeyourStand.Authorization.AutoGenratedBarcodeType;

namespace TakeyourStand.Authorization.AutoGenratedBarcodeType
{
    public class AutoGenratedBarcodeTypeManager : IDomainService, IAutoGenratedBarcodeTypeManager
    {
        private IRepository<AutoGenratedBarcodeType, long> _clientRepository;

        public AutoGenratedBarcodeTypeManager(IRepository<AutoGenratedBarcodeType, long> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<long> Create(AutoGenratedBarcodeType client)
        {
            return await _clientRepository.InsertAndGetIdAsync(client);
        }

        public async Task<AutoGenratedBarcodeType> Update(AutoGenratedBarcodeType client)
        {
            return await _clientRepository.UpdateAsync(client);
        }

        public async Task Delete(long id)
        {
            await _clientRepository.DeleteAsync(id);
        }

        public async Task<AutoGenratedBarcodeType> GetById(long id)
        {
            return await _clientRepository.GetAsync(id);
        }

        public async Task<List<AutoGenratedBarcodeType>> GetAll()
        {
            return await _clientRepository.GetAllListAsync();
        }
    }
}
