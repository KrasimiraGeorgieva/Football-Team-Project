namespace FootballTeamWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    public partial class Player
    {   
             
        public int ID { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        //[Column(TypeName = "FullName")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Full name cannot be longer than 100 characters." )]        
        public string FullName { get; set; }

        [Required]        
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? BornDate{ get; set; }

         
        public string PersonalID { get; set; }

        [Required]
        [Column]
        [StringLength(50)]         
        public string BirthPlace { get; set; }

        [Required]
        [Column]
        public int PlayerNumber { get; set; }

        
        
        public double?  Height { get; set; }

        [Required]
        [Column]
        public decimal Salary { get; set; }

        public int TeamID { get; set; }

        [NotMapped]
        public SelectList Teams { get; set; }

        public virtual Team Team { get; set; }
    }
}
