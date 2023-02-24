using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CineProject.Models;

[Table("tickets")]
public partial class Ticket
{
    [Key]
    [Column("_id")]
    public int Id { get; set; }

    public double? Price { get; set; }

    public int? UserId { get; set; }

    public int? ShowtimeId { get; set; }

    public int? SeatId { get; set; }
}
