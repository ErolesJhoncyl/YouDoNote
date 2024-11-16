namespace YouDoNote.Forms
{
    partial class AddForm
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
            gboxAdd = new GroupBox();
            btnSave = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rtxtContent = new RichTextBox();
            txtTitle = new TextBox();
            gboxAdd.SuspendLayout();
            SuspendLayout();
            // 
            // gboxAdd
            // 
            gboxAdd.BackColor = Color.FromArgb(255, 255, 128);
            gboxAdd.Controls.Add(btnSave);
            gboxAdd.Controls.Add(label3);
            gboxAdd.Controls.Add(label2);
            gboxAdd.Controls.Add(label1);
            gboxAdd.Controls.Add(rtxtContent);
            gboxAdd.Controls.Add(txtTitle);
            gboxAdd.Location = new Point(141, 44);
            gboxAdd.Name = "gboxAdd";
            gboxAdd.Size = new Size(528, 373);
            gboxAdd.TabIndex = 0;
            gboxAdd.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(381, 324);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 23);
            label1.Name = "label1";
            label1.Size = new Size(256, 40);
            label1.TabIndex = 2;
            label1.Text = "Add New Note";
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
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(gboxAdd);
            Name = "AddForm";
            Text = "AddForm";
            gboxAdd.ResumeLayout(false);
            gboxAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxAdd;
        private RichTextBox rtxtContent;
        private TextBox txtTitle;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
    }
}