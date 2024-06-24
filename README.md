# Задание 2 
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

## Полученные таблицы

![alt text](https://github.com/Anton-Khan/AreaOfShape/blob/master/DB.drawio.png)

## Скрипт
SELECT Products.ProductName, Categories.CategoryName FROM Products

LEFT JOIN ProductToCategory ON Products.ProductID = ProductToCategory.ProductID

LEFT JOIN Categories ON ProductToCategory.CategoryID = Categories.CategoryID

ORDER BY Products.ProductName, Categories.CategoryName;

# Были ли опыт с front-end?
Пробовал делать pet-проект на React+TS + отдельный проект с API

https://github.com/Anton-Khan/petshop.front

https://github.com/Anton-Khan/Petshop.Api

# Готов работать (Полная занятость, полный день) после успешного прохождения стажировки - ДА.

