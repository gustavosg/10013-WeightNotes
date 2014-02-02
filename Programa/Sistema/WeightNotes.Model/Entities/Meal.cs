// -------------------------------------------------------------------------
// Descrição do Programa:
// Sistema criado com o intuito de auxiliar o usuário à regular seu processo
// de emagrecimento no dia a dia, utilizando métodos de cálculo à partir
// de sua rotina diária de alimentação e exercícios.
// -------------------------------------------------------------------------
// Descrição do Projeto:
// Solution: WeightNotes.FrontEnd
// Funcionalidade: Projeto principal do sistema
// -------------------------------------------------------------------------
// Descrição da Classe:
// Classe: Meal.cs
// Tipo: Model
// Funcionalidade: Mapeamento de campos para a entidade Meal
// Data de Criação: 27/01/2014
// Autor: Gustavo Souza Gonçalves
// -------------------------------------------------------------------------

#region References

using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using ViewModelHelpers;


#endregion

namespace WeightNotes.Model.Entities
{
    [Table]
    public class Meal : NotifyPropertyChanged
    {
        public Meal()
        {

        }

        private Int16 _id;
        [Column(Name = "Id", CanBeNull = false, DbType = "int not null identity", IsDbGenerated = true, IsPrimaryKey = true, AutoSync = AutoSync.OnInsert)]
        public Int16 Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        [Column(Name = "_foodId")]
        protected Int16 _foodId;

        private String[] _mealType;
        [Column(Name = "MealType", CanBeNull = false, DbType = "String")]
        public String[] MealType
        {
            get { return _mealType; }
            set
            {
                _mealType = value;
                OnPropertyChanged("MealType");
            }
        }

        private Int16 _totalPoints;
        [Column(Name = "TotalPoints", CanBeNull = true)]
        public Int16 TotalPoints
        {
            get { return _totalPoints; }
            set
            {
                _totalPoints = value;
                OnPropertyChanged("TotalPoints");
            }
        }

        // ToDo Gustavo: Many-To-Many Relationship with Food

    }
}
