using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace ExtractorSharp.Component {
    public partial class ColorPanel : Panel {
        public ColorPanel() {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color Color {
            set => BackColor = value;
            get => BackColor;
        }
    }
}