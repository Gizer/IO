namespace IO
{
    partial class Worker
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
            this.dataGridViewWorker = new System.Windows.Forms.DataGridView();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWorker
            // 
            this.dataGridViewWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorker.Location = new System.Drawing.Point(126, 12);
            this.dataGridViewWorker.Name = "dataGridViewWorker";
            this.dataGridViewWorker.Size = new System.Drawing.Size(671, 426);
            this.dataGridViewWorker.TabIndex = 0;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(13, 28);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(107, 23);
            this.buttonInfo.TabIndex = 1;
            this.buttonInfo.Text = "Informacje";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Location = new System.Drawing.Point(13, 58);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(107, 23);
            this.buttonSchedule.TabIndex = 2;
            this.buttonSchedule.Text = "Grafik";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            this.buttonSchedule.Click += new System.EventHandler(this.btn_sch_Click);
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSchedule);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.dataGridViewWorker);
            this.Name = "Worker";
            this.Text = "Worker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWorker;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonSchedule;
    }
}