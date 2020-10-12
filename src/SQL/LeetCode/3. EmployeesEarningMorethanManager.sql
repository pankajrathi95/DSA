/*
#181 - https://leetcode.com/problems/employees-earning-more-than-their-managers/
The Employee table holds all employees including their managers. Every employee has an Id, and there is also a column for the manager Id.

+----+-------+--------+-----------+
| Id | Name  | Salary | ManagerId |
+----+-------+--------+-----------+
| 1  | Joe   | 70000  | 3         |
| 2  | Henry | 80000  | 4         |
| 3  | Sam   | 60000  | NULL      |
| 4  | Max   | 90000  | NULL      |
+----+-------+--------+-----------+
Given the Employee table, write a SQL query that finds out employees who earn more than their managers. For the above table, Joe is the only employee who earns more than his manager.

+----------+
| Employee |
+----------+
| Joe      |
+----------+
*/

/* using JOINS*/
select e.Name as 'Employee' from Employee e
JOIN Employee m
ON e.ManagerId = m.Id
where e.Salary > m.Salary

/* without JOINS*/
select a.Name as 'Employee' from Employee AS a, Employee as b
where 
a.ManagerId = b.Id
and
a.Salary > b.Salary