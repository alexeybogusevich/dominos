﻿namespace PizzaServiceEF
{
    partial class FormPizzaService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPizzaService));
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonRestaurants = new System.Windows.Forms.Button();
            this.buttonComment = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrder.ForeColor = System.Drawing.Color.White;
            this.buttonOrder.Location = new System.Drawing.Point(-2, 155);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(264, 56);
            this.buttonOrder.TabIndex = 0;
            this.buttonOrder.Text = "Зробити замовлення";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonRestaurants
            // 
            this.buttonRestaurants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRestaurants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestaurants.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRestaurants.ForeColor = System.Drawing.Color.White;
            this.buttonRestaurants.Location = new System.Drawing.Point(-1, 248);
            this.buttonRestaurants.Name = "buttonRestaurants";
            this.buttonRestaurants.Size = new System.Drawing.Size(263, 56);
            this.buttonRestaurants.TabIndex = 1;
            this.buttonRestaurants.Text = "Ресторани";
            this.buttonRestaurants.UseVisualStyleBackColor = false;
            // 
            // buttonComment
            // 
            this.buttonComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonComment.ForeColor = System.Drawing.Color.White;
            this.buttonComment.Location = new System.Drawing.Point(-1, 337);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(263, 56);
            this.buttonComment.TabIndex = 2;
            this.buttonComment.Text = "Залишити відгук";
            this.buttonComment.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(128)))), ((int)(((byte)(191)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(683, 337);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(263, 56);
            this.button5.TabIndex = 4;
            this.button5.Text = "Увійти";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // FormPizzaService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.buttonRestaurants);
            this.Controls.Add(this.buttonOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPizzaService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domino\'s Pizza";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonRestaurants;
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.Button button5;
    }
}

