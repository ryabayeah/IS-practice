
namespace IS_Lab_1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.officeButton = new System.Windows.Forms.Button();
            this.SteadButton = new System.Windows.Forms.Button();
            this.ApartmentButton = new System.Windows.Forms.Button();
            this.HouseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(244, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подбор недвижимости";
            // 
            // officeButton
            // 
            this.officeButton.BackColor = System.Drawing.Color.Snow;
            this.officeButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.officeButton.Location = new System.Drawing.Point(34, 96);
            this.officeButton.Name = "officeButton";
            this.officeButton.Size = new System.Drawing.Size(132, 62);
            this.officeButton.TabIndex = 1;
            this.officeButton.Text = "Офис";
            this.officeButton.UseVisualStyleBackColor = true;
            this.officeButton.Click += new System.EventHandler(this.officeButton_Click);
            // 
            // SteadButton
            // 
            this.SteadButton.BackColor = System.Drawing.Color.Snow;
            this.SteadButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SteadButton.Location = new System.Drawing.Point(211, 96);
            this.SteadButton.Name = "SteadButton";
            this.SteadButton.Size = new System.Drawing.Size(132, 62);
            this.SteadButton.TabIndex = 2;
            this.SteadButton.Text = "Земельный участок";
            this.SteadButton.UseVisualStyleBackColor = true;
            this.SteadButton.Click += new System.EventHandler(this.SteadButton_Click);
            // 
            // ApartmentButton
            // 
            this.ApartmentButton.BackColor = System.Drawing.Color.Snow;
            this.ApartmentButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApartmentButton.Location = new System.Drawing.Point(388, 96);
            this.ApartmentButton.Name = "ApartmentButton";
            this.ApartmentButton.Size = new System.Drawing.Size(132, 62);
            this.ApartmentButton.TabIndex = 3;
            this.ApartmentButton.Text = "Квартира";
            this.ApartmentButton.UseVisualStyleBackColor = true;
            this.ApartmentButton.Click += new System.EventHandler(this.ApartmentButton_Click);
            // 
            // HouseButton
            // 
            this.HouseButton.BackColor = System.Drawing.Color.Snow;
            this.HouseButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HouseButton.Location = new System.Drawing.Point(565, 96);
            this.HouseButton.Name = "HouseButton";
            this.HouseButton.Size = new System.Drawing.Size(132, 62);
            this.HouseButton.TabIndex = 4;
            this.HouseButton.Text = "Дом";
            this.HouseButton.UseVisualStyleBackColor = true;
            this.HouseButton.Click += new System.EventHandler(this.HouseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(728, 203);
            this.Controls.Add(this.HouseButton);
            this.Controls.Add(this.ApartmentButton);
            this.Controls.Add(this.SteadButton);
            this.Controls.Add(this.officeButton);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Подбор недвижимости";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button officeButton;
        private System.Windows.Forms.Button SteadButton;
        private System.Windows.Forms.Button ApartmentButton;
        private System.Windows.Forms.Button HouseButton;
    }
}

