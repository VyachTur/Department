using System;

namespace Department {
    struct Employee {

        #region Constructors

        /// <summary>
        /// Конструктор (1)
        /// </summary>
        /// <param name="name">Имя сотрудника</param>
        /// <param name="family">Фамилия сотрудника</param>
        /// <param name="sirname">Отчество сотрудника</param>
        /// <param name="birthDate">Дата рождения сотрудника</param>
        public Employee(string name, string family, string sirname, DateTime birthDate) {
            Id = ++Count_Emp;
            this.name_Emp = name;
            this.family_Emp = family;
            this.sirname_Emp = sirname;
            this.birthDate_Emp = birthDate;
        }

        /// <summary>
        /// Конструктор (2)
        /// </summary>
        /// <param name="name">Имя сотрудника</param>
        /// <param name="family">Фамилия сотрудника</param>
        /// <param name="birthDate">Дата рождения сотрудника</param>
        public Employee(string name, string family, DateTime birthDate) :
                            this(name, family, String.Empty, birthDate) {
            Id = ++Count_Emp;
        }

        #endregion // Constructors


        #region Methods

        /// <summary>
        /// Информация о сотруднике
        /// </summary>
        /// <returns>Id, Family, Name, Sirname, BirthDate</returns>
        public string returnEmployeeInfo() {
            return $"| { this.Id } | { this.Family } { this.Name } { this.Sirname } | { this.BirthDate.ToShortDateString() } г.р. |";
        }

        #endregion // Methods


        #region Property
        /// <summary>
        /// Идентификатор сотрудника
        /// </summary>
        public uint Id { get; private set; }

        /// <summary>
        /// Имя сотрудника
        /// </summary>
        public string Name {
            get { return this.name_Emp.Substring(0, 1).ToUpper() + this.name_Emp.Substring(1, this.name_Emp.Length - 1).ToLower(); }   // первая буква имени прописная, остальные строчные
            set { this.name_Emp = value; }
        }

        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        public string Family {
            get { return this.family_Emp.Substring(0, 1).ToUpper() + this.family_Emp.Substring(1, this.family_Emp.Length - 1).ToLower(); }   // первая буква фамилии прописная, остальные строчные
            set { this.family_Emp = value; }
        }

        /// <summary>
        /// Отчество сотрудника
        /// </summary>
        public string Sirname {
            get { return this.sirname_Emp.Substring(0, 1).ToUpper() + this.sirname_Emp.Substring(1, this.sirname_Emp.Length - 1).ToLower(); }   // первая буква отчества прописная, остальные строчные
            set { this.sirname_Emp = value; }
        }

        /// <summary>
        /// Дата рождения сотрудника
        /// </summary>
        public DateTime BirthDate {
            get { return new DateTime(birthDate_Emp.Year, birthDate_Emp.Month, birthDate_Emp.Day); }
            set { this.birthDate_Emp = value; }
        }

        #endregion // Property


        #region Fields
        
        private string name_Emp;        // имя сотрудника
        private string family_Emp;      // фамилия сотрудника
        private string sirname_Emp;     // отчество сотрудника
        private DateTime birthDate_Emp; // дата рождения сотрудника

        private static uint Count_Emp = 0;  // счетчик сотрудников для определения идентификатора сотрудника (Id)

        #endregion // Fields
    }
}
