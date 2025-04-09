// Klasse => Eigener Datentyp
public class TodoItem
{
    // Klassen definieren Variablen (Daten) und Methoden (Funktionalität)
    // Variablen können Felder (Fields) oder Eigenschaften (Properties) sein
    // Felder sind privat -> Klassenintern
    // Eigenschaft ist public -> Kann von außen aufgerufen werden
    public string Description { get; set; }
    public int Prio { get; set; }

    //Instanz-Methode => myToDo.ToString();

    public override string ToString()
    {
        return $"{Description} - {Prio}";
    }
}