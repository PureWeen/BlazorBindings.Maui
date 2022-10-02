// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements.Handlers;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using System;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public abstract partial class VisualElement : NavigableElement
    {
        static VisualElement()
        {
            ElementHandlerRegistry.RegisterPropertyContentHandler<VisualElement>(nameof(Background),
                (renderer, parent, component) => new ContentPropertyHandler<MC.VisualElement>((x, value) => x.Background = (MC.Brush)value));
            ElementHandlerRegistry.RegisterPropertyContentHandler<VisualElement>(nameof(Shadow),
                (renderer, parent, component) => new ContentPropertyHandler<MC.VisualElement>((x, value) => x.Shadow = (MC.Shadow)value));
            RegisterAdditionalHandlers();
        }

        [Parameter] public double? AnchorX { get; set; }
        [Parameter] public double? AnchorY { get; set; }
        [Parameter] public Color BackgroundColor { get; set; }
        [Parameter] public FlowDirection? FlowDirection { get; set; }
        [Parameter] public Rect? Frame { get; set; }
        [Parameter] public double? HeightRequest { get; set; }
        [Parameter] public bool? InputTransparent { get; set; }
        [Parameter] public bool? IsEnabled { get; set; }
        [Parameter] public bool? IsVisible { get; set; }
        [Parameter] public double? MaximumHeightRequest { get; set; }
        [Parameter] public double? MaximumWidthRequest { get; set; }
        [Parameter] public double? MinimumHeightRequest { get; set; }
        [Parameter] public double? MinimumWidthRequest { get; set; }
        [Parameter] public double? Opacity { get; set; }
        [Parameter] public double? Rotation { get; set; }
        [Parameter] public double? RotationX { get; set; }
        [Parameter] public double? RotationY { get; set; }
        [Parameter] public double? Scale { get; set; }
        [Parameter] public double? ScaleX { get; set; }
        [Parameter] public double? ScaleY { get; set; }
        [Parameter] public double? TranslationX { get; set; }
        [Parameter] public double? TranslationY { get; set; }
        [Parameter] public double? WidthRequest { get; set; }
        [Parameter] public int? ZIndex { get; set; }
        [Parameter] public RenderFragment Background { get; set; }
        [Parameter] public RenderFragment Shadow { get; set; }
        [Parameter] public EventCallback OnLoaded { get; set; }
        [Parameter] public EventCallback OnUnloaded { get; set; }
        [Parameter] public EventCallback OnChildrenReordered { get; set; }
        [Parameter] public EventCallback<MC.FocusEventArgs> OnFocused { get; set; }
        [Parameter] public EventCallback OnMeasureInvalidated { get; set; }
        [Parameter] public EventCallback OnSizeChanged { get; set; }
        [Parameter] public EventCallback<MC.FocusEventArgs> OnUnfocused { get; set; }

        public new MC.VisualElement NativeControl => (MC.VisualElement)((Element)this).NativeControl;


        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(AnchorX):
                    if (!Equals(AnchorX, value))
                    {
                        AnchorX = (double?)value;
                        NativeControl.AnchorX = AnchorX ?? (double)MC.VisualElement.AnchorXProperty.DefaultValue;
                    }
                    break;
                case nameof(AnchorY):
                    if (!Equals(AnchorY, value))
                    {
                        AnchorY = (double?)value;
                        NativeControl.AnchorY = AnchorY ?? (double)MC.VisualElement.AnchorYProperty.DefaultValue;
                    }
                    break;
                case nameof(BackgroundColor):
                    if (!Equals(BackgroundColor, value))
                    {
                        BackgroundColor = (Color)value;
                        NativeControl.BackgroundColor = BackgroundColor;
                    }
                    break;
                case nameof(FlowDirection):
                    if (!Equals(FlowDirection, value))
                    {
                        FlowDirection = (FlowDirection?)value;
                        NativeControl.FlowDirection = FlowDirection ?? (FlowDirection)MC.VisualElement.FlowDirectionProperty.DefaultValue;
                    }
                    break;
                case nameof(Frame):
                    if (!Equals(Frame, value))
                    {
                        Frame = (Rect?)value;
                        NativeControl.Frame = Frame ?? default;
                    }
                    break;
                case nameof(HeightRequest):
                    if (!Equals(HeightRequest, value))
                    {
                        HeightRequest = (double?)value;
                        NativeControl.HeightRequest = HeightRequest ?? (double)MC.VisualElement.HeightRequestProperty.DefaultValue;
                    }
                    break;
                case nameof(InputTransparent):
                    if (!Equals(InputTransparent, value))
                    {
                        InputTransparent = (bool?)value;
                        NativeControl.InputTransparent = InputTransparent ?? (bool)MC.VisualElement.InputTransparentProperty.DefaultValue;
                    }
                    break;
                case nameof(IsEnabled):
                    if (!Equals(IsEnabled, value))
                    {
                        IsEnabled = (bool?)value;
                        NativeControl.IsEnabled = IsEnabled ?? (bool)MC.VisualElement.IsEnabledProperty.DefaultValue;
                    }
                    break;
                case nameof(IsVisible):
                    if (!Equals(IsVisible, value))
                    {
                        IsVisible = (bool?)value;
                        NativeControl.IsVisible = IsVisible ?? (bool)MC.VisualElement.IsVisibleProperty.DefaultValue;
                    }
                    break;
                case nameof(MaximumHeightRequest):
                    if (!Equals(MaximumHeightRequest, value))
                    {
                        MaximumHeightRequest = (double?)value;
                        NativeControl.MaximumHeightRequest = MaximumHeightRequest ?? (double)MC.VisualElement.MaximumHeightRequestProperty.DefaultValue;
                    }
                    break;
                case nameof(MaximumWidthRequest):
                    if (!Equals(MaximumWidthRequest, value))
                    {
                        MaximumWidthRequest = (double?)value;
                        NativeControl.MaximumWidthRequest = MaximumWidthRequest ?? (double)MC.VisualElement.MaximumWidthRequestProperty.DefaultValue;
                    }
                    break;
                case nameof(MinimumHeightRequest):
                    if (!Equals(MinimumHeightRequest, value))
                    {
                        MinimumHeightRequest = (double?)value;
                        NativeControl.MinimumHeightRequest = MinimumHeightRequest ?? (double)MC.VisualElement.MinimumHeightRequestProperty.DefaultValue;
                    }
                    break;
                case nameof(MinimumWidthRequest):
                    if (!Equals(MinimumWidthRequest, value))
                    {
                        MinimumWidthRequest = (double?)value;
                        NativeControl.MinimumWidthRequest = MinimumWidthRequest ?? (double)MC.VisualElement.MinimumWidthRequestProperty.DefaultValue;
                    }
                    break;
                case nameof(Opacity):
                    if (!Equals(Opacity, value))
                    {
                        Opacity = (double?)value;
                        NativeControl.Opacity = Opacity ?? (double)MC.VisualElement.OpacityProperty.DefaultValue;
                    }
                    break;
                case nameof(Rotation):
                    if (!Equals(Rotation, value))
                    {
                        Rotation = (double?)value;
                        NativeControl.Rotation = Rotation ?? (double)MC.VisualElement.RotationProperty.DefaultValue;
                    }
                    break;
                case nameof(RotationX):
                    if (!Equals(RotationX, value))
                    {
                        RotationX = (double?)value;
                        NativeControl.RotationX = RotationX ?? (double)MC.VisualElement.RotationXProperty.DefaultValue;
                    }
                    break;
                case nameof(RotationY):
                    if (!Equals(RotationY, value))
                    {
                        RotationY = (double?)value;
                        NativeControl.RotationY = RotationY ?? (double)MC.VisualElement.RotationYProperty.DefaultValue;
                    }
                    break;
                case nameof(Scale):
                    if (!Equals(Scale, value))
                    {
                        Scale = (double?)value;
                        NativeControl.Scale = Scale ?? (double)MC.VisualElement.ScaleProperty.DefaultValue;
                    }
                    break;
                case nameof(ScaleX):
                    if (!Equals(ScaleX, value))
                    {
                        ScaleX = (double?)value;
                        NativeControl.ScaleX = ScaleX ?? (double)MC.VisualElement.ScaleXProperty.DefaultValue;
                    }
                    break;
                case nameof(ScaleY):
                    if (!Equals(ScaleY, value))
                    {
                        ScaleY = (double?)value;
                        NativeControl.ScaleY = ScaleY ?? (double)MC.VisualElement.ScaleYProperty.DefaultValue;
                    }
                    break;
                case nameof(TranslationX):
                    if (!Equals(TranslationX, value))
                    {
                        TranslationX = (double?)value;
                        NativeControl.TranslationX = TranslationX ?? (double)MC.VisualElement.TranslationXProperty.DefaultValue;
                    }
                    break;
                case nameof(TranslationY):
                    if (!Equals(TranslationY, value))
                    {
                        TranslationY = (double?)value;
                        NativeControl.TranslationY = TranslationY ?? (double)MC.VisualElement.TranslationYProperty.DefaultValue;
                    }
                    break;
                case nameof(WidthRequest):
                    if (!Equals(WidthRequest, value))
                    {
                        WidthRequest = (double?)value;
                        NativeControl.WidthRequest = WidthRequest ?? (double)MC.VisualElement.WidthRequestProperty.DefaultValue;
                    }
                    break;
                case nameof(ZIndex):
                    if (!Equals(ZIndex, value))
                    {
                        ZIndex = (int?)value;
                        NativeControl.ZIndex = ZIndex ?? default;
                    }
                    break;
                case nameof(Background):
                    Background = (RenderFragment)value;
                    break;
                case nameof(Shadow):
                    Shadow = (RenderFragment)value;
                    break;
                case nameof(OnLoaded):
                    if (!Equals(OnLoaded, value))
                    {
                        void NativeControlLoaded(object sender, EventArgs e) => OnLoaded.InvokeAsync();

                        OnLoaded = (EventCallback)value;
                        NativeControl.Loaded -= NativeControlLoaded;
                        NativeControl.Loaded += NativeControlLoaded;
                    }
                    break;
                case nameof(OnUnloaded):
                    if (!Equals(OnUnloaded, value))
                    {
                        void NativeControlUnloaded(object sender, EventArgs e) => OnUnloaded.InvokeAsync();

                        OnUnloaded = (EventCallback)value;
                        NativeControl.Unloaded -= NativeControlUnloaded;
                        NativeControl.Unloaded += NativeControlUnloaded;
                    }
                    break;
                case nameof(OnChildrenReordered):
                    if (!Equals(OnChildrenReordered, value))
                    {
                        void NativeControlChildrenReordered(object sender, EventArgs e) => OnChildrenReordered.InvokeAsync();

                        OnChildrenReordered = (EventCallback)value;
                        NativeControl.ChildrenReordered -= NativeControlChildrenReordered;
                        NativeControl.ChildrenReordered += NativeControlChildrenReordered;
                    }
                    break;
                case nameof(OnFocused):
                    if (!Equals(OnFocused, value))
                    {
                        void NativeControlFocused(object sender, MC.FocusEventArgs e) => OnFocused.InvokeAsync(e);

                        OnFocused = (EventCallback<MC.FocusEventArgs>)value;
                        NativeControl.Focused -= NativeControlFocused;
                        NativeControl.Focused += NativeControlFocused;
                    }
                    break;
                case nameof(OnMeasureInvalidated):
                    if (!Equals(OnMeasureInvalidated, value))
                    {
                        void NativeControlMeasureInvalidated(object sender, EventArgs e) => OnMeasureInvalidated.InvokeAsync();

                        OnMeasureInvalidated = (EventCallback)value;
                        NativeControl.MeasureInvalidated -= NativeControlMeasureInvalidated;
                        NativeControl.MeasureInvalidated += NativeControlMeasureInvalidated;
                    }
                    break;
                case nameof(OnSizeChanged):
                    if (!Equals(OnSizeChanged, value))
                    {
                        void NativeControlSizeChanged(object sender, EventArgs e) => OnSizeChanged.InvokeAsync();

                        OnSizeChanged = (EventCallback)value;
                        NativeControl.SizeChanged -= NativeControlSizeChanged;
                        NativeControl.SizeChanged += NativeControlSizeChanged;
                    }
                    break;
                case nameof(OnUnfocused):
                    if (!Equals(OnUnfocused, value))
                    {
                        void NativeControlUnfocused(object sender, MC.FocusEventArgs e) => OnUnfocused.InvokeAsync(e);

                        OnUnfocused = (EventCallback<MC.FocusEventArgs>)value;
                        NativeControl.Unfocused -= NativeControlUnfocused;
                        NativeControl.Unfocused += NativeControlUnfocused;
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
            RenderTreeBuilderHelper.AddContentProperty(builder, sequence++, typeof(VisualElement), Background);
            RenderTreeBuilderHelper.AddContentProperty(builder, sequence++, typeof(VisualElement), Shadow);
        }

        static partial void RegisterAdditionalHandlers();
    }
}
