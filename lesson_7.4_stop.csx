// beachtenswert ist, dass bei der Ausgabe z.B. die Oberfläche über die Eigenschaften Surface ermittelt wird, also groß geschrieben und ohne Klammern
// der Umfang hingegen wird über die Methode circumference() abgefragt, also klein geschrieben und mit Klammern
// der entscheidende Punkt ist, dass nun alle Daten und alles Verhalten des Rechtecks in der Klasse definiert sind.
// diese Definition des Rechtecks kann jetzt insb. in eine andere Datei verschoben werden, wodurch das Hauptprogram sehr viel übersichtlicher wird
// außerdem unterstützt der Editor die Verwendung der Klasse, indem nach dem Tippen des Punktes nach einem Objektnamen die vorhanden öffentlichen Variablen, Eigenschaten und Methoden angezeigt werden.

class Rectangle {
    float edgeA;
    float edgeB;

    public float EdgeA {
        get {return edgeA;}
    }

    public float EdgeB {
        get {return edgeB;}
    }

    public float Surface {
        get {return surface(edgeA, edgeB);}
    }

    public bool IsSquare {
        get {return isSquare(edgeA, edgeB);}
    }

    public Rectangle (float a, float b) {
        edgeA = a;
        edgeB = b;
    }

    public float circumference () {
        return 2 * (edgeA + edgeB);
    }

    float surface (float a, float b) {
        return a * b;
    }
    bool isSquare (float a, float b) {
        return a == b;
    }
}

Rectangle r1 = new Rectangle(12.5f,12.5f);
Rectangle r2 = new Rectangle(12.5f, 9.25f);

Console.WriteLine("The two edges of rectangle R1 are " + r1.EdgeA + " and " + r1.EdgeB + ".");
Console.WriteLine("The surface of rectangle R1 is " + r1.Surface + ".");
Console.WriteLine("The circumference of rectangle R1 is " + r1.circumference() + ".");
Console.WriteLine("Rectangle R1 is " + (!r1.IsSquare?"not ":"")+ "a square.");

Console.WriteLine("The two edges of rectangle r2 are " + r2.EdgeA + " and " + r2.EdgeB + ".");
Console.WriteLine("The surface of rectangle r2 is " + r2.Surface + ".");
Console.WriteLine("The circumference of rectangle r2 is " + r2.circumference() + ".");
Console.WriteLine("Rectangle r2 is " + (!r2.IsSquare?"not ":"")+ "a square.");
