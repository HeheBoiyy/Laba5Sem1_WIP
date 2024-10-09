namespace Laba5Sem1_WIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FitnessProgram fitnessProgram = null;
            string userChoice;

            do
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Задать имя и план тренировок");
                Console.WriteLine("2. Установить целевую норму калорий");
                Console.WriteLine("3. Вывести информацию о программе");
                Console.WriteLine("4. Добавить тренировку");
                Console.WriteLine("5. Изменить план тренировок");
                Console.WriteLine("6. Показать уровень физической подготовки");
                Console.WriteLine("7. Мотивирующее сообщение");
                Console.WriteLine("8. Выход");
                Console.Write("Выберите пункт меню: ");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        if (fitnessProgram == null)
                        {
                            Console.Write("Введите ваше имя: ");
                            string name = Console.ReadLine();
                            Console.Write("Введите ваш план тренировок: ");
                            string plan = Console.ReadLine();
                            fitnessProgram = new FitnessProgram { Name = name };
                            fitnessProgram.ChangeExercisePlan(plan);
                            Console.WriteLine($"Программа создана для {fitnessProgram.Name} с планом {fitnessProgram.ExercisePlan}.");
                        }
                        else
                        {
                            Console.WriteLine("Имя и план тренировок уже заданы и не могут быть изменены.");
                        }
                        break;

                    case "2":
                        if (fitnessProgram != null)
                        {
                            Console.Write("Введите целевую норму калорий: ");
                            int targetCalories = int.Parse(Console.ReadLine());
                            fitnessProgram.SetDailyTargetCalories(targetCalories);
                            Console.WriteLine($"Целевая норма калорий установлена на {targetCalories}.");
                        }
                        else
                        {
                            Console.WriteLine("Сначала задайте имя и план тренировок.");
                        }
                        break;

                    case "3":
                        if (fitnessProgram != null)
                        {
                            Console.WriteLine($"Имя: {fitnessProgram.Name}");
                            Console.WriteLine($"План тренировок: {fitnessProgram.ExercisePlan}");
                            Console.WriteLine($"Сожженные калории: {fitnessProgram.CaloriesBurned}");
                            Console.WriteLine($"Количество тренировок: {fitnessProgram.TotalExercises}");
                            Console.WriteLine($"Уровень физической подготовки: {fitnessProgram.FitnessLevel}");
                            if (fitnessProgram.Warning)
                                Console.WriteLine("Внимание: Целевая норма калорий не достигнута.");
                        }
                        else
                        {
                            Console.WriteLine("Сначала задайте имя и план тренировок.");
                        }
                        break;

                    case "4":
                        if (fitnessProgram != null)
                        {
                            Console.Write("Введите количество сожженных калорий за тренировку: ");
                            int calories = int.Parse(Console.ReadLine());
                            fitnessProgram.CompleteExercise(calories);
                            Console.WriteLine($"Добавлено {calories} калорий. Всего сожжено: {fitnessProgram.CaloriesBurned}");
                        }
                        else
                        {
                            Console.WriteLine("Сначала задайте имя и план тренировок.");
                        }
                        break;

                    case "5":
                        if (fitnessProgram != null)
                        {
                            Console.Write("Введите новый план тренировок: ");
                            string newPlan = Console.ReadLine();
                            fitnessProgram.ChangeExercisePlan(newPlan);
                            Console.WriteLine($"План тренировок изменен на: {newPlan}");
                        }
                        else
                        {
                            Console.WriteLine("Сначала задайте имя и план тренировок.");
                        }
                        break;

                    case "6":
                        if (fitnessProgram != null)
                        {
                            Console.WriteLine($"Ваш уровень физической подготовки: {fitnessProgram.FitnessLevel}");
                            Console.WriteLine($"До цели осталось сжечь {fitnessProgram.DailyTargetCalories - fitnessProgram.CaloriesBurned} калорий.");
                        }
                        else
                        {
                            Console.WriteLine("Сначала задайте имя и план тренировок.");
                        }
                        break;

                    case "7":
                        if (fitnessProgram != null)
                        {
                            Console.WriteLine(fitnessProgram.Motivate());
                        }
                        else
                        {
                            Console.WriteLine("Сначала задайте имя и план тренировок.");
                        }
                        break;

                    case "8":
                        Console.WriteLine("Выход из программы.");
                        break;

                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }

            } while (userChoice != "8");
        }
    }    
}
