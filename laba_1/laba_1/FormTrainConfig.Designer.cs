namespace laba_1
{
    partial class FormTrainConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMonorail = new System.Windows.Forms.Label();
            this.labelElectricLocomotive = new System.Windows.Forms.Label();
            this.panelTrain = new System.Windows.Forms.Panel();
            this.labelAddColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.pictureBoxTrain = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelFlesh = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panelTrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrain)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMonorail);
            this.groupBox1.Controls.Add(this.labelElectricLocomotive);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип поезда";
            // 
            // labelMonorail
            // 
            this.labelMonorail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMonorail.Location = new System.Drawing.Point(6, 80);
            this.labelMonorail.Name = "labelMonorail";
            this.labelMonorail.Size = new System.Drawing.Size(120, 50);
            this.labelMonorail.TabIndex = 1;
            this.labelMonorail.Text = "Монорельс";
            this.labelMonorail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMonorail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelMonorail_MouseDown);
            // 
            // labelElectricLocomotive
            // 
            this.labelElectricLocomotive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelElectricLocomotive.Location = new System.Drawing.Point(6, 21);
            this.labelElectricLocomotive.Name = "labelElectricLocomotive";
            this.labelElectricLocomotive.Size = new System.Drawing.Size(120, 50);
            this.labelElectricLocomotive.TabIndex = 0;
            this.labelElectricLocomotive.Text = "Электричка";
            this.labelElectricLocomotive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelElectricLocomotive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelElectricLocomotive_MouseDown);
            // 
            // panelTrain
            // 
            this.panelTrain.AllowDrop = true;
            this.panelTrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTrain.Controls.Add(this.labelAddColor);
            this.panelTrain.Controls.Add(this.labelBaseColor);
            this.panelTrain.Controls.Add(this.pictureBoxTrain);
            this.panelTrain.Location = new System.Drawing.Point(152, 12);
            this.panelTrain.Name = "panelTrain";
            this.panelTrain.Size = new System.Drawing.Size(191, 240);
            this.panelTrain.TabIndex = 4;
            this.panelTrain.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTrain_DragDrop);
            this.panelTrain.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTrain_DragEnter);
            // 
            // labelAddColor
            // 
            this.labelAddColor.AllowDrop = true;
            this.labelAddColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAddColor.Location = new System.Drawing.Point(16, 195);
            this.labelAddColor.Name = "labelAddColor";
            this.labelAddColor.Size = new System.Drawing.Size(160, 35);
            this.labelAddColor.TabIndex = 3;
            this.labelAddColor.Text = "Доп. цвет";
            this.labelAddColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAddColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelAddColor_DragDrop);
            this.labelAddColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(16, 148);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(160, 35);
            this.labelBaseColor.TabIndex = 2;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // pictureBoxTrain
            // 
            this.pictureBoxTrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTrain.Location = new System.Drawing.Point(16, 21);
            this.pictureBoxTrain.Name = "pictureBoxTrain";
            this.pictureBoxTrain.Size = new System.Drawing.Size(160, 109);
            this.pictureBoxTrain.TabIndex = 1;
            this.pictureBoxTrain.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelWhite);
            this.groupBox2.Controls.Add(this.panelYellow);
            this.groupBox2.Controls.Add(this.panelPink);
            this.groupBox2.Controls.Add(this.panelBlue);
            this.groupBox2.Controls.Add(this.panelOrange);
            this.groupBox2.Controls.Add(this.panelFlesh);
            this.groupBox2.Controls.Add(this.panelGreen);
            this.groupBox2.Controls.Add(this.panelBlack);
            this.groupBox2.Location = new System.Drawing.Point(349, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 240);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(52, 159);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(40, 40);
            this.panelWhite.TabIndex = 3;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelYellow.Location = new System.Drawing.Point(52, 113);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(40, 40);
            this.panelYellow.TabIndex = 3;
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelPink.Location = new System.Drawing.Point(6, 159);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(40, 40);
            this.panelPink.TabIndex = 2;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelBlue.Location = new System.Drawing.Point(52, 67);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(40, 40);
            this.panelBlue.TabIndex = 3;
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelOrange.Location = new System.Drawing.Point(6, 113);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(40, 40);
            this.panelOrange.TabIndex = 2;
            // 
            // panelFlesh
            // 
            this.panelFlesh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelFlesh.Location = new System.Drawing.Point(52, 21);
            this.panelFlesh.Name = "panelFlesh";
            this.panelFlesh.Size = new System.Drawing.Size(40, 40);
            this.panelFlesh.TabIndex = 1;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelGreen.Location = new System.Drawing.Point(6, 67);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(40, 40);
            this.panelGreen.TabIndex = 2;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(6, 21);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(40, 40);
            this.panelBlack.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 160);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(134, 35);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 207);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(134, 35);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormTrainConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 263);
            this.Controls.Add(this.panelTrain);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(476, 301);
            this.MinimumSize = new System.Drawing.Size(476, 301);
            this.Name = "FormTrainConfig";
            this.Text = "Выбор поезда";
            this.groupBox1.ResumeLayout(false);
            this.panelTrain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrain)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMonorail;
        private System.Windows.Forms.Label labelElectricLocomotive;
        private System.Windows.Forms.Panel panelTrain;
        private System.Windows.Forms.PictureBox pictureBoxTrain;
        private System.Windows.Forms.Label labelAddColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelFlesh;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}