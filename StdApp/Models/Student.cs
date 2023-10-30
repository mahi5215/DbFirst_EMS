namespace StdApp.Models;
using System.ComponentModel.DataAnnotations;
public class Student
{
    [Key]
    [Required(ErrorMessage="ID Required")]
    [Display(Name="Enter ID")]
    public int Id{get; set;}
    [Required(ErrorMessage="Name Required")]
    [Display(Name="Enter Name")]
    public string Name{get; set;}
    public int Hindi{get; set;}
    public int Maths{get; set;}
    public int English{get; set;}

}