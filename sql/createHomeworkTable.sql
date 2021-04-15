CREATE TABLE homework (
id serial NOT NULL PRIMARY KEY, 
name TEXT NOT NULL,
image TEXT NOT NULL,
dateSet DATE NOT NULL DEFAULT CURRENT_DATE,
dateDue TEXT,
comment TEXT
);

INSERT INTO homework (name, image, dateSet, dateDue, comment) VALUES 
('English - Conjunctions','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/eng.PNG','2020-09-14' ,'Wednesday','Complete each sentence using the correct conjunction. Make sure to read the sentences carefully as you will be using them in class later this week.'),
('Maths - Missing Numbers','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/maths4.PNG','2020-09-25' ,'Monday','Count carefully to find the missing numbers. They are missing from a hundred square and a number line.'),
('Phonics','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/phon2.PNG','2020-10-9' ,'Monday','Do you know what the picture is? Which sound can you hear when you say it? Circle the correct one.'),
('Geography - Identify UK countries and bodies of water','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/geo2.PNG','2020-11-6' ,'Wednesday','Look carefully at the map and use the word bank to help you.'),
('Maths - Tens and Ones','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/maths5.PNG','2020-11-20' ,'Tuesday','Count carefully and think about your number formation when answering each question.'),
('Religious Education - Diwali','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/RE.PNG','2020-12-18' ,'First Day Back','Tell your family and friends what you have learned about each word you find.'),
('Maths - Arrays','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/maths2.PNG','2021-01-08' ,'Monday','Try to remember all the different vocabulary learned in class to complete all fluency questions.'),
('Reading','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/read1.PNG','2021-01-18' ,'Wednesday','Read the Peter Harris Biography again, make sure you read it carefully and underline any key words you think might be important. Then answer the questions.'),
('Maths - Division','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/maths1.PNG','2021-02-05' ,'Monday','Use objects around your home to help you share equally and answer the fluency questions.'),
('Phonics','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/phonics.PNG','2021-02-26' ,'Monday','Do you know what the picture is? Which sound can you hear when you say it? Circle the correct one.'),
('Reading - Comprehension','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/read.PNG','2021-03-12' ,'Monday','Answer each question using the text from Giraffes Cant Dance. Remember to identify the key words that are going to help you the most.'),
('Phonics','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/words.PNG','2021-03-26' ,'Monday','Practice reading words that use "oy" and "oi". Once you match them to the correct picture, try to use them in a sentence.'),
('Maths - Multiplication and Division','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/math3.PNG','2021-04-16' ,'Monday','Read each problem carefully, sing the songs from class to help you solve the problems.'),
('Reading - Comprehension','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/read2.PNG','2021-04-30' ,'Monday','Each sentence is from the text, The Tiger Who Came To Tea. Identify the correct word that completes the sentence.'),
('English - Verbs and Nouns','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/eng2.PNG','2021-05-17' ,'Friday','Remind yourself what is a verb and what is a noun. Read the instructions carefully.'),
('Phonics','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/phonics2.PNG','2021-06-04' ,'Wednesday','Read each word carefully, what sounds can you hear? Match the word to the correct picture.'),
('Maths - Five Times Table','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/maths.PNG','2021-06-14' ,'Wednesday','Start with part A of the varied fluency before moving on to part B.'),
('Geography - Identify continents and oceans','https://homelearnhut.s3.eu-west-2.amazonaws.com/homework/geo.PNG','2021-07-09' ,'Monday','Go to youtube and listen to the songs we learnt in class to help you remember.');