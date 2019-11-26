namespace coachUI
{
    partial class Form1
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
            this.addButton = new System.Windows.Forms.Button();
            this.getButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.ageTextbox = new System.Windows.Forms.TextBox();
            this.seatTextbox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.seatLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.AccessibleName = "";
            this.addButton.BackColor = System.Drawing.Color.Red;
            this.addButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addButton.Location = new System.Drawing.Point(38, 301);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(113, 64);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add To Bus";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // getButton
            // 
            this.getButton.AccessibleName = "";
            this.getButton.BackColor = System.Drawing.Color.Red;
            this.getButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.getButton.Location = new System.Drawing.Point(209, 288);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(113, 64);
            this.getButton.TabIndex = 1;
            this.getButton.Text = "Get by name";
            this.getButton.UseVisualStyleBackColor = false;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.AccessibleName = "";
            this.removeButton.BackColor = System.Drawing.Color.Red;
            this.removeButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.removeButton.Location = new System.Drawing.Point(402, 300);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(113, 64);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AccessibleName = "";
            this.clearButton.BackColor = System.Drawing.Color.Red;
            this.clearButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clearButton.Location = new System.Drawing.Point(209, 538);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(113, 64);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(165, 76);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(296, 20);
            this.nameTextbox.TabIndex = 4;
            this.nameTextbox.TextChanged += new System.EventHandler(this.nameTextbox_TextChanged);
            // 
            // ageTextbox
            // 
            this.ageTextbox.Location = new System.Drawing.Point(165, 129);
            this.ageTextbox.Name = "ageTextbox";
            this.ageTextbox.Size = new System.Drawing.Size(54, 20);
            this.ageTextbox.TabIndex = 5;
            this.ageTextbox.TextChanged += new System.EventHandler(this.ageTextbox_TextChanged);
            // 
            // seatTextbox
            // 
            this.seatTextbox.Location = new System.Drawing.Point(165, 191);
            this.seatTextbox.Name = "seatTextbox";
            this.seatTextbox.Size = new System.Drawing.Size(54, 20);
            this.seatTextbox.TabIndex = 6;
            this.seatTextbox.TextChanged += new System.EventHandler(this.seatTextbox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(116, 76);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // seatLabel
            // 
            this.seatLabel.AutoSize = true;
            this.seatLabel.Location = new System.Drawing.Point(116, 191);
            this.seatLabel.Name = "seatLabel";
            this.seatLabel.Size = new System.Drawing.Size(29, 13);
            this.seatLabel.TabIndex = 8;
            this.seatLabel.Text = "Seat";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(116, 129);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 9;
            this.ageLabel.Text = "Age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 737);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.seatLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.seatTextbox);
            this.Controls.Add(this.ageTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox ageTextbox;
        private System.Windows.Forms.TextBox seatTextbox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label seatLabel;
        private System.Windows.Forms.Label ageLabel;
    }
}

