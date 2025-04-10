﻿using System.Drawing;
using System.Windows.Forms;
using ExtractorSharp.Core.Model;
using System.ComponentModel;

namespace ExtractorSharp.Component {
    public partial class ESTabPanel : TabControl {
        public ESTabPanel() {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Language Language { set; get; } = Language.Default;

        public void AddPage(string name, Control control) {
            var page = new TabPage(Language[name]);
            page.Controls.Add(control);
            page.UseVisualStyleBackColor = true;
            TabPages.Add(page);
        }

        protected override void OnDrawItem(DrawItemEventArgs e) {
            var format = new StringFormat {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            };
            var rect = GetTabRect(e.Index);
            var brush = Brushes.Black;
            var text = TabPages[e.Index].Text;
            e.Graphics.DrawString(text, Font, brush, rect, format);
        }
    }
}