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
// Classe: Person.cs
// Tipo: Model
// Funcionalidade: Mapeamento de campos para a entidade Person
// Data de Criação: 26/01/2014
// Autor: Gustavo Souza Gonçalves
// -------------------------------------------------------------------------

#region References

using System;
using System.Data.Linq.Mapping;
using ViewModelHelpers;

#endregion

namespace WeightNotes.Model.Entities
{
    [Table]
    public class Person : NotifyPropertyChanged
    {
        public Person()
        {

        }

        private Int64 _id;
        [Column(Name = "Id", CanBeNull = false, DbType = "long not null identity", IsDbGenerated = true, IsPrimaryKey = true, AutoSync = AutoSync.OnInsert)]
        public Int64 Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        private String _name;
        [Column(Name = "Name", CanBeNull = false, DbType = "nchar(50)")]
        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private Int64 _weightWatchersCode;
        [Column(Name = "WeightWatchersCode", CanBeNull = true, DbType = "long null", IsDbGenerated = true)]
        public Int64 WeightWatchersCode
        {
            get { return _weightWatchersCode; }
            set
            {
                _weightWatchersCode = value;
                OnPropertyChanged("WeightWatchersCode");
            }
        }

        private DateTime _dateOfBirth;
        [Column(Name = "DateOfBirth", CanBeNull = false, DbType = "datetime")]
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                _dateOfBirth = value;
                OnPropertyChanged("DateOfBirth");
            }
        }

        private Boolean _sexualGender;
        [Column(Name = "SexualGender", CanBeNull = false, DbType = "bool")]
        public Boolean SexualGender
        {
            get { return _sexualGender; }
            set
            {
                _sexualGender = value;
                OnPropertyChanged("SexualGender");
            }
        }

        private Double _weight;
        [Column(Name = "Weight", CanBeNull = false, DbType = "float")]
        public Double Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged("Weight");
            }
        }

        private Double _height;
        [Column(Name = "Height", CanBeNull = false, DbType = "float")]
        public Double Height
        {
            get { return _height; }
            set
            {
                _height = value;
                OnPropertyChanged("Height");
            }
        }

        private Double _targetHeight;
        [Column(Name = "TargetHeight", CanBeNull = false, DbType = "float")]
        public Double TargetHeight
        {
            get { return _targetHeight; }
            set
            {
                _targetHeight = value;
                OnPropertyChanged("Height");
            }
        }
        

    }
}
