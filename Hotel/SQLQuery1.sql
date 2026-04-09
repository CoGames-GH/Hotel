CREATE DATABASE Hotel;
GO
USE Hotel;
CREATE TABLE Users(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Login_ NVARCHAR(50) NOT NULL UNIQUE,
    Password_ NVARCHAR(50) NOT NULL,
    Name_ NVARCHAR(100) NOT NULL,
    Role_ NVARCHAR(30) NOT NULL CHECK (Role_ IN ('Сотрудник','Менеджер','Бухгалтер','Админ'))
);

CREATE TABLE Rooms (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name_ NVARCHAR(100) NOT NULL,
    City NVARCHAR(50) NOT NULL,
    PricePerNight DECIMAL(10,2) NOT NULL,
    Capacity INT NOT NULL,
    Description_ NVARCHAR(500)
);

CREATE TABLE BookingRequests (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL FOREIGN KEY REFERENCES Users(Id),
    RoomId INT NOT NULL FOREIGN KEY REFERENCES Rooms(Id),
    CheckInDate DATE NOT NULL,
    CheckOutDate DATE NOT NULL,
    Status_ NVARCHAR(30)  NOT NULL CHECK (Status_ IN ('Свободно','Забронировано','Занято','Отклонено')),
    Comment NVARCHAR(500),
    TotalAmount DECIMAL(10,2) NOT NULL
);

INSERT INTO Users(Login_, Password_,Name_,Role_)
VALUES ('Ф','123','Иванов','Сотрудник'),
       ('mgr','123','Петрова','Менеджер'),
       ('acc','123','Сидоров','Бухгалтер'),
       ('adm','123','Админ','Админ');

INSERT INTO Rooms(Name_,City,PricePerNight,Capacity,Description_)
VALUES ('Стандарт','Казань',4500.00,2,'1 двуспальная кровать'),
       ('Комфорт','Казань',5200.00,2,'2 односпальные кровати'),
       ('Люкс','Казань',7000.00,3,'Гостиная + спальня');
