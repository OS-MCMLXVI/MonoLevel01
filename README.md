MONO guidance level 01



What is your test project

You should create an application which allows a user to input first name, last name and GPA of students. In addition, program should enlist those students.


Project details:
- Application will have two operations: „ENLIST“ and „DISPLAY“
- „ENLIST“ - allows to insert student into list of students
- „DISPLAY“ – displays list of students sorted alphabetically (sort by last name - ascending)
- Enforce case-insensitive operation name (e.g. a user can type: „eNlist“, „ENLIst“, „enlist“ and application should still work)
- Dsplay message if user type non-existing operation, and allow to try it again
- Prevent possibility to insert empty values for each studen's property (first name, last name, GPA) [Data validation]
- Display message „You need to insert value. “ and allow user to insert new value again
- Prevent possibility to insert string instead of numerical value for GPA
- Display message „You need to insert numerical value.“ and allow user to insert new value again
- After „DISPLAY“ operation, program should stop – user should be able to see the displayed students but user shouldn't be able to insert new one.


Project structure details:
- Project.Code – ClassLibrary project – core business logic of your application (must be referenced into ConsoleApplication project)
- Project.App – ConsoleApplication project – entry point of your application (everything related to the console's input/output will be made here)


Implementantion details:
- You need to create a static class Operations which holds operation names (you will check operation input against these constants)
- Create a abstract class Person which holds common properties to each person (including Id)
- Create Student class which holds specific student properties (use inheritance)
- Create StudentContainer which will have in-memory list of all students, and will have methods to manipulate that list
- Since user should not be able to assign student id, you need to create StudentIdGenerator class which will provide unique id-s (you may use Singleton pattern – for now avoid thread safe version)
- Upon Student object creation, system will acquire Id via StudentIdGenerator – a user should not be able to set Id
- Create dedicated validation class with methods to validate string (null or empty), operation name and GPA's appropriate data type


Example:
- Operation: ENLIST       Note: Console (bolded values are user input)
    Student
- First name: Ivan        Note: Upon „ENTER“ keystroke next property will appear. In this case „Last name“
- Last name: Ivanovic
- GPA: 2.5                Note:(Upon „ENTER“ keystroke – student should be inserted into repository, and user will be able to choose an operation again)
- Operation: ENLIST
- Student
- First name: Ana
- Last name: Anic
- GPA: 4.6
- Operation: display
    Students in a system:
    1. Anic, Ana – 4.6
    2. Ivanovic, Ivan – 2.5

----------------------------------------

- Operation: enlist
    Student
- First name:               Note: (Upon „ENTER“ keystroke – A validation error message will be displayed)
    You need to insert value.
- First name: Ivan
- Last name: Ivanovic
- GPA: 2.4sda!              Note: (Upon „ENTER“ keystroke – A validation error message will be displayed)
    You need to insert numerical value
- GPA: 2.4
- Operation: DISPLAYnew2    Note: (Upon „ENTER“ keystroke – An operation invalid message will be displayed)
    Operation non-existing, please use appropriate operation
- Operation: DIsplaY
    Students in a system:
    1. Ivanovic, Ivan – 2.4
