using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CRUD.Models
{
    public class Seller

    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "{0} deve ter entre {2} e {1} caracteres.")]
        [DisplayName("Nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "{0} deve ter entre {2} e {1} caracteres.")]
        [DisplayName("Sobrenome")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [EmailAddress(ErrorMessage = "Informe um email válido.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [DataType(DataType.Date)]
        [DisplayName("Data de Aniversário")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [DisplayName("Salário")]
        public double BaseSalary { get; set; }
        [DisplayName("Departamento")]
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string surname, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            SurName = surname;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }


        public void AddSales(SalesRecord sr) 
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
