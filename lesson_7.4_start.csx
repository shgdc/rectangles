// der letzte Schrit besteht darin, die Methoden zur Berechnung der Rechteckeigenschaften in die Klasse hineinzuziehen
// da die Methoden dann Zugriff auf die privaten Variablen der Objekte haben, könnte man die Parameter entfernen
// auf diese Weise könnte man die Methoden dann auf dem Objekt aufrufen, ohne das man Argumente angeben müsste
// nennen wir das obige Vorgehen Ansatz 1
// alternativ kann man für Methoden, die nur mit Daten des Objektes arbeiten auch weitere Eigenschaften definieren;
// in den get-Methoden kann man dann die zuvor in das Objekt hineingezogenen Methoden aufrufen
// bei diesem Ansatz 2 bietet es sich an, die Parameter der hineingezogenen Methoden beizubehalten, da es die Lesbarkeit verbessert
// Aufgabe: setze für den Umfang Ansatz 1 um und für die anderen beiden Methoden Ansatz 2

class Rectangle {
    float edgeA;
    float edgeB;

    public float EdgeA {
        get {return edgeA;}
    }

    public float EdgeB {
        get {return edgeB;}
    }

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

Console.WriteLine("The two edges of rectangle R1 are " + r1.EdgeA + " and " + r1.EdgeB + ".");
Console.WriteLine("The surface of rectangle R1 is " + surface(r1.EdgeA, r1.EdgeB) + ".");
Console.WriteLine("The circumference of rectangle R1 is " + circumference(r1.EdgeA, r1.EdgeB) + ".");
Console.WriteLine("Rectangle R1 is " + (!isSquare(r1.EdgeA, r1.EdgeB)?"not ":"")+ "a square.");

Console.WriteLine("The two edges of rectangle r2 are " + r2.EdgeA + " and " + r2.EdgeB + ".");
Console.WriteLine("The surface of rectangle r2 is " + surface(r2.EdgeA, r2.EdgeB) + ".");
Console.WriteLine("The circumference of rectangle r2 is " + circumference(r2.EdgeA, r2.EdgeB) + ".");
Console.WriteLine("Rectangle r2 is " + (!isSquare(r2.EdgeA, r2.EdgeB)?"not ":"")+ "a square.");
