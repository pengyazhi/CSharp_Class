namespace Lab_Form
{
    partial class Frm_M12
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
            this.btnAccumulate = new System.Windows.Forms.Button();
            this.labCount = new System.Windows.Forms.Label();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.btnRemainder = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnReduce = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLocalVar = new System.Windows.Forms.Button();
            this.btnClassVar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStatic = new System.Windows.Forms.Button();
            this.btnInsatnce = new System.Windows.Forms.Button();
            this.labInstanceCount = new System.Windows.Forms.Label();
            this.labStaticCount = new System.Windows.Forms.Label();
            this.button02 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccumulate
            // 
            this.btnAccumulate.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccumulate.Location = new System.Drawing.Point(206, 117);
            this.btnAccumulate.Name = "btnAccumulate";
            this.btnAccumulate.Size = new System.Drawing.Size(59, 51);
            this.btnAccumulate.TabIndex = 0;
            this.btnAccumulate.Text = "+=";
            this.btnAccumulate.UseVisualStyleBackColor = true;
            this.btnAccumulate.Click += new System.EventHandler(this.btnAccumulate_Click);
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCount.Location = new System.Drawing.Point(202, 59);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(77, 19);
            this.labCount.TabIndex = 1;
            this.labCount.Text = "Count : 0";
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMultiply.Location = new System.Drawing.Point(206, 186);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(59, 51);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "*=";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDecrease.Location = new System.Drawing.Point(287, 117);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(59, 51);
            this.btnDecrease.TabIndex = 3;
            this.btnDecrease.Text = "-=";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // btnRemainder
            // 
            this.btnRemainder.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemainder.Location = new System.Drawing.Point(287, 186);
            this.btnRemainder.Name = "btnRemainder";
            this.btnRemainder.Size = new System.Drawing.Size(59, 51);
            this.btnRemainder.TabIndex = 4;
            this.btnRemainder.Text = "%=";
            this.btnRemainder.UseVisualStyleBackColor = true;
            this.btnRemainder.Click += new System.EventHandler(this.btnRemainder_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlus.Location = new System.Drawing.Point(179, 261);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(86, 51);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "++num";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnReduce
            // 
            this.btnReduce.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReduce.Location = new System.Drawing.Point(287, 261);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(86, 51);
            this.btnReduce.TabIndex = 6;
            this.btnReduce.Text = "--num";
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(179, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "num++";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(287, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "num--";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClassVar);
            this.groupBox1.Controls.Add(this.btnLocalVar);
            this.groupBox1.Location = new System.Drawing.Point(457, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 176);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variable";
            // 
            // btnLocalVar
            // 
            this.btnLocalVar.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLocalVar.Location = new System.Drawing.Point(52, 25);
            this.btnLocalVar.Name = "btnLocalVar";
            this.btnLocalVar.Size = new System.Drawing.Size(148, 51);
            this.btnLocalVar.TabIndex = 0;
            this.btnLocalVar.Text = "Local Var.";
            this.btnLocalVar.UseVisualStyleBackColor = true;
            this.btnLocalVar.Click += new System.EventHandler(this.btnLocalVar_Click);
            // 
            // btnClassVar
            // 
            this.btnClassVar.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClassVar.Location = new System.Drawing.Point(52, 107);
            this.btnClassVar.Name = "btnClassVar";
            this.btnClassVar.Size = new System.Drawing.Size(148, 51);
            this.btnClassVar.TabIndex = 1;
            this.btnClassVar.Text = "Class Var.";
            this.btnClassVar.UseVisualStyleBackColor = true;
            this.btnClassVar.Click += new System.EventHandler(this.btnClassVar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labInstanceCount);
            this.groupBox2.Controls.Add(this.labStaticCount);
            this.groupBox2.Controls.Add(this.btnStatic);
            this.groupBox2.Controls.Add(this.btnInsatnce);
            this.groupBox2.Location = new System.Drawing.Point(457, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 267);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Static";
            // 
            // btnStatic
            // 
            this.btnStatic.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatic.Location = new System.Drawing.Point(52, 190);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(148, 51);
            this.btnStatic.TabIndex = 1;
            this.btnStatic.Text = "Static";
            this.btnStatic.UseVisualStyleBackColor = true;
            this.btnStatic.Click += new System.EventHandler(this.btnStatic_Click);
            // 
            // btnInsatnce
            // 
            this.btnInsatnce.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsatnce.Location = new System.Drawing.Point(52, 70);
            this.btnInsatnce.Name = "btnInsatnce";
            this.btnInsatnce.Size = new System.Drawing.Size(148, 51);
            this.btnInsatnce.TabIndex = 0;
            this.btnInsatnce.Text = "Instance";
            this.btnInsatnce.UseVisualStyleBackColor = true;
            this.btnInsatnce.Click += new System.EventHandler(this.btnInsatnce_Click);
            // 
            // labInstanceCount
            // 
            this.labInstanceCount.AutoSize = true;
            this.labInstanceCount.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInstanceCount.Location = new System.Drawing.Point(58, 34);
            this.labInstanceCount.Name = "labInstanceCount";
            this.labInstanceCount.Size = new System.Drawing.Size(142, 19);
            this.labInstanceCount.TabIndex = 11;
            this.labInstanceCount.Text = "Instance Count : 0";
            // 
            // labStaticCount
            // 
            this.labStaticCount.AutoSize = true;
            this.labStaticCount.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStaticCount.Location = new System.Drawing.Point(58, 155);
            this.labStaticCount.Name = "labStaticCount";
            this.labStaticCount.Size = new System.Drawing.Size(123, 19);
            this.labStaticCount.TabIndex = 12;
            this.labStaticCount.Text = "Static Count : 0";
            // 
            // button02
            // 
            this.button02.Location = new System.Drawing.Point(557, 537);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(181, 64);
            this.button02.TabIndex = 11;
            this.button02.Text = "Open Hello Form";
            this.button02.UseVisualStyleBackColor = true;
            this.button02.Click += new System.EventHandler(this.button02_Click);
            // 
            // Frm_M12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 690);
            this.Controls.Add(this.button02);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReduce);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnRemainder);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.btnAccumulate);
            this.Name = "Frm_M12";
            this.Text = "Frm_M12";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccumulate;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Button btnRemainder;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClassVar;
        private System.Windows.Forms.Button btnLocalVar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labInstanceCount;
        private System.Windows.Forms.Label labStaticCount;
        private System.Windows.Forms.Button btnStatic;
        private System.Windows.Forms.Button btnInsatnce;
        private System.Windows.Forms.Button button02;
    }
}