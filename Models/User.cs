using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CineProject.Models;

[Table("users")]
public partial class User
{
    [Key]
    [Column("_id")]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Username { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Password { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Fullname { get; set; }

    [Column("DOB")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Dob { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? PhoneNumber { get; set; }

    public double? Points { get; set; }

    public int? Role { get; set; }
}
