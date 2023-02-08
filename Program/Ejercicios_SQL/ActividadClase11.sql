
-- 1. Modificar un usuario --

UPDATE Usuario
SET	Contraseña = 'NuevaContraseña'
WHERE Nombre = 'Ernesto'

-- 2. Eliminar un usuario --  CHECKEAR

DELETE FROM Usuario
WHERE Apellido = 'Casazza'


-- 3. Modificar un producto --

UPDATE Producto
SET	Stock = 3
WHERE Descripciones = 'Pantalon Jean'

-- 4. Eliminar un producto -- CHECKEAR

DELETE FROM Producto
WHERE Descripciones = 'Campera'

-- 5. Consulta con join

SELECT Producto.Descripciones, Usuario.Nombre
FROM Producto
INNER JOIN Usuario
ON PRODUCTO.IdUsuario = Usuario.id