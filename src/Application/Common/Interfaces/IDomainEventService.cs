using CleanTemplate.Domain.Common;
using System.Threading.Tasks;

namespace CleanTemplate.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
