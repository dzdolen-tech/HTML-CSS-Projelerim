-- Step 1 & 2: Create and use the new database
CREATE DATABASE MovieAssignmentDB;
GO

USE MovieAssignmentDB;
GO

-- Step 2, 4, & 8: Create the parent table (Directors) with Primary Key and 2 additional columns
CREATE TABLE Directors (
    DirectorID INT PRIMARY KEY,
    DirectorName VARCHAR(100),
    BirthYear INT,
    Nationality VARCHAR(50)
);
GO

-- Step 2, 4, 6, & 8: Create the child table (Movies) with Primary Key, Foreign Key, and 2 additional columns
CREATE TABLE Movies (
    MovieID INT PRIMARY KEY,
    MovieName VARCHAR(100),
    ReleaseYear INT,
    Genre VARCHAR(50),
    DirectorID INT,
    FOREIGN KEY (DirectorID) REFERENCES Directors(DirectorID)
);
GO

-- Step 10 & 12: Insert values (5 rows per table, matching Foreign Keys to Primary Keys)
INSERT INTO Directors (DirectorID, DirectorName, BirthYear, Nationality) VALUES
(1, 'Christopher Nolan', 1970, 'British'),
(2, 'Steven Spielberg', 1946, 'American'),
(3, 'Quentin Tarantino', 1963, 'American'),
(4, 'Denis Villeneuve', 1967, 'Canadian'),
(5, 'Greta Gerwig', 1983, 'American');
GO

INSERT INTO Movies (MovieID, MovieName, ReleaseYear, Genre, DirectorID) VALUES
(101, 'Inception', 2010, 'Sci-Fi', 1),
(102, 'Jurassic Park', 1993, 'Adventure', 2),
(103, 'Pulp Fiction', 1994, 'Crime', 3),
(104, 'Dune', 2021, 'Sci-Fi', 4),
(105, 'Little Women', 2019, 'Drama', 5);
GO

-- Step 13: Query data from both tables using a JOIN
SELECT 
    m.MovieName,
    m.ReleaseYear,
    m.Genre,
    d.DirectorName,
    d.Nationality
FROM Movies m
JOIN Directors d ON m.DirectorID = d.DirectorID;
GO