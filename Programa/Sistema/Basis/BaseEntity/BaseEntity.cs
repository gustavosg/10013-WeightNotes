using System;
using ViewModelHelpers;

namespace Basis.BaseEntity
{
    public class BaseEntity : NotifyPropertyChanged, IEntity
    {
        public virtual Int64 Id { get; private set; }
    }
}
