using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CineProject.Models;

[Table("rooms")]
public partial class Room
{
    [Key]
    [Column("_id")]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(255)]
    public string Type { get; set; } = null!;

    public bool? Status { get; set; }

    public int? MovieId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AvailableAt { get; set; }
}
