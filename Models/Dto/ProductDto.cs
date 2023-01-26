using Models;

namespace tr_backend_itsense.Models.Dto;

public record CreateProductDto(string name);

public record UpdateProductDto(string name, ProductStatus status);
