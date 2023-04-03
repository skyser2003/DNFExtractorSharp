﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ExtractorSharp.Component;
using ExtractorSharp.Core.Composition;
using ExtractorSharp.Core.Config;

namespace ExtractorSharp.View.SettingPane {
    public partial class SaveImagePane : AbstractSettingPane {
        private List<CheckBox> converterList;

        public SaveImagePane(IConnector Connector) : base(Connector) {
            InitializeComponent();
            savePathBox.Click += Browse;
            browseButton.Click += Browse;
            emptyButton.Click += (o, e) => savePathBox.Clear();
        }

        private void Browse(object sender, EventArgs e) {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                savePathBox.Text = dialog.SelectedPath;
            }
        }

        public override void Initialize() {
            promptCheck.Checked = Config["SaveImageTip"].Boolean;
            fullPathCheck.Checked = Config["SaveImageFullPath"].Boolean;
            savePathBox.Text = Config["SaveImagePath"].Value;
            var i = 0;
            converterList = new List<CheckBox>();
            converterGroup.Controls.Clear();
            foreach (var converter in Connector.Effects) {
                var checkbox = new CheckBox();
                checkbox.Text = Language[converter.Name];
                checkbox.Tag = converter;
                checkbox.Checked = Config[$"{converter.Name}Effect"].Boolean;
                checkbox.Location = new Point(100 * (i / 4) + 10, i * 30 + 15);
                converterList.Add(checkbox);
                i++;
            }

            converterGroup.Controls.AddRange(converterList.ToArray());
        }

        public override void Save() {
            Config["SaveImageTip"] = new ConfigValue(promptCheck.Checked);
            Config["SaveImageFullPath"] = new ConfigValue(fullPathCheck.Checked);
            Config["SaveImagePath"] = new ConfigValue(savePathBox.Text);
            foreach (var box in converterList) {
                var converter = box.Tag as IEffect;
                Config[$"{converter.Name}Effect"] = new ConfigValue(box.Checked);
                converter.Enable = box.Checked;
            }
        }
    }
}