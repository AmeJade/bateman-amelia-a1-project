//Opening dialouge

using System.ComponentModel.Design;

Console.WriteLine("You find yourself waking up in a mysterious dark room.");

Console.WriteLine("Infront of you find a dingy elevator, what do you do?");

Console.WriteLine("Go back to sleep? | Enter the elevator?");

// 1st choice proccesor 

string choice1 = Console.ReadLine();

if (choice1 == "Go back to sleep") Console.WriteLine("You went back to sleep, but little did you know, this wasn't a dream. A monster comes out of the elevator and eats you in your sleep.");
else if (choice1 == "Enter the elevator") Console.WriteLine("You step into the elevator and see a run down looking, but still working button pannel."); Console.WriteLine("You are currently on Floor 1, there's a control panel for the elevator infront of you, but it seems to be broken with the exception of the 2nd floor button. Will you press the button?");
Console.WriteLine("Yes | No");
string choice2 = Console.ReadLine();

//This section is responsible for processing the user's choices in each floor
//floor 2

if (choice2 == "Yes") Console.WriteLine("You selected the second floor and are quickly taken to a strange looking, almost swamp like enviorment.");
else if (choice2 == "No") Console.WriteLine("You choose not to press the button and figure out what is going on and where you are, but the elevator button starts to glow before seeming to press itself, taking you to the 2nd floor anyway");
Console.WriteLine("You stepped out of the elevator and into the swamp. The ground feels sticky and mushy. While observing your surroundings, you hear some rustling in a nearby bush. What will you do?"); Console.WriteLine("Ignore it and keep investigating elsewhere | Inspect the bush");

string floor2choice1 = Console.ReadLine();

if (floor2choice1 == "Inspect the bush") Console.WriteLine("You creep up onto the bush, but accidentally stepped on a stick which caused it to snap. The monster hiding in the bush notices you and eats you. Too bad!");
else if (floor2choice1 == "Ignore it and keep investigating elsewhere") Console.WriteLine("You ignore the noise and look elsewhere for a way out. Upon furthur inspection, you notice that you're being followed by whatever it was hiding in the bush. What do you do?"); Console.WriteLine("Cower and hope it goes away | Fight the monster");

string floor2choice2 = Console.ReadLine();
 
//monster fight
if (floor2choice2 == "Cower and hope it goes away") Console.WriteLine("You curl into a ball and cover your head hoping the monster goes away, sadly for you it does not, and you get eaten. Too bad!");
else if (floor2choice2 == "Fight the monster") Console.WriteLine("You initiated a fight with the monster. What will you do?");
Console.WriteLine("Charge at it and punch it in the stomache | Grab it's head and poke it's eyeballs with your fingers");

//monster fight results
string floor2choice3 = Console.ReadLine();

if (floor2choice3 == "Charge at it and punch it in the stomache") Console.WriteLine("You ran up to the monster and punched it in it's stomache. The monster doesn't even feel a lick of pain due to it's thick hide and eats you while you're vunurable. Try Again!");
else if (floor2choice3 == "Grab it's head and poke it's eyeballs with your fingers") Console.WriteLine("You run up to the monster and grab it's head before it can move, and without a second thought you shove your fingers as far as they can go into the monster's eye sockets. The monster whails in pain and is blinded."); Console.WriteLine("You take this oppurtunity to run away as fast and as far as you can."); Console.WriteLine("You see another elevator door in the distance and rush inside. The moment you get inside you press the only working button on the panel to escape, taking you to the 3rd floor.");


//floor 3
Console.WriteLine("Upon selecting the third floor and are quickly taken to what appears to be a dark and dingy cave.");
Console.WriteLine("You stepped out of the elevator and into the cave. You see stalagmites and stalagtites everywhere, slowly dripping and catching water droplets respectivley.");
Console.WriteLine("The room is oddly small featuring a door and a chest among the otherwise natural looking cave enviorment. What do you do?"); Console.WriteLine("Open the door | Inspect the chest");

string floor3choice1 = Console.ReadLine();

if (floor3choice1 == "Inspect the chest") Console.WriteLine("You approach the chest and pry the lid open to reveal... the mouth of a Mimic! Before you can back away, it clamps it's maw shut, cutting you in half. Try Again!");
else if (floor3choice1 == "Open the door") Console.WriteLine("You approach the door and turn the knob, but the door doesn't budge. It seems it's locked."); Console.WriteLine("Suddenly you hear a growling noise from behind you. You turn around to see the chest from earlier was actually a hungry Mimic!"); Console.WriteLine("The Mimic unleashes it's long tounge and wraps it around you, bringing you in closer once it's trapped you. What do you do"); Console.WriteLine("Try to wriggle your way out of it's grip | Stab it's tounge with a loose stalagmite");

//monster fight 2
string floor3choice2 = Console.ReadLine();

if (floor3choice2 == "Try to wriggle your way out of it's grip") Console.WriteLine("You helplessly attempt to wriggle and pry yourself out of it's tight grip, but to no avail. You are eaten by the Mimic. Try Again!");
else if (floor3choice2 == "Stab it's tounge with a loose stalagmite") Console.WriteLine("You look around you in hopes of finding something to use as a weapon and spot a loose looking stalagmite. You reach over to it and rip it out off the ground. What will you do?"); Console.WriteLine("Shove the stalagmite down the Mimic's throat | Stab the stalagmite through the Mimic's tounge");

string floor3choice3 = Console.ReadLine();

if (floor3choice3 == "Shove the stalagmite down the Mimic's throat") Console.WriteLine("Stalagmite in hand, you thrust it into the Mimic's mouth, however in it's injury induced panic, the Mimic clamps it's jaws shut on your arm. You fall onto the floor in agony, and while you're bleeding out, the Mimic makes a counter attack and bites your head off. Try again!");
else if (floor3choice3 == "Stab the stalagmite through the Mimic's tounge") Console.WriteLine("You jab the stalagmite you grabbed into the Mimic's tounge. The Mimic unravels it's tounge in pain and coughs up a key. Without much time to spare, you grab the key and use it to open the door, leading you to yet another elevator. You quckly rush in and press the only working button, taking you to the 4th floor");


//floor 4
if (floorchoice == "4") Console.WriteLine("");

//floor 5
if (floorchoice == "5") Console.WriteLine("");







