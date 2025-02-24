using System;
using System.Collections.Generic;

namespace Lesgriots.API.Models;

public partial class Subscription
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public byte Pland { get; set; }

    public byte Status { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual User User { get; set; } = null!;
}
