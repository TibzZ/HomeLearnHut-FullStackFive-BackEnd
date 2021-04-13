--- In progress

select (id, name, avatar) from children
FULL OUTER JOIN
(select * from childrensHomework)
ON
id = childId;