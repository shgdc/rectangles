// der nächste Schritt besteht darin, für die Rechtecke eine Klasse einzuführen. 
// Die Gemeinsamkeiten der Rechtecke werden dabei an einer Stelle definiert. 
// Man kann sich die Klasse wie eine allgemeine Vorlage vorstellen, mit der man beliebig viele konkrete Objekte erzeugen kann.
// unten ist zunächst die Klasse definiert und das erste Rechteck mit Hilfe der Klasse neu als Objekt definiert worden.
// Schau Dir die beiden Zeile genau an, in denen das Rechteck erzeugt wird. In den Kommentaren dort werden die Zeilen erklärt.
// leider gibt es eine Reihe Fehlermeldungen; diese liegen daran, dass die Variablen einer Klasse von außen nicht zugreifbar sind, wenn sie wie hier edgeB deklariert werden;
// um dies zu korrieren, deklariere edgeB wie edgeA mit dem sogenannten Access Modifier "public"
// Aufgabe: ändere das zweite Rechteck entsprechend um
// 

class Rectangle {
    public float edgeA;
    float edgeB;
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

float r2_edgeA; // Kante des Rechtecks
float r2_edgeB; // Kante des Rechtecks

Rectangle r1;           // die Variable r1 wird mit der von uns definierten Klasse als Typ deklariert
r1 = new Rectangle();   // der Variable r1 wird ein neues Objekt der Klasse Rectangle zugewiesen; 
                        // dafür wird eine besondere Methode der Klasse aufgerufen, die automatisch erzeugt wird; diese Methode heißt Standard-Konstruktor

r1.edgeA = 12.5f;
r1.edgeB = 9.25f;
r1.edgeB = r1.edgeA;

r2_edgeA = 12.5f;
r2_edgeB = 9.25f;

Console.WriteLine("The two edges of rectangle R1 are " + r1.edgeA + " and " + r1.edgeB + ".");
Console.WriteLine("The surface of rectangle R1 is " + surface(r1.edgeA, r1.edgeB) + ".");
Console.WriteLine("The circumference of rectangle R1 is " + circumference(r1.edgeA, r1.edgeB) + ".");
Console.WriteLine("Rectangle R1 is " + (!isSquare(r1.edgeA, r1.edgeB)?"not ":"")+ "a square.");

Console.WriteLine("The two edges of rectangle r2 are " + r2_edgeA + " and " + r2_edgeB + ".");
Console.WriteLine("The surface of rectangle r2 is " + surface(r2_edgeA, r2_edgeB) + ".");
Console.WriteLine("The circumference of rectangle r2 is " + circumference(r2_edgeA, r2_edgeB) + ".");
Console.WriteLine("Rectangle r2 is " + (!isSquare(r2_edgeA, r2_edgeB)?"not ":"")+ "a square.");
