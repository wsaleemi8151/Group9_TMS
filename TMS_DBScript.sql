 
CREATE DATABASE IF NOT EXISTS TMS_DB;
USE TMS_DB;


CREATE TABLE Country (
    CountryID INT NOT NULL,
    Country VARCHAR(50) NOT NULL,
    PRIMARY KEY (CountryID)
);

CREATE TABLE State (
    StateID INT NOT NULL,
    State VARCHAR(50) NOT NULL,
    CountryID INT NOT NULL,
    PRIMARY KEY (StateID),
    FOREIGN KEY (CountryID)
        REFERENCES Country (CountryID)
);


CREATE TABLE City (
    CityID INT NOT NULL,
    City VARCHAR(50) NOT NULL,
    StateID INT NOT NULL,
    PRIMARY KEY (CityID),
    FOREIGN KEY (StateID)
        REFERENCES State (StateID)
);

CREATE TABLE Address (
    AddressID INT NOT NULL,
    StreetAddress VARCHAR(150) NOT NULL,
    CityID INT NOT NULL,
    PRIMARY KEY (AddressID),
    FOREIGN KEY (CityID)
        REFERENCES City (CityID)
);

CREATE TABLE Role (
    RoleID INT NOT NULL,
    Role VARCHAR(50) NOT NULL,
    Description VARCHAR(200) NOT NULL,
    PRIMARY KEY (RoleID)
);

CREATE TABLE User (
    UserID INT NOT NULL,
    UserName VARCHAR(50) NOT NULL,
    Password VARCHAR(50) NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    RoleID INT NOT NULL,
    CreatedBy INT NOT NULL,
    CreatedOn DATETIME NOT NULL,
    UpdatedBy INT NOT NULL,
    UpdatedOn DATETIME NOT NULL,
    PRIMARY KEY (UserID),
    FOREIGN KEY (CreatedBy)
        REFERENCES User (UserID),
    FOREIGN KEY (UpdatedBy)
        REFERENCES User (UserID)
);


CREATE TABLE Carrier (
    CarrierID INT NOT NULL,
    Name VARCHAR(50) NOT NULL,
    VehicleDimensions VARCHAR(100) NOT NULL,
    CreatedBy INT NOT NULL,
    CreatedOn DATETIME NOT NULL,
    UpdatedBy INT NOT NULL,
    UpdatedOn DATETIME NOT NULL,
    PRIMARY KEY (CarrierID),
    FOREIGN KEY (CreatedBy)
        REFERENCES User (UserID),
    FOREIGN KEY (UpdatedBy)
        REFERENCES User (UserID)
);


CREATE TABLE Customer (
    CustomerID INT NOT NULL,
    Name VARCHAR(50) NOT NULL,
    CompanyName VARCHAR(200) NULL,
    CreatedBy INT NOT NULL,
    CreatedOn DATETIME NOT NULL,
    UpdatedBy INT NOT NULL,
    UpdatedOn DATETIME NOT NULL,
    PRIMARY KEY (CustomerID),
    FOREIGN KEY (CreatedBy)
        REFERENCES User (UserID),
    FOREIGN KEY (UpdatedBy)
        REFERENCES User (UserID)
);


CREATE TABLE Contract (
    ContractID INT NOT NULL,
    ContractDetails VARCHAR(200) NOT NULL,
    CustomerID INT NOT NULL,
    CreatedBy INT NOT NULL,
    CreatedOn DATETIME NOT NULL,
    UpdatedBy INT NOT NULL,
    UpdatedOn DATETIME NOT NULL,
    PRIMARY KEY (ContractID),
    FOREIGN KEY (CustomerID)
        REFERENCES Customer (CustomerID),
    FOREIGN KEY (CreatedBy)
        REFERENCES User (UserID),
    FOREIGN KEY (UpdatedBy)
        REFERENCES User (UserID)
);


