//Набор данных
int[] numbers = { 1, 2, 3, 4, 5 };

// Запрос создается, но не выполняется
var query = from n in numbers
            where n > Get1()
            select n;
;

// Запрос выполнится только здесь, когда мы начнем итерировать результаты
foreach (var number in query)
{
    Console.WriteLine(number);
}

//Запрос с немедленным выполнением
numbers.Where(item => item > Get1()).Count();

;

int Get1()
{
    return 2;
}