using System.Collections.Generic;
using System.Linq;
using TakeyourStand.EntityFramework;
using System.IO.Packaging;
using Abp.Authorization;
using TakeyourStand.Authorization;
using System;
using TakeyourStand.Authorization.InventyoryNotification;

namespace TakeyourStand.Migrations.SeedData
{
    [AbpAuthorize(PermissionNames.Pages_MstInventyoryNotification)]
    public class DefaultInventoryNotificationsCreator
    {
        public static List<InventyoryNotification> InitialinventoryNotification { get; private set; }

        private TakeyourStandDbContext _context;

        static DefaultInventoryNotificationsCreator()
        {
            InitialinventoryNotification = new List<InventyoryNotification>
            {
                new InventyoryNotification("Do not send low inventory notifications"),
                new InventyoryNotification("Send notification as soon as an item reaches re-order level"),
                new InventyoryNotification("Send a consolidate low-inventory notification for each outlet, once a day"),
            };
        }

        public DefaultInventoryNotificationsCreator(TakeyourStandDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateinventoryNotification();
        }

        private void CreateinventoryNotification()
        {
            try
            {
                foreach (var inventoryNotification in InitialinventoryNotification)
                {
                    AddinventoryNotificationIfNotExists(inventoryNotification);
                }
            }
            catch (System.Exception ex)
            {
                Console.Write("Error :            - " + ex.ToString());
            }
        }

        private void AddinventoryNotificationIfNotExists(InventyoryNotification inventoryNotification)
        {
            try
            {
                if (_context.tblInventyoryNotification.Any(l => l.Name == inventoryNotification.Name))
                {
                    return;
                }
                _context.tblInventyoryNotification.Add(inventoryNotification);

                _context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                Console.Write("Error :            - " + ex.ToString());

            }
        }
    }
}
