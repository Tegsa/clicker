namespace clicker
{
    public partial class Form1 : Form
    {
        private int cash;
        public int Cash
        {
            set
            {
                cash = value;
                label1.Text = "Bitcoiny: $" + value.ToString();
            }
            get
            { 
            return cash;
            }
        }
        uint buttonLevel;
        int A1Ammount;
        int A2Ammount;
        int A3Ammount;
        int A1Interval; //iloœæ cykli / min
        int A2Interval;
        int A3Interval;
        public Form1()
        {
            InitializeComponent();
            Cash = 0;
            buttonLevel = 1;
            A1Ammount = 10;
            A2Ammount = 10;
            A3Ammount = 10;
            A1Interval = 0;
            A2Interval = 0;
            A3Interval = 0;
            A1AmmountTextBox.Text = A1Ammount.ToString();
            A1AmmountTextBox.Text = A1Interval.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cash += (int)Math.Pow(10, buttonLevel-1);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void upgradebutton_Click(object sender, EventArgs e)
        {
            int upgradeCost = (int)Math.Pow(10, buttonLevel);
            if (Cash >= upgradeCost)
            {
                buttonLevel++;
                buttonLevelTextBox.Text = buttonLevel.ToString();
                Cash -= upgradeCost;
                
                string nextUpgradeCost = "($" + Math.Pow(10, buttonLevel).ToString() + ")";
                upgradebutton.Text = "Upgrade\n" + nextUpgradeCost;
            }
            }

        private void A1UpgradeInterval_Click(object sender, EventArgs e)
        {
            int upgradeCost = A1Interval * 100;
            if(Cash >= upgradeCost){
                A1Interval++;
                A1IntervalTextBox.Text = A1Interval.ToString();
                A1Timer.Interval = (60 / A1Interval) * 100;
                if (!A1Timer.Enabled)
                    A1Timer.Enabled = true;
                Cash -= upgradeCost;
            }
        }

        private void A1UpgradeAmmount_Click(object sender, EventArgs e)
        {
            A1Ammount += 10;
            A1AmmountTextBox.Text = A1Ammount.ToString();
        }

        private void A1Tick(object sender, EventArgs e)
        {
            Cash += A1Ammount;
        }

        private void A2UpgradeInterval_Click(object sender, EventArgs e)
        {
            int upgradeCost = A2Interval * 1000;
            if (Cash >= upgradeCost)
            {

                A2Interval++;
                A2IntervalTextBox.Text = A2Interval.ToString();
                A2Timer.Interval = (60 / A2Interval) * 50;
                if (!A2Timer.Enabled)
                    A2Timer.Enabled = true;
                Cash -= upgradeCost;
            }
        }

        private void A2IntervalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void A2Tick(object sender, EventArgs e)
        {
            Cash += A2Ammount;
        }

        private void A3UpgradeInterval_Click(object sender, EventArgs e)
        {
            int upgradeCost = A3Interval * 2000;
            if (Cash >= upgradeCost && buttonLevel >= 3)
            {

                A3Interval++;
                A3IntervalTextBox.Text = A3Interval.ToString();
                A3Time.Interval = (int)Math.Ceiling((double)((60 / A3Interval) * 30 + float.Epsilon));
                if (!A3Time.Enabled)
                    A3Time.Enabled = true;
                Cash -= upgradeCost;
            }
        }

        private void A3IntervalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void A3Tick(object sender, EventArgs e)
        {
            Cash += A3Ammount;
        }

        private void A2UpgradeAmmount_Click(object sender, EventArgs e)
        {
            A2Ammount += 30;
            A2AmmountTextBox.Text = A2Ammount.ToString();
        }

        private void A2AmmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void A3UpgradeButton_Click(object sender, EventArgs e)
        {
            A3Ammount += 50;
            A3AmmountTextBox.Text = A3Ammount.ToString();
        }

        private void A3AmmountTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}