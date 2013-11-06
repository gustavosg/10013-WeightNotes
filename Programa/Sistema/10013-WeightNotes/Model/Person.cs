// --------------------------------------------------------------------------------------------------
// Descrição do Sistema:
//
//
//
// --------------------------------------------------------------------------------------------------
// Descrição da Classe:
//
//
//
// --------------------------------------------------------------------------------------------------

#region Preferences

using System;
using Basis.BaseEntity;

#endregion

namespace _10013_WeightWatchersNotes.Model
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
