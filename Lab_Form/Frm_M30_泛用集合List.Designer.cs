namespace Lab_Form
{
    partial class Frm_M30_泛用集合List
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
            this.rTxtBoxProductList = new System.Windows.Forms.RichTextBox();
            this.btnAddDifferentType = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnAddProductList = new System.Windows.Forms.Button();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.labProductPrice = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.labProductName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rTxtBoxProductList
            // 
            this.rTxtBoxProductList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rTxtBoxProductList.Location = new System.Drawing.Point(419, 29);
            this.rTxtBoxProductList.Name = "rTxtBoxProductList";
            this.rTxtBoxProductList.ReadOnly = true;
            this.rTxtBoxProductList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rTxtBoxProductList.Size = new System.Drawing.Size(308, 259);
            this.rTxtBoxProductList.TabIndex = 19;
            this.rTxtBoxProductList.Text = "      產品名稱      產品價格";
            // 
            // btnAddDifferentType
            // 
            this.btnAddDifferentType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDifferentType.Location = new System.Drawing.Point(33, 141);
            this.btnAddDifferentType.Name = "btnAddDifferentType";
            this.btnAddDifferentType.Size = new System.Drawing.Size(197, 48);
            this.btnAddDifferentType.TabIndex = 18;
            this.btnAddDifferentType.Text = "加入不同的資料型態";
            this.btnAddDifferentType.UseVisualStyleBackColor = true;
            this.btnAddDifferentType.Click += new System.EventHandler(this.btnAddDifferentType_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(266, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 48);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAt.Location = new System.Drawing.Point(266, 168);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(121, 48);
            this.btnRemoveAt.TabIndex = 16;
            this.btnRemoveAt.Text = "Remove At";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(266, 96);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(121, 48);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnAddProductList
            // 
            this.btnAddProductList.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductList.Location = new System.Drawing.Point(266, 29);
            this.btnAddProductList.Name = "btnAddProductList";
            this.btnAddProductList.Size = new System.Drawing.Size(121, 48);
            this.btnAddProductList.TabIndex = 14;
            this.btnAddProductList.Text = "Add";
            this.btnAddProductList.UseVisualStyleBackColor = true;
            this.btnAddProductList.Click += new System.EventHandler(this.btnAddProductList_Click);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProductPrice.Location = new System.Drawing.Point(130, 78);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 33);
            this.txtProductPrice.TabIndex = 13;
            // 
            // labProductPrice
            // 
            this.labProductPrice.AutoSize = true;
            this.labProductPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labProductPrice.Location = new System.Drawing.Point(29, 81);
            this.labProductPrice.Name = "labProductPrice";
            this.labProductPrice.Size = new System.Drawing.Size(105, 24);
            this.labProductPrice.TabIndex = 12;
            this.labProductPrice.Text = "產品價格：";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProductName.Location = new System.Drawing.Point(130, 29);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 33);
            this.txtProductName.TabIndex = 11;
            // 
            // labProductName
            // 
            this.labProductName.AutoSize = true;
            this.labProductName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labProductName.Location = new System.Drawing.Point(29, 32);
            this.labProductName.Name = "labProductName";
            this.labProductName.Size = new System.Drawing.Size(105, 24);
            this.labProductName.TabIndex = 10;
            this.labProductName.Text = "產品名稱：";
            // 
            // Frm_M30_泛用集合List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rTxtBoxProductList);
            this.Controls.Add(this.btnAddDifferentType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnAddProductList);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.labProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.labProductName);
            this.Name = "Frm_M30_泛用集合List";
            this.Text = "Frm_M30_泛用集合List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtBoxProductList;
        private System.Windows.Forms.Button btnAddDifferentType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnAddProductList;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label labProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label labProductName;
    }
}