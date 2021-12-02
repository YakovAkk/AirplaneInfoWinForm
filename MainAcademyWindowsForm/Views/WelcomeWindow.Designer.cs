
namespace MainAcademyWindowsForm
{
    partial class WelcomeWindow
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstStationBtn = new System.Windows.Forms.Button();
            this.secondStationBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.AdmenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstStationBtn
            // 
            this.firstStationBtn.Location = new System.Drawing.Point(167, 216);
            this.firstStationBtn.Name = "firstStationBtn";
            this.firstStationBtn.Size = new System.Drawing.Size(170, 152);
            this.firstStationBtn.TabIndex = 0;
            this.firstStationBtn.Text = "First Station";
            this.firstStationBtn.UseVisualStyleBackColor = true;
            this.firstStationBtn.Click += new System.EventHandler(this.firstStationBtn_Click);
            // 
            // secondStationBtn
            // 
            this.secondStationBtn.Location = new System.Drawing.Point(384, 216);
            this.secondStationBtn.Name = "secondStationBtn";
            this.secondStationBtn.Size = new System.Drawing.Size(170, 152);
            this.secondStationBtn.TabIndex = 1;
            this.secondStationBtn.Text = "Second Station";
            this.secondStationBtn.UseVisualStyleBackColor = true;
            this.secondStationBtn.Click += new System.EventHandler(this.secondStationBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(324, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wellcome to my app";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(364, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose something station";
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(785, 532);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(135, 68);
            this.QuitBtn.TabIndex = 4;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // AdmenBtn
            // 
            this.AdmenBtn.Location = new System.Drawing.Point(398, 530);
            this.AdmenBtn.Name = "AdmenBtn";
            this.AdmenBtn.Size = new System.Drawing.Size(156, 72);
            this.AdmenBtn.TabIndex = 5;
            this.AdmenBtn.Text = "Admen";
            this.AdmenBtn.UseVisualStyleBackColor = true;
            this.AdmenBtn.Click += new System.EventHandler(this.AdmenBtn_Click);
            // 
            // WelcomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdmenBtn);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondStationBtn);
            this.Controls.Add(this.firstStationBtn);
            this.MinimumSize = new System.Drawing.Size(800, 640);
            this.Name = "WelcomeWindow";
            this.Size = new System.Drawing.Size(1009, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button firstStationBtn;
        private System.Windows.Forms.Button secondStationBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button AdmenBtn;
    }
}
