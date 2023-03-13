using TakeyourStand.EntityFramework;
using EntityFramework.DynamicFilters;
using System;

namespace TakeyourStand.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private TakeyourStandDbContext _context;

        public InitialHostDbBuilder(TakeyourStandDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            try
            {
                _context.DisableAllFilters();

                new DefaultEditionsCreator(_context).Create();
                new DefaultLanguagesCreator(_context).Create();
                new HostRoleAndUserCreator(_context).Create();
                new DefaultSettingsCreator(_context).Create();
                new DefaultAutoGenratedBarcodeTypeCreator(_context).Create();
                new DefaultInventoryNotificationsCreator(_context).Create();
            }
            catch (System.Exception ex)
            {
                Console.Write(Environment.NewLine);
                Console.Write("Error :            - " + ex.ToString());
            }
        }
    }
}
