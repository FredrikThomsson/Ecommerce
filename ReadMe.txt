Fredrik: 
Cart controller, Carts view files
Orders controller, Orders view files
CSS

Dan:
Tickets controller, Tickets view files
Products controller, Products view files
CSS

1. Skriv update-database i package manager console

2. Använd följande SQL kod i Microsoft SQL Server Mangement Studio:


USE GrupparbeteMVC


INSERT INTO dbo.Carts (Date, CartTotal) 
VALUES
('2023-04-28', 0)


INSERT INTO dbo.Products (Name, Description, SEKPrice, DollarPrice) VALUES
('Chicken Alfredo Pizza', 'A classic pizza topped with creamy Alfredo sauce, grilled chicken, and mozzarella cheese', 129.99, 15.10),
('Spicy Seafood Pizza', 'A delicious pizza with spicy tomato sauce, shrimp, calamari, and mixed vegetables', 149.99, 17.40),
('Veggie Delight Pizza', 'A vegetarian pizza loaded with fresh vegetables such as bell peppers, onions, mushrooms, olives, and tomatoes', 119.99, 13.90),
('Meat Lovers Pizza', 'A meaty pizza with pepperoni, ham, beef, and Italian sausage, topped with melted mozzarella cheese', 139.99, 16.20),
('Hawaiian Pizza', 'A sweet and savory pizza topped with ham, pineapple, and mozzarella cheese', 119.99, 13.90),
('Barbecue Chicken Pizza', 'A tangy pizza topped with barbecue sauce, grilled chicken, red onions, and mozzarella cheese', 129.99, 15.10),
('Buffalo Chicken Pizza', 'A spicy pizza topped with buffalo sauce, grilled chicken, celery, and blue cheese crumbles', 129.99, 15.10),
('Meatball Pizza', 'A pizza loaded with meatballs, marinara sauce, and melted mozzarella cheese', 139.99, 16.20),
('Chicken and Bacon Pizza', 'A pizza topped with grilled chicken, crispy bacon, red onions, and mozzarella cheese', 129.99, 15.10),
('Supreme Pizza', 'A loaded pizza with pepperoni, sausage, onions, bell peppers, mushrooms, and black olives, topped with melted mozzarella cheese', 139.99, 16.20);


INSERT INTO dbo.Categories (Name)
VALUES
('chicken'),
('seafood'),
('veggie'),
('meat');

INSERT INTO dbo.CategoryProduct (CategoriesId, ProductsId)
VALUES

(1, 1),(2, 2),(3, 3),
(4, 4),(4, 5),(1, 6),
(1, 7),(4, 8),(1, 9),
(4, 9), (4, 10);


INSERT INTO dbo.Tags (Name)
VALUES

('chicken'), ('alfredo'), ('mozzarella'), ('parmesan'), ('tomato sauce'), ('garlic'), ('olive oil'),
('shrimp'), ('calamari'), ('mussels'), ('jalapeno'), ('mozzarella'), ('tomato sauce'), ('garlic'), ('olive oil'),
('mushroom'), ('onion'), ('bell pepper'), ('black olives'), ('tomato sauce'), ('mozzarella'), ('olive oil'),
('bacon'), ('pepperoni'), ('sausage'), ('ham'), ('tomato sauce'), ('mozzarella'), ('olive oil'),
('ham'), ('pineapple'), ('tomato sauce'), ('mozzarella'), ('olive oil'),
('chicken'), ('red onion'), ('cilantro'), ('barbecue sauce'), ('mozzarella'), ('olive oil'),
('chicken'), ('buffalo sauce'), ('red onion'), ('blue cheese'), ('mozzarella'), ('olive oil'),
('meatball'), ('tomato sauce'), ('mozzarella'), ('olive oil'),
('chicken'), ('bacon'), ('tomato sauce'), ('mozzarella'), ('olive oil'),
('pepperoni'), ('sausage'), ('mushroom'), ('onion'), ('bell pepper'), ('black olives'), ('tomato sauce'), ('mozzarella'), ('olive oil');

INSERT INTO dbo.ProductTag (ProductsId, TagsId)
VALUES
(1, 1), (1, 2), (1, 3), (1, 4), (1, 5), (1, 6), (1, 7),
(2, 8), (2, 9), (2, 10), (2, 11), (2, 3), (2, 5), (2, 6), (2, 7),
(3, 12), (3, 13), (3, 14), (3, 15), (3, 5), (3, 3), (3, 7),
(4, 16), (4, 17), (4, 18), (4, 19), (4, 5), (4, 3), (4, 7),
(5, 19), (5, 20), (5, 5), (5, 3), (5, 7),
(6, 1), (6, 21), (6, 22), (6, 23), (6, 3), (6, 7),
(7, 1), (7, 24), (7, 21), (7, 25), (7, 3), (7, 7),
(8, 26), (8, 5), (8, 3), (8, 7),
(9, 1), (9, 26), (9, 5), (9, 3), (9, 7),
(10, 17), (10, 18), (10, 12), (10, 13), (10, 14), (10, 15), (10, 5), (10, 3), (10, 7);


INSERT INTO dbo.Orders
VALUES
('John', 'Doe', 'Main street 10', '2023-05-01', 429.97, 3),
('Jane', 'Doe', 'Main street 15', '2023-05-02', 259.98, 2);


INSERT INTO dbo.OrderItems 
VALUES
(1, 1, 1), (1,2,2),
(2, 3, 1), (2, 4, 1);

INSERT INTO dbo.Tickets (Title, Description, Creator)
VALUES
('Good pizza', 'Very good taste', 'John'),
('Bad pizza', 'Very bad taste', 'Jane');


