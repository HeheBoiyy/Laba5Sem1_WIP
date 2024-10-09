using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5Sem1_WIP
{
    class FitnessProgram
    {
        public string Name { get; init; }
        public string ExercisePlan { get; private set; }
        public int CaloriesBurned { get; private set; }
        public int TotalExercises { get; private set; }
        public int DailyTargetCalories { get; private set; }

        public string FitnessLevel => CaloriesBurned switch
        {
            > 2000 => "Спортсмен",
            > 1000 => "Активный",
            _ => "Новичок"
        };

        public bool Warning => CaloriesBurned < DailyTargetCalories;

        public void CompleteExercise(int calories)
        {
            CaloriesBurned += calories;
            TotalExercises++;
        }

        public void ChangeExercisePlan(string newPlan)
        {
            ExercisePlan = newPlan;
        }

        public void SetDailyTargetCalories(int target)
        {
            DailyTargetCalories = target;
        }

        public string Motivate()
        {
            string[] messages = {
            "Ты можешь достичь своей цели!",
            "Продолжай в том же духе!",
            "Ты силен! Не сдавайся!"
        };
            Random rand = new Random();
            return messages[rand.Next(messages.Length)];
        }
    }
}