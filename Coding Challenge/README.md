# Coding Problem

# Preparation

The code you write in completion of this task, as well as your ability to explain the approach you take and the reasoning behind your decisions are extremely important to us.  This is our primary insight into your coding abilities.  _We hope and expect that you will take this aspect of the interview process seriously!_

During the scheduled code review, the developers reviewing your solution with you will be calling in with the Zoom. During the call, you will be sharing your screen while walking through your solution, so please ensure that you are able to do so using GoToMeeting.

**Prior to the code review, upload your solution to BitBucket and provide Experity with a link to the shared repository no later than an hour before your scheduled interview.** 

# Problem Description

Write a program that takes two inputs from the user:

1. Allow the user to select a text file (\*.txt) using a standard file dialog.
2. Allow the user to type in a word to use for analysis of that text file.

The word chosen by the user is then used to analyze the file selected by the user to do the following:

1. Display each occurrence of the word in a grid on the UI and include the word before and after and the line number (indicated by Carriage Return and Line Feed). 
2. If there is not a word before (within the sentence) indicate NA. If there is not a word after (within the sentence) indicate NA.
3. Count the number of times the word occurs in the file.
4. Count the number of words used in the file.
5. Give a percentage of the word selected vs. the overall word count.


Implement your solution as a WinForms or WPF application in C# using .NET 4 or newer.  (No console applications)
Focus on the following criteria when developing your solution:

- Write your code so that it is easy for one of your peers to extend the code base based on good coding practices and documentation.
- Use of Object Oriented Principles, such as interfaces and common design patterns.
- Submission of a compiling and fully working solution.

# If You Want to Impress

#### Extra Credit Options

If you wish to impress, adding flexibility to your program is an option:

- Use of unit tests (nunit, mstest, or similar framework) is nice.
- Anything you can think of to make an interesting and useful design addition to the program, just create a document outlining the design addition and why you chose to implement it and submit it with your program.