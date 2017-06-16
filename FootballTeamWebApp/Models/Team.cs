namespace FootballTeamWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Team
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Team()
        {
            Players = new HashSet<Player>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TeamName { get; set; }

        [Column(TypeName = "date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateOfCreation { get; set; }

        [StringLength(50)]
        public string Stadium { get; set; }

        [Required]
        [StringLength(50)]
        public string Owner { get; set; }

        [StringLength(50)]
        public string Coach { get; set; }

        [Column(TypeName = "text")]
        public string WebSite { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Player> Players { get; set; }
    }
}
