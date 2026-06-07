using Application.Database;
using Application.Domain;
using Application.Repository;
using Application.Repository.Interfaces;
using Application.Service.Interfaces;

namespace Application.Service
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;

        public NotificationService()
        {
            _notificationRepository = new NotificationDatabaseRepository(AppDb.CreateContext());
        }

        public List<Notification> GetAll()
        {
            return _notificationRepository.GetAllWithReceiver();
        }

        public Notification GetById(int id)
        {
            var notification = _notificationRepository.Get(id);
            if (notification == null)
                throw new Exception($"Notifikacija sa ID {id} nije pronađena.");
            return notification;
        }

        public Notification Create(Notification notification)
        {
            return _notificationRepository.Create(notification);
        }

        public Notification Update(Notification notification)
        {
            return _notificationRepository.Update(notification);
        }

        public void Delete(int id)
        {
            _notificationRepository.Delete(id);
        }

        public List<Notification> GetByReceiverId(int receiverId)
        {
            return GetAll()
                .Where(n => n.Reciever.Id == receiverId)
                .OrderByDescending(n => n.CreatedAt)
                .ToList();
        }

        public List<Notification> GetUnread(int receiverId)
        {
            return GetByReceiverId(receiverId)
                .Where(n => !n.IsSeen)
                .ToList();
        }

        public void MarkAllAsRead(int receiverId)
        {
            var unread = GetUnread(receiverId);
            foreach (var n in unread)
            {
                n.MarkAsSeen();
                _notificationRepository.Update(n);
            }
        }
    }
}
