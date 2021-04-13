-- Testing the INSERT
select * from childrensHomework;
DELETE FROM childrensHomework WHERE id>324;

select * from homework;
DELETE FROM homework WHERE id >18 ;

-- Test JSON data
-- {"Name":"TestName","Image":"TestImage","DateDue":"TestDate","Comment":"TestComment"}

-- Testing the UPDATE

-- Mark
--{"Id":1,"Image":"PUTimage", "Comment":"PUTcomment","Annotation":"PUTannotation"}