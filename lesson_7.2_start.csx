// bisher werden den öffentlichen Variablen der Objekte nach der Erstellung der Objekte von außen Werte zugewiesen
// besser ist es diese Variablen mit dem Access Modifier "private" zu verbergen und ihre Werte mit Hilfe einer besonderen zusätzlichen Methode zu setzen
// diese besondere Methode nennt man einen Konstruktur; im Gegensatz zu einer normalen Methode werden Konstruktoren ohne Typ für einen Rückgabewert definiert
// Konstruktoren heißen genauso wie ihre Klasse; Konstruktoren können Parameter haben; eine Klasse kann mehrere Konstruktoren haben
// Aufgabe: 1) verberge die Variablen der Klasse 2) erstelle einen Konstruktor, um die Variablen zu setzen 3) passe den Rest des Programms entsprechend an

class Rectangle {
    public float edgeA;
    public float edgeB;
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

Rectangle r1 = new Rectangle();
Rectangle r2 = new Rectangle();

r1.edgeA = 12.5f;
r1.edgeB = 9.25f;
r1.edgeB = r1.edgeA;

r2.edgeA = 12.5f;
r2.edgeB = 9.25f;

Console.WriteLine("The two edges of rectangle R1 are " + r1.edgeA + " and " + r1.edgeB + ".");
Console.WriteLine("The surface of rectangle R1 is " + surface(r1.edgeA, r1.edgeB) + ".");
Console.WriteLine("The circumference of rectangle R1 is " + circumference(r1.edgeA, r1.edgeB) + ".");
Console.WriteLine("Rectangle R1 is " + (!isSquare(r1.edgeA, r1.edgeB)?"not ":"")+ "a square.");

Console.WriteLine("The two edges of rectangle r2 are " + r2.edgeA + " and " + r2.edgeB + ".");
Console.WriteLine("The surface of rectangle r2 is " + surface(r2.edgeA, r2.edgeB) + ".");
Console.WriteLine("The circumference of rectangle r2 is " + circumference(r2.edgeA, r2.edgeB) + ".");
Console.WriteLine("Rectangle r2 is " + (!isSquare(r2.edgeA, r2.edgeB)?"not ":"")+ "a square.");
