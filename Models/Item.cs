using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CineProject.Models;

[Table("items")]
public partial class Item
{
    [Key]
    [Column("_id")]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Name { get; set; }

    public int? Amount { get; set; }

    public double? Price { get; set; }
}
