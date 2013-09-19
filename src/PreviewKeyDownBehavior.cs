using System.Windows.Input;

namespace aheil.Windows.Behaviors
{
    public class PreviewKeyDownBehavior : KeyEventHandlerBehavior
    {
        protected override void OnAttached()
        {
            base.OnAttached();

            if (AssociatedObject != null)
            {
                AssociatedObject.PreviewKeyDown += AttachedPreviewKeyDown;
            }
        }

        protected override void OnDetaching()
        {
            if (AssociatedObject != null)
            {
                AssociatedObject.PreviewKeyDown -= AttachedPreviewKeyDown;
            }

            base.OnDetaching();
        }

        private void AttachedPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != this.Key)
                return;

            if (base.Command == null)
                return;

            if (this.Command.CanExecute(this.CommandParamters))
            {
                this.Command.Execute(this.CommandParamters);
                e.Handled = true;
            }
        }
    }
}
