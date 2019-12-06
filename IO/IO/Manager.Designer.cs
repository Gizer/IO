namespace OracleGUI
{
    partial class Manager
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
            this.dataGridViewManager = new System.Windows.Forms.DataGridView();
            this.groupBoxManager = new System.Windows.Forms.GroupBox();
            this.radioButtonLineNumber = new System.Windows.Forms.RadioButton();
            this.radioButtonTimeOfArrival = new System.Windows.Forms.RadioButton();
            this.radioButtonSchedule = new System.Windows.Forms.RadioButton();
            this.radioButtonStops = new System.Windows.Forms.RadioButton();
            this.radioButtonDepot = new System.Windows.Forms.RadioButton();
            this.radioButtonTimetable = new System.Windows.Forms.RadioButton();
            this.radioButtonVehicles = new System.Windows.Forms.RadioButton();
            this.radioButtonCrash = new System.Windows.Forms.RadioButton();
            this.radioButtonWorkers = new System.Windows.Forms.RadioButton();
            this.tb_change = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManager)).BeginInit();
            this.groupBoxManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewManager
            // 
            this.dataGridViewManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManager.Location = new System.Drawing.Point(131, 12);
            this.dataGridViewManager.Name = "dataGridViewManager";
            this.dataGridViewManager.Size = new System.Drawing.Size(657, 237);
            this.dataGridViewManager.TabIndex = 0;
            // 
            // groupBoxManager
            // 
            this.groupBoxManager.Controls.Add(this.radioButtonLineNumber);
            this.groupBoxManager.Controls.Add(this.radioButtonTimeOfArrival);
            this.groupBoxManager.Controls.Add(this.radioButtonSchedule);
            this.groupBoxManager.Controls.Add(this.radioButtonStops);
            this.groupBoxManager.Controls.Add(this.radioButtonDepot);
            this.groupBoxManager.Controls.Add(this.radioButtonTimetable);
            this.groupBoxManager.Controls.Add(this.radioButtonVehicles);
            this.groupBoxManager.Controls.Add(this.radioButtonCrash);
            this.groupBoxManager.Controls.Add(this.radioButtonWorkers);
            this.groupBoxManager.Location = new System.Drawing.Point(12, 12);
            this.groupBoxManager.Name = "groupBoxManager";
            this.groupBoxManager.Size = new System.Drawing.Size(113, 237);
            this.groupBoxManager.TabIndex = 1;
            this.groupBoxManager.TabStop = false;
            this.groupBoxManager.Text = "Opcje";
            // 
            // radioButtonLineNumber
            // 
            this.radioButtonLineNumber.AutoSize = true;
            this.radioButtonLineNumber.Location = new System.Drawing.Point(6, 205);
            this.radioButtonLineNumber.Name = "radioButtonLineNumber";
            this.radioButtonLineNumber.Size = new System.Drawing.Size(80, 17);
            this.radioButtonLineNumber.TabIndex = 6;
            this.radioButtonLineNumber.TabStop = true;
            this.radioButtonLineNumber.Text = "Numer_Linii";
            this.radioButtonLineNumber.UseVisualStyleBackColor = true;
            // 
            // radioButtonTimeOfArrival
            // 
            this.radioButtonTimeOfArrival.AutoSize = true;
            this.radioButtonTimeOfArrival.Location = new System.Drawing.Point(7, 181);
            this.radioButtonTimeOfArrival.Name = "radioButtonTimeOfArrival";
            this.radioButtonTimeOfArrival.Size = new System.Drawing.Size(99, 17);
            this.radioButtonTimeOfArrival.TabIndex = 5;
            this.radioButtonTimeOfArrival.TabStop = true;
            this.radioButtonTimeOfArrival.Text = "Czas_Przyjazdu";
            this.radioButtonTimeOfArrival.UseVisualStyleBackColor = true;
            // 
            // radioButtonSchedule
            // 
            this.radioButtonSchedule.AutoSize = true;
            this.radioButtonSchedule.Location = new System.Drawing.Point(6, 157);
            this.radioButtonSchedule.Name = "radioButtonSchedule";
            this.radioButtonSchedule.Size = new System.Drawing.Size(53, 17);
            this.radioButtonSchedule.TabIndex = 4;
            this.radioButtonSchedule.TabStop = true;
            this.radioButtonSchedule.Text = "Grafik";
            this.radioButtonSchedule.UseVisualStyleBackColor = true;
            this.radioButtonSchedule.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonStops
            // 
            this.radioButtonStops.AutoSize = true;
            this.radioButtonStops.Location = new System.Drawing.Point(6, 134);
            this.radioButtonStops.Name = "radioButtonStops";
            this.radioButtonStops.Size = new System.Drawing.Size(73, 17);
            this.radioButtonStops.TabIndex = 4;
            this.radioButtonStops.TabStop = true;
            this.radioButtonStops.Text = "Przystanki";
            this.radioButtonStops.UseVisualStyleBackColor = true;
            this.radioButtonStops.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonDepot
            // 
            this.radioButtonDepot.AutoSize = true;
            this.radioButtonDepot.Location = new System.Drawing.Point(6, 111);
            this.radioButtonDepot.Name = "radioButtonDepot";
            this.radioButtonDepot.Size = new System.Drawing.Size(71, 17);
            this.radioButtonDepot.TabIndex = 4;
            this.radioButtonDepot.TabStop = true;
            this.radioButtonDepot.Text = "Zajezdnie";
            this.radioButtonDepot.UseVisualStyleBackColor = true;
            this.radioButtonDepot.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonTimetable
            // 
            this.radioButtonTimetable.AutoSize = true;
            this.radioButtonTimetable.Location = new System.Drawing.Point(6, 88);
            this.radioButtonTimetable.Name = "radioButtonTimetable";
            this.radioButtonTimetable.Size = new System.Drawing.Size(64, 17);
            this.radioButtonTimetable.TabIndex = 3;
            this.radioButtonTimetable.TabStop = true;
            this.radioButtonTimetable.Text = "Rozklad";
            this.radioButtonTimetable.UseVisualStyleBackColor = true;
            this.radioButtonTimetable.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonVehicles
            // 
            this.radioButtonVehicles.AutoSize = true;
            this.radioButtonVehicles.Location = new System.Drawing.Point(6, 65);
            this.radioButtonVehicles.Name = "radioButtonVehicles";
            this.radioButtonVehicles.Size = new System.Drawing.Size(62, 17);
            this.radioButtonVehicles.TabIndex = 2;
            this.radioButtonVehicles.TabStop = true;
            this.radioButtonVehicles.Text = "Pojazdy";
            this.radioButtonVehicles.UseVisualStyleBackColor = true;
            this.radioButtonVehicles.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonCrash
            // 
            this.radioButtonCrash.AutoSize = true;
            this.radioButtonCrash.Location = new System.Drawing.Point(6, 42);
            this.radioButtonCrash.Name = "radioButtonCrash";
            this.radioButtonCrash.Size = new System.Drawing.Size(67, 17);
            this.radioButtonCrash.TabIndex = 1;
            this.radioButtonCrash.TabStop = true;
            this.radioButtonCrash.Text = "Wypadki";
            this.radioButtonCrash.UseVisualStyleBackColor = true;
            this.radioButtonCrash.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonWorkers
            // 
            this.radioButtonWorkers.AutoSize = true;
            this.radioButtonWorkers.Location = new System.Drawing.Point(6, 19);
            this.radioButtonWorkers.Name = "radioButtonWorkers";
            this.radioButtonWorkers.Size = new System.Drawing.Size(80, 17);
            this.radioButtonWorkers.TabIndex = 0;
            this.radioButtonWorkers.TabStop = true;
            this.radioButtonWorkers.Text = "Pracownicy";
            this.radioButtonWorkers.UseVisualStyleBackColor = true;
            this.radioButtonWorkers.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // tb_change
            // 
            this.tb_change.Location = new System.Drawing.Point(12, 388);
            this.tb_change.Name = "tb_change";
            this.tb_change.Size = new System.Drawing.Size(132, 20);
            this.tb_change.TabIndex = 2;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(12, 415);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(132, 23);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "Zmiań wybraną wartość";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(667, 415);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(121, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Usuń wybrany rekord";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.tb_change);
            this.Controls.Add(this.groupBoxManager);
            this.Controls.Add(this.dataGridViewManager);
            this.Name = "Manager";
            this.Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManager)).EndInit();
            this.groupBoxManager.ResumeLayout(false);
            this.groupBoxManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewManager;
        private System.Windows.Forms.GroupBox groupBoxManager;
        private System.Windows.Forms.RadioButton radioButtonSchedule;
        private System.Windows.Forms.RadioButton radioButtonStops;
        private System.Windows.Forms.RadioButton radioButtonDepot;
        private System.Windows.Forms.RadioButton radioButtonTimetable;
        private System.Windows.Forms.RadioButton radioButtonVehicles;
        private System.Windows.Forms.RadioButton radioButtonCrash;
        private System.Windows.Forms.RadioButton radioButtonWorkers;
        private System.Windows.Forms.TextBox tb_change;
        private System.Windows.Forms.RadioButton radioButtonLineNumber;
        private System.Windows.Forms.RadioButton radioButtonTimeOfArrival;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
    }
}