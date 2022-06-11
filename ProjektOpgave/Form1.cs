namespace ProjektOpgave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vinkelA = Convert.ToDouble(textBoxVinkelA.Text);
            double vinkelC = Convert.ToDouble(textBoxVinkelC.Text);
            double sideB = Convert.ToDouble(textBoxSideB.Text);
            //Grader til Radianer
            double vinkelARadianer = vinkelA / 180 * Math.PI;
            //Vinkel B
            double vinkelB = vinkelC - vinkelA;
            textBoxVinkelB.Text = vinkelB.ToString();
            //Side a
            double sideA = sideB * Math.Tan(vinkelARadianer);
            textBoxSideA.Text = sideA.ToString("0.00");
            //Side c
            double sideC = sideB / Math.Cos(vinkelARadianer);
            textBoxSideC.Text = sideC.ToString("0.00");
            //Omkreds
            double omkreds = sideA + sideB + sideC;
            textBoxOmkreds.Text = omkreds.ToString("0.00");
            //Areal
            double areal = sideA * sideB / 2;
            textBoxAreal.Text = areal.ToString("0.00");
        }
    }
}