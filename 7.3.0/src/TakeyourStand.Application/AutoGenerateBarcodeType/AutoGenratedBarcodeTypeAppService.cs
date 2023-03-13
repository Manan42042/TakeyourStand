using Abp.AutoMapper;
using Abp.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeyourStand.Authorization.AutoGenratedBarcodeType;
using TakeyourStand.Authorization.AutoGenratedBarcodeType.Dto;


namespace TakeyourStand.Authorization.AutoGenratedBarcodeType
{
    public class AutoGenratedBarcodeTypeAppService : IAutoGenratedBarcodeTypeAppService
    {
        private IAutoGenratedBarcodeTypeManager _AutoGenratedBarcodeTypeManager;

        public AutoGenratedBarcodeTypeAppService(IAutoGenratedBarcodeTypeManager AutoGenratedBarcodeTypeManager)
        {
            _AutoGenratedBarcodeTypeManager = AutoGenratedBarcodeTypeManager;
        }

        [Obsolete]
        public async Task<CreateAutoGenratedBarcodeTypeOutput> CreateAutoGenratedBarcodeType(CreateAutoGenratedBarcodeTypeInput input)
        {
            var AutoGenratedBarcodeType =  input.MapTo<AutoGenratedBarcodeType>(); //mapeia o input para o tipo AutoGenratedBarcodeType

            var createdAutoGenratedBarcodeTypeId = await _AutoGenratedBarcodeTypeManager.Create(AutoGenratedBarcodeType); //como a funcao no repositorio eh "createandgetID", ao criar o AutoGenratedBarcodeType, um Id eh retornado e passado a variavel
            return new CreateAutoGenratedBarcodeTypeOutput
            {
                Id = createdAutoGenratedBarcodeTypeId //o output usa a nova id para mostrar o novo AutoGenratedBarcodeType
            }; 
        }

        public async Task DeleteAutoGenratedBarcodeType(long id)
        {
            await _AutoGenratedBarcodeTypeManager.Delete(id);
        }

        [Obsolete]
        public async Task<GetAllAutoGenratedBarcodeTypeOutput> GetAllAutoGenratedBarcodeTypes()
        {
            var AutoGenratedBarcodeTypesdata = await _AutoGenratedBarcodeTypeManager.GetAll();
            return new GetAllAutoGenratedBarcodeTypeOutput
            {
                AutoGenratedBarcodeTypes = AutoGenratedBarcodeTypesdata.MapTo<List<GetAllAutoGenratedBarcodeTypeItem>>()
            };
        }

        [Obsolete]
        public async Task<GetAutoGenratedBarcodeTypeByIdOutput> GetById(long id)
        {
           
            var AutoGenratedBarcodeType = await _AutoGenratedBarcodeTypeManager.GetById(id);
            return AutoGenratedBarcodeType.MapTo<GetAutoGenratedBarcodeTypeByIdOutput>();
        }

        [Obsolete]
        public async Task<UpdateAutoGenratedBarcodeTypeOutput> UpdateAutoGenratedBarcodeType(UpdateAutoGenratedBarcodeTypeInput input)
        {
            var AutoGenratedBarcodeType = input.MapTo<AutoGenratedBarcodeType>();
            var AutoGenratedBarcodeTypeUpdated = await _AutoGenratedBarcodeTypeManager.Update(AutoGenratedBarcodeType);
            return AutoGenratedBarcodeTypeUpdated.MapTo<UpdateAutoGenratedBarcodeTypeOutput>();
        }
    }
}

