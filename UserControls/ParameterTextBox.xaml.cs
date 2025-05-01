using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DisordersOfCarbohydrateMetabolismsCalculator.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ParameterTextBox.xaml
    /// </summary>
    public partial class ParameterTextBox : UserControl
    {
        public string ParameterName
        {
            get { return (string)GetValue(ParameterNameProperty); }
            set { SetValue(ParameterNameProperty, value); }
        }

        public static readonly DependencyProperty ParameterNameProperty =
            DependencyProperty.Register("ParameterName", typeof(string), typeof(ParameterTextBox), new PropertyMetadata(string.Empty));

        public string ParameterUnit
        {
            get { return (string)GetValue(ParameterUnitProperty); }
            set { SetValue(ParameterUnitProperty, value); }
        }

        public static readonly DependencyProperty ParameterUnitProperty =
            DependencyProperty.Register("ParameterUnit", typeof(string), typeof(ParameterTextBox), new PropertyMetadata(string.Empty));

        public string Parameter
        {
            get { return (string)GetValue(ParameterProperty); }
            set { SetValue(ParameterProperty, value); }
        }

        public static readonly DependencyProperty ParameterProperty =
            DependencyProperty.Register("Parameter", typeof(string), typeof(ParameterTextBox),
                new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(ParameterTextBox), new PropertyMetadata(null));

        public ParameterTextBox()
        {
            InitializeComponent();
        }
    }
}
