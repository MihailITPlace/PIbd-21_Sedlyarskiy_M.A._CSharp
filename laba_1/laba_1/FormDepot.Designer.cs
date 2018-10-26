namespace laba_1
{
    partial class FormDepot
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
            this.buttonSetElectricLocomotive = new System.Windows.Forms.Button();
            this.buttonSetMonorail = new System.Windows.Forms.Button();
            this.groupBoxTakeTrain = new System.Windows.Forms.GroupBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonTakeTrain = new System.Windows.Forms.Button();
            this.pictureBoxTakeTrain = new System.Windows.Forms.PictureBox();
            this.labelNumberPlace = new System.Windows.Forms.Label();
            this.pictureBoxDepot = new System.Windows.Forms.PictureBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.groupBoxTakeTrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetElectricLocomotive
            // 
            this.buttonSetElectricLocomotive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetElectricLocomotive.Location = new System.Drawing.Point(854, 148);
            this.buttonSetElectricLocomotive.Name = "buttonSetElectricLocomotive";
            this.buttonSetElectricLocomotive.Size = new System.Drawing.Size(192, 65);
            this.buttonSetElectricLocomotive.TabIndex = 1;
            this.buttonSetElectricLocomotive.Text = "Добавить локомотив";
            this.buttonSetElectricLocomotive.UseVisualStyleBackColor = true;
            this.buttonSetElectricLocomotive.Click += new System.EventHandler(this.buttonSetElectricLocomotive_Click);
            // 
            // buttonSetMonorail
            // 
            this.buttonSetMonorail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetMonorail.Location = new System.Drawing.Point(854, 219);
            this.buttonSetMonorail.Name = "buttonSetMonorail";
            this.buttonSetMonorail.Size = new System.Drawing.Size(192, 65);
            this.buttonSetMonorail.TabIndex = 2;
            this.buttonSetMonorail.Text = "Добавить монорельс";
            this.buttonSetMonorail.UseVisualStyleBackColor = true;
            this.buttonSetMonorail.Click += new System.EventHandler(this.buttonSetMonorail_Click);
            // 
            // groupBoxTakeTrain
            // 
            this.groupBoxTakeTrain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTakeTrain.Controls.Add(this.maskedTextBox);
            this.groupBoxTakeTrain.Controls.Add(this.buttonTakeTrain);
            this.groupBoxTakeTrain.Controls.Add(this.pictureBoxTakeTrain);
            this.groupBoxTakeTrain.Controls.Add(this.labelNumberPlace);
            this.groupBoxTakeTrain.Location = new System.Drawing.Point(854, 299);
            this.groupBoxTakeTrain.Name = "groupBoxTakeTrain";
            this.groupBoxTakeTrain.Size = new System.Drawing.Size(192, 184);
            this.groupBoxTakeTrain.TabIndex = 3;
            this.groupBoxTakeTrain.TabStop = false;
            this.groupBoxTakeTrain.Text = "Забрать состав";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(60, 19);
            this.maskedTextBox.Mask = "00";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBox.TabIndex = 3;
            this.maskedTextBox.ValidatingType = typeof(int);
            // 
            // buttonTakeTrain
            // 
            this.buttonTakeTrain.Location = new System.Drawing.Point(18, 54);
            this.buttonTakeTrain.Name = "buttonTakeTrain";
            this.buttonTakeTrain.Size = new System.Drawing.Size(160, 23);
            this.buttonTakeTrain.TabIndex = 2;
            this.buttonTakeTrain.Text = "Забрать состав";
            this.buttonTakeTrain.UseVisualStyleBackColor = true;
            this.buttonTakeTrain.Click += new System.EventHandler(this.buttonTakeTrain_Click);
            // 
            // pictureBoxTakeTrain
            // 
            this.pictureBoxTakeTrain.Location = new System.Drawing.Point(18, 83);
            this.pictureBoxTakeTrain.Name = "pictureBoxTakeTrain";
            this.pictureBoxTakeTrain.Size = new System.Drawing.Size(160, 95);
            this.pictureBoxTakeTrain.TabIndex = 1;
            this.pictureBoxTakeTrain.TabStop = false;
            // 
            // labelNumberPlace
            // 
            this.labelNumberPlace.AutoSize = true;
            this.labelNumberPlace.Location = new System.Drawing.Point(15, 22);
            this.labelNumberPlace.Name = "labelNumberPlace";
            this.labelNumberPlace.Size = new System.Drawing.Size(39, 13);
            this.labelNumberPlace.TabIndex = 0;
            this.labelNumberPlace.Text = "Место";
            // 
            // pictureBoxDepot
            // 
            this.pictureBoxDepot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDepot.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDepot.Name = "pictureBoxDepot";
            this.pictureBoxDepot.Size = new System.Drawing.Size(848, 483);
            this.pictureBoxDepot.TabIndex = 0;
            this.pictureBoxDepot.TabStop = false;
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(854, 12);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(192, 121);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // FormDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 492);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBoxTakeTrain);
            this.Controls.Add(this.buttonSetMonorail);
            this.Controls.Add(this.buttonSetElectricLocomotive);
            this.Controls.Add(this.pictureBoxDepot);
            this.Name = "FormDepot";
            this.Text = "Депо";
            this.groupBoxTakeTrain.ResumeLayout(false);
            this.groupBoxTakeTrain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDepot;
        private System.Windows.Forms.Button buttonSetElectricLocomotive;
        private System.Windows.Forms.Button buttonSetMonorail;
        private System.Windows.Forms.GroupBox groupBoxTakeTrain;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Button buttonTakeTrain;
        private System.Windows.Forms.PictureBox pictureBoxTakeTrain;
        private System.Windows.Forms.Label labelNumberPlace;
        private System.Windows.Forms.ListBox listBoxLevels;
    }
}