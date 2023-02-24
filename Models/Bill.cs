using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CineProject.Models;

[Table("bills")]
public partial class Bill
{
    [Key]
    [Column("_id")]
    public int Id { get; set; }

    public int? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public int? UserId { get; set; }

    public int? TicketId { get; set; }

    public int? ItemId { get; set; }

    public double? Total { get; set; }
}
