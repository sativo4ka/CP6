# CP6

Вариант 1. Парсер списка чисел

Метод int SumValidNumbers(List<string> values) суммирует корректные числа из списка строк.

Для каждого значения пытайтесь выполнить int.Parse.catch (FormatException ex) when (string.IsNullOrWhiteSpace(value)) — пустые строки пропускайте без логирования (это ожидаемый, частый случай).catch (FormatException ex) (без when) — для остальных ошибок формата выводите предупреждение и продолжайте обработку следующих значений.catch (OverflowException ex) — это считается критической, неожидаемой ситуацией для метода: выведите сообщение и выполните throw;, чтобы передать её вызывающему коду, не теряя стек вызовов.Используйте finally (на каждой итерации или один раз для всего метода — на ваш выбор) для логирования количества обработанных элементов.

<img width="2255" height="796" alt="image" src="https://github.com/user-attachments/assets/27bf4428-54be-405f-99d6-3572465ab56a" />

<img width="1508" height="1260" alt="image" src="https://github.com/user-attachments/assets/4b3bc332-87c9-492e-b68c-47f916bcad0c" />
