using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CineProject.Models;

[Table("seats")]
public partial class Seat
{
    [Key]
    [Column("_id")]
    public int Id { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? Code { get; set; }

    [StringLength(255)]
    public string Type { get; set; } = null!;

    public bool? Status { get; set; }

    public int? RoomId { get; set; }
}
