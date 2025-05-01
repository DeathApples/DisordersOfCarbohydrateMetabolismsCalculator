namespace DisordersOfCarbohydrateMetabolismsCalculator.Models
{
    public static class CalculatorModel
    {
        // Сообщение о результате
        public static string ResultMessage =>
            LikelihoodOfDevelopingEarlyDisordersOfCarbohydrateMetabolism > 1.164
            ? "Высокий риск ранних углеводных нарушений"
            : "Низкий риск развития ранних углеводных нарушений";

        // Вероятность развития ранних нарушений углеводного обмена
        public static double LikelihoodOfDevelopingEarlyDisordersOfCarbohydrateMetabolism =>
            -22.901
            + 1.524 * FastingGlycemia
            + 1.193 * GlycatedHemoglobinLevel
            + 0.148 * BodyMassIndex
            + 0.277 * ExternalEatingBehaviorScale
            + 0.242 * TotalCholesterolLevel
            + 0.212 * TriglycerideLevel;

        // Гликемия натощак
        public static double FastingGlycemia { get; set; }

        // Уровень гликированного гемоглобина
        public static double GlycatedHemoglobinLevel { get; set; }

        // Индекс массы тела
        public static double BodyMassIndex { get; set; }

        // Шкала экстернального пищевого поведения
        public static double ExternalEatingBehaviorScale { get; set; }

        // Уровень общего холестерина
        public static double TotalCholesterolLevel { get; set; }

        // Уровень триглицеридов
        public static double TriglycerideLevel { get; set; }
    }
}
