/*
 *В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
 *Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
 *В данном ответе реализуется связь много-ко-многим, что позволяет выбрать все записи "Имя продукта - Имя категории", а так же выбрать продукты, у коотрых нет категории
 *Для решения используется оператор LEFT JOIN.
 *Т.к. в условии не указаны данные, которые необходимо использовать, то данные взяты случайные, относительно этих данных созданы таблицы.
 *Products_Categories - объединяющая таблица, которая позволяет реализовать связь многие-ко-многим и выбрать необходимые данные
 */


/*Создание таблиц*/
CREATE TABLE Categories
(
	id INT PRIMARY KEY,
	category TEXT
);

CREATE TABLE Products
(
	id INT PRIMARY KEY,
	product TEXT
);

CREATE TABLE Products_Categories
(
	product_id INT REFERENCES Products(id),
	category_id INT REFERENCES Categories(id),
	CONSTRAINT Products_Categories_pk PRIMARY KEY(product_id, category_id)
);

/*Заполнение таблиц*/
INSERT INTO Categories 
	VALUES (1, 'Car'),
		   (2, 'Programming language'),
		   (3, 'Book'),
		   (4, 'Gift')

INSERT INTO Products 
	VALUES (1, 'C#'),
		   (2, 'Python'),
		   (3, 'Audi A5'),
		   (4, 'Clean Code R.Martin'),
		   (5, 'Nvidia RTX 4090'),
		   (6, 'Skoda Octavia'),
		   (7, 'MacBook Pro 13')

INSERT INTO Products_Categories
	VALUES (1, 2),
		   (2, 2),
		   (3, 1),
		   (4, 3),
		   (6, 1),
		   (4, 4);



/*Реализация необходимого запроса(ответ на задание)*/
SELECT p.product, c.category FROM Products p
	LEFT JOIN Products_Categories pc ON pc.product_id = p.id
	LEFT JOIN Categories c ON pc.category_id = c.id;

/*Ответ на запрос*/
/*
id |product                |category
___|_______________________|____________________
1  |C#	                   |Programming language
2  |Python	           |Programming language
3  |Audi A5	           |Car
4  |Clean Code R.Martin	   |Book
5  |Clean Code R.Martin	   |Gift
6  |Nvidia RTX 4090	   |NULL
7  |Skoda Octavia	   |Car
8  |MacBook Pro 13	   |NULL
________________________________________________
*/