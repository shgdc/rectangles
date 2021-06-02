// der letzte Schrit besteht darin, die Methoden zur Berechnung der Rechteckeigenschaften in die Klasse hineinzuziehen
// da die Methoden dann Zugriff auf die privaten Variablen der Objekte haben, könnte man die Parameter entfernen
// auf diese Weise könnte man die Methoden dann auf dem Objekt aufrufen, ohne das man Argumente angeben müsste
// nennen wir das obige Vorgehen Ansatz 1
// alternativ kann man für Methoden, die nur mit Daten des Objektes arbeiten auch weitere Eigenschaften definieren;
// in den get-Methoden kann man dann die zuvor in das Objekt hineingezogenen Methoden aufrufen
// bei diesem Ansatz 2 bietet es sich an, die Parameter der hineingezogenen Methoden beizubehalten, da es die Lesbarkeit verbessert
// Aufgabe: setze für den Umfang Ansatz 1 um und für die anderen beiden Methoden Ansatz 2

float circumference (float a, float b) {
    return 2 * (a + b);
}

float surface (float a, float b) {
    return a * b;
}

bool isSquare (float a, float b) {
    return a == b;
}
void Output(string name, float edgeA, float edgeB, float surface, float circumference, bool isSquare) {
    Console.WriteLine("The two edges of rectangle " + name + " are " + edgeA + " and " + edgeB + ".");
    Console.WriteLine("The surface of rectangle " + name + " is " + surface + ".");
    Console.WriteLine("The circumference of rectangle " + name + " is " + circumference + ".");
    Console.WriteLine("Rectangle " + name + " is " + (!isSquare?"not ":"")+ "a square.");
}
void Output(Rectangle r) {
    Output (r.Name, r.EdgeA, r.EdgeB, surface(r.EdgeA, r.EdgeB), circumference(r.EdgeA, r.EdgeB), isSquare(r.EdgeA, r.EdgeB));
}

class Rectangle {
    string name;
    float edgeA;
    float edgeB;

    public string Name {
        get {return name;}
    }
    public float EdgeA {
        get {return edgeA;}
    }

    public float EdgeB {
        get {return edgeB;}
    }

    public Rectangle (string n, float a, float b) {
        name = n;
        edgeA = a;
        edgeB = b;
    }
}



Rectangle r1 = new Rectangle("R1", 12.5f,12.5f);
Rectangle r2 = new Rectangle("R2", 12.5f, 9.25f);

Output(r1);
Output(r2);