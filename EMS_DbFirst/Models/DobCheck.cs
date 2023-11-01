using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EMS_DbFirst.Models
{
    public class DobCheck:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime birthdate=Convert.ToDateTime(value);
            int year=birthdate.Year;
            int currentYear=DateTime.Now.Year;
            if(currentYear-year>=25)
                return true;
            else
                return false;
        }
    }
}