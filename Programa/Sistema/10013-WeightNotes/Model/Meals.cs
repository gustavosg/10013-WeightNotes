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


#region References

using System;
using Basis.BaseEntity;

#endregion

namespace _10013_WeightWatchersNotes.Model
{
    public class Meals : BaseEntity
    {
        public virtual String[] MealType
        {
            get
            {
                return new String[]
                {
                        "Café da manhã", 
                        "Lanche manhã",
                        "Almoço",
                        "Lanche da Tarde",
                        "Café da tarde", 
                        "Jantar"
                };
            }
            set {}
        }

        public virtual Foods[] Foods { get; set; }

        public virtual Int16 TotalPoints { get; set; }
    }
}
