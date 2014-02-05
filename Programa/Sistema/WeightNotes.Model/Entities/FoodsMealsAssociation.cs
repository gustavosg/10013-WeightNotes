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
// Classe: FoodMealsAssociation.cs
// Tipo: Model
// Funcionalidade: Classe de relacionamento Many-To-Many para Linq-To-SQL
// Data de Criação: 04/02/2014
// Autor: Gustavo Souza Gonçalves
// -------------------------------------------------------------------------

#region References

using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using ViewModelHelpers;

#endregion

namespace WeightNotes.Model.Entities
{
    [Table(Name = "FoodsMealsAssociation")]
    public class FoodsMealsAssociation : NotifyPropertyChanged
    {
        #region Constructor

        public FoodsMealsAssociation()
        {

        }

        #endregion

        #region Properties

        private Int64 _id;
        [Column(Name = "Id",
            DbType = "long not null identity",
            CanBeNull = false,
            IsPrimaryKey = true,
            IsDbGenerated = true,
            AutoSync = AutoSync.OnInsert)]
        public Int64 Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        #endregion
    }
}
