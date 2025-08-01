CREATE TABLE Users (
    ID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Email NVARCHAR(100) UNIQUE,
    Password NVARCHAR(100)
);

CREATE TABLE BusRoutes (
    RouteID INT PRIMARY KEY IDENTITY,
    RouteName NVARCHAR(100),
    DepartureTime TIME,
    SeatsAvailable INT
);
