namespace Lab_18
{
    partial class Application
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
            this.LabelLenght = new System.Windows.Forms.Label();
            this.TextLenght = new System.Windows.Forms.TextBox();
            this.EnterR = new System.Windows.Forms.Button();
            this.LabelRadVpis = new System.Windows.Forms.Label();
            this.LabelS = new System.Windows.Forms.Label();
            this.LabelRadOpis = new System.Windows.Forms.Label();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.textBoxVpis = new System.Windows.Forms.TextBox();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelLenght
            // 
            this.LabelLenght.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLenght.Location = new System.Drawing.Point(0, 0);
            this.LabelLenght.Name = "LabelLenght";
            this.LabelLenght.Size = new System.Drawing.Size(800, 32);
            this.LabelLenght.TabIndex = 0;
            this.LabelLenght.Text = "Длинна стороны равностороннего треугольника:";
            this.LabelLenght.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelLenght.Click += new System.EventHandler(this.LabelLenght_Click);
            // 
            // TextLenght
            // 
            this.TextLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLenght.Location = new System.Drawing.Point(334, 70);
            this.TextLenght.Name = "TextLenght";
            this.TextLenght.Size = new System.Drawing.Size(131, 26);
            this.TextLenght.TabIndex = 1;
            this.TextLenght.TextChanged += new System.EventHandler(this.TextLenght_TextChanged);
            // 
            // EnterR
            // 
            this.EnterR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterR.Location = new System.Drawing.Point(334, 156);
            this.EnterR.Name = "EnterR";
            this.EnterR.Size = new System.Drawing.Size(131, 51);
            this.EnterR.TabIndex = 2;
            this.EnterR.Text = "Рассчитать";
            this.EnterR.UseVisualStyleBackColor = true;
            this.EnterR.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelRadVpis
            // 
            this.LabelRadVpis.AutoSize = true;
            this.LabelRadVpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRadVpis.Location = new System.Drawing.Point(12, 265);
            this.LabelRadVpis.Name = "LabelRadVpis";
            this.LabelRadVpis.Size = new System.Drawing.Size(243, 20);
            this.LabelRadVpis.TabIndex = 3;
            this.LabelRadVpis.Text = "Радиус вписанной окружности:";
            this.LabelRadVpis.Click += new System.EventHandler(this.LabelRadVpis_Click);
            // 
            // LabelS
            // 
            this.LabelS.AutoSize = true;
            this.LabelS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelS.Location = new System.Drawing.Point(347, 265);
            this.LabelS.Name = "LabelS";
            this.LabelS.Size = new System.Drawing.Size(86, 20);
            this.LabelS.TabIndex = 4;
            this.LabelS.Text = "Площадь:";
            this.LabelS.Click += new System.EventHandler(this.LabelS_Click);
            // 
            // LabelRadOpis
            // 
            this.LabelRadOpis.AutoSize = true;
            this.LabelRadOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRadOpis.Location = new System.Drawing.Point(535, 265);
            this.LabelRadOpis.Name = "LabelRadOpis";
            this.LabelRadOpis.Size = new System.Drawing.Size(243, 20);
            this.LabelRadOpis.TabIndex = 5;
            this.LabelRadOpis.Text = "Радиус описанной окружности:";
            this.LabelRadOpis.Click += new System.EventHandler(this.LabelRadOpis_Click);
            // 
            // textBoxS
            // 
            this.textBoxS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxS.Location = new System.Drawing.Point(334, 322);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(124, 26);
            this.textBoxS.TabIndex = 6;
            this.textBoxS.TextChanged += new System.EventHandler(this.textBoxS_TextChanged);
            // 
            // textBoxVpis
            // 
            this.textBoxVpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVpis.Location = new System.Drawing.Point(72, 322);
            this.textBoxVpis.Name = "textBoxVpis";
            this.textBoxVpis.Size = new System.Drawing.Size(124, 26);
            this.textBoxVpis.TabIndex = 7;
            this.textBoxVpis.TextChanged += new System.EventHandler(this.textBoxVpis_TextChanged);
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOpis.Location = new System.Drawing.Point(588, 322);
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(124, 26);
            this.textBoxOpis.TabIndex = 8;
            this.textBoxOpis.TextChanged += new System.EventHandler(this.textBoxOpis_TextChanged);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.textBoxVpis);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.LabelRadOpis);
            this.Controls.Add(this.LabelS);
            this.Controls.Add(this.LabelRadVpis);
            this.Controls.Add(this.EnterR);
            this.Controls.Add(this.TextLenght);
            this.Controls.Add(this.LabelLenght);
            this.Name = "Application";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLenght;
        private System.Windows.Forms.TextBox TextLenght;
        private System.Windows.Forms.Button EnterR;
        private System.Windows.Forms.Label LabelRadVpis;
        private System.Windows.Forms.Label LabelS;
        private System.Windows.Forms.Label LabelRadOpis;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.TextBox textBoxVpis;
        private System.Windows.Forms.TextBox textBoxOpis;
    }
}

