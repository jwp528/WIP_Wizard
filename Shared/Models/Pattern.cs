using Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models;

public class Pattern : BaseObject
{
    public Pattern() : base() { }

    [MaxLength(150)]
    public string Name { get; set; }

    [Column(TypeName = "nvarchar(30)")]
    public DifficultyEnum Difficulty { get; set; }

    public User User { get; set; }
}