CREATE TABLE Fee (
    FeeID INT NOT NULL,
    Description VARCHAR(200) NOT NULL,
    Fee DECIMAL(18 , 0 ) NOT NULL,
    CreatedBy INT NOT NULL,
    CreatedOn DATETIME NOT NULL,
    UpdatedBy INT NOT NULL,
    UpdatedOn DATETIME NOT NULL,
    PRIMARY KEY (FeeID),
    FOREIGN KEY (CreatedBy)
        REFERENCES User (UserID),
    FOREIGN KEY (UpdatedBy)
        REFERENCES User (UserID)
);


CREATE TABLE Invoice (
    InvoiceID INT NOT NULL,
    FeeID INT NOT NULL,
    PaymentStatus VARCHAR(50) NOT NULL,
    CreatedBy INT NOT NULL,
    CreatedOn DATETIME NOT NULL,
    UpdatedBy INT NOT NULL,
    UpdatedOn DATETIME NOT NULL,
    PRIMARY KEY (InvoiceID),
    FOREIGN KEY (FeeID)
        REFERENCES Fee (FeeID),
    FOREIGN KEY (CreatedBy)
        REFERENCES User (UserID),
    FOREIGN KEY (UpdatedBy)
        REFERENCES User (UserID)
);

CREATE TABLE Log (
    LogID INT NOT NULL,
    FileName VARCHAR(150) NOT NULL,
    CreatedOn DATETIME NOT NULL,
    PRIMARY KEY (LogID)
);


CREATE TABLE OrderStatus (
    OrderStatusID INT NOT NULL,
    Status VARCHAR(50) NOT NULL,
    PRIMARY KEY (OrderStatusID)
);


CREATE TABLE CustomerOrder (
    OrderID INT NOT NULL,
    OrderDetails VARCHAR(200) NOT NULL,
    OrderStatusID INT NOT NULL,
    CustomerID INT NOT NULL,
    CarrierID INT NOT NULL,
    InvoiceID INT NULL,
    CreatedBy INT NOT NULL,
    CreatedOn DATETIME NOT NULL,
    UpdatedBy INT NOT NULL,
    UpdatedOn DATETIME NOT NULL,
    PRIMARY KEY (OrderID),
    FOREIGN KEY (OrderStatusID)
        REFERENCES OrderStatus (OrderStatusID),
    FOREIGN KEY (CustomerID)
        REFERENCES Customer (CustomerID),
    FOREIGN KEY (CarrierID)
        REFERENCES Carrier (CarrierID),
    FOREIGN KEY (InvoiceID)
        REFERENCES Invoice (InvoiceID),
    FOREIGN KEY (CreatedBy)
        REFERENCES User (UserID),
    FOREIGN KEY (UpdatedBy)
        REFERENCES User (UserID)
);


CREATE TABLE OrderTrip (
    TripID INT NOT NULL,
    OrderID INT NOT NULL,
    CarrierID INT NOT NULL,
    PRIMARY KEY (TripID),
    FOREIGN KEY (OrderID)
        REFERENCES CustomerOrder (OrderID),
    FOREIGN KEY (CarrierID)
        REFERENCES Carrier (CarrierID)
);


CREATE TABLE Route (
    RouteID INT NOT NULL,
    Description VARCHAR(200) NOT NULL,
    SourceAddressID INT NOT NULL,
    DestinationAddressID INT NOT NULL,
    CreatedBy INT NOT NULL,
    CreatedOn DATETIME NOT NULL,
    UpdatedBy INT NOT NULL,
    UpdatedOn DATETIME NOT NULL,
    PRIMARY KEY (RouteID),
    FOREIGN KEY (SourceAddressID)
        REFERENCES Address (AddressID),
    FOREIGN KEY (DestinationAddressID)
        REFERENCES Address (AddressID),
    FOREIGN KEY (CreatedBy)
        REFERENCES User (UserID),
    FOREIGN KEY (UpdatedBy)
        REFERENCES User (UserID)
);   
    
