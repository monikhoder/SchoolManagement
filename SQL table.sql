-- User
create table [User] (
    Id int primary key identity(1,1) not null,
    Name varchar(255) not null check (Name <> ''),
    Password varchar(255) not null check (Password <> ''),
    Role varchar(255) not null
);

-- Student
create table Student (
    Id int primary key identity(1,1) not null,
    FirstName varchar(255) not null,
    LastName varchar(255) not null,
    Gender varchar(50) not null,
    EnrollDate datetime not null,
    Status bit default 0,
    GradeId int not null,
    foreign key (GradeId) references Grade(Id)
);

-- Teacher
create table Teacher (
    Id int primary key identity(1,1) not null,
    FirstName varchar(255) not null,
    LastName varchar(255) not null,
    Gender varchar(50) not null,
    Salary decimal(10, 2) not null,
    Status bit default 0
);

-- Classroom
create table Classroom (
    Id int primary key identity(1,1) not null,
    Name varchar(255) not null unique
);

-- Exam
create table Exam (
    Id int primary key identity(1,1) not null,
    Date datetime not null,
    SubjectId int not null,
    foreign key (SubjectId) references Subject(Id)
);

-- Grade
create table Grade (
    Id int primary key identity(1,1) not null,
    Score int not null,
    SubjectId int not null,
    foreign key (SubjectId) references Subject(Id)
);

-- Subject
create table Subject (
    Id int primary key identity(1,1) not null,
    Name varchar(255) not null
);

-- Classroom student
create table ClassroomStudent (
    Id int primary key identity(1,1) not null,
    ClassroomId int not null,
    StudentId int not null,
    foreign key (ClassroomId) references Classroom(Id),
    foreign key (StudentId) references Student(Id)
);

-- Classroom teacher
create table ClassroomTeacher (
    Id int primary key identity(1,1) not null,
    ClassroomId int not null,
    TeacherId int not null,
    foreign key (ClassroomId) references Classroom(Id),
    foreign key (TeacherId) references Teacher(Id)
);

-- Teacher subject
create table TeacherSubject (
    Id int primary key identity(1,1) not null,
    TeacherId int not null,
    SubjectId int not null,
    foreign key (TeacherId) references Teacher(Id),
    foreign key (SubjectId) references Subject(Id)
);

-- Exam student
create table ExamStudent (
    Id int primary key identity(1,1) not null,
    ExamId int not null,
    StudentId int not null,
    foreign key (ExamId) references Exam(Id),
    foreign key (StudentId) references Student(Id)
);
