﻿using MediatR;
namespace LiquorInStock.Shared.SeedWork
{
    public abstract class Entity
    {
        int? _requestedHashCode;
        int _Id;
        public virtual int Id
        {
            get => _Id;
            protected set => _Id = value;
        }

        private List<INotification> _domainEvents;
        public IReadOnlyCollection<INotification> DomainEvents => _domainEvents?.AsReadOnly();

        public void RemoveDomainEvent(INotification eventItem) => _domainEvents?.Remove(eventItem);

        public void ClearDomainEvents() => _domainEvents?.Clear();


        public bool IsTransient() => this.Id == default(Int32);

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Entity))
                return false;

            if (Object.ReferenceEquals(this, obj))
                return true;

            if (this.GetType() != obj.GetType())
                return false;

            Entity item = (Entity)obj;

            if (item.IsTransient() || this.IsTransient())
                return false;
            else
                return item.Id == this.Id;
        }

        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                if (!_requestedHashCode.HasValue)
                    _requestedHashCode = this.Id.GetHashCode() ^ 31;

                return _requestedHashCode.Value;
            }
            else
                return base.GetHashCode();

        }
        public static bool operator ==(Entity left, Entity right)
        {
            if (Object.Equals(left, null))
                return (Object.Equals(right, null)) ? true : false;
            else
                return left.Equals(right);
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }
    }
    public abstract class AuditableEntity : Entity
    {
        public DateTime AddedOn { get; set; }
        public int AddedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
