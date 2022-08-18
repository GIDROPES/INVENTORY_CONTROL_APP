
namespace INVENTORY_CONTROL_APP
{
    partial class MainShowingForm
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
            this.cmbBxStores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowStore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowReturns = new System.Windows.Forms.Button();
            this.btnShowDelivers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBxStores
            // 
            this.cmbBxStores.FormattingEnabled = true;
            this.cmbBxStores.Location = new System.Drawing.Point(439, 94);
            this.cmbBxStores.Name = "cmbBxStores";
            this.cmbBxStores.Size = new System.Drawing.Size(328, 24);
            this.cmbBxStores.TabIndex = 0;
            this.cmbBxStores.SelectedIndexChanged += new System.EventHandler(this.cmbBxStores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите склад для просмотра товаров";
            // 
            // btnShowStore
            // 
            this.btnShowStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShowStore.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowStore.Location = new System.Drawing.Point(65, 148);
            this.btnShowStore.Name = "btnShowStore";
            this.btnShowStore.Size = new System.Drawing.Size(702, 60);
            this.btnShowStore.TabIndex = 2;
            this.btnShowStore.Text = "Просмотр";
            this.btnShowStore.UseVisualStyleBackColor = false;
            this.btnShowStore.Click += new System.EventHandler(this.btnShowStore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(395, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Отследить товар";
            // 
            // btnShowReturns
            // 
            this.btnShowReturns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShowReturns.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowReturns.Location = new System.Drawing.Point(65, 394);
            this.btnShowReturns.Name = "btnShowReturns";
            this.btnShowReturns.Size = new System.Drawing.Size(411, 67);
            this.btnShowReturns.TabIndex = 4;
            this.btnShowReturns.Text = "Возвраты";
            this.btnShowReturns.UseVisualStyleBackColor = false;
            this.btnShowReturns.Click += new System.EventHandler(this.btnShowReturns_Click);
            // 
            // btnShowDelivers
            // 
            this.btnShowDelivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShowDelivers.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnShowDelivers.Location = new System.Drawing.Point(499, 394);
            this.btnShowDelivers.Name = "btnShowDelivers";
            this.btnShowDelivers.Size = new System.Drawing.Size(411, 67);
            this.btnShowDelivers.TabIndex = 5;
            this.btnShowDelivers.Text = "Доставки";
            this.btnShowDelivers.UseVisualStyleBackColor = false;
            this.btnShowDelivers.Click += new System.EventHandler(this.btnShowDelivers_Click);
            // 
            // MainShowingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 532);
            this.Controls.Add(this.btnShowDelivers);
            this.Controls.Add(this.btnShowReturns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowStore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBxStores);
            this.Name = "MainShowingForm";
            this.Text = "MainShowingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainShowingForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBxStores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowStore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowReturns;
        private System.Windows.Forms.Button btnShowDelivers;
    }
}