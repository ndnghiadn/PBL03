using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CineProject.Models;

[Keyless]
[Table("roles")]
public partial class Role
{
    [Column("_id")]
    public int? Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Name { get; set; }
}
