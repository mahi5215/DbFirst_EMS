using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace EMS_DbFirst.Models;

public partial class Department
{

    [Key]
    public int Id { get; set; }

    [Display(Name ="Department Name")]
    [Required(ErrorMessage ="Department name cant be blank")]
    public string DeptName { get; set; } = null!;
    
    [Display(Name ="City")]
    [StringLength(25,MinimumLength =3,ErrorMessage ="City must be 3 chars")]
    public string Location { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
