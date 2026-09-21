Console.WriteLine("Банковский счёт");

double balance = 1000;
Console.WriteLine($"Начальный баланс: {balance}");

balance += 500;
Console.WriteLine($"После пополнения на 500: {balance}");

balance -= 200;
Console.WriteLine($"После покупки на 200: {balance}");

balance *= 1.05;
Console.WriteLine($"После начисления на 5%: {balance}");

balance /= 2;
Console.WriteLine($"После деления пополам: {balance}");



Console.WriteLine();
Console.WriteLine("Постфикс vs префикс");

int lessonNumber = 1;
Console.WriteLine($"lessonNumber++ выводит: {lessonNumber++}");
Console.WriteLine($"После этого lessonNumber = {lessonNumber}");

int weekNumber = 1;
Console.WriteLine($"++weekNumber выводит: {++weekNumber}");
Console.WriteLine($"После этого weekNumber = {weekNumber}");

Console.WriteLine();
Console.WriteLine("Практическая ловушка");

int attempts = 0;
Console.WriteLine($"Попытка №{++attempts}");
Console.WriteLine($"Попытка №{++attempts}");
Console.WriteLine($"Всего попыток: {attempts}");



Console.WriteLine();
Console.WriteLine("Операторы сравнения");

double myGrade = 4.6;
double passingGrade = 4.0;
int myAge = 20;
int votingAge = 18;
bool isPassing = myGrade >= passingGrade;
bool isExactAge = myAge == votingAge;
bool canVote = myAge >= votingAge;
bool isNotFailing = myGrade != 2.0;
Console.WriteLine($"Балл {myGrade} >= {passingGrade}: {isPassing}");
Console.WriteLine($"Возраст {myAge} == {votingAge}: {isExactAge}");
Console.WriteLine($"Возраст {myAge} >= {votingAge} (может голосовать): {canVote}");
Console.WriteLine($"Балл {myGrade} != 2.0 (не двойка): {isNotFailing}");



Console.WriteLine();
Console.WriteLine("Логические операторы");

bool hasPassingGrade = true;
bool hasAttendance = false;
bool hasDebt = true;

bool canGetScholarship = hasPassingGrade && hasAttendance;
bool canRetakeExam = hasPassingGrade || hasAttendance;
bool isDebtFree = !hasDebt;
Console.WriteLine($"Может получить стипендию (оценка И посещаемость): {canGetScholarship}");
Console.WriteLine($"Может пересдать (оценка ИЛИ посещаемость): {canRetakeExam}");
Console.WriteLine($"Нет долгов: {isDebtFree}");



Console.WriteLine();
Console.WriteLine("Короткое замыкание");

bool CheckAndPrint(string label, bool value) { Console.WriteLine($"Вычисляется: {label}"); return value;}

Console.WriteLine("Проверяем && (первый операнд false):");
bool resultAnd = CheckAndPrint("A", false) && CheckAndPrint("B", true);
Console.WriteLine($"Результат: {resultAnd}");

Console.WriteLine();
Console.WriteLine("Проверяем || (первый операнд true):");
bool resultOr = CheckAndPrint("C", true) || CheckAndPrint("D", false);
Console.WriteLine($"Результат: {resultOr}");


Console.WriteLine();
Console.WriteLine("Приоритет операций");

int resultNoParens = 2 + 3 * 4;
int resultWithParens = (2 + 3) * 4;
Console.WriteLine($"2 + 3 * 4 = {resultNoParens}");
Console.WriteLine($"(2 + 3) * 4 = {resultWithParens}");
bool logicResult = 5 > 3 && 2 < 4 || false;
bool logicResultParens = (5 > 3 && 2 < 4) || false;
Console.WriteLine($"5 > 3 && 2 < 4 || false = {logicResult}");
Console.WriteLine($"(5 > 3 && 2 < 4) || false = {logicResultParens}");



Console.WriteLine();
Console.WriteLine("Приёмная комиссия");

Console.Write("Введите средний балл аттестата: ");
double averageGrade = double.Parse(Console.ReadLine());

Console.Write("Введите баллы за экзамен (0-100): ");
int examScore = int.Parse(Console.ReadLine());

Console.Write("Есть льгота? (1 - да, 0 - нет): ");
int benefitInput = int.Parse(Console.ReadLine());
bool hasBenefit = (benefitInput == 1);
bool hasGoodCertificate = averageGrade >= 4.0;
bool hasGoodExam = examScore >= 60;
bool isEligibleByRules = (hasGoodCertificate && hasGoodExam) || hasBenefit;
double totalScore = averageGrade * 10; 
totalScore += examScore;

Console.WriteLine();
Console.WriteLine("Результат");
Console.WriteLine($"Хороший аттестат (>= 4.0): {hasGoodCertificate}");
Console.WriteLine($"Хороший экзамен (>= 60): {hasGoodExam}");
Console.WriteLine($"Льгота: {hasBenefit}");
Console.WriteLine($"Проходит по правилам: {isEligibleByRules}");
Console.WriteLine($"Итоговый балл: {totalScore}");

Console.WriteLine("Чётное или нечётное—без if");
Console.WriteLine("Введите целое число");
string text1 = Console.ReadLine();
int number1 = int.Parse(text1);
bool isEven = number1 % 2 == 0;
Console.WriteLine($"Число чётное: {isEven}");

Console.WriteLine("Инкремент в выражении");
// 1. Постфиксная форма x++
int x1 = 3;
Console.WriteLine($"x1++ = {x1++}");
Console.WriteLine($"После этого x1 = {x1}");
// x1++ сначала возвращает старое значение (3) для вывода, а затем увеличивает от x1 до 4

int x2 = 3;
int result = ++x2 * 10;
Console.WriteLine($"++x2 * 10 = {result}");
// ++x2 сначала увеличивает x2 с 3 до 4, и только потом умножает на 10 

int x3 = 3;
int res = x3++ * 10;
Console.WriteLine($"x3++ * 10 = {res}");
// x3++ использует старое значение (3) для умножения, а сам x3 становится 4 уже после этого

Console.WriteLine("Калькулятор скидки с несколькими условиями");
Console.Write("Введите сумму покупки: ");
int sum = int.Parse(Console.ReadLine());
Console.Write("Есть ли карта постоянного покупателя? (1 - да, 0 -нет): ");
int card1 = int.Parse(Console.ReadLine());
bool card2 = (card1 == 1);
Console.Write("Введите количество товаров в чеке: ");
int item = int.Parse(Console.ReadLine());
bool isSum = sum >= 3000;
bool isItem = item >= 3;
bool eligibleForDiscount = (isSum && isItem) || card2;

Console.WriteLine($"Сумма >= 3000: {isSum}");
Console.WriteLine($"Товаров в чеке >= 3: {isItem}");
Console.WriteLine($"Есть ли карта постоянного покупателя: {card2}");
Console.WriteLine($"Положена ли скидка: {eligibleForDiscount}");