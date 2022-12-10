string s1 = "Hello, World!"; Console.WriteLine(s1) //задание и вывод строки
var s2 = "Create by var"; Console.WriteLine(s2); // задание строки через общий типа переменных
string s3 = "Hello, "; string s4 = s3 + "John!"; //задание строки, объединение строк
Console.WriteLine(s4); //вывод строки
string s5 = "test1"; //задание строки
var s6 = "test2"; //задание строки
Console.WriteLine("first line\nSecond line"); //вывод строк
Console.WriteLine(@"first line\nSecond line"); //вывод строк
int age = 27; //задание целочисленной переменной
Console.WriteLine(String.Format("Age: {0}", age));  //обычный вывод 
Console.WriteLine("");//вывод
Console.WriteLine($"Age: {age}"); вывод с префиксом
Console.WriteLine(""); //вывод
string s7 = new string("test3"); //задание строки
char[] charArray = { 'H', 'e', 'l', 'l', 'o' }; string s8 = new string(charArray); //задание строки через массив
string s9 = new string('O', 10); // "OOOOOOOOOO"
string s10 = "Area"; string s11 = " 51"; //задание строк
Console.WriteLine("Concat by +: " + s10 + s11); //объединение строк
Console.WriteLine("Concat by Concat(): " + string.Concat(s10, s11)); //объединение строк
string[] sArr1 = { "First ", "Second ", "Third " }; Console.WriteLine(string.Concat(sArr1)); //объединение строк из массива
string[] sArr2 = { "First", "Second", "Third" };  //стрококвый массив
Console.WriteLine("Join elements in array by Join() with space: " + string.Join(" ", sArr2)); //объединение с разделителем
Console.WriteLine("Join elements in array by Join() with <->: " + string.Join("<->", sArr2));//объединение с разделителем
string s12 = "Hello"; //задание строки
Console.WriteLine("Get element by index s12[3]: " + s12[3]); //вывод определенного символа из строки
s1 = "Hello, World!"
// Поиск первого вхождения символа 'r' 
Console.WriteLine("Index of \'r\': " + s1.IndexOf('r'));
// Поиск первого вхождения символа 'l' начиная с позиции 4 
Console.WriteLine("Index of \'l\', start at 4: " + s1.IndexOf('l', 4));
// Поиск первого вхождения строки "World" 
Console.WriteLine("Index of \"World\": " + s1.IndexOf("World"));
// Поиск первого вхождения символа из набора ['o', 'd', ','] 
Console.WriteLine("Index of pos of any symbol in array: " + s1.IndexOfAny(new char[] { 'o', 'd', ',' }));
// Поиск последнего вхождения символа 'l'  
Console.WriteLine("Last index of \'l\': " + s1.LastIndexOf('l'));
// Поиск последнего вхождения строки "or"
Console.WriteLine("Last index of \"or\": " + s1.LastIndexOf("or"));
// Поиск последнего вхождения символа из набора ['o', 'd', ',']
Console.WriteLine("Last index of pos of any symbol in array: " + s1.LastIndexOfAny(new char[] { 'o', 'd', ',' })); //последние индексы
Console.WriteLine("Contains \"World\"? " + s1.Contains("World")); // True Console.WriteLine("Starts with \"He\"? " + s1.StartsWith("He")); // True // первые индексы
Console.WriteLine("Ends with \"ld\"? " + s1.EndsWith("ld")); // False //последние индексы
Console.WriteLine("Substring start at pos 7: " + s1.Substring(7)); // World! Console.WriteLine("Substring start at pos 7 (4 chars): " + s1.Substring(7, 4)); // Worl //извлечение подстроки
string t1 = "John"; string t2 = "John"; string t3 = "Mary"; //задание строк
Console.WriteLine("t1 == t2: " + (t1 == t2)); // True //Сравнение строк
Console.WriteLine("t1 != t2: " + (t1 != t2)); // False //Сравнение строк
Console.WriteLine("t1 == t3: " + (t1 == t3)); // False //Сравнение строк

Console.WriteLine("Equals method: t1.Equals(t2)" + t1.Equals(t2)); // True Console.WriteLine("Equals method: t1.Equals(t3)" + t1.Equals(t3)); // False //Сравнение строк
Console.WriteLine("Insert: " + "26".Insert(1, "[4]")); // 2[4]6 //вставка строки в исходную в заданную позицию
Console.WriteLine("PadLeft: "); //выравнивание по левому краю
Console.WriteLine("some string".PadLeft(15)); // " some string"//выравнивание по левому краю
Console.WriteLine("some string".PadLeft(15, '*')); // "****some string" //выравнивание по левому краю
Console.WriteLine("PadRight: "); //выравнивание по правому краю
Console.WriteLine("some string".PadRight(15)); // "some string " Console.WriteLine("some string".PadRight(15, '*')); // "some string****" //выравнивание по правому краю
Console.WriteLine("Remove demo1: " + "Hello".Remove(2)); //удаление символов с указанной позиции
Console.WriteLine("Remove demo2: " + "Hello".Remove(2, 2));//удаление символов с указанной позиции
Console.WriteLine("Hello, World!".Replace('!', '.')); // Hello, World. //замена элементов строки
Console.WriteLine("Hello, World!".Replace("World", "John")); // Hello, John! //замена элементов строки
Console.WriteLine("Hello, World!".ToUpper()); // HELLO, WORLD! // преобразование строки к верхнему регистру
Console.WriteLine("Hello, World!".ToLower()); // hello, world!  // преобразование строки к нижнему регистру
Console.WriteLine(" hello ".Trim()); // "hello"  //удаление символов
Console.WriteLine("***hello---".Trim('*')); // "hello---"  //удаление символов
Console.WriteLine("***hello---".Trim(new char[] { '*', '-' })); // "hello"  //удаление символов
Console.WriteLine(" hello ".TrimStart()); // "hello "   //удаление символов
Console.WriteLine(" hello ".TrimEnd()); // " hello"  //удаление символов
Console.WriteLine("Hello".Length); // 5 //найти длину строки
foreach (var s in "1 2 3".Split(' '))  //разделить строку на подстроки 
    Console.WriteLine(s); //вывод
foreach (var s in "1 2 3-4-5-6".Split(new char[] { ' ', '-' }))  //разделить строку на подстроки 
    Console.WriteLine(s); //вывод