
namespace INVENTORY_CONTROL_APP
{
    partial class StartForm
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
            this.labelSNACK = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSNACK
            // 
            this.labelSNACK.AutoSize = true;
            this.labelSNACK.BackColor = System.Drawing.Color.Transparent;
            this.labelSNACK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSNACK.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSNACK.Location = new System.Drawing.Point(281, 93);
            this.labelSNACK.Name = "labelSNACK";
            this.labelSNACK.Size = new System.Drawing.Size(253, 44);
            this.labelSNACK.TabIndex = 0;
            this.labelSNACK.Text = "SNACK TO GO";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(121, 178);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(569, 24);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Добро пожаловать в приложение для помощи в управлении складом!";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonStart.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.Color.Black;
            this.buttonStart.Location = new System.Drawing.Point(350, 268);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(123, 48);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "НАЧАТЬ";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelSNACK);
            this.Name = "StartForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "StartForm";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSNACK;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonStart;
    }
}

