//Opening dialouge

Console.WriteLine("You find yourself waking up in a mysterious dark room.");

Console.WriteLine("Infront of you find a dingy elevator, what do you do?");

Console.WriteLine("Go back to sleep? | Enter the elevator?");

// 1st choice proccesor 

string choice1 = Console.ReadLine();

if (choice1 == "Go back to sleep") Console.WriteLine("You went back to sleep, but little did you know, this wasn't a dream. A monster comes out of the elevator and eats you in your sleep.");
else if (choice1 == "Enter the elevator") Console.WriteLine("You step into the elevator and see a run down looking, but still working button pannel."); Console.WriteLine("You are currently on Floor 1, you can visit floors 2-5. Which floor would you like to travel to?");

//This section is responsible for processing the user's choice of floor to visit

//floor 2
string floorchoice = Console.ReadLine();

if (floorchoice == "2") Console.WriteLine("You selected the second floor and are quickly taken to a strange looking, almost swamp like enviorment.");
Console.WriteLine("You stepped out of the elevevator and into the swamp. The ground feels sticky and mushy. While observing your surroundings, you hear some rustling in a nearby bush. What will you do?"); Console.WriteLine("Ignore it and keep investigating elsewhere | Inspect the bush");

string floor2choice1 = Console.ReadLine();

if (floor2choice1 == "Inspect the bush") Console.WriteLine("You creep up onto the bush, but accidentally stepped on a stick which caused it to snap. The monster hiding in the bush notices you and eats you. Too bad!");
else if (floor2choice1 == "Ignore it and keep investigating elsewhere") Console.WriteLine("You ignore the noise and look elsewhere for a way out. Upon furthur inspection, you notice that you're being followed by whatever it was hiding in the bush. What do you do?"); Console.WriteLine("Cower and hope it goes away | Fight the monster");

string floor2choice2 = Console.ReadLine();

if (floor2choice2 == "Cower and hope it goes away") Console.WriteLine("You curl into a ball and cover your head hoping the monster goes away, sadly for you it does not, and you get eaten. Too bad!");
else if (floor2choice2 == "Fight the monster") Console.WriteLine("Your pathetic attempt at fighting such a powerful monster fail, and you are eaten. Too bad!");

//floor 3
if (floorchoice == "3") Console.WriteLine("");

//floor 4
if (floorchoice == "4") Console.WriteLine("");

//floor 5
if (floorchoice == "5") Console.WriteLine("");









