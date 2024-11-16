namespace YouDoNote.Forms
{
    partial class UpdateForm
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
            gboxUpdate = new GroupBox();
            lblDate = new Label();
            btnUpdate = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rtxtContent = new RichTextBox();
            txtTitle = new TextBox();
            gboxUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // gboxUpdate
            // 
            gboxUpdate.BackColor = Color.FromArgb(255, 255, 128);
            gboxUpdate.Controls.Add(lblDate);
            gboxUpdate.Controls.Add(btnUpdate);
            gboxUpdate.Controls.Add(label3);
            gboxUpdate.Controls.Add(label2);
            gboxUpdate.Controls.Add(label1);
            gboxUpdate.Controls.Add(rtxtContent);
            gboxUpdate.Controls.Add(txtTitle);
            gboxUpdate.Location = new Point(136, 39);
            gboxUpdate.Name = "gboxUpdate";
            gboxUpdate.Size = new Size(528, 373);
            gboxUpdate.TabIndex = 1;
            gboxUpdate.TabStop = false;
            gboxUpdate.Enter += gboxUpdate_Enter;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(84, 310);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 20);
            lblDate.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 255, 128);
            btnUpdate.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(381, 324);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Save";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 177);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 4;
            label3.Text = "Note Content";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 101);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 3;
            label2.Text = "Note Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 23);
            label1.Name = "label1";
            label1.Size = new Size(239, 40);
            label1.TabIndex = 2;
            label1.Text = "Update Note";
            // 
            // rtxtContent
            // 
            rtxtContent.Location = new Point(243, 177);
            rtxtContent.Name = "rtxtContent";
            rtxtContent.Size = new Size(232, 120);
            rtxtContent.TabIndex = 1;
            rtxtContent.Text = "";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(243, 101);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(232, 27);
            txtTitle.TabIndex = 0;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(gboxUpdate);
            Name = "UpdateForm";
            Text = "UpdateForm";
            gboxUpdate.ResumeLayout(false);
            gboxUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxUpdate;
        private Button btnUpdate;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox rtxtContent;
        private TextBox txtTitle;
        private Label lblDate;
    }
}