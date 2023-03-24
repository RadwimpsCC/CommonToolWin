namespace CommonToolWin.Tool
{
    partial class FormToolMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormToolMain));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGetCpu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(48, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Excel导出";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonGetCpu
            // 
            this.buttonGetCpu.BackColor = System.Drawing.Color.Transparent;
            this.buttonGetCpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetCpu.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetCpu.ForeColor = System.Drawing.Color.White;
            this.buttonGetCpu.Location = new System.Drawing.Point(176, 48);
            this.buttonGetCpu.Name = "buttonGetCpu";
            this.buttonGetCpu.Size = new System.Drawing.Size(107, 41);
            this.buttonGetCpu.TabIndex = 0;
            this.buttonGetCpu.Text = "获取电脑CPU";
            this.buttonGetCpu.UseVisualStyleBackColor = false;
            this.buttonGetCpu.Click += new System.EventHandler(this.buttonGetCpu_Click);
            // 
            // FormToolMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 679);
            this.Controls.Add(this.buttonGetCpu);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormToolMain";
            this.Text = "FormToolMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGetCpu;
    }
}