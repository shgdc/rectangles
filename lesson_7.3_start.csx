// man könnte den Zugriff auf die privaten Objekt-Variablen mit Hilfe von öffentlichen Methoden herstellen
// aber für genau diesen Zweck gibt es einen besonderen Ansatz, die sogenannten Object-Properties
// siehe https://www.w3schools.com/cs/cs_properties.asp
// diese ermöglichen es unter anderem dafür zu sorgen, dass den Objekt-Variablen keine unerwünschten Werte zugewiesen werden
// Object Properties heißen genauso wie die entsprechenden Variablen, werden aber groß geschrieben
// diese Objekteigenschaften sind wie eine Kombination aus einer Variable und drei festgelegten Zugriffsmethoden get, set und init
// die Zugriffsmethoden können, müssen aber nicht definiert werden; durch Weglassen der get-Zugriffsmethode kann man z.B. Schreibzugriff verhindern
// Aufgabe: 1) füge der Klasse zwei Eigenschaften EdgeA und EdgeB hinzu 2) definiere jeweils nur die get-Methode für diese Eigenschaften
// 3) passe den Rest des Programms ensprechend an

class Rectangle {
    float edgeA;
    float edgeB;

    public Rectangle (float a, float b) {
        edgeA = a;
        edgeB = b;
    }
}

float circumference (float a, float b) {
    return 2 * (a + b);
}

float surface (float a, float b) {
    return a * b;
}

bool isSquare (float a, float b) {
    return a == b;
}

Rectangle r1 = new Rectangle(12.5f,12.5f);
Rectangle r2 = new Rectangle(12.5f, 9.25f);

Console.WriteLine("The two edges of rectangle R1 are " + r1.edgeA + " and " + r1.edgeB + ".");
Console.WriteLine("The surface of rectangle R1 is " + surface(r1.edgeA, r1.edgeB) + ".");
Console.WriteLine("The circumference of rectangle R1 is " + circumference(r1.edgeA, r1.edgeB) + ".");
Console.WriteLine("Rectangle R1 is " + (!isSquare(r1.edgeA, r1.edgeB)?"not ":"")+ "a square.");

Console.WriteLine("The two edges of rectangle r2 are " + r2.edgeA + " and " + r2.edgeB + ".");
Console.WriteLine("The surface of rectangle r2 is " + surface(r2.edgeA, r2.edgeB) + ".");
Console.WriteLine("The circumference of rectangle r2 is " + circumference(r2.edgeA, r2.edgeB) + ".");
Console.WriteLine("Rectangle r2 is " + (!isSquare(r2.edgeA, r2.edgeB)?"not ":"")+ "a square.");
