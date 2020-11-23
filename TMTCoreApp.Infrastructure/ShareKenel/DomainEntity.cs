﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TMTCoreApp.Infrastructure.ShareKenel
{
    public abstract class DomainEntity<T>
    {
        public T Id { get; set; }
        public bool IsTransient() {
            return Id.Equals(default(T));
        }
    }
}
