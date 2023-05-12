USE Products

select Products.Name, Categories.Title from Products
left join ProductCategories on Products.Id = ProductCategories.ProductId
left join Categories on ProductCategories.CategoryId = Categories.Id