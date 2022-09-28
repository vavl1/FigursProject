select Products.Name , Categories.name from Products 
left join ProductToCategories on Products.Id = ProductToCategories.ProductId
left join Categories on Categories.Id = ProductToCategories.CategoryId