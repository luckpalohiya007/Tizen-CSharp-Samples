/*
 * Copyright 2019 Samsung Electronics Co., Ltd. All rights reserved.
 *
 * Licensed under the Flora License, Version 1.1 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://floralicense.org/license
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

﻿using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestureSensor.Tizen.Wearable.Controls
{
    /// <summary>
    /// Icon control with text.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GestureImage : AbsoluteLayout
    {
        /// <summary>
        /// Backing field for <see cref="Text"/>
        /// </summary>
        private string _text;

        /// <summary>
        /// Backing store for the Command bindable property.
        /// </summary>
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(GestureImage), null);

        /// <summary>
        /// Backing store for the PressCommand bindable property.
        /// </summary>
        public static readonly BindableProperty PressCommandProperty =
            BindableProperty.Create(nameof(PressCommand), typeof(ICommand), typeof(MaskedImageButton), null);

        /// <summary>
        /// Backing store for the Command bindable property.
        /// </summary>
        public static readonly BindableProperty ReleaseCommandProperty =
            BindableProperty.Create(nameof(ReleaseCommand), typeof(ICommand), typeof(MaskedImageButton), null);

        /// <summary>
        /// Backing store for the IconColor bindable property.
        /// </summary>
        public static readonly BindableProperty IconColorProperty =
            BindableProperty.Create(nameof(IconColor), typeof(Color), typeof(GestureImage), Color.Transparent);

        /// <summary>
        /// Backing store for the IconBackgroundColor bindable property.
        /// </summary>
        public static readonly BindableProperty IconBackgroundColorProperty =
            BindableProperty.Create(nameof(IconBackgroundColor), typeof(Color), typeof(GestureImage), Color.Transparent);

        /// <summary>
        /// Gets or sets Command executed on tap.
        /// </summary>
        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        /// <summary>
        /// Gets or sets command executed on click.
        /// </summary>
        public ICommand PressCommand
        {
            get => (ICommand)GetValue(PressCommandProperty);
            set => SetValue(PressCommandProperty, value);
        }

        /// <summary>
        /// Gets or sets command executed on click.
        /// </summary>
        public ICommand ReleaseCommand
        {
            get => (ICommand)GetValue(ReleaseCommandProperty);
            set => SetValue(ReleaseCommandProperty, value);
        }

        /// <summary>
        /// Gets or set icon color.
        /// </summary>
        public Color IconColor
        {
            get => (Color)GetValue(IconColorProperty);
            set => SetValue(IconColorProperty, value);
        }

        /// <summary>
        /// Gets or set icon background color.
        /// </summary>
        public Color IconBackgroundColor
        {
            get => (Color)GetValue(IconBackgroundColorProperty);
            set => SetValue(IconBackgroundColorProperty, value);
        }

        /// <summary>
        /// Gets or sets icon text.
        /// </summary>
        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged(nameof(Text));
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GestureImage"/> class.
        /// </summary>
        public GestureImage()
        {
            InitializeComponent();
        }
    }
}
