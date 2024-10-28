namespace projeto5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(caixaquantidade.Text);
            int contagemTotal = 0;

            for ( int i = 1; i <= quantidade; i++)
            if(i % 10 == 0 || i== 1)
            {
                richTextBox1.AppendText(i.ToString() + Environment.NewLine);
                contagemTotal++;
            }
            else if(i==quantidade)
                {
                    string text = quantidade.ToString();
                    richTextBox1.Text += text;
                }
            
            
        }
    }
}
