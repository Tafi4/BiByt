namespace BiByt
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            pictureBox1 = new PictureBox();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            TransactionsButton = new Button();
            AddTransactionButton = new Button();
            ExpensesButton = new Button();
            IncomeButton = new Button();
            listBox1 = new ListBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(14, 891);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1574, -2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 866);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 46);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 22;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(271, 34);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(608, 75);
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(247, 166, 0);
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(1350, 46);
            button1.Name = "button1";
            button1.Size = new Size(185, 52);
            button1.TabIndex = 24;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(247, 166, 0);
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(1008, 46);
            button2.Name = "button2";
            button2.Size = new Size(245, 52);
            button2.TabIndex = 25;
            button2.Text = "Пожертвовать";
            button2.UseVisualStyleBackColor = false;
            // 
            // chart1
            // 
            chart1.AccessibleRole = AccessibleRole.ScrollBar;
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(42, 145);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            chart1.Series.Add(series2);
            chart1.Size = new Size(392, 533);
            chart1.TabIndex = 29;
            chart1.Text = "chart1";
            // 
            // TransactionsButton
            // 
            TransactionsButton.BackColor = Color.FromArgb(247, 166, 0);
            TransactionsButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TransactionsButton.Location = new Point(82, 735);
            TransactionsButton.Name = "TransactionsButton";
            TransactionsButton.Size = new Size(303, 62);
            TransactionsButton.TabIndex = 36;
            TransactionsButton.Text = "Транзакции";
            TransactionsButton.UseVisualStyleBackColor = false;
            TransactionsButton.Click += TransactionsButton_Click;
            // 
            // AddTransactionButton
            // 
            AddTransactionButton.BackColor = Color.FromArgb(247, 166, 0);
            AddTransactionButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddTransactionButton.Location = new Point(1194, 735);
            AddTransactionButton.Name = "AddTransactionButton";
            AddTransactionButton.Size = new Size(303, 62);
            AddTransactionButton.TabIndex = 37;
            AddTransactionButton.Text = "Добавить тразакцию";
            AddTransactionButton.UseVisualStyleBackColor = false;
            AddTransactionButton.Click += AddTransactionButton_Click;
            // 
            // ExpensesButton
            // 
            ExpensesButton.BackColor = Color.FromArgb(247, 166, 0);
            ExpensesButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ExpensesButton.Location = new Point(829, 735);
            ExpensesButton.Name = "ExpensesButton";
            ExpensesButton.Size = new Size(303, 62);
            ExpensesButton.TabIndex = 38;
            ExpensesButton.Text = "Расходы";
            ExpensesButton.UseVisualStyleBackColor = false;
            ExpensesButton.Click += ExpensesButton_Click;
            // 
            // IncomeButton
            // 
            IncomeButton.BackColor = Color.FromArgb(247, 166, 0);
            IncomeButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            IncomeButton.Location = new Point(446, 735);
            IncomeButton.Name = "IncomeButton";
            IncomeButton.Size = new Size(303, 62);
            IncomeButton.TabIndex = 39;
            IncomeButton.Text = "Доходы";
            IncomeButton.UseVisualStyleBackColor = false;
            IncomeButton.Click += IncomeButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(680, 149);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(868, 529);
            listBox1.TabIndex = 40;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-1, -2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1585, 18);
            pictureBox4.TabIndex = 41;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(-1, 702);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(1585, 18);
            pictureBox6.TabIndex = 42;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 831);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(1585, 18);
            pictureBox7.TabIndex = 43;
            pictureBox7.TabStop = false;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(1584, 861);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(listBox1);
            Controls.Add(IncomeButton);
            Controls.Add(ExpensesButton);
            Controls.Add(AddTransactionButton);
            Controls.Add(TransactionsButton);
            Controls.Add(chart1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox5);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "menu";
            Text = "Form1";
            Load += menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox5;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button TransactionsButton;
        private Button AddTransactionButton;
        private Button ExpensesButton;
        private Button IncomeButton;
        private ListBox listBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}