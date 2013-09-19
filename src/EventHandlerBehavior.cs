using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace aheil.Windows.Behaviors
{
    public class EventHandlerBehavior : Behavior<UIElement>
    {
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(ICommand), typeof(EventHandlerBehavior));

        public object CommandParamters
        {
            get { return (object)GetValue(ParamtersProperty); }
            set { SetValue(ParamtersProperty, value); }
        }

        public static readonly DependencyProperty ParamtersProperty =
            DependencyProperty.Register("CommandParamters", typeof(object), typeof(EventHandlerBehavior), new PropertyMetadata(null));
    }
}