namespace Lab02
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.btbSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(276, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(41, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(213, 120);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(53, 13);
            this.lblNumber1.TabIndex = 1;
            this.lblNumber1.Text = "Number 1";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(276, 117);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(239, 20);
            this.txtNumber1.TabIndex = 2;
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(216, 168);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(53, 13);
            this.lblNumber2.TabIndex = 3;
            this.lblNumber2.Text = "Number 2";
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(276, 168);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(239, 20);
            this.txtNumber2.TabIndex = 4;
            // 
            // btbSub
            // 
            this.btbSub.Location = new System.Drawing.Point(348, 233);
            this.btbSub.Name = "btbSub";
            this.btbSub.Size = new System.Drawing.Size(43, 38);
            this.btbSub.TabIndex = 0;
            this.btbSub.Text = "-";
            this.btbSub.UseVisualStyleBackColor = true;
            this.btbSub.Click += new System.EventHandler(this.btbSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(417, 233);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(42, 38);
            this.btnMul.TabIndex = 0;
            this.btnMul.Text = "x";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(483, 233);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(40, 38);
            this.btnDiv.TabIndex = 0;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(213, 329);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(276, 326);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(247, 20);
            this.txtResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 474);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btbSub);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Lab02-01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Button btbSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
    }
}

