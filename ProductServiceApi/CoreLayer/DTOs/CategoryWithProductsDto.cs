﻿namespace CoreLayer.DTOs
{

	public class CategoryWithProductsDto : CategoryDto
	{
		public List<ProductDto> Products { get; set; }
	}

}