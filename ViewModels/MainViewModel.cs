using DisordersOfCarbohydrateMetabolismsCalculator.Models;
using System.Globalization;

namespace DisordersOfCarbohydrateMetabolismsCalculator.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        // Гликемия натощак
        private string _fastingGlycemia;
        public string FastingGlycemia
        {
            get => _fastingGlycemia;
            set
            {
                if (string.IsNullOrEmpty(value))
                    FastingGlycemia = "0";

                if (!double.TryParse(value.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out var factor))
                    return;

                CalculatorModel.FastingGlycemia = factor;
                UpdateCalculatedCharacteristic();

                SetProperty(ref _fastingGlycemia, value);
            }
        }

        // Уровень гликированного гемоглобина
        private string _glycatedHemoglobinLevel;
        public string GlycatedHemoglobinLevel
        {
            get => _glycatedHemoglobinLevel;
            set
            {
                if (string.IsNullOrEmpty(value))
                    GlycatedHemoglobinLevel = "0";

                if (!double.TryParse(value.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out var factor))
                    return;

                CalculatorModel.GlycatedHemoglobinLevel = factor;
                UpdateCalculatedCharacteristic();

                SetProperty(ref _glycatedHemoglobinLevel, value); ;
            }
        }

        // Индекс массы тела
        private string _bodyMassIndex;
        public string BodyMassIndex
        {
            get => _bodyMassIndex;
            set
            {
                if (string.IsNullOrEmpty(value))
                    BodyMassIndex = "0";

                if (!double.TryParse(value.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out var factor))
                    return;

                CalculatorModel.BodyMassIndex = factor;
                UpdateCalculatedCharacteristic();

                SetProperty(ref _bodyMassIndex, value);
            }
        }

        // Шкала экстернального пищевого поведения
        private string _externalEatingBehaviorScale;
        public string ExternalEatingBehaviorScale
        {
            get => _externalEatingBehaviorScale;
            set
            {
                if (string.IsNullOrEmpty(value))
                    ExternalEatingBehaviorScale = "0";

                if (!double.TryParse(value.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out var factor))
                    return;

                CalculatorModel.ExternalEatingBehaviorScale = factor;
                UpdateCalculatedCharacteristic();

                SetProperty(ref _externalEatingBehaviorScale, value);
            }
        }

        // Уровень общего холестерина
        private string _totalCholesterolLevel;
        public string TotalCholesterolLevel
        {
            get => _totalCholesterolLevel;
            set
            {
                if (string.IsNullOrEmpty(value))
                    TotalCholesterolLevel = "0";

                if (!double.TryParse(value.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out var factor))
                    return;

                CalculatorModel.TotalCholesterolLevel = factor;
                UpdateCalculatedCharacteristic();

                SetProperty(ref _totalCholesterolLevel, value);
            }
        }

        // Уровень триглицеридов
        private string _triglycerideLevel;
        public string TriglycerideLevel
        {
            get => _triglycerideLevel;
            set
            {
                if (string.IsNullOrEmpty(value))
                    TriglycerideLevel = "0";

                if (!double.TryParse(value.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out var factor))
                    return;

                CalculatorModel.TriglycerideLevel = factor;
                UpdateCalculatedCharacteristic();

                SetProperty(ref _triglycerideLevel, value);
            }
        }

        // Вероятность развития ранних нарушений углеводного обмена
        private string _likelihoodOfDevelopingEarlyDisordersOfCarbohydrateMetabolism;
        public string LikelihoodOfDevelopingEarlyDisordersOfCarbohydrateMetabolism
        {
            get => _likelihoodOfDevelopingEarlyDisordersOfCarbohydrateMetabolism;
            set => SetProperty(ref _likelihoodOfDevelopingEarlyDisordersOfCarbohydrateMetabolism, value);
        }

        // Сообщение о результате
        private string _resultMessage;
        public string ResultMessage
        {
            get => _resultMessage;
            set => SetProperty(ref _resultMessage, value);
        }

        private void UpdateCalculatedCharacteristic()
        {
            LikelihoodOfDevelopingEarlyDisordersOfCarbohydrateMetabolism =
                $"Рассчётная характеристика: {CalculatorModel.LikelihoodOfDevelopingEarlyDisordersOfCarbohydrateMetabolism}";
            ResultMessage = $"Результат: {CalculatorModel.ResultMessage}";
        }

        public MainViewModel()
        {
            FastingGlycemia = "4.6";
            GlycatedHemoglobinLevel = "4.8";
            BodyMassIndex = "21.4";
            ExternalEatingBehaviorScale = "12";
            TotalCholesterolLevel = "3.9";
            TriglycerideLevel = "1.2";
        }
    }
}
