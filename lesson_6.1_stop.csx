// das Ziel dieser Datei ist zu zeigen, wie umständlich, unübersichtlich und fehleranfällig es ist, mit mehreren Objekten auf diese Weise zu arbeiten
// als erste Verbesserung werden wir die Berechnungen von Fläche, Umfang und ob das Rechteck ein Quadrat ist in Methoden auslagern.
// unten ist dies am Beispiel von Umfang geschehen; zur weiteren Vereinfachung wurden die Umfangsvariablen entfernt und bei der Ausgabe direkt die neue Umfangsmethode aufgerufen
// Aufgabe: ändere den Code entsprechend für die anderen beiden berechneten Werte

float circumference (float a, float b) {
    return 2 * (a + b);
}

float surface (float a, float b) {
    return a * b;
}

bool isSquare (float a, float b) {
    return a == b;
}

float r1_edgeA; // Kante des Rechtecks
float r1_edgeB; // Kante des Rechtecks

float r2_edgeA; // Kante des Rechtecks
float r2_edgeB; // Kante des Rechtecks

r1_edgeA = 12.5f;
r1_edgeB = 9.25f;
r1_edgeB = r1_edgeA;

r2_edgeA = 12.5f;
r2_edgeB = 9.25f;

Console.WriteLine("The two edges of rectangle R1 are " + r1_edgeA + " and " + r1_edgeB + ".");
Console.WriteLine("The surface of rectangle R1 is " + surface(r1_edgeA, r1_edgeB) + ".");
Console.WriteLine("The circumference of rectangle R1 is " + circumference(r1_edgeA, r1_edgeB) + ".");
Console.WriteLine("Rectangle R1 is " + (!isSquare(r1_edgeA, r1_edgeB)?"not ":"")+ "a square.");

Console.WriteLine("The two edges of rectangle r2 are " + r2_edgeA + " and " + r2_edgeB + ".");
Console.WriteLine("The surface of rectangle r2 is " + surface(r2_edgeA, r2_edgeB) + ".");
Console.WriteLine("The circumference of rectangle r2 is " + circumference(r2_edgeA, r2_edgeB) + ".");
Console.WriteLine("Rectangle r2 is " + (!isSquare(r2_edgeA, r2_edgeB)?"not ":"")+ "a square.");
