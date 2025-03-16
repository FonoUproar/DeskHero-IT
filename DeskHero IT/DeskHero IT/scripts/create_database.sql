/*
** Copyright Microsoft, Inc. 1994 - 2000
** All Rights Reserved.
*/
SET NOCOUNT ON
GO

USE MASTER
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'DeskHeroIt')
BEGIN
    -- Ensure that the database is not in use
    ALTER DATABASE DeskHeroIt SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE DeskHeroIt;
END
GO

DECLARE @device_directory NVARCHAR(520)
SELECT @device_directory = SUBSTRING(filename, 1, CHARINDEX(N'master.mdf', LOWER(filename)) - 1)
FROM master.dbo.sysaltfiles WHERE dbid = 1 AND fileid = 1

EXECUTE (N'CREATE DATABASE DeskHeroIt
  ON PRIMARY (NAME = N''DeskHeroIt_New'', FILENAME = N''' + @device_directory + N'DeskHero_New.mdf'')
  LOG ON (NAME = N''DeskHeroIt_Log'',  FILENAME = N''' + @device_directory + N'DeskHero_Log.ldf'')');
GO

IF CAST(SERVERPROPERTY('ProductMajorVersion') AS INT)<12 
BEGIN
  exec sp_dboption 'DeskHeroIt','trunc. log on chkpt.','true'
  exec sp_dboption 'DeskHeroIt','select into/bulkcopy','true'
END
ELSE ALTER DATABASE [DeskHeroIt] SET RECOVERY SIMPLE WITH NO_WAIT
GO

set quoted_identifier on
GO
USE "DeskHeroIt"

CREATE TABLE user_roles (
	role_id INT PRIMARY KEY IDENTITY(1, 1),
	role_name VARCHAR(50) NOT NULL,
	trash_flag BIT DEFAULT(0)
);

CREATE TABLE users (
    user_id INT PRIMARY KEY IDENTITY(1, 1),
	role_id INT NOT NULL,
	first_name VARCHAR(100) NOT NULL,
	last_name VARCHAR(200) NOT NULL,
	user_name VARCHAR(100) NOT NULL,
	password VARCHAR(250) NOT NULL,
    user_email VARCHAR(100) NOT NULL UNIQUE,
	phone_number VARCHAR(50) NOT NULL,
	state		 VARCHAR(30) NOT NULL,
	city		 VARCHAR(100) NOT NULL,
    created_at DATETIME DEFAULT GETDATE(),

    CONSTRAINT uq_user_email UNIQUE (user_email),

	FOREIGN KEY (role_id) REFERENCES user_roles(role_id)
);


CREATE TABLE categories(
	category_id INT PRIMARY KEY IDENTITY(1, 1),
	category_name VARCHAR(100) NOT NULL,
	trash_flag BIT DEFAULT(0)
);

CREATE TABLE priorities (
	priority_id INT PRIMARY KEY IDENTITY(1, 1),
	priority_level VARCHAR(50)
);

CREATE TABLE ticket_status (
	status_id INT PRIMARY KEY IDENTITY(1, 1),
	status_name VARCHAR(30) NOT NULL
)

CREATE TABLE tickets (
	ticket_id INT PRIMARY KEY IDENTITY(1, 1),
	status_id INT NOT NULL,
	created_by_user_id INT NOT NULL,
	priority_id INT NOT NULL,
	title VARCHAR(100),
	description VARCHAR(MAX),
	created_at DATETIME DEFAULT GETDATE(),
	trash_flag BIT DEFAULT(0),

	 -- Foreign Keys
    CONSTRAINT status_id FOREIGN KEY (status_id) REFERENCES ticket_status(status_id),
    CONSTRAINT created_by_user_id FOREIGN KEY (created_by_user_id) REFERENCES users(user_id),
    CONSTRAINT priority_id FOREIGN KEY (priority_id) REFERENCES priorities(priority_id),
);

CREATE TABLE ticket_assignments (
	ticket_assignment_id INT PRIMARY KEY IDENTITY(1, 1),
	ticket_id INT NOT NULL,
	tech_support_id INT NOT NULL,
	assigned_by_user_id INT NOT NULL,
	assignet_at DATETIME,
	trash_flag BIT DEFAULT(0),
	
    -- Foreign Keys
    FOREIGN KEY (ticket_id) REFERENCES tickets(ticket_id),
    FOREIGN KEY (tech_support_id) REFERENCES users(user_id),
    FOREIGN KEY (assigned_by_user_id) REFERENCES users(user_id),
);

CREATE TABLE resolutions (
	resolution_id INT PRIMARY KEY IDENTITY(1, 1),
	ticket_id INT NOT NULL,
	resolved_by_user_id INT NOT NULL,
	resolved_at DATETIME,
	details VARCHAR(MAX),
	trash_flag BIT DEFAULT(0),

	-- Foreign Keys
	FOREIGN KEY (ticket_id) REFERENCES tickets(ticket_id),
	FOREIGN KEY (resolved_by_user_id) REFERENCES users(user_id)
);

/*
Inserting sample data
*/
INSERT INTO user_roles (role_name, trash_flag)
VALUES
    ('Admin', 0),
    ('User', 0),
    ('Manager', 0),
    ('Support', 0),
	('Developer', 0);

INSERT INTO users (role_id, first_name, last_name, user_name, password, user_email, state, city, phone_number)
VALUES
    (1, 'Zaid', 'Al Falahi', 'admin_user', 'adminpassword123', 'admin@deskhero.com', 'CA', 'Los Angeles', '123-456-7890'),
    (2, 'Uziel', 'Carranza', 'standard_user', 'userpassword123', 'user@deskhero.com', 'IL', 'Chicago', '321-654-0987'),
    (3, 'Royce', 'Baker', 'manager_user', 'managerpassword123', 'manager@deskhero.com', 'TX', 'Dallas', '213-546-8970'),
    (4, 'Brenden', 'Beezley', 'support_user', 'supportpassword123', 'support@deskhero.com', 'OH', 'Akron', '123-465-8709'),
    (5, 'Wesley', 'Bogart', 'developer_user', 'developerpassword123', 'developer@deskhero.com', 'UT', 'Alta', '231-456-8210');

INSERT INTO categories (category_name)
VALUES
    ('Software Issue'),
    ('Hardware Issue'),
    ('Network Issue'),
    ('General Inquiry'),
    ('Account Issue');

INSERT INTO priorities (priority_level)
VALUES
    ('Low'),
    ('Medium'),
    ('High'),
    ('Critical');
	
INSERT INTO ticket_status (status_name)
VALUES
    ('Open'),
    ('In Progress'),
    ('Resolved'),
    ('Closed');

INSERT INTO tickets (status_id, created_by_user_id, priority_id, title, description, created_at, trash_flag)
VALUES
    (1, 2, 3, 'Unable to connect to Wi-Fi', 'User is unable to connect to the corporate Wi-Fi network.', 
        GETDATE(), 0),
    (2, 3, 2, 'Request for software update', 'The user is requesting an update to the application software.',
        GETDATE(), 0),
    (3, 4, 1, 'Password reset request', 'User is unable to reset their account password.', 
        GETDATE(), 0),
    (4, 5, 4, 'Critical server issue', 'The development server is down and needs immediate attention.',
        GETDATE(), 0);

INSERT INTO ticket_assignments (ticket_id, tech_support_id, assigned_by_user_id, assignet_at)
VALUES
    (1, 4, 2, GETDATE()),
    (2, 5, 3, GETDATE()),
    (3, 4, 2, GETDATE()),
    (4, 5, 3, GETDATE());

INSERT INTO resolutions (ticket_id, resolved_by_user_id, resolved_at, details)
VALUES
    (3, 4, GETDATE(), 'Reset the user password and sent the new credentials.'),
    (1, 4, GETDATE(), 'Rebooted the router and connected the user to the network.'),
    (2, 5, GETDATE(), 'Updated the application software to the latest version.'),
    (4, 5, GETDATE(), 'Rebooted the development server and restored service.');
