USE SocialMediaApp_database;

--USERS TABLE:
CREATE TABLE Users (
	userID INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(50) NOT NULL,
	userPassword VARCHAR(50)
);

INSERT INTO Users (username, userPassword) VALUES 
('shini._1', 'hasan'),
('ahmadsattar', 'ahmad'),
('saadehtsham', 'saad'),
('not_zebi', 'zuhaib'),
('umair.755', 'umair'),
('hanzala.zahid', 'hanzala'),
('obaida_malik', 'obaida'),
('zainzaidi', 'zain'),
('its.abdullah', 'abdullah'),
('ali_faisal', 'ali');
SELECT * FROM Users;

--POSTS TABLE:
CREATE TABLE Posts (
	PostID INT PRIMARY KEY IDENTITY(1,1),
	userID INT,
	FOREIGN KEY (userID) REFERENCES Users(userID),
	PostContent VARCHAR(1000),
	username VARCHAR(50)
);

SELECT * FROM Posts;


INSERT INTO Posts (userID, postContent, username)
VALUES
    (1, 'Excited for the weekend!', 'shini._1'),
    (1, '.Enjoying the sunny weather today!', 'shini._1'),
    (2, 'Just finished a great book.', 'ahmadsattar'),
    (2, 'Feeling inspired to start a new project.', 'ahmadsattar'),
    (3, 'Enjoying a cup of coffee ', 'saadehtsham'),
    (4, 'Looking forward to the new movie release.', 'not_zebi'),
    (4, 'Feeling excited about the upcoming trip!', 'not_zebi'),
    (5, 'Feeling grateful for the little things.', 'umair.755'),
    (5, 'Spending quality time with family and friends.', 'umair.755'),
    (6, 'Happy to be surrounded by good company.', 'hanzala.zahid'),
    (7, 'Exploring new places ', 'obaida_malik'),
    (7, 'Amazing views on today''s hike!', 'obaida_malik'),
    (8, 'Trying out a new recipe tonight.', 'zainzaidi'),
    (9, 'Reflecting on the day''s blessings.', 'its.abdullah'),
    (9, 'Feeling motivated to achieve my goals.', 'its.abdullah'),
    (10, 'Feeling motivated and productive!', 'ali_faisal'),
    (10, 'Excited about the new opportunities ahead!', 'ali_faisal');

	SELECT * FROM Posts;

--forieng key constraint check:
SELECT name
FROM sys.foreign_keys
WHERE parent_object_id = OBJECT_ID('Posts');

SELECT name
FROM sys.foreign_keys
WHERE parent_object_id = OBJECT_ID('Posts');

--FK__Comments__PostID__0F624AF8 conflict

UPDATE Posts
SET username = u.username
FROM Posts p
INNER JOIN Users u ON p.userID = u.userID;



-- Reactions table
-- Create the Reactions table with UserID and username
CREATE TABLE Reactions (
    ReactionID INT PRIMARY KEY IDENTITY(1,1),
    PostID INT,
    UserID INT,
    username VARCHAR(50),
    Reaction VARCHAR(50),
    FOREIGN KEY (PostID) REFERENCES Posts(PostID),
    FOREIGN KEY (UserID) REFERENCES Users(userID)
);

-- Insert sample reactions for each user with usernames
INSERT INTO Reactions (PostID, UserID, username, Reaction) VALUES
-- User 1
    (1, 1, 'shini._1', 'Like'),
    (2, 1, 'shini._1', 'Love'),
    (3, 1, 'shini._1', 'Wow'),
-- User 2
    (1, 2, 'ahmadsattar', 'Sad'),
    (2, 2, 'ahmadsattar', 'Angry'),
    (3, 2, 'ahmadsattar', 'Haha'),
-- User 3
    (1, 3, 'saadehtsham', 'Wow'),
    (2, 3, 'saadehtsham', 'Love'),
    (3, 3, 'saadehtsham', 'Like'),
-- User 4
    (1, 4, 'not_zebi', 'Love'),
    (2, 4, 'not_zebi', 'Like'),
    (3, 4, 'not_zebi', 'Haha'),
-- User 5
    (1, 5, 'umair.755', 'Like'),
    (2, 5, 'umair.755', 'Wow'),
    (3, 5, 'umair.755', 'Angry'),
-- User 6
    (1, 6, 'hanzala.zahid', 'Haha'),
    (2, 6, 'hanzala.zahid', 'Like'),
    (3, 6, 'hanzala.zahid', 'Love'),
-- User 7
    (1, 7, 'obaida_malik', 'Love'),
    (2, 7, 'obaida_malik', 'Wow'),
    (3, 7, 'obaida_malik', 'Sad'),
-- User 8
    (1, 8, 'zainzaidi', 'Angry'),
    (2, 8, 'zainzaidi', 'Love'),
    (3, 8, 'zainzaidi', 'Like'),
-- User 9
    (1, 9, 'its.abdullah', 'Wow'),
    (2, 9, 'its.abdullah', 'Like'),
    (3, 9, 'its.abdullah', 'Haha'),
-- User 10
    (1, 10, 'ali_faisal', 'Like'),
    (2, 10, 'ali_faisal', 'Love'),
    (3, 10, 'ali_faisal', 'Angry');


SELECT * FROM Reactions;

-- Create the Comments table
CREATE TABLE Comments (
    CommentID INT PRIMARY KEY IDENTITY(1,1),
    PostID INT,
    CommentContent VARCHAR(MAX),
    Username NVARCHAR(50),
    FOREIGN KEY (PostID) REFERENCES Posts(PostID)
);
select * from Comments;




drop table Comments;

INSERT INTO Comments (PostID, CommentContent, Username)
VALUES 
    (1, 'Great post!', 'shini._1'),
    (2, 'Nice!', 'ahmadsattar'),
    (3, 'Interesting!', 'saadehtsham'),
    (4, 'Keep it up!', 'not_zebi'),
    (5, 'Amazing!', 'umair.755'),
    (6, 'Inspiring!', 'hanzala.zahid'),
    (7, 'Cool!', 'obaida_malik'),
    (8, 'Well done!', 'zainzaidi'),
    (9, 'Great thoughts!', 'its.abdullah'),
    (10, 'Keep it going!', 'ali_faisal');


	SELECT * FROM Comments;


-- freinds table:

USE SocialMediaApp_database;

-- Create the Friends table
CREATE TABLE Friends (
    FriendshipID INT PRIMARY KEY IDENTITY(1,1),
    UserID1 INT,
    UserID2 INT,
    Username1 VARCHAR(50),
    Username2 VARCHAR(50),
    FOREIGN KEY (UserID1) REFERENCES Users(userID),
    FOREIGN KEY (UserID2) REFERENCES Users(userID)
);

INSERT INTO Friends (UserID1, UserID2, Username1, Username2) VALUES
    (1, 2, 'shini._1', 'ahmadsattar'),
    (1, 3, 'shini._1', 'saadehtsham'),
    (2, 4, 'ahmadsattar', 'not_zebi'),
    (3, 5, 'saadehtsham', 'umair.755'),
    (4, 6, 'not_zebi', 'hanzala.zahid'),
    (5, 7, 'umair.755', 'obaida_malik'),
    (6, 8, 'hanzala.zahid', 'zainzaidi'),
    (7, 9, 'obaida_malik', 'its.abdullah'),
    (8, 10, 'zainzaidi', 'ali_faisal'),
    (9, 1, 'its.abdullah', 'shini._1'),
    (10, 2, 'ali_faisal', 'ahmadsattar');

SELECT Username2
FROM Friends 
WHERE Username1 = 'shini._1';

SELECT * FROM Friends;


