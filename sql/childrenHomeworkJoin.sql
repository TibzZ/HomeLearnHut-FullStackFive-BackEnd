select children.id, children.name, children.avatar, childrensHomework.image,childrensHomework.comment, childrensHomework.annotation
from children
FULL OUTER JOIN
childrensHomework
on
children.id = childrensHomework.childId
 where homeworkId=@Id;