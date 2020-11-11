/* CREATE TABLE profiles
(
  id VARCHAR(255) NOT NULL,
  email VARCHAR(255) NOT NULL,
  name VARCHAR(255) NOT NULL,
  picture VARCHAR(255) NOT NULL,
  PRIMARY KEY(id) 
) */

/* CREATE TABLE catagories
(
  id INT AUTO_INCREMENT,
  creatorId VARCHAR(255) NOT NULL,
  title VARCHAR(255) NOT NULL,
  questions INT,
  PRIMARY KEY(id),

  FOREIGN KEY (creatorId)
    REFERENCES profiles (id)
    ON DELETE CASCADE
) */

/* CREATE TABLE questions
(
  id INT AUTO_INCREMENT,
  creatorId VARCHAR(255) NOT NULL,
  title VARCHAR(255) NOT NULL,
  description VARCHAR(255) NOT NULL,
  dateCreated VARCHAR(255) NOT NULL,
  dateClosed VARCHAR(255),
  dateUpdated VARCHAR(255),
  responses INT,
  isSolved TINYINT,
  catagoryId INT,
  PRIMARY KEY(id),

  INDEX (catagoryId),

  FOREIGN KEY (creatorId)
    REFERENCES profiles (id)
    ON DELETE CASCADE,
  
  FOREIGN KEY (catagoryId)
    REFERENCES catagories (id)
    ON DELETE CASCADE  
) */

/* CREATE TABLE responses
(
  id INT AUTO_INCREMENT,
  creatorId VARCHAR(255) NOT NULL,
  title VARCHAR(255) NOT NULL,
  description VARCHAR(255) NOT NULL,
  votes INT,
  isAnswer TINYINT,
  questionId INT,
  PRIMARY KEY(id),

  INDEX (questionId),

  FOREIGN KEY (creatorId)
    REFERENCES profiles (id)
    ON DELETE CASCADE,

  FOREIGN KEY (questionId)
    REFERENCES questions (id)
    ON DELETE CASCADE
) */