CREATE DATABASE IF NOT EXISTS Club_Deportivo;
USE Club_Deportivo;

-- Tabla de no socios
CREATE TABLE IF NOT EXISTS  no_socios (
    idNoSocio INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    dni VARCHAR(20) NOT NULL UNIQUE,
    telefono VARCHAR(20) NOT NULL,
    direccion VARCHAR(255) NOT NULL,
    fecha_inscripcion DATE NOT NULL,
    activo BOOLEAN NOT NULL,
    ficha_medica BOOLEAN NOT NULL
);

-- Tabla de socios
CREATE TABLE IF NOT EXISTS  socios (
    idSocio INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    dni VARCHAR(20) NOT NULL UNIQUE,
    telefono VARCHAR(20) NOT NULL,
    direccion VARCHAR(255) NOT NULL,
    fecha_inscripcion DATE NOT NULL,
    ficha_medica BOOLEAN NOT NULL,
    activo BOOLEAN NOT NULL,
    carnet BOOLEAN NOT NULL
);

-- Tabla de cuotas
CREATE TABLE IF NOT EXISTS cuotas (
    idCuota INT AUTO_INCREMENT PRIMARY KEY,
    idSocio INT NOT NULL,
    monto DECIMAL(10,2),
    fechaPago DATE NOT NULL,
	formaPago VARCHAR(50),
    estadoDelPago BOOLEAN NOT NULL,
    fechaVencimiento DATE NOT NULL,
    FOREIGN KEY (idSocio) REFERENCES socios(idSocio)
);
