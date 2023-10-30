namespace ProdMvc.Models;
using System.ComponentModel.DataAnnotations;
public class Product
{
    [Key]
    [Required(ErrorMessage="ID Required")]
    [Display(Name="Product ID")]
    public int Id{get; set;}
    [Required(ErrorMessage="Name cannot be Blank")]
    [Display(Name="Enter Name")]
    public string ?Name{get; set;}
    [Range(100,10000,ErrorMessage="Price should be between 100 and 10000")]
    public int Price{get; set;}
    public int Stock{get; set;}


}