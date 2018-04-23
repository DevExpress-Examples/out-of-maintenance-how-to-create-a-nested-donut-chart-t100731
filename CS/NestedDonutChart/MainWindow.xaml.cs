using System.Windows;
using DevExpress.Xpf.Charts;
using System.Windows.Media;

namespace NestedDonutChart {

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void chartControl1_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {

            if (e.SeriesPoint.Value <= 10) {
                e.DrawOptions.Color = Color.FromArgb(0xFF, 0x51, 0x89, 0x03);
            }

            else if ((e.SeriesPoint.Value > 10) & (e.SeriesPoint.Value <= 20)) {
                e.DrawOptions.Color = Color.FromArgb(0xFF, 0xF9, 0xAA, 0x0F);
            }

            else if (e.SeriesPoint.Value > 20) {
                e.DrawOptions.Color = Color.FromArgb(0xFF, 0xC7, 0x39, 0x0C);
            }
        }
    }
}


