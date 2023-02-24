using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CineProject.Models;

[Table("showtimes")]
public partial class Showtime
{
    [Key]
    [Column("_id")]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndedAt { get; set; }

    public int? MovieId { get; set; }

    public int? RoomId { get; set; }
}
