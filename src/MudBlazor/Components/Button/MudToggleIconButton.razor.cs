﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace MudBlazor
{
#nullable enable
    public partial class MudToggleIconButton : MudComponentBase
    {
        /// <summary>
        /// The toggled value.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.Button.Behavior)]
        public bool Toggled { get; set; }

        /// <summary>
        /// Fires whenever toggled is changed. 
        /// </summary>
        [Parameter]
        public EventCallback<bool> ToggledChanged { get; set; }

        /// <summary>
        /// The Icon that will be used in the untoggled state.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.Button.Behavior)]
        public string? Icon { get; set; }

        /// <summary>
        /// The Icon that will be used in the toggled state.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.Button.Behavior)]
        public string? ToggledIcon { get; set; }

        /// <summary>
        /// Text for the <c>title</c> attribute which provides a basic tooltip.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.Button.Behavior)]
        public string? Title { get; set; }

        /// <summary>
        /// Used as an alternative for <see cref="Title"/> when in the toggled state if this property is specified.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.Button.Behavior)]
        public string? ToggledTitle { get; set; }

        /// <summary>
        /// The <c>aria-label</c> for the button when it's not in the toggled state.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>null</c>.
        /// </remarks>
        [Parameter]
        [Category(CategoryTypes.Button.Behavior)]
        public string? AriaLabel { get; set; }

        /// <summary>
        /// The <c>aria-label</c> for the button when it's in the toggled state.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>null</c>.
        /// </remarks>
        [Parameter]
        [Category(CategoryTypes.Button.Behavior)]
        public string? ToggledAriaLabel { get; set; }

        /// <summary>
        /// The color of the icon in the untoggled state. It supports the theme colors.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.Button.Appearance)]
        public Color Color { get; set; } = Color.Default;

        /// <summary>
        /// The color of the icon in the toggled state. It supports the theme colors.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.Button.Appearance)]
        public Color ToggledColor { get; set; } = Color.Default;

        /// <summary>
        /// The Size of the component in the untoggled state.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.Button.Appearance)]
        public Size Size { get; set; } = Size.Medium;

        /// <summary>
        /// The Size of the component in the toggled state.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.Button.Appearance)]
        public Size ToggledSize { get; set; } = Size.Medium;

        /// <summary>
        /// If set uses a negative margin.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.Button.Appearance)]
        public Edge Edge { get; set; }

        /// <summary>
        /// Whether to show a ripple effect when the user clicks the button. Default is true.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.Button.Appearance)]
        public bool Ripple { get; set; } = true;

        /// <summary>
        /// If true, the button will be disabled.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.Button.Behavior)]
        public bool Disabled { get; set; }

        /// <summary>
        /// The variant to use.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.Button.Appearance)]
        public Variant Variant { get; set; } = Variant.Text;

        /// <summary>
        /// Determines whether the component has a drop-shadow. Default is true
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.Button.Appearance)]
        public bool DropShadow { get; set; } = true;

        /// <summary>
        /// If true, the click event bubbles up to the containing/parent component.
        /// </summary>
        [Parameter]
        [Category(CategoryTypes.Button.Behavior)]
        public bool ClickPropagation { get; set; }

        public Task Toggle()
        {
            return SetToggledAsync(!Toggled);
        }

        protected internal async Task SetToggledAsync(bool toggled)
        {
            if (Disabled)
                return;
            if (Toggled != toggled)
            {
                Toggled = toggled;
                await ToggledChanged.InvokeAsync(Toggled);
            }
        }
    }
}
