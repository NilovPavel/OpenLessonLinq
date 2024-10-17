//Массив строк
string[] strings = new string[] { "Alice", "Bов", "Carry", "Dilan", "Frank", "George", "Harold" };

//Первый элемент
string first = strings.First(
    //Если убрать комментарий, то выдаст ошибку, так как нет элементов в коллекции
    //удовлетворяющих условию
    //item => item.Length >= 7  
    );
string firstOrDefault =
    strings.FirstOrDefault
    (
        item => item.Length >= 7
    );

//Последний элемент
string last = strings.Last
    (
    //Если убрать комментарий, то выдаст ошибку, так как нет элементов в коллекции
    //удовлетворяющих условию
    //item => item.Length >= 7  
    );

string lastOrDefault =
    strings.LastOrDefault
    (
        item => item.Length >= 7
    );

//Единичный элемент
string single = 
    strings.Single
    (
    //Если убрать комментарий, то отработает успешно, так как только 1 элемент
    //в коллекции удовлетворяющий условию
    item => item.Length == 3  
    );

string singleOrDefault =
    strings.SingleOrDefault
    (
        //item => item.Length ==6
    );