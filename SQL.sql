CREATE TABLE products(
	id INT AUTO_INCREMENT,
    product_name VARCHAR(20),
    PRIMARY KEY(id)
);
CREATE TABLE categories(
	id INT AUTO_INCREMENT,
    category_name VARCHAR(20),
    PRIMARY KEY(id)
);
INSERT INTO products VALUES
		(1, 'Apple 11'),
        (2, 'Redmi MI10'),
        (3, 'SAMSUNG S10'),
        (4, 'Apple MACBOOK'),
        (5, 'ASUS PREDATOR');
INSERT INTO categories VALUES
		(1, 'phone'),
        (2, 'PC');
CREATE TABLE product_category(
		product_id INT,
		category_id INT,
         FOREIGN KEY(product_id) REFERENCES products(id),
          FOREIGN KEY(category_id) REFERENCES categories(id),
		PRIMARY KEY(product_id, category_id) 
);
INSERT INTO product_category VALUES
			(1, 1),
            (2, 1),
            (3, 1),
            (4, 2),
            (5, 2);
SELECT p.'product_name', c.'category_name 
					FROM products p 
							LEFT JOIN product_category pc
								ON p.id = pc.product_id
                            LEFT JOIN categories c
								ON pc.categories_id = c.id;
