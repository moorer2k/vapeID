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
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

using MetroFramework.Controls;
using MetroFramework.Native;

namespace MetroFramework.Design
{
    internal class MetroTabControlDesigner : ParentControlDesigner
    {
        #region Variables
        /// <summary>
        /// 
        /// </summary>
        private readonly DesignerVerbCollection _verbs = new DesignerVerbCollection();
        /// <summary>
        /// 
        /// </summary>
        private IDesignerHost _designerHost;
        /// <summary>
        /// 
        /// </summary>
        private ISelectionService _selectionService;
        #endregion

        #region Fields
        public override SelectionRules SelectionRules
        {
            get
            {
                return Control.Dock == DockStyle.Fill ? SelectionRules.Visible : base.SelectionRules;
            }
        }
        public override DesignerVerbCollection Verbs
        {
            get
            {
                if (_verbs.Count == 2)
                {
                    var myControl = (MetroTabControl)Control;
                    _verbs[1].Enabled = myControl.TabCount != 0;
                }
                return _verbs;
            }
        }

        public IDesignerHost DesignerHost
        {
            get
            {
                return _designerHost ?? (_designerHost = (IDesignerHost)(GetService(typeof(IDesignerHost))));
            }
        }

        public ISelectionService SelectionService
        {
            get
            {
                return _selectionService ?? (_selectionService = (ISelectionService)(GetService(typeof(ISelectionService))));
            }
        }
        #endregion

        #region Constructor
        public MetroTabControlDesigner()
        {
            var verb1 = new DesignerVerb("Add Tab", OnAddPage);
            var verb2 = new DesignerVerb("Remove Tab", OnRemovePage);
            _verbs.AddRange(new[] { verb1, verb2 });
        }
        #endregion

        #region Private methods
        private void OnAddPage(Object sender, EventArgs e)
        {
            var parentControl = (MetroTabControl) Control;
            var oldTabs = parentControl.Controls;

            RaiseComponentChanging(TypeDescriptor.GetProperties(parentControl)["TabPages"]);

            var p = (MetroTabPage)(DesignerHost.CreateComponent(typeof(MetroTabPage)));
            p.Text = p.Name;
            parentControl.TabPages.Add(p);

            RaiseComponentChanged(TypeDescriptor.GetProperties(parentControl)["TabPages"],
                                  oldTabs, parentControl.TabPages);
            parentControl.SelectedTab = p;

            SetVerbs();
        }

        private void OnRemovePage(Object sender, EventArgs e)
        {
            var parentControl = (MetroTabControl) Control;
            var oldTabs = parentControl.Controls;

            if (parentControl.SelectedIndex < 0)
            {
                return;
            }

            RaiseComponentChanging(TypeDescriptor.GetProperties(parentControl)["TabPages"]);

            DesignerHost.DestroyComponent(parentControl.TabPages[parentControl.SelectedIndex]);

            RaiseComponentChanged(TypeDescriptor.GetProperties(parentControl)["TabPages"],
                                  oldTabs, parentControl.TabPages);

            SelectionService.SetSelectedComponents(new IComponent[]
            {
                parentControl
            }, SelectionTypes.Auto);

            SetVerbs();
        }

        private void SetVerbs()
        {
            var parentControl = (MetroTabControl) Control;

            switch (parentControl.TabPages.Count)
            {
                case 0:
                    Verbs[1].Enabled = false;
                    break;
                default:
                    Verbs[1].Enabled = true;
                    break;
            }
        }
        #endregion

        #region Overrides
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case (int)WinApi.Messages.WM_NCHITTEST:
                    if (m.Result.ToInt32() == (int)WinApi.HitTest.HTTRANSPARENT)
                    {
                        m.Result = (IntPtr) WinApi.HitTest.HTCLIENT;
                    }
                    break;
            }
        }

        protected override bool GetHitTest(System.Drawing.Point point)
        {
            if (SelectionService.PrimarySelection == Control)
            {
                var hti = new WinApi.TCHITTESTINFO
                {
                    pt = Control.PointToClient(point),
                    flags = 0
                };

                var m = new Message
                {
                    HWnd = Control.Handle,
                    Msg = WinApi.TCM_HITTEST
                };

                var lparam =
                    System.Runtime.InteropServices.Marshal.AllocHGlobal(System.Runtime.InteropServices.Marshal.SizeOf(hti));
                System.Runtime.InteropServices.Marshal.StructureToPtr(hti,
                                                                      lparam, false);
                m.LParam = lparam;

                base.WndProc(ref m);
                System.Runtime.InteropServices.Marshal.FreeHGlobal(lparam);

                if (m.Result.ToInt32() != -1)
                {
                    return hti.flags != (int)WinApi.TabControlHitTest.TCHT_NOWHERE;
                }
            }

            return false;
        }

        protected override void PreFilterProperties(IDictionary properties)
        {
            properties.Remove("ImeMode");
            properties.Remove("Padding");
            properties.Remove("FlatAppearance");
            properties.Remove("FlatStyle");
            properties.Remove("AutoEllipsis");
            properties.Remove("UseCompatibleTextRendering");

            properties.Remove("Image");
            properties.Remove("ImageAlign");
            properties.Remove("ImageIndex");
            properties.Remove("ImageKey");
            properties.Remove("ImageList");
            properties.Remove("TextImageRelation");

            properties.Remove("BackgroundImage");
            properties.Remove("BackgroundImageLayout");
            properties.Remove("UseVisualStyleBackColor");

            properties.Remove("Font");
            properties.Remove("ForeColor");
            properties.Remove("RightToLeft");

            base.PreFilterProperties(properties);
        }
        #endregion
    }
}