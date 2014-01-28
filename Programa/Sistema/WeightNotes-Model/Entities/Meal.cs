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
using System.Data.Linq.Mapping;
using ViewModelHelpers;

#endregion

namespace WeightNotes_Model.Entities
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

        private String[] _mealType;

        public String[] MealType
        {
            get { return _mealType; }
            set { _mealType = value; }
        }

    }
}
