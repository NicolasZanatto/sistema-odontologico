
CREATE DATABASE `sistema_odontologico`

CREATE USER 'OdontologiaUSER'@'localhost' IDENTIFIED BY 'Odonto123';

GRANT ALL PRIVILEGES ON sistema_odontologico.table TO 'OdontologiaUSER'@'localhost';