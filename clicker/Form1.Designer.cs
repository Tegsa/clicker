namespace clicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.upgradebutton = new System.Windows.Forms.Button();
            this.buttonLevelTextBox = new System.Windows.Forms.TextBox();
            this.A1AmmountTextBox = new System.Windows.Forms.TextBox();
            this.A1UpgradeAmmount = new System.Windows.Forms.Button();
            this.A1UpgradeInterval = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.A1IntervalTextBox = new System.Windows.Forms.TextBox();
            this.A1Timer = new System.Windows.Forms.Timer(this.components);
            this.A2IntervalTextBox = new System.Windows.Forms.TextBox();
            this.A2UpgradeInterval = new System.Windows.Forms.Button();
            this.A2Timer = new System.Windows.Forms.Timer(this.components);
            this.A3UpgradeInterval = new System.Windows.Forms.Button();
            this.A3IntervalTextBox = new System.Windows.Forms.TextBox();
            this.A3Time = new System.Windows.Forms.Timer(this.components);
            this.A2UpgradeAmmount = new System.Windows.Forms.Button();
            this.A2AmmountTextBox = new System.Windows.Forms.TextBox();
            this.A3UpgradeButton = new System.Windows.Forms.Button();
            this.A3AmmountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::clicker.Properties.Resources.images;
            this.button1.Location = new System.Drawing.Point(486, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 141);
            this.button1.TabIndex = 0;
            this.button1.Text = "click me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bitcoiny: $0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // upgradebutton
            // 
            this.upgradebutton.Location = new System.Drawing.Point(380, 358);
            this.upgradebutton.Name = "upgradebutton";
            this.upgradebutton.Size = new System.Drawing.Size(75, 58);
            this.upgradebutton.TabIndex = 2;
            this.upgradebutton.Text = "Upgrade";
            this.upgradebutton.UseVisualStyleBackColor = true;
            this.upgradebutton.Click += new System.EventHandler(this.upgradebutton_Click);
            // 
            // buttonLevelTextBox
            // 
            this.buttonLevelTextBox.Location = new System.Drawing.Point(355, 303);
            this.buttonLevelTextBox.Name = "buttonLevelTextBox";
            this.buttonLevelTextBox.Size = new System.Drawing.Size(100, 23);
            this.buttonLevelTextBox.TabIndex = 3;
            // 
            // A1AmmountTextBox
            // 
            this.A1AmmountTextBox.Location = new System.Drawing.Point(38, 22);
            this.A1AmmountTextBox.Name = "A1AmmountTextBox";
            this.A1AmmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.A1AmmountTextBox.TabIndex = 4;
            // 
            // A1UpgradeAmmount
            // 
            this.A1UpgradeAmmount.Location = new System.Drawing.Point(172, 22);
            this.A1UpgradeAmmount.Name = "A1UpgradeAmmount";
            this.A1UpgradeAmmount.Size = new System.Drawing.Size(164, 70);
            this.A1UpgradeAmmount.TabIndex = 5;
            this.A1UpgradeAmmount.Text = "ulepsz ilość";
            this.A1UpgradeAmmount.UseVisualStyleBackColor = true;
            this.A1UpgradeAmmount.Click += new System.EventHandler(this.A1UpgradeAmmount_Click);
            // 
            // A1UpgradeInterval
            // 
            this.A1UpgradeInterval.Location = new System.Drawing.Point(452, 21);
            this.A1UpgradeInterval.Name = "A1UpgradeInterval";
            this.A1UpgradeInterval.Size = new System.Drawing.Size(167, 71);
            this.A1UpgradeInterval.TabIndex = 6;
            this.A1UpgradeInterval.Text = "ulepsz częstotliwość";
            this.A1UpgradeInterval.UseVisualStyleBackColor = true;
            this.A1UpgradeInterval.Click += new System.EventHandler(this.A1UpgradeInterval_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "AutoUpgrade1";
            // 
            // A1IntervalTextBox
            // 
            this.A1IntervalTextBox.Location = new System.Drawing.Point(346, 32);
            this.A1IntervalTextBox.Name = "A1IntervalTextBox";
            this.A1IntervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.A1IntervalTextBox.TabIndex = 8;
            // 
            // A1Timer
            // 
            this.A1Timer.Tick += new System.EventHandler(this.A1Tick);
            // 
            // A2IntervalTextBox
            // 
            this.A2IntervalTextBox.Location = new System.Drawing.Point(346, 126);
            this.A2IntervalTextBox.Name = "A2IntervalTextBox";
            this.A2IntervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.A2IntervalTextBox.TabIndex = 10;
            this.A2IntervalTextBox.TextChanged += new System.EventHandler(this.A2IntervalTextBox_TextChanged);
            // 
            // A2UpgradeInterval
            // 
            this.A2UpgradeInterval.Location = new System.Drawing.Point(453, 98);
            this.A2UpgradeInterval.Name = "A2UpgradeInterval";
            this.A2UpgradeInterval.Size = new System.Drawing.Size(166, 77);
            this.A2UpgradeInterval.TabIndex = 11;
            this.A2UpgradeInterval.Text = "ulepsz częstotliwość ";
            this.A2UpgradeInterval.UseVisualStyleBackColor = true;
            this.A2UpgradeInterval.Click += new System.EventHandler(this.A2UpgradeInterval_Click);
            // 
            // A2Timer
            // 
            this.A2Timer.Tick += new System.EventHandler(this.A2Tick);
            // 
            // A3UpgradeInterval
            // 
            this.A3UpgradeInterval.Location = new System.Drawing.Point(453, 181);
            this.A3UpgradeInterval.Name = "A3UpgradeInterval";
            this.A3UpgradeInterval.Size = new System.Drawing.Size(166, 79);
            this.A3UpgradeInterval.TabIndex = 12;
            this.A3UpgradeInterval.Text = "ulepsz częstotliwość";
            this.A3UpgradeInterval.UseVisualStyleBackColor = true;
            this.A3UpgradeInterval.Click += new System.EventHandler(this.A3UpgradeInterval_Click);
            // 
            // A3IntervalTextBox
            // 
            this.A3IntervalTextBox.Location = new System.Drawing.Point(346, 210);
            this.A3IntervalTextBox.Name = "A3IntervalTextBox";
            this.A3IntervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.A3IntervalTextBox.TabIndex = 13;
            this.A3IntervalTextBox.TextChanged += new System.EventHandler(this.A3IntervalTextBox_TextChanged);
            // 
            // A3Time
            // 
            this.A3Time.Tick += new System.EventHandler(this.A3Tick);
            // 
            // A2UpgradeAmmount
            // 
            this.A2UpgradeAmmount.Location = new System.Drawing.Point(170, 99);
            this.A2UpgradeAmmount.Name = "A2UpgradeAmmount";
            this.A2UpgradeAmmount.Size = new System.Drawing.Size(166, 76);
            this.A2UpgradeAmmount.TabIndex = 14;
            this.A2UpgradeAmmount.Text = "ulepsz szybkosc";
            this.A2UpgradeAmmount.UseVisualStyleBackColor = true;
            this.A2UpgradeAmmount.Click += new System.EventHandler(this.A2UpgradeAmmount_Click);
            // 
            // A2AmmountTextBox
            // 
            this.A2AmmountTextBox.Location = new System.Drawing.Point(38, 126);
            this.A2AmmountTextBox.Name = "A2AmmountTextBox";
            this.A2AmmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.A2AmmountTextBox.TabIndex = 15;
            this.A2AmmountTextBox.TextChanged += new System.EventHandler(this.A2AmmountTextBox_TextChanged);
            // 
            // A3UpgradeButton
            // 
            this.A3UpgradeButton.Location = new System.Drawing.Point(170, 181);
            this.A3UpgradeButton.Name = "A3UpgradeButton";
            this.A3UpgradeButton.Size = new System.Drawing.Size(166, 80);
            this.A3UpgradeButton.TabIndex = 16;
            this.A3UpgradeButton.Text = "ulepsz ilość ";
            this.A3UpgradeButton.UseVisualStyleBackColor = true;
            this.A3UpgradeButton.Click += new System.EventHandler(this.A3UpgradeButton_Click);
            // 
            // A3AmmountTextBox
            // 
            this.A3AmmountTextBox.Location = new System.Drawing.Point(38, 210);
            this.A3AmmountTextBox.Name = "A3AmmountTextBox";
            this.A3AmmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.A3AmmountTextBox.TabIndex = 17;
            this.A3AmmountTextBox.TextChanged += new System.EventHandler(this.A3AmmountTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::clicker.Properties.Resources.Oc_k9kuTURBXy9mOTE0MTFhYi0yZTc2LTQ2YTAtYmVjNC1mMjNmZDVlN2QwZGYuanBlZ5GVAs0DBwDDw4GhMAE;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.A3AmmountTextBox);
            this.Controls.Add(this.A3UpgradeButton);
            this.Controls.Add(this.A2AmmountTextBox);
            this.Controls.Add(this.A2UpgradeAmmount);
            this.Controls.Add(this.A3IntervalTextBox);
            this.Controls.Add(this.A3UpgradeInterval);
            this.Controls.Add(this.A2UpgradeInterval);
            this.Controls.Add(this.A2IntervalTextBox);
            this.Controls.Add(this.A1IntervalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.A1UpgradeInterval);
            this.Controls.Add(this.A1UpgradeAmmount);
            this.Controls.Add(this.A1AmmountTextBox);
            this.Controls.Add(this.buttonLevelTextBox);
            this.Controls.Add(this.upgradebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button upgradebutton;
        private TextBox buttonLevelTextBox;
        private TextBox A1AmmountTextBox;
        private Button A1UpgradeAmmount;
        private Button A1UpgradeInterval;
        private Label label2;
        private TextBox A1IntervalTextBox;
        private System.Windows.Forms.Timer A1Timer;
        private TextBox A2IntervalTextBox;
        private Button A2UpgradeInterval;
        private System.Windows.Forms.Timer A2Timer;
        private Button A3UpgradeInterval;
        private TextBox A3IntervalTextBox;
        private System.Windows.Forms.Timer A3Time;
        private Button A2UpgradeAmmount;
        private TextBox A2AmmountTextBox;
        private Button A3UpgradeButton;
        private TextBox A3AmmountTextBox;
    }
}