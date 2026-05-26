namespace homework_4
{
    public partial class Form1 : Form
    {
        private List<int> answer = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            random();
            MessageBox.Show("遊戲開始!! 請在下方輸入框輸入4位數字");
            listBox1.Items.Clear();
            button1.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("答案是: " + string.Join("",answer));
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string input = textBox1.Text.Trim();

            if (input.Length != 4)
            {
                MessageBox.Show("請輸入4位數字");
                return;
            }

            int[] guess = input.Select(c => c - '0').ToArray();

            int A = 0;
            int B = 0;

            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == answer[i])
                {
                    A++;
                }
                else if (answer.Contains(guess[i]))
                {
                    B++;
                }
            }

            string resultText = $"{input} -> {A}A{B}B";
            listBox1.Items.Add(resultText);

            if (A == 4)
            {
                MessageBox.Show("你猜對了!! ");
                button1.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            random();
            listBox1.Items.Clear();
            button3.Enabled = true;
            MessageBox.Show("遊戲已重製");
        }
        private void random()
        {
            Random rand = new Random();
            //HashSet元素絕對不重複
            HashSet<int> uniqueNumbers = new HashSet<int>();

            while (uniqueNumbers.Count < 4)
            {
                uniqueNumbers.Add(rand.Next(0, 10));
            }

            answer = uniqueNumbers.ToList();
        }
    }
}
   
