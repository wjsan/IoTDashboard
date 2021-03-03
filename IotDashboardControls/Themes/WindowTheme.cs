﻿using IotDashboard.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoTDashboard.Components
{
    [ToolboxItem(false)]
    public partial class WindowTheme : Component
    {
        public Color BackgroudColor { get; set; }

        public WindowTheme()
        {
            InitializeComponent();
        }

        public WindowTheme(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

    }
}
