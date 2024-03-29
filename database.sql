CREATE DATABASE HotelManager;
use HotelManager;

CREATE TABLE Clients(
PersonID char(20),
LastName NVARCHAR(100),
FirstName NVARCHAR(100),
Address NVARCHAR(255), --Địa chỉ thường chú trước đây
Phone char(15),
PictureOfIDCard NVARCHAR(255), --Đường dẫn đến chỗ lưu hình CMND,
PictureOfHouseholdRegistry NVARCHAR(255), --Đường dẫn chỗ lưu hình hộ khẩu thường trú cũ
RoomID int,
PRIMARY KEY (PersonID)
);


CREATE TABLE Rooms(
RoomID int IDENTITY(1,1),
Area FLOAT,
PRIMARY KEY (RoomID)
);

CREATE TABLE Vehicles(
VehicleID CHAR(15),
Model NVARCHAR(100),
Color NVARCHAR(50),
Picture NVARCHAR(255),
PersonID char(20),
PRIMARY KEY (VehicleID)
);

CREATE TABLE ElectricityPayments(
RoomID int,
DatePay DATE,
Wattage FLOAT,
Price int,
PRIMARY KEY (RoomID, DatePay)
);

CREATE TABLE WaterPayments(
RoomID int,
DatePay DATE,
Volume FLOAT, --Lượng nước đã dùng
Price int,
PRIMARY KEY (RoomID, DatePay)
);

CREATE TABLE Contracts(
ContractID int IDENTITY(1,1),
PersonID char(20),
TimeStartRent DATE,
TimeEndRent DATE,
PaymentPerMonth int,
PictureOfContract NVARCHAR(255), --Đường dẫn lưu hình hợp đồng
PRIMARY KEY (ContractID)
);

CREATE TABLE DetailPaymentByMonths(
PersonID char(20),
DatePay DATE,
PaymentForRoom int,
PaymentForOther int, --Tiền ở khoản thu khác như đổ bể đồ vật,...
PRIMARY KEY (PersonID, DatePay)
);

ALTER TABLE Clients
ADD FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID);
ALTER TABLE Contracts
ADD FOREIGN KEY (PersonID) REFERENCES Clients(PersonID);
ALTER TABLE Vehicles
ADD FOREIGN KEY (PersonID) REFERENCES Clients(PersonID);



