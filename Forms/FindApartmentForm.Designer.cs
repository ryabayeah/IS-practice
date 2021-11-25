
namespace IS_Lab_1
{
    partial class FindApartmentForm
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
            this.ParkingCheckBox = new System.Windows.Forms.CheckBox();
            this.CountOfRoomsComboBox = new System.Windows.Forms.ComboBox();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.FloorComboBox = new System.Windows.Forms.ComboBox();
            this.MaterialsComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.InfastuctureComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.YearsComboBox = new System.Windows.Forms.ComboBox();
            this.SquareComboBox = new System.Windows.Forms.ComboBox();
            this.PriceComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SquareLabel = new System.Windows.Forms.Label();
            this.ChoosePriceLabel = new System.Windows.Forms.Label();
            this.ComfortCheckBox = new System.Windows.Forms.CheckBox();
            this.ViewCheckBox = new System.Windows.Forms.CheckBox();
            this.TransportСheckBox = new System.Windows.Forms.CheckBox();
            this.NewOrOldcheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.Snow;
            this.NextButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(814, 376);
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
            this.GoBackButton.Location = new System.Drawing.Point(12, 376);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(109, 33);
            this.GoBackButton.TabIndex = 20;
            this.GoBackButton.Text = "Назад";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewOrOldcheckBox);
            this.panel1.Controls.Add(this.TransportСheckBox);
            this.panel1.Controls.Add(this.ViewCheckBox);
            this.panel1.Controls.Add(this.ComfortCheckBox);
            this.panel1.Controls.Add(this.ParkingCheckBox);
            this.panel1.Controls.Add(this.CountOfRoomsComboBox);
            this.panel1.Controls.Add(this.LocationComboBox);
            this.panel1.Controls.Add(this.FloorComboBox);
            this.panel1.Controls.Add(this.MaterialsComboBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.InfastuctureComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.YearsComboBox);
            this.panel1.Controls.Add(this.SquareComboBox);
            this.panel1.Controls.Add(this.PriceComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SquareLabel);
            this.panel1.Controls.Add(this.ChoosePriceLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 338);
            this.panel1.TabIndex = 19;
            // 
            // ParkingCheckBox
            // 
            this.ParkingCheckBox.AutoSize = true;
            this.ParkingCheckBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.ParkingCheckBox.Location = new System.Drawing.Point(643, 106);
            this.ParkingCheckBox.Name = "ParkingCheckBox";
            this.ParkingCheckBox.Size = new System.Drawing.Size(114, 28);
            this.ParkingCheckBox.TabIndex = 16;
            this.ParkingCheckBox.Text = "Парковка";
            this.ParkingCheckBox.UseVisualStyleBackColor = true;
            this.ParkingCheckBox.CheckedChanged += new System.EventHandler(this.ParkingCheckBox_CheckedChanged);
            // 
            // CountOfRoomsComboBox
            // 
            this.CountOfRoomsComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountOfRoomsComboBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CountOfRoomsComboBox.FormattingEnabled = true;
            this.CountOfRoomsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            ">4"});
            this.CountOfRoomsComboBox.Location = new System.Drawing.Point(332, 121);
            this.CountOfRoomsComboBox.Name = "CountOfRoomsComboBox";
            this.CountOfRoomsComboBox.Size = new System.Drawing.Size(211, 29);
            this.CountOfRoomsComboBox.TabIndex = 13;
            this.CountOfRoomsComboBox.Text = "Укажите количество комнат...";
            this.CountOfRoomsComboBox.SelectedIndexChanged += new System.EventHandler(this.CountOfRoomsComboBox_SelectedIndexChanged);
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationComboBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Items.AddRange(new object[] {
            "В городе",
            "За городом"});
            this.LocationComboBox.Location = new System.Drawing.Point(332, 294);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(211, 29);
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
            "Первый этаж",
            "От второго до предпоследнего",
            "Последний этаж"});
            this.FloorComboBox.Location = new System.Drawing.Point(332, 206);
            this.FloorComboBox.Name = "FloorComboBox";
            this.FloorComboBox.Size = new System.Drawing.Size(211, 29);
            this.FloorComboBox.TabIndex = 15;
            this.FloorComboBox.Text = "Укажите этаж...";
            this.FloorComboBox.UseWaitCursor = true;
            this.FloorComboBox.SelectedIndexChanged += new System.EventHandler(this.FloorComboBox_SelectedIndexChanged);
            // 
            // MaterialsComboBox
            // 
            this.MaterialsComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialsComboBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MaterialsComboBox.FormattingEnabled = true;
            this.MaterialsComboBox.Items.AddRange(new object[] {
            "Панельный",
            "Кирпичный",
            "Монолитный"});
            this.MaterialsComboBox.Location = new System.Drawing.Point(332, 44);
            this.MaterialsComboBox.Name = "MaterialsComboBox";
            this.MaterialsComboBox.Size = new System.Drawing.Size(211, 29);
            this.MaterialsComboBox.TabIndex = 12;
            this.MaterialsComboBox.Text = "Укажите тип постройки...";
            this.MaterialsComboBox.SelectedIndexChanged += new System.EventHandler(this.MaterialsComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(332, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Расположение";
            // 
            // InfastuctureComboBox
            // 
            this.InfastuctureComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfastuctureComboBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.InfastuctureComboBox.FormattingEnabled = true;
            this.InfastuctureComboBox.Items.AddRange(new object[] {
            "Развитая",
            "Неразвитая"});
            this.InfastuctureComboBox.Location = new System.Drawing.Point(21, 294);
            this.InfastuctureComboBox.Name = "InfastuctureComboBox";
            this.InfastuctureComboBox.Size = new System.Drawing.Size(211, 29);
            this.InfastuctureComboBox.TabIndex = 11;
            this.InfastuctureComboBox.Text = "Укажите инфраструктуру...";
            this.InfastuctureComboBox.SelectedIndexChanged += new System.EventHandler(this.InfastuctureComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(332, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Количество комнат";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(332, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Этаж";
            // 
            // YearsComboBox
            // 
            this.YearsComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearsComboBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.YearsComboBox.FormattingEnabled = true;
            this.YearsComboBox.Items.AddRange(new object[] {
            "Еще строится",
            "меньше 10 лет",
            "10-15 лет",
            "15-30 лет",
            "больше 30 лет"});
            this.YearsComboBox.Location = new System.Drawing.Point(21, 206);
            this.YearsComboBox.Name = "YearsComboBox";
            this.YearsComboBox.Size = new System.Drawing.Size(211, 29);
            this.YearsComboBox.TabIndex = 10;
            this.YearsComboBox.Text = "Укажите возраст здания...";
            this.YearsComboBox.SelectedIndexChanged += new System.EventHandler(this.YearsComboBox_SelectedIndexChanged);
            // 
            // SquareComboBox
            // 
            this.SquareComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SquareComboBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SquareComboBox.FormattingEnabled = true;
            this.SquareComboBox.Items.AddRange(new object[] {
            "< 50",
            "50 - 100",
            "> 100"});
            this.SquareComboBox.Location = new System.Drawing.Point(21, 121);
            this.SquareComboBox.Name = "SquareComboBox";
            this.SquareComboBox.Size = new System.Drawing.Size(211, 29);
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
            "1000000 <",
            "1000000 - 2000000",
            "2000000 - 3000000",
            "> 3000000"});
            this.PriceComboBox.Location = new System.Drawing.Point(21, 44);
            this.PriceComboBox.Name = "PriceComboBox";
            this.PriceComboBox.Size = new System.Drawing.Size(211, 29);
            this.PriceComboBox.TabIndex = 8;
            this.PriceComboBox.Text = "Укажите бюджет...";
            this.PriceComboBox.SelectedIndexChanged += new System.EventHandler(this.PriceComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(332, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип постройки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Инфраструктура";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Возраст здания";
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
            // ComfortCheckBox
            // 
            this.ComfortCheckBox.AutoSize = true;
            this.ComfortCheckBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.ComfortCheckBox.Location = new System.Drawing.Point(643, 168);
            this.ComfortCheckBox.Name = "ComfortCheckBox";
            this.ComfortCheckBox.Size = new System.Drawing.Size(177, 28);
            this.ComfortCheckBox.TabIndex = 17;
            this.ComfortCheckBox.Text = "Наличие удобств";
            this.ComfortCheckBox.UseVisualStyleBackColor = true;
            this.ComfortCheckBox.CheckedChanged += new System.EventHandler(this.ComfortCheckBox_CheckedChanged);
            // 
            // ViewCheckBox
            // 
            this.ViewCheckBox.AutoSize = true;
            this.ViewCheckBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.ViewCheckBox.Location = new System.Drawing.Point(643, 230);
            this.ViewCheckBox.Name = "ViewCheckBox";
            this.ViewCheckBox.Size = new System.Drawing.Size(154, 28);
            this.ViewCheckBox.TabIndex = 18;
            this.ViewCheckBox.Text = "Красивый вид";
            this.ViewCheckBox.UseVisualStyleBackColor = true;
            this.ViewCheckBox.CheckedChanged += new System.EventHandler(this.ViewCheckBox_CheckedChanged);
            // 
            // TransportСheckBox
            // 
            this.TransportСheckBox.AutoSize = true;
            this.TransportСheckBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.TransportСheckBox.Location = new System.Drawing.Point(643, 292);
            this.TransportСheckBox.Name = "TransportСheckBox";
            this.TransportСheckBox.Size = new System.Drawing.Size(260, 28);
            this.TransportСheckBox.TabIndex = 19;
            this.TransportСheckBox.Text = "Транспортная доступность";
            this.TransportСheckBox.UseVisualStyleBackColor = true;
            this.TransportСheckBox.CheckedChanged += new System.EventHandler(this.TransportСheckBox_CheckedChanged);
            // 
            // NewOrOldcheckBox
            // 
            this.NewOrOldcheckBox.AutoSize = true;
            this.NewOrOldcheckBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.NewOrOldcheckBox.Location = new System.Drawing.Point(643, 44);
            this.NewOrOldcheckBox.Name = "NewOrOldcheckBox";
            this.NewOrOldcheckBox.Size = new System.Drawing.Size(144, 28);
            this.NewOrOldcheckBox.TabIndex = 20;
            this.NewOrOldcheckBox.Text = "Новостройка";
            this.NewOrOldcheckBox.UseVisualStyleBackColor = false;
            this.NewOrOldcheckBox.CheckedChanged += new System.EventHandler(this.NewOrOldcheckBox_CheckedChanged);
            // 
            // FindApartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 426);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.panel1);
            this.Name = "FindApartmentForm";
            this.Text = "Подбор квартиры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindApartmentForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ParkingCheckBox;
        private System.Windows.Forms.ComboBox CountOfRoomsComboBox;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.ComboBox FloorComboBox;
        private System.Windows.Forms.ComboBox MaterialsComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox InfastuctureComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox YearsComboBox;
        private System.Windows.Forms.ComboBox SquareComboBox;
        private System.Windows.Forms.ComboBox PriceComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SquareLabel;
        private System.Windows.Forms.Label ChoosePriceLabel;
        private System.Windows.Forms.CheckBox NewOrOldcheckBox;
        private System.Windows.Forms.CheckBox TransportСheckBox;
        private System.Windows.Forms.CheckBox ViewCheckBox;
        private System.Windows.Forms.CheckBox ComfortCheckBox;
    }
}