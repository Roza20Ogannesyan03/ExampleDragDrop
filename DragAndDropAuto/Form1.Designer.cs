namespace DragAndDropAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSourseDrag = new System.Windows.Forms.Button();
            this.textBoxTargetDrop = new System.Windows.Forms.TextBox();
            this.buttonSourseDrag2 = new System.Windows.Forms.Button();
            this.pictureBoxSourseDrag2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSourseDrag = new System.Windows.Forms.PictureBox();
            this.panelTargetDrag = new System.Windows.Forms.Panel();
            this.listBoxColors = new System.Windows.Forms.ListBox();
            this.listBoxFruits = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSourseDrag2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSourseDrag)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSourseDrag
            // 
            this.buttonSourseDrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSourseDrag.Location = new System.Drawing.Point(88, 48);
            this.buttonSourseDrag.Name = "buttonSourseDrag";
            this.buttonSourseDrag.Size = new System.Drawing.Size(242, 37);
            this.buttonSourseDrag.TabIndex = 0;
            this.buttonSourseDrag.Text = "Перетащи меня";
            this.buttonSourseDrag.UseVisualStyleBackColor = true;
            this.buttonSourseDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSourseDrag_MouseDown);
            // 
            // textBoxTargetDrop
            // 
            this.textBoxTargetDrop.AllowDrop = true;
            this.textBoxTargetDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTargetDrop.Location = new System.Drawing.Point(422, 79);
            this.textBoxTargetDrop.Name = "textBoxTargetDrop";
            this.textBoxTargetDrop.Size = new System.Drawing.Size(214, 31);
            this.textBoxTargetDrop.TabIndex = 1;
            this.textBoxTargetDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxTargetDrop_DragDrop);
            this.textBoxTargetDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxTargetDrop_DragEnter);
            // 
            // buttonSourseDrag2
            // 
            this.buttonSourseDrag2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSourseDrag2.Location = new System.Drawing.Point(88, 116);
            this.buttonSourseDrag2.Name = "buttonSourseDrag2";
            this.buttonSourseDrag2.Size = new System.Drawing.Size(242, 34);
            this.buttonSourseDrag2.TabIndex = 2;
            this.buttonSourseDrag2.Text = "ТАЩИ!!";
            this.buttonSourseDrag2.UseVisualStyleBackColor = true;
            this.buttonSourseDrag2.Click += new System.EventHandler(this.buttonSourseDrag2_Click);
            // 
            // pictureBoxSourseDrag2
            // 
            this.pictureBoxSourseDrag2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSourseDrag2.Image")));
            this.pictureBoxSourseDrag2.Location = new System.Drawing.Point(277, 186);
            this.pictureBoxSourseDrag2.Name = "pictureBoxSourseDrag2";
            this.pictureBoxSourseDrag2.Size = new System.Drawing.Size(169, 158);
            this.pictureBoxSourseDrag2.TabIndex = 4;
            this.pictureBoxSourseDrag2.TabStop = false;
            this.pictureBoxSourseDrag2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSourseDrag_MouseDown);
            // 
            // pictureBoxSourseDrag
            // 
            this.pictureBoxSourseDrag.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSourseDrag.Image")));
            this.pictureBoxSourseDrag.Location = new System.Drawing.Point(34, 186);
            this.pictureBoxSourseDrag.Name = "pictureBoxSourseDrag";
            this.pictureBoxSourseDrag.Size = new System.Drawing.Size(164, 158);
            this.pictureBoxSourseDrag.TabIndex = 5;
            this.pictureBoxSourseDrag.TabStop = false;
            this.pictureBoxSourseDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSourseDrag_MouseDown);
            // 
            // panelTargetDrag
            // 
            this.panelTargetDrag.AllowDrop = true;
            this.panelTargetDrag.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTargetDrag.Location = new System.Drawing.Point(555, 186);
            this.panelTargetDrag.Name = "panelTargetDrag";
            this.panelTargetDrag.Size = new System.Drawing.Size(177, 158);
            this.panelTargetDrag.TabIndex = 6;
            this.panelTargetDrag.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTargetDrag_DragDrop);
            this.panelTargetDrag.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTargetDrag_DragEnter);
            // 
            // listBoxColors
            // 
            this.listBoxColors.AllowDrop = true;
            this.listBoxColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxColors.FormattingEnabled = true;
            this.listBoxColors.ItemHeight = 25;
            this.listBoxColors.Items.AddRange(new object[] {
            "красный",
            "синий",
            "зеленый",
            "оранж"});
            this.listBoxColors.Location = new System.Drawing.Point(71, 428);
            this.listBoxColors.Name = "listBoxColors";
            this.listBoxColors.Size = new System.Drawing.Size(127, 129);
            this.listBoxColors.TabIndex = 7;
            this.listBoxColors.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxColors_DragEnter);
            this.listBoxColors.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxColors_DragEnter);
            this.listBoxColors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxColors_MouseDown);
            // 
            // listBoxFruits
            // 
            this.listBoxFruits.AllowDrop = true;
            this.listBoxFruits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFruits.FormattingEnabled = true;
            this.listBoxFruits.ItemHeight = 25;
            this.listBoxFruits.Items.AddRange(new object[] {
            "яблоко",
            "слива",
            "киви",
            "апельсин"});
            this.listBoxFruits.Location = new System.Drawing.Point(277, 428);
            this.listBoxFruits.Name = "listBoxFruits";
            this.listBoxFruits.Size = new System.Drawing.Size(146, 129);
            this.listBoxFruits.TabIndex = 8;
            this.listBoxFruits.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxFruits_DragDrop);
            this.listBoxFruits.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxColors_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.listBoxFruits);
            this.Controls.Add(this.listBoxColors);
            this.Controls.Add(this.panelTargetDrag);
            this.Controls.Add(this.pictureBoxSourseDrag);
            this.Controls.Add(this.pictureBoxSourseDrag2);
            this.Controls.Add(this.buttonSourseDrag2);
            this.Controls.Add(this.textBoxTargetDrop);
            this.Controls.Add(this.buttonSourseDrag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSourseDrag2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSourseDrag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSourseDrag;
        private System.Windows.Forms.TextBox textBoxTargetDrop;
        private System.Windows.Forms.Button buttonSourseDrag2;
        private System.Windows.Forms.PictureBox pictureBoxSourseDrag2;
        private System.Windows.Forms.PictureBox pictureBoxSourseDrag;
        private System.Windows.Forms.Panel panelTargetDrag;
        private System.Windows.Forms.ListBox listBoxColors;
        private System.Windows.Forms.ListBox listBoxFruits;
    }
}

