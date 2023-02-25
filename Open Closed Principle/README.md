# Open-closed Principle
(O) in SOLID <br>
1. Class/method etc. should be open for extensions and close for modifications

Practicaly if you see in code huge <b>if</b> or <b>switch</b> statement then is a huge probably that this statement break this principle.<br>
In the example tere are two branches:
First one is <b>before</b> when you can see how I broke this principle in class Pets (You can see that there is a if statement for pets inside foreach and I want to talk with turtle so then I need to create another if)
In <b>master</b>'s branch I created abrastract class Pet and move funcionality to abstraction then I can remove nasty if statement 