
namespace INVENTORY_CONTROL_APP
{
    partial class ShowStoreStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowStoreStock));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvShowProducts = new System.Windows.Forms.DataGridView();
            this.txtBxSearcher = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnGoBack1 = new System.Windows.Forms.Button();
            this.btnAddOne = new System.Windows.Forms.Button();
            this.btnAddALot = new System.Windows.Forms.Button();
            this.btnDeleteOne = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnSetDefected = new System.Windows.Forms.Button();
            this.btnSendDelOne = new System.Windows.Forms.Button();
            this.lblProductStock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblCurrStore = new System.Windows.Forms.Label();
            this.btnSendDelALot = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProductInStock = new System.Windows.Forms.Label();
            this.btnDeleteAllNSP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvShowProducts);
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1253, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Продукция";
            // 
            // dgvShowProducts
            // 
            this.dgvShowProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowProducts.Location = new System.Drawing.Point(15, 32);
            this.dgvShowProducts.Name = "dgvShowProducts";
            this.dgvShowProducts.RowHeadersWidth = 51;
            this.dgvShowProducts.RowTemplate.Height = 24;
            this.dgvShowProducts.Size = new System.Drawing.Size(1222, 251);
            this.dgvShowProducts.TabIndex = 0;
            // 
            // txtBxSearcher
            // 
            this.txtBxSearcher.Location = new System.Drawing.Point(672, 40);
            this.txtBxSearcher.Name = "txtBxSearcher";
            this.txtBxSearcher.Size = new System.Drawing.Size(577, 22);
            this.txtBxSearcher.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(543, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnGoBack1
            // 
            this.btnGoBack1.Location = new System.Drawing.Point(27, 39);
            this.btnGoBack1.Name = "btnGoBack1";
            this.btnGoBack1.Size = new System.Drawing.Size(80, 22);
            this.btnGoBack1.TabIndex = 3;
            this.btnGoBack1.Text = "Назад";
            this.btnGoBack1.UseVisualStyleBackColor = true;
            this.btnGoBack1.Click += new System.EventHandler(this.btnGoBack1_Click);
            // 
            // btnAddOne
            // 
            this.btnAddOne.BackColor = System.Drawing.Color.Bisque;
            this.btnAddOne.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddOne.Location = new System.Drawing.Point(27, 424);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(224, 78);
            this.btnAddOne.TabIndex = 4;
            this.btnAddOne.Text = "Добавить единицу товара";
            this.btnAddOne.UseVisualStyleBackColor = false;
            // 
            // btnAddALot
            // 
            this.btnAddALot.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddALot.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddALot.ForeColor = System.Drawing.Color.White;
            this.btnAddALot.Location = new System.Drawing.Point(257, 424);
            this.btnAddALot.Name = "btnAddALot";
            this.btnAddALot.Size = new System.Drawing.Size(224, 78);
            this.btnAddALot.TabIndex = 5;
            this.btnAddALot.Text = "Множественное пополнение товара";
            this.btnAddALot.UseVisualStyleBackColor = false;
            // 
            // btnDeleteOne
            // 
            this.btnDeleteOne.BackColor = System.Drawing.Color.Salmon;
            this.btnDeleteOne.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteOne.Location = new System.Drawing.Point(442, 588);
            this.btnDeleteOne.Name = "btnDeleteOne";
            this.btnDeleteOne.Size = new System.Drawing.Size(224, 34);
            this.btnDeleteOne.TabIndex = 6;
            this.btnDeleteOne.Text = "Убрать со склада";
            this.btnDeleteOne.UseVisualStyleBackColor = false;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Bisque;
            this.btnTransfer.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTransfer.ForeColor = System.Drawing.Color.Black;
            this.btnTransfer.Location = new System.Drawing.Point(1025, 508);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(224, 45);
            this.btnTransfer.TabIndex = 7;
            this.btnTransfer.Text = "Перенести на другой склад";
            this.btnTransfer.UseVisualStyleBackColor = false;
            // 
            // btnSetDefected
            // 
            this.btnSetDefected.BackColor = System.Drawing.Color.Salmon;
            this.btnSetDefected.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetDefected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetDefected.Location = new System.Drawing.Point(1025, 559);
            this.btnSetDefected.Name = "btnSetDefected";
            this.btnSetDefected.Size = new System.Drawing.Size(224, 34);
            this.btnSetDefected.TabIndex = 8;
            this.btnSetDefected.Text = "Отметить как брак";
            this.btnSetDefected.UseVisualStyleBackColor = false;
            // 
            // btnSendDelOne
            // 
            this.btnSendDelOne.BackColor = System.Drawing.Color.Bisque;
            this.btnSendDelOne.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendDelOne.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSendDelOne.Location = new System.Drawing.Point(795, 424);
            this.btnSendDelOne.Name = "btnSendDelOne";
            this.btnSendDelOne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSendDelOne.Size = new System.Drawing.Size(224, 78);
            this.btnSendDelOne.TabIndex = 9;
            this.btnSendDelOne.Text = "Отправить в доставку единицу товара";
            this.btnSendDelOne.UseVisualStyleBackColor = false;
            // 
            // lblProductStock
            // 
            this.lblProductStock.AutoSize = true;
            this.lblProductStock.BackColor = System.Drawing.Color.Transparent;
            this.lblProductStock.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.lblProductStock.Location = new System.Drawing.Point(22, 535);
            this.lblProductStock.Name = "lblProductStock";
            this.lblProductStock.Size = new System.Drawing.Size(330, 30);
            this.lblProductStock.TabIndex = 10;
            this.lblProductStock.Text = "Подобных товаров на складе:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 588);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(184, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Товар без брака";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.lbl.Location = new System.Drawing.Point(487, 424);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(239, 30);
            this.lbl.TabIndex = 12;
            this.lbl.Text = "Управление складом:";
            // 
            // lblCurrStore
            // 
            this.lblCurrStore.AutoSize = true;
            this.lblCurrStore.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurrStore.Location = new System.Drawing.Point(487, 464);
            this.lblCurrStore.Name = "lblCurrStore";
            this.lblCurrStore.Size = new System.Drawing.Size(128, 22);
            this.lblCurrStore.TabIndex = 13;
            this.lblCurrStore.Text = "название склада";
            // 
            // btnSendDelALot
            // 
            this.btnSendDelALot.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSendDelALot.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendDelALot.ForeColor = System.Drawing.Color.White;
            this.btnSendDelALot.Location = new System.Drawing.Point(1025, 424);
            this.btnSendDelALot.Name = "btnSendDelALot";
            this.btnSendDelALot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSendDelALot.Size = new System.Drawing.Size(224, 78);
            this.btnSendDelALot.TabIndex = 14;
            this.btnSendDelALot.Text = "Отправить оптовую доставку";
            this.btnSendDelALot.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(859, 516);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 118);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblProductInStock
            // 
            this.lblProductInStock.AutoSize = true;
            this.lblProductInStock.BackColor = System.Drawing.Color.Transparent;
            this.lblProductInStock.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.lblProductInStock.Location = new System.Drawing.Point(437, 535);
            this.lblProductInStock.Name = "lblProductInStock";
            this.lblProductInStock.Size = new System.Drawing.Size(211, 30);
            this.lblProductInStock.TabIndex = 16;
            this.lblProductInStock.Text = "Единица на складе";
            // 
            // btnDeleteAllNSP
            // 
            this.btnDeleteAllNSP.BackColor = System.Drawing.Color.Salmon;
            this.btnDeleteAllNSP.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteAllNSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteAllNSP.Location = new System.Drawing.Point(1025, 599);
            this.btnDeleteAllNSP.Name = "btnDeleteAllNSP";
            this.btnDeleteAllNSP.Size = new System.Drawing.Size(224, 49);
            this.btnDeleteAllNSP.TabIndex = 17;
            this.btnDeleteAllNSP.Text = "Убрать со склада все товары не в наличии";
            this.btnDeleteAllNSP.UseVisualStyleBackColor = false;
            // 
            // ShowStoreStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 654);
            this.Controls.Add(this.btnDeleteAllNSP);
            this.Controls.Add(this.lblProductInStock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSendDelALot);
            this.Controls.Add(this.lblCurrStore);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProductStock);
            this.Controls.Add(this.btnSendDelOne);
            this.Controls.Add(this.btnSetDefected);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnDeleteOne);
            this.Controls.Add(this.btnAddALot);
            this.Controls.Add(this.btnAddOne);
            this.Controls.Add(this.btnGoBack1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBxSearcher);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "ShowStoreStock";
            this.Text = "Товары на складе";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowStoreStock_FormClosing);
            this.Load += new System.EventHandler(this.ShowStoreStock_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvShowProducts;
        private System.Windows.Forms.TextBox txtBxSearcher;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnGoBack1;
        private System.Windows.Forms.Button btnAddOne;
        private System.Windows.Forms.Button btnAddALot;
        private System.Windows.Forms.Button btnDeleteOne;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnSetDefected;
        private System.Windows.Forms.Button btnSendDelOne;
        private System.Windows.Forms.Label lblProductStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblCurrStore;
        private System.Windows.Forms.Button btnSendDelALot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProductInStock;
        private System.Windows.Forms.Button btnDeleteAllNSP;
    }
}