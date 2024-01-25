# 1. Инициализируем изначальный массив StringsArray
string[] StringsArray = { "GeekBrains", "HelloWorld", "abc", "hjiufhwei", "ffe", "12f", "fsd", "ffdfew", "124" };
# 2. Создаем массив NewArray
string[] NewArray
# 3. Инициализируем массив NewArray элементами из массива StringsArray, длина которых меньше или равна 3
NewArray = StringsArray.Where(f => f.Length <= 3).ToArray();

# 4.Вывод элементов массива NewArray на консоль
Console.Write(string.Join(",", NewArray));
