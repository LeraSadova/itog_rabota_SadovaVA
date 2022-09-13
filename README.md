**Итоговая проверочная работа**

*Работу выполнила студентка __Валерия Садова__*

>Условия проверочной работы находятся в файле "uslovie_raboty.md"

* Ссылка на репозиторий: https://github.com/LeraSadova/itog_rabota_SadovaVA.git
* Блок-схема алгоритма находится в папке "Блок_схема"

*Код программы содержит подробные комментарии по каждому действию*

**Теперь я расскажу как решала задачу (есть 2 варианта решения):**
>>Вариант 1
* Решала задачу через 2 массива.
* Первый массив - мы вводим с клавиатуры, предварительно решив, сколько элементов будет в нем содержаться.
* Выводим на экран полученный массив.
* Дальше объявляем метод, который будет в этом массиве искать элементы, кол-во символов в которых <=3.
*Эти элементы будут заполнять второй массив, который мы объявляем как массив длины первого массива.*
* Для второго массива используем переменную index, которая будет увеличиваться на 1 каждый раз, когда в первом массиве найдется элемент, удовлетворяющий условию (изначально index=0).
*Когда прошлись по всем элементам первого массива, объявляем метод для печати массива (вывода на экран). 
* Обращаемся к обоим методам. 

>>Вариант 2
* Пользователь решает, сколько элементов будет в массиве
* Вводит их с клавиатуры
* А дальше в методе печати нужных нам элементов ищем соответствующие элементы
* Выводим их на экран