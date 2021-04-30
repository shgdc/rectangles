// man kann folgendes beobachten:
// die Kanten werden nur noch einmal in der Klasse deklariert und nicht mehr für jedes Objekt
// der Zugriff auf die Kanten mit z.B. r1.edgeA ist deutlich verschieden von r1_edgeA, obwohl er sehr ähnlich aussieht
// bei r1.edgeA und r2.edgeA handelt es sich um den Zugriff auf zwei Variablen, die in unterschiedlichen Objekten existieren
// bei r1_edgeA und r2_edgeA handelt es ich um den Zugriff auf zwei Variablen, die im gleichen Programmkontext existieren, hier dem Hauptprogramm

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
