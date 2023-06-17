using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models;

public class BaseObject
{
    public Guid Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedBy { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string UpdatedBy { get; set; }

    public DateTime? FlaggedOn { get; set; }

    public FlagEnum? FlaggedAs { get; set; }
}
