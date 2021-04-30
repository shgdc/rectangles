// wie man sieht kann man das Programm mit dem aktuellen Ansatz nicht wieder läuffähig machen, denn es fehlt Zugriff auf die Objekt-Variablen
// im nächsten Schritt stellen wir den Zugriff wieder her

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
