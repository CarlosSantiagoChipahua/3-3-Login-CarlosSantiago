CREATE DATABASE login;
USE login;

-- Crear tabla users
CREATE TABLE users(
    userid 		INT 			NOT NULL 	AUTO_INCREMENT 		PRIMARY KEY,
    firstname 		VARCHAR(50) 	NOT NULL,
    lastname 		VARCHAR(50) 	NOT NULL,
    username		VARCHAR(50) 	UNIQUE 		NOT NULL,
    password 		VARCHAR(256) 	NOT NULL,
    email 			VARCHAR(100) 	UNIQUE 		NOT NULL,
    description 	TEXT 			NOT NULL,
    userstatus 		BOOLEAN 		DEFAULT TRUE,
    createddate 	TIMESTAMP DEFAULT 	CURRENT_TIMESTAMP
);

-- Insertar usuario administrador
INSERT INTO users (firstname, lastname, username, password, email, description) 
VALUES (
    'Administrador', 
    'Principal', 
    'admin', 
    SHA2('admin123', 256), 
    'admin@sistema.com', 
    'Usuario administrador de la base de datos'
);

-- Verificar que se insertó correctamente
SELECT * FROM users;

-- Para verificar el login manualmente
SELECT * FROM users 
WHERE username = 'admin' 
AND password = SHA2('admin123', 256);
