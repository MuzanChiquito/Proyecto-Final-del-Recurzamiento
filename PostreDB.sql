CREATE DATABASE dbPostress;
USE dbPostress;

CREATE TABLE postres (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    tipo ENUM('Dulce','Salado') NOT NULL,
    precio DECIMAL(10,2) NOT NULL
);

CREATE TABLE ventas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    fecha DATETIME NOT NULL,
    total DECIMAL(10,2) NOT NULL
);

CREATE TABLE detalle_venta (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_ventas INT NOT NULL,
    producto VARCHAR(100) NOT NULL,
    cantidad INT NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    total DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (id_ventas) REFERENCES ventas(id)
);

INSERT INTO postres (nombre, tipo, precio) VALUES
('Pastel de pera', 'Dulce', 40.00),
('Cheesecake', 'Dulce', 40.00),
('Galleta Oreo', 'Dulce', 35.00),
('Empanada', 'Salado', 25.00),
('Pan de Queso', 'Salado', 20.00),
('Croissant', 'Salado', 30.00);

SELECT * FROM postres;
