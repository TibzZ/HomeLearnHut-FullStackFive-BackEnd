-- Testing the INSERT
select * from childrensHomework;
DELETE FROM childrensHomework WHERE id>324;

select * from homework;
DELETE FROM homework WHERE id >18 ;

-- Test JSON data
-- Test INSERT (upload) Homework
-- {"Name":"TestName","Image":"TestImage","DateDue":"TestDate","Comment":"TestComment"}

-- Testing the UPDATE
-- Test Mark (PUT)
----{"Name":"TestName","Image":"https://homelearnhut.s3.eu-west-2.amazonaws.com/done/m-RE.png","DateDue":"TestDate","Comment":"TestComment"}-

-- Test Reject (PUT)
-- {}