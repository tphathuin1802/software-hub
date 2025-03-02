namespace DemoAutoMLSentiment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Load sample data
            var sampleData = new MLModel1.ModelInput()
            {
                Col0 = richTextBox1.Text,
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);
            double f_positive = Math.Round(result.Score[1], 0);
            double f_negative = Math.Round(result.Score[0], 0);
            LabelNegative.Text = result.Score[0].ToString();
            lablePositive.Text = result.Score[1].ToString();

        }
    }
}
