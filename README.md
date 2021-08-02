## RobotCodeChallenge

### Approach 
I approached this code challenge methodically. Starting with deciding which part of the robot challenge i was going to attempt to create
and then using my knowledge of C# to create a simple yet effective application that did all of the required tasks

The first part was trying to get the program to read and grab the variables from the "PLACE" command. This was done
using Regex to create a pattern that detected when the command was written correctly. Once detected it would split the string
and assign it to variables to be used.

The other commands were then simply detected using a switch statement creating a simple and effective way to move the robot.

To remove complexitiy from the code i created a function to detect when the robot is off the table to determine if it should listen to the command written.

Finally to test the key functions in my code i used Unit Tests. These tested mainly the Regex pattern to determine that it was going to read
the correct command.

The code written was designed too to be easily expanded upon and read with the intention of future work being made on the written code.

### Testing
To use this program, each line of the sample inputs need tobe typed in manually, this was a design choice as it gives the user 
an easy way to manipulate the robot's movements as they please rather than using a .txt file with pre written commands.

When i tested the code i ensured that when the sample input commands where used. The respective output was correct.

### Tools
C# .NET Standard 2.0
Visual Studio 2019


### Rules of Challenge
```
Description:

The application is a simulation of a toy robot moving on a square
tabletop, of dimensions 5 units x 5 units.

There are no other obstructions on the table surface.

The robot is free to roam around the surface of the table, but must be
prevented from falling to destruction.  Any movement that would result
in the robot falling from the table must be prevented, however further
valid movement commands must still be allowed.

Create an application that can read in commands of the following form -

    PLACE X,Y,F
    MOVE
    LEFT
    RIGHT
    REPORT

Where PLACE will put the toy robot on the table in position X,Y and
facing NORTH, SOUTH, EAST or WEST.  The origin (0,0) can be considered to
be the SOUTH WEST most corner.

It is required that the first command to the robot is a PLACE command,
after that, any sequence of commands may be issued, in any order, including
another PLACE command.  The application should discard all commands in
the sequence until a valid PLACE command has been executed.

Where MOVE will move the toy robot one unit forward in the direction
it is currently facing.

Where LEFT and RIGHT will rotate the robot 90 degrees in the specified
direction without changing the position of the robot.

Where REPORT will announce the X,Y and F of the robot.  This can be
in any form, but standard output is sufficient.

A robot that is not on the table can choose the ignore the MOVE, LEFT,
RIGHT and REPORT commands.

Input can be from a file, or from standard input, as the developer chooses.

Provide test data to exercise the application.

Constraints:

The toy robot must not fall off the table during movement.  This also
includes the initial placement of the toy robot.  Any move that would cause
the robot to fall must be ignored.

Example Input and Output:

a)----------------
PLACE 0,0,NORTH
MOVE
REPORT

Output: 0,1,NORTH

b)----------------
PLACE 0,0,NORTH
LEFT
REPORT

Output: 0,0,WEST
c)----------------
PLACE 1,2,EAST
MOVE
MOVE
LEFT
MOVE
REPORT

Output: 3,3,NORTH

Deliverables:

The source files, the test data and any test code.

It is not required to provide any graphical output showing the movement
of the toy robot.
```
