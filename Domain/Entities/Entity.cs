using System;

namespace Domain.Entities
{
    public class Entity
    {
        public Guid Id { get; protected set; } = Guid.NewGuid();
    }
}