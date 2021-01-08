--AUTHOR
CREATE TABLE author (
authorId number(5) Primary key,
authorName varchar(200),
numberOfBooks number(6)
);

CREATE SEQUENCE S_AUTHOR
START WITH 1
INCREMENT BY 1
CACHE 1000;

CREATE OR REPLACE TRIGGER T_AUTHOR_AUTHORID
BEFORE INSERT
ON AUTHOR
REFERENCING NEW AS NEW
FOR EACH ROW
BEGIN
    if(:new.AUTHORID is null) then
    SELECT S_AUTHOR.nextval
    INTO :new.AUTHORID
    FROM dual;
    end if;
END;
    
ALTER TRIGGER "T_AUTHOR_AUTHORID" ENABLE; 

--ENDAUTHOR

--BOOKS
CREATE TABLE books (
bookId number(5) Primary key,
bookName varchar2(200),
authorId number(5) constraint authorId references author(authorId)
);

CREATE SEQUENCE S_BOOKS
START WITH 1001
INCREMENT BY 1
CACHE 2000;

CREATE OR REPLACE TRIGGER T_BOOKS_BOOKID
BEFORE INSERT
ON BOOKS
REFERENCING NEW AS NEW
FOR EACH ROW
BEGIN
    if(:new.BOOKID is null) then
    SELECT S_BOOKS.nextval
    INTO :new.BOOKID
    FROM dual;
    end if;
END;
    
ALTER TRIGGER "T_BOOKS_BOOKID" ENABLE;
--ENDBOOKS

--students
CREATE TABLE students (
studentId number(5) PRIMARY KEY,
studentName varchar2(20),
studentAge number(2)
);

CREATE SEQUENCE S_STUDENTS
START WITH 3001
INCREMENT BY 1
CACHE 9000;

CREATE OR REPLACE TRIGGER T_STUDENTS_STUDENTID
BEFORE INSERT
ON STUDENTS
REFERENCING NEW AS NEW
FOR EACH ROW
BEGIN
    if(:new.STUDENTID is null) then
    SELECT S_STUDENTS.nextval
    INTO :new.STUDENTID
    FROM dual;
    end if;
END;
    
ALTER TRIGGER "T_STUDENTS_STUDENTID" ENABLE;
--endstudents


--BORROWS
CREATE TABLE borrows (
borrowId number(5) PRIMARY KEY,
studentId number(5) constraint studentId references students(studentId),
bookId number(5) constraint bookId references books(bookId) 
);

CREATE SEQUENCE S_BORROWS
START WITH 2001
INCREMENT BY 1
CACHE 3000;

CREATE OR REPLACE TRIGGER T_BORROWS_BORROWID
BEFORE INSERT
ON BORROWS
REFERENCING NEW AS NEW
FOR EACH ROW
BEGIN
    if(:new.BORROWID is null) then
    SELECT S_BORROWS.nextval
    INTO :new.BORROWID
    FROM dual;
    end if;
END;
    
ALTER TRIGGER "T_BORROWS_BORROWID" ENABLE;
--ENDBORROWS


--USERS
CREATE TABLE users(
userName varchar2(200) primary key,
userPassword varchar2(200),
isAdmin number null
);
INSERT INTO users (userName,userPassword) VALUES ('admin','admin');
--ENDUSERS

--SOME DUMMY DATA
INSERT INTO author (authorId,authorName,numberofBooks) VALUES (1,'Kiss Pal',42);
INSERT INTO author (authorId,authorName,numberofBooks) VALUES (2,'Nagy Zoltan Pal',2);
INSERT INTO author (authorId,authorName,numberofBooks) VALUES (3,'Fekete Ferenc',12);
INSERT INTO author (authorId,authorName,numberofBooks) VALUES (4,'Jr. Feher Norbert',6);

INSERT INTO books (bookId,bookName,authorId) VALUES (1001,'Adventurer',2);
INSERT INTO books (bookId,bookName,authorId) VALUES (1002,'Fight for nothing',2);
INSERT INTO books (bookId,bookName,authorId) VALUES (1003,'Just do it',1);
INSERT INTO books (bookId,bookName,authorId) VALUES (1004,'Nothing else matters',4);
INSERT INTO books (bookId,bookName,authorId) VALUES (1005,'Dummy data cunamy',3);
INSERT INTO books (bookId,bookName,authorId) VALUES (1006,'Dummy data cunamy , the revenge!',4);

INSERT INTO students (studentId, studentName, studentAge) VALUES (3001,'Kiss Zoltan',11);
INSERT INTO students (studentId, studentName, studentAge) VALUES (3002,'Kiss Jeno',7);
INSERT INTO students (studentId, studentName, studentAge) VALUES (3003,'Feher Agnes',13);
INSERT INTO students (studentId, studentName, studentAge) VALUES (3004,'Fekete Zoltan',10);
INSERT INTO students (studentId, studentName, studentAge) VALUES (3005,'Gal Mate',11);
INSERT INTO students (studentId, studentName, studentAge) VALUES (3006,'Adam Erik',9);

INSERT INTO borrows (borrowId,studentId,bookId) VALUES (2001,3001,1001);
INSERT INTO borrows (borrowId,studentId,bookId) VALUES (2002,3001,1001);
INSERT INTO borrows (borrowId,studentId,bookId) VALUES (2003,3005,1003);
INSERT INTO borrows (borrowId,studentId,bookId) VALUES (2004,3003,1002);
INSERT INTO borrows (borrowId,studentId,bookId) VALUES (2005,3004,1006);


