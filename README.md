# MindBoxLib
Тестовое задание для MindBoxLib

1. Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.

    <a href="https://github.com/LordVampiree/MindBoxLib/tree/main/MindBoxLib">Код проекта</a>
    
    <a href="https://github.com/LordVampiree/MindBoxLib/tree/main/MindBoxLib.Tests">Код тестов</a>


2. В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
<code>
SELECT p.name, c.name FROM products p
LEFT JOIN prodcat pc on pc.product_id = p.id
INNER JOIN categories c on pc.category_id = c.id
</code>
