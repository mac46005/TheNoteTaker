using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace TheNoteTaker_WPF_UI.Core.Input
{
    public class KeyTrigger //: TriggerBase<UIElement>
    {
        //public static readonly DependencyProperty KeyProperty =
        //    DependencyProperty.Register("Key", typeof(Key),typeof(KeyTrigger),null);

        //public static readonly DependencyProperty ModifiersProperty =
        //    DependencyProperty.Register("Modifiers", typeof(ModifierKeys), typeof(KeyTrigger), null);


        //public Key Key
        //{
        //    get { return (Key)GetValue(KeyProperty); }
        //    set { SetValue(KeyProperty, value); }
        //}



        //public ModifierKeys Modifier
        //{
        //    get { return (ModifierKeys)GetValue(ModifiersProperty); }
        //    set { SetValue(KeyProperty, value); }
        //}

        //protected override void OnAttached()
        //{
        //    base.OnAttached();
        //}


        //protected override void OnDetaching()
        //{
        //    base.OnDetaching();

        //    AssociatedObject.KeyDown -= OnAssociatedObjectKeyDown;
        //}
        //private void OnAssociatedObjectKeyDown(object sender, KeyEventArgs e)
        //{
        //    var key = (e.Key == Key.System) ? e.SystemKey : e.Key;
        //    if ((key == Key && Keyboard.Modifiers == GetActualModifies(e.Key, Modifiers)))
        //    {
        //        InvokeActions(e);
        //    }
        //}

        //static ModifierKeys GetActualModifies(Key key,ModifierKeys modifiers)
        //{
        //    switch (key)
        //    {
        //        case Key.LeftCtrl:
        //        case Key.RightCtrl:
        //            modifiers |= ModifierKeys.Control;
        //            return modifiers;


        //        case Key.LeftAlt:
        //        case Key.RightAlt:
        //            modifiers |= ModifierKeys.Alt;
        //            return modifiers;

        //        case Key.LeftShift:
        //        case Key.RightShift:
        //            modifiers |= ModifierKeys.Shift;
        //            break;
        //    }

        //    return modifiers;
        //}


    }
}
