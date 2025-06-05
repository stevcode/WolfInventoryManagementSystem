namespace WolfInventoryManagementSystem.Core;

public abstract record SaleMetric;

public record LocationMetric(double Latitude, double Longitude, string Name) : SaleMetric;

public record WeatherMetric(string Condition, double TemperatureFahrenheit) : SaleMetric;

/// <summary>
/// Represents a sales metric associated with a specific sales channel (e.g., convention, show, in-person etc.).
/// </summary>
/// <remarks>This record is used to encapsulate metrics related to a particular sales channel. It inherits from
/// <see cref="SaleMetric"/>, allowing it to be used in contexts where general sales metrics are required.</remarks>
/// <param name="Channel">The name of the sales channel associated with this metric. Cannot be null or empty.</param>
public record SalesChannelMetric(string Channel) : SaleMetric;

public record SeasonalityEventMetric(string Tag) : SaleMetric;

public record StockLevelAtSaleMetric(Guid ItemId, int StockLevel) : SaleMetric;

public record DiscountAppliedMetric(string DiscountName, decimal DiscountAmount) : SaleMetric;
