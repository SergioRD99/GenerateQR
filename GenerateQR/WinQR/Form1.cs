using System.Drawing.Imaging;

namespace WinQR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_generateQR_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw mGen =
                Zen.Barcode.BarcodeDrawFactory.CodeQr;
            PBQR.Image = mGen.Draw(textBox1.Text, 100);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".png";
            save.Filter = "Archivos PNG (*.png)|*.png";
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (save.ShowDialog() == DialogResult.OK)
            {
                string codigoQR = save.FileName;               
                if (PBQR.Image != null)
                {                 
                    PBQR.Image.Save(codigoQR, ImageFormat.Png);
                }
                else
                {
                    MessageBox.Show("No hay una imagen para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
