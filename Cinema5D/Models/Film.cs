using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cinema5D.Models {
    public class Film {
        [ScaffoldColumn(true)]
        [Key]
        public int FilmID { get; set; }

        [Required]
        [Display(Name="Назва")]
        [StringLength(160)]
        [MinLength(3)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Тривалість (сек)")]
        [Range(1, int.MaxValue)]
        public int RunningTime { get; set; }

        [Display(Name="Команда для запуску")]
        [StringLength(255)]
        [MinLength(3)]
        public string CommandLink { get; set; }
    }
}