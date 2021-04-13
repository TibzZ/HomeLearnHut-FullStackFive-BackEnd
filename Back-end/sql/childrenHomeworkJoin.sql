--- In progress

select (children.id, children.name, children.avatar,
childrensHomework.childId,
childrensHomework.image,childrensHomework.comment, childrensHomework.annotation
) from children
FULL OUTER JOIN
childrensHomework
on
children.id = childrensHomework.childId
    where childrensHomework.homeworkId=1;
;
