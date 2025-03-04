using System;
using System.Collections.Generic;

namespace Lesgriots.Domain.Models;

public partial class Transaction
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid SubscriptionId { get; set; }

    public decimal Amount { get; set; }

    public string? Currency { get; set; }

    public byte Status { get; set; }

    public DateTime? TransactionDate { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
