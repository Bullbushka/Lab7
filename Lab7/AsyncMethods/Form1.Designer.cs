namespace _6AsyncMethods
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnIsComplete = new System.Windows.Forms.Button();
            this.btnCallback = new System.Windows.Forms.Button();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblIsComplete = new System.Windows.Forms.Label();
            this.lblCallback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(13, 13);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 0;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnIsComplete
            // 
            this.btnIsComplete.Location = new System.Drawing.Point(13, 43);
            this.btnIsComplete.Name = "btnIsComplete";
            this.btnIsComplete.Size = new System.Drawing.Size(75, 23);
            this.btnIsComplete.TabIndex = 1;
            this.btnIsComplete.Text = "Is Complete";
            this.btnIsComplete.UseVisualStyleBackColor = true;
            this.btnIsComplete.Click += new System.EventHandler(this.btnIsComplete_Click);
            // 
            // btnCallback
            // 
            this.btnCallback.Location = new System.Drawing.Point(13, 73);
            this.btnCallback.Name = "btnCallback";
            this.btnCallback.Size = new System.Drawing.Size(75, 23);
            this.btnCallback.TabIndex = 2;
            this.btnCallback.Text = "Callback";
            this.btnCallback.UseVisualStyleBackColor = true;
            this.btnCallback.Click += new System.EventHandler(this.btnCallback_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(106, 18);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(0, 13);
            this.lblEnd.TabIndex = 3;
            // 
            // lblIsComplete
            // 
            this.lblIsComplete.AutoSize = true;
            this.lblIsComplete.Location = new System.Drawing.Point(106, 48);
            this.lblIsComplete.Name = "lblIsComplete";
            this.lblIsComplete.Size = new System.Drawing.Size(0, 13);
            this.lblIsComplete.TabIndex = 4;
            // 
            // lblCallback
            // 
            this.lblCallback.AutoSize = true;
            this.lblCallback.Location = new System.Drawing.Point(106, 78);
            this.lblCallback.Name = "lblCallback";
            this.lblCallback.Size = new System.Drawing.Size(0, 13);
            this.lblCallback.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 123);
            this.Controls.Add(this.lblCallback);
            this.Controls.Add(this.lblIsComplete);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.btnCallback);
            this.Controls.Add(this.btnIsComplete);
            this.Controls.Add(this.btnEnd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnIsComplete;
        private System.Windows.Forms.Button btnCallback;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblIsComplete;
        private System.Windows.Forms.Label lblCallback;
    }
}

