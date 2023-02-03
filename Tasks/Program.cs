//Exam
//Test
//Test 2


//asd

//Developer 's Vineyard
//Kiril is a successful senior software developer. One of the benefits of such a career is the opportunity to work remotely. One day, he decided to relocate in a less populated area, outside of the big city. And because he is very good and efficient at his job, he can also dedicate enough time to grow his own vineyard and brew rakia and wine every year! Now, he needs help to calculate the next year's yield, so he can know in advance if he would be able to treat all his colleagues with a glass of wine and rakia!

//Keep in mind the following:

//1 vine produces 7 kilos of grapes.
//1 bottle of wine is 750ml and requires 1 kilo of perfect quality grapes.
//1 bottle of rakia is 700ml and requires 5 kilos of average quality grapes.
//1 glass of wine is exactly 150ml.
//1 glass of rakia is exactly 50ml.
//You cannot bring half full or half empty bottles to the party ;)
//Each of Kiril's colleagues should be able to taste at least 2 glasses of wine and 1 glass of rakia.
//On the first line of the input you will receive the number of colleagues - N.
//On the second line you will receive the length of the vineyard that Kiril has grown so far - M.
//On the third line, you will receive a visual representation of the vineyard, as a string.
//Here's a legend:
//X - this is a vine with perfect quality grapes
//x - this is a vine with average quality grapes
//= - something bad happened to the vine here, it is not suitable for brewing neither vine or rakia.

//Example 1:

//= X = x = x =
//Explanation:

//This vineyard has 1 vine with perfect quality grapes, 2 vines with average quality grapes and 4 vines that are ruined.
//That equals to 7 kilos of perfect quality grapes and 14 kilos of average quality grapes.
//That equals to 7 bottles of wine and 2 bottles of rakia.
//That equals to 35 glasses of wine and 28 glasses of rakia.
//Example 2:

//XXXXXXXX
//Explanation:

//This vineyard has 8 vines with perfect quality grapes, but not a single vine with average quality grape, so no rakia will be brewed. Too much of a good thing can sometimes be bad, right?
//Input
//On the first line of the input you will receive the number of colleagues - N.
//On the second line you will receive the length of the vineyard that Kiril has grown so far - M.
//On the third line, you will receive a visual representation of the vineyard, as a string.
//Output
//Exactly one line:

//Yes! X bottles of wine and Y bottles of rakia remaining for the next party!
//or
//No! X more bottles of wine and Y more bottles of rakia required!
//Sample tests
//Input
//20
//2
//Xx
//Output
//No! 1 more bottles of wine and 1 more bottles of rakia required!
//Input
//40
//6
//xXx=Xx
//Output
//No! 2 more bottles of wine and 0 more bottles of rakia required!

//----------------------------------------------------------------------

//using System.ComponentModel;

//Sufficiently Strong Key
//Finally! You achieved your dream to become a programmer and now you are battling with your first real task. Your web application will open up to the world so it requires api keys. The task of writing the code to generate them falls to you and you are ready in no time. However, suspicion starts to creep in - is your code producing sufficiently random and strong api keys? For an api key to be considered as strong, it must satisfy the following criteria:

//contain at least 3 lowercase chars (a-z)
//contain at least 3 uppercase chars (A-Z)
//contain at least 3 digits (0-9)
//contain at least 3 special chars (!@#$%^&*()_+-=><?)
//must be at least 15 chars long
//You quickly write some code to test your other code and some of the generated api keys are found not up to standard. Logically, you come up with the brilliant idea to write code that will fix existing api keys, but to that, you need some code that can calculate how many chars need to be appended to existing not-strong-enough keys.

//Examples:

//telerikacademy123 - requires 6 more.
//abc123ABC!@# - requires 3 more.
//The api key telerikacademy123 is at least 15 chars long, and contains 3 lower and 3 digits, but is missing 3 uppercase and 3 special. So it needs a minimum of 6 additional chars to become sufficiently strong. abc123ABC!@# contains 3 of each, but is not long enough - so it needs 3 more chars to reach the minimum length of 15.

//Input
//Exactly one line: (can contain any symbol)

//the api key
//Output
//Exactly one line:

//number: how many chars you need to append to make it sufficiently random
//Sample tests
//Input
//telerikacademy123
//Output
//6
//3 uppercase and 3 special chars missing

//Input
//ASas12!@
//Output
//7

// NA Sufficient strong key sum, dobre vurvi, edna zada4a e re6ena



//2 ot 3 zada4i sum re6il

//Ostava vineyard imam predstava kakvo da napravq