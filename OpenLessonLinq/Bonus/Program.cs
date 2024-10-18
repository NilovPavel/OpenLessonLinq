//Как в LINQ найти индекс элемента с помощью лямбда-выражений?
int i = 0;
string[] strings = new string[] { "A", "B", "C", "D", "E" };
int index = strings
    .Select(item => new { Symbol = item, Index = i++ } )
    .Where( item => item.Symbol == "B" )
    .First()
    .Index;
;