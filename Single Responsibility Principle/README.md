# Single Reponsibility Principle
(S) in SOLID

1. Class/method etc. should be responsible for only one functionality
2. There should be only one reason to modify for example method.

In this example there are two branches: </br>
First one is <b>before</b> when you can see how I broke this principle in class AddUserService, then I separate two funcionality from this class to: <br>
1. UserRepository - register new user
2. SendEmailService - send email after registration was done.
