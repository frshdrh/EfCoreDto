namespace EfCoreDto.Core.DTOs;

public record AddressDTO(
	string Type,
	string AddressLine1,
	string? AddressLine2,
	string PostalCode,
	string City,
	string Country,
	bool IsCurrent);
