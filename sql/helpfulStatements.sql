-- Testing the INSERT
select * from childrensHomework;
DELETE FROM childrensHomework WHERE id>324;

select * from homework;
DELETE FROM homework WHERE id >18 ;

-- Test JSON data

-- Test INSERT (upload) Homework
-- {"Name":"TestName","Image":"https://homelearnhut.s3.eu-west-2.amazonaws.com/done/m-RE.png","DateDue":"TestDate","Comment":"TestComment"}

-- Testing the UPDATE
-- Test Mark (PUT)
-- Need false annotation
-- {"Id":1,"Image":"https://homelearnhut.s3.eu-west-2.amazonaws.com/done/m-RE.png", "Comment":"PUTmarkcomment","Annotation":"{\"lines\":[{\"points\":[{\"x\":214.71199920841985,\"y\":410.0786050260287},{\"x\":214.71199920841985,\"y\":410.0786050260287},{\"x\":214.71199920841985,\"y\":410.0786050260287},{\"x\":214.71199920841985,\"y\":410.0786050260287},{\"x\":214.66277312305502,\"y\":408.2571826541575},{\"x\":214.64867905594156,\"y\":407.25747244659266},{\"x\":214.64867905594156,\"y\":407.25747244659266},{\"x\":215.16851842390457,\"y\":406.15361653605004},{\"x\":215.3848248745878,\"y\":405.2289063637556},{\"x\":215.8024326362865,\"y\":404.8735952072817},{\"x\":216.83537588725918,\"y\":403.9105793467731},{\"x\":218.0354092055983,\"y\":402.07914548317774},{\"x\":218.93384279642854,\"y\":401.00383432501326},{\"x\":219.6546847009069,\"y\":400.6487435441828},{\"x\":219.6546847009069,\"y\":400.6487435441828}],\"brushColor\":\"#66ff00\",\"brushRadius\":2}],\"width\":530,\"height\":700}"}

-- Test Reject (PUT)
-- {"Id":1,"Image":null, "Comment":"PUTrejectcomment","Annotation":null}