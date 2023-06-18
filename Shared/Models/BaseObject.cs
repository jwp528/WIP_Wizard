using Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models;

public class BaseObject
{
    public BaseObject()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedBy { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string UpdatedBy { get; set; }

    public DateTime? FlaggedOn { get; set; }

    [Column(TypeName = "nvarchar(30)")]
    public FlagEnum? FlaggedAs { get; set; }
}
