using System.Windows;
using System.Windows.Input;

namespace aheil.Windows.Behaviors
{
    public class KeyEventHandlerBehavior : EventHandlerBehavior
    {
        public Key Key
        {
            get { return (Key)GetValue(KeyProperty); }
            set { SetValue(KeyProperty, value); }
        }

        public static readonly DependencyProperty KeyProperty =
            DependencyProperty.Register("Key", typeof(Key), typeof(KeyEventHandlerBehavior), new PropertyMetadata(Key.Return));
    }
}