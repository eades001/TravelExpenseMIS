namespace TravelExpenseMIS
{
    partial class travelExpenseForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.autoGroupBox = new System.Windows.Forms.GroupBox();
            this.chevyRadioButton = new System.Windows.Forms.RadioButton();
            this.buickRadioButton = new System.Windows.Forms.RadioButton();
            this.routeGroupBox = new System.Windows.Forms.GroupBox();
            this.cityRadioButton = new System.Windows.Forms.RadioButton();
            this.freewayRadioButton = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.mileageLabel = new System.Windows.Forms.Label();
            this.totalMilesLabel = new System.Windows.Forms.Label();
            this.gasPriceLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.mileageValueLabel = new System.Windows.Forms.Label();
            this.totalMilesValueLabel = new System.Windows.Forms.Label();
            this.totalCostValueLabel = new System.Windows.Forms.Label();
            this.gasPriceTextBox = new System.Windows.Forms.TextBox();
            this.autoGroupBox.SuspendLayout();
            this.routeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(188, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(187, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Travel Expense";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Management Information System";
            // 
            // autoGroupBox
            // 
            this.autoGroupBox.BackColor = System.Drawing.Color.Tan;
            this.autoGroupBox.Controls.Add(this.chevyRadioButton);
            this.autoGroupBox.Controls.Add(this.buickRadioButton);
            this.autoGroupBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.autoGroupBox.Location = new System.Drawing.Point(50, 95);
            this.autoGroupBox.Name = "autoGroupBox";
            this.autoGroupBox.Size = new System.Drawing.Size(200, 124);
            this.autoGroupBox.TabIndex = 2;
            this.autoGroupBox.TabStop = false;
            this.autoGroupBox.Text = " Auto ";
            // 
            // chevyRadioButton
            // 
            this.chevyRadioButton.AutoSize = true;
            this.chevyRadioButton.Location = new System.Drawing.Point(20, 75);
            this.chevyRadioButton.Name = "chevyRadioButton";
            this.chevyRadioButton.Size = new System.Drawing.Size(142, 25);
            this.chevyRadioButton.TabIndex = 1;
            this.chevyRadioButton.Text = "Chevy Lumina";
            this.chevyRadioButton.UseVisualStyleBackColor = true;
            this.chevyRadioButton.CheckedChanged += new System.EventHandler(this.chevyRadioButton_CheckedChanged);
            // 
            // buickRadioButton
            // 
            this.buickRadioButton.AutoSize = true;
            this.buickRadioButton.Checked = true;
            this.buickRadioButton.Location = new System.Drawing.Point(20, 35);
            this.buickRadioButton.Name = "buickRadioButton";
            this.buickRadioButton.Size = new System.Drawing.Size(133, 25);
            this.buickRadioButton.TabIndex = 0;
            this.buickRadioButton.TabStop = true;
            this.buickRadioButton.Text = "Buick Electra";
            this.buickRadioButton.UseVisualStyleBackColor = true;
            this.buickRadioButton.CheckedChanged += new System.EventHandler(this.buickRadioButton_CheckedChanged);
            // 
            // routeGroupBox
            // 
            this.routeGroupBox.Controls.Add(this.cityRadioButton);
            this.routeGroupBox.Controls.Add(this.freewayRadioButton);
            this.routeGroupBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.routeGroupBox.Location = new System.Drawing.Point(50, 225);
            this.routeGroupBox.Name = "routeGroupBox";
            this.routeGroupBox.Size = new System.Drawing.Size(200, 124);
            this.routeGroupBox.TabIndex = 3;
            this.routeGroupBox.TabStop = false;
            this.routeGroupBox.Text = "Route";
            // 
            // cityRadioButton
            // 
            this.cityRadioButton.AutoSize = true;
            this.cityRadioButton.Location = new System.Drawing.Point(20, 77);
            this.cityRadioButton.Name = "cityRadioButton";
            this.cityRadioButton.Size = new System.Drawing.Size(59, 25);
            this.cityRadioButton.TabIndex = 1;
            this.cityRadioButton.Text = "City";
            this.cityRadioButton.UseVisualStyleBackColor = true;
            this.cityRadioButton.CheckedChanged += new System.EventHandler(this.cityRadioButton_CheckedChanged);
            // 
            // freewayRadioButton
            // 
            this.freewayRadioButton.AutoSize = true;
            this.freewayRadioButton.Checked = true;
            this.freewayRadioButton.Location = new System.Drawing.Point(20, 37);
            this.freewayRadioButton.Name = "freewayRadioButton";
            this.freewayRadioButton.Size = new System.Drawing.Size(97, 25);
            this.freewayRadioButton.TabIndex = 0;
            this.freewayRadioButton.TabStop = true;
            this.freewayRadioButton.Text = "Freeway";
            this.freewayRadioButton.UseVisualStyleBackColor = true;
            this.freewayRadioButton.CheckedChanged += new System.EventHandler(this.freewayRadioButton_CheckedChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Linen;
            this.calculateButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(50, 365);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(96, 43);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calc";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Linen;
            this.quitButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(153, 365);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(96, 43);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // mileageLabel
            // 
            this.mileageLabel.AutoSize = true;
            this.mileageLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.mileageLabel.Location = new System.Drawing.Point(309, 120);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(73, 21);
            this.mileageLabel.TabIndex = 6;
            this.mileageLabel.Text = "Mileage";
            // 
            // totalMilesLabel
            // 
            this.totalMilesLabel.AutoSize = true;
            this.totalMilesLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.totalMilesLabel.Location = new System.Drawing.Point(309, 173);
            this.totalMilesLabel.Name = "totalMilesLabel";
            this.totalMilesLabel.Size = new System.Drawing.Size(96, 21);
            this.totalMilesLabel.TabIndex = 7;
            this.totalMilesLabel.Text = "Total Miles";
            // 
            // gasPriceLabel
            // 
            this.gasPriceLabel.AutoSize = true;
            this.gasPriceLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gasPriceLabel.Location = new System.Drawing.Point(309, 255);
            this.gasPriceLabel.Name = "gasPriceLabel";
            this.gasPriceLabel.Size = new System.Drawing.Size(89, 21);
            this.gasPriceLabel.TabIndex = 8;
            this.gasPriceLabel.Text = "Gas Price";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(309, 316);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(91, 21);
            this.totalCostLabel.TabIndex = 9;
            this.totalCostLabel.Text = "Total Cost";
            // 
            // mileageValueLabel
            // 
            this.mileageValueLabel.AutoSize = true;
            this.mileageValueLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.mileageValueLabel.Location = new System.Drawing.Point(450, 120);
            this.mileageValueLabel.Name = "mileageValueLabel";
            this.mileageValueLabel.Size = new System.Drawing.Size(0, 21);
            this.mileageValueLabel.TabIndex = 10;
            // 
            // totalMilesValueLabel
            // 
            this.totalMilesValueLabel.AutoSize = true;
            this.totalMilesValueLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.totalMilesValueLabel.Location = new System.Drawing.Point(450, 173);
            this.totalMilesValueLabel.Name = "totalMilesValueLabel";
            this.totalMilesValueLabel.Size = new System.Drawing.Size(0, 21);
            this.totalMilesValueLabel.TabIndex = 11;
            // 
            // totalCostValueLabel
            // 
            this.totalCostValueLabel.AutoSize = true;
            this.totalCostValueLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.totalCostValueLabel.Location = new System.Drawing.Point(434, 314);
            this.totalCostValueLabel.Name = "totalCostValueLabel";
            this.totalCostValueLabel.Size = new System.Drawing.Size(0, 23);
            this.totalCostValueLabel.TabIndex = 13;
            // 
            // gasPriceTextBox
            // 
            this.gasPriceTextBox.BackColor = System.Drawing.Color.Linen;
            this.gasPriceTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gasPriceTextBox.Location = new System.Drawing.Point(438, 252);
            this.gasPriceTextBox.Name = "gasPriceTextBox";
            this.gasPriceTextBox.Size = new System.Drawing.Size(67, 28);
            this.gasPriceTextBox.TabIndex = 1;
            this.gasPriceTextBox.TextChanged += new System.EventHandler(this.gasPriceTextBox_TextChanged);
            this.gasPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gasPriceTextBox_KeyPress);
            // 
            // travelExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.gasPriceTextBox);
            this.Controls.Add(this.totalCostValueLabel);
            this.Controls.Add(this.totalMilesValueLabel);
            this.Controls.Add(this.mileageValueLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.gasPriceLabel);
            this.Controls.Add(this.totalMilesLabel);
            this.Controls.Add(this.mileageLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.routeGroupBox);
            this.Controls.Add(this.autoGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "travelExpenseForm";
            this.Text = "Travel Expense System";
            this.autoGroupBox.ResumeLayout(false);
            this.autoGroupBox.PerformLayout();
            this.routeGroupBox.ResumeLayout(false);
            this.routeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox autoGroupBox;
        private System.Windows.Forms.RadioButton chevyRadioButton;
        private System.Windows.Forms.RadioButton buickRadioButton;
        private System.Windows.Forms.GroupBox routeGroupBox;
        private System.Windows.Forms.RadioButton cityRadioButton;
        private System.Windows.Forms.RadioButton freewayRadioButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label mileageLabel;
        private System.Windows.Forms.Label totalMilesLabel;
        private System.Windows.Forms.Label gasPriceLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label mileageValueLabel;
        private System.Windows.Forms.Label totalMilesValueLabel;
        private System.Windows.Forms.Label totalCostValueLabel;
        private System.Windows.Forms.TextBox gasPriceTextBox;
    }
}

