namespace lab4Assignement
{
    partial class frmUpdateOrder
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.lblRequiredDate = new System.Windows.Forms.Label();
            this.txtshippingDate = new System.Windows.Forms.TextBox();
            this.lblShippedDate = new System.Windows.Forms.Label();
            this.dtPickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtPickerRequiredTime = new System.Windows.Forms.DateTimePicker();
            this.dtPickerShippedDate = new System.Windows.Forms.DateTimePicker();
            this.grpbxCurrantvalue = new System.Windows.Forms.GroupBox();
            this.grpNewvalue = new System.Windows.Forms.GroupBox();
            this.grpbxCurrantvalue.SuspendLayout();
            this.grpNewvalue.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(775, 253);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(617, 253);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(112, 35);
            this.btnAccept.TabIndex = 22;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(179, 35);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(212, 26);
            this.txtOrderDate.TabIndex = 13;
            this.txtOrderDate.Tag = "Order date";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(41, 35);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(88, 20);
            this.lblOrderDate.TabIndex = 12;
            this.lblOrderDate.Text = "Order Date";
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(179, 89);
            this.txtRequiredDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.ReadOnly = true;
            this.txtRequiredDate.Size = new System.Drawing.Size(212, 26);
            this.txtRequiredDate.TabIndex = 25;
            this.txtRequiredDate.Tag = "Order date";
            // 
            // lblRequiredDate
            // 
            this.lblRequiredDate.AutoSize = true;
            this.lblRequiredDate.Location = new System.Drawing.Point(42, 89);
            this.lblRequiredDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequiredDate.Name = "lblRequiredDate";
            this.lblRequiredDate.Size = new System.Drawing.Size(113, 20);
            this.lblRequiredDate.TabIndex = 24;
            this.lblRequiredDate.Text = "Required Date";
            // 
            // txtshippingDate
            // 
            this.txtshippingDate.Location = new System.Drawing.Point(179, 134);
            this.txtshippingDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtshippingDate.Name = "txtshippingDate";
            this.txtshippingDate.ReadOnly = true;
            this.txtshippingDate.Size = new System.Drawing.Size(212, 26);
            this.txtshippingDate.TabIndex = 27;
            this.txtshippingDate.Tag = "Order date";
            // 
            // lblShippedDate
            // 
            this.lblShippedDate.AutoSize = true;
            this.lblShippedDate.Location = new System.Drawing.Point(42, 134);
            this.lblShippedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShippedDate.Name = "lblShippedDate";
            this.lblShippedDate.Size = new System.Drawing.Size(107, 20);
            this.lblShippedDate.TabIndex = 26;
            this.lblShippedDate.Text = "Shipped Date";
            // 
            // dtPickerOrderDate
            // 
            this.dtPickerOrderDate.Location = new System.Drawing.Point(37, 35);
            this.dtPickerOrderDate.Name = "dtPickerOrderDate";
            this.dtPickerOrderDate.Size = new System.Drawing.Size(200, 26);
            this.dtPickerOrderDate.TabIndex = 28;
            // 
            // dtPickerRequiredTime
            // 
            this.dtPickerRequiredTime.Location = new System.Drawing.Point(37, 89);
            this.dtPickerRequiredTime.Name = "dtPickerRequiredTime";
            this.dtPickerRequiredTime.Size = new System.Drawing.Size(200, 26);
            this.dtPickerRequiredTime.TabIndex = 29;
            // 
            // dtPickerShippedDate
            // 
            this.dtPickerShippedDate.Location = new System.Drawing.Point(37, 134);
            this.dtPickerShippedDate.Name = "dtPickerShippedDate";
            this.dtPickerShippedDate.Size = new System.Drawing.Size(200, 26);
            this.dtPickerShippedDate.TabIndex = 30;
            // 
            // grpbxCurrantvalue
            // 
            this.grpbxCurrantvalue.Controls.Add(this.txtshippingDate);
            this.grpbxCurrantvalue.Controls.Add(this.lblOrderDate);
            this.grpbxCurrantvalue.Controls.Add(this.txtOrderDate);
            this.grpbxCurrantvalue.Controls.Add(this.lblRequiredDate);
            this.grpbxCurrantvalue.Controls.Add(this.txtRequiredDate);
            this.grpbxCurrantvalue.Controls.Add(this.lblShippedDate);
            this.grpbxCurrantvalue.Location = new System.Drawing.Point(22, 25);
            this.grpbxCurrantvalue.Name = "grpbxCurrantvalue";
            this.grpbxCurrantvalue.Size = new System.Drawing.Size(434, 191);
            this.grpbxCurrantvalue.TabIndex = 31;
            this.grpbxCurrantvalue.TabStop = false;
            this.grpbxCurrantvalue.Text = "Currant Value ";
            // 
            // grpNewvalue
            // 
            this.grpNewvalue.Controls.Add(this.dtPickerShippedDate);
            this.grpNewvalue.Controls.Add(this.dtPickerOrderDate);
            this.grpNewvalue.Controls.Add(this.dtPickerRequiredTime);
            this.grpNewvalue.Location = new System.Drawing.Point(510, 25);
            this.grpNewvalue.Name = "grpNewvalue";
            this.grpNewvalue.Size = new System.Drawing.Size(377, 191);
            this.grpNewvalue.TabIndex = 32;
            this.grpNewvalue.TabStop = false;
            this.grpNewvalue.Text = "New Value";
            // 
            // frmUpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 333);
            this.Controls.Add(this.grpNewvalue);
            this.Controls.Add(this.grpbxCurrantvalue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Name = "frmUpdateOrder";
            this.Text = "Order Update";
            this.Load += new System.EventHandler(this.frmUpdateOrder_Load);
            this.grpbxCurrantvalue.ResumeLayout(false);
            this.grpbxCurrantvalue.PerformLayout();
            this.grpNewvalue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.Label lblRequiredDate;
        private System.Windows.Forms.TextBox txtshippingDate;
        private System.Windows.Forms.Label lblShippedDate;
        private System.Windows.Forms.DateTimePicker dtPickerOrderDate;
        private System.Windows.Forms.DateTimePicker dtPickerRequiredTime;
        private System.Windows.Forms.DateTimePicker dtPickerShippedDate;
        private System.Windows.Forms.GroupBox grpbxCurrantvalue;
        private System.Windows.Forms.GroupBox grpNewvalue;
    }
}