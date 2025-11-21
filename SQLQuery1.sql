create table users
(
    id INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(MAX) NOT NULL,
    password VARCHAR(MAX) NOT NULL,
    profile_image VARCHAR(MAX) NULL,
    role NVARCHAR(MAX) NOT NULL,
    status VARCHAR(MAX) NOT NULL,
    date_reg DATE NULL,
)

SELECT *FROM users

INSERT INTO users (username , password , profile_image , role , status , date_reg) VALUES ('admin','admin123','','Admin','Active','2025-11-17')

CREATE TABLE products
(
   id INT PRIMARY KEY IDENTITY(1,1),
   prod_id VARCHAR (MAX) NULL,
   prod_name VARCHAR (MAX) NULL,
   prod_type VARCHAR (MAX) NULL,
   prod_stock INT NULL,
   prod_price FLOAT NULL,
   prod_status VARCHAR(MAX) NULL,
   prod_image VARCHAR(MAX) NULL,
   date_insert DATE NULL,
   date_update DATE NULL,
   date_delete DATE NULL,
)

SELECT * FROM products