using CrossSentimenttMLModel;

namespace EmotionAnalystApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnalyst_Click(object sender, EventArgs e)
        {
            //Load sample data
            var sampleData = new SentimentMLModel.ModelInput()
            {
                Col0 = richTextBoxComment.Text,
            };

            //Load model and predict output
            var result = SentimentMLModel.Predict(sampleData);
            double ratio_positive = Math.Round(result.Score[1]* 100 , 1);
            double ratio_negative = Math.Round(result.Score[0]* 100 , 1);
            labelPostive.Text = ratio_positive.ToString();
            labelNegative.Text =ratio_negative.ToString();

        }
    }
}
