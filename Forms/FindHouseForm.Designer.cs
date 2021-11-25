
namespace IS_Lab_1
{
    partial class FindHouseForm
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
            this.NextButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComunicationCheckBox = new System.Windows.Forms.CheckBox();
            this.TransportComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeOfHouseComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComfortCheckBox = new System.Windows.Forms.CheckBox();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.FloorComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SquareComboBox = new System.Windows.Forms.ComboBox();
            this.PriceComboBox = new System.Windows.Forms.ComboBox();
            this.SquareLabel = new System.Windows.Forms.Label();
            this.ChoosePriceLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.Snow;
            this.NextButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(775, 290);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(109, 33);
            this.NextButton.TabIndex = 21;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.Color.Snow;
            this.GoBackButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoBackButton.Location = new System.Drawing.Point(12, 290);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(109, 33);
            this.GoBackButton.TabIndex = 20;
            this.GoBackButton.Text = "Назад";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ComunicationCheckBox);
            this.panel1.Controls.Add(this.TransportComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TypeOfHouseComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ComfortCheckBox);
            this.panel1.Controls.Add(this.LocationComboBox);
            this.panel1.Controls.Add(this.FloorComboBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SquareComboBox);
            this.panel1.Controls.Add(this.PriceComboBox);
            this.panel1.Controls.Add(this.SquareLabel);
            this.panel1.Controls.Add(this.ChoosePriceLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 256);
            this.panel1.TabIndex = 19;
            // 
            // ComunicationCheckBox
            // 
            this.ComunicationCheckBox.AutoSize = true;
            this.ComunicationCheckBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.ComunicationCheckBox.Location = new System.Drawing.Point(643, 127);
            this.ComunicationCheckBox.Name = "ComunicationCheckBox";
            this.ComunicationCheckBox.Size = new System.Drawing.Size(149, 28);
            this.ComunicationCheckBox.TabIndex = 21;
            this.ComunicationCheckBox.Text = "Комуникация";
            this.ComunicationCheckBox.UseVisualStyleBackColor = true;
            this.ComunicationCheckBox.CheckedChanged += new System.EventHandler(this.ComunicationCheckBox_CheckedChanged);
            // 
            // TransportComboBox
            // 
            this.TransportComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportComboBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TransportComboBox.FormattingEnabled = true;
            this.TransportComboBox.Items.AddRange(new object[] {
            "Развитая",
            "Неразвитая"});
            this.TransportComboBox.Location = new System.Drawing.Point(332, 205);
            this.TransportComboBox.Name = "TransportComboBox";
            this.TransportComboBox.Size = new System.Drawing.Size(240, 29);
            this.TransportComboBox.TabIndex = 20;
            this.TransportComboBox.Text = "Укажите транспортную доступность...";
            this.TransportComboBox.SelectedIndexChanged += new System.EventHandler(this.TransportComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(332, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Транспортная доступность";
            // 
            // TypeOfHouseComboBox
            // 
            this.TypeOfHouseComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeOfHouseComboBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TypeOfHouseComboBox.FormattingEnabled = true;
            this.TypeOfHouseComboBox.Items.AddRange(new object[] {
            "Деревянный",
            "Кирпичный",
            "Бревенчатый"});
            this.TypeOfHouseComboBox.Location = new System.Drawing.Point(332, 127);
            this.TypeOfHouseComboBox.Name = "TypeOfHouseComboBox";
            this.TypeOfHouseComboBox.Size = new System.Drawing.Size(240, 29);
            this.TypeOfHouseComboBox.TabIndex = 18;
            this.TypeOfHouseComboBox.Text = "Укажите тип дома...";
            this.TypeOfHouseComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeOfHouseComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(332, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Тип дома";
            // 
            // ComfortCheckBox
            // 
            this.ComfortCheckBox.AutoSize = true;
            this.ComfortCheckBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.ComfortCheckBox.Location = new System.Drawing.Point(643, 44);
            this.ComfortCheckBox.Name = "ComfortCheckBox";
            this.ComfortCheckBox.Size = new System.Drawing.Size(177, 28);
            this.ComfortCheckBox.TabIndex = 16;
            this.ComfortCheckBox.Text = "Наличие удобств";
            this.ComfortCheckBox.UseVisualStyleBackColor = true;
            this.ComfortCheckBox.CheckedChanged += new System.EventHandler(this.ComfortCheckBox_CheckedChanged);
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationComboBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Items.AddRange(new object[] {
            "В городе",
            "За городом"});
            this.LocationComboBox.Location = new System.Drawing.Point(21, 205);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(240, 29);
            this.LocationComboBox.TabIndex = 14;
            this.LocationComboBox.Text = "Укажите расположение...";
            this.LocationComboBox.SelectedIndexChanged += new System.EventHandler(this.LocationComboBox_SelectedIndexChanged);
            // 
            // FloorComboBox
            // 
            this.FloorComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FloorComboBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FloorComboBox.FormattingEnabled = true;
            this.FloorComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            ">4"});
            this.FloorComboBox.Location = new System.Drawing.Point(332, 44);
            this.FloorComboBox.Name = "FloorComboBox";
            this.FloorComboBox.Size = new System.Drawing.Size(240, 29);
            this.FloorComboBox.TabIndex = 15;
            this.FloorComboBox.Text = "Укажите количество этажей...";
            this.FloorComboBox.UseWaitCursor = true;
            this.FloorComboBox.SelectedIndexChanged += new System.EventHandler(this.FloorComboBox_SelectedIndexChanged);
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
            this.label5.Location = new System.Drawing.Point(332, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Количество этажей";
            // 
            // SquareComboBox
            // 
            this.SquareComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SquareComboBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SquareComboBox.FormattingEnabled = true;
            this.SquareComboBox.Items.AddRange(new object[] {
            "< 80",
            "80 - 150",
            ">150"});
            this.SquareComboBox.Location = new System.Drawing.Point(21, 127);
            this.SquareComboBox.Name = "SquareComboBox";
            this.SquareComboBox.Size = new System.Drawing.Size(240, 29);
            this.SquareComboBox.TabIndex = 9;
            this.SquareComboBox.Text = "Укажите площадь...";
            this.SquareComboBox.SelectedIndexChanged += new System.EventHandler(this.SquareComboBox_SelectedIndexChanged);
            // 
            // PriceComboBox
            // 
            this.PriceComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceComboBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.PriceComboBox.FormattingEnabled = true;
            this.PriceComboBox.Items.AddRange(new object[] {
            "< 1000000",
            "1000000 - 3000000",
            "3000000 - 6000000",
            "> 6000000"});
            this.PriceComboBox.Location = new System.Drawing.Point(21, 44);
            this.PriceComboBox.Name = "PriceComboBox";
            this.PriceComboBox.Size = new System.Drawing.Size(240, 29);
            this.PriceComboBox.TabIndex = 8;
            this.PriceComboBox.Text = "Укажите бюджет...";
            this.PriceComboBox.SelectedIndexChanged += new System.EventHandler(this.PriceComboBox_SelectedIndexChanged);
            // 
            // SquareLabel
            // 
            this.SquareLabel.AutoSize = true;
            this.SquareLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SquareLabel.Location = new System.Drawing.Point(21, 100);
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
            // FindHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 334);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.panel1);
            this.Name = "FindHouseForm";
            this.Text = "Подбор дома";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindHouseForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ComfortCheckBox;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.ComboBox FloorComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SquareComboBox;
        private System.Windows.Forms.ComboBox PriceComboBox;
        private System.Windows.Forms.Label SquareLabel;
        private System.Windows.Forms.Label ChoosePriceLabel;
        private System.Windows.Forms.ComboBox TypeOfHouseComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ComunicationCheckBox;
        private System.Windows.Forms.ComboBox TransportComboBox;
        private System.Windows.Forms.Label label2;
    }
}