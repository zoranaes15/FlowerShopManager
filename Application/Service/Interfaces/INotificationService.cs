using Application.Domain;

namespace Application.Service.Interfaces
{
    public interface INotificationService
    {
        List<Notification> GetAll();
        Notification GetById(int id);
        Notification Create(Notification notification);
        Notification Update(Notification notification);
        void Delete(int id);
        List<Notification> GetByReceiverId(int receiverId);
        List<Notification> GetUnread(int receiverId);
        void MarkAllAsRead(int receiverId);
    }
}
