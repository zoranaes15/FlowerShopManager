using Application.Database;
using Application.Domain;
using Application.Repository.Base;
using Application.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public class NotificationDatabaseRepository : CrudDatabaseRepository<Notification, FlowerShopManagerDbContext>, INotificationRepository
    {
        public NotificationDatabaseRepository(FlowerShopManagerDbContext context) : base(context) {}

    }
}
