using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CineProject.Models;

[Table("movies")]
public partial class Movie
{
    [Key]
    [Column("_id")]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Director { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Actors { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Language { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? BannerUrl { get; set; }

    public int? CategoryId { get; set; }

    public int? Duration { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OpenedOn { get; set; }
}
