using System.Collections.Generic;
using System.Linq;
using TakeyourStand.EntityFramework;
using System.IO.Packaging;
using Abp.Authorization;
using TakeyourStand.Authorization;
using System;
using TakeyourStand.Authorization.AutoGenratedBarcodeType;

namespace TakeyourStand.Migrations.SeedData
{
    [AbpAuthorize(PermissionNames.Pages_MstAutoGenratedBarcodeType)]
    public class DefaultAutoGenratedBarcodeTypeCreator
    {
        public static List<AutoGenratedBarcodeType> InitialAutoGenratedBarcodeType { get; private set; }

        private TakeyourStandDbContext _context;

        static DefaultAutoGenratedBarcodeTypeCreator()
        {
            InitialAutoGenratedBarcodeType = new List<AutoGenratedBarcodeType>
            {
                new AutoGenratedBarcodeType("8-digit alphanumeric"),
                new AutoGenratedBarcodeType("13-digit numeric"),
                new AutoGenratedBarcodeType("6-digit numeric"),
            };
        }

        public DefaultAutoGenratedBarcodeTypeCreator(TakeyourStandDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateAutoGenratedBarcodeType();
        }

        private void CreateAutoGenratedBarcodeType()
        {
            try
            {
                foreach (var AutoGenratedBarcodeType in InitialAutoGenratedBarcodeType)
                {
                    AddAutoGenratedBarcodeTypeIfNotExists(AutoGenratedBarcodeType);
                }
            }
            catch (System.Exception ex)
            {
                Console.Write("Error :            - " + ex.ToString());
            }
        }

        private void AddAutoGenratedBarcodeTypeIfNotExists(AutoGenratedBarcodeType AutoGenratedBarcodeType)
        {
            try
            {
                if (_context.tblAutoGenratedBarcodeType.Any(l => l.Name == AutoGenratedBarcodeType.Name))
                {
                    return;
                }
                _context.tblAutoGenratedBarcodeType.Add(AutoGenratedBarcodeType);

                _context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                Console.Write("Error :            - " + ex.ToString());

            }
        }
    }
}
