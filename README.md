# CSharp-Practice
Just a homework= = ez

##Using MySQL

Table department

+--------------+-------------+------+-----+---------+----------------+
| Field        | Type        | Null | Key | Default | Extra          |
+--------------+-------------+------+-----+---------+----------------+
| Name         | varchar(30) | NO   |     | NULL    |                |
| DepartmentID | int(11)     | NO   | PRI | NULL    | auto_increment |
+--------------+-------------+------+-----+---------+----------------+

Table user

+--------------+-------------+------+-----+---------+----------------+
| Field        | Type        | Null | Key | Default | Extra          |
+--------------+-------------+------+-----+---------+----------------+
| ID           | int(11)     | NO   | PRI | NULL    | auto_increment |
| Name         | varchar(30) | NO   |     | NULL    |                |
| Gender       | varchar(20) | NO   |     | NULL    |                |
| DepartmentID | int(11)     | NO   | MUL | NULL    |                |
| Class        | varchar(30) | NO   |     | NULL    |                |
| Birthday     | date        | YES  |     | NULL    |                |
+--------------+-------------+------+-----+---------+----------------+
