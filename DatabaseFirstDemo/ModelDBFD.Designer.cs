﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
namespace DatabaseFirstDemo
{
    #region Contexts

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DatabaseFirstDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DatabaseFirstDBEntities object using the connection string found in the 'DatabaseFirstDBEntities' section of the application configuration file.
        /// </summary>
        public DatabaseFirstDBEntities() : base("name=DatabaseFirstDBEntities", "DatabaseFirstDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseFirstDBEntities object.
        /// </summary>
        public DatabaseFirstDBEntities(string connectionString) : base(connectionString, "DatabaseFirstDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseFirstDBEntities object.
        /// </summary>
        public DatabaseFirstDBEntities(EntityConnection connection) : base(connection, "DatabaseFirstDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Employee> Employees
        {
            get
            {
                if ((_Employees == null))
                {
                    _Employees = base.CreateObjectSet<Employee>("Employees");
                }
                return _Employees;
            }
        }
        private ObjectSet<Employee> _Employees;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Employees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployees(Employee employee)
        {
            base.AddObject("Employees", employee);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DatabaseFirstDBModel", Name="Employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Employee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="empID">Initial value of the EmpID property.</param>
        /// <param name="empName">Initial value of the EmpName property.</param>
        /// <param name="salary">Initial value of the Salary property.</param>
        /// <param name="department">Initial value of the Department property.</param>
        public static Employee CreateEmployee(global::System.Int32 empID, global::System.String empName, global::System.Int32 salary, global::System.String department)
        {
            Employee employee = new Employee();
            employee.EmpID = empID;
            employee.EmpName = empName;
            employee.Salary = salary;
            employee.Department = department;
            return employee;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmpID
        {
            get
            {
                return _EmpID;
            }
            set
            {
                if (_EmpID != value)
                {
                    OnEmpIDChanging(value);
                    ReportPropertyChanging("EmpID");
                    _EmpID = StructuralObject.SetValidValue(value, "EmpID");
                    ReportPropertyChanged("EmpID");
                    OnEmpIDChanged();
                }
            }
        }
        private global::System.Int32 _EmpID;
        partial void OnEmpIDChanging(global::System.Int32 value);
        partial void OnEmpIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String EmpName
        {
            get
            {
                return _EmpName;
            }
            set
            {
                OnEmpNameChanging(value);
                ReportPropertyChanging("EmpName");
                _EmpName = StructuralObject.SetValidValue(value, false, "EmpName");
                ReportPropertyChanged("EmpName");
                OnEmpNameChanged();
            }
        }
        private global::System.String _EmpName;
        partial void OnEmpNameChanging(global::System.String value);
        partial void OnEmpNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Salary
        {
            get
            {
                return _Salary;
            }
            set
            {
                OnSalaryChanging(value);
                ReportPropertyChanging("Salary");
                _Salary = StructuralObject.SetValidValue(value, "Salary");
                ReportPropertyChanged("Salary");
                OnSalaryChanged();
            }
        }
        private global::System.Int32 _Salary;
        partial void OnSalaryChanging(global::System.Int32 value);
        partial void OnSalaryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Department
        {
            get
            {
                return _Department;
            }
            set
            {
                OnDepartmentChanging(value);
                ReportPropertyChanging("Department");
                _Department = StructuralObject.SetValidValue(value, false, "Department");
                ReportPropertyChanged("Department");
                OnDepartmentChanged();
            }
        }
        private global::System.String _Department;
        partial void OnDepartmentChanging(global::System.String value);
        partial void OnDepartmentChanged();

        #endregion

    }

    #endregion

}
