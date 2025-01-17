// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using AC = AlohaKit.Controls;
using BlazorBindings.Core;
using BlazorBindings.Maui.Elements;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Maui.Graphics;
using System.ComponentModel;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.Maui.Elements.AlohaKit
{
    public partial class ToggleSwitch : BlazorBindings.Maui.Elements.GraphicsView
    {
        static ToggleSwitch()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public bool? HasShadow { get; set; }
        [Parameter] public bool? IsOn { get; set; }
        [Parameter] public Color ThumbColor { get; set; }
        [Parameter] public AC.ToggleSwitchDrawable ToggleSwitchDrawable { get; set; }
        [Parameter] public RenderFragment ThumbBrush { get; set; }
        [Parameter] public EventCallback<bool> IsOnChanged { get; set; }

        public new AC.ToggleSwitch NativeControl => (AC.ToggleSwitch)((BindableObject)this).NativeControl;

        protected override AC.ToggleSwitch CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(HasShadow):
                    if (!Equals(HasShadow, value))
                    {
                        HasShadow = (bool?)value;
                        NativeControl.HasShadow = HasShadow ?? (bool)AC.ToggleSwitch.HasShadowProperty.DefaultValue;
                    }
                    break;
                case nameof(IsOn):
                    if (!Equals(IsOn, value))
                    {
                        IsOn = (bool?)value;
                        NativeControl.IsOn = IsOn ?? (bool)AC.ToggleSwitch.IsOnProperty.DefaultValue;
                    }
                    break;
                case nameof(ThumbColor):
                    if (!Equals(ThumbColor, value))
                    {
                        ThumbColor = (Color)value;
                        NativeControl.ThumbBrush = ThumbColor;
                    }
                    break;
                case nameof(ToggleSwitchDrawable):
                    if (!Equals(ToggleSwitchDrawable, value))
                    {
                        ToggleSwitchDrawable = (AC.ToggleSwitchDrawable)value;
                        NativeControl.ToggleSwitchDrawable = ToggleSwitchDrawable;
                    }
                    break;
                case nameof(Background):
                    Background = (RenderFragment)value;
                    break;
                case nameof(ThumbBrush):
                    ThumbBrush = (RenderFragment)value;
                    break;
                case nameof(IsOnChanged):
                    if (!Equals(IsOnChanged, value))
                    {
                        void NativeControlPropertyChanged(object sender, PropertyChangedEventArgs e)
                        {
                            if (e.PropertyName == nameof(NativeControl.IsOn))
                            {
                                var value = NativeControl.IsOn;
                                IsOn = value;
                                InvokeEventCallback(IsOnChanged, value);
                            }
                        }

                        IsOnChanged = (EventCallback<bool>)value;
                        NativeControl.PropertyChanged -= NativeControlPropertyChanged;
                        NativeControl.PropertyChanged += NativeControlPropertyChanged;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
            RenderTreeBuilderHelper.AddContentProperty<AC.ToggleSwitch>(builder, sequence++, Background, (x, value) => x.Background = (MC.Brush)value);
            RenderTreeBuilderHelper.AddContentProperty<AC.ToggleSwitch>(builder, sequence++, ThumbBrush, (x, value) => x.ThumbBrush = (MC.Brush)value);
        }

        static partial void RegisterAdditionalHandlers();
    }
}
