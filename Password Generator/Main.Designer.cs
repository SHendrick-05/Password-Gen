
namespace Password_Generator
{
    partial class Main
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
            this.top = new System.Windows.Forms.Panel();
            this.min = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.len = new System.Windows.Forms.NumericUpDown();
            this.lenLabel = new System.Windows.Forms.Label();
            this.lower = new System.Windows.Forms.CheckBox();
            this.lowerLabel = new System.Windows.Forms.Label();
            this.upperLabel = new System.Windows.Forms.Label();
            this.upper = new System.Windows.Forms.CheckBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.CheckBox();
            this.symbLabel = new System.Windows.Forms.Label();
            this.symb = new System.Windows.Forms.CheckBox();
            this.output = new System.Windows.Forms.TextBox();
            this.genButton = new System.Windows.Forms.Button();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.len)).BeginInit();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.top.Controls.Add(this.min);
            this.top.Controls.Add(this.close);
            this.top.Controls.Add(this.title);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(836, 49);
            this.top.TabIndex = 0;
            // 
            // min
            // 
            this.min.Dock = System.Windows.Forms.DockStyle.Right;
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.SystemColors.Control;
            this.min.Location = new System.Drawing.Point(678, 0);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(79, 49);
            this.min.TabIndex = 2;
            this.min.Text = "_";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.Control;
            this.close.Location = new System.Drawing.Point(757, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(79, 49);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(12, 7);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(302, 36);
            this.title.TabIndex = 0;
            this.title.Text = "Password Generator";
            // 
            // len
            // 
            this.len.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.len.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.len.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.len.ForeColor = System.Drawing.SystemColors.Control;
            this.len.Location = new System.Drawing.Point(466, 94);
            this.len.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.len.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.len.Name = "len";
            this.len.Size = new System.Drawing.Size(120, 29);
            this.len.TabIndex = 2;
            this.len.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lenLabel
            // 
            this.lenLabel.AutoSize = true;
            this.lenLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.lenLabel.Location = new System.Drawing.Point(177, 93);
            this.lenLabel.Name = "lenLabel";
            this.lenLabel.Size = new System.Drawing.Size(176, 24);
            this.lenLabel.TabIndex = 3;
            this.lenLabel.Text = "Password length";
            // 
            // lower
            // 
            this.lower.AutoSize = true;
            this.lower.Checked = true;
            this.lower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lower.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lower.ForeColor = System.Drawing.SystemColors.Control;
            this.lower.Location = new System.Drawing.Point(466, 155);
            this.lower.Name = "lower";
            this.lower.Size = new System.Drawing.Size(12, 11);
            this.lower.TabIndex = 4;
            this.lower.UseVisualStyleBackColor = true;
            // 
            // lowerLabel
            // 
            this.lowerLabel.AutoSize = true;
            this.lowerLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.lowerLabel.Location = new System.Drawing.Point(177, 148);
            this.lowerLabel.Name = "lowerLabel";
            this.lowerLabel.Size = new System.Drawing.Size(172, 24);
            this.lowerLabel.TabIndex = 5;
            this.lowerLabel.Text = "Lowercase [a-z]";
            // 
            // upperLabel
            // 
            this.upperLabel.AutoSize = true;
            this.upperLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.upperLabel.Location = new System.Drawing.Point(177, 193);
            this.upperLabel.Name = "upperLabel";
            this.upperLabel.Size = new System.Drawing.Size(173, 24);
            this.upperLabel.TabIndex = 6;
            this.upperLabel.Text = "Uppercase [A-Z]";
            // 
            // upper
            // 
            this.upper.AutoSize = true;
            this.upper.Checked = true;
            this.upper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.upper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upper.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upper.ForeColor = System.Drawing.SystemColors.Control;
            this.upper.Location = new System.Drawing.Point(466, 200);
            this.upper.Name = "upper";
            this.upper.Size = new System.Drawing.Size(12, 11);
            this.upper.TabIndex = 7;
            this.upper.UseVisualStyleBackColor = true;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.numberLabel.Location = new System.Drawing.Point(177, 235);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(153, 24);
            this.numberLabel.TabIndex = 8;
            this.numberLabel.Text = "Numbers [0-9]";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Checked = true;
            this.number.CheckState = System.Windows.Forms.CheckState.Checked;
            this.number.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.ForeColor = System.Drawing.SystemColors.Control;
            this.number.Location = new System.Drawing.Point(466, 242);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(12, 11);
            this.number.TabIndex = 9;
            this.number.UseVisualStyleBackColor = true;
            // 
            // symbLabel
            // 
            this.symbLabel.AutoSize = true;
            this.symbLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.symbLabel.Location = new System.Drawing.Point(177, 278);
            this.symbLabel.Name = "symbLabel";
            this.symbLabel.Size = new System.Drawing.Size(93, 24);
            this.symbLabel.TabIndex = 10;
            this.symbLabel.Text = "Symbols";
            // 
            // symb
            // 
            this.symb.AutoSize = true;
            this.symb.Checked = true;
            this.symb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.symb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.symb.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symb.ForeColor = System.Drawing.SystemColors.Control;
            this.symb.Location = new System.Drawing.Point(466, 285);
            this.symb.Name = "symb";
            this.symb.Size = new System.Drawing.Size(12, 11);
            this.symb.TabIndex = 11;
            this.symb.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.output.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.SystemColors.Control;
            this.output.Location = new System.Drawing.Point(181, 422);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(405, 33);
            this.output.TabIndex = 12;
            // 
            // genButton
            // 
            this.genButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genButton.ForeColor = System.Drawing.SystemColors.Control;
            this.genButton.Location = new System.Drawing.Point(251, 378);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(265, 38);
            this.genButton.TabIndex = 13;
            this.genButton.Text = "Generate!";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(836, 482);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.output);
            this.Controls.Add(this.symb);
            this.Controls.Add(this.symbLabel);
            this.Controls.Add(this.number);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.upper);
            this.Controls.Add(this.upperLabel);
            this.Controls.Add(this.lowerLabel);
            this.Controls.Add(this.lower);
            this.Controls.Add(this.lenLabel);
            this.Controls.Add(this.len);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.len)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.NumericUpDown len;
        private System.Windows.Forms.Label lenLabel;
        private System.Windows.Forms.CheckBox lower;
        private System.Windows.Forms.Label lowerLabel;
        private System.Windows.Forms.Label upperLabel;
        private System.Windows.Forms.CheckBox upper;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.CheckBox number;
        private System.Windows.Forms.Label symbLabel;
        private System.Windows.Forms.CheckBox symb;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button genButton;
    }
}

