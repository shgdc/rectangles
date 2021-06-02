// the instructions for output for the two rectangles are identical except for the names of the variables
// in such a case it is a good idea to put the instructions into a method and call the method with the desired variables
// this has been done in lines 4-9 below
// the method is called Output
// the word void means that the method does not return a value
// the parentheses after the method name contains variable declarations
// as you can see within the method, the method can use these variables
// also, as you can see in lines 45 and 46, a method can be used by writing its name followed by parentheses containing a list of values
// these values are written into the method's variables

void Output(string name, float edgeA, float edgeB, float surface, float circumference, bool isSquare) {
    Console.WriteLine("The two edges of rectangle " + name + " are " + edgeA + " and " + edgeB + ".");
    Console.WriteLine("The surface of rectangle " + name + " is " + surface + ".");
    Console.WriteLine("The circumference of rectangle " + name + " is " + circumference + ".");
    Console.WriteLine("Rectangle " + name + " is " + (!isSquare?"not ":"")+ "a square.");
}

float r1_edgeA; // Kante des Rechtecks
float r1_edgeB; // Kante des Rechtecks

float r1_surface; // Fläche des Rechtecks
float r1_circumference; // Umfang des Rechtecks
bool r1_isSquare; // Ist das Rechteck ein Quadrat?

float r2_edgeA; // Kante des Rechtecks
float r2_edgeB; // Kante des Rechtecks

float r2_surface; // Fläche des Rechtecks
float r2_circumference; // Umfang des Rechtecks
bool r2_isSquare; // Ist das Rechteck ein Quadrat?

r1_edgeA = 12.5f;
r1_edgeB = 9.25f;
r1_edgeB = r1_edgeA;

r1_surface = r1_edgeA * r1_edgeB;
r1_circumference = 2f * (r1_edgeA + r1_edgeB);
r1_isSquare = r1_edgeA == r1_edgeB;

r2_edgeA = 12.5f;
r2_edgeB = 9.25f;

r2_surface = r2_edgeA * r2_edgeB;
r2_circumference = 2f * (r2_edgeA + r2_edgeB);
r2_isSquare = r2_edgeA == r2_edgeB;

Output("R1", r1_edgeA, r1_edgeB, r1_surface, r1_circumference, r1_isSquare);
Output("R2", r2_edgeA, r2_edgeB, r2_surface, r2_circumference, r2_isSquare);