namespace FinalProject
{
    partial class AdminForm
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
            this.btnentertainment = new System.Windows.Forms.Button();
            this.btnhistory = new System.Windows.Forms.Button();
            this.btnscience = new System.Windows.Forms.Button();
            this.btnsport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnentertainment
            // 
            this.btnentertainment.Location = new System.Drawing.Point(475, 317);
            this.btnentertainment.Name = "btnentertainment";
            this.btnentertainment.Size = new System.Drawing.Size(133, 60);
            this.btnentertainment.TabIndex = 9;
            this.btnentertainment.Text = "Math";
            this.btnentertainment.UseVisualStyleBackColor = true;
            this.btnentertainment.Click += new System.EventHandler(this.btnentertainment_Click);
            // 
            // btnhistory
            // 
            this.btnhistory.Location = new System.Drawing.Point(220, 317);
            this.btnhistory.Name = "btnhistory";
            this.btnhistory.Size = new System.Drawing.Size(133, 60);
            this.btnhistory.TabIndex = 8;
            this.btnhistory.Text = "History";
            this.btnhistory.UseVisualStyleBackColor = true;
            this.btnhistory.Click += new System.EventHandler(this.btnhistory_Click);
            // 
            // btnscience
            // 
            this.btnscience.Location = new System.Drawing.Point(475, 168);
            this.btnscience.Name = "btnscience";
            this.btnscience.Size = new System.Drawing.Size(133, 60);
            this.btnscience.TabIndex = 7;
            this.btnscience.Text = "Science";
            this.btnscience.UseVisualStyleBackColor = true;
            this.btnscience.Click += new System.EventHandler(this.btnscience_Click);
            // 
            // btnsport
            // 
            this.btnsport.Location = new System.Drawing.Point(220, 168);
            this.btnsport.Name = "btnsport";
            this.btnsport.Size = new System.Drawing.Size(133, 60);
            this.btnsport.TabIndex = 6;
            this.btnsport.Text = "Sport";
            this.btnsport.UseVisualStyleBackColor = true;
            this.btnsport.Click += new System.EventHandler(this.btnsport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose a section";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 479);
            this.Controls.Add(this.btnentertainment);
            this.Controls.Add(this.btnhistory);
            this.Controls.Add(this.btnscience);
            this.Controls.Add(this.btnsport);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnentertainment;
        private System.Windows.Forms.Button btnhistory;
        private System.Windows.Forms.Button btnscience;
        private System.Windows.Forms.Button btnsport;
        private System.Windows.Forms.Label label1;
    }
}