

#region References

using Basis.BaseEntity;
using System;

#endregion

namespace Entities
{
    public class Foods : BaseEntity
    {
        public virtual String Name { get; set; }

        public virtual Double Weight { get; set; }

        public virtual Double Protein { get; set; }

        public virtual Double Fiber { get; set; }

        public virtual Gender Gender { get; set; }


    }
}
