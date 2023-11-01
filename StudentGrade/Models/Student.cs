using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StudentGrade.Models
{
    public class Student
    {
        [Key]
        public int StudentId{get;set;}
        public string StudentName{get;set;}
        public DateTime DateOfBirth{get;set;}
        public byte[] Photo{get;set;}
        public decimal Height{get;set;}
        public float Weight{get;set;}
        public Grade Grade{get;set;}
    }
}