using SocialArticleManager.Api.Domain.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SocialArticleManager.Api.Domain.Common.Models
{
    public abstract class Entity<TId>:IHasDomainEvents
    {
        public TId Id { get; protected set; }

        private readonly List<IDomainEvent> _domainEvents = new();
        public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        protected Entity(TId id)
        {
            Id = id;
        }
        protected Entity()
        {
        }
        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }
        public void AddDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

    }
}
