CREATE DATABASE POC;

\c POC;

CREATE TABLE Employees
(
	Id BIGSERIAL PRIMARY KEY,
	Role varchar(255) NULL, 
	Company varchar(255) NULL,
	Location varchar(255) NULL, 
	Remote boolean NOT NULL,
	Link varchar(255) NULL,
	Salary MONEY NULL,
	CreatedAt timestamp with time zone NOT NULL default CURRENT_TIMESTAMP,
	UpdatedAt timestamp with time zone NULL,
	DeletedAt timestamp with time zone NULL
);

INSERT INTO Employees (Role, Company, Location, Remote, Link, Salary) VALUES ('Senior Software Enginner', 'Neon', 'Goiânia', true, 'https://linkedin.com', 14500.00);
INSERT INTO Employees (Role, Company, Location, Remote, Link, Salary) VALUES ('Software Enginner III', 'Neon', 'Goiânia', true, 'https://linkedin.com', 9500.00);
INSERT INTO Employees (Role, Company, Location, Remote, Link, Salary) VALUES ('Software Enginner II', 'Neon', 'Goiânia', true, 'https://linkedin.com', 5000.00);
INSERT INTO Employees (Role, Company, Location, Remote, Link, Salary) VALUES ('Staff Software Enginner', 'Neon', 'Goiânia', true, 'https://linkedin.com', 20000.00);
INSERT INTO Employees (Role, Company, Location, Remote, Link, Salary) VALUES ('Distinguished Software Enginner', 'Neon', 'Goiânia', true, 'https://linkedin.com', 48000.00);
INSERT INTO Employees (Role, Company, Location, Remote, Link, Salary) VALUES ('Fellow Software Enginner', 'Neon', 'Goiânia', true, 'https://linkedin.com', 70000.00);