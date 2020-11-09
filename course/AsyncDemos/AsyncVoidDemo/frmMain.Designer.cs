namespace AsyncVoidDemo
{
    partial class frmMain
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
            this.btnRun = new System.Windows.Forms.Button();
            this.lblLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoAsyncTask = new System.Windows.Forms.RadioButton();
            this.rdoAsyncVoid = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(16, 101);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(92, 37);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "测试";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLeft.Location = new System.Drawing.Point(16, 39);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(79, 28);
            this.lblLeft.TabIndex = 1;
            this.lblLeft.Text = "lblLeft";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(129, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "+";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRight.Location = new System.Drawing.Point(188, 39);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(96, 28);
            this.lblRight.TabIndex = 1;
            this.lblRight.Text = "lblRight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(306, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "=";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(365, 39);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(104, 28);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "lblResult";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoAsyncTask);
            this.groupBox1.Controls.Add(this.rdoAsyncVoid);
            this.groupBox1.Location = new System.Drawing.Point(156, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择异步方法类型";
            // 
            // rdoAsyncTask
            // 
            this.rdoAsyncTask.AutoSize = true;
            this.rdoAsyncTask.Checked = true;
            this.rdoAsyncTask.Location = new System.Drawing.Point(155, 20);
            this.rdoAsyncTask.Name = "rdoAsyncTask";
            this.rdoAsyncTask.Size = new System.Drawing.Size(107, 16);
            this.rdoAsyncTask.TabIndex = 0;
            this.rdoAsyncTask.TabStop = true;
            this.rdoAsyncTask.Text = "使用async Task";
            this.rdoAsyncTask.UseVisualStyleBackColor = true;
            // 
            // rdoAsyncVoid
            // 
            this.rdoAsyncVoid.AutoSize = true;
            this.rdoAsyncVoid.Location = new System.Drawing.Point(18, 21);
            this.rdoAsyncVoid.Name = "rdoAsyncVoid";
            this.rdoAsyncVoid.Size = new System.Drawing.Size(107, 16);
            this.rdoAsyncVoid.TabIndex = 0;
            this.rdoAsyncVoid.Text = "使用async void";
            this.rdoAsyncVoid.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 175);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.btnRun);
            this.Name = "frmMain";
            this.Text = "测试Async Void";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoAsyncTask;
        private System.Windows.Forms.RadioButton rdoAsyncVoid;
    }
}

