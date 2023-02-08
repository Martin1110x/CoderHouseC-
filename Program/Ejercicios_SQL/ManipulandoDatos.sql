-- Obtener todos los productos vendidos --

SELECT * FROM ProductoVendido
INNER JOIN Producto
ON ProductoVendido.IdProducto = Producto.Id

-- Obtener las ventas que registren dos o más productos vendidos del mismo tipo.. --

SELECT Stock, IdProducto, IdVenta
FROM ProductoVendido
WHERE ProductoVendido.Stock >= 2

-- Insertar la venta de 20 productos "Remera manga larga" vendidos por el usuario 2 --

INSERT INTO Venta(IdUsuario, Comentarios)
VALUES (2, 'Fecha de venta: 31/1/2023')

INSERT INTO ProductoVendido(Stock, IdProducto, IdVenta)
VALUES (20, 1, 2)