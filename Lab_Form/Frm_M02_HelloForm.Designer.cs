namespace Lab_Form
{
    partial class Frm_M02_HelloForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_M02_HelloForm));
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.labStarSign = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.labEnglishName = new System.Windows.Forms.Label();
            this.txtStarSign = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtEnglishName = new System.Windows.Forms.TextBox();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labName.Location = new System.Drawing.Point(73, 33);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(75, 27);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(235, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 35);
            this.txtName.TabIndex = 1;
            // 
            // btnSayHello
            // 
            this.btnSayHello.BackColor = System.Drawing.Color.IndianRed;
            this.btnSayHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSayHello.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSayHello.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnSayHello.Location = new System.Drawing.Point(523, 49);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(144, 50);
            this.btnSayHello.TabIndex = 2;
            this.btnSayHello.Text = "Say Hello";
            this.btnSayHello.UseVisualStyleBackColor = false;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // labStarSign
            // 
            this.labStarSign.AutoSize = true;
            this.labStarSign.BackColor = System.Drawing.Color.Transparent;
            this.labStarSign.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStarSign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labStarSign.Location = new System.Drawing.Point(73, 183);
            this.labStarSign.Name = "labStarSign";
            this.labStarSign.Size = new System.Drawing.Size(75, 27);
            this.labStarSign.TabIndex = 3;
            this.labStarSign.Text = "星座：";
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.BackColor = System.Drawing.Color.Transparent;
            this.labSex.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labSex.Location = new System.Drawing.Point(73, 134);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(75, 27);
            this.labSex.TabIndex = 4;
            this.labSex.Text = "性別：";
            // 
            // labEnglishName
            // 
            this.labEnglishName.AutoSize = true;
            this.labEnglishName.BackColor = System.Drawing.Color.Transparent;
            this.labEnglishName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglishName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labEnglishName.Location = new System.Drawing.Point(73, 84);
            this.labEnglishName.Name = "labEnglishName";
            this.labEnglishName.Size = new System.Drawing.Size(168, 27);
            this.labEnglishName.TabIndex = 5;
            this.labEnglishName.Text = "English Name：";
            // 
            // txtStarSign
            // 
            this.txtStarSign.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStarSign.Location = new System.Drawing.Point(235, 175);
            this.txtStarSign.Name = "txtStarSign";
            this.txtStarSign.Size = new System.Drawing.Size(143, 35);
            this.txtStarSign.TabIndex = 6;
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSex.Location = new System.Drawing.Point(235, 131);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(143, 35);
            this.txtSex.TabIndex = 7;
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglishName.Location = new System.Drawing.Point(235, 81);
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(143, 35);
            this.txtEnglishName.TabIndex = 8;
            // 
            // btnSayHi
            // 
            this.btnSayHi.BackColor = System.Drawing.Color.IndianRed;
            this.btnSayHi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSayHi.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSayHi.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnSayHi.Location = new System.Drawing.Point(523, 131);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(144, 50);
            this.btnSayHi.TabIndex = 9;
            this.btnSayHi.Text = "Say Hi";
            this.btnSayHi.UseVisualStyleBackColor = false;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSalmon;
            this.button1.Location = new System.Drawing.Point(505, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 58);
            this.button1.TabIndex = 10;
            this.button1.Text = "Static Num";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_M02_HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEnglishName);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtStarSign);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labEnglishName);
            this.Controls.Add(this.labSex);
            this.Controls.Add(this.labStarSign);
            this.Name = "Frm_M02_HelloForm";
            this.Text = "HelloForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Label labStarSign;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label labEnglishName;
        private System.Windows.Forms.TextBox txtStarSign;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtEnglishName;
        private System.Windows.Forms.Button btnSayHi;
        private System.Windows.Forms.Button button1;
    }
}

