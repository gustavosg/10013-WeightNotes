using System;
using Basis.BaseEntity;

namespace Entities
{
    public class Person : BaseEntity
    {
        public virtual String Name { get; set; }
        public virtual Int16 Age { get; set; }
        public virtual Boolean SexualGender { get; set; }
        public virtual Double Weight { get; set; }
        public virtual Double Height { get; set; }
    }
}
