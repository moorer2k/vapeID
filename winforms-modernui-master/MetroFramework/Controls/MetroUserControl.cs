﻿/**
 * MetroFramework - Modern UI for WinForms
 * 
 * The MIT License (MIT)
 * Copyright (c) 2011 Sven Walter, http://github.com/viperneo
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of 
 * this software and associated documentation files (the "Software"), to deal in the 
 * Software without restriction, including without limitation the rights to use, copy, 
 * modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, 
 * and to permit persons to whom the Software is furnished to do so, subject to the 
 * following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in 
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
 * PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
 * CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
 * OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using MetroFramework.Components;
using MetroFramework.Interfaces;
using MetroFramework.Drawing;

namespace MetroFramework.Controls
{
    public class MetroUserControl : UserControl, IMetroControl
    {
        #region Interface

        private MetroColorStyle metroStyle = MetroColorStyle.Blue;
        [Category("Metro Appearance")]
        public MetroColorStyle Style
        {
            get
            {
                if (StyleManager != null)
                    return StyleManager.Style;

                return metroStyle;
            }
            set { metroStyle = value; }
        }

        private MetroThemeStyle metroTheme = MetroThemeStyle.Light;
        [Category("Metro Appearance")]
        public MetroThemeStyle Theme
        {
            get
            {
                if (StyleManager != null)
                    return StyleManager.Theme;

                return metroTheme;
            }
            set { metroTheme = value; }
        }

        private MetroStyleManager metroStyleManager = null;
        [Browsable(false)]
        public MetroStyleManager StyleManager
        {
            get { return metroStyleManager; }
            set { metroStyleManager = value; }
        }

        #endregion

        #region Fields

        private bool useCustomBackground = false;
        [Category("Metro Appearance")]
        public bool CustomBackground
        {
            get { return useCustomBackground; }
            set { useCustomBackground = value; }
        }

        #endregion

        #region Overridden Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Color backColor = MetroPaint.BackColor.Form(Theme);
            if (useCustomBackground)
                backColor = BackColor;

            e.Graphics.Clear(backColor);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            Invalidate();
        }

        #endregion
    }
}
