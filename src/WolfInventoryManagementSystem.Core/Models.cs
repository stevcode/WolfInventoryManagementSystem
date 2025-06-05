using System.Collections.Immutable;

namespace WolfInventoryManagementSystem.Core;

public record Item(Guid Id, string Name, string Description, string SKU, Guid CategoryId, Guid SupplierId, int QuantityInStock, decimal Price);

public record Category(Guid Id, string Name, string Description);

public record Sale(Guid Id, DateTime Date, IReadOnlyList<SaleLineItem> LineItems, decimal TotalAmount, string PaymentMethod, IReadOnlyList<SaleMetric> Metrics);

public record SaleLineItem(Guid Id, Guid SaleId, Guid ItemId, int Quantity, decimal UnitPrice, decimal LineTotal);

public record InventoryAdjustment(Guid Id, Guid ItemId, DateTime Date, int QuantityChanged, string Reason);

public record SaleReturn(Guid Id, Guid SaleId, Guid SaleLineItemId, int QuantityReturned, DateTime DateReturned, string Reason);

public record Supplier(Guid Id, string Name, string ContactInfo, int LeadTimeDays, int ExpectedLeadTimeDays, ImmutableList<int> LeadTimeHistory);