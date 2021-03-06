﻿using System;

namespace Anet.Data.Entity
{
    public interface IEntityAudit<TKey> : IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
    }

    public interface IEntityAudit : IEntityAudit<long>
    {
    }
}
