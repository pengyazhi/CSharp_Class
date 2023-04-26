namespace Lab_Form
{
    partial class Frm_M20
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
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnTenaryOperator = new System.Windows.Forms.Button();
            this.btnGrade = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.labGrade = new System.Windows.Forms.Label();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnForeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(54, 41);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 0;
            this.btnReverse.Text = "!";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnTenaryOperator
            // 
            this.btnTenaryOperator.Location = new System.Drawing.Point(54, 87);
            this.btnTenaryOperator.Name = "btnTenaryOperator";
            this.btnTenaryOperator.Size = new System.Drawing.Size(113, 113);
            this.btnTenaryOperator.TabIndex = 1;
            this.btnTenaryOperator.Text = "三元運算式";
            this.btnTenaryOperator.UseVisualStyleBackColor = true;
            this.btnTenaryOperator.Click += new System.EventHandler(this.btnTenaryOperator_Click);
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(283, 111);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(100, 44);
            this.btnGrade.TabIndex = 2;
            this.btnGrade.Text = "分級";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(283, 69);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 22);
            this.txtScore.TabIndex = 3;
            // 
            // labGrade
            // 
            this.labGrade.AutoSize = true;
            this.labGrade.Location = new System.Drawing.Point(418, 72);
            this.labGrade.Name = "labGrade";
            this.labGrade.Size = new System.Drawing.Size(53, 12);
            this.labGrade.TabIndex = 4;
            this.labGrade.Text = "顯示級數";
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(54, 247);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(136, 73);
            this.btnWhile.TabIndex = 5;
            this.btnWhile.Text = "while";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(247, 247);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(136, 73);
            this.btnDo.TabIndex = 6;
            this.btnDo.Text = "Do";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(420, 247);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(136, 73);
            this.btnFor.TabIndex = 7;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnForeach
            // 
            this.btnForeach.Location = new System.Drawing.Point(593, 247);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(136, 73);
            this.btnForeach.TabIndex = 8;
            this.btnForeach.Text = "Foreach";
            this.btnForeach.UseVisualStyleBackColor = true;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // Frm_M20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.labGrade);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.btnTenaryOperator);
            this.Controls.Add(this.btnReverse);
            this.Name = "Frm_M20";
            this.Text = "Frm_M20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnTenaryOperator;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label labGrade;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnForeach;
    }
}