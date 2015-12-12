﻿namespace ActionRepeater.Forms
{
    partial class frmAddEvent
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
            this.components = new System.ComponentModel.Container();
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.txtKeys = new System.Windows.Forms.TextBox();
            this.cmbMouseButton = new System.Windows.Forms.ComboBox();
            this.numWaitMS = new System.Windows.Forms.NumericUpDown();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblWait = new System.Windows.Forms.Label();
            this.lblMouseX = new System.Windows.Forms.Label();
            this.lblMouseY = new System.Windows.Forms.Label();
            this.lblMouseRX = new System.Windows.Forms.Label();
            this.lblMouseRY = new System.Windows.Forms.Label();
            this.lblMouseSpeed = new System.Windows.Forms.Label();
            this.lblKeys = new System.Windows.Forms.Label();
            this.lblButton = new System.Windows.Forms.Label();
            this.numMouseX = new System.Windows.Forms.NumericUpDown();
            this.numMouseY = new System.Windows.Forms.NumericUpDown();
            this.numMouseRX = new System.Windows.Forms.NumericUpDown();
            this.numMouseRY = new System.Windows.Forms.NumericUpDown();
            this.numMouseSpeed = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCurrMousePos = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblXPos = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblYPos = new System.Windows.Forms.Label();
            this.tmrCursUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numWaitMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseRX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseRY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEventType
            // 
            this.cmbEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventType.FormattingEnabled = true;
            this.cmbEventType.Items.AddRange(new object[] {
            "Wait",
            "Move Mouse",
            "Send Keys",
            "Click Mouse"});
            this.cmbEventType.Location = new System.Drawing.Point(98, 12);
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.Size = new System.Drawing.Size(142, 21);
            this.cmbEventType.TabIndex = 0;
            this.cmbEventType.SelectedIndexChanged += new System.EventHandler(this.cmbEventType_SelectedIndexChanged);
            // 
            // txtKeys
            // 
            this.txtKeys.Enabled = false;
            this.txtKeys.Location = new System.Drawing.Point(120, 209);
            this.txtKeys.MaxLength = 10;
            this.txtKeys.Name = "txtKeys";
            this.txtKeys.Size = new System.Drawing.Size(120, 20);
            this.txtKeys.TabIndex = 7;
            // 
            // cmbMouseButton
            // 
            this.cmbMouseButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMouseButton.Enabled = false;
            this.cmbMouseButton.FormattingEnabled = true;
            this.cmbMouseButton.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.cmbMouseButton.Location = new System.Drawing.Point(120, 235);
            this.cmbMouseButton.Name = "cmbMouseButton";
            this.cmbMouseButton.Size = new System.Drawing.Size(120, 21);
            this.cmbMouseButton.TabIndex = 8;
            // 
            // numWaitMS
            // 
            this.numWaitMS.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numWaitMS.Location = new System.Drawing.Point(120, 50);
            this.numWaitMS.Maximum = new decimal(new int[] {
            99990,
            0,
            0,
            0});
            this.numWaitMS.Name = "numWaitMS";
            this.numWaitMS.Size = new System.Drawing.Size(120, 20);
            this.numWaitMS.TabIndex = 1;
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(12, 15);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(65, 13);
            this.lblEventType.TabIndex = 10;
            this.lblEventType.Text = "Event Type:";
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Location = new System.Drawing.Point(12, 52);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(80, 13);
            this.lblWait.TabIndex = 11;
            this.lblWait.Text = "Wait Time (ms):";
            // 
            // lblMouseX
            // 
            this.lblMouseX.AutoSize = true;
            this.lblMouseX.Enabled = false;
            this.lblMouseX.Location = new System.Drawing.Point(12, 81);
            this.lblMouseX.Name = "lblMouseX";
            this.lblMouseX.Size = new System.Drawing.Size(52, 13);
            this.lblMouseX.TabIndex = 12;
            this.lblMouseX.Text = "Mouse X:";
            // 
            // lblMouseY
            // 
            this.lblMouseY.AutoSize = true;
            this.lblMouseY.Enabled = false;
            this.lblMouseY.Location = new System.Drawing.Point(12, 107);
            this.lblMouseY.Name = "lblMouseY";
            this.lblMouseY.Size = new System.Drawing.Size(52, 13);
            this.lblMouseY.TabIndex = 13;
            this.lblMouseY.Text = "Mouse Y:";
            // 
            // lblMouseRX
            // 
            this.lblMouseRX.AutoSize = true;
            this.lblMouseRX.Enabled = false;
            this.lblMouseRX.Location = new System.Drawing.Point(12, 133);
            this.lblMouseRX.Name = "lblMouseRX";
            this.lblMouseRX.Size = new System.Drawing.Size(95, 13);
            this.lblMouseRX.TabIndex = 14;
            this.lblMouseRX.Text = "Mouse Random X:";
            // 
            // lblMouseRY
            // 
            this.lblMouseRY.AutoSize = true;
            this.lblMouseRY.Enabled = false;
            this.lblMouseRY.Location = new System.Drawing.Point(12, 159);
            this.lblMouseRY.Name = "lblMouseRY";
            this.lblMouseRY.Size = new System.Drawing.Size(95, 13);
            this.lblMouseRY.TabIndex = 15;
            this.lblMouseRY.Text = "Mouse Random Y:";
            // 
            // lblMouseSpeed
            // 
            this.lblMouseSpeed.AutoSize = true;
            this.lblMouseSpeed.Enabled = false;
            this.lblMouseSpeed.Location = new System.Drawing.Point(12, 185);
            this.lblMouseSpeed.Name = "lblMouseSpeed";
            this.lblMouseSpeed.Size = new System.Drawing.Size(76, 13);
            this.lblMouseSpeed.TabIndex = 16;
            this.lblMouseSpeed.Text = "Mouse Speed:";
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.Enabled = false;
            this.lblKeys.Location = new System.Drawing.Point(12, 212);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(73, 13);
            this.lblKeys.TabIndex = 17;
            this.lblKeys.Text = "Keys to Send:";
            // 
            // lblButton
            // 
            this.lblButton.AutoSize = true;
            this.lblButton.Enabled = false;
            this.lblButton.Location = new System.Drawing.Point(12, 238);
            this.lblButton.Name = "lblButton";
            this.lblButton.Size = new System.Drawing.Size(102, 13);
            this.lblButton.TabIndex = 18;
            this.lblButton.Text = "Mouse Button Click:";
            // 
            // numMouseX
            // 
            this.numMouseX.Enabled = false;
            this.numMouseX.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numMouseX.Location = new System.Drawing.Point(120, 79);
            this.numMouseX.Maximum = new decimal(new int[] {
            99990,
            0,
            0,
            0});
            this.numMouseX.Name = "numMouseX";
            this.numMouseX.Size = new System.Drawing.Size(120, 20);
            this.numMouseX.TabIndex = 2;
            // 
            // numMouseY
            // 
            this.numMouseY.Enabled = false;
            this.numMouseY.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numMouseY.Location = new System.Drawing.Point(120, 105);
            this.numMouseY.Maximum = new decimal(new int[] {
            99990,
            0,
            0,
            0});
            this.numMouseY.Name = "numMouseY";
            this.numMouseY.Size = new System.Drawing.Size(120, 20);
            this.numMouseY.TabIndex = 3;
            // 
            // numMouseRX
            // 
            this.numMouseRX.Enabled = false;
            this.numMouseRX.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numMouseRX.Location = new System.Drawing.Point(120, 131);
            this.numMouseRX.Maximum = new decimal(new int[] {
            99990,
            0,
            0,
            0});
            this.numMouseRX.Name = "numMouseRX";
            this.numMouseRX.Size = new System.Drawing.Size(120, 20);
            this.numMouseRX.TabIndex = 4;
            // 
            // numMouseRY
            // 
            this.numMouseRY.Enabled = false;
            this.numMouseRY.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numMouseRY.Location = new System.Drawing.Point(120, 157);
            this.numMouseRY.Maximum = new decimal(new int[] {
            99990,
            0,
            0,
            0});
            this.numMouseRY.Name = "numMouseRY";
            this.numMouseRY.Size = new System.Drawing.Size(120, 20);
            this.numMouseRY.TabIndex = 5;
            // 
            // numMouseSpeed
            // 
            this.numMouseSpeed.Enabled = false;
            this.numMouseSpeed.Location = new System.Drawing.Point(120, 183);
            this.numMouseSpeed.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numMouseSpeed.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMouseSpeed.Name = "numMouseSpeed";
            this.numMouseSpeed.Size = new System.Drawing.Size(120, 20);
            this.numMouseSpeed.TabIndex = 6;
            this.numMouseSpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(15, 338);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 34);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(150, 338);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCurrMousePos
            // 
            this.lblCurrMousePos.AutoSize = true;
            this.lblCurrMousePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrMousePos.Location = new System.Drawing.Point(32, 266);
            this.lblCurrMousePos.Name = "lblCurrMousePos";
            this.lblCurrMousePos.Size = new System.Drawing.Size(173, 20);
            this.lblCurrMousePos.TabIndex = 19;
            this.lblCurrMousePos.Text = "Current Cursor Position";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(12, 291);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 20;
            this.lblX.Text = "X:";
            // 
            // lblXPos
            // 
            this.lblXPos.AutoSize = true;
            this.lblXPos.Location = new System.Drawing.Point(35, 291);
            this.lblXPos.Name = "lblXPos";
            this.lblXPos.Size = new System.Drawing.Size(0, 13);
            this.lblXPos.TabIndex = 21;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(12, 313);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 22;
            this.lblY.Text = "Y:";
            // 
            // lblYPos
            // 
            this.lblYPos.AutoSize = true;
            this.lblYPos.Location = new System.Drawing.Point(35, 313);
            this.lblYPos.Name = "lblYPos";
            this.lblYPos.Size = new System.Drawing.Size(0, 13);
            this.lblYPos.TabIndex = 23;
            // 
            // tmrCursUpdate
            // 
            this.tmrCursUpdate.Interval = 10;
            this.tmrCursUpdate.Tick += new System.EventHandler(this.tmrCursUpdate_Tick);
            // 
            // frmAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 377);
            this.Controls.Add(this.lblYPos);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblXPos);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblCurrMousePos);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numMouseSpeed);
            this.Controls.Add(this.numMouseRY);
            this.Controls.Add(this.numMouseRX);
            this.Controls.Add(this.numMouseY);
            this.Controls.Add(this.numMouseX);
            this.Controls.Add(this.lblButton);
            this.Controls.Add(this.lblKeys);
            this.Controls.Add(this.lblMouseSpeed);
            this.Controls.Add(this.lblMouseRY);
            this.Controls.Add(this.lblMouseRX);
            this.Controls.Add(this.lblMouseY);
            this.Controls.Add(this.lblMouseX);
            this.Controls.Add(this.lblWait);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.numWaitMS);
            this.Controls.Add(this.cmbMouseButton);
            this.Controls.Add(this.txtKeys);
            this.Controls.Add(this.cmbEventType);
            this.Name = "frmAddEvent";
            this.Text = "Add New Event";
            ((System.ComponentModel.ISupportInitialize)(this.numWaitMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseRX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseRY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEventType;
        private System.Windows.Forms.TextBox txtKeys;
        private System.Windows.Forms.ComboBox cmbMouseButton;
        private System.Windows.Forms.NumericUpDown numWaitMS;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.Label lblMouseX;
        private System.Windows.Forms.Label lblMouseY;
        private System.Windows.Forms.Label lblMouseRX;
        private System.Windows.Forms.Label lblMouseRY;
        private System.Windows.Forms.Label lblMouseSpeed;
        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.Label lblButton;
        private System.Windows.Forms.NumericUpDown numMouseX;
        private System.Windows.Forms.NumericUpDown numMouseY;
        private System.Windows.Forms.NumericUpDown numMouseRX;
        private System.Windows.Forms.NumericUpDown numMouseRY;
        private System.Windows.Forms.NumericUpDown numMouseSpeed;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCurrMousePos;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblXPos;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblYPos;
        private System.Windows.Forms.Timer tmrCursUpdate;
    }
}