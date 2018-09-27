namespace WindowsFormsApp1
{
    partial class SobelParameters
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudXOrder = new System.Windows.Forms.NumericUpDown();
            this.nudAperture = new System.Windows.Forms.NumericUpDown();
            this.nudYOrder = new System.Windows.Forms.NumericUpDown();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAperture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.nudYOrder);
            this.groupBox1.Controls.Add(this.nudAperture);
            this.groupBox1.Controls.Add(this.nudXOrder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sobel Parameters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aperture Size";
            // 
            // nudXOrder
            // 
            this.nudXOrder.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudXOrder.Location = new System.Drawing.Point(87, 20);
            this.nudXOrder.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudXOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudXOrder.Name = "nudXOrder";
            this.nudXOrder.Size = new System.Drawing.Size(120, 20);
            this.nudXOrder.TabIndex = 3;
            this.nudXOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAperture
            // 
            this.nudAperture.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudAperture.Location = new System.Drawing.Point(87, 108);
            this.nudAperture.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudAperture.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAperture.Name = "nudAperture";
            this.nudAperture.Size = new System.Drawing.Size(120, 20);
            this.nudAperture.TabIndex = 4;
            this.nudAperture.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudYOrder
            // 
            this.nudYOrder.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudYOrder.Location = new System.Drawing.Point(87, 59);
            this.nudYOrder.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudYOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudYOrder.Name = "nudYOrder";
            this.nudYOrder.Size = new System.Drawing.Size(120, 20);
            this.nudYOrder.TabIndex = 5;
            this.nudYOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(13, 171);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(120, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SobelParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 293);
            this.Controls.Add(this.groupBox1);
            this.Name = "SobelParameters";
            this.Text = "SobelParameters";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAperture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.NumericUpDown nudYOrder;
        private System.Windows.Forms.NumericUpDown nudAperture;
        private System.Windows.Forms.NumericUpDown nudXOrder;
    }
}