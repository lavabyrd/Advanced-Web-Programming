# Courses App

## Horse Bet Tracking

* Hand In Date:  25 Feb 2018

HotTipster is a would-be horse tipper, i.e., he offers advice as to which horse to place a bet on.  
He has approached you to develop a first-cut system that will record all of his tips/bets and their results, 
together with some queries/reports that he can run against this data.

_The following is some historical data that you should make use of:_
  
The first field is the race course, the second is the date  (in YYYY, MM, DD format), 
the third field is the amount won or lost, while the last field is a flag indicating whether the bet was won or lost.
Write either a console application or a Windows Forms application to capture horse bets.  
You will need to be able to store horse bets, create them and produce a number of reports (see below).  
In this assignment, a horse bet should store the race course where the horse ran, the name of the horse, 
the date on which the race took place, the amount won or lost and an indicator to specify whether the bet was won or lost.

*Requirements and Reports/Queries*

Provide a way for a user to enter horse bet details:  race course, date of the race, the amount that was won or 
lost and a flag indicating whether the bet was a win or a loss.
Start your code with the hard-coded race bets listed above.  
However, you need to provide a mechanism for writing and reading these race bets to a binary text file. 
 This option should be provided via a menu choice.
Provide a report that lists years, total won and total lost, e.g., the output will look like the following:


Year        Total Won       Total Lost
2016        €123.45         €678.90
2017        €543.21         €987.60


* Provide a report that shows the most popular race course for bets.  The most popular race course is the one with the most bets placed on it.
* Provide a report that shows the bets in date order.
* Provide another report that displays the highest amount won for a bet laid and the most lost for a bet laid.
* Provide a report to indicate how successful HotTipster is at horse betting.  This should display the total number of races alongside the number of races that HotTipster has won a bet on.

_Notes_
Please ensure that you build your code base using Test Driven Development, TDD.  So, remember:  Red→Green→Refactor.
For writing and reading horse bets from a binary file, it is entirely up to you how you do this, e.g., you can use a BinaryReader/BinaryWriter, or perhaps a BinaryFormatter.
Ensure you write defensive code.
Use LINQ to produce the results of the reports.