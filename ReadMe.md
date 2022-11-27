This project is a test to show your understanding of SOLID principles and clean code in general.

Background
----------

This project is designed to aggregate and print areas of shapes that are passed to it.

The project contains three model classes - Circle, Rectangle and Square, but more could be added in the future.

Each of these model classes has relevant properties to define the applicable dimensions and a property that returns the surface area.

There is a class called AreaAggreagator that has two very different purposes 
- first is to sum the areas of a number of objects passed to it
- second is the print a list of areas based on an array of objects passed to it

Lastly, there is a Printer class that can print a message either synchronously or asynchronously.

The design of this project violates a number of the SOLID principles.

Your task is to refactor the project so that

* it no longer violates SOLID principles
* new shapes can be added regardless of how the dimensions are defined 
* aggregation will only accept shapes that have an Area property in its parameters
* aggregation not throw exceptions when null objects are present in the parameters
* aggregation can be fully unit tested
* multiple output writer implementations can be used, not just a printer
* output writing can be fully unit tested
* any code smells or bad practices are corrected
* the refactored solution passes all tests with as near as possible to complete code coverage

Guidance
--------

This is a more test oriented to a more senior role and has been chosen as it represents where you would have opportunities to grow, 
with support and mentorship throughout your first year in the role. 

We do not expect you to be able to fully complete the task as set but would like to get a feel for your current strengths and weaknesses.
It will help us to get a feel for how you approach a coding problem and allow the opportunity to discuss your solution together. 

Some Hints to help you get started: 
-----------------------------------

o Take a look at the unit tests and ensure you are happy that the code is fully under test.
o Look for areas where refactoring out base classes might simplify code and move you closer to a solution.
o How might you take advantage of dependency injection to help you separate your business logic (code that calculates area of shapes) from the infrastructure code (the printer class)?
o Working through the SOLID principles, which might be applied to this codebase, (Focusing mainly on SRP, and ISP/DIP)? 

## My Notes

Usually I would work incrementally with commits, but git wasn't mentioned

Write tests for null objects in aggregation

Error handling on Area prop

IOutputWriter Interface for printer - so area aggregator relies on Interface not concretion

Dependency inject the writer into aggregator

Chose not to use validator 
~~Use validator to validate shapes with DataAnnnotations that do not have an area property? Could use a validator but all Shapes have a area by default from the abstract base class?~~

split unit tests for SRP
parameterise tests rather than testing individually

`* aggregation can be fully unit tested`
`* output writing can be fully unit tested`

return a value from the printer so we can test it? 

Or test output with ITestOutputHelper

in the end I just tested the print functions for not throwing exceptions as all they do is print.

move print async shapes to outputwriter class?

change from decimal to float (smaller bytes)
