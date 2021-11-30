
namespace IS_Lab_1
{
    partial class FindSteadForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.EcologyCheckBox = new System.Windows.Forms.CheckBox();
            this.TransportCheckBox = new System.Windows.Forms.CheckBox();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.NearTeritotyComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SquareComboBox = new System.Windows.Forms.ComboBox();
            this.PriceComboBox = new System.Windows.Forms.ComboBox();
            this.SquareLabel = new System.Windows.Forms.Label();
            this.ChoosePriceLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EcologyCheckBox);
            this.panel1.Controls.Add(this.TransportCheckBox);
            this.panel1.Controls.Add(this.LocationComboBox);
            this.panel1.Controls.Add(this.NearTeritotyComboBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SquareComboBox);
            this.panel1.Controls.Add(this.PriceComboBox);
            this.panel1.Controls.Add(this.SquareLabel);
            this.panel1.Controls.Add(this.ChoosePriceLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 256);
            this.panel1.TabIndex = 3;
            // 
            // EcologyCheckBox
            // 
            this.EcologyCheckBox.AutoSize = true;
            this.EcologyCheckBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.EcologyCheckBox.Location = new System.Drawing.Point(328, 205);
            this.EcologyCheckBox.Name = "EcologyCheckBox";
            this.EcologyCheckBox.Size = new System.Drawing.Size(227, 28);
            this.EcologyCheckBox.TabIndex = 17;
            this.EcologyCheckBox.Text = "Экологическая чистота";
            this.EcologyCheckBox.UseVisualStyleBackColor = true;
            this.EcologyCheckBox.CheckedChanged += new System.EventHandler(this.EcologyCheckBox_CheckedChanged);
            // 
            // TransportCheckBox
            // 
            this.TransportCheckBox.AutoSize = true;
            this.TransportCheckBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.TransportCheckBox.Location = new System.Drawing.Point(328, 121);
            this.TransportCheckBox.Name = "TransportCheckBox";
            this.TransportCheckBox.Size = new System.Drawing.Size(260, 28);
            this.TransportCheckBox.TabIndex = 16;
            this.TransportCheckBox.Text = "Транспортная доступность";
            this.TransportCheckBox.UseVisualStyleBackColor = true;
            this.TransportCheckBox.CheckedChanged += new System.EventHandler(this.TransportCheckBox_CheckedChanged);
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationComboBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Items.AddRange(new object[] {
            "В пригороде",
            "В области"});
            this.LocationComboBox.Location = new System.Drawing.Point(21, 205);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(231, 29);
            this.LocationComboBox.TabIndex = 14;
            this.LocationComboBox.Text = "Укажите расположение...";
            this.LocationComboBox.SelectedIndexChanged += new System.EventHandler(this.LocationComboBox_SelectedIndexChanged);
            // 
            // NearTeritotyComboBox
            // 
            this.NearTeritotyComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NearTeritotyComboBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.NearTeritotyComboBox.FormattingEnabled = true;
            this.NearTeritotyComboBox.Items.AddRange(new object[] {
            "1-2",
            "3-5",
            ">5"});
            this.NearTeritotyComboBox.Location = new System.Drawing.Point(328, 44);
            this.NearTeritotyComboBox.Name = "NearTeritotyComboBox";
            this.NearTeritotyComboBox.Size = new System.Drawing.Size(231, 29);
            this.NearTeritotyComboBox.TabIndex = 15;
            this.NearTeritotyComboBox.Text = "Укажите прилегающую территорию...";
            this.NearTeritotyComboBox.UseWaitCursor = true;
            this.NearTeritotyComboBox.SelectedIndexChanged += new System.EventHandler(this.NearTeritotyComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(21, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Расположение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(328, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Прилежащая территория";
            // 
            // SquareComboBox
            // 
            this.SquareComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SquareComboBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.SquareComboBox.FormattingEnabled = true;
            this.SquareComboBox.Items.AddRange(new object[] {
            "< 1 га",
            "1 -5 га",
            "5 - 10 га",
            "> 10 га"});
            this.SquareComboBox.Location = new System.Drawing.Point(21, 121);
            this.SquareComboBox.Name = "SquareComboBox";
            this.SquareComboBox.Size = new System.Drawing.Size(231, 29);
            this.SquareComboBox.TabIndex = 9;
            this.SquareComboBox.Text = "Укажите площадь...";
            this.SquareComboBox.SelectedIndexChanged += new System.EventHandler(this.SquareComboBox_SelectedIndexChanged);
            // 
            // PriceComboBox
            // 
            this.PriceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriceComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceComboBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.PriceComboBox.FormattingEnabled = true;
            this.PriceComboBox.Items.AddRange(new object[] {
            "< 1000000",
            "1000000 - 2000000",
            "2000000 - 3000000",
            "> 3000000"});
            this.PriceComboBox.Location = new System.Drawing.Point(21, 44);
            this.PriceComboBox.Name = "PriceComboBox";
            this.PriceComboBox.Size = new System.Drawing.Size(231, 29);
            this.PriceComboBox.TabIndex = 8;
            this.PriceComboBox.SelectedIndexChanged += new System.EventHandler(this.PriceComboBox_SelectedIndexChanged);
            // 
            // SquareLabel
            // 
            this.SquareLabel.AutoSize = true;
            this.SquareLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SquareLabel.Location = new System.Drawing.Point(21, 94);
            this.SquareLabel.Name = "SquareLabel";
            this.SquareLabel.Size = new System.Drawing.Size(88, 24);
            this.SquareLabel.TabIndex = 1;
            this.SquareLabel.Text = "Площадь";
            // 
            // ChoosePriceLabel
            // 
            this.ChoosePriceLabel.AutoSize = true;
            this.ChoosePriceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoosePriceLabel.Location = new System.Drawing.Point(21, 17);
            this.ChoosePriceLabel.Name = "ChoosePriceLabel";
            this.ChoosePriceLabel.Size = new System.Drawing.Size(77, 24);
            this.ChoosePriceLabel.TabIndex = 0;
            this.ChoosePriceLabel.Text = "Бюджет";
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.Snow;
            this.NextButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(512, 285);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(109, 33);
            this.NextButton.TabIndex = 20;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.Color.Snow;
            this.GoBackButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoBackButton.Location = new System.Drawing.Point(12, 285);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(109, 33);
            this.GoBackButton.TabIndex = 19;
            this.GoBackButton.Text = "Назад";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // FindSteadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 336);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.panel1);
            this.Name = "FindSteadForm";
            this.Text = "Подбор земельного участка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindSteadForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox TransportCheckBox;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.ComboBox NearTeritotyComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SquareComboBox;
        private System.Windows.Forms.ComboBox PriceComboBox;
        private System.Windows.Forms.Label SquareLabel;
        private System.Windows.Forms.Label ChoosePriceLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.CheckBox EcologyCheckBox;
    }
}