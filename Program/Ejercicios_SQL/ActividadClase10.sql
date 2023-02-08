
-- 1. Primera Consulta --

SELECT Nombre, Apellido, NombreUsuario, Contraseña, Mail
FROM Usuario
WHERE NombreUsuario = 'eperez'

-- 2. Consulta con Condiciones --

-- Primer caso: Caso erróneo --
SELECT Nombre, Apellido, NombreUsuario, Contraseña, Mail
FROM Usuario
WHERE NombreUsuario = 'eperez' AND Contraseña = 'NoVaATraerNada'

-- Segundo caso: Caso correcto --
SELECT Nombre, Apellido, NombreUsuario, Contraseña, Mail
FROM Usuario
WHERE NombreUsuario = 'eperez'AND Contraseña = 'SoyErnestoPerez'

-- 3. Consulta a productos --

SELECT Descripciones, Costo, PrecioVenta, Stock, IdUsuario 
FROM Producto
WHERE IdUsuario = 3

-- 4. Nuevo Usuario --

INSERT INTO Usuario(Nombre, Apellido, NombreUsuario, Contraseña, Mail)
Values ('Martín', 'Regazzoli', 'MartinRega', 'contraseña1234', 'martinrega20@gmail.com')

-- 5. Nuevo producto --	

INSERT INTO Producto(Descripciones, Costo, PrecioVenta, Stock, IdUsuario)
VALUES ('Zapatillas Vans', 1000, 5000, 26, 3)
