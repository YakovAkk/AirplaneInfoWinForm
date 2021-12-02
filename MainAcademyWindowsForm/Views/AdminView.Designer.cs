
namespace MainAcademyWindowsForm
{
    partial class AdminView
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
            this.components = new System.ComponentModel.Container();
            this.OkBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IncorrectPassLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBtn.Location = new System.Drawing.Point(404, 451);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(177, 117);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(181, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input your user name and password ";
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNametextBox.Location = new System.Drawing.Point(433, 205);
            this.UserNametextBox.Multiline = true;
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(255, 46);
            this.UserNametextBox.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordtextBox.Location = new System.Drawing.Point(433, 312);
            this.PasswordtextBox.Multiline = true;
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(255, 46);
            this.PasswordtextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(181, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "User name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(181, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // IncorrectPassLabel
            // 
            this.IncorrectPassLabel.AutoSize = true;
            this.IncorrectPassLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncorrectPassLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectPassLabel.Location = new System.Drawing.Point(360, 389);
            this.IncorrectPassLabel.Name = "IncorrectPassLabel";
            this.IncorrectPassLabel.Size = new System.Drawing.Size(0, 32);
            this.IncorrectPassLabel.TabIndex = 6;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(26, 504);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(183, 64);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "<< Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.IncorrectPassLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.UserNametextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkBtn);
            this.MinimumSize = new System.Drawing.Size(800, 640);
            this.Name = "AdminView";
            this.Size = new System.Drawing.Size(1009, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNametextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IncorrectPassLabel;
        private System.Windows.Forms.Button backBtn;
    }
}
