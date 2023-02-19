// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.Maui.Elements
{
    public partial class SwipeItems : Element
    {
        static SwipeItems()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public SwipeMode? Mode { get; set; }
        [Parameter] public SwipeBehaviorOnInvoked? SwipeBehaviorOnInvoked { get; set; }

        public new MC.SwipeItems NativeControl => (MC.SwipeItems)((BindableObject)this).NativeControl;

        protected override MC.SwipeItems CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Mode):
                    if (!Equals(Mode, value))
                    {
                        Mode = (SwipeMode?)value;
                        NativeControl.Mode = Mode ?? (SwipeMode)MC.SwipeItems.ModeProperty.DefaultValue;
                    }
                    break;
                case nameof(SwipeBehaviorOnInvoked):
                    if (!Equals(SwipeBehaviorOnInvoked, value))
                    {
                        SwipeBehaviorOnInvoked = (SwipeBehaviorOnInvoked?)value;
                        NativeControl.SwipeBehaviorOnInvoked = SwipeBehaviorOnInvoked ?? (SwipeBehaviorOnInvoked)MC.SwipeItems.SwipeBehaviorOnInvokedProperty.DefaultValue;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        static partial void RegisterAdditionalHandlers();
    }
}