namespace Tusk2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.buttonStartDataStream = new System.Windows.Forms.Button();
            this.buttonStopDataStream = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelSensor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 12);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1276, 664);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // buttonStartDataStream
            // 
            this.buttonStartDataStream.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartDataStream.BackColor = System.Drawing.Color.White;
            this.buttonStartDataStream.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartDataStream.Location = new System.Drawing.Point(1311, 132);
            this.buttonStartDataStream.Name = "buttonStartDataStream";
            this.buttonStartDataStream.Size = new System.Drawing.Size(87, 37);
            this.buttonStartDataStream.TabIndex = 4;
            this.buttonStartDataStream.Text = "Начать";
            this.buttonStartDataStream.UseVisualStyleBackColor = false;
            this.buttonStartDataStream.Click += new System.EventHandler(this.buttonStartDataStream_Click_1);
            // 
            // buttonStopDataStream
            // 
            this.buttonStopDataStream.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStopDataStream.BackColor = System.Drawing.Color.White;
            this.buttonStopDataStream.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopDataStream.Location = new System.Drawing.Point(1311, 194);
            this.buttonStopDataStream.Name = "buttonStopDataStream";
            this.buttonStopDataStream.Size = new System.Drawing.Size(87, 37);
            this.buttonStopDataStream.TabIndex = 5;
            this.buttonStopDataStream.Text = "Остановить";
            this.buttonStopDataStream.UseVisualStyleBackColor = false;
            this.buttonStopDataStream.Click += new System.EventHandler(this.buttonStopDataStream_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Location = new System.Drawing.Point(1311, 265);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(87, 37);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.BackColor = System.Drawing.Color.White;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(1311, 332);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(87, 37);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelSensor
            // 
            this.labelSensor.AutoSize = true;
            this.labelSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSensor.ForeColor = System.Drawing.Color.Red;
            this.labelSensor.Location = new System.Drawing.Point(1311, 87);
            this.labelSensor.Name = "labelSensor";
            this.labelSensor.Size = new System.Drawing.Size(87, 16);
            this.labelSensor.TabIndex = 8;
            this.labelSensor.Text = "Остановлен";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 697);
            this.Controls.Add(this.labelSensor);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonStopDataStream);
            this.Controls.Add(this.buttonStartDataStream);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        public System.Windows.Forms.Button buttonStartDataStream;
        public System.Windows.Forms.Button buttonStopDataStream;
        public System.Windows.Forms.Button buttonClear;
        public System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelSensor;
    }
}

