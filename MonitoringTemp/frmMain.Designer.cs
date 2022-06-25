
namespace MonitoringTemp
{
    partial class frmMain
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
            this.lbFishName = new System.Windows.Forms.Label();
            this.lbMaxTemp = new System.Windows.Forms.Label();
            this.tbMaxTemp = new System.Windows.Forms.TextBox();
            this.lbMaxTempTime = new System.Windows.Forms.Label();
            this.tbMaxTempTime = new System.Windows.Forms.TextBox();
            this.tbMinTempTime = new System.Windows.Forms.TextBox();
            this.lbMinTempTime = new System.Windows.Forms.Label();
            this.tbMinTemp = new System.Windows.Forms.TextBox();
            this.lbMinTemp = new System.Windows.Forms.Label();
            this.tbDateTime = new System.Windows.Forms.TextBox();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.lbTemperature = new System.Windows.Forms.Label();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.tbFish = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbFishName
            // 
            this.lbFishName.AutoSize = true;
            this.lbFishName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFishName.Location = new System.Drawing.Point(18, 19);
            this.lbFishName.Name = "lbFishName";
            this.lbFishName.Size = new System.Drawing.Size(101, 25);
            this.lbFishName.TabIndex = 1;
            this.lbFishName.Text = "Вид рыбы:";
            // 
            // lbMaxTemp
            // 
            this.lbMaxTemp.AutoSize = true;
            this.lbMaxTemp.Location = new System.Drawing.Point(65, 59);
            this.lbMaxTemp.Name = "lbMaxTemp";
            this.lbMaxTemp.Size = new System.Drawing.Size(359, 20);
            this.lbMaxTemp.TabIndex = 2;
            this.lbMaxTemp.Text = "Максимально допустимая температура хранения:";
            // 
            // tbMaxTemp
            // 
            this.tbMaxTemp.Location = new System.Drawing.Point(472, 56);
            this.tbMaxTemp.Name = "tbMaxTemp";
            this.tbMaxTemp.Size = new System.Drawing.Size(125, 27);
            this.tbMaxTemp.TabIndex = 3;
            // 
            // lbMaxTempTime
            // 
            this.lbMaxTempTime.AutoSize = true;
            this.lbMaxTempTime.Location = new System.Drawing.Point(18, 98);
            this.lbMaxTempTime.Name = "lbMaxTempTime";
            this.lbMaxTempTime.Size = new System.Drawing.Size(444, 20);
            this.lbMaxTempTime.TabIndex = 4;
            this.lbMaxTempTime.Text = "Допустимое время превышения максимальной температуры:";
            // 
            // tbMaxTempTime
            // 
            this.tbMaxTempTime.Location = new System.Drawing.Point(472, 95);
            this.tbMaxTempTime.Name = "tbMaxTempTime";
            this.tbMaxTempTime.Size = new System.Drawing.Size(125, 27);
            this.tbMaxTempTime.TabIndex = 5;
            // 
            // tbMinTempTime
            // 
            this.tbMinTempTime.Location = new System.Drawing.Point(472, 174);
            this.tbMinTempTime.Name = "tbMinTempTime";
            this.tbMinTempTime.Size = new System.Drawing.Size(125, 27);
            this.tbMinTempTime.TabIndex = 9;
            // 
            // lbMinTempTime
            // 
            this.lbMinTempTime.AutoSize = true;
            this.lbMinTempTime.Location = new System.Drawing.Point(18, 177);
            this.lbMinTempTime.Name = "lbMinTempTime";
            this.lbMinTempTime.Size = new System.Drawing.Size(440, 20);
            this.lbMinTempTime.TabIndex = 8;
            this.lbMinTempTime.Text = "Допустимое время превышения минимальной температуры:";
            // 
            // tbMinTemp
            // 
            this.tbMinTemp.Location = new System.Drawing.Point(472, 135);
            this.tbMinTemp.Name = "tbMinTemp";
            this.tbMinTemp.Size = new System.Drawing.Size(125, 27);
            this.tbMinTemp.TabIndex = 7;
            // 
            // lbMinTemp
            // 
            this.lbMinTemp.AutoSize = true;
            this.lbMinTemp.Location = new System.Drawing.Point(65, 135);
            this.lbMinTemp.Name = "lbMinTemp";
            this.lbMinTemp.Size = new System.Drawing.Size(355, 20);
            this.lbMinTemp.TabIndex = 6;
            this.lbMinTemp.Text = "Минимально допустимая температура хранения:";
            // 
            // tbDateTime
            // 
            this.tbDateTime.Location = new System.Drawing.Point(472, 214);
            this.tbDateTime.Name = "tbDateTime";
            this.tbDateTime.Size = new System.Drawing.Size(125, 27);
            this.tbDateTime.TabIndex = 10;
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Location = new System.Drawing.Point(186, 217);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(95, 20);
            this.lbDateTime.TabIndex = 11;
            this.lbDateTime.Text = "Дата/Время:";
            // 
            // lbTemperature
            // 
            this.lbTemperature.AutoSize = true;
            this.lbTemperature.Location = new System.Drawing.Point(18, 255);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(103, 20);
            this.lbTemperature.TabIndex = 12;
            this.lbTemperature.Text = "Температура:";
            // 
            // tbTemperature
            // 
            this.tbTemperature.Location = new System.Drawing.Point(127, 252);
            this.tbTemperature.Multiline = true;
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(470, 69);
            this.tbTemperature.TabIndex = 13;
            // 
            // tbFish
            // 
            this.tbFish.Location = new System.Drawing.Point(125, 19);
            this.tbFish.Name = "tbFish";
            this.tbFish.Size = new System.Drawing.Size(125, 27);
            this.tbFish.TabIndex = 0;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.LightGray;
            this.btnCheck.Location = new System.Drawing.Point(18, 356);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(175, 53);
            this.btnCheck.TabIndex = 14;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(337, 357);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(521, 145);
            this.tbResult.TabIndex = 15;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResult.Location = new System.Drawing.Point(227, 356);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(100, 25);
            this.lbResult.TabIndex = 16;
            this.lbResult.Text = "Результат:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightGray;
            this.btnLoad.Location = new System.Drawing.Point(615, 255);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(138, 48);
            this.btnLoad.TabIndex = 17;
            this.btnLoad.Text = "Загрузить из файла:";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(870, 514);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.lbTemperature);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.tbDateTime);
            this.Controls.Add(this.tbMinTempTime);
            this.Controls.Add(this.lbMinTempTime);
            this.Controls.Add(this.tbMinTemp);
            this.Controls.Add(this.lbMinTemp);
            this.Controls.Add(this.tbMaxTempTime);
            this.Controls.Add(this.lbMaxTempTime);
            this.Controls.Add(this.tbMaxTemp);
            this.Controls.Add(this.lbMaxTemp);
            this.Controls.Add(this.lbFishName);
            this.Controls.Add(this.tbFish);
            this.MinimumSize = new System.Drawing.Size(888, 561);
            this.Name = "frmMain";
            this.Text = "MonitoringTemperature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbFishName;
        private System.Windows.Forms.Label lbMaxTemp;
        private System.Windows.Forms.TextBox tbMaxTemp;
        private System.Windows.Forms.Label lbMaxTempTime;
        private System.Windows.Forms.TextBox tbMaxTempTime;
        private System.Windows.Forms.TextBox tbMinTempTime;
        private System.Windows.Forms.Label lbMinTempTime;
        private System.Windows.Forms.TextBox tbMinTemp;
        private System.Windows.Forms.Label lbMinTemp;
        private System.Windows.Forms.TextBox tbDateTime;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Label lbTemperature;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.TextBox tbFish;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

