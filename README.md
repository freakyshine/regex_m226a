# RegEx (M226a)

## This project

- .. a project for school explaining the use and documents RegEx

## What is RegEx?

Regex are short line of instructions that give you as a developer a lot of power.

<img src="https://images-cdn.9gag.com/photo/aGdNNK5_700b.jpg" alt="Meme" style="zoom:25%; float:left;" />

It is used in a lot of different ways. For example in search queries, password validation, or to check if a string is an E-Mail address (the RegEx in the michmich does that).

## Syntax

| Syntax             | Description                                                  | Usage   |
| ------------------ | ------------------------------------------------------------ | ---------------- |
| ```[ ]```          | Matches any character in the given set<br />The set is defined in-between the brackets | /**[**a-z**]**/g |
| ```/g```                 | Is the expression flag to define where to apply the condition<br />There are also expression flags to only look on one line for example, but this won't be explained any further in this project | /[a-z]**/g**     |
| ```a-z```          | Includes every roman letter from a to z (**lower case**)     | /[**a-z**]/g     |
| ```A-Z```          | Includes every roman letter from A to Z (**upper case**)     | /[**A-Z**]/g     |
| ```0-9``` ```\d``` | Includes every Arabic digit from 0 to 9                      | /[**0-9**]/g     |
| ```\w```           | All of the above (a-z, A-Z, 0-9)                             | /**\w**/g        |
| ```\W```           | All none-word characters. Pretty much symbols and whitespaces. | /**\W**/g        |
| ```^```            | Is used to explicitly define the start of a string. The given regex has to apply to the first character. | /**^**[A-Z]/g    |
| ```{2,4}```        | *2* and *4* can be any number. They define the range of the length the string can be.<br />The example on the right will match with every string that is only letters and is between 3 and 5 letters. | /[a-zA-Z]**{3,5}**/g |



