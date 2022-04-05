using System;
using Xamarin.Forms;

namespace Day8.Behaviors
{
    public class MyInputBehavior : Behavior<Entry>
    {
        public Color ErrorColor { get; set; }
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += OnTextChanged;
        }
        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= OnTextChanged;
        }
        private void OnTextChanged(object sender, EventArgs args)
        {
            var obj = (Entry)sender;
            obj.BackgroundColor = obj.Text == "root" ? ErrorColor : Color.White;
        }
    }
}
