using Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models;

public class User : BaseObject
{
    [MaxLength(150)]
    public string FirstName { get; set; }

    [MaxLength(150)]
    public string LastName { get; set; }

    [EmailAddress]
    public string Email { get; set; }

    [Phone]
    public string Phone { get; set; }

    [MaxLength(150)]
    public string ScreenName { get; set; }

    public DateTime? EmailConfirmed { get; set; }

    public DateTime? PhoneConfirmed { get; set; }

    [Column(TypeName = "nvarchar(30)")]
    public OAuthTypeEnum AuthenticationType { get; set; }

    [MaxLength(300)]
    public string OAuthId { get; set; }

    [NotMapped]
    public bool AccountConfirmed
    {
        get
        {
            return EmailConfirmed is not null || PhoneConfirmed is not null;
        }
    }

    [NotMapped]
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
}
