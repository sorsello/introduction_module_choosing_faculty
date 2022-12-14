# Итоговая проверочная работа
## Задача:

Написать программу, 


которая из имеющегося массива строк формирует массив из строк, 


длина которых меньше либо равна 3 символа.

<br>

Первоначальный массив можно ввести с клавиатуры, 

либо задать на старте выполнения алгоритма.

При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

---
 # Решение

_Рассматривается отдельный метод, который будет отвечать за опредение элементов массива, которые подходят по условию длины в меньше либо равно 3_ 

    Важным условием в задаче является использование массивов, а не коллекций.

    В C# массивы имеют фиксированный размер при инициализации.

    Решение которое приходит на ум - использовать Array.Resize

1. Необходимо создать метод, который будет принимать массив строк, созданный пользователем (М1) и возвращать результат в виде массива строк (М2).

1. В начале нужно задать переменную для размера массива М2 (РМ2) равную 0 и переменную для результата в виде массива строк М2 с размером РМ2. С помощью этих переменных мы будем добавлять подходящие элементы в массив М2 для результата.

1. Для решения задачи нужно перебрать все элементы массива М1 - используем цикл for.

1. Внутри цикла for, для каждой итерации проверить является ли длина текущего элемента массива (номер итерации цикла как индекс массиве М1) меньше либо равной трем - используем условный оператор if.

1. Если длина текущего элемента массива больше 3 -> перейти к следующий итерации и как следствие к следующему элементу массива М1 и выполнить шаг 4.

1. Если условие выполняется и длина текущего элемента массива меньше либо равна 3 ->

1. Увеличить РМ2 на 1, так как подходящий элемент к добавлению найден

1. Нужно сдедать resize для массива М2 (если не делать resize, то массив М2 так и будет с размером 0, несмотря на то, что РМ увеличели на 1)

1. Наш массив М2 имеет размер 1, но в нем нет никакого элемента в индексе 0. Нужно добавить текущий элемент массива М1, который подощел по условию, в массив М2.

1. Нюанс в том, что при увеличении РМ2 на 1, когда выполняется условие, в массив М2 нам необходимо присваивать текущий элемент массива М1 по индексу равному РМ2 - 1. В C# индексы считаются от 0. Если этого не сделать, то алгоритм будет присваивать значения массиву М2 по индексу РМ2, который выходит за рамки текущего размера массива М2.

1. Когда алгоритм перебрал все элементы массива М1, вернуть значение массива М2.

---

## Блоксхема решения

![Solution flowchart is displayed here](./final_task_flowchart.png "Solution flowchart")